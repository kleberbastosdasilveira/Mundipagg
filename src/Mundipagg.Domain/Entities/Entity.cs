using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mundipagg.Domain.Entities
{
    public abstract class Entity
    {
        protected Entity()
        {
            Id = ObjectId.GenerateNewId();
        }

        public ObjectId Id { get; set; }
    }
}
