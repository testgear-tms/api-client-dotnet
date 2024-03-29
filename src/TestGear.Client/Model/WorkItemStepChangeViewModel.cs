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
    /// WorkItemStepChangeViewModel
    /// </summary>
    [DataContract(Name = "WorkItemStepChangeViewModel")]
    public partial class WorkItemStepChangeViewModel : IEquatable<WorkItemStepChangeViewModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkItemStepChangeViewModel" /> class.
        /// </summary>
        /// <param name="action">action.</param>
        /// <param name="expected">expected.</param>
        /// <param name="comments">comments.</param>
        /// <param name="testData">testData.</param>
        /// <param name="index">index.</param>
        /// <param name="workItemId">workItemId.</param>
        /// <param name="workItem">workItem.</param>
        public WorkItemStepChangeViewModel(string action = default(string), string expected = default(string), string comments = default(string), string testData = default(string), int index = default(int), Guid? workItemId = default(Guid?), SharedStepChangeViewModel workItem = default(SharedStepChangeViewModel))
        {
            this.Action = action;
            this.Expected = expected;
            this.Comments = comments;
            this.TestData = testData;
            this.Index = index;
            this.WorkItemId = workItemId;
            this.WorkItem = workItem;
        }

        /// <summary>
        /// Gets or Sets Action
        /// </summary>
        [DataMember(Name = "action", EmitDefaultValue = true)]
        public string Action { get; set; }

        /// <summary>
        /// Gets or Sets Expected
        /// </summary>
        [DataMember(Name = "expected", EmitDefaultValue = true)]
        public string Expected { get; set; }

        /// <summary>
        /// Gets or Sets Comments
        /// </summary>
        [DataMember(Name = "comments", EmitDefaultValue = true)]
        public string Comments { get; set; }

        /// <summary>
        /// Gets or Sets TestData
        /// </summary>
        [DataMember(Name = "testData", EmitDefaultValue = true)]
        public string TestData { get; set; }

        /// <summary>
        /// Gets or Sets Index
        /// </summary>
        [DataMember(Name = "index", EmitDefaultValue = false)]
        public int Index { get; set; }

        /// <summary>
        /// Gets or Sets WorkItemId
        /// </summary>
        [DataMember(Name = "workItemId", EmitDefaultValue = true)]
        public Guid? WorkItemId { get; set; }

        /// <summary>
        /// Gets or Sets WorkItem
        /// </summary>
        [DataMember(Name = "workItem", EmitDefaultValue = false)]
        public SharedStepChangeViewModel WorkItem { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WorkItemStepChangeViewModel {\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  Expected: ").Append(Expected).Append("\n");
            sb.Append("  Comments: ").Append(Comments).Append("\n");
            sb.Append("  TestData: ").Append(TestData).Append("\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  WorkItemId: ").Append(WorkItemId).Append("\n");
            sb.Append("  WorkItem: ").Append(WorkItem).Append("\n");
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
            return this.Equals(input as WorkItemStepChangeViewModel);
        }

        /// <summary>
        /// Returns true if WorkItemStepChangeViewModel instances are equal
        /// </summary>
        /// <param name="input">Instance of WorkItemStepChangeViewModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkItemStepChangeViewModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
                ) && 
                (
                    this.Expected == input.Expected ||
                    (this.Expected != null &&
                    this.Expected.Equals(input.Expected))
                ) && 
                (
                    this.Comments == input.Comments ||
                    (this.Comments != null &&
                    this.Comments.Equals(input.Comments))
                ) && 
                (
                    this.TestData == input.TestData ||
                    (this.TestData != null &&
                    this.TestData.Equals(input.TestData))
                ) && 
                (
                    this.Index == input.Index ||
                    this.Index.Equals(input.Index)
                ) && 
                (
                    this.WorkItemId == input.WorkItemId ||
                    (this.WorkItemId != null &&
                    this.WorkItemId.Equals(input.WorkItemId))
                ) && 
                (
                    this.WorkItem == input.WorkItem ||
                    (this.WorkItem != null &&
                    this.WorkItem.Equals(input.WorkItem))
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
                if (this.Action != null)
                {
                    hashCode = (hashCode * 59) + this.Action.GetHashCode();
                }
                if (this.Expected != null)
                {
                    hashCode = (hashCode * 59) + this.Expected.GetHashCode();
                }
                if (this.Comments != null)
                {
                    hashCode = (hashCode * 59) + this.Comments.GetHashCode();
                }
                if (this.TestData != null)
                {
                    hashCode = (hashCode * 59) + this.TestData.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Index.GetHashCode();
                if (this.WorkItemId != null)
                {
                    hashCode = (hashCode * 59) + this.WorkItemId.GetHashCode();
                }
                if (this.WorkItem != null)
                {
                    hashCode = (hashCode * 59) + this.WorkItem.GetHashCode();
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
