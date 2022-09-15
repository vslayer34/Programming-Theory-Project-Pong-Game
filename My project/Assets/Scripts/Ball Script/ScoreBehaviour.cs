using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBehaviour : MonoBehaviour
{
    [SerializeField]
    GameObject player, computer;

    private PlayerPlatform playerScript;
    private ComputerPlatform computerScript;

    private void Start()
    {
        playerScript = player.GetComponent<PlayerPlatform>();
        computerScript = computer.GetComponent<ComputerPlatform>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(Tags.playerSideTag))
        {
            computerScript.score++;
            Debug.Log(computerScript.score);
        }
        if (collision.gameObject.CompareTag(Tags.computerSideTag))
        {
            playerScript.score++;
            Debug.Log(playerScript.score);
        }
    }
}
