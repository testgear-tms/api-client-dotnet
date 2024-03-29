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
    /// ParameterGroupModel
    /// </summary>
    [DataContract(Name = "ParameterGroupModel")]
    public partial class ParameterGroupModel : IEquatable<ParameterGroupModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ParameterGroupModel" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="values">values.</param>
        /// <param name="parameterKeyId">parameterKeyId.</param>
        public ParameterGroupModel(string name = default(string), Dictionary<string, string> values = default(Dictionary<string, string>), Guid parameterKeyId = default(Guid))
        {
            this.Name = name;
            this.Values = values;
            this.ParameterKeyId = parameterKeyId;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Values
        /// </summary>
        [DataMember(Name = "values", EmitDefaultValue = true)]
        public Dictionary<string, string> Values { get; set; }

        /// <summary>
        /// Gets or Sets ParameterKeyId
        /// </summary>
        [DataMember(Name = "parameterKeyId", EmitDefaultValue = false)]
        public Guid ParameterKeyId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ParameterGroupModel {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
            sb.Append("  ParameterKeyId: ").Append(ParameterKeyId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ParameterGroupModel);
        }

        /// <summary>
        /// Returns true if ParameterGroupModel instances are equal
        /// </summary>
        /// <param name="input">Instance of ParameterGroupModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ParameterGroupModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Values == input.Values ||
                    this.Values != null &&
                    input.Values != null &&
                    this.Values.SequenceEqual(input.Values)
                ) && 
                (
                    this.ParameterKeyId == input.ParameterKeyId ||
                    (this.ParameterKeyId != null &&
                    this.ParameterKeyId.Equals(input.ParameterKeyId))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Values != null)
                {
                    hashCode = (hashCode * 59) + this.Values.GetHashCode();
                }
                if (this.ParameterKeyId != null)
                {
                    hashCode = (hashCode * 59) + this.ParameterKeyId.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
