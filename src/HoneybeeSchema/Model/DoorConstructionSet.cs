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
    /// A set of constructions for door assemblies.
    /// </summary>
    [DataContract]
    public partial class DoorConstructionSet : HoneybeeObject, IEquatable<DoorConstructionSet>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="DoorConstructionSet" /> class.
        /// </summary>
        /// <param name="interiorConstruction">An OpaqueConstruction for all opaque doors with a Surface boundary condition..</param>
        /// <param name="exteriorConstruction">An OpaqueConstruction for opaque doors with an Outdoors boundary condition and a Wall face type for their parent face..</param>
        /// <param name="overheadConstruction">An OpaqueConstruction for opaque doors with an Outdoors boundary condition and a RoofCeiling or Floor type for their parent face..</param>
        /// <param name="exteriorGlassConstruction">A WindowConstruction for all glass doors with an Outdoors boundary condition..</param>
        /// <param name="interiorGlassConstruction">A WindowConstruction for all glass doors with a Surface boundary condition..</param>
        public DoorConstructionSet
        (
             // Required parameters
            OpaqueConstruction interiorConstruction= default, OpaqueConstruction exteriorConstruction= default, OpaqueConstruction overheadConstruction= default, WindowConstruction exteriorGlassConstruction= default, WindowConstruction interiorGlassConstruction= default// Optional parameters
        )// BaseClass
        {
            this.InteriorConstruction = interiorConstruction;
            this.ExteriorConstruction = exteriorConstruction;
            this.OverheadConstruction = overheadConstruction;
            this.ExteriorGlassConstruction = exteriorGlassConstruction;
            this.InteriorGlassConstruction = interiorGlassConstruction;

            // Set non-required readonly properties with defaultValue
            this.Type = "DoorConstructionSet";
        }
        
        /// <summary>
        /// An OpaqueConstruction for all opaque doors with a Surface boundary condition.
        /// </summary>
        /// <value>An OpaqueConstruction for all opaque doors with a Surface boundary condition.</value>
        [DataMember(Name="interior_construction", EmitDefaultValue=false)]
        [JsonProperty("interior_construction")]
        public OpaqueConstruction InteriorConstruction { get; set; } 
        /// <summary>
        /// An OpaqueConstruction for opaque doors with an Outdoors boundary condition and a Wall face type for their parent face.
        /// </summary>
        /// <value>An OpaqueConstruction for opaque doors with an Outdoors boundary condition and a Wall face type for their parent face.</value>
        [DataMember(Name="exterior_construction", EmitDefaultValue=false)]
        [JsonProperty("exterior_construction")]
        public OpaqueConstruction ExteriorConstruction { get; set; } 
        /// <summary>
        /// An OpaqueConstruction for opaque doors with an Outdoors boundary condition and a RoofCeiling or Floor type for their parent face.
        /// </summary>
        /// <value>An OpaqueConstruction for opaque doors with an Outdoors boundary condition and a RoofCeiling or Floor type for their parent face.</value>
        [DataMember(Name="overhead_construction", EmitDefaultValue=false)]
        [JsonProperty("overhead_construction")]
        public OpaqueConstruction OverheadConstruction { get; set; } 
        /// <summary>
        /// A WindowConstruction for all glass doors with an Outdoors boundary condition.
        /// </summary>
        /// <value>A WindowConstruction for all glass doors with an Outdoors boundary condition.</value>
        [DataMember(Name="exterior_glass_construction", EmitDefaultValue=false)]
        [JsonProperty("exterior_glass_construction")]
        public WindowConstruction ExteriorGlassConstruction { get; set; } 
        /// <summary>
        /// A WindowConstruction for all glass doors with a Surface boundary condition.
        /// </summary>
        /// <value>A WindowConstruction for all glass doors with a Surface boundary condition.</value>
        [DataMember(Name="interior_glass_construction", EmitDefaultValue=false)]
        [JsonProperty("interior_glass_construction")]
        public WindowConstruction InteriorGlassConstruction { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            if (this is IIDdBase iDd)
                return $"DoorConstructionSet {iDd.Identifier}";
       
            return "DoorConstructionSet";
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
            sb.Append("DoorConstructionSet:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  InteriorConstruction: ").Append(InteriorConstruction).Append("\n");
            sb.Append("  ExteriorConstruction: ").Append(ExteriorConstruction).Append("\n");
            sb.Append("  OverheadConstruction: ").Append(OverheadConstruction).Append("\n");
            sb.Append("  ExteriorGlassConstruction: ").Append(ExteriorGlassConstruction).Append("\n");
            sb.Append("  InteriorGlassConstruction: ").Append(InteriorGlassConstruction).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>DoorConstructionSet object</returns>
        public static DoorConstructionSet FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<DoorConstructionSet>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>DoorConstructionSet object</returns>
        public DoorConstructionSet DuplicateDoorConstructionSet()
        {
            return Duplicate() as DoorConstructionSet;
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
            return this.Equals(input as DoorConstructionSet);
        }

        /// <summary>
        /// Returns true if DoorConstructionSet instances are equal
        /// </summary>
        /// <param name="input">Instance of DoorConstructionSet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DoorConstructionSet input)
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
                    this.OverheadConstruction == input.OverheadConstruction ||
                    (this.OverheadConstruction != null &&
                    this.OverheadConstruction.Equals(input.OverheadConstruction))
                ) && 
                (
                    this.ExteriorGlassConstruction == input.ExteriorGlassConstruction ||
                    (this.ExteriorGlassConstruction != null &&
                    this.ExteriorGlassConstruction.Equals(input.ExteriorGlassConstruction))
                ) && 
                (
                    this.InteriorGlassConstruction == input.InteriorGlassConstruction ||
                    (this.InteriorGlassConstruction != null &&
                    this.InteriorGlassConstruction.Equals(input.InteriorGlassConstruction))
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
                if (this.OverheadConstruction != null)
                    hashCode = hashCode * 59 + this.OverheadConstruction.GetHashCode();
                if (this.ExteriorGlassConstruction != null)
                    hashCode = hashCode * 59 + this.ExteriorGlassConstruction.GetHashCode();
                if (this.InteriorGlassConstruction != null)
                    hashCode = hashCode * 59 + this.InteriorGlassConstruction.GetHashCode();
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
            Regex regexType = new Regex(@"^DoorConstructionSet$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }

}
