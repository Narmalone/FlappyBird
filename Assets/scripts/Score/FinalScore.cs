using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class FinalScore : MonoBehaviour
{
    public Score score;

    private void Start()
    {
        GetComponent<TextMeshProUGUI>().text = score.myScore.ToString();
    }


}
