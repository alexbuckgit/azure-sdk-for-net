// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    /// <summary> Non secret deployment resource id reference. </summary>
    public partial class OpenDeploymentResourceReference : DeploymentResourceIdReference
    {
        /// <summary> Initializes a new instance of <see cref="OpenDeploymentResourceReference"/>. </summary>
        public OpenDeploymentResourceReference()
        {
            IdType = IdType.Open;
        }

        /// <summary> Initializes a new instance of <see cref="OpenDeploymentResourceReference"/>. </summary>
        /// <param name="idType"> The resource reference arm id type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="id"> Resource ID. </param>
        internal OpenDeploymentResourceReference(IdType idType, IDictionary<string, BinaryData> serializedAdditionalRawData, ResourceIdentifier id) : base(idType, serializedAdditionalRawData)
        {
            Id = id;
            IdType = idType;
        }

        /// <summary> Resource ID. </summary>
        public ResourceIdentifier Id { get; set; }
    }
}
