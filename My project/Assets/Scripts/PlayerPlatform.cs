using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPlatform : Platform
{
    [SerializeField]
    GameObject holdArea;
    private float movementY;

    // Update is called once per frame
    void Update()
    {
        Move();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (gameObject.transform.childCount <= 1)
                Debug.Log("No ball in contact");
            else
                ShootBall();
        }
    }

    public override void Move()
    {
        base.Move();
        movementY = Input.GetAxisRaw("Vertical");
        transform.position += new Vector3(0, movementY) * Time.deltaTime * speed;
    }
}
