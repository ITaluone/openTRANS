﻿using System;
using System.Xml.Serialization;

namespace openTRANS
{
    public partial class Agreement
    {
        [XmlElement("AGREEMENT_ID")]
        public string AgreementId;

        [XmlElement("AGREEMENT_END_DATE")]
        public DateTime AgreementEndDate;
    }
}
