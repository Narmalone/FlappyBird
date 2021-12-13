using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleporter : MonoBehaviour
{
    public float RangePipes;
    private void OnTriggerEnter2D(Collider2D p_collision)
    {
        if(p_collision.GetComponent<Pipe>()!= null)
        {
            p_collision.transform.position = new Vector3(RangePipes, p_collision.transform.position.y, 0f);
            print("teleporter le pipe");
        }
    }
}
