using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreUI : MonoBehaviour
{
    public GameObject player;
    private TextMeshProUGUI ScoreK;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("GameManager");
        Debug.Log("player = " + player);
        ScoreK = GetComponent<TextMeshProUGUI>();
        //ScoreK.text = "Score: " + player.GetComponent<PlayerMovement>()._playerScore.ToString();
        ScoreK.text = "Score: " + player.GetComponent<GameManage>()._playerScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        //ScoreK.text = "Score: " + player.GetComponent<PlayerMovement>()._playerScore.ToString();
        ScoreK.text = "Score: " + player.GetComponent<GameManage>()._playerScore.ToString();
    }
}
