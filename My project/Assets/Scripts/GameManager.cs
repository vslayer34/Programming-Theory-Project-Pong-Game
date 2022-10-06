using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [SerializeField]
    private GameObject playerPlatform;
    [SerializeField]
    private GameObject computerPlatform;
    [SerializeField]
    private GameObject ball;

    public GameObject spawnedBall;

    public int playerScore, computerScore;

    public bool ballOutOfBounds = false;
    public bool playerLead, computerLead;

    private void Awake()
    {
        if (instance == null)
            instance = this;
    }

    private void Start()
    {
        Debug.Log("Game Manager is Active");
        playerScore = 0;
        computerScore = 0;
        playerLead = true;
        SpawnBall(playerPlatform);
    }

    private void Update()
    {
        if (ballOutOfBounds)
            StartCoroutine("RestartRound");
    }

    public void SpawnBall(GameObject platform)
    {
        Vector3 spawnPos = platform.transform.GetChild(0).transform.position;
        GameObject newBall = Instantiate(ball, new Vector3(spawnPos.x, spawnPos.y), Quaternion.identity);
        newBall.transform.SetParent(platform.transform);
        spawnedBall = newBall;
        ballOutOfBounds = false;
        playerLead = false;
        computerLead = false;
    }

    // ABSTRACTION
    private IEnumerator RestartRound()
    {
        yield return new WaitForSeconds(2.0f);
        //ballOutOfBounds = false;
        playerPlatform.transform.position = new Vector2(8.08f, 0);
        computerPlatform.transform.position = new Vector2(-8.08f, 0);
        if (playerLead)
            SpawnBall(playerPlatform);
        else if (computerLead)
            SpawnBall(computerPlatform);
    }
}
