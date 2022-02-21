using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PongManager : MonoBehaviour
{
    [SerializeField] private GameObject ball;
    [SerializeField] private GameObject p1Goal;
    [SerializeField] private GameObject p2Goal;
    private static int Player1Score = 0;
    private static int Player2Score = 0;

    private void Awake()
    {
        //p1Goal.onScore += HandleP2Score;
        //p2Goal.onScore += HandleP1Score;
        //ball.Restart();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
