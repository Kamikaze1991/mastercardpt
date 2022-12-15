# Pbo.App.MastercardApi.Client.Model.RedemptionRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CashBackAmount** | **double** | The cash back value of the points redeemed. Minimum set to 0. Required. | 
**Description** | **string** | Any additional details that can go with this StatementCredit for future reference. Optional. | [optional] 
**ExternalId** | **string** | External client unique identifier for the redemption request. Required. | 
**PaymentAuthId** | **string** | Rewards identifier of the Authorization for which the statement credit to be issued. Required. | 
**PointsRedeemed** | **decimal** | Total points redeemed for this redemption. | 
**ReasonCode** | **string** | Mastercard Reward System response code to indicate if the redemption is successful or not. Response codes are documented &lt;a href&#x3D;\&quot;/pay-with-rewards/documentation/response-codes/\&quot;&gt; here&lt;/a&gt;. Required. | 
**RedemptionType** | **string** | Type of redemption. Use STATEMENT_CREDIT. Optional. | [optional] 
**UserId** | **string** | Unique identifier of the user. | 
**UserIdType** | **string** | Identifier type for the given user such as RANAC. Optional. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

