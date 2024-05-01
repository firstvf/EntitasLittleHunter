using System;
using UnityEngine;

namespace Project.Scripts.Data
{
    [CreateAssetMenu(fileName = ("Assets/Data/Settings/NewGameSettings"), menuName = "EntitasLittleHunter/Data/Settings/Game", order = 0)]
    public class GameSettingsData : ScriptableObject
    {
        [Header("Game Settings")]
        public string GameVersion;
        public int BuildNumber;
        [Header("Multiplayer Settings"), Space(2f)]
        public NetworkPreset NetworkConfig;

        [Serializable]
        public class NetworkPreset
        {
            public int MaxNumbersOfPlayers;
            public string RoomSceneName;
        }
    }
}