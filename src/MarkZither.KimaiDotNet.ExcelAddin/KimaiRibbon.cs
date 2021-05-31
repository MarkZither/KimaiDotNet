﻿using MarkZither.KimaiDotNet.ExcelAddin.Services;
using MarkZither.KimaiDotNet.ExcelAddin.Sheets;
using MarkZither.KimaiDotNet.Models;

using Microsoft.Extensions.Logging;
using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Tools.Ribbon;

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Deployment.Application;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Excel = Microsoft.Office.Interop.Excel;

namespace MarkZither.KimaiDotNet.ExcelAddin
{
    [VstoUnhandledException]
    public partial class KimaiRibbon
    {
        private string GetVersionNumber()
        {
            return ApplicationDeployment.IsNetworkDeployed
                ? ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString()
                : Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }
        #region events
        private void KimaiRibbon_Load(object sender, RibbonUIEventArgs e)
        {
            lblAddinVersionNo.Label = GetVersionNumber();
        }
        private void tglApiCreds_Click(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisAddIn.TaskPane.Visible = ((RibbonToggleButton)sender).Checked;
        }
        private async void btnConnect_Click(object sender, RibbonControlEventArgs e)
        {
            var mockWorksheet =
                Globals.ThisAddIn.Application.Worksheets.Cast<Worksheet>()
                       .SingleOrDefault(w => string.Equals(w.Name, "Mock", StringComparison.OrdinalIgnoreCase));

            IKimaiServices services;
            try
            {
                if (string.Equals(ConfigurationManager.AppSettings["UseMocks"], "true", StringComparison.OrdinalIgnoreCase)
                    || mockWorksheet is Worksheet)
                {
                    services = new MockKimaiServices();
                }
                else
                {
                    services = new KimaiServices();
                }
                var version = await services.GetVersion().ConfigureAwait(false);
                lblVersionNo.Label = version.VersionProperty;
                var user = await services.GetCurrentUser().ConfigureAwait(false);
                Globals.ThisAddIn.CurrentUser = user;
                btnSync.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ExcelAddin.Globals.ThisAddIn.Logger.LogWarning($"Could not connect to Kimai server. {ex.Message}", ex);
            }
        }
        private async void btnSync_Click(object sender, RibbonControlEventArgs e)
        {
            await Sheets.Sheet1.Instance.SyncTimesheetsAsync().ConfigureAwait(false);
        }
        private void btnSettings_Click(object sender, RibbonControlEventArgs e)
        {
            // Method intentionally left empty.
        }
        private void btnCalendar_Click(object sender, RibbonControlEventArgs e)
        {
            // https://owa.youdomain.com/EWS/Exchange.asmx";
            string ewsUrl = ConfigurationManager.AppSettings.Get("EWS_URL");
            string mbx = ConfigurationManager.AppSettings.Get("EWS_MBX");
            string password = ConfigurationManager.AppSettings.Get("EWS_PASSWORD");
            var ewsservice = new Microsoft.Exchange.WebServices.Data.ExchangeService
            {
                Credentials = new System.Net.NetworkCredential(mbx, password),
                Url = new Uri(ewsUrl)
            };
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls; //DevSkim: ignore DS440020,DS440000,DS144436
            // Bind the Inbox folder to the service object.
            Microsoft.Exchange.WebServices.Data.Folder inbox =
                Microsoft.Exchange.WebServices.Data.Folder.Bind(ewsservice,
                Microsoft.Exchange.WebServices.Data.WellKnownFolderName.Inbox);

            Microsoft.Exchange.WebServices.Data.ItemView view = new Microsoft.Exchange.WebServices.Data.ItemView(10);
            Microsoft.Exchange.WebServices.Data.ItemView iv = new Microsoft.Exchange.WebServices.Data.ItemView(10);

            Microsoft.Exchange.WebServices.Data.FindItemsResults<Microsoft.Exchange.WebServices.Data.Item> findResults =
                ewsservice.FindItems(new Microsoft.Exchange.WebServices.Data.FolderId(
                    Microsoft.Exchange.WebServices.Data.WellKnownFolderName.Inbox),"System.Message.DateReceived:01/01/2021..01/03/2021", iv);

            //Microsoft.Exchange.WebServices.Data.FindItemsResults<Microsoft.Exchange.WebServices.Data.Item> findResults = 
              //  ewsservice.FindItems("System.Message.DateReceived:01/01/2021..01/03/2021", iv);

            foreach (Microsoft.Exchange.WebServices.Data.Item item in findResults)
            {
                string x = "";
            }

            //https://blog.matrixpost.net/create-a-c-console-app-net-framework-to-export-mail-attachments-from-an-exchange-mailbox/
            Microsoft.Exchange.WebServices.Data.ExchangeService service = 
                new Microsoft.Exchange.WebServices.Data.ExchangeService(
                    Microsoft.Exchange.WebServices.Data.ExchangeVersion.Exchange2013_SP1);
            service.Credentials = new Microsoft.Exchange.WebServices.Data.WebCredentials(mbx
                , password);
            //service.UseDefaultCredentials = true;
            //service.
            service.Url = new Uri(ewsUrl);
            Microsoft.Exchange.WebServices.Data.EmailMessage email = new Microsoft.Exchange.WebServices.Data.EmailMessage(service);
            email.ToRecipients.Add("somebody@test.com");
            email.Subject = "HelloWorld";
            email.Body = new Microsoft.Exchange.WebServices.Data.MessageBody("This is the first email I've sent by using the EWS Managed API.");

            try
            {
                //email.Send();

                // Initialize values for the start and end times, and the number of appointments to retrieve.
                DateTime startDate = DateTime.Now;
                DateTime endDate = startDate.AddDays(30);
                const int NUM_APPTS = 5;
                // Initialize the calendar folder object with only the folder ID. 
                Microsoft.Exchange.WebServices.Data.CalendarFolder calendar = Microsoft.Exchange.WebServices.Data.CalendarFolder.Bind(service, Microsoft.Exchange.WebServices.Data.WellKnownFolderName.Calendar, new Microsoft.Exchange.WebServices.Data.PropertySet());
                // Set the start and end time and number of appointments to retrieve.
                Microsoft.Exchange.WebServices.Data.CalendarView cView = new Microsoft.Exchange.WebServices.Data.CalendarView(startDate, endDate, NUM_APPTS);
                // Limit the properties returned to the appointment's subject, start time, and end time.
                cView.PropertySet = new Microsoft.Exchange.WebServices.Data.PropertySet(Microsoft.Exchange.WebServices.Data.AppointmentSchema.Subject, Microsoft.Exchange.WebServices.Data.AppointmentSchema.Start, Microsoft.Exchange.WebServices.Data.AppointmentSchema.End);
                // Retrieve a collection of appointments by using the calendar view.
                Microsoft.Exchange.WebServices.Data.FindItemsResults<Microsoft.Exchange.WebServices.Data.Appointment> appointments = calendar.FindAppointments(cView);
                Console.WriteLine("\nThe first " + NUM_APPTS + " appointments on your calendar from " + startDate.Date.ToShortDateString() +
                                  " to " + endDate.Date.ToShortDateString() + " are: \n");

                foreach (Microsoft.Exchange.WebServices.Data.Appointment a in appointments)
                {
                    Console.Write("Subject: " + a.Subject.ToString() + " ");
                    Console.Write("Start: " + a.Start.ToString() + " ");
                    Console.Write("End: " + a.End.ToString());
                    Console.WriteLine();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Coming Soon!");
            ExcelAddin.Globals.ThisAddIn.Logger.LogInformation("Calendar coming soon");
        }

        private static bool RedirectionUrlValidationCallback(string redirectionUrl)
        {
            // The default for the validation callback is to reject the URL.
            bool result = false;
            Uri redirectionUri = new Uri(redirectionUrl);
            // Validate the contents of the redirection URL. In this simple validation
            // callback, the redirection URL is considered valid if it is using HTTPS
            // to encrypt the authentication credentials. 
            if (redirectionUri.Scheme == "https")
            {
                result = true;
            }
            return result;
        }

        private void btnSyncPremuim_Click(object sender, RibbonControlEventArgs e)
        {
            MessageBox.Show("This is a premium feature please consider sponsoring the project.");
            ExcelAddin.Globals.ThisAddIn.Logger.LogInformation("Premium sync");
        }
        private void btnInfo_Click(object sender, RibbonControlEventArgs e)
        {
            //https://stackoverflow.com/questions/19458721/cant-type-on-a-wpf-window-in-a-vsto-addin
            AboutWindow aboutWindow = new AboutWindow();
            aboutWindow.Show();
            if (true)
            {
                throw new InvalidCastException("test exception");
            }
        }
        #endregion

        private void btnBug_Click(object sender, RibbonControlEventArgs e)
        {
#pragma warning disable RCS1192 // Unnecessary usage of verbatim string literal.
#pragma warning disable S1075 // URIs should not be hardcoded
            Process.Start(@"https://github.com/MarkZither/KimaiDotNet/issues");
#pragma warning restore S1075 // URIs should not be hardcoded
#pragma warning restore RCS1192 // Unnecessary usage of verbatim string literal.
        }

        private void btnHelp_Click(object sender, RibbonControlEventArgs e)
        {
#pragma warning disable RCS1192 // Unnecessary usage of verbatim string literal.
#pragma warning disable S1075 // URIs should not be hardcoded
            Process.Start(@"https://github.com/MarkZither/KimaiDotNet/discussions");
#pragma warning restore S1075 // URIs should not be hardcoded
#pragma warning restore RCS1192 // Unnecessary usage of verbatim string literal.
        }
    }
}
