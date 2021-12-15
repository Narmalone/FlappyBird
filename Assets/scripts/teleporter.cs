using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleporter : MonoBehaviour
{
    public float RangePipes;
    

    //get col pipe et tp par transform
    public void OnTriggerEnter2D(Collider2D p_collision)
    {
        print(p_collision.GetComponent<Pipe>());

        if (p_collision.GetComponent<Pipe>()!= null)
        {
            p_collision.transform.position = new Vector3(RangePipes, p_collision.transform.position.y, 0f);
            print("teleporter le pipe");
        }

    }
}
