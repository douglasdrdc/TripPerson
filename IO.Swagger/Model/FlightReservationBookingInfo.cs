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
    /// FlightReservationBookingInfo
    /// </summary>
    [DataContract]
    public partial class FlightReservationBookingInfo :  IEquatable<FlightReservationBookingInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FlightReservationBookingInfo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FlightReservationBookingInfo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FlightReservationBookingInfo" /> class.
        /// </summary>
        /// <param name="TravelClass">The cabin class offered on this flight. An enumeration that will read either ECONOMY, PREMIUM_ECONOMY, BUSINESS or FIRST (required).</param>
        /// <param name="BookingCode">The Reservation Booking Designator code that determines the quality and terms of the flight offered for the given price. A single letter from A..Z (required).</param>
        /// <param name="AirlineRecordLocator">6 character identifier of this travel record on the airline&#39;s system. May be the same as the global record locator. (required).</param>
        /// <param name="Status">An enumeration to represent the reservation status for this seat on this flight. For example&amp;colon; CONFIRMED, CANCELLED, RESCHEDULED, FLIGHT_CANCELLED, WAITLISTED. (required).</param>
        public FlightReservationBookingInfo(string TravelClass = default(string), string BookingCode = default(string), string AirlineRecordLocator = default(string), string Status = default(string))
        {
            // to ensure "TravelClass" is required (not null)
            if (TravelClass == null)
            {
                throw new InvalidDataException("TravelClass is a required property for FlightReservationBookingInfo and cannot be null");
            }
            else
            {
                this.TravelClass = TravelClass;
            }
            // to ensure "BookingCode" is required (not null)
            if (BookingCode == null)
            {
                throw new InvalidDataException("BookingCode is a required property for FlightReservationBookingInfo and cannot be null");
            }
            else
            {
                this.BookingCode = BookingCode;
            }
            // to ensure "AirlineRecordLocator" is required (not null)
            if (AirlineRecordLocator == null)
            {
                throw new InvalidDataException("AirlineRecordLocator is a required property for FlightReservationBookingInfo and cannot be null");
            }
            else
            {
                this.AirlineRecordLocator = AirlineRecordLocator;
            }
            // to ensure "Status" is required (not null)
            if (Status == null)
            {
                throw new InvalidDataException("Status is a required property for FlightReservationBookingInfo and cannot be null");
            }
            else
            {
                this.Status = Status;
            }
        }
        
        /// <summary>
        /// The cabin class offered on this flight. An enumeration that will read either ECONOMY, PREMIUM_ECONOMY, BUSINESS or FIRST
        /// </summary>
        /// <value>The cabin class offered on this flight. An enumeration that will read either ECONOMY, PREMIUM_ECONOMY, BUSINESS or FIRST</value>
        [DataMember(Name="travel_class", EmitDefaultValue=false)]
        public string TravelClass { get; set; }

        /// <summary>
        /// The Reservation Booking Designator code that determines the quality and terms of the flight offered for the given price. A single letter from A..Z
        /// </summary>
        /// <value>The Reservation Booking Designator code that determines the quality and terms of the flight offered for the given price. A single letter from A..Z</value>
        [DataMember(Name="booking_code", EmitDefaultValue=false)]
        public string BookingCode { get; set; }

        /// <summary>
        /// 6 character identifier of this travel record on the airline&#39;s system. May be the same as the global record locator.
        /// </summary>
        /// <value>6 character identifier of this travel record on the airline&#39;s system. May be the same as the global record locator.</value>
        [DataMember(Name="airline_record_locator", EmitDefaultValue=false)]
        public string AirlineRecordLocator { get; set; }

        /// <summary>
        /// An enumeration to represent the reservation status for this seat on this flight. For example&amp;colon; CONFIRMED, CANCELLED, RESCHEDULED, FLIGHT_CANCELLED, WAITLISTED.
        /// </summary>
        /// <value>An enumeration to represent the reservation status for this seat on this flight. For example&amp;colon; CONFIRMED, CANCELLED, RESCHEDULED, FLIGHT_CANCELLED, WAITLISTED.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlightReservationBookingInfo {\n");
            sb.Append("  TravelClass: ").Append(TravelClass).Append("\n");
            sb.Append("  BookingCode: ").Append(BookingCode).Append("\n");
            sb.Append("  AirlineRecordLocator: ").Append(AirlineRecordLocator).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(obj as FlightReservationBookingInfo);
        }

        /// <summary>
        /// Returns true if FlightReservationBookingInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of FlightReservationBookingInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FlightReservationBookingInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TravelClass == other.TravelClass ||
                    this.TravelClass != null &&
                    this.TravelClass.Equals(other.TravelClass)
                ) && 
                (
                    this.BookingCode == other.BookingCode ||
                    this.BookingCode != null &&
                    this.BookingCode.Equals(other.BookingCode)
                ) && 
                (
                    this.AirlineRecordLocator == other.AirlineRecordLocator ||
                    this.AirlineRecordLocator != null &&
                    this.AirlineRecordLocator.Equals(other.AirlineRecordLocator)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
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
                if (this.TravelClass != null)
                    hash = hash * 59 + this.TravelClass.GetHashCode();
                if (this.BookingCode != null)
                    hash = hash * 59 + this.BookingCode.GetHashCode();
                if (this.AirlineRecordLocator != null)
                    hash = hash * 59 + this.AirlineRecordLocator.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
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
