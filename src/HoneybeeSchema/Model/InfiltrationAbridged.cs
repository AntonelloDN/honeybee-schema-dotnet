/* 
 * Honeybee Model Schema
 *
 * This is the documentation for Honeybee model schema.
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
    /// Base class for all objects requiring a valid EnergyPlus identifier.
    /// </summary>
    [DataContract]
    public partial class InfiltrationAbridged : IDdEnergyBaseModel, IEquatable<InfiltrationAbridged>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="InfiltrationAbridged" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InfiltrationAbridged() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InfiltrationAbridged" /> class.
        /// </summary>
        /// <param name="flowPerExteriorArea">Number for the infiltration per exterior surface area in m3/s-m2..</param>
        /// <param name="schedule">Identifier of the schedule for the infiltration over the course of the year. The type of this schedule should be Fractional and the fractional values will get multiplied by the flow_per_exterior_area to yield a complete infiltration profile..</param>
        /// <param name="constantCoefficient">constantCoefficient (default to 1D).</param>
        /// <param name="temperatureCoefficient">temperatureCoefficient (default to 0D).</param>
        /// <param name="velocityCoefficient">velocityCoefficient (default to 0D).</param>
        /// <param name="identifier">Text string for a unique object ID. This identifier remains constant as the object is mutated, copied, and serialized to different formats (eg. dict, idf, osm). This identifier is also used to reference the object across a Model. It must be &lt; 100 characters, use only ASCII characters and exclude (, ; ! \\n \\t). (required).</param>
        /// <param name="displayName">Display name of the object with no character restrictions..</param>
        public InfiltrationAbridged
        (
            string identifier, // Required parameters
            double flowPerExteriorArea= default, string schedule= default, double constantCoefficient = 1D, double temperatureCoefficient = 0D, double velocityCoefficient = 0D, string displayName= default// Optional parameters
        ) : base(identifier: identifier, displayName: displayName )// BaseClass
        {
            this.FlowPerExteriorArea = flowPerExteriorArea;
            this.Schedule = schedule;
            // use default value if no "constantCoefficient" provided
            if (constantCoefficient == null)
            {
                this.ConstantCoefficient = 1D;
            }
            else
            {
                this.ConstantCoefficient = constantCoefficient;
            }
            // use default value if no "temperatureCoefficient" provided
            if (temperatureCoefficient == null)
            {
                this.TemperatureCoefficient = 0D;
            }
            else
            {
                this.TemperatureCoefficient = temperatureCoefficient;
            }
            // use default value if no "velocityCoefficient" provided
            if (velocityCoefficient == null)
            {
                this.VelocityCoefficient = 0D;
            }
            else
            {
                this.VelocityCoefficient = velocityCoefficient;
            }

            // Set non-required readonly properties with defaultValue
            this.Type = "InfiltrationAbridged";
        }
        
        /// <summary>
        /// Number for the infiltration per exterior surface area in m3/s-m2.
        /// </summary>
        /// <value>Number for the infiltration per exterior surface area in m3/s-m2.</value>
        [DataMember(Name="flow_per_exterior_area", EmitDefaultValue=false)]
        [JsonProperty("flow_per_exterior_area")]
        public double FlowPerExteriorArea { get; set; }
        /// <summary>
        /// Identifier of the schedule for the infiltration over the course of the year. The type of this schedule should be Fractional and the fractional values will get multiplied by the flow_per_exterior_area to yield a complete infiltration profile.
        /// </summary>
        /// <value>Identifier of the schedule for the infiltration over the course of the year. The type of this schedule should be Fractional and the fractional values will get multiplied by the flow_per_exterior_area to yield a complete infiltration profile.</value>
        [DataMember(Name="schedule", EmitDefaultValue=false)]
        [JsonProperty("schedule")]
        public string Schedule { get; set; }
        /// <summary>
        /// Gets or Sets ConstantCoefficient
        /// </summary>
        [DataMember(Name="constant_coefficient", EmitDefaultValue=false)]
        [JsonProperty("constant_coefficient")]
        public double ConstantCoefficient { get; set; }
        /// <summary>
        /// Gets or Sets TemperatureCoefficient
        /// </summary>
        [DataMember(Name="temperature_coefficient", EmitDefaultValue=false)]
        [JsonProperty("temperature_coefficient")]
        public double TemperatureCoefficient { get; set; }
        /// <summary>
        /// Gets or Sets VelocityCoefficient
        /// </summary>
        [DataMember(Name="velocity_coefficient", EmitDefaultValue=false)]
        [JsonProperty("velocity_coefficient")]
        public double VelocityCoefficient { get; set; }
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            if (this is IIDdBase iDd)
                return $"InfiltrationAbridged {iDd.Identifier}";
       
            return "InfiltrationAbridged";
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
            sb.Append("InfiltrationAbridged:\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  FlowPerExteriorArea: ").Append(FlowPerExteriorArea).Append("\n");
            sb.Append("  Schedule: ").Append(Schedule).Append("\n");
            sb.Append("  ConstantCoefficient: ").Append(ConstantCoefficient).Append("\n");
            sb.Append("  TemperatureCoefficient: ").Append(TemperatureCoefficient).Append("\n");
            sb.Append("  VelocityCoefficient: ").Append(VelocityCoefficient).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented, new AnyOfJsonConverter());
        }

        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>InfiltrationAbridged object</returns>
        public static InfiltrationAbridged FromJson(string json)
        {
            return JsonConvert.DeserializeObject<InfiltrationAbridged>(json, new AnyOfJsonConverter());
        }
     

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as InfiltrationAbridged);
        }

        /// <summary>
        /// Returns true if InfiltrationAbridged instances are equal
        /// </summary>
        /// <param name="input">Instance of InfiltrationAbridged to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InfiltrationAbridged input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.FlowPerExteriorArea == input.FlowPerExteriorArea ||
                    (this.FlowPerExteriorArea != null &&
                    this.FlowPerExteriorArea.Equals(input.FlowPerExteriorArea))
                ) && base.Equals(input) && 
                (
                    this.Schedule == input.Schedule ||
                    (this.Schedule != null &&
                    this.Schedule.Equals(input.Schedule))
                ) && base.Equals(input) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && base.Equals(input) && 
                (
                    this.ConstantCoefficient == input.ConstantCoefficient ||
                    (this.ConstantCoefficient != null &&
                    this.ConstantCoefficient.Equals(input.ConstantCoefficient))
                ) && base.Equals(input) && 
                (
                    this.TemperatureCoefficient == input.TemperatureCoefficient ||
                    (this.TemperatureCoefficient != null &&
                    this.TemperatureCoefficient.Equals(input.TemperatureCoefficient))
                ) && base.Equals(input) && 
                (
                    this.VelocityCoefficient == input.VelocityCoefficient ||
                    (this.VelocityCoefficient != null &&
                    this.VelocityCoefficient.Equals(input.VelocityCoefficient))
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
                int hashCode = base.GetHashCode();
                if (this.FlowPerExteriorArea != null)
                    hashCode = hashCode * 59 + this.FlowPerExteriorArea.GetHashCode();
                if (this.Schedule != null)
                    hashCode = hashCode * 59 + this.Schedule.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.ConstantCoefficient != null)
                    hashCode = hashCode * 59 + this.ConstantCoefficient.GetHashCode();
                if (this.TemperatureCoefficient != null)
                    hashCode = hashCode * 59 + this.TemperatureCoefficient.GetHashCode();
                if (this.VelocityCoefficient != null)
                    hashCode = hashCode * 59 + this.VelocityCoefficient.GetHashCode();
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
            foreach(var x in base.BaseValidate(validationContext)) yield return x;
            // FlowPerExteriorArea (double) minimum
            if(this.FlowPerExteriorArea < (double)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FlowPerExteriorArea, must be a value greater than or equal to 0.", new [] { "FlowPerExteriorArea" });
            }

            // Schedule (string) maxLength
            if(this.Schedule != null && this.Schedule.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Schedule, length must be less than 100.", new [] { "Schedule" });
            }

            // Schedule (string) minLength
            if(this.Schedule != null && this.Schedule.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Schedule, length must be greater than 1.", new [] { "Schedule" });
            }

            // Type (string) pattern
            Regex regexType = new Regex(@"^InfiltrationAbridged$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            // ConstantCoefficient (double) minimum
            if(this.ConstantCoefficient < (double)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ConstantCoefficient, must be a value greater than or equal to 0.", new [] { "ConstantCoefficient" });
            }

            // TemperatureCoefficient (double) minimum
            if(this.TemperatureCoefficient < (double)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TemperatureCoefficient, must be a value greater than or equal to 0.", new [] { "TemperatureCoefficient" });
            }

            // VelocityCoefficient (double) minimum
            if(this.VelocityCoefficient < (double)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for VelocityCoefficient, must be a value greater than or equal to 0.", new [] { "VelocityCoefficient" });
            }

            yield break;
        }
    }

}
