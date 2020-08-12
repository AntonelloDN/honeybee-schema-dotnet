/* 
 * Honeybee Energy Simulation Parameter Schema
 *
 * This is the documentation for Honeybee energy simulation parameter schema.
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
    /// Used to specify which types of calculations to run.
    /// </summary>
    [DataContract]
    public partial class SimulationControl : HoneybeeObject, IEquatable<SimulationControl>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationControl" /> class.
        /// </summary>
        /// <param name="doZoneSizing">Boolean for whether the zone sizing calculation should be run. (default to true).</param>
        /// <param name="doSystemSizing">Boolean for whether the system sizing calculation should be run. (default to true).</param>
        /// <param name="doPlantSizing">Boolean for whether the plant sizing calculation should be run. (default to true).</param>
        /// <param name="runForRunPeriods">Boolean for whether the simulation should be run for the sizing periods. (default to true).</param>
        /// <param name="runForSizingPeriods">Boolean for whether the simulation should be run for the run periods. (default to false).</param>
        public SimulationControl
        (
             // Required parameters
            bool doZoneSizing = true, bool doSystemSizing = true, bool doPlantSizing = true, bool runForRunPeriods = true, bool runForSizingPeriods = false// Optional parameters
        )// BaseClass
        {
            // use default value if no "doZoneSizing" provided
            if (doZoneSizing == null)
            {
                this.DoZoneSizing = true;
            }
            else
            {
                this.DoZoneSizing = doZoneSizing;
            }
            // use default value if no "doSystemSizing" provided
            if (doSystemSizing == null)
            {
                this.DoSystemSizing = true;
            }
            else
            {
                this.DoSystemSizing = doSystemSizing;
            }
            // use default value if no "doPlantSizing" provided
            if (doPlantSizing == null)
            {
                this.DoPlantSizing = true;
            }
            else
            {
                this.DoPlantSizing = doPlantSizing;
            }
            // use default value if no "runForRunPeriods" provided
            if (runForRunPeriods == null)
            {
                this.RunForRunPeriods = true;
            }
            else
            {
                this.RunForRunPeriods = runForRunPeriods;
            }
            // use default value if no "runForSizingPeriods" provided
            if (runForSizingPeriods == null)
            {
                this.RunForSizingPeriods = false;
            }
            else
            {
                this.RunForSizingPeriods = runForSizingPeriods;
            }

            // Set non-required readonly properties with defaultValue
            this.Type = "SimulationControl";
        }
        
        /// <summary>
        /// Boolean for whether the zone sizing calculation should be run.
        /// </summary>
        /// <value>Boolean for whether the zone sizing calculation should be run.</value>
        [DataMember(Name="do_zone_sizing", EmitDefaultValue=false)]
        [JsonProperty("do_zone_sizing")]
        public bool DoZoneSizing { get; set; }  = true;
        /// <summary>
        /// Boolean for whether the system sizing calculation should be run.
        /// </summary>
        /// <value>Boolean for whether the system sizing calculation should be run.</value>
        [DataMember(Name="do_system_sizing", EmitDefaultValue=false)]
        [JsonProperty("do_system_sizing")]
        public bool DoSystemSizing { get; set; }  = true;
        /// <summary>
        /// Boolean for whether the plant sizing calculation should be run.
        /// </summary>
        /// <value>Boolean for whether the plant sizing calculation should be run.</value>
        [DataMember(Name="do_plant_sizing", EmitDefaultValue=false)]
        [JsonProperty("do_plant_sizing")]
        public bool DoPlantSizing { get; set; }  = true;
        /// <summary>
        /// Boolean for whether the simulation should be run for the sizing periods.
        /// </summary>
        /// <value>Boolean for whether the simulation should be run for the sizing periods.</value>
        [DataMember(Name="run_for_run_periods", EmitDefaultValue=false)]
        [JsonProperty("run_for_run_periods")]
        public bool RunForRunPeriods { get; set; }  = true;
        /// <summary>
        /// Boolean for whether the simulation should be run for the run periods.
        /// </summary>
        /// <value>Boolean for whether the simulation should be run for the run periods.</value>
        [DataMember(Name="run_for_sizing_periods", EmitDefaultValue=false)]
        [JsonProperty("run_for_sizing_periods")]
        public bool RunForSizingPeriods { get; set; }  = false;
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            if (this is IIDdBase iDd)
                return $"SimulationControl {iDd.Identifier}";
       
            return "SimulationControl";
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
            sb.Append("SimulationControl:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  DoZoneSizing: ").Append(DoZoneSizing).Append("\n");
            sb.Append("  DoSystemSizing: ").Append(DoSystemSizing).Append("\n");
            sb.Append("  DoPlantSizing: ").Append(DoPlantSizing).Append("\n");
            sb.Append("  RunForRunPeriods: ").Append(RunForRunPeriods).Append("\n");
            sb.Append("  RunForSizingPeriods: ").Append(RunForSizingPeriods).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>SimulationControl object</returns>
        public static SimulationControl FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<SimulationControl>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>SimulationControl object</returns>
        public SimulationControl DuplicateSimulationControl()
        {
            return Duplicate() as SimulationControl;
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
            return this.Equals(input as SimulationControl);
        }

        /// <summary>
        /// Returns true if SimulationControl instances are equal
        /// </summary>
        /// <param name="input">Instance of SimulationControl to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SimulationControl input)
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
                    this.DoZoneSizing == input.DoZoneSizing ||
                    (this.DoZoneSizing != null &&
                    this.DoZoneSizing.Equals(input.DoZoneSizing))
                ) && 
                (
                    this.DoSystemSizing == input.DoSystemSizing ||
                    (this.DoSystemSizing != null &&
                    this.DoSystemSizing.Equals(input.DoSystemSizing))
                ) && 
                (
                    this.DoPlantSizing == input.DoPlantSizing ||
                    (this.DoPlantSizing != null &&
                    this.DoPlantSizing.Equals(input.DoPlantSizing))
                ) && 
                (
                    this.RunForRunPeriods == input.RunForRunPeriods ||
                    (this.RunForRunPeriods != null &&
                    this.RunForRunPeriods.Equals(input.RunForRunPeriods))
                ) && 
                (
                    this.RunForSizingPeriods == input.RunForSizingPeriods ||
                    (this.RunForSizingPeriods != null &&
                    this.RunForSizingPeriods.Equals(input.RunForSizingPeriods))
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
                if (this.DoZoneSizing != null)
                    hashCode = hashCode * 59 + this.DoZoneSizing.GetHashCode();
                if (this.DoSystemSizing != null)
                    hashCode = hashCode * 59 + this.DoSystemSizing.GetHashCode();
                if (this.DoPlantSizing != null)
                    hashCode = hashCode * 59 + this.DoPlantSizing.GetHashCode();
                if (this.RunForRunPeriods != null)
                    hashCode = hashCode * 59 + this.RunForRunPeriods.GetHashCode();
                if (this.RunForSizingPeriods != null)
                    hashCode = hashCode * 59 + this.RunForSizingPeriods.GetHashCode();
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
            Regex regexType = new Regex(@"^SimulationControl$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }

}
