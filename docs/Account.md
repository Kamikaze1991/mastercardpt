# Pbo.App.MastercardApi.Client.Model.Account
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountId** | **string** | The unique identifier for the given account. | [optional] 
**AccountIdType** | **string** | Identifier type for the given account. Possible values are BAN (the Bank Account Number) and RANAC (the unique account identifier assigned by Mastercard and provided to the client in the account enrollment) | [optional] 
**Status** | **string** | Status of the user&#39;s account. Valid values are GOOD_STANDING, REDEEM_ONLY, NEW, ON_HOLD, CANCELLED, INACTIVE. | [optional] 
**ProductCode** | **string** | The account’s associated card product type as configured during the implementation of the program. | [optional] 
**ProgramIdentifier** | **string** | Program identifier for the program in which the cardholder is enrolled. The Program ID is created by Mastercard Rewards System. | [optional] 
**OpenDate** | **DateTime** | The date of account opening as defined by the client. | [optional] 
**EnrollmentDate** | **DateTime** | The date for when the account becomes eligible for rewards program. If undefined, enrollment date is defaulted to the date when Mastercard processes the enrollment. | [optional] 
**AccruePoints** | **bool** | This specifies if the account can accrue points. It is used in conjunction with Account Status to define earn and burn behavior for the account. | [optional] 
**HouseholdToken** | **string** | This field ties together multiple User accounts into one household.  This value is typically assigned by the Client and sent with the batch enrollment file.  To use this field, an MRS Program must be configured to support a Household Token value that is externally provided by the Client. | [optional] 
**PrimaryAccount** | **bool** | Identifies if the account is primary for the User. A User may only have 1 primary account.  In situations where householding is used, there may only be 1 primary account in the household, regardless of how many User accounts make up that household.  A value of true indicates that the account is primary for the User or the household. | [optional] 
**CompanyIca** | **long** | Interbank Card Association number assigned by Mastercard to the financial institution. | [optional] 
**AccountFirstFour** | **string** | The first 4 digits of the account number. | [optional] 
**AccountLastFour** | **string** | The last 4 digits of the account number. | [optional] 
**PcloAccountStatusCode** | **string** | Status of the user&#39;s account. Valid values are GOOD_STANDING, REDEEM_ONLY, NEW, ON_HOLD, CANCELLED, INACTIVE. | [optional] 
**UserDefined1** | **string** | Custom fields defined by the user. | [optional] 
**UserDefined2** | **string** | Custom fields defined by the user. | [optional] 
**UserDefined3** | **string** | Custom fields defined by the user. | [optional] 
**UserDefined4** | **string** | Custom fields defined by the user. | [optional] 
**UserDefined5** | **string** | Custom fields defined by the user. | [optional] 
**UserDefined6** | **string** | Custom fields defined by the user. | [optional] 
**UserDefined7** | **string** | Custom fields defined by the user. | [optional] 
**UserDefined8** | **string** | Custom fields defined by the user. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

