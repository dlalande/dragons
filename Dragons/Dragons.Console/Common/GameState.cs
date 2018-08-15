﻿using System;
using System.Collections.Generic;

namespace Dragons.Common
{
    public class GameState
    {
        public GameState()
        {
            Events = new List<Event>();
            Moves = new Stack<Move>();
        }

        public Player Player1 { get; set; }
        public Player Player2 { get; set; }
        public List<Event> Events { get; set; }
        public Stack<Move> Moves { get; set; }

        public Game ToGame(Guid playerId)
        {
            var player = Player1.PlayerId.Equals(playerId) ? Player1 : Player2;
            var game = new Game
            {
                Name = player.Name,
                Board = player.Board,
                Mana = player.Mana,
                Opponent = !Player1.PlayerId.Equals(playerId) ? Player1.Name : Player2.Name,
                Spells = Spell.AllSpells()
            };
            return game;
        }
    }
}
