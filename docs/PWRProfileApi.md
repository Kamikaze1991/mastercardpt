# Pbo.App.MastercardApi.Client.Api.PWRProfileApi

All URIs are relative to *https://api.mastercard.com/loyalty*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetProfileUsingGET**](PWRProfileApi.md#getprofileusingget) | **GET** /redeemers/{id} | 
[**SearchProfileUsingPOST**](PWRProfileApi.md#searchprofileusingpost) | **POST** /redeemers/search | 


<a name="getprofileusingget"></a>
# **GetProfileUsingGET**
> RedeemerProfile GetProfileUsingGET (string redemptionType, string id, string userIdType = null)



Returns a cardholder's Pay with Rewards program settings. including points balance, communication preferences and other parameters. POST and GET operations are available. Use POST when retrieving profile details based on sensitive data such as BAN or BCN. Use GET with RANAC for user_id_type.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pbo.App.MastercardApi.Client.Api;
using Pbo.App.MastercardApi.Client.Client;
using Pbo.App.MastercardApi.Client.Model;

namespace Example
{
    public class GetProfileUsingGETExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mastercard.com/loyalty";
            var apiInstance = new PWRProfileApi(config);
            var redemptionType = PWR;  // string | Redemption type should be PWR.
            var id = 609330255453162553303101469598;  // string | Unique identifier of the user.
            var userIdType = RANAC;  // string | Identifier type for the given user such as RANAC. (optional) 

            try
            {
                RedeemerProfile result = apiInstance.GetProfileUsingGET(redemptionType, id, userIdType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PWRProfileApi.GetProfileUsingGET: " + e.Message );
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
 **redemptionType** | **string**| Redemption type should be PWR. | 
 **id** | **string**| Unique identifier of the user. | 
 **userIdType** | **string**| Identifier type for the given user such as RANAC. | [optional] 

### Return type

[**RedeemerProfile**](RedeemerProfile.md)

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

<a name="searchprofileusingpost"></a>
# **SearchProfileUsingPOST**
> RedeemerProfile SearchProfileUsingPOST (SearchProfileRequest searchProfileRequest)



Retrieves a cardholder's Pay with Rewards program settings, including points balance, conversion rules, communication preferences and more.<br/><br/> POST and GET operations are available. Use POST when retrieving profile details based on sensitive data such as BAN or BCN. Use GET with RANAC for user_id_type.<br/><br/> This endpoint is not for retrieving cardholders' personal information. Use GET /users for personal information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pbo.App.MastercardApi.Client.Api;
using Pbo.App.MastercardApi.Client.Client;
using Pbo.App.MastercardApi.Client.Model;

namespace Example
{
    public class SearchProfileUsingPOSTExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mastercard.com/loyalty";
            var apiInstance = new PWRProfileApi(config);
            var searchProfileRequest = new SearchProfileRequest(); // SearchProfileRequest | request

            try
            {
                RedeemerProfile result = apiInstance.SearchProfileUsingPOST(searchProfileRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PWRProfileApi.SearchProfileUsingPOST: " + e.Message );
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
 **searchProfileRequest** | [**SearchProfileRequest**](SearchProfileRequest.md)| request | 

### Return type

[**RedeemerProfile**](RedeemerProfile.md)

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

