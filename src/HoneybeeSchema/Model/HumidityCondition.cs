/* 
 * Honeybee Energy Simulation Parameter Schema
 *
 * This is the documentation for Honeybee energy simulation parameter schema.
 *
 * The version of the OpenAPI document: 1.25.1
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
    /// Used to specify humidity conditions on a design day.
    /// </summary>
    [DataContract]
    public partial class HumidityCondition : HoneybeeObject, IEquatable<HumidityCondition>, IValidatableObject
    {

        /// <summary>
        /// Defines HumidityType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum HumidityTypeEnum
        {
            /// <summary>
            /// Enum Wetbulb for value: Wetbulb
            /// </summary>
            [EnumMember(Value = "Wetbulb")]
            Wetbulb = 1,

            /// <summary>
            /// Enum Dewpoint for value: Dewpoint
            /// </summary>
            [EnumMember(Value = "Dewpoint")]
            Dewpoint = 2,

            /// <summary>
            /// Enum HumidityRatio for value: HumidityRatio
            /// </summary>
            [EnumMember(Value = "HumidityRatio")]
            HumidityRatio = 3,

            /// <summary>
            /// Enum Enthalpy for value: Enthalpy
            /// </summary>
            [EnumMember(Value = "Enthalpy")]
            Enthalpy = 4

        }

        /// <summary>
        /// Gets or Sets HumidityType
        /// </summary>
        [DataMember(Name="humidity_type", EmitDefaultValue=false)]
        public HumidityTypeEnum HumidityType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="HumidityCondition" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected HumidityCondition() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="HumidityCondition" /> class.
        /// </summary>
        /// <param name="humidityType">humidityType (required).</param>
        /// <param name="humidityValue">The value correcponding to the humidity_type. (required).</param>
        /// <param name="barometricPressure">Barometric air pressure on the design day [Pa]. (default to 101325D).</param>
        /// <param name="rain">Boolean to indicate rain on the design day. (default to false).</param>
        /// <param name="snowOnGround">Boolean to indicate snow on the ground during the design day. (default to false).</param>
        public HumidityCondition
        (
            HumidityTypeEnum humidityType, double humidityValue, // Required parameters
            double barometricPressure = 101325D, bool rain = false, bool snowOnGround = false// Optional parameters
        )// BaseClass
        {
            // to ensure "humidityType" is required (not null)
            if (humidityType == null)
            {
                throw new InvalidDataException("humidityType is a required property for HumidityCondition and cannot be null");
            }
            else
            {
                this.HumidityType = humidityType;
            }
            
            // to ensure "humidityValue" is required (not null)
            if (humidityValue == null)
            {
                throw new InvalidDataException("humidityValue is a required property for HumidityCondition and cannot be null");
            }
            else
            {
                this.HumidityValue = humidityValue;
            }
            
            // use default value if no "barometricPressure" provided
            if (barometricPressure == null)
            {
                this.BarometricPressure = 101325D;
            }
            else
            {
                this.BarometricPressure = barometricPressure;
            }
            // use default value if no "rain" provided
            if (rain == null)
            {
                this.Rain = false;
            }
            else
            {
                this.Rain = rain;
            }
            // use default value if no "snowOnGround" provided
            if (snowOnGround == null)
            {
                this.SnowOnGround = false;
            }
            else
            {
                this.SnowOnGround = snowOnGround;
            }

            // Set non-required readonly properties with defaultValue
            this.Type = "HumidityCondition";
        }
        
        /// <summary>
        /// The value correcponding to the humidity_type.
        /// </summary>
        /// <value>The value correcponding to the humidity_type.</value>
        [DataMember(Name="humidity_value", EmitDefaultValue=false)]
        [JsonProperty("humidity_value")]
        public double HumidityValue { get; set; }
        /// <summary>
        /// Barometric air pressure on the design day [Pa].
        /// </summary>
        /// <value>Barometric air pressure on the design day [Pa].</value>
        [DataMember(Name="barometric_pressure", EmitDefaultValue=false)]
        [JsonProperty("barometric_pressure")]
        public double BarometricPressure { get; set; }
        /// <summary>
        /// Boolean to indicate rain on the design day.
        /// </summary>
        /// <value>Boolean to indicate rain on the design day.</value>
        [DataMember(Name="rain", EmitDefaultValue=false)]
        [JsonProperty("rain")]
        public bool Rain { get; set; }
        /// <summary>
        /// Boolean to indicate snow on the ground during the design day.
        /// </summary>
        /// <value>Boolean to indicate snow on the ground during the design day.</value>
        [DataMember(Name="snow_on_ground", EmitDefaultValue=false)]
        [JsonProperty("snow_on_ground")]
        public bool SnowOnGround { get; set; }
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            if (this is IIDdBase iDd)
                return $"HumidityCondition {iDd.Identifier}";
       
            return "HumidityCondition";
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public string ToString(bool detailed)
        {
            if (detailed)
                return this.ToString();
            
            var sb = new StringBuilder();
            sb.Append("HumidityCondition:\n");
            sb.Append("  HumidityType: ").Append(HumidityType).Append("\n");
            sb.Append("  HumidityValue: ").Append(HumidityValue).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  BarometricPressure: ").Append(BarometricPressure).Append("\n");
            sb.Append("  Rain: ").Append(Rain).Append("\n");
            sb.Append("  SnowOnGround: ").Append(SnowOnGround).Append("\n");
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
        /// <returns>HumidityCondition object</returns>
        public static HumidityCondition FromJson(string json)
        {
            return JsonConvert.DeserializeObject<HumidityCondition>(json, new AnyOfJsonConverter());
        }
     

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as HumidityCondition);
        }

        /// <summary>
        /// Returns true if HumidityCondition instances are equal
        /// </summary>
        /// <param name="input">Instance of HumidityCondition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HumidityCondition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.HumidityType == input.HumidityType ||
                    (this.HumidityType != null &&
                    this.HumidityType.Equals(input.HumidityType))
                ) && 
                (
                    this.HumidityValue == input.HumidityValue ||
                    (this.HumidityValue != null &&
                    this.HumidityValue.Equals(input.HumidityValue))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.BarometricPressure == input.BarometricPressure ||
                    (this.BarometricPressure != null &&
                    this.BarometricPressure.Equals(input.BarometricPressure))
                ) && 
                (
                    this.Rain == input.Rain ||
                    (this.Rain != null &&
                    this.Rain.Equals(input.Rain))
                ) && 
                (
                    this.SnowOnGround == input.SnowOnGround ||
                    (this.SnowOnGround != null &&
                    this.SnowOnGround.Equals(input.SnowOnGround))
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
                if (this.HumidityType != null)
                    hashCode = hashCode * 59 + this.HumidityType.GetHashCode();
                if (this.HumidityValue != null)
                    hashCode = hashCode * 59 + this.HumidityValue.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.BarometricPressure != null)
                    hashCode = hashCode * 59 + this.BarometricPressure.GetHashCode();
                if (this.Rain != null)
                    hashCode = hashCode * 59 + this.Rain.GetHashCode();
                if (this.SnowOnGround != null)
                    hashCode = hashCode * 59 + this.SnowOnGround.GetHashCode();
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
            Regex regexType = new Regex(@"^HumidityCondition$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            // BarometricPressure (double) maximum
            if(this.BarometricPressure > (double)120000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BarometricPressure, must be a value less than or equal to 120000.", new [] { "BarometricPressure" });
            }

            // BarometricPressure (double) minimum
            if(this.BarometricPressure < (double)31000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BarometricPressure, must be a value greater than or equal to 31000.", new [] { "BarometricPressure" });
            }

            yield break;
        }
    }

}
