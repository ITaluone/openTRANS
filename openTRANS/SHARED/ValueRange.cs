﻿using System.Xml.Serialization;
using static openTRANS.Common;

namespace openTRANS
{
    public class ValueRange
    {
        [XmlElement("STARTVALUE", Namespace = Namespace.bmecat)]
        public Interval StartValue = new Interval();

        [XmlElement("ENDVALUE", Namespace = Namespace.bmecat)]
        public Interval EndValue = new Interval();

        [XmlElement("INTERVALVALUE", Namespace = Namespace.bmecat)]
        public decimal IntervalNumber;
    }
}