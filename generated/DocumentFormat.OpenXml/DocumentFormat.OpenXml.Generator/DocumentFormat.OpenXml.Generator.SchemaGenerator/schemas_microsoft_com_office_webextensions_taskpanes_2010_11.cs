﻿// <auto-generated/>

// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Office2013.WebExtension;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using DocumentFormat.OpenXml.Validation.Semantic;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Office2013.WebExtentionPane
{
    /// <summary>
    /// <para>Defines the Taskpanes Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wetp:taskpanes.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.WebExtentionPane.WebExtensionTaskpane" /> <c>&lt;wetp:taskpane></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("wetp:taskpanes")]
    public partial class Taskpanes : TypedOpenXmlPartRootElement
    {
        /// <summary>
        /// Initializes a new instance of the Taskpanes class.
        /// </summary>
        public Taskpanes() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Taskpanes class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Taskpanes(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Taskpanes class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Taskpanes(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Taskpanes class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Taskpanes(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("wetp:taskpanes");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Office2013.WebExtentionPane.WebExtensionTaskpane>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.WebExtentionPane.WebExtensionTaskpane), 0, 0, version: FileFormatVersions.Office2013)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Taskpanes>(deep);

        internal Taskpanes(WebExTaskpanesPart ownerPart) : base(ownerPart)
        {
        }

        /// <summary>
        /// Loads the DOM from the WebExTaskpanesPart
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to be loaded.</param>
        public void Load(WebExTaskpanesPart openXmlPart)
        {
            LoadFromPart(openXmlPart);
        }

        /// <summary>
        /// Saves the DOM into the WebExTaskpanesPart.
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to save to.</param>
        public void Save(WebExTaskpanesPart openXmlPart)
        {
            base.SaveToPart(openXmlPart);
        }

        /// <summary>
        /// Gets the WebExTaskpanesPart associated with this element.
        /// </summary>
        public WebExTaskpanesPart? WebExTaskpanesPart
        {
            get => OpenXmlPart as WebExTaskpanesPart;
            internal set => OpenXmlPart = value;
        }
    }

    /// <summary>
    /// <para>Defines the WebExtensionPartReference Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wetp:webextensionref.</para>
    /// </summary>
    [SchemaAttr("wetp:webextensionref")]
    public partial class WebExtensionPartReference : TypedOpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the WebExtensionPartReference class.
        /// </summary>
        public WebExtensionPartReference() : base()
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: r:id</para>
        /// </summary>
        /// <remark>
        /// xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
        /// </remark>
        [SchemaAttr("r:id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("wetp:webextensionref");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddElement<WebExtensionPartReference>()
                .AddAttribute("r:id", a => a.Id, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                });
            builder.AddConstraint(new RelationshipExistConstraint(builder.CreateQName("r:id")) { Application = ApplicationType.Word | ApplicationType.Excel, Version = FileFormatVersions.Office2013 });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<WebExtensionPartReference>(deep);
    }

    /// <summary>
    /// <para>Defines the OfficeArtExtensionList Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wetp:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Extension" /> <c>&lt;a:ext></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("wetp:extLst")]
    public partial class OfficeArtExtensionList : TypedOpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the OfficeArtExtensionList class.
        /// </summary>
        public OfficeArtExtensionList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the OfficeArtExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public OfficeArtExtensionList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OfficeArtExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public OfficeArtExtensionList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OfficeArtExtensionList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public OfficeArtExtensionList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("wetp:extLst");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Extension>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Group, 1, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Extension), 0, 0)
                    }
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<OfficeArtExtensionList>(deep);
    }

    /// <summary>
    /// <para>Defines the WebExtensionTaskpane Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wetp:taskpane.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.WebExtentionPane.OfficeArtExtensionList" /> <c>&lt;wetp:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.WebExtentionPane.WebExtensionPartReference" /> <c>&lt;wetp:webextensionref></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("wetp:taskpane")]
    public partial class WebExtensionTaskpane : TypedOpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the WebExtensionTaskpane class.
        /// </summary>
        public WebExtensionTaskpane() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the WebExtensionTaskpane class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public WebExtensionTaskpane(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the WebExtensionTaskpane class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public WebExtensionTaskpane(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the WebExtensionTaskpane class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public WebExtensionTaskpane(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>dockstate, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: dockstate</para>
        /// </summary>
        [SchemaAttr("dockstate")]
        public StringValue? DockState
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visibility, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: visibility</para>
        /// </summary>
        [SchemaAttr("visibility")]
        public BooleanValue? Visibility
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>width, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: width</para>
        /// </summary>
        [SchemaAttr("width")]
        public DoubleValue? Width
        {
            get => GetAttribute<DoubleValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>row, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: row</para>
        /// </summary>
        [SchemaAttr("row")]
        public UInt32Value? Row
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>locked, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: locked</para>
        /// </summary>
        [SchemaAttr("locked")]
        public BooleanValue? Locked
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("wetp:taskpane");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Office2013.WebExtentionPane.OfficeArtExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.WebExtentionPane.WebExtensionPartReference>();
            builder.AddElement<WebExtensionTaskpane>()
                .AddAttribute("dockstate", a => a.DockState, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("visibility", a => a.Visibility, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("width", a => a.Width, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("row", a => a.Row, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("locked", a => a.Locked);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.WebExtentionPane.WebExtensionPartReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.WebExtentionPane.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2013)
            };
        }

        /// <summary>
        /// <para>WebExtensionPartReference.</para>
        /// <para>Represents the following element tag in the schema: wetp:webextensionref.</para>
        /// </summary>
        /// <remark>
        /// xmlns:wetp = http://schemas.microsoft.com/office/webextensions/taskpanes/2010/11
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.WebExtentionPane.WebExtensionPartReference? WebExtensionPartReference
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.WebExtentionPane.WebExtensionPartReference>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>OfficeArtExtensionList.</para>
        /// <para>Represents the following element tag in the schema: wetp:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:wetp = http://schemas.microsoft.com/office/webextensions/taskpanes/2010/11
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.WebExtentionPane.OfficeArtExtensionList? OfficeArtExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.WebExtentionPane.OfficeArtExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<WebExtensionTaskpane>(deep);
    }
}