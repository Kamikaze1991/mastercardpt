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
    /// UserAddress
    /// </summary>
    [DataContract(Name = "UserAddress")]
    public partial class UserAddress : IEquatable<UserAddress>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserAddress" /> class.
        /// </summary>
        /// <param name="addressLine1">Address Line 1 of the User&#39;s address.</param>
        /// <param name="addressLine2">Address Line 2 of the User&#39;s address.</param>
        /// <param name="addressLine3">Address Line 3 of the User&#39;s address.</param>
        /// <param name="addressLine4">Address Line 4 of the User&#39;s address.</param>
        /// <param name="city">City name as per User&#39;s address.</param>
        /// <param name="countryCode">Country Code as per User&#39;s address.</param>
        /// <param name="postalCode">Postal Code as per User&#39;s address.</param>
        /// <param name="stateProvinceCode">State Code as per User&#39;s address.</param>
        public UserAddress(string addressLine1 = default(string), string addressLine2 = default(string), string addressLine3 = default(string), string addressLine4 = default(string), string city = default(string), string countryCode = default(string), string postalCode = default(string), string stateProvinceCode = default(string))
        {
            this.AddressLine1 = addressLine1;
            this.AddressLine2 = addressLine2;
            this.AddressLine3 = addressLine3;
            this.AddressLine4 = addressLine4;
            this.City = city;
            this.CountryCode = countryCode;
            this.PostalCode = postalCode;
            this.StateProvinceCode = stateProvinceCode;
        }

        /// <summary>
        /// Address Line 1 of the User&#39;s address
        /// </summary>
        /// <value>Address Line 1 of the User&#39;s address</value>
        [DataMember(Name = "addressLine1", EmitDefaultValue = false)]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// Address Line 2 of the User&#39;s address
        /// </summary>
        /// <value>Address Line 2 of the User&#39;s address</value>
        [DataMember(Name = "addressLine2", EmitDefaultValue = false)]
        public string AddressLine2 { get; set; }

        /// <summary>
        /// Address Line 3 of the User&#39;s address
        /// </summary>
        /// <value>Address Line 3 of the User&#39;s address</value>
        [DataMember(Name = "addressLine3", EmitDefaultValue = false)]
        public string AddressLine3 { get; set; }

        /// <summary>
        /// Address Line 4 of the User&#39;s address
        /// </summary>
        /// <value>Address Line 4 of the User&#39;s address</value>
        [DataMember(Name = "addressLine4", EmitDefaultValue = false)]
        public string AddressLine4 { get; set; }

        /// <summary>
        /// City name as per User&#39;s address
        /// </summary>
        /// <value>City name as per User&#39;s address</value>
        [DataMember(Name = "city", EmitDefaultValue = false)]
        public string City { get; set; }

        /// <summary>
        /// Country Code as per User&#39;s address
        /// </summary>
        /// <value>Country Code as per User&#39;s address</value>
        [DataMember(Name = "countryCode", EmitDefaultValue = false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// Postal Code as per User&#39;s address
        /// </summary>
        /// <value>Postal Code as per User&#39;s address</value>
        [DataMember(Name = "postalCode", EmitDefaultValue = false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// State Code as per User&#39;s address
        /// </summary>
        /// <value>State Code as per User&#39;s address</value>
        [DataMember(Name = "stateProvinceCode", EmitDefaultValue = false)]
        public string StateProvinceCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserAddress {\n");
            sb.Append("  AddressLine1: ").Append(AddressLine1).Append("\n");
            sb.Append("  AddressLine2: ").Append(AddressLine2).Append("\n");
            sb.Append("  AddressLine3: ").Append(AddressLine3).Append("\n");
            sb.Append("  AddressLine4: ").Append(AddressLine4).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  StateProvinceCode: ").Append(StateProvinceCode).Append("\n");
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
            return this.Equals(input as UserAddress);
        }

        /// <summary>
        /// Returns true if UserAddress instances are equal
        /// </summary>
        /// <param name="input">Instance of UserAddress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserAddress input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AddressLine1 == input.AddressLine1 ||
                    (this.AddressLine1 != null &&
                    this.AddressLine1.Equals(input.AddressLine1))
                ) && 
                (
                    this.AddressLine2 == input.AddressLine2 ||
                    (this.AddressLine2 != null &&
                    this.AddressLine2.Equals(input.AddressLine2))
                ) && 
                (
                    this.AddressLine3 == input.AddressLine3 ||
                    (this.AddressLine3 != null &&
                    this.AddressLine3.Equals(input.AddressLine3))
                ) && 
                (
                    this.AddressLine4 == input.AddressLine4 ||
                    (this.AddressLine4 != null &&
                    this.AddressLine4.Equals(input.AddressLine4))
                ) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.CountryCode == input.CountryCode ||
                    (this.CountryCode != null &&
                    this.CountryCode.Equals(input.CountryCode))
                ) && 
                (
                    this.PostalCode == input.PostalCode ||
                    (this.PostalCode != null &&
                    this.PostalCode.Equals(input.PostalCode))
                ) && 
                (
                    this.StateProvinceCode == input.StateProvinceCode ||
                    (this.StateProvinceCode != null &&
                    this.StateProvinceCode.Equals(input.StateProvinceCode))
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
                if (this.AddressLine1 != null)
                    hashCode = hashCode * 59 + this.AddressLine1.GetHashCode();
                if (this.AddressLine2 != null)
                    hashCode = hashCode * 59 + this.AddressLine2.GetHashCode();
                if (this.AddressLine3 != null)
                    hashCode = hashCode * 59 + this.AddressLine3.GetHashCode();
                if (this.AddressLine4 != null)
                    hashCode = hashCode * 59 + this.AddressLine4.GetHashCode();
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.CountryCode != null)
                    hashCode = hashCode * 59 + this.CountryCode.GetHashCode();
                if (this.PostalCode != null)
                    hashCode = hashCode * 59 + this.PostalCode.GetHashCode();
                if (this.StateProvinceCode != null)
                    hashCode = hashCode * 59 + this.StateProvinceCode.GetHashCode();
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
            // AddressLine1 (string) maxLength
            if(this.AddressLine1 != null && this.AddressLine1.Length > 80)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AddressLine1, length must be less than 80.", new [] { "AddressLine1" });
            }

            // AddressLine1 (string) minLength
            if(this.AddressLine1 != null && this.AddressLine1.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AddressLine1, length must be greater than 0.", new [] { "AddressLine1" });
            }

            // AddressLine2 (string) maxLength
            if(this.AddressLine2 != null && this.AddressLine2.Length > 80)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AddressLine2, length must be less than 80.", new [] { "AddressLine2" });
            }

            // AddressLine2 (string) minLength
            if(this.AddressLine2 != null && this.AddressLine2.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AddressLine2, length must be greater than 0.", new [] { "AddressLine2" });
            }

            // AddressLine3 (string) maxLength
            if(this.AddressLine3 != null && this.AddressLine3.Length > 80)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AddressLine3, length must be less than 80.", new [] { "AddressLine3" });
            }

            // AddressLine3 (string) minLength
            if(this.AddressLine3 != null && this.AddressLine3.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AddressLine3, length must be greater than 0.", new [] { "AddressLine3" });
            }

            // AddressLine4 (string) maxLength
            if(this.AddressLine4 != null && this.AddressLine4.Length > 80)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AddressLine4, length must be less than 80.", new [] { "AddressLine4" });
            }

            // AddressLine4 (string) minLength
            if(this.AddressLine4 != null && this.AddressLine4.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AddressLine4, length must be greater than 0.", new [] { "AddressLine4" });
            }

            // City (string) maxLength
            if(this.City != null && this.City.Length > 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for City, length must be less than 30.", new [] { "City" });
            }

            // City (string) minLength
            if(this.City != null && this.City.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for City, length must be greater than 0.", new [] { "City" });
            }

            // CountryCode (string) maxLength
            if(this.CountryCode != null && this.CountryCode.Length > 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CountryCode, length must be less than 3.", new [] { "CountryCode" });
            }

            // CountryCode (string) minLength
            if(this.CountryCode != null && this.CountryCode.Length < 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CountryCode, length must be greater than 2.", new [] { "CountryCode" });
            }

            // PostalCode (string) maxLength
            if(this.PostalCode != null && this.PostalCode.Length > 14)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PostalCode, length must be less than 14.", new [] { "PostalCode" });
            }

            // PostalCode (string) minLength
            if(this.PostalCode != null && this.PostalCode.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PostalCode, length must be greater than 0.", new [] { "PostalCode" });
            }

            // StateProvinceCode (string) maxLength
            if(this.StateProvinceCode != null && this.StateProvinceCode.Length > 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StateProvinceCode, length must be less than 3.", new [] { "StateProvinceCode" });
            }

            // StateProvinceCode (string) minLength
            if(this.StateProvinceCode != null && this.StateProvinceCode.Length < 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StateProvinceCode, length must be greater than 2.", new [] { "StateProvinceCode" });
            }

            yield break;
        }
    }

}
