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
    /// RailStationResponse
    /// </summary>
    [DataContract]
    public partial class RailStationResponse :  IEquatable<RailStationResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RailStationResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RailStationResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RailStationResponse" /> class.
        /// </summary>
        /// <param name="Id">The ID of this station, as provided in the request (required).</param>
        /// <param name="Type">The type of code to which this station refers. Some codes represent agglomeration of multiple stations, whereas others represent an individual station. Possible values are AGGLOMERATION and STATION. (required).</param>
        /// <param name="Name">The name of this station. (required).</param>
        /// <param name="ShortName">The shortened name of this station (20 characters max) which may be used in certain cases. (required).</param>
        /// <param name="Country">The &lt;a href&#x3D;\&quot;http://en.wikipedia.org/wiki/ISO_3166-1_alpha-2\&quot;&gt;ISO 3166-1 alpha-2 country code&lt;/a&gt; in which this station can be found. (required).</param>
        /// <param name="Location">This stations&#39;s approximate geolocation.  (required).</param>
        /// <param name="Traffic">An indication of the level of Intercity traffic passing through this station. (required).</param>
        public RailStationResponse(string Id = default(string), string Type = default(string), string Name = default(string), string ShortName = default(string), string Country = default(string), Geolocation Location = default(Geolocation), string Traffic = default(string))
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for RailStationResponse and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "Type" is required (not null)
            if (Type == null)
            {
                throw new InvalidDataException("Type is a required property for RailStationResponse and cannot be null");
            }
            else
            {
                this.Type = Type;
            }
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for RailStationResponse and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "ShortName" is required (not null)
            if (ShortName == null)
            {
                throw new InvalidDataException("ShortName is a required property for RailStationResponse and cannot be null");
            }
            else
            {
                this.ShortName = ShortName;
            }
            // to ensure "Country" is required (not null)
            if (Country == null)
            {
                throw new InvalidDataException("Country is a required property for RailStationResponse and cannot be null");
            }
            else
            {
                this.Country = Country;
            }
            // to ensure "Location" is required (not null)
            if (Location == null)
            {
                throw new InvalidDataException("Location is a required property for RailStationResponse and cannot be null");
            }
            else
            {
                this.Location = Location;
            }
            // to ensure "Traffic" is required (not null)
            if (Traffic == null)
            {
                throw new InvalidDataException("Traffic is a required property for RailStationResponse and cannot be null");
            }
            else
            {
                this.Traffic = Traffic;
            }
        }
        
        /// <summary>
        /// The ID of this station, as provided in the request
        /// </summary>
        /// <value>The ID of this station, as provided in the request</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The type of code to which this station refers. Some codes represent agglomeration of multiple stations, whereas others represent an individual station. Possible values are AGGLOMERATION and STATION.
        /// </summary>
        /// <value>The type of code to which this station refers. Some codes represent agglomeration of multiple stations, whereas others represent an individual station. Possible values are AGGLOMERATION and STATION.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// The name of this station.
        /// </summary>
        /// <value>The name of this station.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The shortened name of this station (20 characters max) which may be used in certain cases.
        /// </summary>
        /// <value>The shortened name of this station (20 characters max) which may be used in certain cases.</value>
        [DataMember(Name="short_name", EmitDefaultValue=false)]
        public string ShortName { get; set; }

        /// <summary>
        /// The &lt;a href&#x3D;\&quot;http://en.wikipedia.org/wiki/ISO_3166-1_alpha-2\&quot;&gt;ISO 3166-1 alpha-2 country code&lt;/a&gt; in which this station can be found.
        /// </summary>
        /// <value>The &lt;a href&#x3D;\&quot;http://en.wikipedia.org/wiki/ISO_3166-1_alpha-2\&quot;&gt;ISO 3166-1 alpha-2 country code&lt;/a&gt; in which this station can be found.</value>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// This stations&#39;s approximate geolocation. 
        /// </summary>
        /// <value>This stations&#39;s approximate geolocation. </value>
        [DataMember(Name="location", EmitDefaultValue=false)]
        public Geolocation Location { get; set; }

        /// <summary>
        /// An indication of the level of Intercity traffic passing through this station.
        /// </summary>
        /// <value>An indication of the level of Intercity traffic passing through this station.</value>
        [DataMember(Name="traffic", EmitDefaultValue=false)]
        public string Traffic { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RailStationResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ShortName: ").Append(ShortName).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  Traffic: ").Append(Traffic).Append("\n");
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
            return this.Equals(obj as RailStationResponse);
        }

        /// <summary>
        /// Returns true if RailStationResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of RailStationResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RailStationResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.ShortName == other.ShortName ||
                    this.ShortName != null &&
                    this.ShortName.Equals(other.ShortName)
                ) && 
                (
                    this.Country == other.Country ||
                    this.Country != null &&
                    this.Country.Equals(other.Country)
                ) && 
                (
                    this.Location == other.Location ||
                    this.Location != null &&
                    this.Location.Equals(other.Location)
                ) && 
                (
                    this.Traffic == other.Traffic ||
                    this.Traffic != null &&
                    this.Traffic.Equals(other.Traffic)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.ShortName != null)
                    hash = hash * 59 + this.ShortName.GetHashCode();
                if (this.Country != null)
                    hash = hash * 59 + this.Country.GetHashCode();
                if (this.Location != null)
                    hash = hash * 59 + this.Location.GetHashCode();
                if (this.Traffic != null)
                    hash = hash * 59 + this.Traffic.GetHashCode();
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
