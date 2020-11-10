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
    /// Construction for opaque objects (Face, Shade, Door).
    /// </summary>
    [DataContract(Name = "OpaqueConstructionAbridged")]
    public partial class OpaqueConstructionAbridged : IDdEnergyBaseModel, IEquatable<OpaqueConstructionAbridged>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OpaqueConstructionAbridged" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OpaqueConstructionAbridged() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "OpaqueConstructionAbridged";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="OpaqueConstructionAbridged" /> class.
        /// </summary>
        /// <param name="layers">List of strings for opaque material identifiers. The order of the materials is from exterior to interior. (required).</param>
        /// <param name="identifier">Text string for a unique object ID. This identifier remains constant as the object is mutated, copied, and serialized to different formats (eg. dict, idf, osm). This identifier is also used to reference the object across a Model. It must be &lt; 100 characters, use only ASCII characters and exclude (, ; ! \\n \\t). (required).</param>
        /// <param name="displayName">Display name of the object with no character restrictions..</param>
        public OpaqueConstructionAbridged
        (
            string identifier, List<string> layers, // Required parameters
            string displayName= default // Optional parameters
        ) : base(identifier: identifier, displayName: displayName)// BaseClass
        {
            // to ensure "layers" is required (not null)
            this.Layers = layers ?? throw new ArgumentNullException("layers is a required property for OpaqueConstructionAbridged and cannot be null");

            // Set non-required readonly properties with defaultValue
            this.Type = "OpaqueConstructionAbridged";
        }

        /// <summary>
        /// List of strings for opaque material identifiers. The order of the materials is from exterior to interior.
        /// </summary>
        /// <value>List of strings for opaque material identifiers. The order of the materials is from exterior to interior.</value>
        [DataMember(Name = "layers", IsRequired = true, EmitDefaultValue = false)]
        
        public List<string> Layers { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "OpaqueConstructionAbridged";
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
            sb.Append("OpaqueConstructionAbridged:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Layers: ").Append(Layers).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>OpaqueConstructionAbridged object</returns>
        public static OpaqueConstructionAbridged FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<OpaqueConstructionAbridged>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpaqueConstructionAbridged object</returns>
        public virtual OpaqueConstructionAbridged DuplicateOpaqueConstructionAbridged()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateOpaqueConstructionAbridged();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override IDdEnergyBaseModel DuplicateIDdEnergyBaseModel()
        {
            return DuplicateOpaqueConstructionAbridged();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as OpaqueConstructionAbridged);
        }

        /// <summary>
        /// Returns true if OpaqueConstructionAbridged instances are equal
        /// </summary>
        /// <param name="input">Instance of OpaqueConstructionAbridged to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OpaqueConstructionAbridged input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                (
                    this.Layers == input.Layers ||
                    this.Layers != null &&
                    input.Layers != null &&
                    this.Layers.SequenceEqual(input.Layers)
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
                if (this.Layers != null)
                    hashCode = hashCode * 59 + this.Layers.GetHashCode();
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
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            foreach(var x in base.BaseValidate(validationContext)) yield return x;

            
            // Type (string) pattern
            Regex regexType = new Regex(@"^OpaqueConstructionAbridged$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
