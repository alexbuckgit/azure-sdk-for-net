// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.SecurityInsights
{
    /// <summary>
    /// A class representing the WorkspaceManagerGroup data model.
    /// The workspace manager group
    /// </summary>
    public partial class WorkspaceManagerGroupData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="WorkspaceManagerGroupData"/>. </summary>
        public WorkspaceManagerGroupData()
        {
            MemberResourceNames = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="WorkspaceManagerGroupData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="description"> The description of the workspace manager group. </param>
        /// <param name="displayName"> The display name of the workspace manager group. </param>
        /// <param name="memberResourceNames"> The names of the workspace manager members participating in this group. </param>
        /// <param name="etag"> Resource Etag. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal WorkspaceManagerGroupData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string description, string displayName, IList<string> memberResourceNames, ETag? etag, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Description = description;
            DisplayName = displayName;
            MemberResourceNames = memberResourceNames;
            ETag = etag;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The description of the workspace manager group. </summary>
        [WirePath("properties.description")]
        public string Description { get; set; }
        /// <summary> The display name of the workspace manager group. </summary>
        [WirePath("properties.displayName")]
        public string DisplayName { get; set; }
        /// <summary> The names of the workspace manager members participating in this group. </summary>
        [WirePath("properties.memberResourceNames")]
        public IList<string> MemberResourceNames { get; }
        /// <summary> Resource Etag. </summary>
        [WirePath("etag")]
        public ETag? ETag { get; }
    }
}
