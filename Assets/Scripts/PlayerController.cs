using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D mainRigidBody;
    [SerializeField] private SpriteRenderer mainSpriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // mainRigidBody.AddForce(new Vector2(-moveSpeed * Time.deltaTime, 0));
    }
}
