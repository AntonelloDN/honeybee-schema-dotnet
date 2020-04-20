/* 
 * Honeybee Model Schema
 *
 * This is the documentation for Honeybee model schema.
 *
 * The version of the OpenAPI document: 1.25.1
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
    /// Base class for all objects that are not extensible with additional keys.  This effectively includes all objects except for the Properties classes that are assigned to geometry objects.
    /// </summary>
    [DataContract]
    public partial class Outdoors : HoneybeeObject, IEquatable<Outdoors>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="Outdoors" /> class.
        /// </summary>
        /// <param name="sunExposure">A boolean noting whether the boundary is exposed to sun. (default to true).</param>
        /// <param name="windExposure">A boolean noting whether the boundary is exposed to wind. (default to true).</param>
        /// <param name="viewFactor">A number for the view factor to the ground. This can also be an Autocalculate object to have the view factor automatically calculated..</param>
        public Outdoors
        (
            // Required parameters
            bool sunExposure = true, bool windExposure = true, AnyOf<Autocalculate,double> viewFactor= default// Optional parameters
        )// BaseClass
        {
            // use default value if no "sunExposure" provided
            if (sunExposure == null)
            {
                this.SunExposure = true;
            }
            else
            {
                this.SunExposure = sunExposure;
            }
            // use default value if no "windExposure" provided
            if (windExposure == null)
            {
                this.WindExposure = true;
            }
            else
            {
                this.WindExposure = windExposure;
            }
            this.ViewFactor = viewFactor;

            // Set non-required readonly properties with defaultValue
            this.Type = "Outdoors";
        }
        
        /// <summary>
        /// A boolean noting whether the boundary is exposed to sun.
        /// </summary>
        /// <value>A boolean noting whether the boundary is exposed to sun.</value>
        [DataMember(Name="sun_exposure", EmitDefaultValue=false)]
        [JsonProperty("sun_exposure")]
        public bool SunExposure { get; set; }
        /// <summary>
        /// A boolean noting whether the boundary is exposed to wind.
        /// </summary>
        /// <value>A boolean noting whether the boundary is exposed to wind.</value>
        [DataMember(Name="wind_exposure", EmitDefaultValue=false)]
        [JsonProperty("wind_exposure")]
        public bool WindExposure { get; set; }
        /// <summary>
        /// A number for the view factor to the ground. This can also be an Autocalculate object to have the view factor automatically calculated.
        /// </summary>
        /// <value>A number for the view factor to the ground. This can also be an Autocalculate object to have the view factor automatically calculated.</value>
        [DataMember(Name="view_factor", EmitDefaultValue=false)]
        [JsonProperty("view_factor")]
        public AnyOf<Autocalculate,double> ViewFactor { get; set; }
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            if (this is IIDdBase iDd)
                return $"Outdoors {iDd.Identifier}";
       
            return "Outdoors";
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public string ToString(bool detailed)
        {
            if (detailed)
                return this.ToString();
            
            var sb = new StringBuilder();
            sb.Append("Outdoors:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  SunExposure: ").Append(SunExposure).Append("\n");
            sb.Append("  WindExposure: ").Append(WindExposure).Append("\n");
            sb.Append("  ViewFactor: ").Append(ViewFactor).Append("\n");
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
        /// <returns>Outdoors object</returns>
        public static Outdoors FromJson(string json)
        {
            return JsonConvert.DeserializeObject<Outdoors>(json, new AnyOfJsonConverter());
        }
     

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Outdoors);
        }

        /// <summary>
        /// Returns true if Outdoors instances are equal
        /// </summary>
        /// <param name="input">Instance of Outdoors to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Outdoors input)
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
                    this.SunExposure == input.SunExposure ||
                    (this.SunExposure != null &&
                    this.SunExposure.Equals(input.SunExposure))
                ) && 
                (
                    this.WindExposure == input.WindExposure ||
                    (this.WindExposure != null &&
                    this.WindExposure.Equals(input.WindExposure))
                ) && 
                (
                    this.ViewFactor == input.ViewFactor ||
                    (this.ViewFactor != null &&
                    this.ViewFactor.Equals(input.ViewFactor))
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
                if (this.SunExposure != null)
                    hashCode = hashCode * 59 + this.SunExposure.GetHashCode();
                if (this.WindExposure != null)
                    hashCode = hashCode * 59 + this.WindExposure.GetHashCode();
                if (this.ViewFactor != null)
                    hashCode = hashCode * 59 + this.ViewFactor.GetHashCode();
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
            Regex regexType = new Regex(@"^Outdoors$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }

}
