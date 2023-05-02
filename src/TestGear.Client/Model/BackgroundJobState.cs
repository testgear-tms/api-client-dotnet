/*
 * API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v2.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using FileParameter = TestGear.Client.Client.FileParameter;
using OpenAPIDateConverter = TestGear.Client.Client.OpenAPIDateConverter;

namespace TestGear.Client.Model
{
    /// <summary>
    /// Defines BackgroundJobState
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum BackgroundJobState
    {
        /// <summary>
        /// Enum Enqueued for value: Enqueued
        /// </summary>
        [EnumMember(Value = "Enqueued")]
        Enqueued = 1,

        /// <summary>
        /// Enum InProgress for value: InProgress
        /// </summary>
        [EnumMember(Value = "InProgress")]
        InProgress = 2,

        /// <summary>
        /// Enum Completed for value: Completed
        /// </summary>
        [EnumMember(Value = "Completed")]
        Completed = 3,

        /// <summary>
        /// Enum Failed for value: Failed
        /// </summary>
        [EnumMember(Value = "Failed")]
        Failed = 4

    }

}
