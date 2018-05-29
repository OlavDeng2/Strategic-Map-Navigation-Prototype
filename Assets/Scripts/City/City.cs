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
    
    //Array to store all the ships for sale in shipyard
    public GameObject[] shipsInShipyard;

    //array to store all the different items for sale in the store
    public GameObject[] itemsInStore;

    //Int to store the crew count available for hire
    public int crewForHire;

    public Nationality cityNationality;

    public enum Nationality { Friendly, Enemy};
}
