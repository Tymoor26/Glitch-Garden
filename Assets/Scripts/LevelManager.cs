﻿using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {
    public float autoLoadNextLevelAfter;
    public bool onSplash;

    void Start()
    {
        if (onSplash && autoLoadNextLevelAfter>0) { Invoke("LoadNextLevel", autoLoadNextLevelAfter); }
    }

	public void LoadLevel(string name){
		Debug.Log ("New Level load: " + name);
		Application.LoadLevel (name);
	}

	public void QuitRequest(){
		Debug.Log ("Quit requested");
		Application.Quit ();
	}

    public void LoadNextLevel()
    {
        Application.LoadLevel(Application.loadedLevel + 1);
    }
}
