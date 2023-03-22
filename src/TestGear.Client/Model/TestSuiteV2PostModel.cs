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
    /// TestSuiteV2PostModel
    /// </summary>
    [DataContract(Name = "TestSuiteV2PostModel")]
    public partial class TestSuiteV2PostModel : IEquatable<TestSuiteV2PostModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestSuiteV2PostModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TestSuiteV2PostModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TestSuiteV2PostModel" /> class.
        /// </summary>
        /// <param name="parentId">parentId.</param>
        /// <param name="testPlanId">testPlanId (required).</param>
        /// <param name="name">name (required).</param>
        public TestSuiteV2PostModel(Guid? parentId = default(Guid?), Guid testPlanId = default(Guid), string name = default(string))
        {
            this.TestPlanId = testPlanId;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for TestSuiteV2PostModel and cannot be null");
            }
            this.Name = name;
            this.ParentId = parentId;
        }

        /// <summary>
        /// Gets or Sets ParentId
        /// </summary>
        [DataMember(Name = "parentId", EmitDefaultValue = true)]
        public Guid? ParentId { get; set; }

        /// <summary>
        /// Gets or Sets TestPlanId
        /// </summary>
        [DataMember(Name = "testPlanId", IsRequired = true, EmitDefaultValue = true)]
        public Guid TestPlanId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TestSuiteV2PostModel {\n");
            sb.Append("  ParentId: ").Append(ParentId).Append("\n");
            sb.Append("  TestPlanId: ").Append(TestPlanId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as TestSuiteV2PostModel);
        }

        /// <summary>
        /// Returns true if TestSuiteV2PostModel instances are equal
        /// </summary>
        /// <param name="input">Instance of TestSuiteV2PostModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TestSuiteV2PostModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ParentId == input.ParentId ||
                    (this.ParentId != null &&
                    this.ParentId.Equals(input.ParentId))
                ) && 
                (
                    this.TestPlanId == input.TestPlanId ||
                    (this.TestPlanId != null &&
                    this.TestPlanId.Equals(input.TestPlanId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.ParentId != null)
                {
                    hashCode = (hashCode * 59) + this.ParentId.GetHashCode();
                }
                if (this.TestPlanId != null)
                {
                    hashCode = (hashCode * 59) + this.TestPlanId.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
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
            // Name (string) maxLength
            if (this.Name != null && this.Name.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 255.", new [] { "Name" });
            }

            // Name (string) minLength
            if (this.Name != null && this.Name.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 0.", new [] { "Name" });
            }

            yield break;
        }
    }

}
