/*
 * Pay with Rewards APIs
 *
 * Pay with Rewards allows cardholders to redeem points for purchases made with an enrolled Mastercard card. The following APIs create the Pay with Rewards user experience, and can be used inside a banking app or other mobile apps.
 *
 * The version of the OpenAPI document: 1.1
 * Contact: paywithrewards@mastercard.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Pbo.App.MastercardApi.Client.Client.OpenAPIDateConverter;

namespace Pbo.App.MastercardApi.Client.Model
{
    /// <summary>
    /// UserUpdateRequest
    /// </summary>
    [DataContract(Name = "UserUpdateRequest")]
    public partial class UserUpdateRequest : IEquatable<UserUpdateRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserUpdateRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UserUpdateRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserUpdateRequest" /> class.
        /// </summary>
        /// <param name="address">address.</param>
        /// <param name="pcloUser">pcloUser.</param>
        /// <param name="birthDate">User&#39;s date of birth.</param>
        /// <param name="businessPhoneNumber">User’s business phone number.</param>
        /// <param name="emailAddress">User’s email address.</param>
        /// <param name="employee">Used to assign Employee status to a user, default value is false.</param>
        /// <param name="firstName">User&#39;s first name.</param>
        /// <param name="genericIdentification">Answer to the user’s bank-provided custom verification question.  Can be used as a Security Question data point by the Internet Redemptions website, Customer Service, or web services..</param>
        /// <param name="genericIdentificationDescription">The descriptive label for the user’s bank-provided custom verification question.  Can be used as a Security Question data point by the Internet Redemptions website, Customer Service, or web services..</param>
        /// <param name="lastName">User&#39;s last name.</param>
        /// <param name="mobilePhoneNumber">User’s mobile phone number.</param>
        /// <param name="motherMaidenName">User&#39;s mother&#39;s maiden name.</param>
        /// <param name="nationalIdentifier">User&#39;s unique identifier assigned by the national or government system. For example, passport number or tax identification number..</param>
        /// <param name="userId">Unique identifier of the User (required).</param>
        /// <param name="userIdType">Identifier type of the User. (required).</param>
        /// <param name="vip">Used to assign VIP status to a user, default value is false.</param>
        /// <param name="userDefined1">User Defined Field 1.</param>
        public UserUpdateRequest(UserAddress address = default(UserAddress), PCLOUser pcloUser = default(PCLOUser), string birthDate = default(string), string businessPhoneNumber = default(string), string emailAddress = default(string), bool employee = default(bool), string firstName = default(string), string genericIdentification = default(string), string genericIdentificationDescription = default(string), string lastName = default(string), string mobilePhoneNumber = default(string), string motherMaidenName = default(string), string nationalIdentifier = default(string), string userId = default(string), string userIdType = default(string), bool vip = default(bool), string userDefined1 = default(string))
        {
            // to ensure "userId" is required (not null)
            this.UserId = userId ?? throw new ArgumentNullException("userId is a required property for UserUpdateRequest and cannot be null");
            // to ensure "userIdType" is required (not null)
            this.UserIdType = userIdType ?? throw new ArgumentNullException("userIdType is a required property for UserUpdateRequest and cannot be null");
            this.Address = address;
            this.PcloUser = pcloUser;
            this.BirthDate = birthDate;
            this.BusinessPhoneNumber = businessPhoneNumber;
            this.EmailAddress = emailAddress;
            this.Employee = employee;
            this.FirstName = firstName;
            this.GenericIdentification = genericIdentification;
            this.GenericIdentificationDescription = genericIdentificationDescription;
            this.LastName = lastName;
            this.MobilePhoneNumber = mobilePhoneNumber;
            this.MotherMaidenName = motherMaidenName;
            this.NationalIdentifier = nationalIdentifier;
            this.Vip = vip;
            this.UserDefined1 = userDefined1;
        }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name = "address", EmitDefaultValue = false)]
        public UserAddress Address { get; set; }

        /// <summary>
        /// Gets or Sets PcloUser
        /// </summary>
        [DataMember(Name = "pcloUser", EmitDefaultValue = false)]
        public PCLOUser PcloUser { get; set; }

        /// <summary>
        /// User&#39;s date of birth
        /// </summary>
        /// <value>User&#39;s date of birth</value>
        [DataMember(Name = "birthDate", EmitDefaultValue = false)]
        public string BirthDate { get; set; }

        /// <summary>
        /// User’s business phone number
        /// </summary>
        /// <value>User’s business phone number</value>
        [DataMember(Name = "businessPhoneNumber", EmitDefaultValue = false)]
        public string BusinessPhoneNumber { get; set; }

        /// <summary>
        /// User’s email address
        /// </summary>
        /// <value>User’s email address</value>
        [DataMember(Name = "emailAddress", EmitDefaultValue = false)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Used to assign Employee status to a user, default value is false
        /// </summary>
        /// <value>Used to assign Employee status to a user, default value is false</value>
        [DataMember(Name = "employee", EmitDefaultValue = false)]
        public bool Employee { get; set; }

        /// <summary>
        /// User&#39;s first name
        /// </summary>
        /// <value>User&#39;s first name</value>
        [DataMember(Name = "firstName", EmitDefaultValue = false)]
        public string FirstName { get; set; }

        /// <summary>
        /// Answer to the user’s bank-provided custom verification question.  Can be used as a Security Question data point by the Internet Redemptions website, Customer Service, or web services.
        /// </summary>
        /// <value>Answer to the user’s bank-provided custom verification question.  Can be used as a Security Question data point by the Internet Redemptions website, Customer Service, or web services.</value>
        [DataMember(Name = "genericIdentification", EmitDefaultValue = false)]
        public string GenericIdentification { get; set; }

        /// <summary>
        /// The descriptive label for the user’s bank-provided custom verification question.  Can be used as a Security Question data point by the Internet Redemptions website, Customer Service, or web services.
        /// </summary>
        /// <value>The descriptive label for the user’s bank-provided custom verification question.  Can be used as a Security Question data point by the Internet Redemptions website, Customer Service, or web services.</value>
        [DataMember(Name = "genericIdentificationDescription", EmitDefaultValue = false)]
        public string GenericIdentificationDescription { get; set; }

        /// <summary>
        /// User&#39;s last name
        /// </summary>
        /// <value>User&#39;s last name</value>
        [DataMember(Name = "lastName", EmitDefaultValue = false)]
        public string LastName { get; set; }

        /// <summary>
        /// User’s mobile phone number
        /// </summary>
        /// <value>User’s mobile phone number</value>
        [DataMember(Name = "mobilePhoneNumber", EmitDefaultValue = false)]
        public string MobilePhoneNumber { get; set; }

        /// <summary>
        /// User&#39;s mother&#39;s maiden name
        /// </summary>
        /// <value>User&#39;s mother&#39;s maiden name</value>
        [DataMember(Name = "motherMaidenName", EmitDefaultValue = false)]
        public string MotherMaidenName { get; set; }

        /// <summary>
        /// User&#39;s unique identifier assigned by the national or government system. For example, passport number or tax identification number.
        /// </summary>
        /// <value>User&#39;s unique identifier assigned by the national or government system. For example, passport number or tax identification number.</value>
        [DataMember(Name = "nationalIdentifier", EmitDefaultValue = false)]
        public string NationalIdentifier { get; set; }

        /// <summary>
        /// Unique identifier of the User
        /// </summary>
        /// <value>Unique identifier of the User</value>
        [DataMember(Name = "userId", IsRequired = true, EmitDefaultValue = false)]
        public string UserId { get; set; }

        /// <summary>
        /// Identifier type of the User.
        /// </summary>
        /// <value>Identifier type of the User.</value>
        [DataMember(Name = "userIdType", IsRequired = true, EmitDefaultValue = false)]
        public string UserIdType { get; set; }

        /// <summary>
        /// Used to assign VIP status to a user, default value is false
        /// </summary>
        /// <value>Used to assign VIP status to a user, default value is false</value>
        [DataMember(Name = "vip", EmitDefaultValue = false)]
        public bool Vip { get; set; }

        /// <summary>
        /// User Defined Field 1
        /// </summary>
        /// <value>User Defined Field 1</value>
        [DataMember(Name = "userDefined1", EmitDefaultValue = false)]
        public string UserDefined1 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserUpdateRequest {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  PcloUser: ").Append(PcloUser).Append("\n");
            sb.Append("  BirthDate: ").Append(BirthDate).Append("\n");
            sb.Append("  BusinessPhoneNumber: ").Append(BusinessPhoneNumber).Append("\n");
            sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
            sb.Append("  Employee: ").Append(Employee).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  GenericIdentification: ").Append(GenericIdentification).Append("\n");
            sb.Append("  GenericIdentificationDescription: ").Append(GenericIdentificationDescription).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  MobilePhoneNumber: ").Append(MobilePhoneNumber).Append("\n");
            sb.Append("  MotherMaidenName: ").Append(MotherMaidenName).Append("\n");
            sb.Append("  NationalIdentifier: ").Append(NationalIdentifier).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  UserIdType: ").Append(UserIdType).Append("\n");
            sb.Append("  Vip: ").Append(Vip).Append("\n");
            sb.Append("  UserDefined1: ").Append(UserDefined1).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as UserUpdateRequest);
        }

        /// <summary>
        /// Returns true if UserUpdateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UserUpdateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserUpdateRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.PcloUser == input.PcloUser ||
                    (this.PcloUser != null &&
                    this.PcloUser.Equals(input.PcloUser))
                ) && 
                (
                    this.BirthDate == input.BirthDate ||
                    (this.BirthDate != null &&
                    this.BirthDate.Equals(input.BirthDate))
                ) && 
                (
                    this.BusinessPhoneNumber == input.BusinessPhoneNumber ||
                    (this.BusinessPhoneNumber != null &&
                    this.BusinessPhoneNumber.Equals(input.BusinessPhoneNumber))
                ) && 
                (
                    this.EmailAddress == input.EmailAddress ||
                    (this.EmailAddress != null &&
                    this.EmailAddress.Equals(input.EmailAddress))
                ) && 
                (
                    this.Employee == input.Employee ||
                    this.Employee.Equals(input.Employee)
                ) && 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.GenericIdentification == input.GenericIdentification ||
                    (this.GenericIdentification != null &&
                    this.GenericIdentification.Equals(input.GenericIdentification))
                ) && 
                (
                    this.GenericIdentificationDescription == input.GenericIdentificationDescription ||
                    (this.GenericIdentificationDescription != null &&
                    this.GenericIdentificationDescription.Equals(input.GenericIdentificationDescription))
                ) && 
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
                ) && 
                (
                    this.MobilePhoneNumber == input.MobilePhoneNumber ||
                    (this.MobilePhoneNumber != null &&
                    this.MobilePhoneNumber.Equals(input.MobilePhoneNumber))
                ) && 
                (
                    this.MotherMaidenName == input.MotherMaidenName ||
                    (this.MotherMaidenName != null &&
                    this.MotherMaidenName.Equals(input.MotherMaidenName))
                ) && 
                (
                    this.NationalIdentifier == input.NationalIdentifier ||
                    (this.NationalIdentifier != null &&
                    this.NationalIdentifier.Equals(input.NationalIdentifier))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.UserIdType == input.UserIdType ||
                    (this.UserIdType != null &&
                    this.UserIdType.Equals(input.UserIdType))
                ) && 
                (
                    this.Vip == input.Vip ||
                    this.Vip.Equals(input.Vip)
                ) && 
                (
                    this.UserDefined1 == input.UserDefined1 ||
                    (this.UserDefined1 != null &&
                    this.UserDefined1.Equals(input.UserDefined1))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.PcloUser != null)
                    hashCode = hashCode * 59 + this.PcloUser.GetHashCode();
                if (this.BirthDate != null)
                    hashCode = hashCode * 59 + this.BirthDate.GetHashCode();
                if (this.BusinessPhoneNumber != null)
                    hashCode = hashCode * 59 + this.BusinessPhoneNumber.GetHashCode();
                if (this.EmailAddress != null)
                    hashCode = hashCode * 59 + this.EmailAddress.GetHashCode();
                hashCode = hashCode * 59 + this.Employee.GetHashCode();
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.GenericIdentification != null)
                    hashCode = hashCode * 59 + this.GenericIdentification.GetHashCode();
                if (this.GenericIdentificationDescription != null)
                    hashCode = hashCode * 59 + this.GenericIdentificationDescription.GetHashCode();
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.MobilePhoneNumber != null)
                    hashCode = hashCode * 59 + this.MobilePhoneNumber.GetHashCode();
                if (this.MotherMaidenName != null)
                    hashCode = hashCode * 59 + this.MotherMaidenName.GetHashCode();
                if (this.NationalIdentifier != null)
                    hashCode = hashCode * 59 + this.NationalIdentifier.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.UserIdType != null)
                    hashCode = hashCode * 59 + this.UserIdType.GetHashCode();
                hashCode = hashCode * 59 + this.Vip.GetHashCode();
                if (this.UserDefined1 != null)
                    hashCode = hashCode * 59 + this.UserDefined1.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // BirthDate (string) maxLength
            if(this.BirthDate != null && this.BirthDate.Length > 10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BirthDate, length must be less than 10.", new [] { "BirthDate" });
            }

            // BirthDate (string) minLength
            if(this.BirthDate != null && this.BirthDate.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BirthDate, length must be greater than 0.", new [] { "BirthDate" });
            }

            // BusinessPhoneNumber (string) maxLength
            if(this.BusinessPhoneNumber != null && this.BusinessPhoneNumber.Length > 25)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BusinessPhoneNumber, length must be less than 25.", new [] { "BusinessPhoneNumber" });
            }

            // BusinessPhoneNumber (string) minLength
            if(this.BusinessPhoneNumber != null && this.BusinessPhoneNumber.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BusinessPhoneNumber, length must be greater than 0.", new [] { "BusinessPhoneNumber" });
            }

            // EmailAddress (string) maxLength
            if(this.EmailAddress != null && this.EmailAddress.Length > 120)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EmailAddress, length must be less than 120.", new [] { "EmailAddress" });
            }

            // EmailAddress (string) minLength
            if(this.EmailAddress != null && this.EmailAddress.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EmailAddress, length must be greater than 0.", new [] { "EmailAddress" });
            }

            // FirstName (string) maxLength
            if(this.FirstName != null && this.FirstName.Length > 25)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FirstName, length must be less than 25.", new [] { "FirstName" });
            }

            // FirstName (string) minLength
            if(this.FirstName != null && this.FirstName.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FirstName, length must be greater than 0.", new [] { "FirstName" });
            }

            // GenericIdentification (string) maxLength
            if(this.GenericIdentification != null && this.GenericIdentification.Length > 15)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for GenericIdentification, length must be less than 15.", new [] { "GenericIdentification" });
            }

            // GenericIdentification (string) minLength
            if(this.GenericIdentification != null && this.GenericIdentification.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for GenericIdentification, length must be greater than 0.", new [] { "GenericIdentification" });
            }

            // GenericIdentificationDescription (string) maxLength
            if(this.GenericIdentificationDescription != null && this.GenericIdentificationDescription.Length > 25)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for GenericIdentificationDescription, length must be less than 25.", new [] { "GenericIdentificationDescription" });
            }

            // GenericIdentificationDescription (string) minLength
            if(this.GenericIdentificationDescription != null && this.GenericIdentificationDescription.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for GenericIdentificationDescription, length must be greater than 0.", new [] { "GenericIdentificationDescription" });
            }

            // LastName (string) maxLength
            if(this.LastName != null && this.LastName.Length > 25)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LastName, length must be less than 25.", new [] { "LastName" });
            }

            // LastName (string) minLength
            if(this.LastName != null && this.LastName.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LastName, length must be greater than 0.", new [] { "LastName" });
            }

            // MobilePhoneNumber (string) maxLength
            if(this.MobilePhoneNumber != null && this.MobilePhoneNumber.Length > 25)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MobilePhoneNumber, length must be less than 25.", new [] { "MobilePhoneNumber" });
            }

            // MobilePhoneNumber (string) minLength
            if(this.MobilePhoneNumber != null && this.MobilePhoneNumber.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MobilePhoneNumber, length must be greater than 0.", new [] { "MobilePhoneNumber" });
            }

            // MotherMaidenName (string) maxLength
            if(this.MotherMaidenName != null && this.MotherMaidenName.Length > 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MotherMaidenName, length must be less than 30.", new [] { "MotherMaidenName" });
            }

            // MotherMaidenName (string) minLength
            if(this.MotherMaidenName != null && this.MotherMaidenName.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MotherMaidenName, length must be greater than 0.", new [] { "MotherMaidenName" });
            }

            // NationalIdentifier (string) maxLength
            if(this.NationalIdentifier != null && this.NationalIdentifier.Length > 11)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for NationalIdentifier, length must be less than 11.", new [] { "NationalIdentifier" });
            }

            // NationalIdentifier (string) minLength
            if(this.NationalIdentifier != null && this.NationalIdentifier.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for NationalIdentifier, length must be greater than 0.", new [] { "NationalIdentifier" });
            }

            // UserId (string) maxLength
            if(this.UserId != null && this.UserId.Length > 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for UserId, length must be less than 30.", new [] { "UserId" });
            }

            // UserId (string) minLength
            if(this.UserId != null && this.UserId.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for UserId, length must be greater than 1.", new [] { "UserId" });
            }

            // UserIdType (string) maxLength
            if(this.UserIdType != null && this.UserIdType.Length > 5)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for UserIdType, length must be less than 5.", new [] { "UserIdType" });
            }

            // UserIdType (string) minLength
            if(this.UserIdType != null && this.UserIdType.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for UserIdType, length must be greater than 1.", new [] { "UserIdType" });
            }

            // UserDefined1 (string) maxLength
            if(this.UserDefined1 != null && this.UserDefined1.Length > 40)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for UserDefined1, length must be less than 40.", new [] { "UserDefined1" });
            }

            // UserDefined1 (string) minLength
            if(this.UserDefined1 != null && this.UserDefined1.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for UserDefined1, length must be greater than 0.", new [] { "UserDefined1" });
            }

            yield break;
        }
    }

}
