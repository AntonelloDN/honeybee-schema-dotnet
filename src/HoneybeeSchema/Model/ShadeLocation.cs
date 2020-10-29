/* 
 * Honeybee Model Schema
 *
 * This is the documentation for Honeybee model schema.
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
    /// Choices for where a shade material is located in a window assembly.
    /// </summary>
    /// <value>Choices for where a shade material is located in a window assembly.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ShadeLocation
    {
        /// <summary>
        /// Enum Interior for value: Interior
        /// </summary>
        [EnumMember(Value = "Interior")]
        Interior = 1,

        /// <summary>
        /// Enum Between for value: Between
        /// </summary>
        [EnumMember(Value = "Between")]
        Between = 2,

        /// <summary>
        /// Enum Exterior for value: Exterior
        /// </summary>
        [EnumMember(Value = "Exterior")]
        Exterior = 3

    }

}
