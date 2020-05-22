/* 
 * Honeybee Model Schema
 *
 * This is the documentation for Honeybee model schema.
 *
 * The version of the OpenAPI document: 1.32.0
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
    /// No mass opaque material representing a layer within an opaque construction.  Used when only the thermal resistance (R value) of the material is known.
    /// </summary>
    [DataContract]
    public partial class EnergyMaterialNoMass : IDdEnergyBaseModel, IEquatable<EnergyMaterialNoMass>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Roughness
        /// </summary>
        [DataMember(Name="roughness", EmitDefaultValue=false)]
        public Roughness? Roughness { get; set; }   = HoneybeeSchema.Roughness.MediumRough; 
        /// <summary>
        /// Initializes a new instance of the <see cref="EnergyMaterialNoMass" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EnergyMaterialNoMass() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EnergyMaterialNoMass" /> class.
        /// </summary>
        /// <param name="rValue">The thermal resistance (R-value) of the material layer [m2-K/W]. (required).</param>
        /// <param name="roughness">roughness (default to &quot;MediumRough&quot;).</param>
        /// <param name="thermalAbsorptance">Fraction of incident long wavelength radiation that is absorbed by the material. Default value is 0.9. (default to 0.9D).</param>
        /// <param name="solarAbsorptance">Fraction of incident solar radiation absorbed by the material. Default value is 0.7. (default to 0.7D).</param>
        /// <param name="visibleAbsorptance">Fraction of incident visible wavelength radiation absorbed by the material. Default value is 0.7. (default to 0.7D).</param>
        /// <param name="identifier">Text string for a unique object ID. This identifier remains constant as the object is mutated, copied, and serialized to different formats (eg. dict, idf, osm). This identifier is also used to reference the object across a Model. It must be &lt; 100 characters, use only ASCII characters and exclude (, ; ! \\n \\t). (required).</param>
        /// <param name="displayName">Display name of the object with no character restrictions..</param>
        public EnergyMaterialNoMass
        (
            string identifier, double rValue, // Required parameters
            string displayName= default, Roughness? roughness = HoneybeeSchema.Roughness.MediumRough, double thermalAbsorptance = 0.9D, double solarAbsorptance = 0.7D, double visibleAbsorptance = 0.7D// Optional parameters
        ) : base(identifier: identifier, displayName: displayName )// BaseClass
        {
            // to ensure "rValue" is required (not null)
            if (rValue == null)
            {
                throw new InvalidDataException("rValue is a required property for EnergyMaterialNoMass and cannot be null");
            }
            else
            {
                this.RValue = rValue;
            }
            
            // use default value if no "roughness" provided
            if (roughness == null)
            {
                this.Roughness = HoneybeeSchema.Roughness.MediumRough;
            }
            else
            {
                this.Roughness = roughness;
            }
            // use default value if no "thermalAbsorptance" provided
            if (thermalAbsorptance == null)
            {
                this.ThermalAbsorptance = 0.9D;
            }
            else
            {
                this.ThermalAbsorptance = thermalAbsorptance;
            }
            // use default value if no "solarAbsorptance" provided
            if (solarAbsorptance == null)
            {
                this.SolarAbsorptance = 0.7D;
            }
            else
            {
                this.SolarAbsorptance = solarAbsorptance;
            }
            // use default value if no "visibleAbsorptance" provided
            if (visibleAbsorptance == null)
            {
                this.VisibleAbsorptance = 0.7D;
            }
            else
            {
                this.VisibleAbsorptance = visibleAbsorptance;
            }

            // Set non-required readonly properties with defaultValue
            this.Type = "EnergyMaterialNoMass";
        }
        
        /// <summary>
        /// The thermal resistance (R-value) of the material layer [m2-K/W].
        /// </summary>
        /// <value>The thermal resistance (R-value) of the material layer [m2-K/W].</value>
        [DataMember(Name="r_value", EmitDefaultValue=false)]
        [JsonProperty("r_value")]
        public double RValue { get; set; } 
        /// <summary>
        /// Fraction of incident long wavelength radiation that is absorbed by the material. Default value is 0.9.
        /// </summary>
        /// <value>Fraction of incident long wavelength radiation that is absorbed by the material. Default value is 0.9.</value>
        [DataMember(Name="thermal_absorptance", EmitDefaultValue=false)]
        [JsonProperty("thermal_absorptance")]
        public double ThermalAbsorptance { get; set; }  = 0.9D;
        /// <summary>
        /// Fraction of incident solar radiation absorbed by the material. Default value is 0.7.
        /// </summary>
        /// <value>Fraction of incident solar radiation absorbed by the material. Default value is 0.7.</value>
        [DataMember(Name="solar_absorptance", EmitDefaultValue=false)]
        [JsonProperty("solar_absorptance")]
        public double SolarAbsorptance { get; set; }  = 0.7D;
        /// <summary>
        /// Fraction of incident visible wavelength radiation absorbed by the material. Default value is 0.7.
        /// </summary>
        /// <value>Fraction of incident visible wavelength radiation absorbed by the material. Default value is 0.7.</value>
        [DataMember(Name="visible_absorptance", EmitDefaultValue=false)]
        [JsonProperty("visible_absorptance")]
        public double VisibleAbsorptance { get; set; }  = 0.7D;
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            if (this is IIDdBase iDd)
                return $"EnergyMaterialNoMass {iDd.Identifier}";
       
            return "EnergyMaterialNoMass";
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
            sb.Append("EnergyMaterialNoMass:\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  RValue: ").Append(RValue).Append("\n");
            sb.Append("  Roughness: ").Append(Roughness).Append("\n");
            sb.Append("  ThermalAbsorptance: ").Append(ThermalAbsorptance).Append("\n");
            sb.Append("  SolarAbsorptance: ").Append(SolarAbsorptance).Append("\n");
            sb.Append("  VisibleAbsorptance: ").Append(VisibleAbsorptance).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>EnergyMaterialNoMass object</returns>
        public static EnergyMaterialNoMass FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<EnergyMaterialNoMass>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>EnergyMaterialNoMass object</returns>
        public EnergyMaterialNoMass DuplicateEnergyMaterialNoMass()
        {
            return Duplicate() as EnergyMaterialNoMass;
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
            return this.Equals(input as EnergyMaterialNoMass);
        }

        /// <summary>
        /// Returns true if EnergyMaterialNoMass instances are equal
        /// </summary>
        /// <param name="input">Instance of EnergyMaterialNoMass to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnergyMaterialNoMass input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.RValue == input.RValue ||
                    (this.RValue != null &&
                    this.RValue.Equals(input.RValue))
                ) && base.Equals(input) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && base.Equals(input) && 
                (
                    this.Roughness == input.Roughness ||
                    (this.Roughness != null &&
                    this.Roughness.Equals(input.Roughness))
                ) && base.Equals(input) && 
                (
                    this.ThermalAbsorptance == input.ThermalAbsorptance ||
                    (this.ThermalAbsorptance != null &&
                    this.ThermalAbsorptance.Equals(input.ThermalAbsorptance))
                ) && base.Equals(input) && 
                (
                    this.SolarAbsorptance == input.SolarAbsorptance ||
                    (this.SolarAbsorptance != null &&
                    this.SolarAbsorptance.Equals(input.SolarAbsorptance))
                ) && base.Equals(input) && 
                (
                    this.VisibleAbsorptance == input.VisibleAbsorptance ||
                    (this.VisibleAbsorptance != null &&
                    this.VisibleAbsorptance.Equals(input.VisibleAbsorptance))
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
                if (this.RValue != null)
                    hashCode = hashCode * 59 + this.RValue.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Roughness != null)
                    hashCode = hashCode * 59 + this.Roughness.GetHashCode();
                if (this.ThermalAbsorptance != null)
                    hashCode = hashCode * 59 + this.ThermalAbsorptance.GetHashCode();
                if (this.SolarAbsorptance != null)
                    hashCode = hashCode * 59 + this.SolarAbsorptance.GetHashCode();
                if (this.VisibleAbsorptance != null)
                    hashCode = hashCode * 59 + this.VisibleAbsorptance.GetHashCode();
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
            // RValue (double) minimum
            if(this.RValue < (double)0.001)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RValue, must be a value greater than or equal to 0.001.", new [] { "RValue" });
            }

            // Type (string) pattern
            Regex regexType = new Regex(@"^EnergyMaterialNoMass$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            // ThermalAbsorptance (double) maximum
            if(this.ThermalAbsorptance > (double)0.99999)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ThermalAbsorptance, must be a value less than or equal to 0.99999.", new [] { "ThermalAbsorptance" });
            }

            // SolarAbsorptance (double) maximum
            if(this.SolarAbsorptance > (double)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SolarAbsorptance, must be a value less than or equal to 1.", new [] { "SolarAbsorptance" });
            }

            // SolarAbsorptance (double) minimum
            if(this.SolarAbsorptance < (double)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SolarAbsorptance, must be a value greater than or equal to 0.", new [] { "SolarAbsorptance" });
            }

            // VisibleAbsorptance (double) maximum
            if(this.VisibleAbsorptance > (double)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for VisibleAbsorptance, must be a value less than or equal to 1.", new [] { "VisibleAbsorptance" });
            }

            // VisibleAbsorptance (double) minimum
            if(this.VisibleAbsorptance < (double)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for VisibleAbsorptance, must be a value greater than or equal to 0.", new [] { "VisibleAbsorptance" });
            }

            yield break;
        }
    }

}
