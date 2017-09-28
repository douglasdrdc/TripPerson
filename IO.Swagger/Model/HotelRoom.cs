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
    /// HotelRoom
    /// </summary>
    [DataContract]
    public partial class HotelRoom :  IEquatable<HotelRoom>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HotelRoom" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected HotelRoom() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="HotelRoom" /> class.
        /// </summary>
        /// <param name="BookingCode">The booking code identifies a product at the hotel. It can be used to book a room. (required).</param>
        /// <param name="RoomTypeCode">A 3-letter code to identify a specific room type..</param>
        /// <param name="RatePlanCode">A 3 letter code to designate different rates base on traveler type..</param>
        /// <param name="TotalAmount">The total price of staying in this room from the given check-in date to the given check-out date.</param>
        /// <param name="Rates">The total price of staying in this room from the given check-in date to the given check-out date.</param>
        /// <param name="Descriptions">An array of description strings describing room and rate types features.</param>
        /// <param name="RoomTypeInfo">RoomTypeInfo.</param>
        /// <param name="RateTypeCode">The unique rate code used by the hotel chain to price this room&#39;s rate.</param>
        public HotelRoom(string BookingCode = default(string), string RoomTypeCode = default(string), string RatePlanCode = default(string), Amount TotalAmount = default(Amount), List<PeriodRate> Rates = default(List<PeriodRate>), List<string> Descriptions = default(List<string>), RoomInfo RoomTypeInfo = default(RoomInfo), string RateTypeCode = default(string))
        {
            // to ensure "BookingCode" is required (not null)
            if (BookingCode == null)
            {
                throw new InvalidDataException("BookingCode is a required property for HotelRoom and cannot be null");
            }
            else
            {
                this.BookingCode = BookingCode;
            }
            this.RoomTypeCode = RoomTypeCode;
            this.RatePlanCode = RatePlanCode;
            this.TotalAmount = TotalAmount;
            this.Rates = Rates;
            this.Descriptions = Descriptions;
            this.RoomTypeInfo = RoomTypeInfo;
            this.RateTypeCode = RateTypeCode;
        }
        
        /// <summary>
        /// The booking code identifies a product at the hotel. It can be used to book a room.
        /// </summary>
        /// <value>The booking code identifies a product at the hotel. It can be used to book a room.</value>
        [DataMember(Name="booking_code", EmitDefaultValue=false)]
        public string BookingCode { get; set; }

        /// <summary>
        /// A 3-letter code to identify a specific room type.
        /// </summary>
        /// <value>A 3-letter code to identify a specific room type.</value>
        [DataMember(Name="room_type_code", EmitDefaultValue=false)]
        public string RoomTypeCode { get; set; }

        /// <summary>
        /// A 3 letter code to designate different rates base on traveler type.
        /// </summary>
        /// <value>A 3 letter code to designate different rates base on traveler type.</value>
        [DataMember(Name="rate_plan_code", EmitDefaultValue=false)]
        public string RatePlanCode { get; set; }

        /// <summary>
        /// The total price of staying in this room from the given check-in date to the given check-out date
        /// </summary>
        /// <value>The total price of staying in this room from the given check-in date to the given check-out date</value>
        [DataMember(Name="total_amount", EmitDefaultValue=false)]
        public Amount TotalAmount { get; set; }

        /// <summary>
        /// The total price of staying in this room from the given check-in date to the given check-out date
        /// </summary>
        /// <value>The total price of staying in this room from the given check-in date to the given check-out date</value>
        [DataMember(Name="rates", EmitDefaultValue=false)]
        public List<PeriodRate> Rates { get; set; }

        /// <summary>
        /// An array of description strings describing room and rate types features
        /// </summary>
        /// <value>An array of description strings describing room and rate types features</value>
        [DataMember(Name="descriptions", EmitDefaultValue=false)]
        public List<string> Descriptions { get; set; }

        /// <summary>
        /// Gets or Sets RoomTypeInfo
        /// </summary>
        [DataMember(Name="room_type_info", EmitDefaultValue=false)]
        public RoomInfo RoomTypeInfo { get; set; }

        /// <summary>
        /// The unique rate code used by the hotel chain to price this room&#39;s rate
        /// </summary>
        /// <value>The unique rate code used by the hotel chain to price this room&#39;s rate</value>
        [DataMember(Name="rate_type_code", EmitDefaultValue=false)]
        public string RateTypeCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HotelRoom {\n");
            sb.Append("  BookingCode: ").Append(BookingCode).Append("\n");
            sb.Append("  RoomTypeCode: ").Append(RoomTypeCode).Append("\n");
            sb.Append("  RatePlanCode: ").Append(RatePlanCode).Append("\n");
            sb.Append("  TotalAmount: ").Append(TotalAmount).Append("\n");
            sb.Append("  Rates: ").Append(Rates).Append("\n");
            sb.Append("  Descriptions: ").Append(Descriptions).Append("\n");
            sb.Append("  RoomTypeInfo: ").Append(RoomTypeInfo).Append("\n");
            sb.Append("  RateTypeCode: ").Append(RateTypeCode).Append("\n");
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
            return this.Equals(obj as HotelRoom);
        }

        /// <summary>
        /// Returns true if HotelRoom instances are equal
        /// </summary>
        /// <param name="other">Instance of HotelRoom to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HotelRoom other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.BookingCode == other.BookingCode ||
                    this.BookingCode != null &&
                    this.BookingCode.Equals(other.BookingCode)
                ) && 
                (
                    this.RoomTypeCode == other.RoomTypeCode ||
                    this.RoomTypeCode != null &&
                    this.RoomTypeCode.Equals(other.RoomTypeCode)
                ) && 
                (
                    this.RatePlanCode == other.RatePlanCode ||
                    this.RatePlanCode != null &&
                    this.RatePlanCode.Equals(other.RatePlanCode)
                ) && 
                (
                    this.TotalAmount == other.TotalAmount ||
                    this.TotalAmount != null &&
                    this.TotalAmount.Equals(other.TotalAmount)
                ) && 
                (
                    this.Rates == other.Rates ||
                    this.Rates != null &&
                    this.Rates.SequenceEqual(other.Rates)
                ) && 
                (
                    this.Descriptions == other.Descriptions ||
                    this.Descriptions != null &&
                    this.Descriptions.SequenceEqual(other.Descriptions)
                ) && 
                (
                    this.RoomTypeInfo == other.RoomTypeInfo ||
                    this.RoomTypeInfo != null &&
                    this.RoomTypeInfo.Equals(other.RoomTypeInfo)
                ) && 
                (
                    this.RateTypeCode == other.RateTypeCode ||
                    this.RateTypeCode != null &&
                    this.RateTypeCode.Equals(other.RateTypeCode)
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
                if (this.BookingCode != null)
                    hash = hash * 59 + this.BookingCode.GetHashCode();
                if (this.RoomTypeCode != null)
                    hash = hash * 59 + this.RoomTypeCode.GetHashCode();
                if (this.RatePlanCode != null)
                    hash = hash * 59 + this.RatePlanCode.GetHashCode();
                if (this.TotalAmount != null)
                    hash = hash * 59 + this.TotalAmount.GetHashCode();
                if (this.Rates != null)
                    hash = hash * 59 + this.Rates.GetHashCode();
                if (this.Descriptions != null)
                    hash = hash * 59 + this.Descriptions.GetHashCode();
                if (this.RoomTypeInfo != null)
                    hash = hash * 59 + this.RoomTypeInfo.GetHashCode();
                if (this.RateTypeCode != null)
                    hash = hash * 59 + this.RateTypeCode.GetHashCode();
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
