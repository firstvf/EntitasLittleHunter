using System.Diagnostics;
using DG.Tweening;
using Project.Scripts.ExtensionsMethods;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Project.Scripts.MonoBehaviors
{
    public class SplashScene : MonoBehaviour
    {
        private const string BOOTSTRAP_SCENE = "Bootstrap";

        [SerializeField] private GameObject _bootstrapGameObject;
        [SerializeField] private Image _logoImage;

        private readonly Stopwatch _stopWatch = new Stopwatch();
        private bool _isLoading;

        private void Awake()
        {
            _logoImage.SetAlpha(0f);
        }

        private void Start()
        {
            _logoImage.DOFade(1f, 1f).OnComplete(delegate
            {
                _stopWatch.Start();
                _bootstrapGameObject.SetActive(true);
                _stopWatch.Stop();

                float delay = Mathf.Max(0f, Mathf.Min(2f - _stopWatch.ElapsedMilliseconds, 2f));
                _logoImage.DOFade(0f, 1f).SetDelay(delay).OnComplete(OnLogoImageFadeOut);
            });
        }

        private void OnLogoImageFadeOut()
        {
            LoadSceneData();
        }

        private void LoadSceneData()
        {
            _isLoading = true;
            SceneManager.UnloadSceneAsync(BOOTSTRAP_SCENE);
        }
    }
}