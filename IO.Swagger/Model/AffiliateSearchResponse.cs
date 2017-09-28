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
    /// AffiliateSearchResponse
    /// </summary>
    [DataContract]
    public partial class AffiliateSearchResponse :  IEquatable<AffiliateSearchResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AffiliateSearchResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AffiliateSearchResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AffiliateSearchResponse" /> class.
        /// </summary>
        /// <param name="Meta">Meta data about the results (required).</param>
        /// <param name="Results">Results.</param>
        public AffiliateSearchResponse(AffiliateSearchMeta Meta = default(AffiliateSearchMeta), List<AffiliateSearchResult> Results = default(List<AffiliateSearchResult>))
        {
            // to ensure "Meta" is required (not null)
            if (Meta == null)
            {
                throw new InvalidDataException("Meta is a required property for AffiliateSearchResponse and cannot be null");
            }
            else
            {
                this.Meta = Meta;
            }
            this.Results = Results;
        }
        
        /// <summary>
        /// Meta data about the results
        /// </summary>
        /// <value>Meta data about the results</value>
        [DataMember(Name="meta", EmitDefaultValue=false)]
        public AffiliateSearchMeta Meta { get; set; }

        /// <summary>
        /// Gets or Sets Results
        /// </summary>
        [DataMember(Name="results", EmitDefaultValue=false)]
        public List<AffiliateSearchResult> Results { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AffiliateSearchResponse {\n");
            sb.Append("  Meta: ").Append(Meta).Append("\n");
            sb.Append("  Results: ").Append(Results).Append("\n");
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
            return this.Equals(obj as AffiliateSearchResponse);
        }

        /// <summary>
        /// Returns true if AffiliateSearchResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of AffiliateSearchResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AffiliateSearchResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Meta == other.Meta ||
                    this.Meta != null &&
                    this.Meta.Equals(other.Meta)
                ) && 
                (
                    this.Results == other.Results ||
                    this.Results != null &&
                    this.Results.SequenceEqual(other.Results)
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
                if (this.Meta != null)
                    hash = hash * 59 + this.Meta.GetHashCode();
                if (this.Results != null)
                    hash = hash * 59 + this.Results.GetHashCode();
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
