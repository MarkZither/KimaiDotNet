# IO.Swagger.Api.TimesheetApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiTimesheetsActiveGet**](TimesheetApi.md#apitimesheetsactiveget) | **GET** /api/timesheets/active | Returns the collection of active timesheet records
[**ApiTimesheetsGet**](TimesheetApi.md#apitimesheetsget) | **GET** /api/timesheets | Returns a collection of timesheet records
[**ApiTimesheetsIdDelete**](TimesheetApi.md#apitimesheetsiddelete) | **DELETE** /api/timesheets/{id} | Delete an existing timesheet record
[**ApiTimesheetsIdDuplicatePatch**](TimesheetApi.md#apitimesheetsidduplicatepatch) | **PATCH** /api/timesheets/{id}/duplicate | Duplicates an existing timesheet record
[**ApiTimesheetsIdExportPatch**](TimesheetApi.md#apitimesheetsidexportpatch) | **PATCH** /api/timesheets/{id}/export | Switch the export state of a timesheet record to (un-)lock it
[**ApiTimesheetsIdGet**](TimesheetApi.md#apitimesheetsidget) | **GET** /api/timesheets/{id} | Returns one timesheet record
[**ApiTimesheetsIdMetaPatch**](TimesheetApi.md#apitimesheetsidmetapatch) | **PATCH** /api/timesheets/{id}/meta | Sets the value of a meta-field for an existing timesheet.
[**ApiTimesheetsIdPatch**](TimesheetApi.md#apitimesheetsidpatch) | **PATCH** /api/timesheets/{id} | Update an existing timesheet record
[**ApiTimesheetsIdRestartPatch**](TimesheetApi.md#apitimesheetsidrestartpatch) | **PATCH** /api/timesheets/{id}/restart | Restarts a previously stopped timesheet record for the current user
[**ApiTimesheetsIdStopPatch**](TimesheetApi.md#apitimesheetsidstoppatch) | **PATCH** /api/timesheets/{id}/stop | Stops an active timesheet record
[**ApiTimesheetsPost**](TimesheetApi.md#apitimesheetspost) | **POST** /api/timesheets | Creates a new timesheet record
[**ApiTimesheetsRecentGet**](TimesheetApi.md#apitimesheetsrecentget) | **GET** /api/timesheets/recent | Returns the collection of recent user activities


<a name="apitimesheetsactiveget"></a>
# **ApiTimesheetsActiveGet**
> List<TimesheetCollectionExpanded> ApiTimesheetsActiveGet ()

Returns the collection of active timesheet records

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiTimesheetsActiveGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: apiToken
            Configuration.Default.ApiKey.Add("X-AUTH-TOKEN", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-AUTH-TOKEN", "Bearer");
            // Configure API key authorization: apiUser
            Configuration.Default.ApiKey.Add("X-AUTH-USER", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-AUTH-USER", "Bearer");

            var apiInstance = new TimesheetApi();

            try
            {
                // Returns the collection of active timesheet records
                List&lt;TimesheetCollectionExpanded&gt; result = apiInstance.ApiTimesheetsActiveGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TimesheetApi.ApiTimesheetsActiveGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<TimesheetCollectionExpanded>**](TimesheetCollectionExpanded.md)

### Authorization

[apiToken](../README.md#apiToken), [apiUser](../README.md#apiUser)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apitimesheetsget"></a>
# **ApiTimesheetsGet**
> List<TimesheetCollection> ApiTimesheetsGet (string user, string customer, string customers, string project, string projects, string activity, string activities, string page, string size, string tags, string orderBy, string order, string begin, string end, string exported, string active, string full, string term, string modifiedAfter)

Returns a collection of timesheet records

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiTimesheetsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: apiToken
            Configuration.Default.ApiKey.Add("X-AUTH-TOKEN", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-AUTH-TOKEN", "Bearer");
            // Configure API key authorization: apiUser
            Configuration.Default.ApiKey.Add("X-AUTH-USER", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-AUTH-USER", "Bearer");

            var apiInstance = new TimesheetApi();
            var user = user_example;  // string | User ID to filter timesheets. Needs permission 'view_other_timesheet', pass 'all' to fetch data for all user (default: current user) (optional) 
            var customer = customer_example;  // string | DEPRECATED: Customer ID to filter timesheets (will be removed with 2.0) (optional) 
            var customers = customers_example;  // string | Comma separated list of customer IDs to filter timesheets (optional) 
            var project = project_example;  // string | DEPRECATED: Project ID to filter timesheets (will be removed with 2.0) (optional) 
            var projects = projects_example;  // string | Comma separated list of project IDs to filter timesheets (optional) 
            var activity = activity_example;  // string | DEPRECATED: Activity ID to filter timesheets (will be removed with 2.0) (optional) 
            var activities = activities_example;  // string | Comma separated list of activity IDs to filter timesheets (optional) 
            var page = page_example;  // string | The page to display, renders a 404 if not found (default: 1) (optional) 
            var size = size_example;  // string | The amount of entries for each page (default: 50) (optional) 
            var tags = tags_example;  // string | The name of tags which are in the datasets (optional) 
            var orderBy = orderBy_example;  // string | The field by which results will be ordered. Allowed values: id, begin, end, rate (default: begin) (optional) 
            var order = order_example;  // string | The result order. Allowed values: ASC, DESC (default: DESC) (optional) 
            var begin = begin_example;  // string | Only records after this date will be included (format: HTML5) (optional) 
            var end = end_example;  // string | Only records before this date will be included (format: HTML5) (optional) 
            var exported = exported_example;  // string | Use this flag if you want to filter for export state. Allowed values: 0=not exported, 1=exported (default: all) (optional) 
            var active = active_example;  // string | Filter for running/active records. Allowed values: 0=stopped, 1=active (default: all) (optional) 
            var full = full_example;  // string | Allows to fetch fully serialized objects including subresources. Allowed values: true (default: false) (optional) 
            var term = term_example;  // string | Free search term (optional) 
            var modifiedAfter = modifiedAfter_example;  // string | Only records changed after this date will be included (format: HTML5). Available since Kimai 1.10 and works only for records that were created/updated since then. (optional) 

            try
            {
                // Returns a collection of timesheet records
                List&lt;TimesheetCollection&gt; result = apiInstance.ApiTimesheetsGet(user, customer, customers, project, projects, activity, activities, page, size, tags, orderBy, order, begin, end, exported, active, full, term, modifiedAfter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TimesheetApi.ApiTimesheetsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **user** | **string**| User ID to filter timesheets. Needs permission &#39;view_other_timesheet&#39;, pass &#39;all&#39; to fetch data for all user (default: current user) | [optional] 
 **customer** | **string**| DEPRECATED: Customer ID to filter timesheets (will be removed with 2.0) | [optional] 
 **customers** | **string**| Comma separated list of customer IDs to filter timesheets | [optional] 
 **project** | **string**| DEPRECATED: Project ID to filter timesheets (will be removed with 2.0) | [optional] 
 **projects** | **string**| Comma separated list of project IDs to filter timesheets | [optional] 
 **activity** | **string**| DEPRECATED: Activity ID to filter timesheets (will be removed with 2.0) | [optional] 
 **activities** | **string**| Comma separated list of activity IDs to filter timesheets | [optional] 
 **page** | **string**| The page to display, renders a 404 if not found (default: 1) | [optional] 
 **size** | **string**| The amount of entries for each page (default: 50) | [optional] 
 **tags** | **string**| The name of tags which are in the datasets | [optional] 
 **orderBy** | **string**| The field by which results will be ordered. Allowed values: id, begin, end, rate (default: begin) | [optional] 
 **order** | **string**| The result order. Allowed values: ASC, DESC (default: DESC) | [optional] 
 **begin** | **string**| Only records after this date will be included (format: HTML5) | [optional] 
 **end** | **string**| Only records before this date will be included (format: HTML5) | [optional] 
 **exported** | **string**| Use this flag if you want to filter for export state. Allowed values: 0&#x3D;not exported, 1&#x3D;exported (default: all) | [optional] 
 **active** | **string**| Filter for running/active records. Allowed values: 0&#x3D;stopped, 1&#x3D;active (default: all) | [optional] 
 **full** | **string**| Allows to fetch fully serialized objects including subresources. Allowed values: true (default: false) | [optional] 
 **term** | **string**| Free search term | [optional] 
 **modifiedAfter** | **string**| Only records changed after this date will be included (format: HTML5). Available since Kimai 1.10 and works only for records that were created/updated since then. | [optional] 

### Return type

[**List<TimesheetCollection>**](TimesheetCollection.md)

### Authorization

[apiToken](../README.md#apiToken), [apiUser](../README.md#apiUser)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apitimesheetsiddelete"></a>
# **ApiTimesheetsIdDelete**
> void ApiTimesheetsIdDelete (int? id)

Delete an existing timesheet record

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiTimesheetsIdDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: apiToken
            Configuration.Default.ApiKey.Add("X-AUTH-TOKEN", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-AUTH-TOKEN", "Bearer");
            // Configure API key authorization: apiUser
            Configuration.Default.ApiKey.Add("X-AUTH-USER", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-AUTH-USER", "Bearer");

            var apiInstance = new TimesheetApi();
            var id = 56;  // int? | Timesheet record ID to delete

            try
            {
                // Delete an existing timesheet record
                apiInstance.ApiTimesheetsIdDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TimesheetApi.ApiTimesheetsIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Timesheet record ID to delete | 

### Return type

void (empty response body)

### Authorization

[apiToken](../README.md#apiToken), [apiUser](../README.md#apiUser)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apitimesheetsidduplicatepatch"></a>
# **ApiTimesheetsIdDuplicatePatch**
> TimesheetEntity ApiTimesheetsIdDuplicatePatch (int? id)

Duplicates an existing timesheet record

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiTimesheetsIdDuplicatePatchExample
    {
        public void main()
        {
            
            // Configure API key authorization: apiToken
            Configuration.Default.ApiKey.Add("X-AUTH-TOKEN", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-AUTH-TOKEN", "Bearer");
            // Configure API key authorization: apiUser
            Configuration.Default.ApiKey.Add("X-AUTH-USER", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-AUTH-USER", "Bearer");

            var apiInstance = new TimesheetApi();
            var id = 56;  // int? | Timesheet record ID to duplicate

            try
            {
                // Duplicates an existing timesheet record
                TimesheetEntity result = apiInstance.ApiTimesheetsIdDuplicatePatch(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TimesheetApi.ApiTimesheetsIdDuplicatePatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Timesheet record ID to duplicate | 

### Return type

[**TimesheetEntity**](TimesheetEntity.md)

### Authorization

[apiToken](../README.md#apiToken), [apiUser](../README.md#apiUser)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apitimesheetsidexportpatch"></a>
# **ApiTimesheetsIdExportPatch**
> TimesheetEntity ApiTimesheetsIdExportPatch (int? id)

Switch the export state of a timesheet record to (un-)lock it

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiTimesheetsIdExportPatchExample
    {
        public void main()
        {
            
            // Configure API key authorization: apiToken
            Configuration.Default.ApiKey.Add("X-AUTH-TOKEN", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-AUTH-TOKEN", "Bearer");
            // Configure API key authorization: apiUser
            Configuration.Default.ApiKey.Add("X-AUTH-USER", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-AUTH-USER", "Bearer");

            var apiInstance = new TimesheetApi();
            var id = 56;  // int? | Timesheet record ID to switch export state

            try
            {
                // Switch the export state of a timesheet record to (un-)lock it
                TimesheetEntity result = apiInstance.ApiTimesheetsIdExportPatch(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TimesheetApi.ApiTimesheetsIdExportPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Timesheet record ID to switch export state | 

### Return type

[**TimesheetEntity**](TimesheetEntity.md)

### Authorization

[apiToken](../README.md#apiToken), [apiUser](../README.md#apiUser)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apitimesheetsidget"></a>
# **ApiTimesheetsIdGet**
> TimesheetEntity ApiTimesheetsIdGet (int? id)

Returns one timesheet record

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiTimesheetsIdGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: apiToken
            Configuration.Default.ApiKey.Add("X-AUTH-TOKEN", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-AUTH-TOKEN", "Bearer");
            // Configure API key authorization: apiUser
            Configuration.Default.ApiKey.Add("X-AUTH-USER", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-AUTH-USER", "Bearer");

            var apiInstance = new TimesheetApi();
            var id = 56;  // int? | Timesheet record ID to fetch

            try
            {
                // Returns one timesheet record
                TimesheetEntity result = apiInstance.ApiTimesheetsIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TimesheetApi.ApiTimesheetsIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Timesheet record ID to fetch | 

### Return type

[**TimesheetEntity**](TimesheetEntity.md)

### Authorization

[apiToken](../README.md#apiToken), [apiUser](../README.md#apiUser)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apitimesheetsidmetapatch"></a>
# **ApiTimesheetsIdMetaPatch**
> TimesheetEntity ApiTimesheetsIdMetaPatch (int? id, Body4 body)

Sets the value of a meta-field for an existing timesheet.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiTimesheetsIdMetaPatchExample
    {
        public void main()
        {
            
            // Configure API key authorization: apiToken
            Configuration.Default.ApiKey.Add("X-AUTH-TOKEN", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-AUTH-TOKEN", "Bearer");
            // Configure API key authorization: apiUser
            Configuration.Default.ApiKey.Add("X-AUTH-USER", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-AUTH-USER", "Bearer");

            var apiInstance = new TimesheetApi();
            var id = 56;  // int? | Timesheet record ID to set the meta-field value for
            var body = new Body4(); // Body4 |  (optional) 

            try
            {
                // Sets the value of a meta-field for an existing timesheet.
                TimesheetEntity result = apiInstance.ApiTimesheetsIdMetaPatch(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TimesheetApi.ApiTimesheetsIdMetaPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Timesheet record ID to set the meta-field value for | 
 **body** | [**Body4**](Body4.md)|  | [optional] 

### Return type

[**TimesheetEntity**](TimesheetEntity.md)

### Authorization

[apiToken](../README.md#apiToken), [apiUser](../README.md#apiUser)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apitimesheetsidpatch"></a>
# **ApiTimesheetsIdPatch**
> TimesheetEntity ApiTimesheetsIdPatch (TimesheetEditForm body, int? id)

Update an existing timesheet record

Update an existing timesheet record, you can pass all or just a subset of the attributes.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiTimesheetsIdPatchExample
    {
        public void main()
        {
            
            // Configure API key authorization: apiToken
            Configuration.Default.ApiKey.Add("X-AUTH-TOKEN", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-AUTH-TOKEN", "Bearer");
            // Configure API key authorization: apiUser
            Configuration.Default.ApiKey.Add("X-AUTH-USER", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-AUTH-USER", "Bearer");

            var apiInstance = new TimesheetApi();
            var body = new TimesheetEditForm(); // TimesheetEditForm | 
            var id = 56;  // int? | Timesheet record ID to update

            try
            {
                // Update an existing timesheet record
                TimesheetEntity result = apiInstance.ApiTimesheetsIdPatch(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TimesheetApi.ApiTimesheetsIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TimesheetEditForm**](TimesheetEditForm.md)|  | 
 **id** | **int?**| Timesheet record ID to update | 

### Return type

[**TimesheetEntity**](TimesheetEntity.md)

### Authorization

[apiToken](../README.md#apiToken), [apiUser](../README.md#apiUser)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apitimesheetsidrestartpatch"></a>
# **ApiTimesheetsIdRestartPatch**
> TimesheetEntity ApiTimesheetsIdRestartPatch (int? id, Body3 body)

Restarts a previously stopped timesheet record for the current user

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiTimesheetsIdRestartPatchExample
    {
        public void main()
        {
            
            // Configure API key authorization: apiToken
            Configuration.Default.ApiKey.Add("X-AUTH-TOKEN", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-AUTH-TOKEN", "Bearer");
            // Configure API key authorization: apiUser
            Configuration.Default.ApiKey.Add("X-AUTH-USER", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-AUTH-USER", "Bearer");

            var apiInstance = new TimesheetApi();
            var id = 56;  // int? | Timesheet record ID to restart
            var body = new Body3(); // Body3 |  (optional) 

            try
            {
                // Restarts a previously stopped timesheet record for the current user
                TimesheetEntity result = apiInstance.ApiTimesheetsIdRestartPatch(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TimesheetApi.ApiTimesheetsIdRestartPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Timesheet record ID to restart | 
 **body** | [**Body3**](Body3.md)|  | [optional] 

### Return type

[**TimesheetEntity**](TimesheetEntity.md)

### Authorization

[apiToken](../README.md#apiToken), [apiUser](../README.md#apiUser)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apitimesheetsidstoppatch"></a>
# **ApiTimesheetsIdStopPatch**
> TimesheetEntity ApiTimesheetsIdStopPatch (int? id)

Stops an active timesheet record

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiTimesheetsIdStopPatchExample
    {
        public void main()
        {
            
            // Configure API key authorization: apiToken
            Configuration.Default.ApiKey.Add("X-AUTH-TOKEN", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-AUTH-TOKEN", "Bearer");
            // Configure API key authorization: apiUser
            Configuration.Default.ApiKey.Add("X-AUTH-USER", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-AUTH-USER", "Bearer");

            var apiInstance = new TimesheetApi();
            var id = 56;  // int? | Timesheet record ID to stop

            try
            {
                // Stops an active timesheet record
                TimesheetEntity result = apiInstance.ApiTimesheetsIdStopPatch(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TimesheetApi.ApiTimesheetsIdStopPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Timesheet record ID to stop | 

### Return type

[**TimesheetEntity**](TimesheetEntity.md)

### Authorization

[apiToken](../README.md#apiToken), [apiUser](../README.md#apiUser)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apitimesheetspost"></a>
# **ApiTimesheetsPost**
> TimesheetEntity ApiTimesheetsPost (TimesheetEditForm body, string full)

Creates a new timesheet record

Creates a new timesheet record for the current user and returns it afterwards.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiTimesheetsPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: apiToken
            Configuration.Default.ApiKey.Add("X-AUTH-TOKEN", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-AUTH-TOKEN", "Bearer");
            // Configure API key authorization: apiUser
            Configuration.Default.ApiKey.Add("X-AUTH-USER", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-AUTH-USER", "Bearer");

            var apiInstance = new TimesheetApi();
            var body = new TimesheetEditForm(); // TimesheetEditForm | 
            var full = full_example;  // string | Allows to fetch fully serialized objects including subresources (TimesheetEntityExpanded). Allowed values: true (default: false) (optional) 

            try
            {
                // Creates a new timesheet record
                TimesheetEntity result = apiInstance.ApiTimesheetsPost(body, full);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TimesheetApi.ApiTimesheetsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TimesheetEditForm**](TimesheetEditForm.md)|  | 
 **full** | **string**| Allows to fetch fully serialized objects including subresources (TimesheetEntityExpanded). Allowed values: true (default: false) | [optional] 

### Return type

[**TimesheetEntity**](TimesheetEntity.md)

### Authorization

[apiToken](../README.md#apiToken), [apiUser](../README.md#apiUser)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apitimesheetsrecentget"></a>
# **ApiTimesheetsRecentGet**
> List<TimesheetCollectionExpanded> ApiTimesheetsRecentGet (string user, string begin, string size)

Returns the collection of recent user activities

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiTimesheetsRecentGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: apiToken
            Configuration.Default.ApiKey.Add("X-AUTH-TOKEN", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-AUTH-TOKEN", "Bearer");
            // Configure API key authorization: apiUser
            Configuration.Default.ApiKey.Add("X-AUTH-USER", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-AUTH-USER", "Bearer");

            var apiInstance = new TimesheetApi();
            var user = user_example;  // string | User ID to filter timesheets. Needs permission 'view_other_timesheet', pass 'all' to fetch data for all user (default: current user) (optional) 
            var begin = begin_example;  // string | Only records after this date will be included. Default: today - 1 year (format: HTML5) (optional) 
            var size = size_example;  // string | The amount of entries (default: 10) (optional) 

            try
            {
                // Returns the collection of recent user activities
                List&lt;TimesheetCollectionExpanded&gt; result = apiInstance.ApiTimesheetsRecentGet(user, begin, size);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TimesheetApi.ApiTimesheetsRecentGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **user** | **string**| User ID to filter timesheets. Needs permission &#39;view_other_timesheet&#39;, pass &#39;all&#39; to fetch data for all user (default: current user) | [optional] 
 **begin** | **string**| Only records after this date will be included. Default: today - 1 year (format: HTML5) | [optional] 
 **size** | **string**| The amount of entries (default: 10) | [optional] 

### Return type

[**List<TimesheetCollectionExpanded>**](TimesheetCollectionExpanded.md)

### Authorization

[apiToken](../README.md#apiToken), [apiUser](../README.md#apiUser)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

