using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBehaviour : MonoBehaviour
{
    // ABSTRACTION
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(Tags.playerSideTag))
        {
            GameManager.instance.computerScore++;
            GameManager.instance.ballOutOfBounds = true;
            GameManager.instance.computerLead = true;
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag(Tags.computerSideTag))
        {
            GameManager.instance.playerScore++;
            GameManager.instance.ballOutOfBounds = true;
            GameManager.instance.playerLead = true;
            Destroy(gameObject);
        }
    }
    
}
