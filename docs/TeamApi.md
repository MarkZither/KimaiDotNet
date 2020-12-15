# IO.Swagger.Api.TeamApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiTeamsGet**](TeamApi.md#apiteamsget) | **GET** /api/teams | Fetch all existing teams
[**ApiTeamsIdActivitiesActivityIdDelete**](TeamApi.md#apiteamsidactivitiesactivityiddelete) | **DELETE** /api/teams/{id}/activities/{activityId} | Revokes access for an activity from a team
[**ApiTeamsIdActivitiesActivityIdPost**](TeamApi.md#apiteamsidactivitiesactivityidpost) | **POST** /api/teams/{id}/activities/{activityId} | Grant the team access to an activity
[**ApiTeamsIdCustomersCustomerIdDelete**](TeamApi.md#apiteamsidcustomerscustomeriddelete) | **DELETE** /api/teams/{id}/customers/{customerId} | Revokes access for a customer from a team
[**ApiTeamsIdCustomersCustomerIdPost**](TeamApi.md#apiteamsidcustomerscustomeridpost) | **POST** /api/teams/{id}/customers/{customerId} | Grant the team access to a customer
[**ApiTeamsIdDelete**](TeamApi.md#apiteamsiddelete) | **DELETE** /api/teams/{id} | Delete a team
[**ApiTeamsIdGet**](TeamApi.md#apiteamsidget) | **GET** /api/teams/{id} | Returns one team
[**ApiTeamsIdMembersUserIdDelete**](TeamApi.md#apiteamsidmembersuseriddelete) | **DELETE** /api/teams/{id}/members/{userId} | Removes a member from the team
[**ApiTeamsIdMembersUserIdPost**](TeamApi.md#apiteamsidmembersuseridpost) | **POST** /api/teams/{id}/members/{userId} | Add a new member to a team
[**ApiTeamsIdPatch**](TeamApi.md#apiteamsidpatch) | **PATCH** /api/teams/{id} | Update an existing team
[**ApiTeamsIdProjectsProjectIdDelete**](TeamApi.md#apiteamsidprojectsprojectiddelete) | **DELETE** /api/teams/{id}/projects/{projectId} | Revokes access for a project from a team
[**ApiTeamsIdProjectsProjectIdPost**](TeamApi.md#apiteamsidprojectsprojectidpost) | **POST** /api/teams/{id}/projects/{projectId} | Grant the team access to a project
[**ApiTeamsPost**](TeamApi.md#apiteamspost) | **POST** /api/teams | Creates a new team


<a name="apiteamsget"></a>
# **ApiTeamsGet**
> List<TeamCollection> ApiTeamsGet ()

Fetch all existing teams

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiTeamsGetExample
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

            var apiInstance = new TeamApi();

            try
            {
                // Fetch all existing teams
                List&lt;TeamCollection&gt; result = apiInstance.ApiTeamsGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.ApiTeamsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<TeamCollection>**](TeamCollection.md)

### Authorization

[apiToken](../README.md#apiToken), [apiUser](../README.md#apiUser)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiteamsidactivitiesactivityiddelete"></a>
# **ApiTeamsIdActivitiesActivityIdDelete**
> TeamEntity ApiTeamsIdActivitiesActivityIdDelete (int? id, int? activityId)

Revokes access for an activity from a team

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiTeamsIdActivitiesActivityIdDeleteExample
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

            var apiInstance = new TeamApi();
            var id = 56;  // int? | The team whose permission will be revoked
            var activityId = 56;  // int? | The activity to remove (Activity ID)

            try
            {
                // Revokes access for an activity from a team
                TeamEntity result = apiInstance.ApiTeamsIdActivitiesActivityIdDelete(id, activityId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.ApiTeamsIdActivitiesActivityIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The team whose permission will be revoked | 
 **activityId** | **int?**| The activity to remove (Activity ID) | 

### Return type

[**TeamEntity**](TeamEntity.md)

### Authorization

[apiToken](../README.md#apiToken), [apiUser](../README.md#apiUser)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiteamsidactivitiesactivityidpost"></a>
# **ApiTeamsIdActivitiesActivityIdPost**
> TeamEntity ApiTeamsIdActivitiesActivityIdPost (int? id, int? activityId)

Grant the team access to an activity

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiTeamsIdActivitiesActivityIdPostExample
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

            var apiInstance = new TeamApi();
            var id = 56;  // int? | The team that is granted access
            var activityId = 56;  // int? | The activity to grant acecess to (Activity ID)

            try
            {
                // Grant the team access to an activity
                TeamEntity result = apiInstance.ApiTeamsIdActivitiesActivityIdPost(id, activityId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.ApiTeamsIdActivitiesActivityIdPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The team that is granted access | 
 **activityId** | **int?**| The activity to grant acecess to (Activity ID) | 

### Return type

[**TeamEntity**](TeamEntity.md)

### Authorization

[apiToken](../README.md#apiToken), [apiUser](../README.md#apiUser)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiteamsidcustomerscustomeriddelete"></a>
# **ApiTeamsIdCustomersCustomerIdDelete**
> TeamEntity ApiTeamsIdCustomersCustomerIdDelete (int? id, int? customerId)

Revokes access for a customer from a team

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiTeamsIdCustomersCustomerIdDeleteExample
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

            var apiInstance = new TeamApi();
            var id = 56;  // int? | The team whose permission will be revoked
            var customerId = 56;  // int? | The customer to remove (Customer ID)

            try
            {
                // Revokes access for a customer from a team
                TeamEntity result = apiInstance.ApiTeamsIdCustomersCustomerIdDelete(id, customerId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.ApiTeamsIdCustomersCustomerIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The team whose permission will be revoked | 
 **customerId** | **int?**| The customer to remove (Customer ID) | 

### Return type

[**TeamEntity**](TeamEntity.md)

### Authorization

[apiToken](../README.md#apiToken), [apiUser](../README.md#apiUser)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiteamsidcustomerscustomeridpost"></a>
# **ApiTeamsIdCustomersCustomerIdPost**
> TeamEntity ApiTeamsIdCustomersCustomerIdPost (int? id, int? customerId)

Grant the team access to a customer

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiTeamsIdCustomersCustomerIdPostExample
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

            var apiInstance = new TeamApi();
            var id = 56;  // int? | The team that is granted access
            var customerId = 56;  // int? | The customer to grant acecess to (Customer ID)

            try
            {
                // Grant the team access to a customer
                TeamEntity result = apiInstance.ApiTeamsIdCustomersCustomerIdPost(id, customerId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.ApiTeamsIdCustomersCustomerIdPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The team that is granted access | 
 **customerId** | **int?**| The customer to grant acecess to (Customer ID) | 

### Return type

[**TeamEntity**](TeamEntity.md)

### Authorization

[apiToken](../README.md#apiToken), [apiUser](../README.md#apiUser)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiteamsiddelete"></a>
# **ApiTeamsIdDelete**
> void ApiTeamsIdDelete (int? id)

Delete a team

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiTeamsIdDeleteExample
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

            var apiInstance = new TeamApi();
            var id = 56;  // int? | Team ID to delete

            try
            {
                // Delete a team
                apiInstance.ApiTeamsIdDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.ApiTeamsIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Team ID to delete | 

### Return type

void (empty response body)

### Authorization

[apiToken](../README.md#apiToken), [apiUser](../README.md#apiUser)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiteamsidget"></a>
# **ApiTeamsIdGet**
> TeamEntity ApiTeamsIdGet (string id)

Returns one team

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiTeamsIdGetExample
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

            var apiInstance = new TeamApi();
            var id = id_example;  // string | 

            try
            {
                // Returns one team
                TeamEntity result = apiInstance.ApiTeamsIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.ApiTeamsIdGet: " + e.Message );
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

[**TeamEntity**](TeamEntity.md)

### Authorization

[apiToken](../README.md#apiToken), [apiUser](../README.md#apiUser)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiteamsidmembersuseriddelete"></a>
# **ApiTeamsIdMembersUserIdDelete**
> TeamEntity ApiTeamsIdMembersUserIdDelete (int? id, int? userId)

Removes a member from the team

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiTeamsIdMembersUserIdDeleteExample
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

            var apiInstance = new TeamApi();
            var id = 56;  // int? | The team from which the member will be removed
            var userId = 56;  // int? | The team member to remove (User ID)

            try
            {
                // Removes a member from the team
                TeamEntity result = apiInstance.ApiTeamsIdMembersUserIdDelete(id, userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.ApiTeamsIdMembersUserIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The team from which the member will be removed | 
 **userId** | **int?**| The team member to remove (User ID) | 

### Return type

[**TeamEntity**](TeamEntity.md)

### Authorization

[apiToken](../README.md#apiToken), [apiUser](../README.md#apiUser)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiteamsidmembersuseridpost"></a>
# **ApiTeamsIdMembersUserIdPost**
> TeamEntity ApiTeamsIdMembersUserIdPost (int? id, int? userId)

Add a new member to a team

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiTeamsIdMembersUserIdPostExample
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

            var apiInstance = new TeamApi();
            var id = 56;  // int? | The team which will receive the new member
            var userId = 56;  // int? | The team member to add (User ID)

            try
            {
                // Add a new member to a team
                TeamEntity result = apiInstance.ApiTeamsIdMembersUserIdPost(id, userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.ApiTeamsIdMembersUserIdPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The team which will receive the new member | 
 **userId** | **int?**| The team member to add (User ID) | 

### Return type

[**TeamEntity**](TeamEntity.md)

### Authorization

[apiToken](../README.md#apiToken), [apiUser](../README.md#apiUser)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiteamsidpatch"></a>
# **ApiTeamsIdPatch**
> TeamEntity ApiTeamsIdPatch (TeamEditForm body, int? id)

Update an existing team

Update an existing team, you can pass all or just a subset of all attributes (passing users will replace all existing ones)

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiTeamsIdPatchExample
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

            var apiInstance = new TeamApi();
            var body = new TeamEditForm(); // TeamEditForm | 
            var id = 56;  // int? | Team ID to update

            try
            {
                // Update an existing team
                TeamEntity result = apiInstance.ApiTeamsIdPatch(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.ApiTeamsIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TeamEditForm**](TeamEditForm.md)|  | 
 **id** | **int?**| Team ID to update | 

### Return type

[**TeamEntity**](TeamEntity.md)

### Authorization

[apiToken](../README.md#apiToken), [apiUser](../README.md#apiUser)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiteamsidprojectsprojectiddelete"></a>
# **ApiTeamsIdProjectsProjectIdDelete**
> TeamEntity ApiTeamsIdProjectsProjectIdDelete (int? id, int? projectId)

Revokes access for a project from a team

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiTeamsIdProjectsProjectIdDeleteExample
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

            var apiInstance = new TeamApi();
            var id = 56;  // int? | The team whose permission will be revoked
            var projectId = 56;  // int? | The project to remove (Project ID)

            try
            {
                // Revokes access for a project from a team
                TeamEntity result = apiInstance.ApiTeamsIdProjectsProjectIdDelete(id, projectId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.ApiTeamsIdProjectsProjectIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The team whose permission will be revoked | 
 **projectId** | **int?**| The project to remove (Project ID) | 

### Return type

[**TeamEntity**](TeamEntity.md)

### Authorization

[apiToken](../README.md#apiToken), [apiUser](../README.md#apiUser)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiteamsidprojectsprojectidpost"></a>
# **ApiTeamsIdProjectsProjectIdPost**
> TeamEntity ApiTeamsIdProjectsProjectIdPost (int? id, int? projectId)

Grant the team access to a project

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiTeamsIdProjectsProjectIdPostExample
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

            var apiInstance = new TeamApi();
            var id = 56;  // int? | The team that is granted access
            var projectId = 56;  // int? | The project to grant acecess to (Project ID)

            try
            {
                // Grant the team access to a project
                TeamEntity result = apiInstance.ApiTeamsIdProjectsProjectIdPost(id, projectId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.ApiTeamsIdProjectsProjectIdPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The team that is granted access | 
 **projectId** | **int?**| The project to grant acecess to (Project ID) | 

### Return type

[**TeamEntity**](TeamEntity.md)

### Authorization

[apiToken](../README.md#apiToken), [apiUser](../README.md#apiUser)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiteamspost"></a>
# **ApiTeamsPost**
> TeamEntity ApiTeamsPost (TeamEditForm body)

Creates a new team

Creates a new team and returns it afterwards

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiTeamsPostExample
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

            var apiInstance = new TeamApi();
            var body = new TeamEditForm(); // TeamEditForm | 

            try
            {
                // Creates a new team
                TeamEntity result = apiInstance.ApiTeamsPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamApi.ApiTeamsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TeamEditForm**](TeamEditForm.md)|  | 

### Return type

[**TeamEntity**](TeamEntity.md)

### Authorization

[apiToken](../README.md#apiToken), [apiUser](../README.md#apiUser)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

