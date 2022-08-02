﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using DnDStoryWriterHalper.ViewModels;

namespace DnDStoryWriterHalper.Models;


public class Dirrectory : ViewModelBase, IDirrectory 
{
    [XmlElement("name")]
    public string Name { get; set; }
    [XmlArray("content")]
    [XmlArrayItem("dirrectory", typeof(Dirrectory))]
    [XmlArrayItem("textpage", typeof(TextPage))]
    public ObservableCollection<object> Content { get; set; }



    [XmlIgnore]
    public string NameProperty
    {
        get => Name;
        set
        {
            Name = value;
            OnPropertyChanged();
        }
    }

    [XmlIgnore]
    public ObservableCollection<object> ContentProperty
    {
        get => Content;
        set
        {
            Content = value;
            OnPropertyChanged();
        }
    }

    public Dirrectory(string name)
    {
        Name = name;
        Content = new ObservableCollection<object>();
    }

    public Dirrectory() : this("Новая Директория"){}
}

