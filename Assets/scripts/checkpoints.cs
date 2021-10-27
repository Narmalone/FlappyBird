using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpoints : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D p_collision)
    {
        if(p_collision.GetComponent<bird>()!= null)
        {
            FindObjectOfType<Score>().addScore();
            Debug.Log("score");
        }
    }
}
