# IO.Swagger.Api.ProjectApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiProjectsGet**](ProjectApi.md#apiprojectsget) | **GET** /api/projects | Returns a collection of projects.
[**ApiProjectsIdGet**](ProjectApi.md#apiprojectsidget) | **GET** /api/projects/{id} | Returns one project
[**ApiProjectsIdMetaPatch**](ProjectApi.md#apiprojectsidmetapatch) | **PATCH** /api/projects/{id}/meta | Sets the value of a meta-field for an existing project
[**ApiProjectsIdPatch**](ProjectApi.md#apiprojectsidpatch) | **PATCH** /api/projects/{id} | Update an existing project
[**ApiProjectsIdRatesGet**](ProjectApi.md#apiprojectsidratesget) | **GET** /api/projects/{id}/rates | Returns a collection of all rates for one project
[**ApiProjectsIdRatesPost**](ProjectApi.md#apiprojectsidratespost) | **POST** /api/projects/{id}/rates | Adds a new rate to an project
[**ApiProjectsIdRatesRateIdDelete**](ProjectApi.md#apiprojectsidratesrateiddelete) | **DELETE** /api/projects/{id}/rates/{rateId} | Deletes one rate for an project
[**ApiProjectsPost**](ProjectApi.md#apiprojectspost) | **POST** /api/projects | Creates a new project


<a name="apiprojectsget"></a>
# **ApiProjectsGet**
> List<ProjectCollection> ApiProjectsGet (string customer, string customers, string visible, string start, string end, string ignoreDates, string order, string orderBy, string term)

Returns a collection of projects.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiProjectsGetExample
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

            var apiInstance = new ProjectApi();
            var customer = customer_example;  // string | Customer ID to filter projects (optional) 
            var customers = customers_example;  // string | Comma separated list of customer IDs to filter projects (optional) 
            var visible = visible_example;  // string | Visibility status to filter projects. Allowed values: 1=visible, 2=hidden, 3=both (default: 1) (optional) 
            var start = start_example;  // string | Only projects that started before this date will be included. Allowed format: HTML5 (default: now, if end is also empty) (optional) 
            var end = end_example;  // string | Only projects that ended after this date will be included. Allowed format: HTML5 (default: now, if start is also empty) (optional) 
            var ignoreDates = ignoreDates_example;  // string | If set, start and end are completely ignored. Allowed values: 1 (default: off) (optional) 
            var order = order_example;  // string | The result order. Allowed values: ASC, DESC (default: ASC) (optional) 
            var orderBy = orderBy_example;  // string | The field by which results will be ordered. Allowed values: id, name, customer (default: name) (optional) 
            var term = term_example;  // string | Free search term (optional) 

            try
            {
                // Returns a collection of projects.
                List&lt;ProjectCollection&gt; result = apiInstance.ApiProjectsGet(customer, customers, visible, start, end, ignoreDates, order, orderBy, term);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectApi.ApiProjectsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customer** | **string**| Customer ID to filter projects | [optional] 
 **customers** | **string**| Comma separated list of customer IDs to filter projects | [optional] 
 **visible** | **string**| Visibility status to filter projects. Allowed values: 1&#x3D;visible, 2&#x3D;hidden, 3&#x3D;both (default: 1) | [optional] 
 **start** | **string**| Only projects that started before this date will be included. Allowed format: HTML5 (default: now, if end is also empty) | [optional] 
 **end** | **string**| Only projects that ended after this date will be included. Allowed format: HTML5 (default: now, if start is also empty) | [optional] 
 **ignoreDates** | **string**| If set, start and end are completely ignored. Allowed values: 1 (default: off) | [optional] 
 **order** | **string**| The result order. Allowed values: ASC, DESC (default: ASC) | [optional] 
 **orderBy** | **string**| The field by which results will be ordered. Allowed values: id, name, customer (default: name) | [optional] 
 **term** | **string**| Free search term | [optional] 

### Return type

[**List<ProjectCollection>**](ProjectCollection.md)

### Authorization

[apiToken](../README.md#apiToken), [apiUser](../README.md#apiUser)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiprojectsidget"></a>
# **ApiProjectsIdGet**
> ProjectEntity ApiProjectsIdGet (string id)

Returns one project

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiProjectsIdGetExample
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

            var apiInstance = new ProjectApi();
            var id = id_example;  // string | 

            try
            {
                // Returns one project
                ProjectEntity result = apiInstance.ApiProjectsIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectApi.ApiProjectsIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 

### Return type

[**ProjectEntity**](ProjectEntity.md)

### Authorization

[apiToken](../README.md#apiToken), [apiUser](../README.md#apiUser)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiprojectsidmetapatch"></a>
# **ApiProjectsIdMetaPatch**
> ProjectEntity ApiProjectsIdMetaPatch (int? id, Body2 body)

Sets the value of a meta-field for an existing project

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiProjectsIdMetaPatchExample
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

            var apiInstance = new ProjectApi();
            var id = 56;  // int? | Project record ID to set the meta-field value for
            var body = new Body2(); // Body2 |  (optional) 

            try
            {
                // Sets the value of a meta-field for an existing project
                ProjectEntity result = apiInstance.ApiProjectsIdMetaPatch(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectApi.ApiProjectsIdMetaPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Project record ID to set the meta-field value for | 
 **body** | [**Body2**](Body2.md)|  | [optional] 

### Return type

[**ProjectEntity**](ProjectEntity.md)

### Authorization

[apiToken](../README.md#apiToken), [apiUser](../README.md#apiUser)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiprojectsidpatch"></a>
# **ApiProjectsIdPatch**
> ProjectEntity ApiProjectsIdPatch (ProjectEditForm body, int? id)

Update an existing project

Update an existing project, you can pass all or just a subset of all attributes

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiProjectsIdPatchExample
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

            var apiInstance = new ProjectApi();
            var body = new ProjectEditForm(); // ProjectEditForm | 
            var id = 56;  // int? | Project ID to update

            try
            {
                // Update an existing project
                ProjectEntity result = apiInstance.ApiProjectsIdPatch(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectApi.ApiProjectsIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ProjectEditForm**](ProjectEditForm.md)|  | 
 **id** | **int?**| Project ID to update | 

### Return type

[**ProjectEntity**](ProjectEntity.md)

### Authorization

[apiToken](../README.md#apiToken), [apiUser](../README.md#apiUser)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiprojectsidratesget"></a>
# **ApiProjectsIdRatesGet**
> List<ProjectRate> ApiProjectsIdRatesGet (int? id)

Returns a collection of all rates for one project

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiProjectsIdRatesGetExample
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

            var apiInstance = new ProjectApi();
            var id = 56;  // int? | The project whose rates will be returned

            try
            {
                // Returns a collection of all rates for one project
                List&lt;ProjectRate&gt; result = apiInstance.ApiProjectsIdRatesGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectApi.ApiProjectsIdRatesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The project whose rates will be returned | 

### Return type

[**List<ProjectRate>**](ProjectRate.md)

### Authorization

[apiToken](../README.md#apiToken), [apiUser](../README.md#apiUser)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiprojectsidratespost"></a>
# **ApiProjectsIdRatesPost**
> ProjectRate ApiProjectsIdRatesPost (int? id, ProjectRateForm body)

Adds a new rate to an project

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiProjectsIdRatesPostExample
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

            var apiInstance = new ProjectApi();
            var id = 56;  // int? | The project to add the rate for
            var body = new ProjectRateForm(); // ProjectRateForm | 

            try
            {
                // Adds a new rate to an project
                ProjectRate result = apiInstance.ApiProjectsIdRatesPost(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectApi.ApiProjectsIdRatesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The project to add the rate for | 
 **body** | [**ProjectRateForm**](ProjectRateForm.md)|  | 

### Return type

[**ProjectRate**](ProjectRate.md)

### Authorization

[apiToken](../README.md#apiToken), [apiUser](../README.md#apiUser)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiprojectsidratesrateiddelete"></a>
# **ApiProjectsIdRatesRateIdDelete**
> void ApiProjectsIdRatesRateIdDelete (int? id, int? rateId)

Deletes one rate for an project

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiProjectsIdRatesRateIdDeleteExample
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

            var apiInstance = new ProjectApi();
            var id = 56;  // int? | The project whose rate will be removed
            var rateId = 56;  // int? | The rate to remove

            try
            {
                // Deletes one rate for an project
                apiInstance.ApiProjectsIdRatesRateIdDelete(id, rateId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectApi.ApiProjectsIdRatesRateIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The project whose rate will be removed | 
 **rateId** | **int?**| The rate to remove | 

### Return type

void (empty response body)

### Authorization

[apiToken](../README.md#apiToken), [apiUser](../README.md#apiUser)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiprojectspost"></a>
# **ApiProjectsPost**
> ProjectEntity ApiProjectsPost (ProjectEditForm body)

Creates a new project

Creates a new project and returns it afterwards

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiProjectsPostExample
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

            var apiInstance = new ProjectApi();
            var body = new ProjectEditForm(); // ProjectEditForm | 

            try
            {
                // Creates a new project
                ProjectEntity result = apiInstance.ApiProjectsPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectApi.ApiProjectsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ProjectEditForm**](ProjectEditForm.md)|  | 

### Return type

[**ProjectEntity**](ProjectEntity.md)

### Authorization

[apiToken](../README.md#apiToken), [apiUser](../README.md#apiUser)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

