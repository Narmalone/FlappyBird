using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class UIManager : MonoBehaviour
{
    public GameObject GameOverPannel;

    public GameObject GameStartPannel;

    public GameObject GameUiPannel;


    public bool isStart;
    private void Start()
    {
        GameStartPannel.SetActive(true);
        isStart = true;

        GameUiPannel.SetActive(false);

        GameOverPannel.SetActive(false);
    }


    public void OnStart()
    {
        isStart = false;
        GameStartPannel.SetActive(false);
        GameUiPannel.SetActive(true);
    }

    public void OnDeath()
    {
        isStart = true;
        GameUiPannel.SetActive(false);
        GameOverPannel.SetActive(true);
    }

    public void OnRestart()
    {
        isStart = false;
        SceneManager.LoadScene("jeu");
    }

    private void Update()
    {
        if(isStart == true)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }


}
