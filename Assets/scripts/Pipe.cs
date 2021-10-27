using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    public float Speed;

    void Update()
    {
        transform.position -= Vector3.right * Speed * Time.deltaTime;
       
    }
}
