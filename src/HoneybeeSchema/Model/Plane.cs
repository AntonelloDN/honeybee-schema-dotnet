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
    /// Base class for all objects that are not extensible with additional keys.  This effectively includes all objects except for the Properties classes that are assigned to geometry objects.
    /// </summary>
    [DataContract(Name = "Plane")]
    public partial class Plane : OpenAPIGenBaseModel, IEquatable<Plane>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Plane" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Plane() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "Plane";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="Plane" /> class.
        /// </summary>
        /// <param name="n">Plane normal as 3 (x, y, z) values. (required).</param>
        /// <param name="o">Plane origin as 3 (x, y, z) values (required).</param>
        /// <param name="x">Plane x-axis as 3 (x, y, z) values. If None, it is autocalculated..</param>
        public Plane
        (
           List<double> n, List<double> o, // Required parameters
           List<double> x= default// Optional parameters
        ) : base()// BaseClass
        {
            // to ensure "n" is required (not null)
            this.N = n ?? throw new ArgumentNullException("n is a required property for Plane and cannot be null");
            // to ensure "o" is required (not null)
            this.O = o ?? throw new ArgumentNullException("o is a required property for Plane and cannot be null");
            this.X = x;

            // Set non-required readonly properties with defaultValue
            this.Type = "Plane";
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type")]
        public override string Type { get; protected set; }  = "Plane";

        /// <summary>
        /// Plane normal as 3 (x, y, z) values.
        /// </summary>
        /// <value>Plane normal as 3 (x, y, z) values.</value>
        [DataMember(Name = "n", IsRequired = true)]
        public List<double> N { get; set; } 
        /// <summary>
        /// Plane origin as 3 (x, y, z) values
        /// </summary>
        /// <value>Plane origin as 3 (x, y, z) values</value>
        [DataMember(Name = "o", IsRequired = true)]
        public List<double> O { get; set; } 
        /// <summary>
        /// Plane x-axis as 3 (x, y, z) values. If None, it is autocalculated.
        /// </summary>
        /// <value>Plane x-axis as 3 (x, y, z) values. If None, it is autocalculated.</value>
        [DataMember(Name = "x")]
        public List<double> X { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "Plane";
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
            sb.Append("Plane:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  N: ").Append(N).Append("\n");
            sb.Append("  O: ").Append(O).Append("\n");
            sb.Append("  X: ").Append(X).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>Plane object</returns>
        public static Plane FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<Plane>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>Plane object</returns>
        public virtual Plane DuplicatePlane()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicatePlane();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicatePlane();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as Plane);
        }

        /// <summary>
        /// Returns true if Plane instances are equal
        /// </summary>
        /// <param name="input">Instance of Plane to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Plane input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                (
                    this.N == input.N ||
                    this.N != null &&
                    input.N != null &&
                    this.N.SequenceEqual(input.N)
                ) && base.Equals(input) && 
                (
                    this.O == input.O ||
                    this.O != null &&
                    input.O != null &&
                    this.O.SequenceEqual(input.O)
                ) && base.Equals(input) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && base.Equals(input) && 
                (
                    this.X == input.X ||
                    this.X != null &&
                    input.X != null &&
                    this.X.SequenceEqual(input.X)
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
                if (this.N != null)
                    hashCode = hashCode * 59 + this.N.GetHashCode();
                if (this.O != null)
                    hashCode = hashCode * 59 + this.O.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.X != null)
                    hashCode = hashCode * 59 + this.X.GetHashCode();
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
            Regex regexType = new Regex(@"^Plane$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
