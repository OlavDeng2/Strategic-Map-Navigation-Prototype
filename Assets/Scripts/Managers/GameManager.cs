using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameManager gameManager;
    
    void Awake()
    {
        // Set the instace of the game manager to be this
        if (!gameManager)
        {
            // Sets this to not be destroyed when loading a new scene
            DontDestroyOnLoad(gameObject);
            gameManager = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
