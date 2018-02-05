using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CityLevelManager : MonoBehaviour {

    private string currentCity;

    public Text currentCityText;

	// Use this for initialization
	void Start () {
        currentCity = LevelManager.levelManager.GetCityName();
        currentCityText.text = currentCity;
	}
	
	// Update is called once per frame
	void Update () {
	}

    public void setCurrentCity(string city){ currentCity = city; }
}
