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
    /// Direct evaporative cooling systems (with optional heating).
    /// </summary>
    [DataContract]
    public partial class EvaporativeCooler : HeatCoolBase, IEquatable<EvaporativeCooler>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets EquipmentType
        /// </summary>
        [DataMember(Name="equipment_type", EmitDefaultValue=false)]
        public EvaporativeCoolerEquipmentType? EquipmentType { get; set; }   
        /// <summary>
        /// Initializes a new instance of the <see cref="EvaporativeCooler" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EvaporativeCooler() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EvaporativeCooler" /> class.
        /// </summary>
        /// <param name="equipmentType">equipmentType.</param>
        /// <param name="identifier">Text string for a unique object ID. This identifier remains constant as the object is mutated, copied, and serialized to different formats (eg. dict, idf, osm). This identifier is also used to reference the object across a Model. It must be &lt; 100 characters, use only ASCII characters and exclude (, ; ! \\n \\t). (required).</param>
        /// <param name="displayName">Display name of the object with no character restrictions..</param>
        /// <param name="vintage">vintage.</param>
        public EvaporativeCooler
        (
            string identifier, // Required parameters
            string displayName= default, Vintages? vintage= default, EvaporativeCoolerEquipmentType? equipmentType= default// Optional parameters
        ) : base(identifier: identifier, displayName: displayName, vintage: vintage)// BaseClass
        {
            this.EquipmentType = equipmentType;

            // Set non-required readonly properties with defaultValue
            this.Type = "EvaporativeCooler";
        }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            if (this is IIDdBase iDd)
                return $"EvaporativeCooler {iDd.Identifier}";
       
            return "EvaporativeCooler";
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
            sb.Append("EvaporativeCooler:\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Vintage: ").Append(Vintage).Append("\n");
            sb.Append("  EquipmentType: ").Append(EquipmentType).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>EvaporativeCooler object</returns>
        public static EvaporativeCooler FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<EvaporativeCooler>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>EvaporativeCooler object</returns>
        public EvaporativeCooler DuplicateEvaporativeCooler()
        {
            return Duplicate() as EvaporativeCooler;
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
            return this.Equals(input as EvaporativeCooler);
        }

        /// <summary>
        /// Returns true if EvaporativeCooler instances are equal
        /// </summary>
        /// <param name="input">Instance of EvaporativeCooler to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EvaporativeCooler input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && base.Equals(input) && 
                (
                    this.EquipmentType == input.EquipmentType ||
                    (this.EquipmentType != null &&
                    this.EquipmentType.Equals(input.EquipmentType))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.EquipmentType != null)
                    hashCode = hashCode * 59 + this.EquipmentType.GetHashCode();
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
            // Type (string) pattern
            Regex regexType = new Regex(@"^EvaporativeCooler$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }

}
