using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    private float posYLimit = 4.24f;
    public float speed = 10.0f;
    private float shootForce = 50.0f;

    public GameObject ball;

    public virtual void Move()
    {
        if (transform.position.y >= posYLimit)
            transform.position = new Vector3(transform.position.x, posYLimit, transform.position.z);
        if (transform.position.y <= -posYLimit)
            transform.position = new Vector3(transform.position.x, -posYLimit, transform.position.z);
    }

    public void ShootBall()
    {
        if (gameObject.transform.childCount == 1)
            return;
        GameObject ball = gameObject.transform.GetChild(1).gameObject;
        Vector2 shoot = new Vector2(100, Random.Range(-50.0f, 50.0f)) * shootForce * Time.deltaTime;
        Rigidbody2D rb = ball.GetComponent<Rigidbody2D>();
        rb.AddForce(shoot, ForceMode2D.Impulse);
        ball.transform.parent = null;
    }
}
