using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour{

    public static LevelManager levelManager;

    //data for city
    private City currentCity;

    void Awake()
    {
        // Set the instace of the game manager to be this
        if (!levelManager)
        {
            // Sets this to not be destroyed when loading a new scene
            DontDestroyOnLoad(gameObject);
            levelManager = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void EnterOpenWorld()
    {
        LoadScene("OpenWorld");
    }

    public void EnterCity(string cityName)
    {
        print("player wants to enter " + cityName);
        LoadScene("City");

    }

    public void EnterBattle()
    {
        print("Entering battle now");
        LoadScene("Battle");
    }

    //getters and setters
    public void SetCurrentCity(City city) { currentCity = city; }
    public City GetCurrentCity() { return currentCity; }
}
