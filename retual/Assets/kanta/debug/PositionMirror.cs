using UnityEngine;
using System.Collections;

public class PositionMirror : MonoBehaviour {

    [SerializeField]
    Transform m_MirrorTargert;
	
	// Update is called once per frame
	void Update () {
	    if(m_MirrorTargert){
            m_MirrorTargert.position = transform.position;
        }
	}
}
