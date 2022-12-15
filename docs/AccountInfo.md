# Pbo.App.MastercardApi.Client.Model.AccountInfo
Holds account level details such as accountStatus, minimum and maximum purchase threshold and other parameters.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountStatus** | **string** | Status of the consumer&#39;s account. Valid values are GOODSTANDING(1), REDEEMONLY(0), NEW(2), ONHOLD(4), CANCELLED(3), INACTIVE(5). | [optional] 
**LastFourDigitsOfCard** | **string** | Last four digits of cardholder&#39;s account number. | [optional] 
**MinProgramPurchaseThreshold** | **string** | Minimum purchase amount eligible for Pay with Rewards. | [optional] 
**MaxProgramPurchaseThreshold** | **string** | Maximum purchase amount eligible for Pay With Rewards. | [optional] 
**ProgramId** | **string** | Program identifier for the program in which the cardholder is enrolled. Program Id is created by Mastercard Rewards System. | [optional] 
**RedemptionEnrollStatus** | **string** | Status of the cardholder&#39;s account where cardholder has selected for the rebate to be processed on an account other than the transacting card account. Possible values are \&quot;I\&quot;, \&quot;A\&quot;. \&quot;I\&quot; indicates inactive, \&quot;A\&quot; indicates active. This field is not applicable if the cardholder rebate account is same as their card account. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

