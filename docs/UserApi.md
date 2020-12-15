# IO.Swagger.Api.UserApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiUsersGet**](UserApi.md#apiusersget) | **GET** /api/users | Returns the collection of all registered users
[**ApiUsersIdGet**](UserApi.md#apiusersidget) | **GET** /api/users/{id} | Return one user entity
[**ApiUsersIdPatch**](UserApi.md#apiusersidpatch) | **PATCH** /api/users/{id} | Update an existing user
[**ApiUsersMeGet**](UserApi.md#apiusersmeget) | **GET** /api/users/me | Return the current user entity
[**ApiUsersPost**](UserApi.md#apiuserspost) | **POST** /api/users | Creates a new user


<a name="apiusersget"></a>
# **ApiUsersGet**
> List<UserCollection> ApiUsersGet (string visible, string orderBy, string order, string term)

Returns the collection of all registered users

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiUsersGetExample
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

            var apiInstance = new UserApi();
            var visible = visible_example;  // string | Visibility status to filter users. Allowed values: 1=visible, 2=hidden, 3=all (default: 1) (optional) 
            var orderBy = orderBy_example;  // string | The field by which results will be ordered. Allowed values: id, username, alias, email (default: username) (optional) 
            var order = order_example;  // string | The result order. Allowed values: ASC, DESC (default: ASC) (optional) 
            var term = term_example;  // string | Free search term (optional) 

            try
            {
                // Returns the collection of all registered users
                List&lt;UserCollection&gt; result = apiInstance.ApiUsersGet(visible, orderBy, order, term);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.ApiUsersGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **visible** | **string**| Visibility status to filter users. Allowed values: 1&#x3D;visible, 2&#x3D;hidden, 3&#x3D;all (default: 1) | [optional] 
 **orderBy** | **string**| The field by which results will be ordered. Allowed values: id, username, alias, email (default: username) | [optional] 
 **order** | **string**| The result order. Allowed values: ASC, DESC (default: ASC) | [optional] 
 **term** | **string**| Free search term | [optional] 

### Return type

[**List<UserCollection>**](UserCollection.md)

### Authorization

[apiToken](../README.md#apiToken), [apiUser](../README.md#apiUser)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiusersidget"></a>
# **ApiUsersIdGet**
> UserEntity ApiUsersIdGet (int? id)

Return one user entity

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiUsersIdGetExample
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

            var apiInstance = new UserApi();
            var id = 56;  // int? | User ID to fetch

            try
            {
                // Return one user entity
                UserEntity result = apiInstance.ApiUsersIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.ApiUsersIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| User ID to fetch | 

### Return type

[**UserEntity**](UserEntity.md)

### Authorization

[apiToken](../README.md#apiToken), [apiUser](../README.md#apiUser)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiusersidpatch"></a>
# **ApiUsersIdPatch**
> UserEntity ApiUsersIdPatch (UserEditForm body, int? id)

Update an existing user

Update an existing user, you can pass all or just a subset of all attributes (passing roles will replace all existing ones)

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiUsersIdPatchExample
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

            var apiInstance = new UserApi();
            var body = new UserEditForm(); // UserEditForm | 
            var id = 56;  // int? | User ID to update

            try
            {
                // Update an existing user
                UserEntity result = apiInstance.ApiUsersIdPatch(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.ApiUsersIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UserEditForm**](UserEditForm.md)|  | 
 **id** | **int?**| User ID to update | 

### Return type

[**UserEntity**](UserEntity.md)

### Authorization

[apiToken](../README.md#apiToken), [apiUser](../README.md#apiUser)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiusersmeget"></a>
# **ApiUsersMeGet**
> UserEntity ApiUsersMeGet ()

Return the current user entity

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiUsersMeGetExample
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

            var apiInstance = new UserApi();

            try
            {
                // Return the current user entity
                UserEntity result = apiInstance.ApiUsersMeGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.ApiUsersMeGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**UserEntity**](UserEntity.md)

### Authorization

[apiToken](../README.md#apiToken), [apiUser](../README.md#apiUser)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiuserspost"></a>
# **ApiUsersPost**
> UserEntity ApiUsersPost (UserCreateForm body)

Creates a new user

Creates a new user and returns it afterwards

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiUsersPostExample
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

            var apiInstance = new UserApi();
            var body = new UserCreateForm(); // UserCreateForm | 

            try
            {
                // Creates a new user
                UserEntity result = apiInstance.ApiUsersPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.ApiUsersPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UserCreateForm**](UserCreateForm.md)|  | 

### Return type

[**UserEntity**](UserEntity.md)

### Authorization

[apiToken](../README.md#apiToken), [apiUser](../README.md#apiUser)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

