/* 
 * Honeybee Model Schema
 *
 * Documentation for Honeybee model schema
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
    /// Abridged set containing radiance modifiers needed for a model&#39;s Apertures.
    /// </summary>
    [DataContract(Name = "ApertureModifierSetAbridged")]
    public partial class ApertureModifierSetAbridged : OpenAPIGenBaseModel, IEquatable<ApertureModifierSetAbridged>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApertureModifierSetAbridged" /> class.
        /// </summary>
        /// <param name="windowModifier">Identifier of modifier object for apertures with an Outdoors boundary condition, False is_operable property, and Wall parent Face..</param>
        /// <param name="interiorModifier">Identifier of modifier object for apertures with a Surface boundary condition..</param>
        /// <param name="skylightModifier">Identifier of modifier object for apertures with an Outdoors boundary condition, False is_operable property, and a RoofCeiling or Floor face type for their parent face..</param>
        /// <param name="operableModifier">Identifier of modifier object for apertures with an Outdoors boundary condition and a True is_operable property..</param>
        public ApertureModifierSetAbridged
        (
           // Required parameters
           string windowModifier= default, string interiorModifier= default, string skylightModifier= default, string operableModifier= default// Optional parameters
        ) : base()// BaseClass
        {
            this.WindowModifier = windowModifier;
            this.InteriorModifier = interiorModifier;
            this.SkylightModifier = skylightModifier;
            this.OperableModifier = operableModifier;

            // Set non-required readonly properties with defaultValue
            this.Type = "ApertureModifierSetAbridged";
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type")]
        public override string Type { get; protected set; }  = "ApertureModifierSetAbridged";

        /// <summary>
        /// Identifier of modifier object for apertures with an Outdoors boundary condition, False is_operable property, and Wall parent Face.
        /// </summary>
        /// <value>Identifier of modifier object for apertures with an Outdoors boundary condition, False is_operable property, and Wall parent Face.</value>
        [DataMember(Name = "window_modifier")]
        public string WindowModifier { get; set; } 
        /// <summary>
        /// Identifier of modifier object for apertures with a Surface boundary condition.
        /// </summary>
        /// <value>Identifier of modifier object for apertures with a Surface boundary condition.</value>
        [DataMember(Name = "interior_modifier")]
        public string InteriorModifier { get; set; } 
        /// <summary>
        /// Identifier of modifier object for apertures with an Outdoors boundary condition, False is_operable property, and a RoofCeiling or Floor face type for their parent face.
        /// </summary>
        /// <value>Identifier of modifier object for apertures with an Outdoors boundary condition, False is_operable property, and a RoofCeiling or Floor face type for their parent face.</value>
        [DataMember(Name = "skylight_modifier")]
        public string SkylightModifier { get; set; } 
        /// <summary>
        /// Identifier of modifier object for apertures with an Outdoors boundary condition and a True is_operable property.
        /// </summary>
        /// <value>Identifier of modifier object for apertures with an Outdoors boundary condition and a True is_operable property.</value>
        [DataMember(Name = "operable_modifier")]
        public string OperableModifier { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "ApertureModifierSetAbridged";
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
            sb.Append("ApertureModifierSetAbridged:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  WindowModifier: ").Append(WindowModifier).Append("\n");
            sb.Append("  InteriorModifier: ").Append(InteriorModifier).Append("\n");
            sb.Append("  SkylightModifier: ").Append(SkylightModifier).Append("\n");
            sb.Append("  OperableModifier: ").Append(OperableModifier).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>ApertureModifierSetAbridged object</returns>
        public static ApertureModifierSetAbridged FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<ApertureModifierSetAbridged>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>ApertureModifierSetAbridged object</returns>
        public virtual ApertureModifierSetAbridged DuplicateApertureModifierSetAbridged()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateApertureModifierSetAbridged();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicateApertureModifierSetAbridged();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as ApertureModifierSetAbridged);
        }

        /// <summary>
        /// Returns true if ApertureModifierSetAbridged instances are equal
        /// </summary>
        /// <param name="input">Instance of ApertureModifierSetAbridged to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApertureModifierSetAbridged input)
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
                    this.WindowModifier == input.WindowModifier ||
                    (this.WindowModifier != null &&
                    this.WindowModifier.Equals(input.WindowModifier))
                ) && base.Equals(input) && 
                (
                    this.InteriorModifier == input.InteriorModifier ||
                    (this.InteriorModifier != null &&
                    this.InteriorModifier.Equals(input.InteriorModifier))
                ) && base.Equals(input) && 
                (
                    this.SkylightModifier == input.SkylightModifier ||
                    (this.SkylightModifier != null &&
                    this.SkylightModifier.Equals(input.SkylightModifier))
                ) && base.Equals(input) && 
                (
                    this.OperableModifier == input.OperableModifier ||
                    (this.OperableModifier != null &&
                    this.OperableModifier.Equals(input.OperableModifier))
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
                if (this.WindowModifier != null)
                    hashCode = hashCode * 59 + this.WindowModifier.GetHashCode();
                if (this.InteriorModifier != null)
                    hashCode = hashCode * 59 + this.InteriorModifier.GetHashCode();
                if (this.SkylightModifier != null)
                    hashCode = hashCode * 59 + this.SkylightModifier.GetHashCode();
                if (this.OperableModifier != null)
                    hashCode = hashCode * 59 + this.OperableModifier.GetHashCode();
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
            Regex regexType = new Regex(@"^ApertureModifierSetAbridged$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
