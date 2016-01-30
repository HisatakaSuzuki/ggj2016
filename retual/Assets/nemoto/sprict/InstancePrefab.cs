using UnityEngine;
using System.Collections;

public class InstancePrefab : MonoBehaviour {
    public GameObject Prefab;

    public void instance()
    {
        GameObject prefab= Instantiate(Prefab,transform.position,transform.rotation) as GameObject;
        prefab.transform.parent = transform;
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
