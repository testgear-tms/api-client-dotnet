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
    /// Defines RequestTypeModel
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RequestTypeModel
    {
        /// <summary>
        /// Enum Post for value: Post
        /// </summary>
        [EnumMember(Value = "Post")]
        Post = 1,

        /// <summary>
        /// Enum Put for value: Put
        /// </summary>
        [EnumMember(Value = "Put")]
        Put = 2,

        /// <summary>
        /// Enum Delete for value: Delete
        /// </summary>
        [EnumMember(Value = "Delete")]
        Delete = 3

    }

}
