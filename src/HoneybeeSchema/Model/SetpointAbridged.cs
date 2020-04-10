/* 
 * Honeybee Model Schema
 *
 * This is the documentation for Honeybee model schema.
 *
 * The version of the OpenAPI document: 1.21.4
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
    /// Used to specify information about the setpoint schedule.
    /// </summary>
    [DataContract]
    public partial class SetpointAbridged :  IEquatable<SetpointAbridged>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SetpointAbridged" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SetpointAbridged() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SetpointAbridged" /> class.
        /// </summary>
        /// <param name="identifier">Text string for a unique object ID. This identifier remains constant as the object is mutated, copied, and serialized to different formats (eg. dict, idf, osm). This identifier is also used to reference the object across a Model. It must be &lt; 100 characters, use only ASCII characters and exclude (, ; ! \\n \\t). (required).</param>
        /// <param name="coolingSchedule">Identifier of the schedule for the cooling setpoint. The values in this schedule should be temperature in [C]. (required).</param>
        /// <param name="heatingSchedule">Identifier of the schedule for the heating setpoint. The values in this schedule should be temperature in [C]. (required).</param>
        /// <param name="displayName">Display name of the object with no character restrictions..</param>
        /// <param name="type">type (default to &quot;SetpointAbridged&quot;).</param>
        /// <param name="humidifyingSchedule">Identifier of the schedule for the humidification setpoint. The values in this schedule should be in [%]..</param>
        /// <param name="dehumidifyingSchedule">Identifier of the schedule for the dehumidification setpoint. The values in this schedule should be in [%]..</param>
        public SetpointAbridged(string identifier, string coolingSchedule, string heatingSchedule, string displayName = default, string type = "SetpointAbridged", string humidifyingSchedule = default, string dehumidifyingSchedule = default)
        {
            // to ensure "identifier" is required (not null)
            if (identifier == null)
            {
                throw new InvalidDataException("identifier is a required property for SetpointAbridged and cannot be null");
            }
            else
            {
                this.Identifier = identifier;
            }
            
            // to ensure "coolingSchedule" is required (not null)
            if (coolingSchedule == null)
            {
                throw new InvalidDataException("coolingSchedule is a required property for SetpointAbridged and cannot be null");
            }
            else
            {
                this.CoolingSchedule = coolingSchedule;
            }
            
            // to ensure "heatingSchedule" is required (not null)
            if (heatingSchedule == null)
            {
                throw new InvalidDataException("heatingSchedule is a required property for SetpointAbridged and cannot be null");
            }
            else
            {
                this.HeatingSchedule = heatingSchedule;
            }
            
            this.DisplayName = displayName;
            // use default value if no "type" provided
            if (type == null)
            {
                this.Type = "SetpointAbridged";
            }
            else
            {
                this.Type = type;
            }
            this.HumidifyingSchedule = humidifyingSchedule;
            this.DehumidifyingSchedule = dehumidifyingSchedule;
        }
        
        /// <summary>
        /// Text string for a unique object ID. This identifier remains constant as the object is mutated, copied, and serialized to different formats (eg. dict, idf, osm). This identifier is also used to reference the object across a Model. It must be &lt; 100 characters, use only ASCII characters and exclude (, ; ! \\n \\t).
        /// </summary>
        /// <value>Text string for a unique object ID. This identifier remains constant as the object is mutated, copied, and serialized to different formats (eg. dict, idf, osm). This identifier is also used to reference the object across a Model. It must be &lt; 100 characters, use only ASCII characters and exclude (, ; ! \\n \\t).</value>
        [DataMember(Name="identifier", EmitDefaultValue=false)]
        [JsonProperty("identifier")]
        public string Identifier { get; set; }

        /// <summary>
        /// Identifier of the schedule for the cooling setpoint. The values in this schedule should be temperature in [C].
        /// </summary>
        /// <value>Identifier of the schedule for the cooling setpoint. The values in this schedule should be temperature in [C].</value>
        [DataMember(Name="cooling_schedule", EmitDefaultValue=false)]
        [JsonProperty("cooling_schedule")]
        public string CoolingSchedule { get; set; }

        /// <summary>
        /// Identifier of the schedule for the heating setpoint. The values in this schedule should be temperature in [C].
        /// </summary>
        /// <value>Identifier of the schedule for the heating setpoint. The values in this schedule should be temperature in [C].</value>
        [DataMember(Name="heating_schedule", EmitDefaultValue=false)]
        [JsonProperty("heating_schedule")]
        public string HeatingSchedule { get; set; }

        /// <summary>
        /// Display name of the object with no character restrictions.
        /// </summary>
        /// <value>Display name of the object with no character restrictions.</value>
        [DataMember(Name="display_name", EmitDefaultValue=false)]
        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Identifier of the schedule for the humidification setpoint. The values in this schedule should be in [%].
        /// </summary>
        /// <value>Identifier of the schedule for the humidification setpoint. The values in this schedule should be in [%].</value>
        [DataMember(Name="humidifying_schedule", EmitDefaultValue=false)]
        [JsonProperty("humidifying_schedule")]
        public string HumidifyingSchedule { get; set; }

        /// <summary>
        /// Identifier of the schedule for the dehumidification setpoint. The values in this schedule should be in [%].
        /// </summary>
        /// <value>Identifier of the schedule for the dehumidification setpoint. The values in this schedule should be in [%].</value>
        [DataMember(Name="dehumidifying_schedule", EmitDefaultValue=false)]
        [JsonProperty("dehumidifying_schedule")]
        public string DehumidifyingSchedule { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SetpointAbridged {\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  CoolingSchedule: ").Append(CoolingSchedule).Append("\n");
            sb.Append("  HeatingSchedule: ").Append(HeatingSchedule).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  HumidifyingSchedule: ").Append(HumidifyingSchedule).Append("\n");
            sb.Append("  DehumidifyingSchedule: ").Append(DehumidifyingSchedule).Append("\n");
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
        /// <returns>SetpointAbridged object</returns>
        public static SetpointAbridged FromJson(string json)
        {
            return JsonConvert.DeserializeObject<SetpointAbridged>(json, new AnyOfJsonConverter());
        }


        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as SetpointAbridged);
        }

        /// <summary>
        /// Returns true if SetpointAbridged instances are equal
        /// </summary>
        /// <param name="input">Instance of SetpointAbridged to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SetpointAbridged input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Identifier == input.Identifier ||
                    (this.Identifier != null &&
                    this.Identifier.Equals(input.Identifier))
                ) && 
                (
                    this.CoolingSchedule == input.CoolingSchedule ||
                    (this.CoolingSchedule != null &&
                    this.CoolingSchedule.Equals(input.CoolingSchedule))
                ) && 
                (
                    this.HeatingSchedule == input.HeatingSchedule ||
                    (this.HeatingSchedule != null &&
                    this.HeatingSchedule.Equals(input.HeatingSchedule))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.HumidifyingSchedule == input.HumidifyingSchedule ||
                    (this.HumidifyingSchedule != null &&
                    this.HumidifyingSchedule.Equals(input.HumidifyingSchedule))
                ) && 
                (
                    this.DehumidifyingSchedule == input.DehumidifyingSchedule ||
                    (this.DehumidifyingSchedule != null &&
                    this.DehumidifyingSchedule.Equals(input.DehumidifyingSchedule))
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
                if (this.Identifier != null)
                    hashCode = hashCode * 59 + this.Identifier.GetHashCode();
                if (this.CoolingSchedule != null)
                    hashCode = hashCode * 59 + this.CoolingSchedule.GetHashCode();
                if (this.HeatingSchedule != null)
                    hashCode = hashCode * 59 + this.HeatingSchedule.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.HumidifyingSchedule != null)
                    hashCode = hashCode * 59 + this.HumidifyingSchedule.GetHashCode();
                if (this.DehumidifyingSchedule != null)
                    hashCode = hashCode * 59 + this.DehumidifyingSchedule.GetHashCode();
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
            // Identifier (string) maxLength
            if(this.Identifier != null && this.Identifier.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Identifier, length must be less than 100.", new [] { "Identifier" });
            }

            // Identifier (string) minLength
            if(this.Identifier != null && this.Identifier.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Identifier, length must be greater than 1.", new [] { "Identifier" });
            }

            // CoolingSchedule (string) maxLength
            if(this.CoolingSchedule != null && this.CoolingSchedule.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CoolingSchedule, length must be less than 100.", new [] { "CoolingSchedule" });
            }

            // CoolingSchedule (string) minLength
            if(this.CoolingSchedule != null && this.CoolingSchedule.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CoolingSchedule, length must be greater than 1.", new [] { "CoolingSchedule" });
            }

            // HeatingSchedule (string) maxLength
            if(this.HeatingSchedule != null && this.HeatingSchedule.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for HeatingSchedule, length must be less than 100.", new [] { "HeatingSchedule" });
            }

            // HeatingSchedule (string) minLength
            if(this.HeatingSchedule != null && this.HeatingSchedule.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for HeatingSchedule, length must be greater than 1.", new [] { "HeatingSchedule" });
            }

            // Type (string) pattern
            Regex regexType = new Regex(@"^SetpointAbridged$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            // HumidifyingSchedule (string) maxLength
            if(this.HumidifyingSchedule != null && this.HumidifyingSchedule.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for HumidifyingSchedule, length must be less than 100.", new [] { "HumidifyingSchedule" });
            }

            // HumidifyingSchedule (string) minLength
            if(this.HumidifyingSchedule != null && this.HumidifyingSchedule.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for HumidifyingSchedule, length must be greater than 1.", new [] { "HumidifyingSchedule" });
            }

            // DehumidifyingSchedule (string) maxLength
            if(this.DehumidifyingSchedule != null && this.DehumidifyingSchedule.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DehumidifyingSchedule, length must be less than 100.", new [] { "DehumidifyingSchedule" });
            }

            // DehumidifyingSchedule (string) minLength
            if(this.DehumidifyingSchedule != null && this.DehumidifyingSchedule.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DehumidifyingSchedule, length must be greater than 1.", new [] { "DehumidifyingSchedule" });
            }

            yield break;
        }
    }

}
