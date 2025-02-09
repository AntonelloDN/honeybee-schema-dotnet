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
    /// A single Radiance of sensors.
    /// </summary>
    [DataContract(Name = "Sensor")]
    public partial class Sensor : OpenAPIGenBaseModel, IEquatable<Sensor>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Sensor" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Sensor() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "Sensor";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="Sensor" /> class.
        /// </summary>
        /// <param name="pos">Position of sensor in space as an array of (x, y, z) values. (required).</param>
        /// <param name="dir">Direction of sensor as an array of (x, y, z) values. (required).</param>
        public Sensor
        (
           List<double> pos, List<double> dir// Required parameters
           // Optional parameters
        ) : base()// BaseClass
        {
            // to ensure "pos" is required (not null)
            this.Pos = pos ?? throw new ArgumentNullException("pos is a required property for Sensor and cannot be null");
            // to ensure "dir" is required (not null)
            this.Dir = dir ?? throw new ArgumentNullException("dir is a required property for Sensor and cannot be null");

            // Set non-required readonly properties with defaultValue
            this.Type = "Sensor";
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type")]
        public override string Type { get; protected set; }  = "Sensor";

        /// <summary>
        /// Position of sensor in space as an array of (x, y, z) values.
        /// </summary>
        /// <value>Position of sensor in space as an array of (x, y, z) values.</value>
        [DataMember(Name = "pos", IsRequired = true)]
        public List<double> Pos { get; set; } 
        /// <summary>
        /// Direction of sensor as an array of (x, y, z) values.
        /// </summary>
        /// <value>Direction of sensor as an array of (x, y, z) values.</value>
        [DataMember(Name = "dir", IsRequired = true)]
        public List<double> Dir { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "Sensor";
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
            sb.Append("Sensor:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Pos: ").Append(Pos).Append("\n");
            sb.Append("  Dir: ").Append(Dir).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>Sensor object</returns>
        public static Sensor FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<Sensor>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>Sensor object</returns>
        public virtual Sensor DuplicateSensor()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateSensor();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicateSensor();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as Sensor);
        }

        /// <summary>
        /// Returns true if Sensor instances are equal
        /// </summary>
        /// <param name="input">Instance of Sensor to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Sensor input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                (
                    this.Pos == input.Pos ||
                    this.Pos != null &&
                    input.Pos != null &&
                    this.Pos.SequenceEqual(input.Pos)
                ) && base.Equals(input) && 
                (
                    this.Dir == input.Dir ||
                    this.Dir != null &&
                    input.Dir != null &&
                    this.Dir.SequenceEqual(input.Dir)
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
                if (this.Pos != null)
                    hashCode = hashCode * 59 + this.Pos.GetHashCode();
                if (this.Dir != null)
                    hashCode = hashCode * 59 + this.Dir.GetHashCode();
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
            foreach(var x in base.BaseValidate(validationContext)) yield return x;

            
            // Type (string) pattern
            Regex regexType = new Regex(@"^Sensor$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
