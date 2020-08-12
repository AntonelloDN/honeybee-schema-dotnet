/* 
 * Honeybee Model Schema
 *
 * This is the documentation for Honeybee model schema.
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
    /// An enumeration.
    /// </summary>
    /// <value>An enumeration.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum WSHPEquipmentType
    {
        /// <summary>
        /// Enum Fluidcoolerwithboiler for value: Water source heat pumps fluid cooler with boiler
        /// </summary>
        [EnumMember(Value = "Water source heat pumps fluid cooler with boiler")]
        Fluidcoolerwithboiler = 1,

        /// <summary>
        /// Enum Coolingtowerwithboiler for value: Water source heat pumps cooling tower with boiler
        /// </summary>
        [EnumMember(Value = "Water source heat pumps cooling tower with boiler")]
        Coolingtowerwithboiler = 2,

        /// <summary>
        /// Enum Withgroundsourceheatpump for value: Water source heat pumps with ground source heat pump
        /// </summary>
        [EnumMember(Value = "Water source heat pumps with ground source heat pump")]
        Withgroundsourceheatpump = 3,

        /// <summary>
        /// Enum Districtchilledwaterwithdistricthotwater for value: Water source heat pumps district chilled water with district hot water
        /// </summary>
        [EnumMember(Value = "Water source heat pumps district chilled water with district hot water")]
        Districtchilledwaterwithdistricthotwater = 4

    }

}
