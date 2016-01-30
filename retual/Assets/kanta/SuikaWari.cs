using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SuikaWari : MonoBehaviour {


    [SerializeField]
    Text m_CompleteLevel;

    void OnCollisionEnter(Collision collision)
    {
        foreach (ContactPoint contact in collision.contacts)
        {
            if (contact.otherCollider.tag == "Player")
            {
                var length = contact.otherCollider.GetComponent<Rigidbody>().GetPointVelocity(transform.position).magnitude;
                m_CompleteLevel.text = (length * 100).ToString() + "%";
            }
        }

    }
}
