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
    /// ErrorErrorsError
    /// </summary>
    [DataContract(Name = "Error_Errors_Error")]
    public partial class ErrorErrorsError : IEquatable<ErrorErrorsError>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorErrorsError" /> class.
        /// </summary>
        /// <param name="source">Source where error occurred.</param>
        /// <param name="reasonCode">Reason code of error.</param>
        /// <param name="description">error description.</param>
        /// <param name="recoverable">Is Error recoverable if retried.</param>
        /// <param name="details">Error details.</param>
        public ErrorErrorsError(string source = default(string), string reasonCode = default(string), string description = default(string), bool recoverable = default(bool), string details = default(string))
        {
            this.Source = source;
            this.ReasonCode = reasonCode;
            this.Description = description;
            this.Recoverable = recoverable;
            this.Details = details;
        }

        /// <summary>
        /// Source where error occurred
        /// </summary>
        /// <value>Source where error occurred</value>
        [DataMember(Name = "Source", EmitDefaultValue = false)]
        public string Source { get; set; }

        /// <summary>
        /// Reason code of error
        /// </summary>
        /// <value>Reason code of error</value>
        [DataMember(Name = "ReasonCode", EmitDefaultValue = false)]
        public string ReasonCode { get; set; }

        /// <summary>
        /// error description
        /// </summary>
        /// <value>error description</value>
        [DataMember(Name = "Description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Is Error recoverable if retried
        /// </summary>
        /// <value>Is Error recoverable if retried</value>
        [DataMember(Name = "Recoverable", EmitDefaultValue = false)]
        public bool Recoverable { get; set; }

        /// <summary>
        /// Error details
        /// </summary>
        /// <value>Error details</value>
        [DataMember(Name = "Details", EmitDefaultValue = false)]
        public string Details { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ErrorErrorsError {\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  ReasonCode: ").Append(ReasonCode).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Recoverable: ").Append(Recoverable).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
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
            return this.Equals(input as ErrorErrorsError);
        }

        /// <summary>
        /// Returns true if ErrorErrorsError instances are equal
        /// </summary>
        /// <param name="input">Instance of ErrorErrorsError to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ErrorErrorsError input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && 
                (
                    this.ReasonCode == input.ReasonCode ||
                    (this.ReasonCode != null &&
                    this.ReasonCode.Equals(input.ReasonCode))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Recoverable == input.Recoverable ||
                    this.Recoverable.Equals(input.Recoverable)
                ) && 
                (
                    this.Details == input.Details ||
                    (this.Details != null &&
                    this.Details.Equals(input.Details))
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
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.ReasonCode != null)
                    hashCode = hashCode * 59 + this.ReasonCode.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                hashCode = hashCode * 59 + this.Recoverable.GetHashCode();
                if (this.Details != null)
                    hashCode = hashCode * 59 + this.Details.GetHashCode();
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
            yield break;
        }
    }

}