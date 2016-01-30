using UnityEngine;
using System.Collections;

public class testplayer : MonoBehaviour {

    Rigidbody m_Rigidbody;
	// Use this for initialization
	void Start () {
        m_Rigidbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {

        float speed = 400.0f * Time.deltaTime;
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed += 400.0f * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            m_Rigidbody.AddForce(Vector3.forward * speed);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            m_Rigidbody.AddForce(Vector3.forward * -speed);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            m_Rigidbody.AddForce(Vector3.right * speed);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            m_Rigidbody.AddForce(Vector3.right * -speed);
        }
	}
}
