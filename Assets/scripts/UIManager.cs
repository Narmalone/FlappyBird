using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject GameOverPannel;

    public void Start()
    {
       GameOverPannel.SetActive(false);
        Time.timeScale = 1;
    }

    public void TriggerGameOver()
    {
        GameOverPannel.SetActive(true);
        Time.timeScale = 0;
    }

}
