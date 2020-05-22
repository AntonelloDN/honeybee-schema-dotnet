/* 
 * Honeybee Energy Simulation Parameter Schema
 *
 * This is the documentation for Honeybee energy simulation parameter schema.
 *
 * The version of the OpenAPI document: 1.32.0
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
    /// Text for the terrain in which the model sits. This is used to determine the wind profile over the height of the rooms.
    /// </summary>
    /// <value>Text for the terrain in which the model sits. This is used to determine the wind profile over the height of the rooms.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum TerrianTypes
    {
        /// <summary>
        /// Enum Ocean for value: Ocean
        /// </summary>
        [EnumMember(Value = "Ocean")]
        Ocean = 1,

        /// <summary>
        /// Enum Country for value: Country
        /// </summary>
        [EnumMember(Value = "Country")]
        Country = 2,

        /// <summary>
        /// Enum Suburbs for value: Suburbs
        /// </summary>
        [EnumMember(Value = "Suburbs")]
        Suburbs = 3,

        /// <summary>
        /// Enum Urban for value: Urban
        /// </summary>
        [EnumMember(Value = "Urban")]
        Urban = 4,

        /// <summary>
        /// Enum City for value: City
        /// </summary>
        [EnumMember(Value = "City")]
        City = 5

    }

}
