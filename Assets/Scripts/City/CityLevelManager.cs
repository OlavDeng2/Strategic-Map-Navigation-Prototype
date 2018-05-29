using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CityLevelManager : MonoBehaviour {

    private City currentCity;
    private string currentCityName;
    private City.Nationality currentCityNationality;

    [Header("UI")]
    public Text currentCityText;
    public Text cityNationalityText;

	// Use this for initialization
	void Start () {
        currentCity = LevelManager.levelManager.GetCurrentCity();
        InitializeCityData();
        InitializeUI();
    }

    private void OnDestroy()
    {
        print("Leaving city");
        LevelManager.levelManager.SetCurrentCity(null);
    }

    private void InitializeCityData()
    {
        currentCityName = currentCity.cityName;
        currentCityNationality = currentCity.cityNationality;
    }

    private void InitializeUI()
    {
        currentCityText.text = currentCityName;
        cityNationalityText.text = currentCityNationality.ToString();
    }

}
