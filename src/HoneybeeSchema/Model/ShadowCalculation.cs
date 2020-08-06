/* 
 * Honeybee Energy Simulation Parameter Schema
 *
 * This is the documentation for Honeybee energy simulation parameter schema.
 *
 * The version of the OpenAPI document: 1.36.0
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
    /// Used to describe settings for EnergyPlus shadow calculation.
    /// </summary>
    [DataContract]
    public partial class ShadowCalculation : HoneybeeObject, IEquatable<ShadowCalculation>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets SolarDistribution
        /// </summary>
        [DataMember(Name="solar_distribution", EmitDefaultValue=false)]
        public SolarDistribution? SolarDistribution { get; set; }   
        /// <summary>
        /// Gets or Sets CalculationMethod
        /// </summary>
        [DataMember(Name="calculation_method", EmitDefaultValue=false)]
        public CalculationMethod? CalculationMethod { get; set; }   
        /// <summary>
        /// Gets or Sets CalculationUpdateMethod
        /// </summary>
        [DataMember(Name="calculation_update_method", EmitDefaultValue=false)]
        public CalculationUpdateMethod? CalculationUpdateMethod { get; set; }   
        /// <summary>
        /// Initializes a new instance of the <see cref="ShadowCalculation" /> class.
        /// </summary>
        /// <param name="solarDistribution">solarDistribution.</param>
        /// <param name="calculationMethod">calculationMethod.</param>
        /// <param name="calculationUpdateMethod">calculationUpdateMethod.</param>
        /// <param name="calculationFrequency">Integer for the number of days in each period for which a unique shadow calculation will be performed. This field is only used if the Periodic calculation_method is used. (default to 30).</param>
        /// <param name="maximumFigures">Number of allowable figures in shadow overlap calculations. (default to 15000).</param>
        public ShadowCalculation
        (
             // Required parameters
            SolarDistribution? solarDistribution= default, CalculationMethod? calculationMethod= default, CalculationUpdateMethod? calculationUpdateMethod= default, int calculationFrequency = 30, int maximumFigures = 15000// Optional parameters
        )// BaseClass
        {
            this.SolarDistribution = solarDistribution;
            this.CalculationMethod = calculationMethod;
            this.CalculationUpdateMethod = calculationUpdateMethod;
            // use default value if no "calculationFrequency" provided
            if (calculationFrequency == null)
            {
                this.CalculationFrequency = 30;
            }
            else
            {
                this.CalculationFrequency = calculationFrequency;
            }
            // use default value if no "maximumFigures" provided
            if (maximumFigures == null)
            {
                this.MaximumFigures = 15000;
            }
            else
            {
                this.MaximumFigures = maximumFigures;
            }

            // Set non-required readonly properties with defaultValue
            this.Type = "ShadowCalculation";
        }
        
        /// <summary>
        /// Integer for the number of days in each period for which a unique shadow calculation will be performed. This field is only used if the Periodic calculation_method is used.
        /// </summary>
        /// <value>Integer for the number of days in each period for which a unique shadow calculation will be performed. This field is only used if the Periodic calculation_method is used.</value>
        [DataMember(Name="calculation_frequency", EmitDefaultValue=false)]
        [JsonProperty("calculation_frequency")]
        public int CalculationFrequency { get; set; }  = 30;
        /// <summary>
        /// Number of allowable figures in shadow overlap calculations.
        /// </summary>
        /// <value>Number of allowable figures in shadow overlap calculations.</value>
        [DataMember(Name="maximum_figures", EmitDefaultValue=false)]
        [JsonProperty("maximum_figures")]
        public int MaximumFigures { get; set; }  = 15000;
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            if (this is IIDdBase iDd)
                return $"ShadowCalculation {iDd.Identifier}";
       
            return "ShadowCalculation";
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
            sb.Append("ShadowCalculation:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  SolarDistribution: ").Append(SolarDistribution).Append("\n");
            sb.Append("  CalculationMethod: ").Append(CalculationMethod).Append("\n");
            sb.Append("  CalculationUpdateMethod: ").Append(CalculationUpdateMethod).Append("\n");
            sb.Append("  CalculationFrequency: ").Append(CalculationFrequency).Append("\n");
            sb.Append("  MaximumFigures: ").Append(MaximumFigures).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>ShadowCalculation object</returns>
        public static ShadowCalculation FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<ShadowCalculation>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>ShadowCalculation object</returns>
        public ShadowCalculation DuplicateShadowCalculation()
        {
            return Duplicate() as ShadowCalculation;
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
            return this.Equals(input as ShadowCalculation);
        }

        /// <summary>
        /// Returns true if ShadowCalculation instances are equal
        /// </summary>
        /// <param name="input">Instance of ShadowCalculation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShadowCalculation input)
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
                    this.SolarDistribution == input.SolarDistribution ||
                    (this.SolarDistribution != null &&
                    this.SolarDistribution.Equals(input.SolarDistribution))
                ) && 
                (
                    this.CalculationMethod == input.CalculationMethod ||
                    (this.CalculationMethod != null &&
                    this.CalculationMethod.Equals(input.CalculationMethod))
                ) && 
                (
                    this.CalculationUpdateMethod == input.CalculationUpdateMethod ||
                    (this.CalculationUpdateMethod != null &&
                    this.CalculationUpdateMethod.Equals(input.CalculationUpdateMethod))
                ) && 
                (
                    this.CalculationFrequency == input.CalculationFrequency ||
                    (this.CalculationFrequency != null &&
                    this.CalculationFrequency.Equals(input.CalculationFrequency))
                ) && 
                (
                    this.MaximumFigures == input.MaximumFigures ||
                    (this.MaximumFigures != null &&
                    this.MaximumFigures.Equals(input.MaximumFigures))
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
                if (this.SolarDistribution != null)
                    hashCode = hashCode * 59 + this.SolarDistribution.GetHashCode();
                if (this.CalculationMethod != null)
                    hashCode = hashCode * 59 + this.CalculationMethod.GetHashCode();
                if (this.CalculationUpdateMethod != null)
                    hashCode = hashCode * 59 + this.CalculationUpdateMethod.GetHashCode();
                if (this.CalculationFrequency != null)
                    hashCode = hashCode * 59 + this.CalculationFrequency.GetHashCode();
                if (this.MaximumFigures != null)
                    hashCode = hashCode * 59 + this.MaximumFigures.GetHashCode();
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
            Regex regexType = new Regex(@"^ShadowCalculation$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            // CalculationFrequency (int) minimum
            if(this.CalculationFrequency < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CalculationFrequency, must be a value greater than or equal to 1.", new [] { "CalculationFrequency" });
            }

            // MaximumFigures (int) minimum
            if(this.MaximumFigures < (int)200)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MaximumFigures, must be a value greater than or equal to 200.", new [] { "MaximumFigures" });
            }

            yield break;
        }
    }

}
