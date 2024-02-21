﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    
    public class UserDetails
    {
        [BsonId] // This attribute indicates that this property maps to the _id field in the document
        public ObjectId Id { get; set; }


         [BsonElement("email")]
        public string Email { get; set; }
    }
}
