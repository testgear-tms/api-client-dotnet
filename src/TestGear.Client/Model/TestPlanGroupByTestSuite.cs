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
    /// TestPlanGroupByTestSuite
    /// </summary>
    [DataContract(Name = "TestPlanGroupByTestSuite")]
    public partial class TestPlanGroupByTestSuite : IEquatable<TestPlanGroupByTestSuite>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestPlanGroupByTestSuite" /> class.
        /// </summary>
        /// <param name="testSuiteId">testSuiteId.</param>
        /// <param name="testSuiteName">testSuiteName.</param>
        /// <param name="value">value.</param>
        public TestPlanGroupByTestSuite(Guid testSuiteId = default(Guid), string testSuiteName = default(string), int value = default(int))
        {
            this.TestSuiteId = testSuiteId;
            this.TestSuiteName = testSuiteName;
            this.Value = value;
        }

        /// <summary>
        /// Gets or Sets TestSuiteId
        /// </summary>
        [DataMember(Name = "testSuiteId", EmitDefaultValue = false)]
        public Guid TestSuiteId { get; set; }

        /// <summary>
        /// Gets or Sets TestSuiteName
        /// </summary>
        [DataMember(Name = "testSuiteName", EmitDefaultValue = true)]
        public string TestSuiteName { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public int Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TestPlanGroupByTestSuite {\n");
            sb.Append("  TestSuiteId: ").Append(TestSuiteId).Append("\n");
            sb.Append("  TestSuiteName: ").Append(TestSuiteName).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as TestPlanGroupByTestSuite);
        }

        /// <summary>
        /// Returns true if TestPlanGroupByTestSuite instances are equal
        /// </summary>
        /// <param name="input">Instance of TestPlanGroupByTestSuite to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TestPlanGroupByTestSuite input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TestSuiteId == input.TestSuiteId ||
                    (this.TestSuiteId != null &&
                    this.TestSuiteId.Equals(input.TestSuiteId))
                ) && 
                (
                    this.TestSuiteName == input.TestSuiteName ||
                    (this.TestSuiteName != null &&
                    this.TestSuiteName.Equals(input.TestSuiteName))
                ) && 
                (
                    this.Value == input.Value ||
                    this.Value.Equals(input.Value)
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
                if (this.TestSuiteId != null)
                {
                    hashCode = (hashCode * 59) + this.TestSuiteId.GetHashCode();
                }
                if (this.TestSuiteName != null)
                {
                    hashCode = (hashCode * 59) + this.TestSuiteName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Value.GetHashCode();
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
