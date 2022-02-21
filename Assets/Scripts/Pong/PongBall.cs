using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PongBall : MonoBehaviour
{
    [SerializeField] private Rigidbody2D mainRigidBody;
    [SerializeField] private float startSpeed;
    // Start is called before the first frame update
    void Start()
    {
        Restart();
    }

    void Restart()
    {
        mainRigidBody.position = Vector2.zero;
        mainRigidBody.velocity = Vector2.zero;

        StartCoroutine(Restart_ball());

        IEnumerator Restart_ball()
        {
            yield return new WaitForSeconds(1);

            Vector2 newVelocity = new Vector2(Random.Range(-5f, 5f), Random.Range(0f, 1f));
            mainRigidBody.velocity = newVelocity.normalized * startSpeed;
        }
    }
}
