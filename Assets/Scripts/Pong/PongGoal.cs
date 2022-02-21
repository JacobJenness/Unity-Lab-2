using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PongGoal : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public event Action onScore;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            onScore?.Invoke();
        }
    }
}
