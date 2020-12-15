# IO.Swagger.Api.DefaultApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiConfigI18nGet**](DefaultApi.md#apiconfigi18nget) | **GET** /api/config/i18n | Returns the user specific locale configuration
[**ApiConfigTimesheetGet**](DefaultApi.md#apiconfigtimesheetget) | **GET** /api/config/timesheet | Returns the timesheet configuration
[**ApiPingGet**](DefaultApi.md#apipingget) | **GET** /api/ping | A testing route for the API
[**ApiVersionGet**](DefaultApi.md#apiversionget) | **GET** /api/version | Returns information about the Kimai release


<a name="apiconfigi18nget"></a>
# **ApiConfigI18nGet**
> I18nConfig ApiConfigI18nGet ()

Returns the user specific locale configuration

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiConfigI18nGetExample
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

            var apiInstance = new DefaultApi();

            try
            {
                // Returns the user specific locale configuration
                I18nConfig result = apiInstance.ApiConfigI18nGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.ApiConfigI18nGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**I18nConfig**](I18nConfig.md)

### Authorization

[apiToken](../README.md#apiToken), [apiUser](../README.md#apiUser)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiconfigtimesheetget"></a>
# **ApiConfigTimesheetGet**
> TimesheetConfig ApiConfigTimesheetGet ()

Returns the timesheet configuration

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiConfigTimesheetGetExample
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

            var apiInstance = new DefaultApi();

            try
            {
                // Returns the timesheet configuration
                TimesheetConfig result = apiInstance.ApiConfigTimesheetGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.ApiConfigTimesheetGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**TimesheetConfig**](TimesheetConfig.md)

### Authorization

[apiToken](../README.md#apiToken), [apiUser](../README.md#apiUser)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apipingget"></a>
# **ApiPingGet**
> void ApiPingGet ()

A testing route for the API

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiPingGetExample
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

            var apiInstance = new DefaultApi();

            try
            {
                // A testing route for the API
                apiInstance.ApiPingGet();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.ApiPingGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

[apiToken](../README.md#apiToken), [apiUser](../README.md#apiUser)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiversionget"></a>
# **ApiVersionGet**
> Version ApiVersionGet ()

Returns information about the Kimai release

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiVersionGetExample
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

            var apiInstance = new DefaultApi();

            try
            {
                // Returns information about the Kimai release
                Version result = apiInstance.ApiVersionGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.ApiVersionGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**Version**](Version.md)

### Authorization

[apiToken](../README.md#apiToken), [apiUser](../README.md#apiUser)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

