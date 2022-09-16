using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreDisplay : MonoBehaviour
{
    [SerializeField]
    GameObject playerGameObject, computerGameObject;

    [SerializeField]
    GameObject playerTextGameObject, computerTextGameObject;

    private TextMeshProUGUI playerTextField, computerTextField;
    private PlayerPlatform playerPlatformScript;
    private ComputerPlatform ComputerPlatformScript;

    private void Start()
    {
        playerTextField = playerTextGameObject.GetComponent<TextMeshProUGUI>();
        computerTextField = computerTextGameObject.GetComponent<TextMeshProUGUI>();
        playerPlatformScript = playerGameObject.GetComponent<PlayerPlatform>();
        ComputerPlatformScript = computerGameObject.GetComponent<ComputerPlatform>();
    }

    private void Update()
    {
        UpdateScore();
    }

    void UpdateScore()
    {
        playerTextField.text = GameManager.instance.playerScore.ToString();
        computerTextField.text = GameManager.instance.computerScore.ToString();
    }
}
