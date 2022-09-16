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

    private float offset = 0.2f;
    public GameObject spawnedBall;

    public int playerScore, computerScore;

    public bool ballOutOfBounds = false;

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
        SpawnBall();
    }

    private void Update()
    {
        if (ballOutOfBounds)
            StartCoroutine("RestartRound");
    }

    public void SpawnBall()
    {
        Vector3 spawnPos = playerPlatform.transform.GetChild(0).transform.position;
        GameObject newBall = Instantiate(ball, new Vector3(spawnPos.x - offset, spawnPos.y), Quaternion.identity);
        newBall.transform.SetParent(playerPlatform.transform);
        spawnedBall = newBall;
    }

    private IEnumerator RestartRound()
    {
        yield return new WaitForSeconds(3.0f);
        ballOutOfBounds = false;
        SceneManager.LoadScene(0);
    }
}
