using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class City {

    public City(string nameOfCity, Nationality nation)
    {
        this.cityName = nameOfCity;
        this.cityNationality = nation;
    }

    public string cityName;
    public Nationality cityNationality;

    public enum Nationality { Friendly, Enemy};
}
