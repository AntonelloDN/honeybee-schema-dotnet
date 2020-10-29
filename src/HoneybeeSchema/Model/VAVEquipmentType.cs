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
    
    public enum VAVEquipmentType
    {
        /// <summary>
        /// Enum Chillerwithgasboilerreheat for value: VAV chiller with gas boiler reheat
        /// </summary>
        [EnumMember(Value = "VAV chiller with gas boiler reheat")]
        Chillerwithgasboilerreheat = 1,

        /// <summary>
        /// Enum Chillerwithcentralairsourceheatpumpreheat for value: VAV chiller with central air source heat pump reheat
        /// </summary>
        [EnumMember(Value = "VAV chiller with central air source heat pump reheat")]
        Chillerwithcentralairsourceheatpumpreheat = 2,

        /// <summary>
        /// Enum Chillerwithdistricthotwaterreheat for value: VAV chiller with district hot water reheat
        /// </summary>
        [EnumMember(Value = "VAV chiller with district hot water reheat")]
        Chillerwithdistricthotwaterreheat = 3,

        /// <summary>
        /// Enum ChillerwithPFPboxes for value: VAV chiller with PFP boxes
        /// </summary>
        [EnumMember(Value = "VAV chiller with PFP boxes")]
        ChillerwithPFPboxes = 4,

        /// <summary>
        /// Enum Chillerwithgascoilreheat for value: VAV chiller with gas coil reheat
        /// </summary>
        [EnumMember(Value = "VAV chiller with gas coil reheat")]
        Chillerwithgascoilreheat = 5,

        /// <summary>
        /// Enum AirCooledchillerwithgasboilerreheat for value: VAV air-cooled chiller with gas boiler reheat
        /// </summary>
        [EnumMember(Value = "VAV air-cooled chiller with gas boiler reheat")]
        AirCooledchillerwithgasboilerreheat = 6,

        /// <summary>
        /// Enum AirCooledchillerwithcentralairsourceheatpumpreheat for value: VAV air-cooled chiller with central air source heat pump reheat
        /// </summary>
        [EnumMember(Value = "VAV air-cooled chiller with central air source heat pump reheat")]
        AirCooledchillerwithcentralairsourceheatpumpreheat = 7,

        /// <summary>
        /// Enum AirCooledchillerwithdistricthotwaterreheat for value: VAV air-cooled chiller with district hot water reheat
        /// </summary>
        [EnumMember(Value = "VAV air-cooled chiller with district hot water reheat")]
        AirCooledchillerwithdistricthotwaterreheat = 8,

        /// <summary>
        /// Enum AirCooledchillerwithPFPboxes for value: VAV air-cooled chiller with PFP boxes
        /// </summary>
        [EnumMember(Value = "VAV air-cooled chiller with PFP boxes")]
        AirCooledchillerwithPFPboxes = 9,

        /// <summary>
        /// Enum AirCooledchillerwithgascoilreheat for value: VAV air-cooled chiller with gas coil reheat
        /// </summary>
        [EnumMember(Value = "VAV air-cooled chiller with gas coil reheat")]
        AirCooledchillerwithgascoilreheat = 10,

        /// <summary>
        /// Enum Districtchilledwaterwithgasboilerreheat for value: VAV district chilled water with gas boiler reheat
        /// </summary>
        [EnumMember(Value = "VAV district chilled water with gas boiler reheat")]
        Districtchilledwaterwithgasboilerreheat = 11,

        /// <summary>
        /// Enum Districtchilledwaterwithcentralairsourceheatpumpreheat for value: VAV district chilled water with central air source heat pump reheat
        /// </summary>
        [EnumMember(Value = "VAV district chilled water with central air source heat pump reheat")]
        Districtchilledwaterwithcentralairsourceheatpumpreheat = 12,

        /// <summary>
        /// Enum Districtchilledwaterwithdistricthotwaterreheat for value: VAV district chilled water with district hot water reheat
        /// </summary>
        [EnumMember(Value = "VAV district chilled water with district hot water reheat")]
        Districtchilledwaterwithdistricthotwaterreheat = 13,

        /// <summary>
        /// Enum DistrictchilledwaterwithPFPboxes for value: VAV district chilled water with PFP boxes
        /// </summary>
        [EnumMember(Value = "VAV district chilled water with PFP boxes")]
        DistrictchilledwaterwithPFPboxes = 14,

        /// <summary>
        /// Enum Districtchilledwaterwithgascoilreheat for value: VAV district chilled water with gas coil reheat
        /// </summary>
        [EnumMember(Value = "VAV district chilled water with gas coil reheat")]
        Districtchilledwaterwithgascoilreheat = 15

    }

}
