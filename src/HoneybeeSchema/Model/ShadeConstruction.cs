/* 
 * Honeybee Model Schema
 *
 * This is the documentation for Honeybee model schema.
 *
 * The version of the OpenAPI document: 1.21.4
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
    /// Construction for Shade objects.
    /// </summary>
    [DataContract]
    public partial class ShadeConstruction :  IEquatable<ShadeConstruction>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShadeConstruction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ShadeConstruction() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ShadeConstruction" /> class.
        /// </summary>
        /// <param name="identifier">Text string for a unique object ID. This identifier remains constant as the object is mutated, copied, and serialized to different formats (eg. dict, idf, osm). This identifier is also used to reference the object across a Model. It must be &lt; 100 characters, use only ASCII characters and exclude (, ; ! \\n \\t). (required).</param>
        /// <param name="displayName">Display name of the object with no character restrictions..</param>
        /// <param name="type">type (default to &quot;ShadeConstruction&quot;).</param>
        /// <param name="solarReflectance"> A number for the solar reflectance of the construction. (default to 0.2).</param>
        /// <param name="visibleReflectance"> A number for the visible reflectance of the construction. (default to 0.2).</param>
        /// <param name="isSpecular">Boolean to note whether the reflection off the shade is diffuse (False) or specular (True). Set to True if the construction is representing a glass facade or a mirror material. (default to false).</param>
        public ShadeConstruction(string identifier, string displayName = default, string type = "ShadeConstruction", double solarReflectance = 0.2, double visibleReflectance = 0.2, bool isSpecular = false)
        {
            // to ensure "identifier" is required (not null)
            if (identifier == null)
            {
                throw new InvalidDataException("identifier is a required property for ShadeConstruction and cannot be null");
            }
            else
            {
                this.Identifier = identifier;
            }
            
            this.DisplayName = displayName;
            // use default value if no "type" provided
            if (type == null)
            {
                this.Type = "ShadeConstruction";
            }
            else
            {
                this.Type = type;
            }
            // use default value if no "solarReflectance" provided
            if (solarReflectance == null)
            {
                this.SolarReflectance = 0.2;
            }
            else
            {
                this.SolarReflectance = solarReflectance;
            }
            // use default value if no "visibleReflectance" provided
            if (visibleReflectance == null)
            {
                this.VisibleReflectance = 0.2;
            }
            else
            {
                this.VisibleReflectance = visibleReflectance;
            }
            // use default value if no "isSpecular" provided
            if (isSpecular == null)
            {
                this.IsSpecular = false;
            }
            else
            {
                this.IsSpecular = isSpecular;
            }
        }
        
        /// <summary>
        /// Text string for a unique object ID. This identifier remains constant as the object is mutated, copied, and serialized to different formats (eg. dict, idf, osm). This identifier is also used to reference the object across a Model. It must be &lt; 100 characters, use only ASCII characters and exclude (, ; ! \\n \\t).
        /// </summary>
        /// <value>Text string for a unique object ID. This identifier remains constant as the object is mutated, copied, and serialized to different formats (eg. dict, idf, osm). This identifier is also used to reference the object across a Model. It must be &lt; 100 characters, use only ASCII characters and exclude (, ; ! \\n \\t).</value>
        [DataMember(Name="identifier", EmitDefaultValue=false)]
        [JsonProperty("identifier")]
        public string Identifier { get; set; }

        /// <summary>
        /// Display name of the object with no character restrictions.
        /// </summary>
        /// <value>Display name of the object with no character restrictions.</value>
        [DataMember(Name="display_name", EmitDefaultValue=false)]
        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        ///  A number for the solar reflectance of the construction.
        /// </summary>
        /// <value> A number for the solar reflectance of the construction.</value>
        [DataMember(Name="solar_reflectance", EmitDefaultValue=false)]
        [JsonProperty("solar_reflectance")]
        public double SolarReflectance { get; set; }

        /// <summary>
        ///  A number for the visible reflectance of the construction.
        /// </summary>
        /// <value> A number for the visible reflectance of the construction.</value>
        [DataMember(Name="visible_reflectance", EmitDefaultValue=false)]
        [JsonProperty("visible_reflectance")]
        public double VisibleReflectance { get; set; }

        /// <summary>
        /// Boolean to note whether the reflection off the shade is diffuse (False) or specular (True). Set to True if the construction is representing a glass facade or a mirror material.
        /// </summary>
        /// <value>Boolean to note whether the reflection off the shade is diffuse (False) or specular (True). Set to True if the construction is representing a glass facade or a mirror material.</value>
        [DataMember(Name="is_specular", EmitDefaultValue=false)]
        [JsonProperty("is_specular")]
        public bool IsSpecular { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShadeConstruction {\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  SolarReflectance: ").Append(SolarReflectance).Append("\n");
            sb.Append("  VisibleReflectance: ").Append(VisibleReflectance).Append("\n");
            sb.Append("  IsSpecular: ").Append(IsSpecular).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented, new AnyOfJsonConverter());
        }

        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>ShadeConstruction object</returns>
        public static ShadeConstruction FromJson(string json)
        {
            return JsonConvert.DeserializeObject<ShadeConstruction>(json, new AnyOfJsonConverter());
        }


        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShadeConstruction);
        }

        /// <summary>
        /// Returns true if ShadeConstruction instances are equal
        /// </summary>
        /// <param name="input">Instance of ShadeConstruction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShadeConstruction input)
        {
            if (input == null)
                return false;

            return 
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
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.SolarReflectance == input.SolarReflectance ||
                    (this.SolarReflectance != null &&
                    this.SolarReflectance.Equals(input.SolarReflectance))
                ) && 
                (
                    this.VisibleReflectance == input.VisibleReflectance ||
                    (this.VisibleReflectance != null &&
                    this.VisibleReflectance.Equals(input.VisibleReflectance))
                ) && 
                (
                    this.IsSpecular == input.IsSpecular ||
                    (this.IsSpecular != null &&
                    this.IsSpecular.Equals(input.IsSpecular))
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
                if (this.Identifier != null)
                    hashCode = hashCode * 59 + this.Identifier.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.SolarReflectance != null)
                    hashCode = hashCode * 59 + this.SolarReflectance.GetHashCode();
                if (this.VisibleReflectance != null)
                    hashCode = hashCode * 59 + this.VisibleReflectance.GetHashCode();
                if (this.IsSpecular != null)
                    hashCode = hashCode * 59 + this.IsSpecular.GetHashCode();
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

            // Type (string) pattern
            Regex regexType = new Regex(@"^ShadeConstruction$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            // SolarReflectance (double) maximum
            if(this.SolarReflectance > (double)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SolarReflectance, must be a value less than or equal to 1.", new [] { "SolarReflectance" });
            }

            // SolarReflectance (double) minimum
            if(this.SolarReflectance < (double)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SolarReflectance, must be a value greater than or equal to 0.", new [] { "SolarReflectance" });
            }

            // VisibleReflectance (double) maximum
            if(this.VisibleReflectance > (double)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for VisibleReflectance, must be a value less than or equal to 1.", new [] { "VisibleReflectance" });
            }

            // VisibleReflectance (double) minimum
            if(this.VisibleReflectance < (double)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for VisibleReflectance, must be a value greater than or equal to 0.", new [] { "VisibleReflectance" });
            }

            yield break;
        }
    }

}
