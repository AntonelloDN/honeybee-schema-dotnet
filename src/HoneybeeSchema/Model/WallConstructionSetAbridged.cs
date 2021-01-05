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
    /// A set of constructions for wall assemblies.
    /// </summary>
    [DataContract(Name = "WallConstructionSetAbridged")]
    public partial class WallConstructionSetAbridged : IEquatable<WallConstructionSetAbridged>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WallConstructionSetAbridged" /> class.
        /// </summary>
        /// <param name="interiorConstruction">Identifier for an OpaqueConstruction for faces with a Surface or Adiabatic boundary condition..</param>
        /// <param name="exteriorConstruction">Identifier for an OpaqueConstruction for faces with an Outdoors boundary condition..</param>
        /// <param name="groundConstruction">Identifier for an OpaqueConstruction for faces with a Ground boundary condition..</param>
        public WallConstructionSetAbridged
        (
           // Required parameters
            string interiorConstruction= default, string exteriorConstruction= default, string groundConstruction= default // Optional parameters
        ) : base(interiorConstruction: interiorConstruction, exteriorConstruction: exteriorConstruction, groundConstruction: groundConstruction)// BaseClass
        {
            this.InteriorConstruction = interiorConstruction;
            this.ExteriorConstruction = exteriorConstruction;
            this.GroundConstruction = groundConstruction;

            // Set non-required readonly properties with defaultValue
            this.Type = "WallConstructionSetAbridged";
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type")]
        public override string Type { get; protected internal set; }  = "WallConstructionSetAbridged";


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "WallConstructionSetAbridged";
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
            sb.Append("WallConstructionSetAbridged:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  InteriorConstruction: ").Append(InteriorConstruction).Append("\n");
            sb.Append("  ExteriorConstruction: ").Append(ExteriorConstruction).Append("\n");
            sb.Append("  GroundConstruction: ").Append(GroundConstruction).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>WallConstructionSetAbridged object</returns>
        public static WallConstructionSetAbridged FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<WallConstructionSetAbridged>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>WallConstructionSetAbridged object</returns>
        public virtual WallConstructionSetAbridged DuplicateWallConstructionSetAbridged()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateWallConstructionSetAbridged();
        }

     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as WallConstructionSetAbridged);
        }

        /// <summary>
        /// Returns true if WallConstructionSetAbridged instances are equal
        /// </summary>
        /// <param name="input">Instance of WallConstructionSetAbridged to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WallConstructionSetAbridged input)
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
                    this.InteriorConstruction == input.InteriorConstruction ||
                    (this.InteriorConstruction != null &&
                    this.InteriorConstruction.Equals(input.InteriorConstruction))
                ) && 
                (
                    this.ExteriorConstruction == input.ExteriorConstruction ||
                    (this.ExteriorConstruction != null &&
                    this.ExteriorConstruction.Equals(input.ExteriorConstruction))
                ) && 
                (
                    this.GroundConstruction == input.GroundConstruction ||
                    (this.GroundConstruction != null &&
                    this.GroundConstruction.Equals(input.GroundConstruction))
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
                if (this.InteriorConstruction != null)
                    hashCode = hashCode * 59 + this.InteriorConstruction.GetHashCode();
                if (this.ExteriorConstruction != null)
                    hashCode = hashCode * 59 + this.ExteriorConstruction.GetHashCode();
                if (this.GroundConstruction != null)
                    hashCode = hashCode * 59 + this.GroundConstruction.GetHashCode();
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
            Regex regexType = new Regex(@"^WallConstructionSetAbridged$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            // InteriorConstruction (string) maxLength
            if(this.InteriorConstruction != null && this.InteriorConstruction.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for InteriorConstruction, length must be less than 100.", new [] { "InteriorConstruction" });
            }

            // InteriorConstruction (string) minLength
            if(this.InteriorConstruction != null && this.InteriorConstruction.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for InteriorConstruction, length must be greater than 1.", new [] { "InteriorConstruction" });
            }
            
            // ExteriorConstruction (string) maxLength
            if(this.ExteriorConstruction != null && this.ExteriorConstruction.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ExteriorConstruction, length must be less than 100.", new [] { "ExteriorConstruction" });
            }

            // ExteriorConstruction (string) minLength
            if(this.ExteriorConstruction != null && this.ExteriorConstruction.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ExteriorConstruction, length must be greater than 1.", new [] { "ExteriorConstruction" });
            }
            
            // GroundConstruction (string) maxLength
            if(this.GroundConstruction != null && this.GroundConstruction.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for GroundConstruction, length must be less than 100.", new [] { "GroundConstruction" });
            }

            // GroundConstruction (string) minLength
            if(this.GroundConstruction != null && this.GroundConstruction.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for GroundConstruction, length must be greater than 1.", new [] { "GroundConstruction" });
            }
            
            yield break;
        }
    }
}
