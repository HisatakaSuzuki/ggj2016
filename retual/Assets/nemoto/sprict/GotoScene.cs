﻿using UnityEngine;
using System.Collections;

public class GotoScene : MonoBehaviour {
    public string sceneName;
    public float time = 0.5f;
    public bool toScene;

    public void GoToScene()
    {
        toScene = true;
    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (toScene)
        {
            time -= Time.deltaTime;
            if (time < 0) Application.LoadLevel(sceneName);
        }
	
	}
}
