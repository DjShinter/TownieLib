using Game.Services;
using Game.Simulation;
using HarmonyLib;
using Server.Shared.State;
using Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace TownieLib
{
    /// <summary>
    /// <c>Service</c> Service is widely used for a lot of the TownOfSalem 2 matches/games.
    /// </summary>
    public static partial class TownieApi
    {
        /// <summary>
        /// Gets Field <c>SimulationService</c> SimulationService is widely used for a lot of the TownOfSalem 2 matches/games.
        /// </summary>
        public static SimulationService SimulationService
        {
            get
            {
                SimulationService simService = Traverse.Create(Service.Game).Field("_gameSimulationService").GetValue<SimulationService>();
                return simService;
            }
        }

        /// <summary>
        /// Gets Field <c>GameSimulation</c> GameSimulation is widely used for a lot of the TownOfSalem 2 matches/games.
        /// </summary>
        public static GameSimulation GameSimulation
        {
            get
            {
                GameSimulation gameSimulation = Traverse.Create(SimulationService).Field("_gameSimulation").GetValue<GameSimulation>();
                return gameSimulation;
            }
        }

        /// <summary>
        /// Gets Field <c>GameSimulation</c> GamePhase is widely used for a lot of the TownOfSalem 2 matches/games.
        /// </summary>
        public static GamePhase GamePhase
        {
            get
            {

                GamePhase gamePhase = Traverse.Create(GameSimulation).Field("m_currentGamePhase").GetValue<GamePhase>();
                return gamePhase;
            }

        }

        public static CastService CastService
        {
            get
            {
                CastService cast = Traverse.Create(GameSimulation).Field("_cast").GetValue<CastService>();
                return cast;
            }
        }
    }

}
