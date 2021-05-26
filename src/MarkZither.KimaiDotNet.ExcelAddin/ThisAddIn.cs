﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;
using System.IO.IsolatedStorage;
using System.IO;
using System.Xml.Serialization;
using MarkZither.KimaiDotNet.ExcelAddin.Properties;
using MarkZither.KimaiDotNet.Models;
using System.Diagnostics;

namespace MarkZither.KimaiDotNet.ExcelAddin
{
    public partial class ThisAddIn
    {
        //https://docs.microsoft.com/en-us/visualstudio/vsto/how-to-create-and-modify-custom-document-properties?redirectedfrom=MSDN&view=vs-2019
        #region Properties
        public string ApiUrl { get; set; }
        public string ApiUsername { get; set; }
        public string ApiPassword { get; set; }
        public IList<ProjectCollection> Projects { get; set; }
        public IList<ActivityCollection> Activities { get; set; }
        public IList<CustomerCollection> Customers { get; set; }
        public IList<TimesheetCollection> Timesheets { get; set; }
        //https://docs.microsoft.com/en-us/visualstudio/vsto/walkthrough-synchronizing-a-custom-task-pane-with-a-ribbon-button?view=vs-2019
        private Microsoft.Office.Tools.CustomTaskPane apiCredentialsTaskPane;
        public Microsoft.Office.Tools.CustomTaskPane TaskPane
        {
            get
            {
                return apiCredentialsTaskPane;
            }
        }

        #endregion

        public ProjectCollection GetProjectById(int id)
        {
            var project = Projects.SingleOrDefault(x => x.Id.Equals(id));
            if(project == default(ProjectCollection))
            {
                Debug.Write($"Id not found: {id}");
            }
            return project;
        }

        public ActivityCollection GetActivityById(int id)
        {
            var activity = Activities.SingleOrDefault(x => x.Id.Equals(id));
            if (activity == default(ActivityCollection))
            {
                Debug.Write($"Id not found: {id}");
            }
            return activity;
        }

        public ProjectCollection GetProjectByName(string name)
        {
            var project = Projects.SingleOrDefault(x => x.Name.Equals(name));
            if (project == default(ProjectCollection))
            {
                Debug.WriteLine($"Id not found: {name}");
            }
            return project;
        }

        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            var myUserControl1 = new ucApiCredentials();
            apiCredentialsTaskPane = this.CustomTaskPanes.Add(myUserControl1, "API Credentials");
            apiCredentialsTaskPane.VisibleChanged +=
                new EventHandler(myCustomTaskPane_VisibleChanged);

            try
            {
                Globals.ThisAddIn.ApiUrl = Settings.Default.ApiUrl;
                Globals.ThisAddIn.ApiUsername = Settings.Default.ApiUsername;
            }
            catch(Exception ex)
            {
                //there has to be a cleaner way
            }
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
            // https://docs.microsoft.com/en-us/dotnet/desktop/winforms/advanced/how-to-write-user-settings-at-run-time-with-csharp?view=netframeworkdesktop-4.8
            Settings.Default.ApiUrl = Globals.ThisAddIn.ApiUrl;
            Settings.Default.ApiUsername = Globals.ThisAddIn.ApiUsername;
            Settings.Default.Save();
        }

        private void myCustomTaskPane_VisibleChanged(object sender, System.EventArgs e)
        {
            Globals.Ribbons.KimaiRibbon.tglApiCreds.Checked =
                apiCredentialsTaskPane.Visible;
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }

        #endregion
    }
}
