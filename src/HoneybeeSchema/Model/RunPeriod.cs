/* 
 * Honeybee Energy Simulation Parameter Schema
 *
 * This is the documentation for Honeybee energy simulation parameter schema.
 *
 * The version of the OpenAPI document: 1.23.0
 * Contact: info@ladybug.tools
 * Generated by: https://github.com/openapitools/openapi-generator.git
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


namespace HoneybeeSchema
{
    /// <summary>
    /// Used to describe the time period over which to run the simulation.
    /// </summary>
    [DataContract]
    public partial class RunPeriod :  IEquatable<RunPeriod>, IValidatableObject
    {
        /// <summary>
        /// Text for the day of the week on which the simulation starts.
        /// </summary>
        /// <value>Text for the day of the week on which the simulation starts.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StartDayOfWeekEnum
        {
            /// <summary>
            /// Enum Sunday for value: Sunday
            /// </summary>
            [EnumMember(Value = "Sunday")]
            Sunday = 1,

            /// <summary>
            /// Enum Monday for value: Monday
            /// </summary>
            [EnumMember(Value = "Monday")]
            Monday = 2,

            /// <summary>
            /// Enum Tuesday for value: Tuesday
            /// </summary>
            [EnumMember(Value = "Tuesday")]
            Tuesday = 3,

            /// <summary>
            /// Enum Wednesday for value: Wednesday
            /// </summary>
            [EnumMember(Value = "Wednesday")]
            Wednesday = 4,

            /// <summary>
            /// Enum Thursday for value: Thursday
            /// </summary>
            [EnumMember(Value = "Thursday")]
            Thursday = 5,

            /// <summary>
            /// Enum Friday for value: Friday
            /// </summary>
            [EnumMember(Value = "Friday")]
            Friday = 6,

            /// <summary>
            /// Enum Saturday for value: Saturday
            /// </summary>
            [EnumMember(Value = "Saturday")]
            Saturday = 7

        }

        /// <summary>
        /// Text for the day of the week on which the simulation starts.
        /// </summary>
        /// <value>Text for the day of the week on which the simulation starts.</value>
        [DataMember(Name="start_day_of_week", EmitDefaultValue=false)]
        public StartDayOfWeekEnum? StartDayOfWeek { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RunPeriod" /> class.
        /// </summary>
        /// <param name="type">type (default to &quot;RunPeriod&quot;).</param>
        /// <param name="startDate">A list of two integers for [month, day], representing the date for the start of the run period. Must be before the end date..</param>
        /// <param name="endDate">A list of two integers for [month, day], representing the date for the end of the run period. Must be after the start date..</param>
        /// <param name="startDayOfWeek">Text for the day of the week on which the simulation starts. (default to StartDayOfWeekEnum.Sunday).</param>
        /// <param name="holidays">A list of lists where each sub-list consists of two integers for [month, day], representing a date which is a holiday within the simulation. If None, no holidays are applied..</param>
        /// <param name="daylightSavingTime">A DaylightSavingTime to dictate the start and end dates of daylight saving time. If None, no daylight saving time is applied to the simulation..</param>
        /// <param name="leapYear">Boolean noting whether the simulation will be run for a leap year. (default to false).</param>
        public RunPeriod(string type = "RunPeriod", List<int> startDate = default, List<int> endDate = default, StartDayOfWeekEnum? startDayOfWeek = StartDayOfWeekEnum.Sunday, List<List<int>> holidays = default, DaylightSavingTime daylightSavingTime = default, bool leapYear = false)
        {
            // use default value if no "type" provided
            if (type == null)
            {
                this.Type = "RunPeriod";
            }
            else
            {
                this.Type = type;
            }
            this.StartDate = startDate;
            this.EndDate = endDate;
            // use default value if no "startDayOfWeek" provided
            if (startDayOfWeek == null)
            {
                this.StartDayOfWeek = StartDayOfWeekEnum.Sunday;
            }
            else
            {
                this.StartDayOfWeek = startDayOfWeek;
            }
            this.Holidays = holidays;
            this.DaylightSavingTime = daylightSavingTime;
            // use default value if no "leapYear" provided
            if (leapYear == null)
            {
                this.LeapYear = false;
            }
            else
            {
                this.LeapYear = leapYear;
            }
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// A list of two integers for [month, day], representing the date for the start of the run period. Must be before the end date.
        /// </summary>
        /// <value>A list of two integers for [month, day], representing the date for the start of the run period. Must be before the end date.</value>
        [DataMember(Name="start_date", EmitDefaultValue=false)]
        [JsonProperty("start_date")]
        public List<int> StartDate { get; set; }

        /// <summary>
        /// A list of two integers for [month, day], representing the date for the end of the run period. Must be after the start date.
        /// </summary>
        /// <value>A list of two integers for [month, day], representing the date for the end of the run period. Must be after the start date.</value>
        [DataMember(Name="end_date", EmitDefaultValue=false)]
        [JsonProperty("end_date")]
        public List<int> EndDate { get; set; }


        /// <summary>
        /// A list of lists where each sub-list consists of two integers for [month, day], representing a date which is a holiday within the simulation. If None, no holidays are applied.
        /// </summary>
        /// <value>A list of lists where each sub-list consists of two integers for [month, day], representing a date which is a holiday within the simulation. If None, no holidays are applied.</value>
        [DataMember(Name="holidays", EmitDefaultValue=false)]
        [JsonProperty("holidays")]
        public List<List<int>> Holidays { get; set; }

        /// <summary>
        /// A DaylightSavingTime to dictate the start and end dates of daylight saving time. If None, no daylight saving time is applied to the simulation.
        /// </summary>
        /// <value>A DaylightSavingTime to dictate the start and end dates of daylight saving time. If None, no daylight saving time is applied to the simulation.</value>
        [DataMember(Name="daylight_saving_time", EmitDefaultValue=false)]
        [JsonProperty("daylight_saving_time")]
        public DaylightSavingTime DaylightSavingTime { get; set; }

        /// <summary>
        /// Boolean noting whether the simulation will be run for a leap year.
        /// </summary>
        /// <value>Boolean noting whether the simulation will be run for a leap year.</value>
        [DataMember(Name="leap_year", EmitDefaultValue=false)]
        [JsonProperty("leap_year")]
        public bool LeapYear { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RunPeriod {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  StartDayOfWeek: ").Append(StartDayOfWeek).Append("\n");
            sb.Append("  Holidays: ").Append(Holidays).Append("\n");
            sb.Append("  DaylightSavingTime: ").Append(DaylightSavingTime).Append("\n");
            sb.Append("  LeapYear: ").Append(LeapYear).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented, new AnyOfJsonConverter());
        }

        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>RunPeriod object</returns>
        public static RunPeriod FromJson(string json)
        {
            return JsonConvert.DeserializeObject<RunPeriod>(json, new AnyOfJsonConverter());
        }


        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as RunPeriod);
        }

        /// <summary>
        /// Returns true if RunPeriod instances are equal
        /// </summary>
        /// <param name="input">Instance of RunPeriod to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RunPeriod input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    this.StartDate != null &&
                    input.StartDate != null &&
                    this.StartDate.SequenceEqual(input.StartDate)
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    this.EndDate != null &&
                    input.EndDate != null &&
                    this.EndDate.SequenceEqual(input.EndDate)
                ) && 
                (
                    this.StartDayOfWeek == input.StartDayOfWeek ||
                    (this.StartDayOfWeek != null &&
                    this.StartDayOfWeek.Equals(input.StartDayOfWeek))
                ) && 
                (
                    this.Holidays == input.Holidays ||
                    this.Holidays != null &&
                    input.Holidays != null &&
                    this.Holidays.SequenceEqual(input.Holidays)
                ) && 
                (
                    this.DaylightSavingTime == input.DaylightSavingTime ||
                    (this.DaylightSavingTime != null &&
                    this.DaylightSavingTime.Equals(input.DaylightSavingTime))
                ) && 
                (
                    this.LeapYear == input.LeapYear ||
                    (this.LeapYear != null &&
                    this.LeapYear.Equals(input.LeapYear))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.StartDayOfWeek != null)
                    hashCode = hashCode * 59 + this.StartDayOfWeek.GetHashCode();
                if (this.Holidays != null)
                    hashCode = hashCode * 59 + this.Holidays.GetHashCode();
                if (this.DaylightSavingTime != null)
                    hashCode = hashCode * 59 + this.DaylightSavingTime.GetHashCode();
                if (this.LeapYear != null)
                    hashCode = hashCode * 59 + this.LeapYear.GetHashCode();
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
            // Type (string) pattern
            Regex regexType = new Regex(@"^RunPeriod$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }

}
