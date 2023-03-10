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
    /// ReprocessRequest
    /// </summary>
    [DataContract(Name = "ReprocessRequest")]
    public partial class ReprocessRequest : IEquatable<ReprocessRequest>, IValidatableObject
    {
        /// <summary>
        /// Identifier type for the given account such as RANAC. Required.
        /// </summary>
        /// <value>Identifier type for the given account such as RANAC. Required.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AccountIdTypeEnum
        {
            /// <summary>
            /// Enum RANAC for value: RANAC
            /// </summary>
            [EnumMember(Value = "RANAC")]
            RANAC = 1

        }

        /// <summary>
        /// Identifier type for the given account such as RANAC. Required.
        /// </summary>
        /// <value>Identifier type for the given account such as RANAC. Required.</value>
        [DataMember(Name = "accountIdType", IsRequired = true, EmitDefaultValue = false)]
        public AccountIdTypeEnum AccountIdType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReprocessRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ReprocessRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReprocessRequest" /> class.
        /// </summary>
        /// <param name="processedBy">User or system submitted the reprocess request. Required. (required).</param>
        /// <param name="accountId">Unique identifier of the account. (required).</param>
        /// <param name="accountIdType">Identifier type for the given account such as RANAC. Required. (required).</param>
        public ReprocessRequest(string processedBy = default(string), string accountId = default(string), AccountIdTypeEnum accountIdType = default(AccountIdTypeEnum))
        {
            // to ensure "processedBy" is required (not null)
            this.ProcessedBy = processedBy ?? throw new ArgumentNullException("processedBy is a required property for ReprocessRequest and cannot be null");
            // to ensure "accountId" is required (not null)
            this.AccountId = accountId ?? throw new ArgumentNullException("accountId is a required property for ReprocessRequest and cannot be null");
            this.AccountIdType = accountIdType;
        }

        /// <summary>
        /// User or system submitted the reprocess request. Required.
        /// </summary>
        /// <value>User or system submitted the reprocess request. Required.</value>
        [DataMember(Name = "processedBy", IsRequired = true, EmitDefaultValue = false)]
        public string ProcessedBy { get; set; }

        /// <summary>
        /// Unique identifier of the account.
        /// </summary>
        /// <value>Unique identifier of the account.</value>
        [DataMember(Name = "accountId", IsRequired = true, EmitDefaultValue = false)]
        public string AccountId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReprocessRequest {\n");
            sb.Append("  ProcessedBy: ").Append(ProcessedBy).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  AccountIdType: ").Append(AccountIdType).Append("\n");
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
            return this.Equals(input as ReprocessRequest);
        }

        /// <summary>
        /// Returns true if ReprocessRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ReprocessRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReprocessRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProcessedBy == input.ProcessedBy ||
                    (this.ProcessedBy != null &&
                    this.ProcessedBy.Equals(input.ProcessedBy))
                ) && 
                (
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
                ) && 
                (
                    this.AccountIdType == input.AccountIdType ||
                    this.AccountIdType.Equals(input.AccountIdType)
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
                if (this.ProcessedBy != null)
                    hashCode = hashCode * 59 + this.ProcessedBy.GetHashCode();
                if (this.AccountId != null)
                    hashCode = hashCode * 59 + this.AccountId.GetHashCode();
                hashCode = hashCode * 59 + this.AccountIdType.GetHashCode();
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
            // ProcessedBy (string) maxLength
            if(this.ProcessedBy != null && this.ProcessedBy.Length > 10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ProcessedBy, length must be less than 10.", new [] { "ProcessedBy" });
            }

            // ProcessedBy (string) minLength
            if(this.ProcessedBy != null && this.ProcessedBy.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ProcessedBy, length must be greater than 1.", new [] { "ProcessedBy" });
            }

            // AccountId (string) maxLength
            if(this.AccountId != null && this.AccountId.Length > 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AccountId, length must be less than 30.", new [] { "AccountId" });
            }

            // AccountId (string) minLength
            if(this.AccountId != null && this.AccountId.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AccountId, length must be greater than 1.", new [] { "AccountId" });
            }

            // AccountIdType (string) maxLength
            if(this.AccountIdType != null)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AccountIdType, length must be less than 5.", new [] { "AccountIdType" });
            }

            // AccountIdType (string) minLength
            if(this.AccountIdType != null)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AccountIdType, length must be greater than 0.", new [] { "AccountIdType" });
            }

            yield break;
        }
    }

}
