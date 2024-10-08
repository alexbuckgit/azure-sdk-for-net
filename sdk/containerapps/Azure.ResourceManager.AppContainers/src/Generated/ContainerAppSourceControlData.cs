// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.AppContainers.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppContainers
{
    /// <summary>
    /// A class representing the ContainerAppSourceControl data model.
    /// Container App SourceControl.
    /// </summary>
    public partial class ContainerAppSourceControlData : ResourceData
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ContainerAppSourceControlData"/>. </summary>
        public ContainerAppSourceControlData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ContainerAppSourceControlData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="operationState"> Current provisioning State of the operation. </param>
        /// <param name="repoUri"> The repo url which will be integrated to ContainerApp. </param>
        /// <param name="branch"> The branch which will trigger the auto deployment. </param>
        /// <param name="gitHubActionConfiguration">
        /// Container App Revision Template with all possible settings and the
        /// defaults if user did not provide them. The defaults are populated
        /// as they were at the creation time
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerAppSourceControlData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ContainerAppSourceControlOperationState? operationState, Uri repoUri, string branch, ContainerAppGitHubActionConfiguration gitHubActionConfiguration, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            OperationState = operationState;
            RepoUri = repoUri;
            Branch = branch;
            GitHubActionConfiguration = gitHubActionConfiguration;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Current provisioning State of the operation. </summary>
        [WirePath("properties.operationState")]
        public ContainerAppSourceControlOperationState? OperationState { get; }
        /// <summary> The repo url which will be integrated to ContainerApp. </summary>
        [WirePath("properties.repoUrl")]
        public Uri RepoUri { get; set; }
        /// <summary> The branch which will trigger the auto deployment. </summary>
        [WirePath("properties.branch")]
        public string Branch { get; set; }
        /// <summary>
        /// Container App Revision Template with all possible settings and the
        /// defaults if user did not provide them. The defaults are populated
        /// as they were at the creation time
        /// </summary>
        [WirePath("properties.githubActionConfiguration")]
        public ContainerAppGitHubActionConfiguration GitHubActionConfiguration { get; set; }
    }
}
