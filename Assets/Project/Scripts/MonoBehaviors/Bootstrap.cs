using Project.Scripts.Data;
using Project.Scripts.Features;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Project.Scripts.MonoBehaviors
{
    public sealed class Bootstrap : MonoBehaviour
    {
        [SerializeField] private string _firstSceneName;
        [SerializeField] private GameSettingsData _gameSettings;
        private GameSystem _gameSystems;
        private Contexts _contexts;
        private SettingsContext _settingsContext;

        public GameSettingsData GameSettings => _gameSettings;
        public static bool IsQuitting { get; private set; }

        private void Awake()
        {
            Application.quitting += delegate
            {
                IsQuitting = true;
            };
            DoAwake();
        }

        private void DoAwake()
        {
            DontDestroyOnLoad(this);
            _contexts = Contexts.sharedInstance;
            _settingsContext = _contexts.settings;

            UnityEngine.Random.InitState((int)DateTime.Now.Ticks);

            LoadSettings();

            _gameSystems = new GameSystem(_contexts);
        }

        private void LoadSettings()
        {
            _settingsContext.SetGameSettings(_gameSettings);
        }

        private void Start()
        {
            _gameSystems.Initialize();
            SceneManager.LoadSceneAsync(_firstSceneName, LoadSceneMode.Additive);
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