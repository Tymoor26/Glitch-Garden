﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class FadeIn : MonoBehaviour {
    public float fadeInTime;

    private Image fadePanel;
    private Color currentColour = Color.black;

    static bool firstTime = true;
    // Use this for initialization
    void Start() {
        fadePanel = GetComponent<Image>();
    }
	
	// Update is called once per frame
	void Update () {
	    if(Time.timeSinceLevelLoad < fadeInTime && firstTime)
        {
            float alphaChange = Time.deltaTime/ fadeInTime;
            currentColour.a -= alphaChange;
            fadePanel.color = currentColour;
        } else
        {
            gameObject.SetActive(false);
            firstTime = false;
            
        }
	}
}
