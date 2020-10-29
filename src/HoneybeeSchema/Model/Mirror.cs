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
    /// Radiance mirror material.
    /// </summary>
    [DataContract]
    public partial class Mirror : ModifierBase, IEquatable<Mirror>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="Mirror" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Mirror() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Mirror" /> class.
        /// </summary>
        /// <param name="modifier">Material modifier (default: Void)..</param>
        /// <param name="dependencies">List of modifiers that this modifier depends on. This argument is only useful for defining advanced modifiers where the modifier is defined based on other modifiers (default: None)..</param>
        /// <param name="rReflectance">A value between 0 and 1 for the red channel reflectance (default: 1). (default to 1D).</param>
        /// <param name="gReflectance">A value between 0 and 1 for the green channel reflectance (default: 1). (default to 1D).</param>
        /// <param name="bReflectance">A value between 0 and 1 for the blue channel reflectance (default: 1). (default to 1D).</param>
        /// <param name="alternateMaterial">An optional material that may be used like the illum type to specify a different material to be used for shading non-source rays. If None, this will keep the alternat_material as mirror. If this alternate material is given as Void, then the mirror surface will be invisible. Using Void is only appropriate if the surface hides other (more detailed) geometry with the same overall reflectance (default: None)..</param>
        /// <param name="identifier">Text string for a unique Radiance object. Must not contain spaces or special characters. This will be used to identify the object across a model and in the exported Radiance files. (required).</param>
        /// <param name="displayName">Display name of the object with no character restrictions..</param>
        public Mirror
        (
            string identifier, // Required parameters
            string displayName= default, AnyOf<Plastic,Glass,BSDF,Glow,Light,Trans,Metal,Void,Mirror> modifier= default, List<AnyOf<Plastic,Glass,BSDF,Glow,Light,Trans,Metal,Void,Mirror>> dependencies= default, double rReflectance = 1D, double gReflectance = 1D, double bReflectance = 1D, AnyOf<Plastic,Glass,BSDF,Glow,Light,Trans,Metal,Void,Mirror> alternateMaterial= default // Optional parameters
        ) : base(identifier: identifier, displayName: displayName )// BaseClass
        {
            this.Modifier = modifier;
            this.Dependencies = dependencies;
            // use default value if no "rReflectance" provided
            if (rReflectance == null)
            {
                this.RReflectance = 1D;
            }
            else
            {
                this.RReflectance = rReflectance;
            }
            // use default value if no "gReflectance" provided
            if (gReflectance == null)
            {
                this.GReflectance = 1D;
            }
            else
            {
                this.GReflectance = gReflectance;
            }
            // use default value if no "bReflectance" provided
            if (bReflectance == null)
            {
                this.BReflectance = 1D;
            }
            else
            {
                this.BReflectance = bReflectance;
            }
            this.AlternateMaterial = alternateMaterial;

            // Set non-required readonly properties with defaultValue
            this.Type = "mirror";
        }
        
        /// <summary>
        /// Material modifier (default: Void).
        /// </summary>
        /// <value>Material modifier (default: Void).</value>
        [DataMember(Name="modifier", EmitDefaultValue=false)]
        [JsonProperty("modifier")]
        public AnyOf<Plastic,Glass,BSDF,Glow,Light,Trans,Metal,Void,Mirror> Modifier { get; set; } 
        /// <summary>
        /// List of modifiers that this modifier depends on. This argument is only useful for defining advanced modifiers where the modifier is defined based on other modifiers (default: None).
        /// </summary>
        /// <value>List of modifiers that this modifier depends on. This argument is only useful for defining advanced modifiers where the modifier is defined based on other modifiers (default: None).</value>
        [DataMember(Name="dependencies", EmitDefaultValue=false)]
        [JsonProperty("dependencies")]
        public List<AnyOf<Plastic,Glass,BSDF,Glow,Light,Trans,Metal,Void,Mirror>> Dependencies { get; set; } 
        /// <summary>
        /// A value between 0 and 1 for the red channel reflectance (default: 1).
        /// </summary>
        /// <value>A value between 0 and 1 for the red channel reflectance (default: 1).</value>
        [DataMember(Name="r_reflectance", EmitDefaultValue=false)]
        [JsonProperty("r_reflectance")]
        public double RReflectance { get; set; }  = 1D;
        /// <summary>
        /// A value between 0 and 1 for the green channel reflectance (default: 1).
        /// </summary>
        /// <value>A value between 0 and 1 for the green channel reflectance (default: 1).</value>
        [DataMember(Name="g_reflectance", EmitDefaultValue=false)]
        [JsonProperty("g_reflectance")]
        public double GReflectance { get; set; }  = 1D;
        /// <summary>
        /// A value between 0 and 1 for the blue channel reflectance (default: 1).
        /// </summary>
        /// <value>A value between 0 and 1 for the blue channel reflectance (default: 1).</value>
        [DataMember(Name="b_reflectance", EmitDefaultValue=false)]
        [JsonProperty("b_reflectance")]
        public double BReflectance { get; set; }  = 1D;
        /// <summary>
        /// An optional material that may be used like the illum type to specify a different material to be used for shading non-source rays. If None, this will keep the alternat_material as mirror. If this alternate material is given as Void, then the mirror surface will be invisible. Using Void is only appropriate if the surface hides other (more detailed) geometry with the same overall reflectance (default: None).
        /// </summary>
        /// <value>An optional material that may be used like the illum type to specify a different material to be used for shading non-source rays. If None, this will keep the alternat_material as mirror. If this alternate material is given as Void, then the mirror surface will be invisible. Using Void is only appropriate if the surface hides other (more detailed) geometry with the same overall reflectance (default: None).</value>
        [DataMember(Name="alternate_material", EmitDefaultValue=false)]
        [JsonProperty("alternate_material")]
        public AnyOf<Plastic,Glass,BSDF,Glow,Light,Trans,Metal,Void,Mirror> AlternateMaterial { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            if (this is IIDdBase iDd)
                return $"Mirror {iDd.Identifier}";
       
            return "Mirror";
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
            sb.Append("Mirror:\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Modifier: ").Append(Modifier).Append("\n");
            sb.Append("  Dependencies: ").Append(Dependencies).Append("\n");
            sb.Append("  RReflectance: ").Append(RReflectance).Append("\n");
            sb.Append("  GReflectance: ").Append(GReflectance).Append("\n");
            sb.Append("  BReflectance: ").Append(BReflectance).Append("\n");
            sb.Append("  AlternateMaterial: ").Append(AlternateMaterial).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>Mirror object</returns>
        public static Mirror FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<Mirror>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>Mirror object</returns>
        public Mirror DuplicateMirror()
        {
            return Duplicate() as Mirror;
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
            return this.Equals(input as Mirror);
        }

        /// <summary>
        /// Returns true if Mirror instances are equal
        /// </summary>
        /// <param name="input">Instance of Mirror to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Mirror input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Modifier == input.Modifier ||
                    (this.Modifier != null &&
                    this.Modifier.Equals(input.Modifier))
                ) && base.Equals(input) && 
                (
                    this.Dependencies == input.Dependencies ||
                    this.Dependencies != null &&
                    input.Dependencies != null &&
                    this.Dependencies.SequenceEqual(input.Dependencies)
                ) && base.Equals(input) && 
                (
                    this.RReflectance == input.RReflectance ||
                    (this.RReflectance != null &&
                    this.RReflectance.Equals(input.RReflectance))
                ) && base.Equals(input) && 
                (
                    this.GReflectance == input.GReflectance ||
                    (this.GReflectance != null &&
                    this.GReflectance.Equals(input.GReflectance))
                ) && base.Equals(input) && 
                (
                    this.BReflectance == input.BReflectance ||
                    (this.BReflectance != null &&
                    this.BReflectance.Equals(input.BReflectance))
                ) && base.Equals(input) && 
                (
                    this.AlternateMaterial == input.AlternateMaterial ||
                    (this.AlternateMaterial != null &&
                    this.AlternateMaterial.Equals(input.AlternateMaterial))
                ) && base.Equals(input) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Modifier != null)
                    hashCode = hashCode * 59 + this.Modifier.GetHashCode();
                if (this.Dependencies != null)
                    hashCode = hashCode * 59 + this.Dependencies.GetHashCode();
                if (this.RReflectance != null)
                    hashCode = hashCode * 59 + this.RReflectance.GetHashCode();
                if (this.GReflectance != null)
                    hashCode = hashCode * 59 + this.GReflectance.GetHashCode();
                if (this.BReflectance != null)
                    hashCode = hashCode * 59 + this.BReflectance.GetHashCode();
                if (this.AlternateMaterial != null)
                    hashCode = hashCode * 59 + this.AlternateMaterial.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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
            // RReflectance (double) maximum
            if(this.RReflectance > (double)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RReflectance, must be a value less than or equal to 1.", new [] { "RReflectance" });
            }

            // RReflectance (double) minimum
            if(this.RReflectance < (double)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RReflectance, must be a value greater than or equal to 0.", new [] { "RReflectance" });
            }

            // GReflectance (double) maximum
            if(this.GReflectance > (double)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for GReflectance, must be a value less than or equal to 1.", new [] { "GReflectance" });
            }

            // GReflectance (double) minimum
            if(this.GReflectance < (double)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for GReflectance, must be a value greater than or equal to 0.", new [] { "GReflectance" });
            }

            // BReflectance (double) maximum
            if(this.BReflectance > (double)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BReflectance, must be a value less than or equal to 1.", new [] { "BReflectance" });
            }

            // BReflectance (double) minimum
            if(this.BReflectance < (double)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BReflectance, must be a value greater than or equal to 0.", new [] { "BReflectance" });
            }

            // Type (string) pattern
            Regex regexType = new Regex(@"^mirror$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }

}
