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
    /// WorkItemChangedAttributeViewModel
    /// </summary>
    [DataContract(Name = "WorkItemChangedAttributeViewModel")]
    public partial class WorkItemChangedAttributeViewModel : IEquatable<WorkItemChangedAttributeViewModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkItemChangedAttributeViewModel" /> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="oldAttributeName">oldAttributeName.</param>
        /// <param name="newAttributeName">newAttributeName.</param>
        /// <param name="oldValue">oldValue.</param>
        /// <param name="newValue">newValue.</param>
        public WorkItemChangedAttributeViewModel(string type = default(string), string oldAttributeName = default(string), string newAttributeName = default(string), Object oldValue = default(Object), Object newValue = default(Object))
        {
            this.Type = type;
            this.OldAttributeName = oldAttributeName;
            this.NewAttributeName = newAttributeName;
            this.OldValue = oldValue;
            this.NewValue = newValue;
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets OldAttributeName
        /// </summary>
        [DataMember(Name = "oldAttributeName", EmitDefaultValue = true)]
        public string OldAttributeName { get; set; }

        /// <summary>
        /// Gets or Sets NewAttributeName
        /// </summary>
        [DataMember(Name = "newAttributeName", EmitDefaultValue = true)]
        public string NewAttributeName { get; set; }

        /// <summary>
        /// Gets or Sets OldValue
        /// </summary>
        [DataMember(Name = "oldValue", EmitDefaultValue = true)]
        public Object OldValue { get; set; }

        /// <summary>
        /// Gets or Sets NewValue
        /// </summary>
        [DataMember(Name = "newValue", EmitDefaultValue = true)]
        public Object NewValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WorkItemChangedAttributeViewModel {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  OldAttributeName: ").Append(OldAttributeName).Append("\n");
            sb.Append("  NewAttributeName: ").Append(NewAttributeName).Append("\n");
            sb.Append("  OldValue: ").Append(OldValue).Append("\n");
            sb.Append("  NewValue: ").Append(NewValue).Append("\n");
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
            return this.Equals(input as WorkItemChangedAttributeViewModel);
        }

        /// <summary>
        /// Returns true if WorkItemChangedAttributeViewModel instances are equal
        /// </summary>
        /// <param name="input">Instance of WorkItemChangedAttributeViewModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkItemChangedAttributeViewModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.OldAttributeName == input.OldAttributeName ||
                    (this.OldAttributeName != null &&
                    this.OldAttributeName.Equals(input.OldAttributeName))
                ) && 
                (
                    this.NewAttributeName == input.NewAttributeName ||
                    (this.NewAttributeName != null &&
                    this.NewAttributeName.Equals(input.NewAttributeName))
                ) && 
                (
                    this.OldValue == input.OldValue ||
                    (this.OldValue != null &&
                    this.OldValue.Equals(input.OldValue))
                ) && 
                (
                    this.NewValue == input.NewValue ||
                    (this.NewValue != null &&
                    this.NewValue.Equals(input.NewValue))
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
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                if (this.OldAttributeName != null)
                {
                    hashCode = (hashCode * 59) + this.OldAttributeName.GetHashCode();
                }
                if (this.NewAttributeName != null)
                {
                    hashCode = (hashCode * 59) + this.NewAttributeName.GetHashCode();
                }
                if (this.OldValue != null)
                {
                    hashCode = (hashCode * 59) + this.OldValue.GetHashCode();
                }
                if (this.NewValue != null)
                {
                    hashCode = (hashCode * 59) + this.NewValue.GetHashCode();
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
