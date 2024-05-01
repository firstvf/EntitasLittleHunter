using Project.Scripts.Data;
using Project.Scripts.Features;
using UnityEngine;

namespace Project.Scripts.MonoBehaviors
{
    public sealed class Bootstrap : MonoBehaviour
    {
        [SerializeField] private string _firstSceneName;
        private GameSystem _gameSystems;
        private Contexts _contexts;
        

        public GameSettingsData GameSettings { get; }
        
        private void Start()
        {
            _contexts = Contexts.sharedInstance;
            _gameSystems = new GameSystem(_contexts);
            _gameSystems.Initialize();
        }

        private void Update()
        {
            _gameSystems.Execute();
            _gameSystems.Cleanup();
        }

        private void OnApplicationQuit()
            => _gameSystems.TearDown();
    }
}