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
    /// Holds information such as points balance, and household role.
    /// </summary>
    [DataContract(Name = "HouseholdInfo")]
    public partial class HouseholdInfo : IEquatable<HouseholdInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HouseholdInfo" /> class.
        /// </summary>
        /// <param name="pointBalance">Available points across all the accounts enrolled in the household..</param>
        /// <param name="householdRole">Household role of the logged in customer. Valid values are NON_REDEEMER(N), REDEEMER(R), PRIMARY_REDEEMER(P)..</param>
        public HouseholdInfo(string pointBalance = default(string), string householdRole = default(string))
        {
            this.PointBalance = pointBalance;
            this.HouseholdRole = householdRole;
        }

        /// <summary>
        /// Available points across all the accounts enrolled in the household.
        /// </summary>
        /// <value>Available points across all the accounts enrolled in the household.</value>
        [DataMember(Name = "pointBalance", EmitDefaultValue = false)]
        public string PointBalance { get; set; }

        /// <summary>
        /// Household role of the logged in customer. Valid values are NON_REDEEMER(N), REDEEMER(R), PRIMARY_REDEEMER(P).
        /// </summary>
        /// <value>Household role of the logged in customer. Valid values are NON_REDEEMER(N), REDEEMER(R), PRIMARY_REDEEMER(P).</value>
        [DataMember(Name = "householdRole", EmitDefaultValue = false)]
        public string HouseholdRole { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HouseholdInfo {\n");
            sb.Append("  PointBalance: ").Append(PointBalance).Append("\n");
            sb.Append("  HouseholdRole: ").Append(HouseholdRole).Append("\n");
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
            return this.Equals(input as HouseholdInfo);
        }

        /// <summary>
        /// Returns true if HouseholdInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of HouseholdInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HouseholdInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PointBalance == input.PointBalance ||
                    (this.PointBalance != null &&
                    this.PointBalance.Equals(input.PointBalance))
                ) && 
                (
                    this.HouseholdRole == input.HouseholdRole ||
                    (this.HouseholdRole != null &&
                    this.HouseholdRole.Equals(input.HouseholdRole))
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
                if (this.PointBalance != null)
                    hashCode = hashCode * 59 + this.PointBalance.GetHashCode();
                if (this.HouseholdRole != null)
                    hashCode = hashCode * 59 + this.HouseholdRole.GetHashCode();
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
            // PointBalance (string) maxLength
            if(this.PointBalance != null && this.PointBalance.Length > 10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PointBalance, length must be less than 10.", new [] { "PointBalance" });
            }

            // PointBalance (string) minLength
            if(this.PointBalance != null && this.PointBalance.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PointBalance, length must be greater than 0.", new [] { "PointBalance" });
            }

            // HouseholdRole (string) maxLength
            if(this.HouseholdRole != null && this.HouseholdRole.Length > 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for HouseholdRole, length must be less than 1.", new [] { "HouseholdRole" });
            }

            // HouseholdRole (string) minLength
            if(this.HouseholdRole != null && this.HouseholdRole.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for HouseholdRole, length must be greater than 1.", new [] { "HouseholdRole" });
            }

            yield break;
        }
    }

}