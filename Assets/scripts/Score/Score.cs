using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int myScore;

    private void Start()
    {
        myScore = 0;
    }

    public void addScore() 
    {

        myScore++;
        GetComponent<TextMeshProUGUI>().text = myScore.ToString();

    }
}
//CREER GAME SCENE MANAGER POUR LE RESTART ETC...//