using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HealthUI : MonoBehaviour
{
    public GameObject player;
    private TextMeshProUGUI healthK;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        healthK = GetComponent<TextMeshProUGUI>();
        healthK.text = "Health: " + player.GetComponent<PlayerMovement>()._playerHealth.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        healthK.text = "Health: " + player.GetComponent<PlayerMovement>()._playerHealth.ToString();
        Debug.Log(player.GetComponent<PlayerMovement>()._playerHealth);   
    }
}
