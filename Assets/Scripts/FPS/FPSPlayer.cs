using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSPlayer : MonoBehaviour
{
    [SerializeField] private Transform shootPosition;
    [SerializeField] private Transform head;
    [SerializeField] private GameObject[] bullets;
    [SerializeField] private AudioSource shootSound;
    //[SerializeField] private FPSUI fpsUI;
    [SerializeField] private int maxHealth;

    public static FPSPlayer instance;

    void Awake()
    {
        instance = this;
        Health = maxHealth;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    // Shoots a bullet on click
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject bulletPrefab = bullets[Random.Range(0, bullets.Length)];
            GameObject newBullet = Instantiate(bulletPrefab);
            newBullet.transform.SetPositionAndRotation(shootPosition.position, shootPosition.rotation);
            shootSound.Play();
        }
    }

    private int health;
    private int Health
    {
        get
        {
            return health;
        }
        set
        {
            health = value;
            //fpsUI.ShowHealthFraction((float)Health / (float)maxHealth);
            if(health <= 0)
            {
                LoadingScreen.LoadScene("MainMenu");
            }
        }
    }

    // Handles the player health after being hit by an enemy
    private float lastHitTime;
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.CompareTag("Enemy") && (Time.time - lastHitTime > 1f))
        {
            lastHitTime = Time.time;
            Destroy(hit.gameObject);
            if (Health > 0)
            {
                Health--;
            }
        }
    }

    private int enemyDefeatCount;
    public void HandleEnemyDefeat()
    {
        enemyDefeatCount++;
        //fpsUI.ShowEnemyDefeatCount(enemyDefeatCount);
    }

    // Determines if enemies should spawn depending on player position
    public bool ShouldSpawn(Vector3 pos)
    {
        Vector3 posDiff = pos - transform.position;
        Vector3 faceDirection = head.forward;
        float distanceFromPlayer = posDiff.magnitude;

        return (Vector3.Dot(posDiff.normalized, faceDirection) < 0.5f) && (distanceFromPlayer > 10f);
    }
}
