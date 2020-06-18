/* 
 * Honeybee Energy Simulation Parameter Schema
 *
 * This is the documentation for Honeybee energy simulation parameter schema.
 *
 * The version of the OpenAPI document: 1.34.1
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
    /// Text describing how often the solar and shading calculations are updated with respect to the flow of time in the simulation.
    /// </summary>
    /// <value>Text describing how often the solar and shading calculations are updated with respect to the flow of time in the simulation.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum CalculationUpdateMethod
    {
        /// <summary>
        /// Enum Periodic for value: Periodic
        /// </summary>
        [EnumMember(Value = "Periodic")]
        Periodic = 1,

        /// <summary>
        /// Enum Timestep for value: Timestep
        /// </summary>
        [EnumMember(Value = "Timestep")]
        Timestep = 2

    }

}
