using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{


    public int myScore;

    public void addScore() 
    {

        myScore++;
        GetComponent<TextMeshProUGUI>().text = myScore.ToString();

        Debug.Log(myScore);
    }
}
//CREER GAME SCENE MANAGER POUR LE RESTART ETC...//