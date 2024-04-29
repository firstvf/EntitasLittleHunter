using UnityEngine;

public sealed class Bootstrap : MonoBehaviour
{
    private GameSystem _gameSystems;

    private void Start()
    {
        Contexts contexts = Contexts.sharedInstance;
        _gameSystems = new GameSystem(contexts);
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