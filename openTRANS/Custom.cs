﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace openTRANS
{
    /// <summary>
    /// Some custom additions which do not belong to the original definitions, but were requested by several people
    /// </summary>
    public partial class Address
    {
        [XmlElement("NAME2", Namespace = Common.Namespace.custom)]
        public string Name2;

        [XmlElement("NAME3", Namespace = Common.Namespace.custom)]
        public string Name3;

    }

    /// <summary>
    /// Not in original definition, but often used
    /// </summary>
    public static partial class OpenTransRemark
    {
        public const string NotesForSupplier = "NotesForSupplier";
     
        /// <summary>
        /// Similar to CustomerOrderReference.OrderId
        /// </summary>
        public const string InternalOrderId = "InternalOrderId";

        public const string InternalSupplierId = "InternalSupplierId";
        public const string InternalOrderCommission = "InternalOrderCommission";
        public const string Delivery = "Delivery";
    }

    /// <summary>
    /// Not in original definition, but often used
    /// </summary>
    public static partial class OpenTransFeature
    {
        public const string ColorCodeInside = "ColorCodeInside";
        public const string ColorCodeOutside = "ColorCodeOutside";
        public const string Length = "Length";
        public const string Width = "Width";
        public const string Height = "Height";
        public const string MaterialGroup = "MaterialGroup";
    }
}
