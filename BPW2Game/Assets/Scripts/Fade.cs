using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Fade : MonoBehaviour
{
    private Image image;

        [SerializeField] private float delay, time;

        public LeanTweenType EaseType;

        private void Awake()
        {
            image = GetComponent<Image>();
            Color color = image.color;
            image.color = new Color(color.r, color.g, color.b, 0);
        }

        public IEnumerator StartFade()
        {
            LeanTween.alpha(image.rectTransform, 1, time).setEase(EaseType).setDelay(delay).setIgnoreTimeScale(true);
            
           yield return new WaitForSeconds(time + delay);
            SceneManager.LoadSceneAsync(1);
        }
}
