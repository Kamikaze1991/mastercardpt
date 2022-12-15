# Pbo.App.MastercardApi.Client.Model.UserEnrollRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Account** | [**AccountBase**](AccountBase.md) |  | 
**Address** | [**UserAddress**](UserAddress.md) |  | [optional] 
**PcloUser** | [**PCLOUser**](PCLOUser.md) |  | [optional] 
**BirthDate** | **DateTime** | User&#39;s date of birth | [optional] 
**BusinessPhoneNumber** | **string** | User’s business phone number | [optional] 
**CompanyIca** | **long** | Interbank Card Association number assigned by Mastercard to the financial institution. | 
**EmailAddress** | **string** | User’s email address | [optional] 
**Employee** | **bool** | Used to assign Employee status to a user, default value is false | [optional] 
**FirstName** | **string** | User&#39;s first name | [optional] 
**GenericIdentification** | **string** | Answer to the user’s bank-provided custom verification question.Can be used as a Security Question data point by the Internet Redemptions website, Customer Service, or web services. | [optional] 
**GenericIdentificationDescription** | **string** | The descriptive label for the user’s bank-provided custom verification question.Can be used as a Security Question data point by the Internet Redemptions website, Customer Service, or web services. | [optional] 
**HomePhoneNumber** | **string** | User’s home phone number | [optional] 
**LastName** | **string** | User&#39;s last name | [optional] 
**MobilePhoneNumber** | **string** | User’s mobile phone number | [optional] 
**MotherMaidenName** | **string** | User’s mother&#39;s maiden name | [optional] 
**NationalIdentifier** | **string** | User&#39;s unique identifier assigned by the national or government system. For example, passport number or tax identification number. | [optional] 
**UserId** | **string** | Unique identifier of the user. | 
**UserIdType** | **string** | Identifier type for the given user. | 
**Vip** | **bool** | Used to assign VIP status to a user. The default value is false. | [optional] 
**AcceptEmails** | **bool** | Specifies if the User allows contact via email for promotional purposes, default value is false | [optional] 
**AcceptSms** | **bool** | Specifies if the User allows contact to their mobile phone for promotional purposes, default value is false | [optional] 
**AcceptPromotionalInfo** | **bool** | Specifies if the User would like to receive information about special promotions, default value is true | [optional] 
**UserDefined1** | **string** | User Defined Field 1 | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

