using UnityEngine;
using UnityEngine.UI;

public class WinScreen : MonoBehaviour
{
 [SerializeField]
 private Text WinnerText;
 [SerializeField]
 private Animator animator;
 [SerializeField]
 private string showAnimationName = "Show";
 [SerializeField]
 private string hideAnimationName = "Hidden";
public void ShowWinScreen(string winnerName)
    {
        WinnerText.text = winnerName + "Wins!";
        animator.Play(showAnimationName, 0, 0f);
    }
    public void HideWinScreen()
    {
        animator.Play(hideAnimationName, 0, 0f);
    }
}
