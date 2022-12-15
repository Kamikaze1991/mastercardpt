# Pbo.App.MastercardApi.Client.Api.ReprocessAuthorizationApi

All URIs are relative to *https://api.mastercard.com/loyalty*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ReprocessAuthorizationsUsingPOST**](ReprocessAuthorizationApi.md#reprocessauthorizationsusingpost) | **POST** /authorizations/{id}/reprocess | 


<a name="reprocessauthorizationsusingpost"></a>
# **ReprocessAuthorizationsUsingPOST**
> ReprocessResponse ReprocessAuthorizationsUsingPOST (string id, ReprocessRequest reprocessRequest)



Re-processes a specific past failed transaction through Pay with Rewards rules. For each program, only transactions with specific response reason codes are eligible for re-processing. Using this call enables a cardholder to redeem points on an past failed transaction.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Pbo.App.MastercardApi.Client.Api;
using Pbo.App.MastercardApi.Client.Client;
using Pbo.App.MastercardApi.Client.Model;

namespace Example
{
    public class ReprocessAuthorizationsUsingPOSTExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mastercard.com/loyalty";
            var apiInstance = new ReprocessAuthorizationApi(config);
            var id = 1005464927;  // string | Unique transaction identifier created by Mastercard Rewards System. Required.
            var reprocessRequest = new ReprocessRequest(); // ReprocessRequest | request

            try
            {
                ReprocessResponse result = apiInstance.ReprocessAuthorizationsUsingPOST(id, reprocessRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReprocessAuthorizationApi.ReprocessAuthorizationsUsingPOST: " + e.Message );
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
 **id** | **string**| Unique transaction identifier created by Mastercard Rewards System. Required. | 
 **reprocessRequest** | [**ReprocessRequest**](ReprocessRequest.md)| request | 

### Return type

[**ReprocessResponse**](ReprocessResponse.md)

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

