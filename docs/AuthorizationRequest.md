# Pbo.App.MastercardApi.Client.Model.AuthorizationRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountId1** | **string** | DE102. Optional. | [optional] 
**AccountId2** | **string** | DE103. Optional. | [optional] 
**AccountNumber** | **string** | DE 48, subelement 33, subfield 2. Optional. | [optional] 
**AccountNumberIndicator** | **string** | DE 48, subelement 33, subfield 1. Optional. | [optional] 
**AcquiringInstitutionIdCode** | **string** | Acquiring Institution ID Code - DE 32. This field is numeric. Required. | 
**AdditionalAmount** | **string** | DE 54. Optional. | [optional] 
**AmountCardholderBillingFee** | **string** | DE 8. Optional. | [optional] 
**AuthorizationIdResponse** | **string** | DE 38. Optional. | [optional] 
**CardAcceptorIdCode** | **string** | Merchant ID code to uniquely identify the merchant in a POS transaction - DE 42. Required. | 
**CardAcceptorNameAndLocation** | **string** | Name and location of the card acceptor - DE 43. Required. | 
**CardholderAccountTerminalLevel** | **string** | Type of cardholder activated terminal used by the cardholder to initiate the transaction - (DE 61, subfield 10). This field should be numeric. Optional. | [optional] 
**CardholderBillingAmount** | **string** | Transaction amount in the issuer&#39;s currency. This is the amount billed to the cardholder in the cardholder account currency, excluding billing fees - DE 6. Required. | 
**CardholderBillingCurrencyCode** | **string** | Currency code of card holder billing amount. Code is accepted in alpha-3 format of ISO 4217 currency codes - DE 51. Required. | 
**ConversionRateCardholderBilling** | **string** | DE 10. Optional. | [optional] 
**ConversionRateSettled** | **string** | DE 9. Optional. | [optional] 
**ExpirationDate** | **string** | DE 48, subelement 33, subfield 3. Should be in YYMM format. Optional. | [optional] 
**ExternalId** | **string** | Client reference number for the authorization. Should be a unique identifier. Required. | 
**ForwardingInstitutionIdCode** | **string** | DE 33. Optional. | [optional] 
**IssuerSettlementAmount** | **string** | DE 5. Optional. | [optional] 
**MerchantCategoryCode** | **string** | Card acceptor business code/merchant category code [MCC] - DE 18. Required. | 
**OnBehalfService** | **string** | DE 48, subelement 71, subfield 1. Optional. | [optional] 
**OnBehalfServiceResult1** | **string** | DE 48, subelement 71, subfield 2. Optional. | [optional] 
**OnBehalfServiceResult2** | **string** | DE 48, subelement 71, subfield 3. Optional. | [optional] 
**OriginalDataElement** | **string** | DE 90. Optional. | [optional] 
**PanMappingFileInformation** | **string** | DE 48, subelement 33. Optional. | [optional] 
**PointOfSaleCaptureCapabilities** | **string** | DE 61, subfield 6. Optional. | [optional] 
**PointOfSaleCardPresence** | **string** | DE 61, subfield 5. Optional. | [optional] 
**PointOfSaleCardTerminalInputCapability** | **string** | DE 61, subfield 10. Optional. | [optional] 
**PointOfSaleCardholderPresence** | **string** | DE 61, subfield 4. Optional. | [optional] 
**PointOfSaleCountryCode** | **string** | DE 61, subfield 13. Optional. | [optional] 
**PointOfSaleData** | **string** | DE 61, subfield 13. Optional. | [optional] 
**PointOfSaleEntryMode** | **string** | DE 22. Optional. | [optional] 
**PointOfSalePostalCode** | **string** | DE 61, subfield 14. Optional. | [optional] 
**PrimaryAccountNumber** | **string** | DE 48, subelement 33, subfield 7. Optional. | [optional] 
**ProcessingCode** | **string** | DE 3, subfield 1. Required. | 
**ProductCode** | **string** | DE 48, subelement 33, subfield 4. Optional. | [optional] 
**ReconciliationCurrencyCode** | **string** | DE 50. Optional. | [optional] 
**ReplacementAmount** | **string** | DE 95. Optional. | [optional] 
**Reserved** | **string** | DE 60. Optional. | [optional] 
**ResponseCode** | **string** | DE 39. Optional. | [optional] 
**SystemTraceAuditNumber** | **string** | DE 11. Optional. | [optional] 
**TokenAssuranceLevel** | **string** | DE 48, subelement 33, subfield 5. Optional. | [optional] 
**TokenRequestorId** | **string** | DE 48, subelement 33, subfield 6. Optional. | [optional] 
**TransactionAmount** | **string** | DE 4. Optional. | [optional] 
**TransactionCategoryCode** | **string** | DE 48. Optional. | [optional] 
**TransactionCurrencyCode** | **string** | DE 49. Optional. | [optional] 
**TransactionDateAndTime** | **string** | Authorization date and time in \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ssXXX\&quot; format. Required. | 
**AccountId** | **string** | Unique identifier of the account. Required. | 
**AccountIdType** | **string** | Identifier type for the given account such as BAN. Required. | 
**WalletIdentifier** | **string** | DE 48, subelement 26, subfield 1. Optional. | [optional] 
**IssuerCountryCode** | **string** | DE 20. Required. | 
**QueueTransaction** | **string** | Set to &#39;Y&#39; to queue the authorization for processing without receiving a response. If queueTransaction&#x3D;&#39;Y&#39; the only field populated in the response will be responseMessage. Required. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

