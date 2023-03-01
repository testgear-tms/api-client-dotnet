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
    /// FailureClassRegexModel
    /// </summary>
    [DataContract(Name = "FailureClassRegexModel")]
    public partial class FailureClassRegexModel : IEquatable<FailureClassRegexModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FailureClassRegexModel" /> class.
        /// </summary>
        /// <param name="regexText">regexText.</param>
        /// <param name="failureClassId">failureClassId.</param>
        /// <param name="id">Unique ID of the entity.</param>
        /// <param name="isDeleted">Indicates if the entity is deleted.</param>
        public FailureClassRegexModel(string regexText = default(string), Guid? failureClassId = default(Guid?), Guid id = default(Guid), bool isDeleted = default(bool))
        {
            this.RegexText = regexText;
            this.FailureClassId = failureClassId;
            this.Id = id;
            this.IsDeleted = isDeleted;
        }

        /// <summary>
        /// Gets or Sets RegexText
        /// </summary>
        [DataMember(Name = "regexText", EmitDefaultValue = true)]
        public string RegexText { get; set; }

        /// <summary>
        /// Gets or Sets FailureClassId
        /// </summary>
        [DataMember(Name = "failureClassId", EmitDefaultValue = true)]
        public Guid? FailureClassId { get; set; }

        /// <summary>
        /// Unique ID of the entity
        /// </summary>
        /// <value>Unique ID of the entity</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Indicates if the entity is deleted
        /// </summary>
        /// <value>Indicates if the entity is deleted</value>
        [DataMember(Name = "isDeleted", EmitDefaultValue = true)]
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FailureClassRegexModel {\n");
            sb.Append("  RegexText: ").Append(RegexText).Append("\n");
            sb.Append("  FailureClassId: ").Append(FailureClassId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IsDeleted: ").Append(IsDeleted).Append("\n");
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
            return this.Equals(input as FailureClassRegexModel);
        }

        /// <summary>
        /// Returns true if FailureClassRegexModel instances are equal
        /// </summary>
        /// <param name="input">Instance of FailureClassRegexModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FailureClassRegexModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.RegexText == input.RegexText ||
                    (this.RegexText != null &&
                    this.RegexText.Equals(input.RegexText))
                ) && 
                (
                    this.FailureClassId == input.FailureClassId ||
                    (this.FailureClassId != null &&
                    this.FailureClassId.Equals(input.FailureClassId))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.IsDeleted == input.IsDeleted ||
                    this.IsDeleted.Equals(input.IsDeleted)
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
                if (this.RegexText != null)
                {
                    hashCode = (hashCode * 59) + this.RegexText.GetHashCode();
                }
                if (this.FailureClassId != null)
                {
                    hashCode = (hashCode * 59) + this.FailureClassId.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsDeleted.GetHashCode();
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
