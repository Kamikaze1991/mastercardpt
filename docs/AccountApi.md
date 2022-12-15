# Pbo.App.MastercardApi.Client.Api.AccountApi

All URIs are relative to *https://api.mastercard.com/loyalty*

Method | HTTP request | Description
------------- | ------------- | -------------
[**EnrollAccount**](AccountApi.md#enrollaccount) | **POST** /mrs/accounts | Enrolls a new account for an existing User. An Account is a unique card, as compared to a User which is a unique cardholder. Each User can have multiple Accounts.
[**FindAccount**](AccountApi.md#findaccount) | **GET** /mrs/accounts/{id} | Retrieves Account details using the Account Id, including the Account standing, enrollment date, and more.&lt;br/&gt;&lt;br/&gt; An Account is a unique card, as compared to a User which is a unique cardholder. Each User can have multiple Accounts.
[**UpdateAccount**](AccountApi.md#updateaccount) | **PUT** /mrs/accounts | Updates the Account status for currently enrolled Accounts.&lt;br/&gt;&lt;br/&gt; An Account is a unique card, as compared to a User which is a unique cardholder. Each User can have multiple Accounts.


<a name="enrollaccount"></a>
# **EnrollAccount**
> AccountEnrollResponse EnrollAccount (AccountEnrollRequest accountEnrollRequest)

Enrolls a new account for an existing User. An Account is a unique card, as compared to a User which is a unique cardholder. Each User can have multiple Accounts.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pbo.App.MastercardApi.Client.Api;
using Pbo.App.MastercardApi.Client.Client;
using Pbo.App.MastercardApi.Client.Model;

namespace Example
{
    public class EnrollAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mastercard.com/loyalty";
            var apiInstance = new AccountApi(config);
            var accountEnrollRequest = new AccountEnrollRequest(); // AccountEnrollRequest | accountEnrollRequest

            try
            {
                // Enrolls a new account for an existing User. An Account is a unique card, as compared to a User which is a unique cardholder. Each User can have multiple Accounts.
                AccountEnrollResponse result = apiInstance.EnrollAccount(accountEnrollRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountApi.EnrollAccount: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountEnrollRequest** | [**AccountEnrollRequest**](AccountEnrollRequest.md)| accountEnrollRequest | 

### Return type

[**AccountEnrollResponse**](AccountEnrollResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Successfully Enrolled Account |  -  |
| **0** | unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findaccount"></a>
# **FindAccount**
> AccountSearchResponse FindAccount (string id, string accountIdType = null, string userIdType = null)

Retrieves Account details using the Account Id, including the Account standing, enrollment date, and more.<br/><br/> An Account is a unique card, as compared to a User which is a unique cardholder. Each User can have multiple Accounts.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pbo.App.MastercardApi.Client.Api;
using Pbo.App.MastercardApi.Client.Client;
using Pbo.App.MastercardApi.Client.Model;

namespace Example
{
    public class FindAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mastercard.com/loyalty";
            var apiInstance = new AccountApi(config);
            var id = 609330255453162553303101469598;  // string | A system generated unique identifier for the User such as RANAC
            var accountIdType = RANAC;  // string | Account identifier type (optional) 
            var userIdType = userIdType_example;  // string | User identifier type (optional) 

            try
            {
                // Retrieves Account details using the Account Id, including the Account standing, enrollment date, and more.<br/><br/> An Account is a unique card, as compared to a User which is a unique cardholder. Each User can have multiple Accounts.
                AccountSearchResponse result = apiInstance.FindAccount(id, accountIdType, userIdType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountApi.FindAccount: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| A system generated unique identifier for the User such as RANAC | 
 **accountIdType** | **string**| Account identifier type | [optional] 
 **userIdType** | **string**| User identifier type | [optional] 

### Return type

[**AccountSearchResponse**](AccountSearchResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully Retrieved Account |  -  |
| **0** | unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateaccount"></a>
# **UpdateAccount**
> void UpdateAccount (AccountUpdateRequest accountUpdateRequest)

Updates the Account status for currently enrolled Accounts.<br/><br/> An Account is a unique card, as compared to a User which is a unique cardholder. Each User can have multiple Accounts.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pbo.App.MastercardApi.Client.Api;
using Pbo.App.MastercardApi.Client.Client;
using Pbo.App.MastercardApi.Client.Model;

namespace Example
{
    public class UpdateAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mastercard.com/loyalty";
            var apiInstance = new AccountApi(config);
            var accountUpdateRequest = new AccountUpdateRequest(); // AccountUpdateRequest | accountUpdateRequest

            try
            {
                // Updates the Account status for currently enrolled Accounts.<br/><br/> An Account is a unique card, as compared to a User which is a unique cardholder. Each User can have multiple Accounts.
                apiInstance.UpdateAccount(accountUpdateRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountApi.UpdateAccount: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountUpdateRequest** | [**AccountUpdateRequest**](AccountUpdateRequest.md)| accountUpdateRequest | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully Updated Account |  -  |
| **0** | unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

