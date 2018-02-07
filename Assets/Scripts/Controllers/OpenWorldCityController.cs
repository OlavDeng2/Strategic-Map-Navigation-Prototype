using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenWorldCityController : MonoBehaviour {

    [Header("UI")]
    public TextMesh cityNameText;

    [Header("City Data")]
    public string cityName;
    public City.Nationality cityNationality;

    public City city;

    // Use this for initialization
    void Start()
    {
        cityNameText.text = cityName;
        city = new City(cityName, cityNationality);

        print(cityName);
        print(cityNationality.ToString());
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // if it is player, enter the city
        if (collision.name == "Player")
        {
            LevelManager.levelManager.SetCurrentCity(city);
            LevelManager.levelManager.EnterCity(cityName);
        }
    }
}
