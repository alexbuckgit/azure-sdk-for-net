// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> Exporter Info. </summary>
    public partial class PipelineGroupExporter
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

        /// <summary> Initializes a new instance of <see cref="PipelineGroupExporter"/>. </summary>
        /// <param name="exporterType"> The type of exporter. </param>
        /// <param name="name"> The name of exporter. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public PipelineGroupExporter(PipelineGroupExporterType exporterType, string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            ExporterType = exporterType;
            Name = name;
        }

        /// <summary> Initializes a new instance of <see cref="PipelineGroupExporter"/>. </summary>
        /// <param name="exporterType"> The type of exporter. </param>
        /// <param name="name"> The name of exporter. </param>
        /// <param name="azureMonitorWorkspaceLogs"> Azure Monitor Workspace Logs specific configurations. </param>
        /// <param name="tcp"> TCP based exporter. Used for pipelineGroup exporter. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PipelineGroupExporter(PipelineGroupExporterType exporterType, string name, MonitorWorkspaceLogsExporter azureMonitorWorkspaceLogs, TcpExporter tcp, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ExporterType = exporterType;
            Name = name;
            AzureMonitorWorkspaceLogs = azureMonitorWorkspaceLogs;
            Tcp = tcp;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="PipelineGroupExporter"/> for deserialization. </summary>
        internal PipelineGroupExporter()
        {
        }

        /// <summary> The type of exporter. </summary>
        public PipelineGroupExporterType ExporterType { get; set; }
        /// <summary> The name of exporter. </summary>
        public string Name { get; set; }
        /// <summary> Azure Monitor Workspace Logs specific configurations. </summary>
        public MonitorWorkspaceLogsExporter AzureMonitorWorkspaceLogs { get; set; }
        /// <summary> TCP based exporter. Used for pipelineGroup exporter. </summary>
        internal TcpExporter Tcp { get; set; }
        /// <summary> TCP url to export. </summary>
        public Uri TcpUri
        {
            get => Tcp is null ? default : Tcp.Uri;
            set => Tcp = new TcpExporter(value);
        }
    }
}
