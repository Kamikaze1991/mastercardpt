# Pbo.App.MastercardApi.Client.Api.StatementCreditApi

All URIs are relative to *https://api.mastercard.com/loyalty*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApplyStatementCreditUsingPOST**](StatementCreditApi.md#applystatementcreditusingpost) | **POST** /redemptions | 


<a name="applystatementcreditusingpost"></a>
# **ApplyStatementCreditUsingPOST**
> RedemptionResponse ApplyStatementCreditUsingPOST (RedemptionRequest redemptionRequest)



Sends a statement credit to a cardholder based on a Pay with Rewards transaction and/or updates the status of a past transaction. This method must be used together with the outbound <a href = \"/pay-with-rewards/documentation/api-reference/auth-notifier/\">Auth Notifier</a>. A statement credit can only be applied based on an existing transaction that was processed by Pay with Rewards. This API can be used to update the status of an authorization (for example, from eligible to redeemed) even without sending a statement credit. Only clients with an external points bank who codes to the Mastercard API for points processing need to use this API.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pbo.App.MastercardApi.Client.Api;
using Pbo.App.MastercardApi.Client.Client;
using Pbo.App.MastercardApi.Client.Model;

namespace Example
{
    public class ApplyStatementCreditUsingPOSTExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mastercard.com/loyalty";
            var apiInstance = new StatementCreditApi(config);
            var redemptionRequest = new RedemptionRequest(); // RedemptionRequest | request

            try
            {
                RedemptionResponse result = apiInstance.ApplyStatementCreditUsingPOST(redemptionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StatementCreditApi.ApplyStatementCreditUsingPOST: " + e.Message );
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
 **redemptionRequest** | [**RedemptionRequest**](RedemptionRequest.md)| request | 

### Return type

[**RedemptionResponse**](RedemptionResponse.md)

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

