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
    /// CarReservationBookingInfo
    /// </summary>
    [DataContract]
    public partial class CarReservationBookingInfo :  IEquatable<CarReservationBookingInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CarReservationBookingInfo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CarReservationBookingInfo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CarReservationBookingInfo" /> class.
        /// </summary>
        /// <param name="ReservationCode">The identifier of this reservation in the car rental provider&#39;s system. This should be provided at the rental office to identify your reservation. (required).</param>
        /// <param name="Status">An enumeration to represent the reservation status for this car rental. For example&amp;colon; CONFIRMED, CANCELLED, REQUESTED, REJECTED, PENDING_CANCELLATION, PENDING_CONFIRMATION. (required).</param>
        public CarReservationBookingInfo(string ReservationCode = default(string), string Status = default(string))
        {
            // to ensure "ReservationCode" is required (not null)
            if (ReservationCode == null)
            {
                throw new InvalidDataException("ReservationCode is a required property for CarReservationBookingInfo and cannot be null");
            }
            else
            {
                this.ReservationCode = ReservationCode;
            }
            // to ensure "Status" is required (not null)
            if (Status == null)
            {
                throw new InvalidDataException("Status is a required property for CarReservationBookingInfo and cannot be null");
            }
            else
            {
                this.Status = Status;
            }
        }
        
        /// <summary>
        /// The identifier of this reservation in the car rental provider&#39;s system. This should be provided at the rental office to identify your reservation.
        /// </summary>
        /// <value>The identifier of this reservation in the car rental provider&#39;s system. This should be provided at the rental office to identify your reservation.</value>
        [DataMember(Name="reservation_code", EmitDefaultValue=false)]
        public string ReservationCode { get; set; }

        /// <summary>
        /// An enumeration to represent the reservation status for this car rental. For example&amp;colon; CONFIRMED, CANCELLED, REQUESTED, REJECTED, PENDING_CANCELLATION, PENDING_CONFIRMATION.
        /// </summary>
        /// <value>An enumeration to represent the reservation status for this car rental. For example&amp;colon; CONFIRMED, CANCELLED, REQUESTED, REJECTED, PENDING_CANCELLATION, PENDING_CONFIRMATION.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CarReservationBookingInfo {\n");
            sb.Append("  ReservationCode: ").Append(ReservationCode).Append("\n");
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
            return this.Equals(obj as CarReservationBookingInfo);
        }

        /// <summary>
        /// Returns true if CarReservationBookingInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of CarReservationBookingInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CarReservationBookingInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ReservationCode == other.ReservationCode ||
                    this.ReservationCode != null &&
                    this.ReservationCode.Equals(other.ReservationCode)
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
                if (this.ReservationCode != null)
                    hash = hash * 59 + this.ReservationCode.GetHashCode();
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
