using UnityEngine;
using System.Collections;

public class suikabreakSound : MonoBehaviour {


    [SerializeField]
    AudioSource m_Sound;
	
	// Update is called once per frame
	void Update () {

        var obj = GetComponent<FixedJoint>();
        if (obj) return;
        m_Sound.Play();
        Destroy(this);
	}
}
