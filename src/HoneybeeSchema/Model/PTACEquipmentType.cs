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
    /// An enumeration.
    /// </summary>
    /// <value>An enumeration.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum PTACEquipmentType
    {
        /// <summary>
        /// Enum PTACwithbaseboardelectric for value: PTAC with baseboard electric
        /// </summary>
        [EnumMember(Value = "PTAC with baseboard electric")]
        PTACwithbaseboardelectric = 1,

        /// <summary>
        /// Enum PTACwithbaseboardgasboiler for value: PTAC with baseboard gas boiler
        /// </summary>
        [EnumMember(Value = "PTAC with baseboard gas boiler")]
        PTACwithbaseboardgasboiler = 2,

        /// <summary>
        /// Enum PTACwithbaseboarddistricthotwater for value: PTAC with baseboard district hot water
        /// </summary>
        [EnumMember(Value = "PTAC with baseboard district hot water")]
        PTACwithbaseboarddistricthotwater = 3,

        /// <summary>
        /// Enum PTACwithgasunitheaters for value: PTAC with gas unit heaters
        /// </summary>
        [EnumMember(Value = "PTAC with gas unit heaters")]
        PTACwithgasunitheaters = 4,

        /// <summary>
        /// Enum PTACwithelectriccoil for value: PTAC with electric coil
        /// </summary>
        [EnumMember(Value = "PTAC with electric coil")]
        PTACwithelectriccoil = 5,

        /// <summary>
        /// Enum PTACwithgascoil for value: PTAC with gas coil
        /// </summary>
        [EnumMember(Value = "PTAC with gas coil")]
        PTACwithgascoil = 6,

        /// <summary>
        /// Enum PTACwithgasboiler for value: PTAC with gas boiler
        /// </summary>
        [EnumMember(Value = "PTAC with gas boiler")]
        PTACwithgasboiler = 7,

        /// <summary>
        /// Enum PTACwithcentralairsourceheatpump for value: PTAC with central air source heat pump
        /// </summary>
        [EnumMember(Value = "PTAC with central air source heat pump")]
        PTACwithcentralairsourceheatpump = 8,

        /// <summary>
        /// Enum PTACwithdistricthotwater for value: PTAC with district hot water
        /// </summary>
        [EnumMember(Value = "PTAC with district hot water")]
        PTACwithdistricthotwater = 9,

        /// <summary>
        /// Enum PTACwithnoheat for value: PTAC with no heat
        /// </summary>
        [EnumMember(Value = "PTAC with no heat")]
        PTACwithnoheat = 10,

        /// <summary>
        /// Enum PTHP for value: PTHP
        /// </summary>
        [EnumMember(Value = "PTHP")]
        PTHP = 11

    }

}
