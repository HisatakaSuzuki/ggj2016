using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SaraArai : MonoBehaviour {

    [SerializeField]
    GameObject m_YogoreContent;

    [SerializeField]
    MeshRenderer m_SaraMaterial;
    [SerializeField]
    Color m_SaraMaterial_Yogore;
    [SerializeField]
    Color m_SaraMaterial_Kirei;

    [SerializeField]
    ParText m_ParText;

    int m_YogoreMax = 1;
    int m_YogoreCount = 0;
	// Use this for initialization
	void Start () {
        m_YogoreMax = m_YogoreContent.transform.childCount;
        m_YogoreCount = 0;
        UpdateCompleteText();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void YogoreDead(){
        m_YogoreCount++;
        UpdateCompleteText();
    }

    void UpdateCompleteText()
    {
        if (m_YogoreMax == 0) return;
        var par = m_YogoreCount / (float)m_YogoreMax;
        m_ParText.SetPar(par * 100);
        UpdateCompleteMaterial(par);
    }

    void UpdateCompleteMaterial(float par)
    {
        var mate = m_SaraMaterial.material;
        mate.color = Color.Lerp(m_SaraMaterial_Yogore, m_SaraMaterial_Kirei, par);
        
    }
}
