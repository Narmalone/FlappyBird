using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plafond : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D p_collision)
    {
        if (p_collision.GetComponent<bird>() != null)
        {
            Debug.Log("hey");
            p_collision.gameObject.SetActive(false);

        }
    }
}
