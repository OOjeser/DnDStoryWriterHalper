﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace StoryWriterHalper.Models
{
    [XmlRoot("project")]
    public record class XMLProjectRootEllement
    {
        [XmlArray("items")]
        [XmlArrayItem("dirrectory", typeof(Dirrectory))]
        [XmlArrayItem("textpage", typeof(TextPage))]
        public ObservableCollection<object> Items { get; set; }
    }
}