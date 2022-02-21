using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PongPaddle : MonoBehaviour
{
    [SerializeField] private KeyCode upKey;
    [SerializeField] private KeyCode downKey;
    [SerializeField] private Rigidbody2D rigidBody;
    [SerializeField] private float moveSpeed;
    private float boundY;

    // Update is called once per frame
    void Update()
    {
        moveSpeed = 10f;
        var velocity = rigidBody.velocity;
        if (Input.GetKey(upKey))
        {
            velocity.y = moveSpeed;
        }
        else if (Input.GetKey(downKey))
        {
            velocity.y = -moveSpeed;
        }
        else
        {
            velocity.y = 0;
        }
        rigidBody.velocity = velocity;

        var position = transform.position;
        boundY = 3.5f;
        if (position.y > boundY)
        {
            position.y = boundY;
        } 
        else if (position.y < -boundY) {
            position.y = -boundY;
        }
        transform.position = position;
    }
}
