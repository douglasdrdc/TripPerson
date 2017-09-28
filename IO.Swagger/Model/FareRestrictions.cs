/* 
 * Amadeus Travel Innovation Sandbox
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 1.2
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// FareRestrictions
    /// </summary>
    [DataContract]
    public partial class FareRestrictions :  IEquatable<FareRestrictions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FareRestrictions" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FareRestrictions() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FareRestrictions" /> class.
        /// </summary>
        /// <param name="Refundable">Indicates whether this fare is refundable under some circumstances. Note that a refund charge or penalty may apply (required).</param>
        /// <param name="ChangePenalties">Indicates whether this fare allows the itinerary to be changed under some circumstances. Note that a change fee or penalty may apply (required).</param>
        public FareRestrictions(bool? Refundable = default(bool?), bool? ChangePenalties = default(bool?))
        {
            // to ensure "Refundable" is required (not null)
            if (Refundable == null)
            {
                throw new InvalidDataException("Refundable is a required property for FareRestrictions and cannot be null");
            }
            else
            {
                this.Refundable = Refundable;
            }
            // to ensure "ChangePenalties" is required (not null)
            if (ChangePenalties == null)
            {
                throw new InvalidDataException("ChangePenalties is a required property for FareRestrictions and cannot be null");
            }
            else
            {
                this.ChangePenalties = ChangePenalties;
            }
        }
        
        /// <summary>
        /// Indicates whether this fare is refundable under some circumstances. Note that a refund charge or penalty may apply
        /// </summary>
        /// <value>Indicates whether this fare is refundable under some circumstances. Note that a refund charge or penalty may apply</value>
        [DataMember(Name="refundable", EmitDefaultValue=false)]
        public bool? Refundable { get; set; }

        /// <summary>
        /// Indicates whether this fare allows the itinerary to be changed under some circumstances. Note that a change fee or penalty may apply
        /// </summary>
        /// <value>Indicates whether this fare allows the itinerary to be changed under some circumstances. Note that a change fee or penalty may apply</value>
        [DataMember(Name="change_penalties", EmitDefaultValue=false)]
        public bool? ChangePenalties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FareRestrictions {\n");
            sb.Append("  Refundable: ").Append(Refundable).Append("\n");
            sb.Append("  ChangePenalties: ").Append(ChangePenalties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as FareRestrictions);
        }

        /// <summary>
        /// Returns true if FareRestrictions instances are equal
        /// </summary>
        /// <param name="other">Instance of FareRestrictions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FareRestrictions other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Refundable == other.Refundable ||
                    this.Refundable != null &&
                    this.Refundable.Equals(other.Refundable)
                ) && 
                (
                    this.ChangePenalties == other.ChangePenalties ||
                    this.ChangePenalties != null &&
                    this.ChangePenalties.Equals(other.ChangePenalties)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Refundable != null)
                    hash = hash * 59 + this.Refundable.GetHashCode();
                if (this.ChangePenalties != null)
                    hash = hash * 59 + this.ChangePenalties.GetHashCode();
                return hash;
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
