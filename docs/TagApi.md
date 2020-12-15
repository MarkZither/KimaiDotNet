# IO.Swagger.Api.TagApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiTagsGet**](TagApi.md#apitagsget) | **GET** /api/tags | Fetch all existing tags
[**ApiTagsIdDelete**](TagApi.md#apitagsiddelete) | **DELETE** /api/tags/{id} | Delete a tag
[**ApiTagsPost**](TagApi.md#apitagspost) | **POST** /api/tags | Creates a new tag


<a name="apitagsget"></a>
# **ApiTagsGet**
> List<string> ApiTagsGet (string name)

Fetch all existing tags

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiTagsGetExample
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

            var apiInstance = new TagApi();
            var name = name_example;  // string | Search term to filter tag list (optional) 

            try
            {
                // Fetch all existing tags
                List&lt;string&gt; result = apiInstance.ApiTagsGet(name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagApi.ApiTagsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Search term to filter tag list | [optional] 

### Return type

**List<string>**

### Authorization

[apiToken](../README.md#apiToken), [apiUser](../README.md#apiUser)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apitagsiddelete"></a>
# **ApiTagsIdDelete**
> void ApiTagsIdDelete (int? id)

Delete a tag

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiTagsIdDeleteExample
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

            var apiInstance = new TagApi();
            var id = 56;  // int? | Tag ID to delete

            try
            {
                // Delete a tag
                apiInstance.ApiTagsIdDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagApi.ApiTagsIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Tag ID to delete | 

### Return type

void (empty response body)

### Authorization

[apiToken](../README.md#apiToken), [apiUser](../README.md#apiUser)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apitagspost"></a>
# **ApiTagsPost**
> TagEntity ApiTagsPost (TagEditForm body)

Creates a new tag

Creates a new tag and returns it afterwards

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiTagsPostExample
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

            var apiInstance = new TagApi();
            var body = new TagEditForm(); // TagEditForm | 

            try
            {
                // Creates a new tag
                TagEntity result = apiInstance.ApiTagsPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagApi.ApiTagsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TagEditForm**](TagEditForm.md)|  | 

### Return type

[**TagEntity**](TagEntity.md)

### Authorization

[apiToken](../README.md#apiToken), [apiUser](../README.md#apiUser)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

