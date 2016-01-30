using UnityEngine;
using System.Collections;

public class PlayerAinme : MonoBehaviour {


    [SerializeField]
    GameObject m_Player;
    [SerializeField]
    Animation m_PlayerAnimation;

	// Use this for initialization
	void Start () {
        m_PlayerAnimation.Play("BothHandsUp");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
