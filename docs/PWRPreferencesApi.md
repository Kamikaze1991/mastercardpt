# Pbo.App.MastercardApi.Client.Api.PWRPreferencesApi

All URIs are relative to *https://api.mastercard.com/loyalty*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetPreferencesUsingGET**](PWRPreferencesApi.md#getpreferencesusingget) | **GET** /redeemers/{id}/preferences | 
[**SetPreferencesUsingPUT**](PWRPreferencesApi.md#setpreferencesusingput) | **PUT** /redeemers/{id}/preferences | 


<a name="getpreferencesusingget"></a>
# **GetPreferencesUsingGET**
> Preferences GetPreferencesUsingGET (string id, string redemptionType, string userIdType = null)



Retrieves a cardholder's Pay with Rewards contact information and communication preferences. This endpoint is a lighter-weight version of GET /redeemers as it returns fewer data elements.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pbo.App.MastercardApi.Client.Api;
using Pbo.App.MastercardApi.Client.Client;
using Pbo.App.MastercardApi.Client.Model;

namespace Example
{
    public class GetPreferencesUsingGETExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mastercard.com/loyalty";
            var apiInstance = new PWRPreferencesApi(config);
            var id = 609330255453162553303101469598;  // string | Unique identifier of the user.
            var redemptionType = PWR;  // string | Redemption type should be PWR. Required.
            var userIdType = RANAC;  // string | Type of identifier sent in user_id. Optional. (optional) 

            try
            {
                Preferences result = apiInstance.GetPreferencesUsingGET(id, redemptionType, userIdType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PWRPreferencesApi.GetPreferencesUsingGET: " + e.Message );
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
 **id** | **string**| Unique identifier of the user. | 
 **redemptionType** | **string**| Redemption type should be PWR. Required. | 
 **userIdType** | **string**| Type of identifier sent in user_id. Optional. | [optional] 

### Return type

[**Preferences**](Preferences.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **0** | unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setpreferencesusingput"></a>
# **SetPreferencesUsingPUT**
> void SetPreferencesUsingPUT (string id, string redemptionType, SetPreferencesRequest setPreferencesRequest)



Sets a cardholder's Pay with Rewards preferences, then returns the updated settings as confirmation. Updates are done in real-time.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pbo.App.MastercardApi.Client.Api;
using Pbo.App.MastercardApi.Client.Client;
using Pbo.App.MastercardApi.Client.Model;

namespace Example
{
    public class SetPreferencesUsingPUTExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mastercard.com/loyalty";
            var apiInstance = new PWRPreferencesApi(config);
            var id = 609330255453162553303101469598;  // string | Unique identifier of the user.
            var redemptionType = PWR;  // string | Redemption type should be PWR.
            var setPreferencesRequest = new SetPreferencesRequest(); // SetPreferencesRequest | setPreferencesRequest

            try
            {
                apiInstance.SetPreferencesUsingPUT(id, redemptionType, setPreferencesRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PWRPreferencesApi.SetPreferencesUsingPUT: " + e.Message );
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
 **id** | **string**| Unique identifier of the user. | 
 **redemptionType** | **string**| Redemption type should be PWR. | 
 **setPreferencesRequest** | [**SetPreferencesRequest**](SetPreferencesRequest.md)| setPreferencesRequest | 

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
| **200** | OK |  -  |
| **0** | unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

