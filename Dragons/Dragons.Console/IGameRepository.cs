﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dragons.Common
{
    interface IGameRepository
    {
        Task<List<Reservation>> GetReservationsAsync();
        Task<Reservation> InsertReservationAsync(Reservation reservation);
        Task<GameState> GetGameSateAsync(Guid playerId);
        Task<GameState> InsertGameStateAsync(GameState gameState);
        Task<GameState> UpdateGameStateAsync(GameState gameState);
        Task<Tuple<InitialSetup,InitialSetup>> GetRandomInitialSetupsAsync();
    }
}
