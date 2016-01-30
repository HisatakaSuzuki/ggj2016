using UnityEngine;
using System.Collections;

public class ParticleLife : MonoBehaviour {
    public float lifetime = 0.7f;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        lifetime -= Time.deltaTime;
        if (lifetime < 0) Destroy(transform.gameObject);
	}
}
