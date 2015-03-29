﻿using MongoDB.Bson;
using ProjectConakry.DomainObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectConakry.DomainObjects
{
    public class Book : MongoEntity
    {
        public string ThumbNailImagePath { get; set; }
        public string BiggerThumbNailImagePath { get; set; }
        public string FullSizeImagePath { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public string ISBN { get; set; }
        public Sections SectionId { get; set; }
        public string StreamingURL{get; set;}


       
    }
}
