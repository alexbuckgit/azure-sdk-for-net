// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.AppService;

/// <summary>
/// SitePublicCertificate.
/// </summary>
public partial class SitePublicCertificate : Resource
{
    /// <summary>
    /// Public certificate name.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Public Certificate byte array.
    /// </summary>
    public BicepValue<BinaryData> Blob { get => _blob; set => _blob.Assign(value); }
    private readonly BicepValue<BinaryData> _blob;

    /// <summary>
    /// Kind of resource.
    /// </summary>
    public BicepValue<string> Kind { get => _kind; set => _kind.Assign(value); }
    private readonly BicepValue<string> _kind;

    /// <summary>
    /// Public Certificate Location.
    /// </summary>
    public BicepValue<PublicCertificateLocation> PublicCertificateLocation { get => _publicCertificateLocation; set => _publicCertificateLocation.Assign(value); }
    private readonly BicepValue<PublicCertificateLocation> _publicCertificateLocation;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Certificate Thumbprint.
    /// </summary>
    public BicepValue<string> ThumbprintString { get => _thumbprintString; }
    private readonly BicepValue<string> _thumbprintString;

    /// <summary>
    /// Gets or sets a reference to the parent WebSite.
    /// </summary>
    public WebSite? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<WebSite> _parent;

    /// <summary>
    /// Creates a new SitePublicCertificate.
    /// </summary>
    /// <param name="resourceName">Name of the SitePublicCertificate.</param>
    /// <param name="resourceVersion">Version of the SitePublicCertificate.</param>
    /// <param name="context">Provisioning context for this resource.</param>
    public SitePublicCertificate(string resourceName, string? resourceVersion = default, ProvisioningContext? context = default)
        : base(resourceName, "Microsoft.Web/sites/publicCertificates", resourceVersion, context)
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _blob = BicepValue<BinaryData>.DefineProperty(this, "Blob", ["properties", "blob"]);
        _kind = BicepValue<string>.DefineProperty(this, "Kind", ["kind"]);
        _publicCertificateLocation = BicepValue<PublicCertificateLocation>.DefineProperty(this, "PublicCertificateLocation", ["properties", "publicCertificateLocation"]);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _thumbprintString = BicepValue<string>.DefineProperty(this, "ThumbprintString", ["properties", "thumbprint"], isOutput: true);
        _parent = ResourceReference<WebSite>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Creates a reference to an existing SitePublicCertificate.
    /// </summary>
    /// <param name="resourceName">Name of the SitePublicCertificate.</param>
    /// <param name="resourceVersion">Version of the SitePublicCertificate.</param>
    /// <returns>The existing SitePublicCertificate resource.</returns>
    public static SitePublicCertificate FromExisting(string resourceName, string? resourceVersion = default) =>
        new(resourceName, resourceVersion) { IsExistingResource = true };
}
