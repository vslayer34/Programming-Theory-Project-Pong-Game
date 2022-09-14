using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPlatform : Platform
{
    [SerializeField]
    GameObject holdArea;
    private float movementY;
    // Start is called before the first frame update
    void Start()
    {
        //SpawnBall();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        if (Input.GetKeyDown(KeyCode.Space))
        {
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
