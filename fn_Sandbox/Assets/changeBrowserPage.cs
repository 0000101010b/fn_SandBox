﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class changeBrowserPage : MonoBehaviour {


    public string toBrowserPage = "";
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    void OnMouseDown()
    {
        SceneManager.LoadScene(toBrowserPage, LoadSceneMode.Single);
    }
}