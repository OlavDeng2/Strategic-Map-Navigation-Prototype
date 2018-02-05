using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenWorldCityController : MonoBehaviour {

    [Header("UI")]
    public TextMesh cityNameText;
    public string cityName;

    // Use this for initialization
    void Start()
    {

        cityName = this.name;
        cityNameText.text = cityName;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Player")
        {
            LevelManager.levelManager.EnterCity(cityName);
        }
    }
}
