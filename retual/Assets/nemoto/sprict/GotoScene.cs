using UnityEngine;
using System.Collections;

public class GotoScene : MonoBehaviour {
    public string sceneName;


    public void GoToScene()
    {
        Application.LoadLevel(sceneName);
    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
