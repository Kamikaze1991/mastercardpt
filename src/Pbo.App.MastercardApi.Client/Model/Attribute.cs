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
    /// Attribute
    /// </summary>
    [DataContract(Name = "Attribute")]
    public partial class Attribute : IEquatable<Attribute>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Attribute" /> class.
        /// </summary>
        /// <param name="name">Name of the conversion rule override..</param>
        /// <param name="value">Value assigned to the conversion rule override..</param>
        public Attribute(string name = default(string), string value = default(string))
        {
            this.Name = name;
            this.Value = value;
        }

        /// <summary>
        /// Name of the conversion rule override.
        /// </summary>
        /// <value>Name of the conversion rule override.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Value assigned to the conversion rule override.
        /// </summary>
        /// <value>Value assigned to the conversion rule override.</value>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Attribute {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as Attribute);
        }

        /// <summary>
        /// Returns true if Attribute instances are equal
        /// </summary>
        /// <param name="input">Instance of Attribute to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Attribute input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
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
