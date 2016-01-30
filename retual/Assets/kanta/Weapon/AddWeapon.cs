using UnityEngine;
using System.Collections;

public class AddWeapon : MonoBehaviour {

    [SerializeField]
    GameObject m_Weapon;

	// Use this for initialization
	void Start () {
        var r = GameObject.Find("Rechard").GetComponent<RechardReflection>();
        if (r)
        {
            r.EpicWeapon(m_Weapon);
        }
	}
}
