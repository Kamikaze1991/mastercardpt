# Pbo.App.MastercardApi.Client.Api.UserApi

All URIs are relative to *https://api.mastercard.com/loyalty*

Method | HTTP request | Description
------------- | ------------- | -------------
[**FindUser**](UserApi.md#finduser) | **GET** /mrs/users/{id} | Retrieves a cardholder&#39;s information, including their name, address, communication preferences, and more.&lt;br&gt;&lt;br/&gt; Users are unique cardholders, as compared to Accounts which are unique cards. Each User can have multiple Accounts.
[**MrsUsersPost**](UserApi.md#mrsuserspost) | **POST** /mrs/users | Enrolls a new cardholder and their account. &lt;br/&gt;&lt;br&gt;Users are unique cardholders, as compared to Accounts which are unique cards. Each User can have multiple Accounts.
[**UpdateUser**](UserApi.md#updateuser) | **PUT** /mrs/users | Updates personal information for currently enrolled cardholders, including their name, contact information, security question, and more.&lt;br/&gt;&lt;br/&gt; &lt;bold&gt;NOTE&amp;#58;&lt;/bold&gt; When calling the endpoint, please ensure that all the attributes are provided with values in the payload even if only a few attributes need to be updated.


<a name="finduser"></a>
# **FindUser**
> UserSearchResponse FindUser (string id, string userIdType = null)

Retrieves a cardholder's information, including their name, address, communication preferences, and more.<br><br/> Users are unique cardholders, as compared to Accounts which are unique cards. Each User can have multiple Accounts.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pbo.App.MastercardApi.Client.Api;
using Pbo.App.MastercardApi.Client.Client;
using Pbo.App.MastercardApi.Client.Model;

namespace Example
{
    public class FindUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mastercard.com/loyalty";
            var apiInstance = new UserApi(config);
            var id = 282947573008198049562610279575;  // string | A system generated unique identifier for the User such as RANCU
            var userIdType = RANCU;  // string | Identifier type for the given user or account.The default value is RANCU. (optional) 

            try
            {
                // Retrieves a cardholder's information, including their name, address, communication preferences, and more.<br><br/> Users are unique cardholders, as compared to Accounts which are unique cards. Each User can have multiple Accounts.
                UserSearchResponse result = apiInstance.FindUser(id, userIdType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.FindUser: " + e.Message );
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
 **id** | **string**| A system generated unique identifier for the User such as RANCU | 
 **userIdType** | **string**| Identifier type for the given user or account.The default value is RANCU. | [optional] 

### Return type

[**UserSearchResponse**](UserSearchResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully Retrieved User |  -  |
| **0** | unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mrsuserspost"></a>
# **MrsUsersPost**
> UserEnrollResponse MrsUsersPost (UserEnrollRequest userEnrollRequest)

Enrolls a new cardholder and their account. <br/><br>Users are unique cardholders, as compared to Accounts which are unique cards. Each User can have multiple Accounts.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pbo.App.MastercardApi.Client.Api;
using Pbo.App.MastercardApi.Client.Client;
using Pbo.App.MastercardApi.Client.Model;

namespace Example
{
    public class MrsUsersPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mastercard.com/loyalty";
            var apiInstance = new UserApi(config);
            var userEnrollRequest = new UserEnrollRequest(); // UserEnrollRequest | userEnrollRequest

            try
            {
                // Enrolls a new cardholder and their account. <br/><br>Users are unique cardholders, as compared to Accounts which are unique cards. Each User can have multiple Accounts.
                UserEnrollResponse result = apiInstance.MrsUsersPost(userEnrollRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.MrsUsersPost: " + e.Message );
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
 **userEnrollRequest** | [**UserEnrollRequest**](UserEnrollRequest.md)| userEnrollRequest | 

### Return type

[**UserEnrollResponse**](UserEnrollResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Successfully Enrolled User |  -  |
| **0** | unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateuser"></a>
# **UpdateUser**
> void UpdateUser (UserUpdateRequest userUpdateRequest)

Updates personal information for currently enrolled cardholders, including their name, contact information, security question, and more.<br/><br/> <bold>NOTE&#58;</bold> When calling the endpoint, please ensure that all the attributes are provided with values in the payload even if only a few attributes need to be updated.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pbo.App.MastercardApi.Client.Api;
using Pbo.App.MastercardApi.Client.Client;
using Pbo.App.MastercardApi.Client.Model;

namespace Example
{
    public class UpdateUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mastercard.com/loyalty";
            var apiInstance = new UserApi(config);
            var userUpdateRequest = new UserUpdateRequest(); // UserUpdateRequest | userUpdateRequest

            try
            {
                // Updates personal information for currently enrolled cardholders, including their name, contact information, security question, and more.<br/><br/> <bold>NOTE&#58;</bold> When calling the endpoint, please ensure that all the attributes are provided with values in the payload even if only a few attributes need to be updated.
                apiInstance.UpdateUser(userUpdateRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UpdateUser: " + e.Message );
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
 **userUpdateRequest** | [**UserUpdateRequest**](UserUpdateRequest.md)| userUpdateRequest | 

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
| **200** | Successfully Updated User |  -  |
| **0** | unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

