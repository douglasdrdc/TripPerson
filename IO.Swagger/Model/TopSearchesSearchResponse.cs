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
    /// TopSearchesSearchResponse
    /// </summary>
    [DataContract]
    public partial class TopSearchesSearchResponse :  IEquatable<TopSearchesSearchResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TopSearchesSearchResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TopSearchesSearchResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TopSearchesSearchResponse" /> class.
        /// </summary>
        /// <param name="Market">Country code (required).</param>
        /// <param name="Period">The date period, in &lt;a href&#x3D;\&quot;https://en.wikipedia.org/wiki/ISO_8601\&quot;&gt;ISO 8601&lt;/a&gt; date format YYYY-MM or YYYY (required).</param>
        /// <param name="Origin">&lt;a href&#x3D;\&quot;https://en.wikipedia.org/wiki/International_Air_Transport_Association_airport_code\&quot;&gt;IATA code&lt;/a&gt; (required).</param>
        /// <param name="Destination">&lt;a href&#x3D;\&quot;https://en.wikipedia.org/wiki/International_Air_Transport_Association_airport_code\&quot;&gt;IATA code&lt;/a&gt; (required).</param>
        /// <param name="Results">Results (required).</param>
        public TopSearchesSearchResponse(string Market = default(string), string Period = default(string), string Origin = default(string), string Destination = default(string), List<TopSearchesSearchResult> Results = default(List<TopSearchesSearchResult>))
        {
            // to ensure "Market" is required (not null)
            if (Market == null)
            {
                throw new InvalidDataException("Market is a required property for TopSearchesSearchResponse and cannot be null");
            }
            else
            {
                this.Market = Market;
            }
            // to ensure "Period" is required (not null)
            if (Period == null)
            {
                throw new InvalidDataException("Period is a required property for TopSearchesSearchResponse and cannot be null");
            }
            else
            {
                this.Period = Period;
            }
            // to ensure "Origin" is required (not null)
            if (Origin == null)
            {
                throw new InvalidDataException("Origin is a required property for TopSearchesSearchResponse and cannot be null");
            }
            else
            {
                this.Origin = Origin;
            }
            // to ensure "Destination" is required (not null)
            if (Destination == null)
            {
                throw new InvalidDataException("Destination is a required property for TopSearchesSearchResponse and cannot be null");
            }
            else
            {
                this.Destination = Destination;
            }
            // to ensure "Results" is required (not null)
            if (Results == null)
            {
                throw new InvalidDataException("Results is a required property for TopSearchesSearchResponse and cannot be null");
            }
            else
            {
                this.Results = Results;
            }
        }
        
        /// <summary>
        /// Country code
        /// </summary>
        /// <value>Country code</value>
        [DataMember(Name="market", EmitDefaultValue=false)]
        public string Market { get; set; }

        /// <summary>
        /// The date period, in &lt;a href&#x3D;\&quot;https://en.wikipedia.org/wiki/ISO_8601\&quot;&gt;ISO 8601&lt;/a&gt; date format YYYY-MM or YYYY
        /// </summary>
        /// <value>The date period, in &lt;a href&#x3D;\&quot;https://en.wikipedia.org/wiki/ISO_8601\&quot;&gt;ISO 8601&lt;/a&gt; date format YYYY-MM or YYYY</value>
        [DataMember(Name="period", EmitDefaultValue=false)]
        public string Period { get; set; }

        /// <summary>
        /// &lt;a href&#x3D;\&quot;https://en.wikipedia.org/wiki/International_Air_Transport_Association_airport_code\&quot;&gt;IATA code&lt;/a&gt;
        /// </summary>
        /// <value>&lt;a href&#x3D;\&quot;https://en.wikipedia.org/wiki/International_Air_Transport_Association_airport_code\&quot;&gt;IATA code&lt;/a&gt;</value>
        [DataMember(Name="origin", EmitDefaultValue=false)]
        public string Origin { get; set; }

        /// <summary>
        /// &lt;a href&#x3D;\&quot;https://en.wikipedia.org/wiki/International_Air_Transport_Association_airport_code\&quot;&gt;IATA code&lt;/a&gt;
        /// </summary>
        /// <value>&lt;a href&#x3D;\&quot;https://en.wikipedia.org/wiki/International_Air_Transport_Association_airport_code\&quot;&gt;IATA code&lt;/a&gt;</value>
        [DataMember(Name="destination", EmitDefaultValue=false)]
        public string Destination { get; set; }

        /// <summary>
        /// Gets or Sets Results
        /// </summary>
        [DataMember(Name="results", EmitDefaultValue=false)]
        public List<TopSearchesSearchResult> Results { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TopSearchesSearchResponse {\n");
            sb.Append("  Market: ").Append(Market).Append("\n");
            sb.Append("  Period: ").Append(Period).Append("\n");
            sb.Append("  Origin: ").Append(Origin).Append("\n");
            sb.Append("  Destination: ").Append(Destination).Append("\n");
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
            return this.Equals(obj as TopSearchesSearchResponse);
        }

        /// <summary>
        /// Returns true if TopSearchesSearchResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of TopSearchesSearchResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TopSearchesSearchResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Market == other.Market ||
                    this.Market != null &&
                    this.Market.Equals(other.Market)
                ) && 
                (
                    this.Period == other.Period ||
                    this.Period != null &&
                    this.Period.Equals(other.Period)
                ) && 
                (
                    this.Origin == other.Origin ||
                    this.Origin != null &&
                    this.Origin.Equals(other.Origin)
                ) && 
                (
                    this.Destination == other.Destination ||
                    this.Destination != null &&
                    this.Destination.Equals(other.Destination)
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
                if (this.Market != null)
                    hash = hash * 59 + this.Market.GetHashCode();
                if (this.Period != null)
                    hash = hash * 59 + this.Period.GetHashCode();
                if (this.Origin != null)
                    hash = hash * 59 + this.Origin.GetHashCode();
                if (this.Destination != null)
                    hash = hash * 59 + this.Destination.GetHashCode();
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
