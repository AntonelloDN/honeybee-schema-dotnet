/* 
 * Honeybee Model Schema
 *
 * This is the documentation for Honeybee model schema.
 *
 * The version of the OpenAPI document: 1.36.1
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
    /// Base class for all objects that are not extensible with additional keys.  This effectively includes all objects except for the Properties classes that are assigned to geometry objects.
    /// </summary>
    [DataContract]
    public partial class DoorEnergyPropertiesAbridged : HoneybeeObject, IEquatable<DoorEnergyPropertiesAbridged>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="DoorEnergyPropertiesAbridged" /> class.
        /// </summary>
        /// <param name="construction">Identifier of an OpaqueConstruction or WindowConstruction for the door. Note that the host door must have the is_glass property set to True to assign a WindowConstruction. If None, the construction is set by the parent Room construction_set or the Model global_construction_set..</param>
        /// <param name="ventOpening">An optional VentilationOpening to specify the operable portion of the Door..</param>
        public DoorEnergyPropertiesAbridged
        (
             // Required parameters
            string construction= default, VentilationOpening ventOpening= default// Optional parameters
        )// BaseClass
        {
            this.Construction = construction;
            this.VentOpening = ventOpening;

            // Set non-required readonly properties with defaultValue
            this.Type = "DoorEnergyPropertiesAbridged";
        }
        
        /// <summary>
        /// Identifier of an OpaqueConstruction or WindowConstruction for the door. Note that the host door must have the is_glass property set to True to assign a WindowConstruction. If None, the construction is set by the parent Room construction_set or the Model global_construction_set.
        /// </summary>
        /// <value>Identifier of an OpaqueConstruction or WindowConstruction for the door. Note that the host door must have the is_glass property set to True to assign a WindowConstruction. If None, the construction is set by the parent Room construction_set or the Model global_construction_set.</value>
        [DataMember(Name="construction", EmitDefaultValue=false)]
        [JsonProperty("construction")]
        public string Construction { get; set; } 
        /// <summary>
        /// An optional VentilationOpening to specify the operable portion of the Door.
        /// </summary>
        /// <value>An optional VentilationOpening to specify the operable portion of the Door.</value>
        [DataMember(Name="vent_opening", EmitDefaultValue=false)]
        [JsonProperty("vent_opening")]
        public VentilationOpening VentOpening { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            if (this is IIDdBase iDd)
                return $"DoorEnergyPropertiesAbridged {iDd.Identifier}";
       
            return "DoorEnergyPropertiesAbridged";
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
            sb.Append("DoorEnergyPropertiesAbridged:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Construction: ").Append(Construction).Append("\n");
            sb.Append("  VentOpening: ").Append(VentOpening).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>DoorEnergyPropertiesAbridged object</returns>
        public static DoorEnergyPropertiesAbridged FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<DoorEnergyPropertiesAbridged>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>DoorEnergyPropertiesAbridged object</returns>
        public DoorEnergyPropertiesAbridged DuplicateDoorEnergyPropertiesAbridged()
        {
            return Duplicate() as DoorEnergyPropertiesAbridged;
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
            return this.Equals(input as DoorEnergyPropertiesAbridged);
        }

        /// <summary>
        /// Returns true if DoorEnergyPropertiesAbridged instances are equal
        /// </summary>
        /// <param name="input">Instance of DoorEnergyPropertiesAbridged to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DoorEnergyPropertiesAbridged input)
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
                    this.Construction == input.Construction ||
                    (this.Construction != null &&
                    this.Construction.Equals(input.Construction))
                ) && 
                (
                    this.VentOpening == input.VentOpening ||
                    (this.VentOpening != null &&
                    this.VentOpening.Equals(input.VentOpening))
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
                if (this.Construction != null)
                    hashCode = hashCode * 59 + this.Construction.GetHashCode();
                if (this.VentOpening != null)
                    hashCode = hashCode * 59 + this.VentOpening.GetHashCode();
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
            Regex regexType = new Regex(@"^DoorEnergyPropertiesAbridged$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            // Construction (string) maxLength
            if(this.Construction != null && this.Construction.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Construction, length must be less than 100.", new [] { "Construction" });
            }

            // Construction (string) minLength
            if(this.Construction != null && this.Construction.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Construction, length must be greater than 1.", new [] { "Construction" });
            }

            yield break;
        }
    }

}
