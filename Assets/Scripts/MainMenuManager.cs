using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour
{
    [SerializeField] private Button startButton;
    [SerializeField] private Button openCreditsButton;
    [SerializeField] private Button closeCreditsButton;
    [SerializeField] private Button platformerButton;
    [SerializeField] private Button threeDSpawnButton;
    [SerializeField] private Button pongButton;
    [SerializeField] private Button FPSButton;
    [SerializeField] private GameObject creditsUI;

    void Awake()
    {
        Cursor.lockState = CursorLockMode.None;
        startButton.onClick.AddListener(() => LoadingScreen.LoadScene("GameScene"));
        platformerButton.onClick.AddListener(() => LoadingScreen.LoadScene("NotQuitePlatformer"));
        threeDSpawnButton.onClick.AddListener(() => LoadingScreen.LoadScene("3DSpawn"));
        pongButton.onClick.AddListener(() => LoadingScreen.LoadScene("Pong"));
        FPSButton.onClick.AddListener(() => LoadingScreen.LoadScene("FPS"));

        openCreditsButton.onClick.AddListener(() => { creditsUI.SetActive(true); });
        closeCreditsButton.onClick.AddListener(() => { creditsUI.SetActive(false); });
    }
}
