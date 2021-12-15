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
    //quand le jeu se lance
    private void Start()
    {
        GameStartPannel.SetActive(true);
        isStart = true;

        GameUiPannel.SetActive(false);

        GameOverPannel.SetActive(false);
    }

    //quand au menu il appuie sur jouer
    public void OnStart()
    {
        isStart = false;
        GameStartPannel.SetActive(false);
        GameUiPannel.SetActive(true);
    }

    //lorsque le joueur meurt
    public void OnDeath()
    {
        isStart = true;
        GameUiPannel.SetActive(false);
        GameOverPannel.SetActive(true);
    }

    //si le joueur relance la partie
    public void OnRestart()
    {
        isStart = false;
        SceneManager.LoadScene("jeu");
    }

    private void Update()
    {
        if (isStart == true)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }


}
