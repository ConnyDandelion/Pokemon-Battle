using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.Events;

public class Timer : MonoBehaviour
{
   [SerializeField]
   private SecondData[] secondsData;
   [SerializeField]
   private Image timerImage;
   [SerializeField]
   private string timerAnimationName;
   [SerializeField]
   private UnityEvent onTimeEnd;
   private Animator timerAnimator;
   private Coroutine timerCoroutine;

   private void Awake()
    {
        timerAnimator = timerImage.GetComponent<Animator>();
    }

    public void StartTimer(int duration)
    {
        if (timerCoroutine != null)
        {
            StopCoroutine(timerCoroutine);
        }
        timerCoroutine = StartCoroutine(TimerCoroutine(duration));
    }
    private IEnumerator TimerCoroutine(int duration)
    {
        for (int i = 0; i < duration; i++)
        {
            SoundManager.instance.Play(secondsData[1].soundName);
            timerImage.sprite = secondsData[1].image;
            timerAnimator.Play(timerAnimationName, 0, 0f);
            yield return new WaitForSeconds(1f);
        }
        onTimeEnd?.Invoke();
    }

    public void StopTimer()
    {
        if (timerCoroutine != null)
        {
            StopCoroutine(timerCoroutine);
            timerCoroutine = null;
        }
    }

}

[System.Serializable]
public class SecondData
{
    public string soundName;
    public Sprite image;
}
