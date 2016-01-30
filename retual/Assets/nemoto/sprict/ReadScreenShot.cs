using UnityEngine;
using System.Collections;
using System.IO;
using UnityEngine.UI;

public class ReadScreenShot : MonoBehaviour {

    public string path = "";
	// Use this for initialization
	void Start () {
       
        path = "Screenshot.png";

        Debug.Log("path:"+path);

        byte[] image = File.ReadAllBytes("/"+path);

        Texture2D tex = new Texture2D(0,0);

        tex.LoadImage(image);

        transform.GetComponent<RawImage>().texture = tex;
    }

    

	
	// Update is called once per frame
	void Update () {
	
	}
}
