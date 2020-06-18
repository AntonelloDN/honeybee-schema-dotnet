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
    /// Text for the day of the week on which the simulation starts.
    /// </summary>
    /// <value>Text for the day of the week on which the simulation starts.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum DaysOfWeek
    {
        /// <summary>
        /// Enum Sunday for value: Sunday
        /// </summary>
        [EnumMember(Value = "Sunday")]
        Sunday = 1,

        /// <summary>
        /// Enum Monday for value: Monday
        /// </summary>
        [EnumMember(Value = "Monday")]
        Monday = 2,

        /// <summary>
        /// Enum Tuesday for value: Tuesday
        /// </summary>
        [EnumMember(Value = "Tuesday")]
        Tuesday = 3,

        /// <summary>
        /// Enum Wednesday for value: Wednesday
        /// </summary>
        [EnumMember(Value = "Wednesday")]
        Wednesday = 4,

        /// <summary>
        /// Enum Thursday for value: Thursday
        /// </summary>
        [EnumMember(Value = "Thursday")]
        Thursday = 5,

        /// <summary>
        /// Enum Friday for value: Friday
        /// </summary>
        [EnumMember(Value = "Friday")]
        Friday = 6,

        /// <summary>
        /// Enum Saturday for value: Saturday
        /// </summary>
        [EnumMember(Value = "Saturday")]
        Saturday = 7

    }

}
