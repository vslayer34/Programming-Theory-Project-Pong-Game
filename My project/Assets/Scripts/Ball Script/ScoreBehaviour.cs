using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBehaviour : MonoBehaviour
{  
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(Tags.playerSideTag))
        {
            GameManager.instance.computerScore++;
        }
        if (collision.gameObject.CompareTag(Tags.computerSideTag))
        {
            GameManager.instance.playerScore++;
        }
    }
    
}
