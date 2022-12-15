# Pbo.App.MastercardApi.Client.Api.AuthorizationsApi

All URIs are relative to *https://api.mastercard.com/loyalty*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAuthorizationsUsingGET**](AuthorizationsApi.md#getauthorizationsusingget) | **GET** /authorizations | 
[**PostAuthorizationsUsingPOST**](AuthorizationsApi.md#postauthorizationsusingpost) | **POST** /authorizations | 


<a name="getauthorizationsusingget"></a>
# **GetAuthorizationsUsingGET**
> List&lt;Authorization&gt; GetAuthorizationsUsingGET (string userId, DateTime fromDate, DateTime toDate, bool includeReprocessed, string userIdType = null, string externalId = null, List<string> pwrFilterCategories = null)



Retrieves a cardholder's recent transactions based on filtering criteria. Each transaction is returned along with a response code which identifies the result of its processing through Pay with Rewards. This can be used to display a transaction history with a status indicator for each transaction. For example- redeemed, eligible for redemption, ineligible for redemption. Results from this can be limited by status code depending on the requirements of the client's UI. This call uses RANAC as the user_id_type. <br> NOTE- This API returns many data elements about each transaction. Typically, PWR UI displays a few key data elements required for a cardholder to identify a transaction. (For example - date, amount, and merchant)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pbo.App.MastercardApi.Client.Api;
using Pbo.App.MastercardApi.Client.Client;
using Pbo.App.MastercardApi.Client.Model;

namespace Example
{
    public class GetAuthorizationsUsingGETExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mastercard.com/loyalty";
            var apiInstance = new AuthorizationsApi(config);
            var userId = 609330255453162553303101469598;  // string | Unique identifier of the user.
            var fromDate = 2019-01-25;  // DateTime | Start date (YYYY-MM-DD) for the transactions required. Required.
            var toDate = 2019-10-28;  // DateTime | End date (YYYY-MM-DD) for the transactions required. Required.
            var includeReprocessed = true;  // bool | Indicates whether or not authorizations that were reprocessed (redeemed post-purchase by the cardholder) should be included.
            var userIdType = RANAC;  // string | Identifier type for the given user such as RANAC. Optional. (optional) 
            var externalId = externalId_example;  // string | Reference number provided by processing network (Mastercard or other). Optional. (optional) 
            var pwrFilterCategories = new List<string>(); // List<string> | Provides capability to filter the transactions based on the authorization response reason code provided by Mastercard. R indicates successfully redeemed which includes authorizations that has response code 60. E indicates eligible transactions which includes authorizations that has response code 59. I indicates ineligible transacations which includes authorizations that has response codes 59,60,72, and 70. Please <a href=\"/pay-with-rewards/documentation/api-reference/application-response-codes/\">click here</a> to understand what these codes mean. Optional. (optional) 

            try
            {
                List<Authorization> result = apiInstance.GetAuthorizationsUsingGET(userId, fromDate, toDate, includeReprocessed, userIdType, externalId, pwrFilterCategories);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthorizationsApi.GetAuthorizationsUsingGET: " + e.Message );
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
 **userId** | **string**| Unique identifier of the user. | 
 **fromDate** | **DateTime**| Start date (YYYY-MM-DD) for the transactions required. Required. | 
 **toDate** | **DateTime**| End date (YYYY-MM-DD) for the transactions required. Required. | 
 **includeReprocessed** | **bool**| Indicates whether or not authorizations that were reprocessed (redeemed post-purchase by the cardholder) should be included. | 
 **userIdType** | **string**| Identifier type for the given user such as RANAC. Optional. | [optional] 
 **externalId** | **string**| Reference number provided by processing network (Mastercard or other). Optional. | [optional] 
 **pwrFilterCategories** | [**List&lt;string&gt;**](string.md)| Provides capability to filter the transactions based on the authorization response reason code provided by Mastercard. R indicates successfully redeemed which includes authorizations that has response code 60. E indicates eligible transactions which includes authorizations that has response code 59. I indicates ineligible transacations which includes authorizations that has response codes 59,60,72, and 70. Please &lt;a href&#x3D;\&quot;/pay-with-rewards/documentation/api-reference/application-response-codes/\&quot;&gt;click here&lt;/a&gt; to understand what these codes mean. Optional. | [optional] 

### Return type

[**List&lt;Authorization&gt;**](Authorization.md)

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

<a name="postauthorizationsusingpost"></a>
# **PostAuthorizationsUsingPOST**
> List&lt;AuthorizationPostResponse&gt; PostAuthorizationsUsingPOST (AuthorizationRequest authorizationRequest)



Sends a new transaction to be processed by Pay with Rewards. This can be used for transactions not processed by the Mastercard network. Supported accountIdType is BAN. Use queueTransaction='Y' if you want to send the transaction to Pay with Rewards without waiting for the completion of processing. When queueTransaction='Y' the only field populated in the response will be responseMessage. Most parameters in this API are optional. Required elements are noted as such.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pbo.App.MastercardApi.Client.Api;
using Pbo.App.MastercardApi.Client.Client;
using Pbo.App.MastercardApi.Client.Model;

namespace Example
{
    public class PostAuthorizationsUsingPOSTExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mastercard.com/loyalty";
            var apiInstance = new AuthorizationsApi(config);
            var authorizationRequest = new AuthorizationRequest(); // AuthorizationRequest | request

            try
            {
                List<AuthorizationPostResponse> result = apiInstance.PostAuthorizationsUsingPOST(authorizationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthorizationsApi.PostAuthorizationsUsingPOST: " + e.Message );
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
 **authorizationRequest** | [**AuthorizationRequest**](AuthorizationRequest.md)| request | 

### Return type

[**List&lt;AuthorizationPostResponse&gt;**](AuthorizationPostResponse.md)

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

