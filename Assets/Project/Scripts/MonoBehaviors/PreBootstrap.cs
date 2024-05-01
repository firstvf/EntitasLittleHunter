using UnityEngine;

namespace Project.Scripts.MonoBehaviors
{
    public sealed class PreBootstrap : MonoBehaviour
    {
        [SerializeField] private GameObject _splashScene;

        private void Awake()
            => BootstrapStart();

        private void BootstrapStart()
        {
            _splashScene.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}