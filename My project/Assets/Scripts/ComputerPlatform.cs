using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class ComputerPlatform : Platform
{
    [SerializeField]
    GameObject gameManagerObject;

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    // POLYMORPHISM
    public override void Move()
    {
        GameObject ball = GameManager.instance.spawnedBall;
        base.Move();
        if (gameObject.transform.childCount == 1 && ball != null)
        {
            if (transform.position.y > ball.transform.position.y)
                transform.position -= transform.up * Time.deltaTime * speed;
            else
                transform.position += transform.up * Time.deltaTime * speed;
        }
        else
        {
            if (gameObject.transform.childCount <= 1)
                Debug.Log("No ball in contact");
            else
                StartCoroutine("WaitBeforeShooting");
        }
    }


    private IEnumerator WaitBeforeShooting()
    {
        yield return new WaitForSeconds(2.0f);
        ShootBall();
    }
}
