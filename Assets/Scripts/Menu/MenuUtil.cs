using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class MenuUtil : MonoBehaviour {
    public LevelManager levelManager = new LevelManager();

    public void LoadLevel(string levelName)
    {
        levelManager.LoadScene(levelName);
    }


    public void Exit() {
		#if UNITY_EDITOR
			Debug.Break();
		#else
			Application.Quit();
		#endif
    }
}
