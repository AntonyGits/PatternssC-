﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Labirint
{
    [XmlRoot("LabirintProperties")] 
    public class Properties
    {
        private string mazeStyle;

        [XmlAttribute("MAZESTYLE")]
        public string MAZESTYLE
        {
            get { return mazeStyle; }
            set { mazeStyle = value; }
        }
    }
}
