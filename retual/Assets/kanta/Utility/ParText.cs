using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ParText : MonoBehaviour {


    [SerializeField]
    Text m_ParText;

    public void SetPar(float par)
    {
        DataManager.Instance.rusultData.score = par;
        //m_ParText.text = par.ToString() + "%";
    } 

	// Use this for initialization
	void Start () {
        SetPar(0);
	}
	
}
