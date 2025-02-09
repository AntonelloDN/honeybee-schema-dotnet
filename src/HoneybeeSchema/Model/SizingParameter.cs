/* 
 * Honeybee Simulation Parameter Schema
 *
 * Documentation for Honeybee simulation-parameter schema
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
    /// Used to specify heating and cooling sizing criteria and safety factors.
    /// </summary>
    [DataContract(Name = "SizingParameter")]
    public partial class SizingParameter : OpenAPIGenBaseModel, IEquatable<SizingParameter>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SizingParameter" /> class.
        /// </summary>
        /// <param name="designDays">A list of DesignDays that represent the criteria for which the HVAC systems will be sized..</param>
        /// <param name="heatingFactor">A number that will be multiplied by the peak heating load for each zone in order to size the heating system. (default to 1.25D).</param>
        /// <param name="coolingFactor">A number that will be multiplied by the peak cooling load for each zone in order to size the heating system. (default to 1.15D).</param>
        public SizingParameter
        (
           // Required parameters
           List<DesignDay> designDays= default, double heatingFactor = 1.25D, double coolingFactor = 1.15D// Optional parameters
        ) : base()// BaseClass
        {
            this.DesignDays = designDays;
            this.HeatingFactor = heatingFactor;
            this.CoolingFactor = coolingFactor;

            // Set non-required readonly properties with defaultValue
            this.Type = "SizingParameter";
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type")]
        public override string Type { get; protected set; }  = "SizingParameter";

        /// <summary>
        /// A list of DesignDays that represent the criteria for which the HVAC systems will be sized.
        /// </summary>
        /// <value>A list of DesignDays that represent the criteria for which the HVAC systems will be sized.</value>
        [DataMember(Name = "design_days")]
        public List<DesignDay> DesignDays { get; set; } 
        /// <summary>
        /// A number that will be multiplied by the peak heating load for each zone in order to size the heating system.
        /// </summary>
        /// <value>A number that will be multiplied by the peak heating load for each zone in order to size the heating system.</value>
        [DataMember(Name = "heating_factor")]
        public double HeatingFactor { get; set; }  = 1.25D;
        /// <summary>
        /// A number that will be multiplied by the peak cooling load for each zone in order to size the heating system.
        /// </summary>
        /// <value>A number that will be multiplied by the peak cooling load for each zone in order to size the heating system.</value>
        [DataMember(Name = "cooling_factor")]
        public double CoolingFactor { get; set; }  = 1.15D;

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "SizingParameter";
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
            sb.Append("SizingParameter:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  DesignDays: ").Append(DesignDays).Append("\n");
            sb.Append("  HeatingFactor: ").Append(HeatingFactor).Append("\n");
            sb.Append("  CoolingFactor: ").Append(CoolingFactor).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>SizingParameter object</returns>
        public static SizingParameter FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<SizingParameter>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>SizingParameter object</returns>
        public virtual SizingParameter DuplicateSizingParameter()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateSizingParameter();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicateSizingParameter();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as SizingParameter);
        }

        /// <summary>
        /// Returns true if SizingParameter instances are equal
        /// </summary>
        /// <param name="input">Instance of SizingParameter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SizingParameter input)
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
                    this.DesignDays == input.DesignDays ||
                    this.DesignDays != null &&
                    input.DesignDays != null &&
                    this.DesignDays.SequenceEqual(input.DesignDays)
                ) && base.Equals(input) && 
                (
                    this.HeatingFactor == input.HeatingFactor ||
                    (this.HeatingFactor != null &&
                    this.HeatingFactor.Equals(input.HeatingFactor))
                ) && base.Equals(input) && 
                (
                    this.CoolingFactor == input.CoolingFactor ||
                    (this.CoolingFactor != null &&
                    this.CoolingFactor.Equals(input.CoolingFactor))
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
                if (this.DesignDays != null)
                    hashCode = hashCode * 59 + this.DesignDays.GetHashCode();
                if (this.HeatingFactor != null)
                    hashCode = hashCode * 59 + this.HeatingFactor.GetHashCode();
                if (this.CoolingFactor != null)
                    hashCode = hashCode * 59 + this.CoolingFactor.GetHashCode();
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
            Regex regexType = new Regex(@"^SizingParameter$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
