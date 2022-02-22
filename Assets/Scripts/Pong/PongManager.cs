using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PongManager : MonoBehaviour
{
    [SerializeField] private GameObject ball;
    [SerializeField] private GameObject p1Goal;
    [SerializeField] private GameObject p2Goal;
    [SerializeField] private TMP_Text p1ScoreText;
    [SerializeField] private TMP_Text p2ScoreText;
    [SerializeField] private TMP_Text winText;
    [SerializeField] private GameObject winTextObject;
    private static int Player1Score = 0;
    private static int Player2Score = 0;
    private int winCondition = 5;

    void Start()
    {
        p1ScoreText.text = Player1Score.ToString();
        p2ScoreText.text = Player2Score.ToString();
    }

    public void Player1Scored()
    {
        Player1Score++;
        p1ScoreText.text = Player1Score.ToString();
        if(Player1Score >= winCondition)
        {
            winText.text = "Player 1 Wins!";
            StartCoroutine(RestartGame());
        }
        ResetPosition();
    }

    public void Player2Scored()
    {
        Player2Score++;
        p2ScoreText.text = Player2Score.ToString();
        if (Player2Score >= winCondition)
        {
            winText.text = "Player 2 Wins!";
            StartCoroutine(RestartGame());
        }
        ResetPosition();
    }

    private void ResetPosition()
    {
        ball.GetComponent<PongBall>().Restart();
    }

    IEnumerator RestartGame()
    {
        winTextObject.SetActive(true);
        yield return new WaitForSeconds(3);
        Player1Score = 0;
        Player2Score = 0;
        LoadingScreen.LoadScene("Pong");
    }
}
