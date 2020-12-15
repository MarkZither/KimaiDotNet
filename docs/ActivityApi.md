# IO.Swagger.Api.ActivityApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiActivitiesGet**](ActivityApi.md#apiactivitiesget) | **GET** /api/activities | Returns a collection of activities
[**ApiActivitiesIdGet**](ActivityApi.md#apiactivitiesidget) | **GET** /api/activities/{id} | Returns one activity
[**ApiActivitiesIdMetaPatch**](ActivityApi.md#apiactivitiesidmetapatch) | **PATCH** /api/activities/{id}/meta | Sets the value of a meta-field for an existing activity
[**ApiActivitiesIdPatch**](ActivityApi.md#apiactivitiesidpatch) | **PATCH** /api/activities/{id} | Update an existing activity
[**ApiActivitiesIdRatesGet**](ActivityApi.md#apiactivitiesidratesget) | **GET** /api/activities/{id}/rates | Returns a collection of all rates for one activity
[**ApiActivitiesIdRatesPost**](ActivityApi.md#apiactivitiesidratespost) | **POST** /api/activities/{id}/rates | Adds a new rate to an activity
[**ApiActivitiesIdRatesRateIdDelete**](ActivityApi.md#apiactivitiesidratesrateiddelete) | **DELETE** /api/activities/{id}/rates/{rateId} | Deletes one rate for an activity
[**ApiActivitiesPost**](ActivityApi.md#apiactivitiespost) | **POST** /api/activities | Creates a new activity


<a name="apiactivitiesget"></a>
# **ApiActivitiesGet**
> List<ActivityCollection> ApiActivitiesGet (string project, string projects, string visible, string globals, string globalsFirst, string orderBy, string order, string term)

Returns a collection of activities

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiActivitiesGetExample
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

            var apiInstance = new ActivityApi();
            var project = project_example;  // string | Project ID to filter activities (optional) 
            var projects = projects_example;  // string | Comma separated list of project IDs to filter activities (optional) 
            var visible = visible_example;  // string | Visibility status to filter activities. Allowed values: 1=visible, 2=hidden, 3=all (default: 1) (optional) 
            var globals = globals_example;  // string | Use if you want to fetch only global activities. Allowed values: true (default: false) (optional) 
            var globalsFirst = globalsFirst_example;  // string | Deprecated parameter, value is not used any more (optional) 
            var orderBy = orderBy_example;  // string | The field by which results will be ordered. Allowed values: id, name, project (default: name) (optional) 
            var order = order_example;  // string | The result order. Allowed values: ASC, DESC (default: ASC) (optional) 
            var term = term_example;  // string | Free search term (optional) 

            try
            {
                // Returns a collection of activities
                List&lt;ActivityCollection&gt; result = apiInstance.ApiActivitiesGet(project, projects, visible, globals, globalsFirst, orderBy, order, term);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActivityApi.ApiActivitiesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **project** | **string**| Project ID to filter activities | [optional] 
 **projects** | **string**| Comma separated list of project IDs to filter activities | [optional] 
 **visible** | **string**| Visibility status to filter activities. Allowed values: 1&#x3D;visible, 2&#x3D;hidden, 3&#x3D;all (default: 1) | [optional] 
 **globals** | **string**| Use if you want to fetch only global activities. Allowed values: true (default: false) | [optional] 
 **globalsFirst** | **string**| Deprecated parameter, value is not used any more | [optional] 
 **orderBy** | **string**| The field by which results will be ordered. Allowed values: id, name, project (default: name) | [optional] 
 **order** | **string**| The result order. Allowed values: ASC, DESC (default: ASC) | [optional] 
 **term** | **string**| Free search term | [optional] 

### Return type

[**List<ActivityCollection>**](ActivityCollection.md)

### Authorization

[apiToken](../README.md#apiToken), [apiUser](../README.md#apiUser)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiactivitiesidget"></a>
# **ApiActivitiesIdGet**
> ActivityEntity ApiActivitiesIdGet (int? id)

Returns one activity

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiActivitiesIdGetExample
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

            var apiInstance = new ActivityApi();
            var id = 56;  // int? | Activity ID to fetch

            try
            {
                // Returns one activity
                ActivityEntity result = apiInstance.ApiActivitiesIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActivityApi.ApiActivitiesIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Activity ID to fetch | 

### Return type

[**ActivityEntity**](ActivityEntity.md)

### Authorization

[apiToken](../README.md#apiToken), [apiUser](../README.md#apiUser)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiactivitiesidmetapatch"></a>
# **ApiActivitiesIdMetaPatch**
> ActivityEntity ApiActivitiesIdMetaPatch (int? id, Body body)

Sets the value of a meta-field for an existing activity

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiActivitiesIdMetaPatchExample
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

            var apiInstance = new ActivityApi();
            var id = 56;  // int? | Activity record ID to set the meta-field value for
            var body = new Body(); // Body |  (optional) 

            try
            {
                // Sets the value of a meta-field for an existing activity
                ActivityEntity result = apiInstance.ApiActivitiesIdMetaPatch(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActivityApi.ApiActivitiesIdMetaPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Activity record ID to set the meta-field value for | 
 **body** | [**Body**](Body.md)|  | [optional] 

### Return type

[**ActivityEntity**](ActivityEntity.md)

### Authorization

[apiToken](../README.md#apiToken), [apiUser](../README.md#apiUser)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiactivitiesidpatch"></a>
# **ApiActivitiesIdPatch**
> ActivityEntity ApiActivitiesIdPatch (ActivityEditForm body, int? id)

Update an existing activity

Update an existing activity, you can pass all or just a subset of all attributes

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiActivitiesIdPatchExample
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

            var apiInstance = new ActivityApi();
            var body = new ActivityEditForm(); // ActivityEditForm | 
            var id = 56;  // int? | Activity ID to update

            try
            {
                // Update an existing activity
                ActivityEntity result = apiInstance.ApiActivitiesIdPatch(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActivityApi.ApiActivitiesIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ActivityEditForm**](ActivityEditForm.md)|  | 
 **id** | **int?**| Activity ID to update | 

### Return type

[**ActivityEntity**](ActivityEntity.md)

### Authorization

[apiToken](../README.md#apiToken), [apiUser](../README.md#apiUser)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiactivitiesidratesget"></a>
# **ApiActivitiesIdRatesGet**
> List<ActivityRate> ApiActivitiesIdRatesGet (int? id)

Returns a collection of all rates for one activity

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiActivitiesIdRatesGetExample
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

            var apiInstance = new ActivityApi();
            var id = 56;  // int? | The activity whose rates will be returned

            try
            {
                // Returns a collection of all rates for one activity
                List&lt;ActivityRate&gt; result = apiInstance.ApiActivitiesIdRatesGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActivityApi.ApiActivitiesIdRatesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The activity whose rates will be returned | 

### Return type

[**List<ActivityRate>**](ActivityRate.md)

### Authorization

[apiToken](../README.md#apiToken), [apiUser](../README.md#apiUser)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiactivitiesidratespost"></a>
# **ApiActivitiesIdRatesPost**
> ActivityRate ApiActivitiesIdRatesPost (int? id, ActivityRateForm body)

Adds a new rate to an activity

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiActivitiesIdRatesPostExample
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

            var apiInstance = new ActivityApi();
            var id = 56;  // int? | The activity to add the rate for
            var body = new ActivityRateForm(); // ActivityRateForm | 

            try
            {
                // Adds a new rate to an activity
                ActivityRate result = apiInstance.ApiActivitiesIdRatesPost(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActivityApi.ApiActivitiesIdRatesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The activity to add the rate for | 
 **body** | [**ActivityRateForm**](ActivityRateForm.md)|  | 

### Return type

[**ActivityRate**](ActivityRate.md)

### Authorization

[apiToken](../README.md#apiToken), [apiUser](../README.md#apiUser)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiactivitiesidratesrateiddelete"></a>
# **ApiActivitiesIdRatesRateIdDelete**
> void ApiActivitiesIdRatesRateIdDelete (int? id, int? rateId)

Deletes one rate for an activity

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiActivitiesIdRatesRateIdDeleteExample
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

            var apiInstance = new ActivityApi();
            var id = 56;  // int? | The activity whose rate will be removed
            var rateId = 56;  // int? | The rate to remove

            try
            {
                // Deletes one rate for an activity
                apiInstance.ApiActivitiesIdRatesRateIdDelete(id, rateId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActivityApi.ApiActivitiesIdRatesRateIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The activity whose rate will be removed | 
 **rateId** | **int?**| The rate to remove | 

### Return type

void (empty response body)

### Authorization

[apiToken](../README.md#apiToken), [apiUser](../README.md#apiUser)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiactivitiespost"></a>
# **ApiActivitiesPost**
> ActivityEntity ApiActivitiesPost (ActivityEditForm body)

Creates a new activity

Creates a new activity and returns it afterwards

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiActivitiesPostExample
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

            var apiInstance = new ActivityApi();
            var body = new ActivityEditForm(); // ActivityEditForm | 

            try
            {
                // Creates a new activity
                ActivityEntity result = apiInstance.ApiActivitiesPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActivityApi.ApiActivitiesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ActivityEditForm**](ActivityEditForm.md)|  | 

### Return type

[**ActivityEntity**](ActivityEntity.md)

### Authorization

[apiToken](../README.md#apiToken), [apiUser](../README.md#apiUser)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

