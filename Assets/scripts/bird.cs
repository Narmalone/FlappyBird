using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird : MonoBehaviour
{
    public float maxSpeedY_Up;
    public float maxSpeedY_Down;
    public float thrust_Force;
    public float fallSpeedY;
    public float SpeedX;


    private void Update()
    {
        Rigidbody2D _rigid = GetComponent<Rigidbody2D>();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.Rotate(0f, 0f, 700f);

            GetComponent<Rigidbody2D>().AddForce(Vector2.up * thrust_Force, ForceMode2D.Force);
        }

        if (_rigid.velocity.y > maxSpeedY_Up) 
        {
            _rigid.velocity = new Vector2(_rigid.velocity.x, maxSpeedY_Up);
        }

        if (_rigid.velocity.y < maxSpeedY_Down)
        {
            transform.Rotate(0f, 0f, -7f);
            _rigid.velocity = new Vector2(_rigid.velocity.x, maxSpeedY_Down);

        }

        //transform.rotation = Quaternion.Slerp(transform.rotation, fallSpeedY, Time.deltaTime * smooth);



    }
}

//OBSCURCIR LECRAN ET METTRE UN GAME OVER, CREER UNE UI MANAGER
