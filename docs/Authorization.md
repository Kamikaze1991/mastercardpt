# Pbo.App.MastercardApi.Client.Model.Authorization
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique transaction identifier created by Mastercard Rewards System. | [optional] 
**ReprocessId** | **string** | Unique identifier created by Mastercard Rewards System, for reprocessed transactions only. | [optional] 
**ResponseReasonId** | **string** | Response reason code provided by MRS for the authorization. | [optional] 
**ResponseReasonDesc** | **string** | Description of MRS response reason code. | [optional] 
**MerchantCategoryName** | **string** | The category name of the merchant. | [optional] 
**ExternalId** | **string** | Reference number provided by processing network (Mastercard or other) | [optional] 
**ReprocessedBy** | **string** | User or system submitted the reprocess request. This is valid only for reprocessed transactions. | [optional] 
**ReprocessedDateTime** | **string** | Date and time on when the reprocess happened. This is valid only for reprocessed transactions. | [optional] 
**De004TransactionAmount** | **string** | Transaction amount. | [optional] 
**De005IssuerCurrencySettlementAmount** | **string** | Issuer settlement amount. | [optional] 
**De006CardholderBillingAmount** | **string** | Transaction amount in the cardholder’s billing currency- this is the amount used by Pay with Rewards in processing a transaction. | [optional] 
**De012TransactionTime** | **string** | Transaction time in HH24miss format. | [optional] 
**De013TransactionDate** | **string** | Transaction date in MMdd format. | [optional] 
**De018MerchantCode** | **string** | Merchant Type (MCC) | [optional] 
**De032AcquiringInstitutionIdCode** | **string** | Acquiring Institution ID Code | [optional] 
**De039ResponseCode** | **string** | Authorization response code(approve/decline). Pay with Rewards considers only approved authorizations. | [optional] 
**De042CardAcceptorIdCode** | **string** | Identifies the card acceptor. Also, used as a merchant ID to uniquely identify the merchant in a POS transaction. | [optional] 
**De043CardAcceptorNameLocation** | **string** | Card Acceptor Name and Location | [optional] 
**De048TCC** | **string** | TCC (Additional Data – Private Use). | [optional] 
**De049TransactionCurrencyCode** | **string** | Currency code of the transaction amount. | [optional] 
**De050SettlementCurrencyCode** | **string** | (Currency Code, Reconciliation) defines the DE 5 (Amount, Reconciliation) currency | [optional] 
**De051CardholderBillingCurrencyCode** | **string** | (Currency Code, Cardholder Billing) defines the DE 6 (Amount, Cardholder Billing) currency, and DE 111 (Amount, Currency Conversion Assessment) currency | [optional] 
**PointsRedeemed** | **string** | Points redeemed for a given transaction. Populated only for successfully redeemed purchases and assigned value \&quot;0\&quot; to eligible and ineligible purchases. | [optional] 
**MerchantCountry** | **string** | Country code for the merchant (ex. FRA). DE61 subfield 13. | [optional] 
**PointConversionCurrency** | **string** | Currency of the conversion rule that was applied by Pay with Rewards engine (ex. EUR). If the applied conversion rule does not have a currency associated, the cardholder billing currency is returned. May not be returned for “ineligible” purchases. | [optional] 
**PointConversionFactor** | **decimal** | Conversion rate (cash to points ratio) applied to the transaction by Pay with Rewards. May not be returned for “Ineligible” purchases. | [optional] 
**CashBackAmount** | **int** | The amount of the statement credit associated with the redemption  (ex. 10.75) A value is returned only if the transaction is in “Redeem” status (response reason 60). For “Eligible” or “Ineligible” purchases a value of “0” is returned. | [optional] 
**TotalPointsRequired** | **decimal** | Total points required for a redemption irrespective of available  point balance, partial redemption, and other thresholds. (ex. 1000) May not be returned for “Ineligible” purchases. | [optional] 
**PartiallyRedeemed** | **bool** | Returns TRUE if the cardholder has redeemed fewer points than the total points required. This is only applicable for authorizations in “Redeem” status (response reason 60). For “Eligible” or “Ineligible” purchases, the default value of FALSE is returned. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

