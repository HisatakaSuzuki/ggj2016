using UnityEngine;
using System.Collections;

public class Buttons : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//stageselectへのシーン遷移
	public void StartButton(){
		//Application.LoadLevel ("StageSelect");
        FadeManager.Instance.LoadLevel("StageSelect", 1f);
	}
}
