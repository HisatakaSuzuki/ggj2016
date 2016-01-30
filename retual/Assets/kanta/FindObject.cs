using UnityEngine;
using System.Collections;
using System.Reflection;

public class FindObject : MonoBehaviour {


    [SerializeField]
    string m_FindGameObjectName;

    GameObject m_GameObject;

    public GameObject GetObject
    {
        get
        {
            if (!m_GameObject) find();
            return m_GameObject;
        }
    }

	// Use this for initialization
	void find () {
        m_GameObject = GameObject.Find(m_FindGameObjectName);
	}
}
