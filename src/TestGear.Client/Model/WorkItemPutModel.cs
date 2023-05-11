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
    /// WorkItemPutModel
    /// </summary>
    [DataContract(Name = "WorkItemPutModel")]
    public partial class WorkItemPutModel : IEquatable<WorkItemPutModel>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", IsRequired = true, EmitDefaultValue = true)]
        public WorkItemStates State { get; set; }

        /// <summary>
        /// Gets or Sets Priority
        /// </summary>
        [DataMember(Name = "priority", IsRequired = true, EmitDefaultValue = true)]
        public WorkItemPriorityModel Priority { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkItemPutModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WorkItemPutModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkItemPutModel" /> class.
        /// </summary>
        /// <param name="attachments">attachments (required).</param>
        /// <param name="iterations">iterations.</param>
        /// <param name="autoTests">autoTests.</param>
        /// <param name="id">id (required).</param>
        /// <param name="sectionId">sectionId.</param>
        /// <param name="description">description.</param>
        /// <param name="state">state (required).</param>
        /// <param name="priority">priority (required).</param>
        /// <param name="steps">steps (required).</param>
        /// <param name="preconditionSteps">preconditionSteps (required).</param>
        /// <param name="postconditionSteps">postconditionSteps (required).</param>
        /// <param name="duration">duration.</param>
        /// <param name="attributes">attributes (required).</param>
        /// <param name="tags">tags (required).</param>
        /// <param name="links">links (required).</param>
        /// <param name="name">name (required).</param>
        public WorkItemPutModel(List<AttachmentPutModel> attachments = default(List<AttachmentPutModel>), List<IterationPutModel> iterations = default(List<IterationPutModel>), List<AutoTestIdModel> autoTests = default(List<AutoTestIdModel>), Guid id = default(Guid), Guid sectionId = default(Guid), string description = default(string), WorkItemStates state = default(WorkItemStates), WorkItemPriorityModel priority = default(WorkItemPriorityModel), List<StepPutModel> steps = default(List<StepPutModel>), List<StepPutModel> preconditionSteps = default(List<StepPutModel>), List<StepPutModel> postconditionSteps = default(List<StepPutModel>), int duration = default(int), Dictionary<string, Object> attributes = default(Dictionary<string, Object>), List<TagShortModel> tags = default(List<TagShortModel>), List<LinkPutModel> links = default(List<LinkPutModel>), string name = default(string))
        {
            // to ensure "attachments" is required (not null)
            if (attachments == null)
            {
                throw new ArgumentNullException("attachments is a required property for WorkItemPutModel and cannot be null");
            }
            this.Attachments = attachments;
            this.Id = id;
            this.State = state;
            this.Priority = priority;
            // to ensure "steps" is required (not null)
            if (steps == null)
            {
                throw new ArgumentNullException("steps is a required property for WorkItemPutModel and cannot be null");
            }
            this.Steps = steps;
            // to ensure "preconditionSteps" is required (not null)
            if (preconditionSteps == null)
            {
                throw new ArgumentNullException("preconditionSteps is a required property for WorkItemPutModel and cannot be null");
            }
            this.PreconditionSteps = preconditionSteps;
            // to ensure "postconditionSteps" is required (not null)
            if (postconditionSteps == null)
            {
                throw new ArgumentNullException("postconditionSteps is a required property for WorkItemPutModel and cannot be null");
            }
            this.PostconditionSteps = postconditionSteps;
            // to ensure "attributes" is required (not null)
            if (attributes == null)
            {
                throw new ArgumentNullException("attributes is a required property for WorkItemPutModel and cannot be null");
            }
            this.Attributes = attributes;
            // to ensure "tags" is required (not null)
            if (tags == null)
            {
                throw new ArgumentNullException("tags is a required property for WorkItemPutModel and cannot be null");
            }
            this.Tags = tags;
            // to ensure "links" is required (not null)
            if (links == null)
            {
                throw new ArgumentNullException("links is a required property for WorkItemPutModel and cannot be null");
            }
            this.Links = links;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for WorkItemPutModel and cannot be null");
            }
            this.Name = name;
            this.Iterations = iterations;
            this.AutoTests = autoTests;
            this.SectionId = sectionId;
            this.Description = description;
            this.Duration = duration;
        }

        /// <summary>
        /// Gets or Sets Attachments
        /// </summary>
        [DataMember(Name = "attachments", IsRequired = true, EmitDefaultValue = true)]
        public List<AttachmentPutModel> Attachments { get; set; }

        /// <summary>
        /// Gets or Sets Iterations
        /// </summary>
        [DataMember(Name = "iterations", EmitDefaultValue = true)]
        public List<IterationPutModel> Iterations { get; set; }

        /// <summary>
        /// Gets or Sets AutoTests
        /// </summary>
        [DataMember(Name = "autoTests", EmitDefaultValue = true)]
        public List<AutoTestIdModel> AutoTests { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets SectionId
        /// </summary>
        [DataMember(Name = "sectionId", EmitDefaultValue = false)]
        public Guid SectionId { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Steps
        /// </summary>
        [DataMember(Name = "steps", IsRequired = true, EmitDefaultValue = true)]
        public List<StepPutModel> Steps { get; set; }

        /// <summary>
        /// Gets or Sets PreconditionSteps
        /// </summary>
        [DataMember(Name = "preconditionSteps", IsRequired = true, EmitDefaultValue = true)]
        public List<StepPutModel> PreconditionSteps { get; set; }

        /// <summary>
        /// Gets or Sets PostconditionSteps
        /// </summary>
        [DataMember(Name = "postconditionSteps", IsRequired = true, EmitDefaultValue = true)]
        public List<StepPutModel> PostconditionSteps { get; set; }

        /// <summary>
        /// Gets or Sets Duration
        /// </summary>
        [DataMember(Name = "duration", EmitDefaultValue = false)]
        public int Duration { get; set; }

        /// <summary>
        /// Gets or Sets Attributes
        /// </summary>
        [DataMember(Name = "attributes", IsRequired = true, EmitDefaultValue = true)]
        public Dictionary<string, Object> Attributes { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name = "tags", IsRequired = true, EmitDefaultValue = true)]
        public List<TagShortModel> Tags { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "links", IsRequired = true, EmitDefaultValue = true)]
        public List<LinkPutModel> Links { get; set; }

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
            sb.Append("class WorkItemPutModel {\n");
            sb.Append("  Attachments: ").Append(Attachments).Append("\n");
            sb.Append("  Iterations: ").Append(Iterations).Append("\n");
            sb.Append("  AutoTests: ").Append(AutoTests).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  SectionId: ").Append(SectionId).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  Steps: ").Append(Steps).Append("\n");
            sb.Append("  PreconditionSteps: ").Append(PreconditionSteps).Append("\n");
            sb.Append("  PostconditionSteps: ").Append(PostconditionSteps).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
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
            return this.Equals(input as WorkItemPutModel);
        }

        /// <summary>
        /// Returns true if WorkItemPutModel instances are equal
        /// </summary>
        /// <param name="input">Instance of WorkItemPutModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkItemPutModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Attachments == input.Attachments ||
                    this.Attachments != null &&
                    input.Attachments != null &&
                    this.Attachments.SequenceEqual(input.Attachments)
                ) && 
                (
                    this.Iterations == input.Iterations ||
                    this.Iterations != null &&
                    input.Iterations != null &&
                    this.Iterations.SequenceEqual(input.Iterations)
                ) && 
                (
                    this.AutoTests == input.AutoTests ||
                    this.AutoTests != null &&
                    input.AutoTests != null &&
                    this.AutoTests.SequenceEqual(input.AutoTests)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.SectionId == input.SectionId ||
                    (this.SectionId != null &&
                    this.SectionId.Equals(input.SectionId))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.State == input.State ||
                    this.State.Equals(input.State)
                ) && 
                (
                    this.Priority == input.Priority ||
                    this.Priority.Equals(input.Priority)
                ) && 
                (
                    this.Steps == input.Steps ||
                    this.Steps != null &&
                    input.Steps != null &&
                    this.Steps.SequenceEqual(input.Steps)
                ) && 
                (
                    this.PreconditionSteps == input.PreconditionSteps ||
                    this.PreconditionSteps != null &&
                    input.PreconditionSteps != null &&
                    this.PreconditionSteps.SequenceEqual(input.PreconditionSteps)
                ) && 
                (
                    this.PostconditionSteps == input.PostconditionSteps ||
                    this.PostconditionSteps != null &&
                    input.PostconditionSteps != null &&
                    this.PostconditionSteps.SequenceEqual(input.PostconditionSteps)
                ) && 
                (
                    this.Duration == input.Duration ||
                    this.Duration.Equals(input.Duration)
                ) && 
                (
                    this.Attributes == input.Attributes ||
                    this.Attributes != null &&
                    input.Attributes != null &&
                    this.Attributes.SequenceEqual(input.Attributes)
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.Links == input.Links ||
                    this.Links != null &&
                    input.Links != null &&
                    this.Links.SequenceEqual(input.Links)
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
                if (this.Attachments != null)
                {
                    hashCode = (hashCode * 59) + this.Attachments.GetHashCode();
                }
                if (this.Iterations != null)
                {
                    hashCode = (hashCode * 59) + this.Iterations.GetHashCode();
                }
                if (this.AutoTests != null)
                {
                    hashCode = (hashCode * 59) + this.AutoTests.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.SectionId != null)
                {
                    hashCode = (hashCode * 59) + this.SectionId.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.State.GetHashCode();
                hashCode = (hashCode * 59) + this.Priority.GetHashCode();
                if (this.Steps != null)
                {
                    hashCode = (hashCode * 59) + this.Steps.GetHashCode();
                }
                if (this.PreconditionSteps != null)
                {
                    hashCode = (hashCode * 59) + this.PreconditionSteps.GetHashCode();
                }
                if (this.PostconditionSteps != null)
                {
                    hashCode = (hashCode * 59) + this.PostconditionSteps.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Duration.GetHashCode();
                if (this.Attributes != null)
                {
                    hashCode = (hashCode * 59) + this.Attributes.GetHashCode();
                }
                if (this.Tags != null)
                {
                    hashCode = (hashCode * 59) + this.Tags.GetHashCode();
                }
                if (this.Links != null)
                {
                    hashCode = (hashCode * 59) + this.Links.GetHashCode();
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
            // Duration (int) maximum
            if (this.Duration > (int)86400)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Duration, must be a value less than or equal to 86400.", new [] { "Duration" });
            }

            // Duration (int) minimum
            if (this.Duration < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Duration, must be a value greater than or equal to 0.", new [] { "Duration" });
            }

            // Name (string) minLength
            if (this.Name != null && this.Name.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 1.", new [] { "Name" });
            }

            yield break;
        }
    }

}
