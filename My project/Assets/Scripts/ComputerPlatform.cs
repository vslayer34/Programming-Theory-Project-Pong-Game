using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerPlatform : Platform
{
    [SerializeField]
    GameObject gameManagerObject;

    float errorMargin = 0.1f;

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    public override void Move()
    {
        GameObject ball = GameManager.instance.spawnedBall;
        base.Move();
        if (transform.position.y > ball.transform.position.y)
            transform.position -= transform.up * Time.deltaTime * speed;
        else
            transform.position += transform.up * Time.deltaTime * speed;
    }
}
