using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class table : MonoBehaviour {

    [SerializeField]
    GameObject m_Ryouris;
    [SerializeField]
    obon m_Obon;
    [SerializeField]
    ParText m_ParText;


    int m_ObonMAX;
    int m_ObonCount;

    int m_RyouriMAX;
    int m_RyouriCount;


    void UpdateParText()
    {
        float t = (m_ObonCount + m_RyouriCount) / (float)(m_ObonMAX + m_RyouriMAX) * 50;
        float o = m_Obon.GetObonPar() * 50;
        m_ParText.SetPar(t + o);
    }

    // Use this for initialization
    void Start()
    {
        m_RyouriMAX = m_Ryouris.transform.childCount;
        m_RyouriCount = 0;
        m_ObonMAX = 1;
        m_ObonCount = 0;
    }

    void Update()
    {
        UpdateParText();
    }
    void OnTriggerEnter(Collider collision)
    {
       
       //foreach (ContactPoint contact in collision.contacts)
       //{
        if (collision.tag == "ryouri")
        {
           m_RyouriCount++;
       
        }
        if (collision.tag == "obon")
        {
            m_ObonCount++;
       
        }
       //}

    }
    void OnTriggerExit(Collider collision)
    {

        //foreach (ContactPoint contact in collision.contacts)
        //{
        if (collision.tag == "ryouri")
        {
            m_RyouriCount--;

        }
        if (collision.tag == "obon")
        {
            m_ObonCount--;

        }
        //}

    }
    //void OnCollisionEnter(Collision collision)
    //{
    //    Debug.Log("acscvas");
    //    foreach (ContactPoint contact in collision.contacts)
    //    {
    //        if (contact.otherCollider.tag == "ryouri")
    //        {
    //            m_RyouriCount++;
    //
    //        }
    //        if (contact.otherCollider.tag == "obon")
    //        {
    //            m_ObonCount++;
    //
    //        }
    //    }
    //
    //}
    //void OnCollisionEnd(Collision collision)
    //{
    //    foreach (ContactPoint contact in collision.contacts)
    //    {
    //        if (contact.otherCollider.tag == "ryouri")
    //        {
    //            m_RyouriCount--;
    //        }
    //        if (contact.otherCollider.tag == "obon")
    //        {
    //            m_ObonCount--;
    //
    //        }
    //    }
    //
    //}
}
