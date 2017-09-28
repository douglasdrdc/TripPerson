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
    /// NearestAirport
    /// </summary>
    [DataContract]
    public partial class NearestAirport :  IEquatable<NearestAirport>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NearestAirport" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NearestAirport() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NearestAirport" /> class.
        /// </summary>
        /// <param name="Airport">The 3 letter IATA airport code of this given airport. You can use this as an input parameter for a low-fare flight search, to get more specific results than the city code, but inspiration search works best using the city code. (required).</param>
        /// <param name="AirportName">The name of this airport, in UTF-8 format (required).</param>
        /// <param name="City">The three letter &lt;a href&#x3D;\&quot;https://en.wikipedia.org/wiki/International_Air_Transport_Association_airport_code\&quot;&gt;IATA code&lt;/a&gt; of the city of the city in which this airport is located. (required).</param>
        /// <param name="CityName">The English name of the city in which this airport is located (required).</param>
        /// <param name="State">The state code of this city, if applicable.</param>
        /// <param name="Distance">The distance in km from the point specified in the query, to this location (required).</param>
        /// <param name="Location">  An object containing the longitude and latitude of the given airport. (required).</param>
        /// <param name="AircraftMovements">The annual number of aircraft movements at that airport..</param>
        /// <param name="Timezone">The &lt;a href&#x3D;\&quot;http://en.wikipedia.org/wiki/List_of_tz_database_time_zones\&quot;&gt;Olson format&lt;/a&gt; name of the timezone in which this airport is located (required).</param>
        public NearestAirport(string Airport = default(string), string AirportName = default(string), string City = default(string), string CityName = default(string), string State = default(string), decimal? Distance = default(decimal?), Geolocation Location = default(Geolocation), int? AircraftMovements = default(int?), string Timezone = default(string))
        {
            // to ensure "Airport" is required (not null)
            if (Airport == null)
            {
                throw new InvalidDataException("Airport is a required property for NearestAirport and cannot be null");
            }
            else
            {
                this.Airport = Airport;
            }
            // to ensure "AirportName" is required (not null)
            if (AirportName == null)
            {
                throw new InvalidDataException("AirportName is a required property for NearestAirport and cannot be null");
            }
            else
            {
                this.AirportName = AirportName;
            }
            // to ensure "City" is required (not null)
            if (City == null)
            {
                throw new InvalidDataException("City is a required property for NearestAirport and cannot be null");
            }
            else
            {
                this.City = City;
            }
            // to ensure "CityName" is required (not null)
            if (CityName == null)
            {
                throw new InvalidDataException("CityName is a required property for NearestAirport and cannot be null");
            }
            else
            {
                this.CityName = CityName;
            }
            // to ensure "Distance" is required (not null)
            if (Distance == null)
            {
                throw new InvalidDataException("Distance is a required property for NearestAirport and cannot be null");
            }
            else
            {
                this.Distance = Distance;
            }
            // to ensure "Location" is required (not null)
            if (Location == null)
            {
                throw new InvalidDataException("Location is a required property for NearestAirport and cannot be null");
            }
            else
            {
                this.Location = Location;
            }
            // to ensure "Timezone" is required (not null)
            if (Timezone == null)
            {
                throw new InvalidDataException("Timezone is a required property for NearestAirport and cannot be null");
            }
            else
            {
                this.Timezone = Timezone;
            }
            this.State = State;
            this.AircraftMovements = AircraftMovements;
        }
        
        /// <summary>
        /// The 3 letter IATA airport code of this given airport. You can use this as an input parameter for a low-fare flight search, to get more specific results than the city code, but inspiration search works best using the city code.
        /// </summary>
        /// <value>The 3 letter IATA airport code of this given airport. You can use this as an input parameter for a low-fare flight search, to get more specific results than the city code, but inspiration search works best using the city code.</value>
        [DataMember(Name="airport", EmitDefaultValue=false)]
        public string Airport { get; set; }

        /// <summary>
        /// The name of this airport, in UTF-8 format
        /// </summary>
        /// <value>The name of this airport, in UTF-8 format</value>
        [DataMember(Name="airport_name", EmitDefaultValue=false)]
        public string AirportName { get; set; }

        /// <summary>
        /// The three letter &lt;a href&#x3D;\&quot;https://en.wikipedia.org/wiki/International_Air_Transport_Association_airport_code\&quot;&gt;IATA code&lt;/a&gt; of the city of the city in which this airport is located.
        /// </summary>
        /// <value>The three letter &lt;a href&#x3D;\&quot;https://en.wikipedia.org/wiki/International_Air_Transport_Association_airport_code\&quot;&gt;IATA code&lt;/a&gt; of the city of the city in which this airport is located.</value>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string City { get; set; }

        /// <summary>
        /// The English name of the city in which this airport is located
        /// </summary>
        /// <value>The English name of the city in which this airport is located</value>
        [DataMember(Name="city_name", EmitDefaultValue=false)]
        public string CityName { get; set; }

        /// <summary>
        /// The state code of this city, if applicable
        /// </summary>
        /// <value>The state code of this city, if applicable</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; set; }

        /// <summary>
        /// The distance in km from the point specified in the query, to this location
        /// </summary>
        /// <value>The distance in km from the point specified in the query, to this location</value>
        [DataMember(Name="distance", EmitDefaultValue=false)]
        public decimal? Distance { get; set; }

        /// <summary>
        ///   An object containing the longitude and latitude of the given airport.
        /// </summary>
        /// <value>  An object containing the longitude and latitude of the given airport.</value>
        [DataMember(Name="location", EmitDefaultValue=false)]
        public Geolocation Location { get; set; }

        /// <summary>
        /// The annual number of aircraft movements at that airport.
        /// </summary>
        /// <value>The annual number of aircraft movements at that airport.</value>
        [DataMember(Name="aircraft_movements", EmitDefaultValue=false)]
        public int? AircraftMovements { get; set; }

        /// <summary>
        /// The &lt;a href&#x3D;\&quot;http://en.wikipedia.org/wiki/List_of_tz_database_time_zones\&quot;&gt;Olson format&lt;/a&gt; name of the timezone in which this airport is located
        /// </summary>
        /// <value>The &lt;a href&#x3D;\&quot;http://en.wikipedia.org/wiki/List_of_tz_database_time_zones\&quot;&gt;Olson format&lt;/a&gt; name of the timezone in which this airport is located</value>
        [DataMember(Name="timezone", EmitDefaultValue=false)]
        public string Timezone { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NearestAirport {\n");
            sb.Append("  Airport: ").Append(Airport).Append("\n");
            sb.Append("  AirportName: ").Append(AirportName).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  CityName: ").Append(CityName).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Distance: ").Append(Distance).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  AircraftMovements: ").Append(AircraftMovements).Append("\n");
            sb.Append("  Timezone: ").Append(Timezone).Append("\n");
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
            return this.Equals(obj as NearestAirport);
        }

        /// <summary>
        /// Returns true if NearestAirport instances are equal
        /// </summary>
        /// <param name="other">Instance of NearestAirport to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NearestAirport other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Airport == other.Airport ||
                    this.Airport != null &&
                    this.Airport.Equals(other.Airport)
                ) && 
                (
                    this.AirportName == other.AirportName ||
                    this.AirportName != null &&
                    this.AirportName.Equals(other.AirportName)
                ) && 
                (
                    this.City == other.City ||
                    this.City != null &&
                    this.City.Equals(other.City)
                ) && 
                (
                    this.CityName == other.CityName ||
                    this.CityName != null &&
                    this.CityName.Equals(other.CityName)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) && 
                (
                    this.Distance == other.Distance ||
                    this.Distance != null &&
                    this.Distance.Equals(other.Distance)
                ) && 
                (
                    this.Location == other.Location ||
                    this.Location != null &&
                    this.Location.Equals(other.Location)
                ) && 
                (
                    this.AircraftMovements == other.AircraftMovements ||
                    this.AircraftMovements != null &&
                    this.AircraftMovements.Equals(other.AircraftMovements)
                ) && 
                (
                    this.Timezone == other.Timezone ||
                    this.Timezone != null &&
                    this.Timezone.Equals(other.Timezone)
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
                if (this.Airport != null)
                    hash = hash * 59 + this.Airport.GetHashCode();
                if (this.AirportName != null)
                    hash = hash * 59 + this.AirportName.GetHashCode();
                if (this.City != null)
                    hash = hash * 59 + this.City.GetHashCode();
                if (this.CityName != null)
                    hash = hash * 59 + this.CityName.GetHashCode();
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                if (this.Distance != null)
                    hash = hash * 59 + this.Distance.GetHashCode();
                if (this.Location != null)
                    hash = hash * 59 + this.Location.GetHashCode();
                if (this.AircraftMovements != null)
                    hash = hash * 59 + this.AircraftMovements.GetHashCode();
                if (this.Timezone != null)
                    hash = hash * 59 + this.Timezone.GetHashCode();
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
