using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class MenuUtil : MonoBehaviour {

    public void LoadLevel(string levelName)
    {
        LevelManager.levelManager.LoadScene(levelName);
    }


    public void Exit() {
		#if UNITY_EDITOR
			Debug.Break();
		#else
			Application.Quit();
		#endif
    }
}
