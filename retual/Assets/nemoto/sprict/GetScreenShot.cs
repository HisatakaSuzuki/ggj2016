using UnityEngine;
using System.Collections;

public class GetScreenShot : MonoBehaviour {

    public void getScreenShot()
    {
        Application.CaptureScreenshot("/Screenshot.png");

    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
