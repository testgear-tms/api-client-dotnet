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
    /// TestResultHistoryReportModel
    /// </summary>
    [DataContract(Name = "TestResultHistoryReportModel")]
    public partial class TestResultHistoryReportModel : IEquatable<TestResultHistoryReportModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestResultHistoryReportModel" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="createdDate">createdDate.</param>
        /// <param name="modifiedDate">modifiedDate.</param>
        /// <param name="userId">If test run was stopped, this property equals identifier of user who stopped it.Otherwise, the property equals identifier of user who created the test result.</param>
        /// <param name="testRunId">testRunId.</param>
        /// <param name="testRunName">testRunName.</param>
        /// <param name="createdByUserName">createdByUserName.</param>
        /// <param name="testPlanId">testPlanId.</param>
        /// <param name="testPlanGlobalId">testPlanGlobalId.</param>
        /// <param name="testPlanName">testPlanName.</param>
        /// <param name="configurationName">If test point related to the test result has configuration, this property will be equal to the test point configuration name. Otherwise, this property will be equal to the test result configuration name.</param>
        /// <param name="isAutomated">isAutomated.</param>
        /// <param name="outcome">If any test result related to the test run is linked with autotest and the run has an outcome, the outcome value equalsto the worst outcome of the last modified test result.Otherwise, the outcome equals to the outcome of first created test result in the test run.</param>
        /// <param name="comment">If any test result related to the test run is linked with autotest, comment will have default valueOtherwise, the comment equals to the comment of first created test result in the test run.</param>
        /// <param name="links">If any test result related to the test run is linked with autotest, link will be equal to the links of last modified test result.Otherwise, the links equals to the links of first created test result in the test run.</param>
        /// <param name="startedOn">startedOn.</param>
        /// <param name="completedOn">completedOn.</param>
        /// <param name="duration">duration.</param>
        /// <param name="createdById">createdById.</param>
        /// <param name="modifiedById">modifiedById.</param>
        /// <param name="attachments">If any test result related to the test run is linked with autotest, attachments will be equal to the attachments of last modified test result.Otherwise, the attachments equals to the attachments of first created test result in the test run.</param>
        /// <param name="workItemVersionId">workItemVersionId.</param>
        /// <param name="workItemVersionNumber">workItemVersionNumber.</param>
        /// <param name="launchSource">launchSource.</param>
        /// <param name="failureClassIds">failureClassIds.</param>
        /// <param name="parameters">parameters.</param>
        public TestResultHistoryReportModel(Guid id = default(Guid), DateTime createdDate = default(DateTime), DateTime modifiedDate = default(DateTime), Guid userId = default(Guid), Guid? testRunId = default(Guid?), string testRunName = default(string), string createdByUserName = default(string), Guid? testPlanId = default(Guid?), long? testPlanGlobalId = default(long?), string testPlanName = default(string), string configurationName = default(string), bool isAutomated = default(bool), string outcome = default(string), string comment = default(string), List<LinkModel> links = default(List<LinkModel>), DateTime? startedOn = default(DateTime?), DateTime? completedOn = default(DateTime?), long? duration = default(long?), Guid createdById = default(Guid), Guid? modifiedById = default(Guid?), List<AttachmentModel> attachments = default(List<AttachmentModel>), Guid? workItemVersionId = default(Guid?), int? workItemVersionNumber = default(int?), string launchSource = default(string), List<Guid> failureClassIds = default(List<Guid>), Dictionary<string, string> parameters = default(Dictionary<string, string>))
        {
            this.Id = id;
            this.CreatedDate = createdDate;
            this.ModifiedDate = modifiedDate;
            this.UserId = userId;
            this.TestRunId = testRunId;
            this.TestRunName = testRunName;
            this.CreatedByUserName = createdByUserName;
            this.TestPlanId = testPlanId;
            this.TestPlanGlobalId = testPlanGlobalId;
            this.TestPlanName = testPlanName;
            this.ConfigurationName = configurationName;
            this.IsAutomated = isAutomated;
            this.Outcome = outcome;
            this.Comment = comment;
            this.Links = links;
            this.StartedOn = startedOn;
            this.CompletedOn = completedOn;
            this.Duration = duration;
            this.CreatedById = createdById;
            this.ModifiedById = modifiedById;
            this.Attachments = attachments;
            this.WorkItemVersionId = workItemVersionId;
            this.WorkItemVersionNumber = workItemVersionNumber;
            this.LaunchSource = launchSource;
            this.FailureClassIds = failureClassIds;
            this.Parameters = parameters;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets CreatedDate
        /// </summary>
        [DataMember(Name = "createdDate", EmitDefaultValue = false)]
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Gets or Sets ModifiedDate
        /// </summary>
        [DataMember(Name = "modifiedDate", EmitDefaultValue = false)]
        public DateTime ModifiedDate { get; set; }

        /// <summary>
        /// If test run was stopped, this property equals identifier of user who stopped it.Otherwise, the property equals identifier of user who created the test result
        /// </summary>
        /// <value>If test run was stopped, this property equals identifier of user who stopped it.Otherwise, the property equals identifier of user who created the test result</value>
        [DataMember(Name = "userId", EmitDefaultValue = false)]
        public Guid UserId { get; set; }

        /// <summary>
        /// Gets or Sets TestRunId
        /// </summary>
        [DataMember(Name = "testRunId", EmitDefaultValue = true)]
        public Guid? TestRunId { get; set; }

        /// <summary>
        /// Gets or Sets TestRunName
        /// </summary>
        [DataMember(Name = "testRunName", EmitDefaultValue = true)]
        public string TestRunName { get; set; }

        /// <summary>
        /// Gets or Sets CreatedByUserName
        /// </summary>
        [DataMember(Name = "createdByUserName", EmitDefaultValue = true)]
        public string CreatedByUserName { get; set; }

        /// <summary>
        /// Gets or Sets TestPlanId
        /// </summary>
        [DataMember(Name = "testPlanId", EmitDefaultValue = true)]
        public Guid? TestPlanId { get; set; }

        /// <summary>
        /// Gets or Sets TestPlanGlobalId
        /// </summary>
        [DataMember(Name = "testPlanGlobalId", EmitDefaultValue = true)]
        public long? TestPlanGlobalId { get; set; }

        /// <summary>
        /// Gets or Sets TestPlanName
        /// </summary>
        [DataMember(Name = "testPlanName", EmitDefaultValue = true)]
        public string TestPlanName { get; set; }

        /// <summary>
        /// If test point related to the test result has configuration, this property will be equal to the test point configuration name. Otherwise, this property will be equal to the test result configuration name
        /// </summary>
        /// <value>If test point related to the test result has configuration, this property will be equal to the test point configuration name. Otherwise, this property will be equal to the test result configuration name</value>
        [DataMember(Name = "configurationName", EmitDefaultValue = true)]
        public string ConfigurationName { get; set; }

        /// <summary>
        /// Gets or Sets IsAutomated
        /// </summary>
        [DataMember(Name = "isAutomated", EmitDefaultValue = true)]
        public bool IsAutomated { get; set; }

        /// <summary>
        /// If any test result related to the test run is linked with autotest and the run has an outcome, the outcome value equalsto the worst outcome of the last modified test result.Otherwise, the outcome equals to the outcome of first created test result in the test run
        /// </summary>
        /// <value>If any test result related to the test run is linked with autotest and the run has an outcome, the outcome value equalsto the worst outcome of the last modified test result.Otherwise, the outcome equals to the outcome of first created test result in the test run</value>
        [DataMember(Name = "outcome", EmitDefaultValue = true)]
        public string Outcome { get; set; }

        /// <summary>
        /// If any test result related to the test run is linked with autotest, comment will have default valueOtherwise, the comment equals to the comment of first created test result in the test run
        /// </summary>
        /// <value>If any test result related to the test run is linked with autotest, comment will have default valueOtherwise, the comment equals to the comment of first created test result in the test run</value>
        [DataMember(Name = "comment", EmitDefaultValue = true)]
        public string Comment { get; set; }

        /// <summary>
        /// If any test result related to the test run is linked with autotest, link will be equal to the links of last modified test result.Otherwise, the links equals to the links of first created test result in the test run
        /// </summary>
        /// <value>If any test result related to the test run is linked with autotest, link will be equal to the links of last modified test result.Otherwise, the links equals to the links of first created test result in the test run</value>
        [DataMember(Name = "links", EmitDefaultValue = true)]
        public List<LinkModel> Links { get; set; }

        /// <summary>
        /// Gets or Sets StartedOn
        /// </summary>
        [DataMember(Name = "startedOn", EmitDefaultValue = true)]
        public DateTime? StartedOn { get; set; }

        /// <summary>
        /// Gets or Sets CompletedOn
        /// </summary>
        [DataMember(Name = "completedOn", EmitDefaultValue = true)]
        public DateTime? CompletedOn { get; set; }

        /// <summary>
        /// Gets or Sets Duration
        /// </summary>
        [DataMember(Name = "duration", EmitDefaultValue = true)]
        public long? Duration { get; set; }

        /// <summary>
        /// Gets or Sets CreatedById
        /// </summary>
        [DataMember(Name = "createdById", EmitDefaultValue = false)]
        public Guid CreatedById { get; set; }

        /// <summary>
        /// Gets or Sets ModifiedById
        /// </summary>
        [DataMember(Name = "modifiedById", EmitDefaultValue = true)]
        public Guid? ModifiedById { get; set; }

        /// <summary>
        /// If any test result related to the test run is linked with autotest, attachments will be equal to the attachments of last modified test result.Otherwise, the attachments equals to the attachments of first created test result in the test run
        /// </summary>
        /// <value>If any test result related to the test run is linked with autotest, attachments will be equal to the attachments of last modified test result.Otherwise, the attachments equals to the attachments of first created test result in the test run</value>
        [DataMember(Name = "attachments", EmitDefaultValue = true)]
        public List<AttachmentModel> Attachments { get; set; }

        /// <summary>
        /// Gets or Sets WorkItemVersionId
        /// </summary>
        [DataMember(Name = "workItemVersionId", EmitDefaultValue = true)]
        public Guid? WorkItemVersionId { get; set; }

        /// <summary>
        /// Gets or Sets WorkItemVersionNumber
        /// </summary>
        [DataMember(Name = "workItemVersionNumber", EmitDefaultValue = true)]
        public int? WorkItemVersionNumber { get; set; }

        /// <summary>
        /// Gets or Sets LaunchSource
        /// </summary>
        [DataMember(Name = "launchSource", EmitDefaultValue = true)]
        public string LaunchSource { get; set; }

        /// <summary>
        /// Gets or Sets FailureClassIds
        /// </summary>
        [DataMember(Name = "failureClassIds", EmitDefaultValue = true)]
        public List<Guid> FailureClassIds { get; set; }

        /// <summary>
        /// Gets or Sets Parameters
        /// </summary>
        [DataMember(Name = "parameters", EmitDefaultValue = true)]
        public Dictionary<string, string> Parameters { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TestResultHistoryReportModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  TestRunId: ").Append(TestRunId).Append("\n");
            sb.Append("  TestRunName: ").Append(TestRunName).Append("\n");
            sb.Append("  CreatedByUserName: ").Append(CreatedByUserName).Append("\n");
            sb.Append("  TestPlanId: ").Append(TestPlanId).Append("\n");
            sb.Append("  TestPlanGlobalId: ").Append(TestPlanGlobalId).Append("\n");
            sb.Append("  TestPlanName: ").Append(TestPlanName).Append("\n");
            sb.Append("  ConfigurationName: ").Append(ConfigurationName).Append("\n");
            sb.Append("  IsAutomated: ").Append(IsAutomated).Append("\n");
            sb.Append("  Outcome: ").Append(Outcome).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  StartedOn: ").Append(StartedOn).Append("\n");
            sb.Append("  CompletedOn: ").Append(CompletedOn).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  CreatedById: ").Append(CreatedById).Append("\n");
            sb.Append("  ModifiedById: ").Append(ModifiedById).Append("\n");
            sb.Append("  Attachments: ").Append(Attachments).Append("\n");
            sb.Append("  WorkItemVersionId: ").Append(WorkItemVersionId).Append("\n");
            sb.Append("  WorkItemVersionNumber: ").Append(WorkItemVersionNumber).Append("\n");
            sb.Append("  LaunchSource: ").Append(LaunchSource).Append("\n");
            sb.Append("  FailureClassIds: ").Append(FailureClassIds).Append("\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
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
            return this.Equals(input as TestResultHistoryReportModel);
        }

        /// <summary>
        /// Returns true if TestResultHistoryReportModel instances are equal
        /// </summary>
        /// <param name="input">Instance of TestResultHistoryReportModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TestResultHistoryReportModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.CreatedDate == input.CreatedDate ||
                    (this.CreatedDate != null &&
                    this.CreatedDate.Equals(input.CreatedDate))
                ) && 
                (
                    this.ModifiedDate == input.ModifiedDate ||
                    (this.ModifiedDate != null &&
                    this.ModifiedDate.Equals(input.ModifiedDate))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.TestRunId == input.TestRunId ||
                    (this.TestRunId != null &&
                    this.TestRunId.Equals(input.TestRunId))
                ) && 
                (
                    this.TestRunName == input.TestRunName ||
                    (this.TestRunName != null &&
                    this.TestRunName.Equals(input.TestRunName))
                ) && 
                (
                    this.CreatedByUserName == input.CreatedByUserName ||
                    (this.CreatedByUserName != null &&
                    this.CreatedByUserName.Equals(input.CreatedByUserName))
                ) && 
                (
                    this.TestPlanId == input.TestPlanId ||
                    (this.TestPlanId != null &&
                    this.TestPlanId.Equals(input.TestPlanId))
                ) && 
                (
                    this.TestPlanGlobalId == input.TestPlanGlobalId ||
                    (this.TestPlanGlobalId != null &&
                    this.TestPlanGlobalId.Equals(input.TestPlanGlobalId))
                ) && 
                (
                    this.TestPlanName == input.TestPlanName ||
                    (this.TestPlanName != null &&
                    this.TestPlanName.Equals(input.TestPlanName))
                ) && 
                (
                    this.ConfigurationName == input.ConfigurationName ||
                    (this.ConfigurationName != null &&
                    this.ConfigurationName.Equals(input.ConfigurationName))
                ) && 
                (
                    this.IsAutomated == input.IsAutomated ||
                    this.IsAutomated.Equals(input.IsAutomated)
                ) && 
                (
                    this.Outcome == input.Outcome ||
                    (this.Outcome != null &&
                    this.Outcome.Equals(input.Outcome))
                ) && 
                (
                    this.Comment == input.Comment ||
                    (this.Comment != null &&
                    this.Comment.Equals(input.Comment))
                ) && 
                (
                    this.Links == input.Links ||
                    this.Links != null &&
                    input.Links != null &&
                    this.Links.SequenceEqual(input.Links)
                ) && 
                (
                    this.StartedOn == input.StartedOn ||
                    (this.StartedOn != null &&
                    this.StartedOn.Equals(input.StartedOn))
                ) && 
                (
                    this.CompletedOn == input.CompletedOn ||
                    (this.CompletedOn != null &&
                    this.CompletedOn.Equals(input.CompletedOn))
                ) && 
                (
                    this.Duration == input.Duration ||
                    (this.Duration != null &&
                    this.Duration.Equals(input.Duration))
                ) && 
                (
                    this.CreatedById == input.CreatedById ||
                    (this.CreatedById != null &&
                    this.CreatedById.Equals(input.CreatedById))
                ) && 
                (
                    this.ModifiedById == input.ModifiedById ||
                    (this.ModifiedById != null &&
                    this.ModifiedById.Equals(input.ModifiedById))
                ) && 
                (
                    this.Attachments == input.Attachments ||
                    this.Attachments != null &&
                    input.Attachments != null &&
                    this.Attachments.SequenceEqual(input.Attachments)
                ) && 
                (
                    this.WorkItemVersionId == input.WorkItemVersionId ||
                    (this.WorkItemVersionId != null &&
                    this.WorkItemVersionId.Equals(input.WorkItemVersionId))
                ) && 
                (
                    this.WorkItemVersionNumber == input.WorkItemVersionNumber ||
                    (this.WorkItemVersionNumber != null &&
                    this.WorkItemVersionNumber.Equals(input.WorkItemVersionNumber))
                ) && 
                (
                    this.LaunchSource == input.LaunchSource ||
                    (this.LaunchSource != null &&
                    this.LaunchSource.Equals(input.LaunchSource))
                ) && 
                (
                    this.FailureClassIds == input.FailureClassIds ||
                    this.FailureClassIds != null &&
                    input.FailureClassIds != null &&
                    this.FailureClassIds.SequenceEqual(input.FailureClassIds)
                ) && 
                (
                    this.Parameters == input.Parameters ||
                    this.Parameters != null &&
                    input.Parameters != null &&
                    this.Parameters.SequenceEqual(input.Parameters)
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.CreatedDate != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedDate.GetHashCode();
                }
                if (this.ModifiedDate != null)
                {
                    hashCode = (hashCode * 59) + this.ModifiedDate.GetHashCode();
                }
                if (this.UserId != null)
                {
                    hashCode = (hashCode * 59) + this.UserId.GetHashCode();
                }
                if (this.TestRunId != null)
                {
                    hashCode = (hashCode * 59) + this.TestRunId.GetHashCode();
                }
                if (this.TestRunName != null)
                {
                    hashCode = (hashCode * 59) + this.TestRunName.GetHashCode();
                }
                if (this.CreatedByUserName != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedByUserName.GetHashCode();
                }
                if (this.TestPlanId != null)
                {
                    hashCode = (hashCode * 59) + this.TestPlanId.GetHashCode();
                }
                if (this.TestPlanGlobalId != null)
                {
                    hashCode = (hashCode * 59) + this.TestPlanGlobalId.GetHashCode();
                }
                if (this.TestPlanName != null)
                {
                    hashCode = (hashCode * 59) + this.TestPlanName.GetHashCode();
                }
                if (this.ConfigurationName != null)
                {
                    hashCode = (hashCode * 59) + this.ConfigurationName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsAutomated.GetHashCode();
                if (this.Outcome != null)
                {
                    hashCode = (hashCode * 59) + this.Outcome.GetHashCode();
                }
                if (this.Comment != null)
                {
                    hashCode = (hashCode * 59) + this.Comment.GetHashCode();
                }
                if (this.Links != null)
                {
                    hashCode = (hashCode * 59) + this.Links.GetHashCode();
                }
                if (this.StartedOn != null)
                {
                    hashCode = (hashCode * 59) + this.StartedOn.GetHashCode();
                }
                if (this.CompletedOn != null)
                {
                    hashCode = (hashCode * 59) + this.CompletedOn.GetHashCode();
                }
                if (this.Duration != null)
                {
                    hashCode = (hashCode * 59) + this.Duration.GetHashCode();
                }
                if (this.CreatedById != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedById.GetHashCode();
                }
                if (this.ModifiedById != null)
                {
                    hashCode = (hashCode * 59) + this.ModifiedById.GetHashCode();
                }
                if (this.Attachments != null)
                {
                    hashCode = (hashCode * 59) + this.Attachments.GetHashCode();
                }
                if (this.WorkItemVersionId != null)
                {
                    hashCode = (hashCode * 59) + this.WorkItemVersionId.GetHashCode();
                }
                if (this.WorkItemVersionNumber != null)
                {
                    hashCode = (hashCode * 59) + this.WorkItemVersionNumber.GetHashCode();
                }
                if (this.LaunchSource != null)
                {
                    hashCode = (hashCode * 59) + this.LaunchSource.GetHashCode();
                }
                if (this.FailureClassIds != null)
                {
                    hashCode = (hashCode * 59) + this.FailureClassIds.GetHashCode();
                }
                if (this.Parameters != null)
                {
                    hashCode = (hashCode * 59) + this.Parameters.GetHashCode();
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
