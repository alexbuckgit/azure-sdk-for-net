// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Synapse.Models;

namespace Azure.ResourceManager.Synapse
{
    /// <summary>
    /// A class representing the SynapseAttachedDatabaseConfiguration data model.
    /// Class representing an attached database configuration.
    /// </summary>
    public partial class SynapseAttachedDatabaseConfigurationData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="SynapseAttachedDatabaseConfigurationData"/>. </summary>
        public SynapseAttachedDatabaseConfigurationData()
        {
            AttachedDatabaseNames = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="SynapseAttachedDatabaseConfigurationData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="provisioningState"> The provisioned state of the resource. </param>
        /// <param name="databaseName"> The name of the database which you would like to attach, use * if you want to follow all current and future databases. </param>
        /// <param name="kustoPoolResourceId"> The resource id of the kusto pool where the databases you would like to attach reside. </param>
        /// <param name="attachedDatabaseNames"> The list of databases from the clusterResourceId which are currently attached to the kusto pool. </param>
        /// <param name="defaultPrincipalsModificationKind"> The default principals modification kind. </param>
        /// <param name="tableLevelSharingProperties"> Table level sharing specifications. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SynapseAttachedDatabaseConfigurationData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AzureLocation? location, ResourceProvisioningState? provisioningState, string databaseName, ResourceIdentifier kustoPoolResourceId, IReadOnlyList<string> attachedDatabaseNames, SynapseDefaultPrincipalsModificationKind? defaultPrincipalsModificationKind, SynapseTableLevelSharingProperties tableLevelSharingProperties, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Location = location;
            ProvisioningState = provisioningState;
            DatabaseName = databaseName;
            KustoPoolResourceId = kustoPoolResourceId;
            AttachedDatabaseNames = attachedDatabaseNames;
            DefaultPrincipalsModificationKind = defaultPrincipalsModificationKind;
            TableLevelSharingProperties = tableLevelSharingProperties;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Resource location. </summary>
        public AzureLocation? Location { get; set; }
        /// <summary> The provisioned state of the resource. </summary>
        public ResourceProvisioningState? ProvisioningState { get; }
        /// <summary> The name of the database which you would like to attach, use * if you want to follow all current and future databases. </summary>
        public string DatabaseName { get; set; }
        /// <summary> The resource id of the kusto pool where the databases you would like to attach reside. </summary>
        public ResourceIdentifier KustoPoolResourceId { get; set; }
        /// <summary> The list of databases from the clusterResourceId which are currently attached to the kusto pool. </summary>
        public IReadOnlyList<string> AttachedDatabaseNames { get; }
        /// <summary> The default principals modification kind. </summary>
        public SynapseDefaultPrincipalsModificationKind? DefaultPrincipalsModificationKind { get; set; }
        /// <summary> Table level sharing specifications. </summary>
        public SynapseTableLevelSharingProperties TableLevelSharingProperties { get; set; }
    }
}
