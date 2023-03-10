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
    /// RedemptionRequest
    /// </summary>
    [DataContract(Name = "RedemptionRequest")]
    public partial class RedemptionRequest : IEquatable<RedemptionRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RedemptionRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RedemptionRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RedemptionRequest" /> class.
        /// </summary>
        /// <param name="cashBackAmount">The cash back value of the points redeemed. Minimum set to 0. Required. (required).</param>
        /// <param name="description">Any additional details that can go with this StatementCredit for future reference. Optional..</param>
        /// <param name="externalId">External client unique identifier for the redemption request. Required. (required).</param>
        /// <param name="paymentAuthId">Rewards identifier of the Authorization for which the statement credit to be issued. Required. (required).</param>
        /// <param name="pointsRedeemed">Total points redeemed for this redemption. (required).</param>
        /// <param name="reasonCode">Mastercard Reward System response code to indicate if the redemption is successful or not. Response codes are documented &lt;a href&#x3D;\&quot;/pay-with-rewards/documentation/response-codes/\&quot;&gt; here&lt;/a&gt;. Required. (required).</param>
        /// <param name="redemptionType">Type of redemption. Use STATEMENT_CREDIT. Optional..</param>
        /// <param name="userId">Unique identifier of the user. (required).</param>
        /// <param name="userIdType">Identifier type for the given user such as RANAC. Optional..</param>
        public RedemptionRequest(double cashBackAmount = default(double), string description = default(string), string externalId = default(string), string paymentAuthId = default(string), decimal pointsRedeemed = default(decimal), string reasonCode = default(string), string redemptionType = default(string), string userId = default(string), string userIdType = default(string))
        {
            this.CashBackAmount = cashBackAmount;
            // to ensure "externalId" is required (not null)
            this.ExternalId = externalId ?? throw new ArgumentNullException("externalId is a required property for RedemptionRequest and cannot be null");
            // to ensure "paymentAuthId" is required (not null)
            this.PaymentAuthId = paymentAuthId ?? throw new ArgumentNullException("paymentAuthId is a required property for RedemptionRequest and cannot be null");
            this.PointsRedeemed = pointsRedeemed;
            // to ensure "reasonCode" is required (not null)
            this.ReasonCode = reasonCode ?? throw new ArgumentNullException("reasonCode is a required property for RedemptionRequest and cannot be null");
            // to ensure "userId" is required (not null)
            this.UserId = userId ?? throw new ArgumentNullException("userId is a required property for RedemptionRequest and cannot be null");
            this.Description = description;
            this.RedemptionType = redemptionType;
            this.UserIdType = userIdType;
        }

        /// <summary>
        /// The cash back value of the points redeemed. Minimum set to 0. Required.
        /// </summary>
        /// <value>The cash back value of the points redeemed. Minimum set to 0. Required.</value>
        [DataMember(Name = "cashBackAmount", IsRequired = true, EmitDefaultValue = false)]
        public double CashBackAmount { get; set; }

        /// <summary>
        /// Any additional details that can go with this StatementCredit for future reference. Optional.
        /// </summary>
        /// <value>Any additional details that can go with this StatementCredit for future reference. Optional.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// External client unique identifier for the redemption request. Required.
        /// </summary>
        /// <value>External client unique identifier for the redemption request. Required.</value>
        [DataMember(Name = "externalId", IsRequired = true, EmitDefaultValue = false)]
        public string ExternalId { get; set; }

        /// <summary>
        /// Rewards identifier of the Authorization for which the statement credit to be issued. Required.
        /// </summary>
        /// <value>Rewards identifier of the Authorization for which the statement credit to be issued. Required.</value>
        [DataMember(Name = "paymentAuthId", IsRequired = true, EmitDefaultValue = false)]
        public string PaymentAuthId { get; set; }

        /// <summary>
        /// Total points redeemed for this redemption.
        /// </summary>
        /// <value>Total points redeemed for this redemption.</value>
        [DataMember(Name = "pointsRedeemed", IsRequired = true, EmitDefaultValue = false)]
        public decimal PointsRedeemed { get; set; }

        /// <summary>
        /// Mastercard Reward System response code to indicate if the redemption is successful or not. Response codes are documented &lt;a href&#x3D;\&quot;/pay-with-rewards/documentation/response-codes/\&quot;&gt; here&lt;/a&gt;. Required.
        /// </summary>
        /// <value>Mastercard Reward System response code to indicate if the redemption is successful or not. Response codes are documented &lt;a href&#x3D;\&quot;/pay-with-rewards/documentation/response-codes/\&quot;&gt; here&lt;/a&gt;. Required.</value>
        [DataMember(Name = "reasonCode", IsRequired = true, EmitDefaultValue = false)]
        public string ReasonCode { get; set; }

        /// <summary>
        /// Type of redemption. Use STATEMENT_CREDIT. Optional.
        /// </summary>
        /// <value>Type of redemption. Use STATEMENT_CREDIT. Optional.</value>
        [DataMember(Name = "redemptionType", EmitDefaultValue = false)]
        public string RedemptionType { get; set; }

        /// <summary>
        /// Unique identifier of the user.
        /// </summary>
        /// <value>Unique identifier of the user.</value>
        [DataMember(Name = "userId", IsRequired = true, EmitDefaultValue = false)]
        public string UserId { get; set; }

        /// <summary>
        /// Identifier type for the given user such as RANAC. Optional.
        /// </summary>
        /// <value>Identifier type for the given user such as RANAC. Optional.</value>
        [DataMember(Name = "userIdType", EmitDefaultValue = false)]
        public string UserIdType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RedemptionRequest {\n");
            sb.Append("  CashBackAmount: ").Append(CashBackAmount).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  PaymentAuthId: ").Append(PaymentAuthId).Append("\n");
            sb.Append("  PointsRedeemed: ").Append(PointsRedeemed).Append("\n");
            sb.Append("  ReasonCode: ").Append(ReasonCode).Append("\n");
            sb.Append("  RedemptionType: ").Append(RedemptionType).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  UserIdType: ").Append(UserIdType).Append("\n");
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
            return this.Equals(input as RedemptionRequest);
        }

        /// <summary>
        /// Returns true if RedemptionRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of RedemptionRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RedemptionRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CashBackAmount == input.CashBackAmount ||
                    this.CashBackAmount.Equals(input.CashBackAmount)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.ExternalId == input.ExternalId ||
                    (this.ExternalId != null &&
                    this.ExternalId.Equals(input.ExternalId))
                ) && 
                (
                    this.PaymentAuthId == input.PaymentAuthId ||
                    (this.PaymentAuthId != null &&
                    this.PaymentAuthId.Equals(input.PaymentAuthId))
                ) && 
                (
                    this.PointsRedeemed == input.PointsRedeemed ||
                    this.PointsRedeemed.Equals(input.PointsRedeemed)
                ) && 
                (
                    this.ReasonCode == input.ReasonCode ||
                    (this.ReasonCode != null &&
                    this.ReasonCode.Equals(input.ReasonCode))
                ) && 
                (
                    this.RedemptionType == input.RedemptionType ||
                    (this.RedemptionType != null &&
                    this.RedemptionType.Equals(input.RedemptionType))
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
                hashCode = hashCode * 59 + this.CashBackAmount.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ExternalId != null)
                    hashCode = hashCode * 59 + this.ExternalId.GetHashCode();
                if (this.PaymentAuthId != null)
                    hashCode = hashCode * 59 + this.PaymentAuthId.GetHashCode();
                hashCode = hashCode * 59 + this.PointsRedeemed.GetHashCode();
                if (this.ReasonCode != null)
                    hashCode = hashCode * 59 + this.ReasonCode.GetHashCode();
                if (this.RedemptionType != null)
                    hashCode = hashCode * 59 + this.RedemptionType.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.UserIdType != null)
                    hashCode = hashCode * 59 + this.UserIdType.GetHashCode();
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
            // Description (string) maxLength
            if(this.Description != null && this.Description.Length > 160)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be less than 160.", new [] { "Description" });
            }

            // Description (string) minLength
            if(this.Description != null && this.Description.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be greater than 0.", new [] { "Description" });
            }

            // ExternalId (string) maxLength
            if(this.ExternalId != null && this.ExternalId.Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ExternalId, length must be less than 20.", new [] { "ExternalId" });
            }

            // ExternalId (string) minLength
            if(this.ExternalId != null && this.ExternalId.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ExternalId, length must be greater than 1.", new [] { "ExternalId" });
            }

            // PaymentAuthId (string) maxLength
            if(this.PaymentAuthId != null && this.PaymentAuthId.Length > 38)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PaymentAuthId, length must be less than 38.", new [] { "PaymentAuthId" });
            }

            // PaymentAuthId (string) minLength
            if(this.PaymentAuthId != null && this.PaymentAuthId.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PaymentAuthId, length must be greater than 1.", new [] { "PaymentAuthId" });
            }

            // ReasonCode (string) maxLength
            if(this.ReasonCode != null && this.ReasonCode.Length > 5)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ReasonCode, length must be less than 5.", new [] { "ReasonCode" });
            }

            // ReasonCode (string) minLength
            if(this.ReasonCode != null && this.ReasonCode.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ReasonCode, length must be greater than 1.", new [] { "ReasonCode" });
            }

            // RedemptionType (string) maxLength
            if(this.RedemptionType != null && this.RedemptionType.Length > 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RedemptionType, length must be less than 30.", new [] { "RedemptionType" });
            }

            // RedemptionType (string) minLength
            if(this.RedemptionType != null && this.RedemptionType.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RedemptionType, length must be greater than 0.", new [] { "RedemptionType" });
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
            if(this.UserIdType != null && this.UserIdType.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for UserIdType, length must be greater than 0.", new [] { "UserIdType" });
            }

            yield break;
        }
    }

}
