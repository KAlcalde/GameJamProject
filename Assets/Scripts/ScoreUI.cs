using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreUI : MonoBehaviour
{
    public GameManage gameManager;
    private TextMeshProUGUI ScoreK;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManage>();
        ScoreK = GetComponent<TextMeshProUGUI>();
        ScoreK.text = "Score: " + gameManager._playerScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        ScoreK.text = "Score: " + gameManager._playerScore.ToString();
    }
}
