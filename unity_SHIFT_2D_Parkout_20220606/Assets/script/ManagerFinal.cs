using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using TMPro;
public class ManagerFinal : MonoBehaviour
{


    [SerializeField, Header("畫布")]
    private CanvasGroup groupfinal;
    [SerializeField, Header("遊戲結束標題")]
    private TextMeshProUGUI textfinal;



    public string stringTitle;

    private void Start()
    {
        textfinal.text = stringTitle;
         InvokeRepeating("FadeIn", 0, 0.2f);
    }

    private void FadeIn()
    {
        groupfinal.alpha += 0.1f;
        if (groupfinal.alpha >= 1)
        {
            groupfinal.interactable = true;
            groupfinal.blocksRaycasts = true;
            CancelInvoke("FadeIn");
        }


    }

    public void  Quit()
    {
        Application.Quit();
    }


    public void Replay() {

        SceneManager.LoadScene("遊戲場景");
    }
}
