using UnityEngine;
using System.Collections;

public class SaraYogore : MonoBehaviour
{
    [SerializeField]
    SaraArai m_SaraArai;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Destroy(gameObject);
            if (m_SaraArai)
            {
                m_SaraArai.YogoreDead();
            }
        }
        
    }

}
