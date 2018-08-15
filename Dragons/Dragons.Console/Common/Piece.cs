﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Dragons.Common
{
    public class Piece
    {
        public Piece()
        {
            Coordinate = new Coordinate();
            Type = PieceType.Map;
        }

        public Coordinate Coordinate { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public PieceType Type { get; set; }

        public int Orientation { get; set; }
    }
}
