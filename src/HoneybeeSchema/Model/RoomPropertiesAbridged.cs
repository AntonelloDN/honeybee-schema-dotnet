/* 
 * Honeybee Model Schema
 *
 * This is the documentation for Honeybee model schema.
 *
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
    /// RoomPropertiesAbridged
    /// </summary>
    [DataContract]
    public partial class RoomPropertiesAbridged : HoneybeeObject, IEquatable<RoomPropertiesAbridged>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="RoomPropertiesAbridged" /> class.
        /// </summary>
        /// <param name="energy">energy.</param>
        /// <param name="radiance">radiance.</param>
        public RoomPropertiesAbridged
        (
             // Required parameters
            RoomEnergyPropertiesAbridged energy= default, RoomRadiancePropertiesAbridged radiance= default// Optional parameters
        )// BaseClass
        {
            this.Energy = energy;
            this.Radiance = radiance;

            // Set non-required readonly properties with defaultValue
            this.Type = "RoomPropertiesAbridged";
        }
        
        /// <summary>
        /// Gets or Sets Energy
        /// </summary>
        [DataMember(Name="energy", EmitDefaultValue=false)]
        [JsonProperty("energy")]
        public RoomEnergyPropertiesAbridged Energy { get; set; } 
        /// <summary>
        /// Gets or Sets Radiance
        /// </summary>
        [DataMember(Name="radiance", EmitDefaultValue=false)]
        [JsonProperty("radiance")]
        public RoomRadiancePropertiesAbridged Radiance { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            if (this is IIDdBase iDd)
                return $"RoomPropertiesAbridged {iDd.Identifier}";
       
            return "RoomPropertiesAbridged";
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString(bool detailed)
        {
            if (!detailed)
                return this.ToString();
            
            var sb = new StringBuilder();
            sb.Append("RoomPropertiesAbridged:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Energy: ").Append(Energy).Append("\n");
            sb.Append("  Radiance: ").Append(Radiance).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>RoomPropertiesAbridged object</returns>
        public static RoomPropertiesAbridged FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<RoomPropertiesAbridged>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>RoomPropertiesAbridged object</returns>
        public RoomPropertiesAbridged DuplicateRoomPropertiesAbridged()
        {
            return Duplicate() as RoomPropertiesAbridged;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>HoneybeeObject</returns>
        public override HoneybeeObject Duplicate()
        {
            return FromJson(this.ToJson());
        }
     

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as RoomPropertiesAbridged);
        }

        /// <summary>
        /// Returns true if RoomPropertiesAbridged instances are equal
        /// </summary>
        /// <param name="input">Instance of RoomPropertiesAbridged to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RoomPropertiesAbridged input)
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
                    this.Energy == input.Energy ||
                    (this.Energy != null &&
                    this.Energy.Equals(input.Energy))
                ) && 
                (
                    this.Radiance == input.Radiance ||
                    (this.Radiance != null &&
                    this.Radiance.Equals(input.Radiance))
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
                if (this.Energy != null)
                    hashCode = hashCode * 59 + this.Energy.GetHashCode();
                if (this.Radiance != null)
                    hashCode = hashCode * 59 + this.Radiance.GetHashCode();
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
            Regex regexType = new Regex(@"^RoomPropertiesAbridged$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }

}
