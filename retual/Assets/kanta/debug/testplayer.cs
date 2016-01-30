using UnityEngine;
using System.Collections;

public class testplayer : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        float speed = 0.01f;
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed += 0.05f;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += transform.forward * speed;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += transform.forward * -speed;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += transform.right * speed;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += transform.right * -speed;
        }
	}
}
