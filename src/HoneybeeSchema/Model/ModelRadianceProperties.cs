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
    /// Radiance Properties for Honeybee Model.
    /// </summary>
    [DataContract(Name = "ModelRadianceProperties")]
    public partial class ModelRadianceProperties : OpenAPIGenBaseModel, IEquatable<ModelRadianceProperties>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelRadianceProperties" /> class.
        /// </summary>
        /// <param name="modifiers">A list of all unique modifiers in the model. This includes modifiers across all Faces, Apertures, Doors, Shades, Room ModifierSets, and the global_modifier_set..</param>
        /// <param name="modifierSets">A list of all unique Room-Assigned ModifierSets in the Model..</param>
        /// <param name="sensorGrids">An array of SensorGrids that are associated with the model..</param>
        /// <param name="views">An array of Views that are associated with the model..</param>
        public ModelRadianceProperties
        (
           // Required parameters
           List<AnyOf<Plastic,Glass,BSDF,Glow,Light,Trans,Metal,Void,Mirror>> modifiers= default, List<AnyOf<ModifierSet,ModifierSetAbridged>> modifierSets= default, List<SensorGrid> sensorGrids= default, List<View> views= default// Optional parameters
        ) : base()// BaseClass
        {
            this.Modifiers = modifiers;
            this.ModifierSets = modifierSets;
            this.SensorGrids = sensorGrids;
            this.Views = views;

            // Set non-required readonly properties with defaultValue
            this.Type = "ModelRadianceProperties";
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type")]
        public override string Type { get; protected set; }  = "ModelRadianceProperties";

        /// <summary>
        /// A list of all unique modifiers in the model. This includes modifiers across all Faces, Apertures, Doors, Shades, Room ModifierSets, and the global_modifier_set.
        /// </summary>
        /// <value>A list of all unique modifiers in the model. This includes modifiers across all Faces, Apertures, Doors, Shades, Room ModifierSets, and the global_modifier_set.</value>
        [DataMember(Name = "modifiers")]
        public List<AnyOf<Plastic,Glass,BSDF,Glow,Light,Trans,Metal,Void,Mirror>> Modifiers { get; set; } 
        /// <summary>
        /// A list of all unique Room-Assigned ModifierSets in the Model.
        /// </summary>
        /// <value>A list of all unique Room-Assigned ModifierSets in the Model.</value>
        [DataMember(Name = "modifier_sets")]
        public List<AnyOf<ModifierSet,ModifierSetAbridged>> ModifierSets { get; set; } 
        /// <summary>
        /// An array of SensorGrids that are associated with the model.
        /// </summary>
        /// <value>An array of SensorGrids that are associated with the model.</value>
        [DataMember(Name = "sensor_grids")]
        public List<SensorGrid> SensorGrids { get; set; } 
        /// <summary>
        /// An array of Views that are associated with the model.
        /// </summary>
        /// <value>An array of Views that are associated with the model.</value>
        [DataMember(Name = "views")]
        public List<View> Views { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "ModelRadianceProperties";
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
            sb.Append("ModelRadianceProperties:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Modifiers: ").Append(Modifiers).Append("\n");
            sb.Append("  ModifierSets: ").Append(ModifierSets).Append("\n");
            sb.Append("  SensorGrids: ").Append(SensorGrids).Append("\n");
            sb.Append("  Views: ").Append(Views).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>ModelRadianceProperties object</returns>
        public static ModelRadianceProperties FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<ModelRadianceProperties>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>ModelRadianceProperties object</returns>
        public virtual ModelRadianceProperties DuplicateModelRadianceProperties()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateModelRadianceProperties();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicateModelRadianceProperties();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as ModelRadianceProperties);
        }

        /// <summary>
        /// Returns true if ModelRadianceProperties instances are equal
        /// </summary>
        /// <param name="input">Instance of ModelRadianceProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModelRadianceProperties input)
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
                    this.Modifiers == input.Modifiers ||
                    this.Modifiers != null &&
                    input.Modifiers != null &&
                    this.Modifiers.SequenceEqual(input.Modifiers)
                ) && base.Equals(input) && 
                (
                    this.ModifierSets == input.ModifierSets ||
                    this.ModifierSets != null &&
                    input.ModifierSets != null &&
                    this.ModifierSets.SequenceEqual(input.ModifierSets)
                ) && base.Equals(input) && 
                (
                    this.SensorGrids == input.SensorGrids ||
                    this.SensorGrids != null &&
                    input.SensorGrids != null &&
                    this.SensorGrids.SequenceEqual(input.SensorGrids)
                ) && base.Equals(input) && 
                (
                    this.Views == input.Views ||
                    this.Views != null &&
                    input.Views != null &&
                    this.Views.SequenceEqual(input.Views)
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
                if (this.Modifiers != null)
                    hashCode = hashCode * 59 + this.Modifiers.GetHashCode();
                if (this.ModifierSets != null)
                    hashCode = hashCode * 59 + this.ModifierSets.GetHashCode();
                if (this.SensorGrids != null)
                    hashCode = hashCode * 59 + this.SensorGrids.GetHashCode();
                if (this.Views != null)
                    hashCode = hashCode * 59 + this.Views.GetHashCode();
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
            Regex regexType = new Regex(@"^ModelRadianceProperties$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
