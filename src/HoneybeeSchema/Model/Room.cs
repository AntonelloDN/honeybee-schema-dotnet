/* 
 * Honeybee Model Schema
 *
 * This is the documentation for Honeybee model schema.
 *
 * The version of the OpenAPI document: 1.25.0
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
    /// Base class for all objects requiring a identifiers acceptable for all engines.
    /// </summary>
    [DataContract]
    public partial class Room : IDdBaseModel,  IEquatable<Room>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="Room" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Room() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Room" /> class.
        /// </summary>
        /// <param name="faces">Faces that together form the closed volume of a room..</param>
        /// <param name="properties">Extension properties for particular simulation engines (Radiance, EnergyPlus)..</param>
        /// <param name="indoorShades">Shades assigned to the interior side of this object (eg. partitions, tables)..</param>
        /// <param name="outdoorShades">Shades assigned to the exterior side of this object (eg. trees, landscaping)..</param>
        /// <param name="multiplier">An integer noting how many times this Room is repeated. Multipliers are used to speed up the calculation when similar Rooms are repeated more than once. Essentially, a given simulation with the Room is run once and then the result is mutliplied by the multiplier. (default to 1).</param>
        /// <param name="identifier">Text string for a unique object ID. This identifier remains constant as the object is mutated, copied, and serialized to different formats (eg. dict, idf, rad). This identifier is also used to reference the object across a Model. It must be &lt; 100 characters and not contain any spaces or special characters. (required).</param>
        /// <param name="displayName">Display name of the object with no character restrictions..</param>
        /// <param name="userData">Optional dictionary of user data associated with the object.All keys and values of this dictionary should be of a standard data type to ensure correct serialization of the object (eg. str, float, int, list)..</param>
        public Room
        (
            string identifier, // Required parameters
            List<Face> faces= default, RoomPropertiesAbridged properties= default, List<Shade> indoorShades= default, List<Shade> outdoorShades= default, int multiplier = 1, string displayName= default, Object userData= default// Optional parameters
        ) : base(identifier: identifier, displayName: displayName, userData: userData )// BaseClass
        {
            this.Faces = faces;
            this.Properties = properties;
            this.IndoorShades = indoorShades;
            this.OutdoorShades = outdoorShades;
            // use default value if no "multiplier" provided
            if (multiplier == null)
            {
                this.Multiplier = 1;
            }
            else
            {
                this.Multiplier = multiplier;
            }
        }
        
        /// <summary>
        /// Faces that together form the closed volume of a room.
        /// </summary>
        /// <value>Faces that together form the closed volume of a room.</value>
        [DataMember(Name="faces", EmitDefaultValue=false)]
        [JsonProperty("faces")]
        public List<Face> Faces { get; set; }

        /// <summary>
        /// Extension properties for particular simulation engines (Radiance, EnergyPlus).
        /// </summary>
        /// <value>Extension properties for particular simulation engines (Radiance, EnergyPlus).</value>
        [DataMember(Name="properties", EmitDefaultValue=false)]
        [JsonProperty("properties")]
        public RoomPropertiesAbridged Properties { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        [JsonProperty("type")]
        public string Type { get; private set; } = "Room"; 

        /// <summary>
        /// Shades assigned to the interior side of this object (eg. partitions, tables).
        /// </summary>
        /// <value>Shades assigned to the interior side of this object (eg. partitions, tables).</value>
        [DataMember(Name="indoor_shades", EmitDefaultValue=false)]
        [JsonProperty("indoor_shades")]
        public List<Shade> IndoorShades { get; set; }

        /// <summary>
        /// Shades assigned to the exterior side of this object (eg. trees, landscaping).
        /// </summary>
        /// <value>Shades assigned to the exterior side of this object (eg. trees, landscaping).</value>
        [DataMember(Name="outdoor_shades", EmitDefaultValue=false)]
        [JsonProperty("outdoor_shades")]
        public List<Shade> OutdoorShades { get; set; }

        /// <summary>
        /// An integer noting how many times this Room is repeated. Multipliers are used to speed up the calculation when similar Rooms are repeated more than once. Essentially, a given simulation with the Room is run once and then the result is mutliplied by the multiplier.
        /// </summary>
        /// <value>An integer noting how many times this Room is repeated. Multipliers are used to speed up the calculation when similar Rooms are repeated more than once. Essentially, a given simulation with the Room is run once and then the result is mutliplied by the multiplier.</value>
        [DataMember(Name="multiplier", EmitDefaultValue=false)]
        [JsonProperty("multiplier")]
        public int Multiplier { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Room {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Faces: ").Append(Faces).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  IndoorShades: ").Append(IndoorShades).Append("\n");
            sb.Append("  OutdoorShades: ").Append(OutdoorShades).Append("\n");
            sb.Append("  Multiplier: ").Append(Multiplier).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented, new AnyOfJsonConverter());
        }

        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>Room object</returns>
        public static Room FromJson(string json)
        {
            return JsonConvert.DeserializeObject<Room>(json, new AnyOfJsonConverter());
        }


        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Room);
        }

        /// <summary>
        /// Returns true if Room instances are equal
        /// </summary>
        /// <param name="input">Instance of Room to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Room input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Faces == input.Faces ||
                    this.Faces != null &&
                    input.Faces != null &&
                    this.Faces.SequenceEqual(input.Faces)
                ) && base.Equals(input) && 
                (
                    this.Properties == input.Properties ||
                    (this.Properties != null &&
                    this.Properties.Equals(input.Properties))
                ) && base.Equals(input) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && base.Equals(input) && 
                (
                    this.IndoorShades == input.IndoorShades ||
                    this.IndoorShades != null &&
                    input.IndoorShades != null &&
                    this.IndoorShades.SequenceEqual(input.IndoorShades)
                ) && base.Equals(input) && 
                (
                    this.OutdoorShades == input.OutdoorShades ||
                    this.OutdoorShades != null &&
                    input.OutdoorShades != null &&
                    this.OutdoorShades.SequenceEqual(input.OutdoorShades)
                ) && base.Equals(input) && 
                (
                    this.Multiplier == input.Multiplier ||
                    (this.Multiplier != null &&
                    this.Multiplier.Equals(input.Multiplier))
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
                if (this.Faces != null)
                    hashCode = hashCode * 59 + this.Faces.GetHashCode();
                if (this.Properties != null)
                    hashCode = hashCode * 59 + this.Properties.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.IndoorShades != null)
                    hashCode = hashCode * 59 + this.IndoorShades.GetHashCode();
                if (this.OutdoorShades != null)
                    hashCode = hashCode * 59 + this.OutdoorShades.GetHashCode();
                if (this.Multiplier != null)
                    hashCode = hashCode * 59 + this.Multiplier.GetHashCode();
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
            Regex regexType = new Regex(@"^Room$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            // Multiplier (int) minimum
            if(this.Multiplier < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Multiplier, must be a value greater than or equal to 1.", new [] { "Multiplier" });
            }

            yield break;
        }
    }

}
