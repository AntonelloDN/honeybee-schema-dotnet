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
    /// A set of constructions for different surface types and boundary conditions.
    /// </summary>
    [DataContract(Name = "ConstructionSetAbridged")]
    public partial class ConstructionSetAbridged : IEquatable<ConstructionSetAbridged>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConstructionSetAbridged" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConstructionSetAbridged() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "ConstructionSetAbridged";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="ConstructionSetAbridged" /> class.
        /// </summary>
        /// <param name="identifier">Text string for a unique object ID. This identifier remains constant as the object is mutated, copied, and serialized to different formats (eg. dict, idf, osm). This identifier is also used to reference the object across a Model. It must be &lt; 100 characters, use only ASCII characters and exclude (, ; ! \\n \\t). (required).</param>
        /// <param name="displayName">Display name of the object with no character restrictions..</param>
        /// <param name="wallSet">A WallConstructionSetAbridged object for this ConstructionSet..</param>
        /// <param name="floorSet">A FloorConstructionSetAbridged object for this ConstructionSet..</param>
        /// <param name="roofCeilingSet">A RoofCeilingConstructionSetAbridged object for this ConstructionSet..</param>
        /// <param name="apertureSet">A ApertureConstructionSetAbridged object for this ConstructionSet..</param>
        /// <param name="doorSet">A DoorConstructionSetAbridged object for this ConstructionSet..</param>
        /// <param name="shadeConstruction">The identifier of a ShadeConstruction to set the reflectance properties of all outdoor shades of all objects to which this ConstructionSet is assigned..</param>
        /// <param name="airBoundaryConstruction">The identifier of an AirBoundaryConstruction to set the properties of Faces with an AirBoundary type..</param>
        public ConstructionSetAbridged
        (
             string identifier, // Required parameters
            string displayName= default, WallConstructionSetAbridged wallSet= default, FloorConstructionSetAbridged floorSet= default, RoofCeilingConstructionSetAbridged roofCeilingSet= default, ApertureConstructionSetAbridged apertureSet= default, DoorConstructionSetAbridged doorSet= default, string shadeConstruction= default, string airBoundaryConstruction= default// Optional parameters
        )// BaseClass
        {
            // to ensure "identifier" is required (not null)
            this.Identifier = identifier ?? throw new ArgumentNullException("identifier is a required property for ConstructionSetAbridged and cannot be null");
            this.DisplayName = displayName;
            this.WallSet = wallSet;
            this.FloorSet = floorSet;
            this.RoofCeilingSet = roofCeilingSet;
            this.ApertureSet = apertureSet;
            this.DoorSet = doorSet;
            this.ShadeConstruction = shadeConstruction;
            this.AirBoundaryConstruction = airBoundaryConstruction;

            // Set non-required readonly properties with defaultValue
            this.Type = "ConstructionSetAbridged";
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type")]
        public override string Type { get; protected internal set; }  = "ConstructionSetAbridged";

        /// <summary>
        /// Text string for a unique object ID. This identifier remains constant as the object is mutated, copied, and serialized to different formats (eg. dict, idf, osm). This identifier is also used to reference the object across a Model. It must be &lt; 100 characters, use only ASCII characters and exclude (, ; ! \\n \\t).
        /// </summary>
        /// <value>Text string for a unique object ID. This identifier remains constant as the object is mutated, copied, and serialized to different formats (eg. dict, idf, osm). This identifier is also used to reference the object across a Model. It must be &lt; 100 characters, use only ASCII characters and exclude (, ; ! \\n \\t).</value>
        [DataMember(Name = "identifier", IsRequired = true, EmitDefaultValue = false)]
        public string Identifier { get; set; } 
        /// <summary>
        /// Display name of the object with no character restrictions.
        /// </summary>
        /// <value>Display name of the object with no character restrictions.</value>
        [DataMember(Name = "display_name", EmitDefaultValue = false)]
        public string DisplayName { get; set; } 
        /// <summary>
        /// A WallConstructionSetAbridged object for this ConstructionSet.
        /// </summary>
        /// <value>A WallConstructionSetAbridged object for this ConstructionSet.</value>
        [DataMember(Name = "wall_set")]
        public WallConstructionSetAbridged WallSet { get; set; } 
        /// <summary>
        /// A FloorConstructionSetAbridged object for this ConstructionSet.
        /// </summary>
        /// <value>A FloorConstructionSetAbridged object for this ConstructionSet.</value>
        [DataMember(Name = "floor_set")]
        public FloorConstructionSetAbridged FloorSet { get; set; } 
        /// <summary>
        /// A RoofCeilingConstructionSetAbridged object for this ConstructionSet.
        /// </summary>
        /// <value>A RoofCeilingConstructionSetAbridged object for this ConstructionSet.</value>
        [DataMember(Name = "roof_ceiling_set")]
        public RoofCeilingConstructionSetAbridged RoofCeilingSet { get; set; } 
        /// <summary>
        /// A ApertureConstructionSetAbridged object for this ConstructionSet.
        /// </summary>
        /// <value>A ApertureConstructionSetAbridged object for this ConstructionSet.</value>
        [DataMember(Name = "aperture_set")]
        public ApertureConstructionSetAbridged ApertureSet { get; set; } 
        /// <summary>
        /// A DoorConstructionSetAbridged object for this ConstructionSet.
        /// </summary>
        /// <value>A DoorConstructionSetAbridged object for this ConstructionSet.</value>
        [DataMember(Name = "door_set")]
        public DoorConstructionSetAbridged DoorSet { get; set; } 
        /// <summary>
        /// The identifier of a ShadeConstruction to set the reflectance properties of all outdoor shades of all objects to which this ConstructionSet is assigned.
        /// </summary>
        /// <value>The identifier of a ShadeConstruction to set the reflectance properties of all outdoor shades of all objects to which this ConstructionSet is assigned.</value>
        [DataMember(Name = "shade_construction")]
        public string ShadeConstruction { get; set; } 
        /// <summary>
        /// The identifier of an AirBoundaryConstruction to set the properties of Faces with an AirBoundary type.
        /// </summary>
        /// <value>The identifier of an AirBoundaryConstruction to set the properties of Faces with an AirBoundary type.</value>
        [DataMember(Name = "air_boundary_construction")]
        public string AirBoundaryConstruction { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "ConstructionSetAbridged";
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
            sb.Append("ConstructionSetAbridged:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  WallSet: ").Append(WallSet).Append("\n");
            sb.Append("  FloorSet: ").Append(FloorSet).Append("\n");
            sb.Append("  RoofCeilingSet: ").Append(RoofCeilingSet).Append("\n");
            sb.Append("  ApertureSet: ").Append(ApertureSet).Append("\n");
            sb.Append("  DoorSet: ").Append(DoorSet).Append("\n");
            sb.Append("  ShadeConstruction: ").Append(ShadeConstruction).Append("\n");
            sb.Append("  AirBoundaryConstruction: ").Append(AirBoundaryConstruction).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>ConstructionSetAbridged object</returns>
        public static ConstructionSetAbridged FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<ConstructionSetAbridged>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>ConstructionSetAbridged object</returns>
        public virtual ConstructionSetAbridged DuplicateConstructionSetAbridged()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateConstructionSetAbridged();
        }

     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as ConstructionSetAbridged);
        }

        /// <summary>
        /// Returns true if ConstructionSetAbridged instances are equal
        /// </summary>
        /// <param name="input">Instance of ConstructionSetAbridged to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConstructionSetAbridged input)
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
                    this.Identifier == input.Identifier ||
                    (this.Identifier != null &&
                    this.Identifier.Equals(input.Identifier))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.WallSet == input.WallSet ||
                    (this.WallSet != null &&
                    this.WallSet.Equals(input.WallSet))
                ) && 
                (
                    this.FloorSet == input.FloorSet ||
                    (this.FloorSet != null &&
                    this.FloorSet.Equals(input.FloorSet))
                ) && 
                (
                    this.RoofCeilingSet == input.RoofCeilingSet ||
                    (this.RoofCeilingSet != null &&
                    this.RoofCeilingSet.Equals(input.RoofCeilingSet))
                ) && 
                (
                    this.ApertureSet == input.ApertureSet ||
                    (this.ApertureSet != null &&
                    this.ApertureSet.Equals(input.ApertureSet))
                ) && 
                (
                    this.DoorSet == input.DoorSet ||
                    (this.DoorSet != null &&
                    this.DoorSet.Equals(input.DoorSet))
                ) && 
                (
                    this.ShadeConstruction == input.ShadeConstruction ||
                    (this.ShadeConstruction != null &&
                    this.ShadeConstruction.Equals(input.ShadeConstruction))
                ) && 
                (
                    this.AirBoundaryConstruction == input.AirBoundaryConstruction ||
                    (this.AirBoundaryConstruction != null &&
                    this.AirBoundaryConstruction.Equals(input.AirBoundaryConstruction))
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
                if (this.Identifier != null)
                    hashCode = hashCode * 59 + this.Identifier.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.WallSet != null)
                    hashCode = hashCode * 59 + this.WallSet.GetHashCode();
                if (this.FloorSet != null)
                    hashCode = hashCode * 59 + this.FloorSet.GetHashCode();
                if (this.RoofCeilingSet != null)
                    hashCode = hashCode * 59 + this.RoofCeilingSet.GetHashCode();
                if (this.ApertureSet != null)
                    hashCode = hashCode * 59 + this.ApertureSet.GetHashCode();
                if (this.DoorSet != null)
                    hashCode = hashCode * 59 + this.DoorSet.GetHashCode();
                if (this.ShadeConstruction != null)
                    hashCode = hashCode * 59 + this.ShadeConstruction.GetHashCode();
                if (this.AirBoundaryConstruction != null)
                    hashCode = hashCode * 59 + this.AirBoundaryConstruction.GetHashCode();
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
            Regex regexType = new Regex(@"^ConstructionSetAbridged$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

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
            
            // ShadeConstruction (string) maxLength
            if(this.ShadeConstruction != null && this.ShadeConstruction.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ShadeConstruction, length must be less than 100.", new [] { "ShadeConstruction" });
            }

            // ShadeConstruction (string) minLength
            if(this.ShadeConstruction != null && this.ShadeConstruction.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ShadeConstruction, length must be greater than 1.", new [] { "ShadeConstruction" });
            }
            
            // AirBoundaryConstruction (string) maxLength
            if(this.AirBoundaryConstruction != null && this.AirBoundaryConstruction.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AirBoundaryConstruction, length must be less than 100.", new [] { "AirBoundaryConstruction" });
            }

            // AirBoundaryConstruction (string) minLength
            if(this.AirBoundaryConstruction != null && this.AirBoundaryConstruction.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AirBoundaryConstruction, length must be greater than 1.", new [] { "AirBoundaryConstruction" });
            }
            
            yield break;
        }
    }
}
