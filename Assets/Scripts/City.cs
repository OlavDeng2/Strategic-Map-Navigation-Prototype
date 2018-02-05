using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

[System.Serializable]
public class City {

    public City(string nameOfCity)
    {
        this.cityName = nameOfCity;
    }

    public readonly string cityName;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
