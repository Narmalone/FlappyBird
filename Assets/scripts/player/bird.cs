using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird : MonoBehaviour
{
    public float maxSpeedY_Up;
    public float maxSpeedY_Down;
    public float thrust_Force;
    public float fallSpeedY;
    public float fallSpeedMax;
    public float goUp;

    private void Update()
    {
        //assisgn Rbody
        Rigidbody2D _rigid = GetComponent<Rigidbody2D>();
        transform.Rotate(0f, 0f, fallSpeedY * Time.deltaTime);


        if (fallSpeedY>fallSpeedMax)
        {
            fallSpeedY = fallSpeedMax;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //transform.Rotate(0f, 0f, goUp);
            //transform.rotation = Quaternion.Slerp(transform.rotation, fallSpeedY, Time.deltaTime);


            GetComponent<Rigidbody2D>().AddForce(Vector2.up * thrust_Force, ForceMode2D.Force);
        }

        //secu velocity

        if (_rigid.velocity.y > maxSpeedY_Up) 
        {
            _rigid.velocity = new Vector2(_rigid.velocity.x, maxSpeedY_Up);

        }

        if (_rigid.velocity.y < maxSpeedY_Down)
        {
            _rigid.velocity = new Vector2(_rigid.velocity.x, maxSpeedY_Down);

        }




    }
}