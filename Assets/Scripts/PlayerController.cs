using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D mainRigidBody;
    [SerializeField] private SpriteRenderer mainSpriteRenderer;
    [SerializeField] private float moveSpeed;
    
    void Update()
    {
        // For some reason, when the moveSpeed is multiplied by Time.deltaTime,
        // the player does not move in the x direction unless they are in the air.
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            mainSpriteRenderer.flipX = true;
            //mainRigidBody.AddForce(new Vector2(-moveSpeed * Time.deltaTime, 0));
            mainRigidBody.AddForce(new Vector2(-moveSpeed, 0));
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            mainSpriteRenderer.flipX = false;
            //mainRigidBody.AddForce(new Vector2(moveSpeed * Time.deltaTime, 0));
            mainRigidBody.AddForce(new Vector2(moveSpeed, 0));
        }
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.Space))
        {
            mainRigidBody.AddForce(new Vector2(0, 200));
        }
    }
}
