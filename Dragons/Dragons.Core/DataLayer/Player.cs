﻿using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;

namespace Dragons.Core
{
    /// <summary>
    /// Represents the player information.
    /// </summary>
    [BsonIgnoreExtraElements]
    public class Player
    {
        /// <summary>
        /// Id of player. Use a GUID or equivalent.
        /// </summary>
        [BsonId]
        [BsonRequired]
        [Required]
        public string PlayerId { get; set; }

        /// <summary>
        /// Name of player. 
        /// </summary>
        [BsonElement]
        [BsonRequired]
        [Required]
        public string Name { get; set; }
    }
}
