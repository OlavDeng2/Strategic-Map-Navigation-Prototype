using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class City : MonoBehaviour {
    [Header("UI")]
    public TextMesh cityNameText;
    public string cityName;

	// Use this for initialization
	void Start () {

        cityName = this.name;
        cityNameText.text = cityName;

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Player")
        {
            LevelManager.levelManager.LoadCity(cityName);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.name == "Player")
        {
        }
    }
}