# IO.Swagger.Api.CustomerApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiCustomersGet**](CustomerApi.md#apicustomersget) | **GET** /api/customers | Returns a collection of customers
[**ApiCustomersIdGet**](CustomerApi.md#apicustomersidget) | **GET** /api/customers/{id} | Returns one customer
[**ApiCustomersIdMetaPatch**](CustomerApi.md#apicustomersidmetapatch) | **PATCH** /api/customers/{id}/meta | Sets the value of a meta-field for an existing customer
[**ApiCustomersIdPatch**](CustomerApi.md#apicustomersidpatch) | **PATCH** /api/customers/{id} | Update an existing customer
[**ApiCustomersIdRatesGet**](CustomerApi.md#apicustomersidratesget) | **GET** /api/customers/{id}/rates | Returns a collection of all rates for one customer
[**ApiCustomersIdRatesPost**](CustomerApi.md#apicustomersidratespost) | **POST** /api/customers/{id}/rates | Adds a new rate to a customer
[**ApiCustomersIdRatesRateIdDelete**](CustomerApi.md#apicustomersidratesrateiddelete) | **DELETE** /api/customers/{id}/rates/{rateId} | Deletes one rate for an customer
[**ApiCustomersPost**](CustomerApi.md#apicustomerspost) | **POST** /api/customers | Creates a new customer


<a name="apicustomersget"></a>
# **ApiCustomersGet**
> List<CustomerCollection> ApiCustomersGet (string visible, string order, string orderBy, string term)

Returns a collection of customers

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiCustomersGetExample
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

            var apiInstance = new CustomerApi();
            var visible = visible_example;  // string | Visibility status to filter activities (1=visible, 2=hidden, 3=both) (optional) 
            var order = order_example;  // string | The result order. Allowed values: ASC, DESC (default: ASC) (optional) 
            var orderBy = orderBy_example;  // string | The field by which results will be ordered. Allowed values: id, name (default: name) (optional) 
            var term = term_example;  // string | Free search term (optional) 

            try
            {
                // Returns a collection of customers
                List&lt;CustomerCollection&gt; result = apiInstance.ApiCustomersGet(visible, order, orderBy, term);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.ApiCustomersGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **visible** | **string**| Visibility status to filter activities (1&#x3D;visible, 2&#x3D;hidden, 3&#x3D;both) | [optional] 
 **order** | **string**| The result order. Allowed values: ASC, DESC (default: ASC) | [optional] 
 **orderBy** | **string**| The field by which results will be ordered. Allowed values: id, name (default: name) | [optional] 
 **term** | **string**| Free search term | [optional] 

### Return type

[**List<CustomerCollection>**](CustomerCollection.md)

### Authorization

[apiToken](../README.md#apiToken), [apiUser](../README.md#apiUser)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apicustomersidget"></a>
# **ApiCustomersIdGet**
> CustomerEntity ApiCustomersIdGet (string id)

Returns one customer

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiCustomersIdGetExample
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

            var apiInstance = new CustomerApi();
            var id = id_example;  // string | 

            try
            {
                // Returns one customer
                CustomerEntity result = apiInstance.ApiCustomersIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.ApiCustomersIdGet: " + e.Message );
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

[**CustomerEntity**](CustomerEntity.md)

### Authorization

[apiToken](../README.md#apiToken), [apiUser](../README.md#apiUser)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apicustomersidmetapatch"></a>
# **ApiCustomersIdMetaPatch**
> CustomerEntity ApiCustomersIdMetaPatch (int? id, Body1 body)

Sets the value of a meta-field for an existing customer

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiCustomersIdMetaPatchExample
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

            var apiInstance = new CustomerApi();
            var id = 56;  // int? | Customer record ID to set the meta-field value for
            var body = new Body1(); // Body1 |  (optional) 

            try
            {
                // Sets the value of a meta-field for an existing customer
                CustomerEntity result = apiInstance.ApiCustomersIdMetaPatch(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.ApiCustomersIdMetaPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Customer record ID to set the meta-field value for | 
 **body** | [**Body1**](Body1.md)|  | [optional] 

### Return type

[**CustomerEntity**](CustomerEntity.md)

### Authorization

[apiToken](../README.md#apiToken), [apiUser](../README.md#apiUser)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apicustomersidpatch"></a>
# **ApiCustomersIdPatch**
> CustomerEntity ApiCustomersIdPatch (CustomerEditForm body, int? id)

Update an existing customer

Update an existing customer, you can pass all or just a subset of all attributes

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiCustomersIdPatchExample
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

            var apiInstance = new CustomerApi();
            var body = new CustomerEditForm(); // CustomerEditForm | 
            var id = 56;  // int? | Customer ID to update

            try
            {
                // Update an existing customer
                CustomerEntity result = apiInstance.ApiCustomersIdPatch(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.ApiCustomersIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CustomerEditForm**](CustomerEditForm.md)|  | 
 **id** | **int?**| Customer ID to update | 

### Return type

[**CustomerEntity**](CustomerEntity.md)

### Authorization

[apiToken](../README.md#apiToken), [apiUser](../README.md#apiUser)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apicustomersidratesget"></a>
# **ApiCustomersIdRatesGet**
> List<CustomerRate> ApiCustomersIdRatesGet (int? id)

Returns a collection of all rates for one customer

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiCustomersIdRatesGetExample
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

            var apiInstance = new CustomerApi();
            var id = 56;  // int? | The customer whose rates will be returned

            try
            {
                // Returns a collection of all rates for one customer
                List&lt;CustomerRate&gt; result = apiInstance.ApiCustomersIdRatesGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.ApiCustomersIdRatesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The customer whose rates will be returned | 

### Return type

[**List<CustomerRate>**](CustomerRate.md)

### Authorization

[apiToken](../README.md#apiToken), [apiUser](../README.md#apiUser)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apicustomersidratespost"></a>
# **ApiCustomersIdRatesPost**
> CustomerRate ApiCustomersIdRatesPost (int? id, CustomerRateForm body)

Adds a new rate to a customer

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiCustomersIdRatesPostExample
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

            var apiInstance = new CustomerApi();
            var id = 56;  // int? | The customer to add the rate for
            var body = new CustomerRateForm(); // CustomerRateForm | 

            try
            {
                // Adds a new rate to a customer
                CustomerRate result = apiInstance.ApiCustomersIdRatesPost(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.ApiCustomersIdRatesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The customer to add the rate for | 
 **body** | [**CustomerRateForm**](CustomerRateForm.md)|  | 

### Return type

[**CustomerRate**](CustomerRate.md)

### Authorization

[apiToken](../README.md#apiToken), [apiUser](../README.md#apiUser)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apicustomersidratesrateiddelete"></a>
# **ApiCustomersIdRatesRateIdDelete**
> void ApiCustomersIdRatesRateIdDelete (int? id, int? rateId)

Deletes one rate for an customer

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiCustomersIdRatesRateIdDeleteExample
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

            var apiInstance = new CustomerApi();
            var id = 56;  // int? | The customer whose rate will be removed
            var rateId = 56;  // int? | The rate to remove

            try
            {
                // Deletes one rate for an customer
                apiInstance.ApiCustomersIdRatesRateIdDelete(id, rateId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.ApiCustomersIdRatesRateIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The customer whose rate will be removed | 
 **rateId** | **int?**| The rate to remove | 

### Return type

void (empty response body)

### Authorization

[apiToken](../README.md#apiToken), [apiUser](../README.md#apiUser)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apicustomerspost"></a>
# **ApiCustomersPost**
> CustomerEntity ApiCustomersPost (CustomerEditForm body)

Creates a new customer

Creates a new customer and returns it afterwards

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiCustomersPostExample
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

            var apiInstance = new CustomerApi();
            var body = new CustomerEditForm(); // CustomerEditForm | 

            try
            {
                // Creates a new customer
                CustomerEntity result = apiInstance.ApiCustomersPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.ApiCustomersPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CustomerEditForm**](CustomerEditForm.md)|  | 

### Return type

[**CustomerEntity**](CustomerEntity.md)

### Authorization

[apiToken](../README.md#apiToken), [apiUser](../README.md#apiUser)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

