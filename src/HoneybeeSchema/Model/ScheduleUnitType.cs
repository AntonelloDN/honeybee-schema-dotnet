/* 
 * Honeybee Model Schema
 *
 * This is the documentation for Honeybee model schema.
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
    /// Defines ScheduleUnitType
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ScheduleUnitType
    {
        /// <summary>
        /// Enum Dimensionless for value: Dimensionless
        /// </summary>
        [EnumMember(Value = "Dimensionless")]
        Dimensionless = 1,

        /// <summary>
        /// Enum Temperature for value: Temperature
        /// </summary>
        [EnumMember(Value = "Temperature")]
        Temperature = 2,

        /// <summary>
        /// Enum DeltaTemperature for value: DeltaTemperature
        /// </summary>
        [EnumMember(Value = "DeltaTemperature")]
        DeltaTemperature = 3,

        /// <summary>
        /// Enum PrecipitationRate for value: PrecipitationRate
        /// </summary>
        [EnumMember(Value = "PrecipitationRate")]
        PrecipitationRate = 4,

        /// <summary>
        /// Enum Angle for value: Angle
        /// </summary>
        [EnumMember(Value = "Angle")]
        Angle = 5,

        /// <summary>
        /// Enum ConvectionCoefficient for value: ConvectionCoefficient
        /// </summary>
        [EnumMember(Value = "ConvectionCoefficient")]
        ConvectionCoefficient = 6,

        /// <summary>
        /// Enum ActivityLevel for value: ActivityLevel
        /// </summary>
        [EnumMember(Value = "ActivityLevel")]
        ActivityLevel = 7,

        /// <summary>
        /// Enum Velocity for value: Velocity
        /// </summary>
        [EnumMember(Value = "Velocity")]
        Velocity = 8,

        /// <summary>
        /// Enum Capacity for value: Capacity
        /// </summary>
        [EnumMember(Value = "Capacity")]
        Capacity = 9,

        /// <summary>
        /// Enum Power for value: Power
        /// </summary>
        [EnumMember(Value = "Power")]
        Power = 10,

        /// <summary>
        /// Enum Availability for value: Availability
        /// </summary>
        [EnumMember(Value = "Availability")]
        Availability = 11,

        /// <summary>
        /// Enum Percent for value: Percent
        /// </summary>
        [EnumMember(Value = "Percent")]
        Percent = 12,

        /// <summary>
        /// Enum Control for value: Control
        /// </summary>
        [EnumMember(Value = "Control")]
        Control = 13,

        /// <summary>
        /// Enum Mode for value: Mode
        /// </summary>
        [EnumMember(Value = "Mode")]
        Mode = 14

    }

}
