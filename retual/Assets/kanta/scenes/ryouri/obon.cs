using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class obon : MonoBehaviour {


    [SerializeField]
    GameObject m_Ryouris;


    int m_ObonMAX;
    int m_ObonCount;

    public float GetObonPar()
    {
        return m_ObonCount/(float)m_ObonMAX;
    }


    // Use this for initialization
    void Start()
    {
        m_ObonMAX = m_Ryouris.transform.childCount;
        m_ObonCount = 0;
    }
	

    void OnTriggerEnter(Collider collision)
    {

        //foreach (ContactPoint contact in collision.contacts)
        //{
        if (collision.tag == "ryouri")
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
            m_ObonCount--;

        }
        //}

    }

   //void OnCollisionEnter(Collision collision)
   //{
   //    foreach (ContactPoint contact in collision.contacts)
   //    {
   //        if (contact.otherCollider.tag == "ryouri")
   //        {
   //            m_ObonCount++;
   //            Debug.Log("ok");
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
   //            m_ObonCount--;
   //        }
   //    }
   //
   //}
}
