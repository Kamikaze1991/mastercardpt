# Pbo.App.MastercardApi.Client.Model.UserSearchResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CompanyIca** | **long** | Interbank Card Association number assigned by Mastercard to the financial institution | [optional] 
**UserId** | **string** | Unique identifier of the user. | [optional] 
**UserIdType** | **string** | Identifier type for the given user. | [optional] 
**FirstName** | **string** | User&#39;s first name | [optional] 
**LastName** | **string** | User&#39;s last name | [optional] 
**MotherMaidenName** | **string** | User&#39;s mother&#39;s maiden name | [optional] 
**BirthDate** | **DateTime** | User&#39;s date of birth | [optional] 
**NationalIdentifier** | **string** | User&#39;s unique identifier assigned by the national or government system. For example, passport number or tax identification number. | [optional] 
**BusinessPhoneNumber** | **string** | User’s business phone number. | [optional] 
**MobilePhoneNumber** | **string** | User’s mobile phone number | [optional] 
**EmailAddress** | **string** | User’s email address | [optional] 
**Vip** | **bool** | Used to assign VIP status to a user, default value is false | [optional] 
**Employee** | **bool** | Used to assign Employee status to a user, default value is false | [optional] 
**AcceptEmails** | **bool** | Specifies if the User allows contact via email for promotional purposes | [optional] 
**AcceptSms** | **bool** | Specifies if the User allows contact to their mobile phone for promotional purposes | [optional] 
**AcceptPromotionalInfo** | **bool** | Specifies if the User would like to receive information about special promotions | [optional] 
**GenericIdentification** | **string** | Answer to the user’s bank-provided custom verification question.  This can be used as a Security Question data point by the Internet Redemptions website, Customer Service, or web services. | [optional] 
**GenericIdentificationDescription** | **string** | The descriptive label for the user’s bank-provided custom verification question.  This can be used as a Security Question data point by the Internet Redemptions website, Customer Service, or web services. | [optional] 
**UserDefined1** | **string** | User Defined Field 1 | [optional] 
**Address** | [**UserAddress**](UserAddress.md) |  | [optional] 
**PcloUser** | [**PCLOUser**](PCLOUser.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

