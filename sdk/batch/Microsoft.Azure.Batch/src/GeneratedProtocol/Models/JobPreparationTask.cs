// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A Job Preparation Task to run before any Tasks of the Job on any given
    /// Compute Node.
    /// </summary>
    /// <remarks>
    /// You can use Job Preparation to prepare a Node to run Tasks for the Job.
    /// Activities commonly performed in Job Preparation include: Downloading
    /// common resource files used by all the Tasks in the Job. The Job
    /// Preparation Task can download these common resource files to the shared
    /// location on the Node. (AZ_BATCH_NODE_ROOT_DIR\shared), or starting a
    /// local service on the Node so that all Tasks of that Job can communicate
    /// with it. If the Job Preparation Task fails (that is, exhausts its retry
    /// count before exiting with exit code 0), Batch will not run Tasks of
    /// this Job on the Node. The Compute Node remains ineligible to run Tasks
    /// of this Job until it is reimaged. The Compute Node remains active and
    /// can be used for other Jobs. The Job Preparation Task can run multiple
    /// times on the same Node. Therefore, you should write the Job Preparation
    /// Task to handle re-execution. If the Node is rebooted, the Job
    /// Preparation Task is run again on the Compute Node before scheduling any
    /// other Task of the Job, if rerunOnNodeRebootAfterSuccess is true or if
    /// the Job Preparation Task did not previously complete. If the Node is
    /// reimaged, the Job Preparation Task is run again before scheduling any
    /// Task of the Job. Batch will retry Tasks when a recovery operation is
    /// triggered on a Node. Examples of recovery operations include (but are
    /// not limited to) when an unhealthy Node is rebooted or a Compute Node
    /// disappeared due to host failure. Retries due to recovery operations are
    /// independent of and are not counted against the maxTaskRetryCount. Even
    /// if the maxTaskRetryCount is 0, an internal retry due to a recovery
    /// operation may occur. Because of this, all Tasks should be idempotent.
    /// This means Tasks need to tolerate being interrupted and restarted
    /// without causing any corruption or duplicate data. The best practice for
    /// long running Tasks is to use some form of checkpointing.
    /// </remarks>
    public partial class JobPreparationTask
    {
        /// <summary>
        /// Initializes a new instance of the JobPreparationTask class.
        /// </summary>
        public JobPreparationTask()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JobPreparationTask class.
        /// </summary>
        /// <param name="commandLine">The command line of the Job Preparation
        /// Task.</param>
        /// <param name="id">A string that uniquely identifies the Job
        /// Preparation Task within the Job.</param>
        /// <param name="containerSettings">The settings for the container
        /// under which the Job Preparation Task runs.</param>
        /// <param name="resourceFiles">A list of files that the Batch service
        /// will download to the Compute Node before running the command
        /// line.</param>
        /// <param name="environmentSettings">A list of environment variable
        /// settings for the Job Preparation Task.</param>
        /// <param name="constraints">Constraints that apply to the Job
        /// Preparation Task.</param>
        /// <param name="waitForSuccess">Whether the Batch service should wait
        /// for the Job Preparation Task to complete successfully before
        /// scheduling any other Tasks of the Job on the Compute Node. A Job
        /// Preparation Task has completed successfully if it exits with exit
        /// code 0.</param>
        /// <param name="userIdentity">The user identity under which the Job
        /// Preparation Task runs.</param>
        /// <param name="rerunOnNodeRebootAfterSuccess">Whether the Batch
        /// service should rerun the Job Preparation Task after a Compute Node
        /// reboots.</param>
        public JobPreparationTask(string commandLine, string id = default(string), TaskContainerSettings containerSettings = default(TaskContainerSettings), IList<ResourceFile> resourceFiles = default(IList<ResourceFile>), IList<EnvironmentSetting> environmentSettings = default(IList<EnvironmentSetting>), TaskConstraints constraints = default(TaskConstraints), bool? waitForSuccess = default(bool?), UserIdentity userIdentity = default(UserIdentity), bool? rerunOnNodeRebootAfterSuccess = default(bool?))
        {
            Id = id;
            CommandLine = commandLine;
            ContainerSettings = containerSettings;
            ResourceFiles = resourceFiles;
            EnvironmentSettings = environmentSettings;
            Constraints = constraints;
            WaitForSuccess = waitForSuccess;
            UserIdentity = userIdentity;
            RerunOnNodeRebootAfterSuccess = rerunOnNodeRebootAfterSuccess;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a string that uniquely identifies the Job Preparation
        /// Task within the Job.
        /// </summary>
        /// <remarks>
        /// The ID can contain any combination of alphanumeric characters
        /// including hyphens and underscores and cannot contain more than 64
        /// characters. If you do not specify this property, the Batch service
        /// assigns a default value of 'jobpreparation'. No other Task in the
        /// Job can have the same ID as the Job Preparation Task. If you try to
        /// submit a Task with the same id, the Batch service rejects the
        /// request with error code TaskIdSameAsJobPreparationTask; if you are
        /// calling the REST API directly, the HTTP status code is 409
        /// (Conflict).
        /// </remarks>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the command line of the Job Preparation Task.
        /// </summary>
        /// <remarks>
        /// The command line does not run under a shell, and therefore cannot
        /// take advantage of shell features such as environment variable
        /// expansion. If you want to take advantage of such features, you
        /// should invoke the shell in the command line, for example using "cmd
        /// /c MyCommand" in Windows or "/bin/sh -c MyCommand" in Linux. If the
        /// command line refers to file paths, it should use a relative path
        /// (relative to the Task working directory), or use the Batch provided
        /// environment variable
        /// (https://docs.microsoft.com/azure/batch/batch-compute-node-environment-variables).
        /// </remarks>
        [JsonProperty(PropertyName = "commandLine")]
        public string CommandLine { get; set; }

        /// <summary>
        /// Gets or sets the settings for the container under which the Job
        /// Preparation Task runs.
        /// </summary>
        /// <remarks>
        /// When this is specified, all directories recursively below the
        /// AZ_BATCH_NODE_ROOT_DIR (the root of Azure Batch directories on the
        /// node) are mapped into the container, all Task environment variables
        /// are mapped into the container, and the Task command line is
        /// executed in the container. Files produced in the container outside
        /// of AZ_BATCH_NODE_ROOT_DIR might not be reflected to the host disk,
        /// meaning that Batch file APIs will not be able to access those
        /// files.
        /// </remarks>
        [JsonProperty(PropertyName = "containerSettings")]
        public TaskContainerSettings ContainerSettings { get; set; }

        /// <summary>
        /// Gets or sets a list of files that the Batch service will download
        /// to the Compute Node before running the command line.
        /// </summary>
        /// <remarks>
        /// Files listed under this element are located in the Task's working
        /// directory.  There is a maximum size for the list of resource files.
        /// When the max size is exceeded, the request will fail and the
        /// response error code will be RequestEntityTooLarge. If this occurs,
        /// the collection of ResourceFiles must be reduced in size. This can
        /// be achieved using .zip files, Application Packages, or Docker
        /// Containers.
        /// </remarks>
        [JsonProperty(PropertyName = "resourceFiles")]
        public IList<ResourceFile> ResourceFiles { get; set; }

        /// <summary>
        /// Gets or sets a list of environment variable settings for the Job
        /// Preparation Task.
        /// </summary>
        [JsonProperty(PropertyName = "environmentSettings")]
        public IList<EnvironmentSetting> EnvironmentSettings { get; set; }

        /// <summary>
        /// Gets or sets constraints that apply to the Job Preparation Task.
        /// </summary>
        [JsonProperty(PropertyName = "constraints")]
        public TaskConstraints Constraints { get; set; }

        /// <summary>
        /// Gets or sets whether the Batch service should wait for the Job
        /// Preparation Task to complete successfully before scheduling any
        /// other Tasks of the Job on the Compute Node. A Job Preparation Task
        /// has completed successfully if it exits with exit code 0.
        /// </summary>
        /// <remarks>
        /// If true and the Job Preparation Task fails on a Node, the Batch
        /// service retries the Job Preparation Task up to its maximum retry
        /// count (as specified in the constraints element). If the Task has
        /// still not completed successfully after all retries, then the Batch
        /// service will not schedule Tasks of the Job to the Node. The Node
        /// remains active and eligible to run Tasks of other Jobs. If false,
        /// the Batch service will not wait for the Job Preparation Task to
        /// complete. In this case, other Tasks of the Job can start executing
        /// on the Compute Node while the Job Preparation Task is still
        /// running; and even if the Job Preparation Task fails, new Tasks will
        /// continue to be scheduled on the Compute Node. The default value is
        /// true.
        /// </remarks>
        [JsonProperty(PropertyName = "waitForSuccess")]
        public bool? WaitForSuccess { get; set; }

        /// <summary>
        /// Gets or sets the user identity under which the Job Preparation Task
        /// runs.
        /// </summary>
        /// <remarks>
        /// If omitted, the Task runs as a non-administrative user unique to
        /// the Task on Windows Compute Nodes, or a non-administrative user
        /// unique to the Pool on Linux Compute Nodes.
        /// </remarks>
        [JsonProperty(PropertyName = "userIdentity")]
        public UserIdentity UserIdentity { get; set; }

        /// <summary>
        /// Gets or sets whether the Batch service should rerun the Job
        /// Preparation Task after a Compute Node reboots.
        /// </summary>
        /// <remarks>
        /// The Job Preparation Task is always rerun if a Compute Node is
        /// reimaged, or if the Job Preparation Task did not complete (e.g.
        /// because the reboot occurred while the Task was running). Therefore,
        /// you should always write a Job Preparation Task to be idempotent and
        /// to behave correctly if run multiple times. The default value is
        /// true.
        /// </remarks>
        [JsonProperty(PropertyName = "rerunOnNodeRebootAfterSuccess")]
        public bool? RerunOnNodeRebootAfterSuccess { get; set; }

    }
}
