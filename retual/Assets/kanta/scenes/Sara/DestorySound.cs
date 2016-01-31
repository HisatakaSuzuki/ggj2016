using UnityEngine;
using System.Collections;

public class DestorySound : MonoBehaviour {


    [SerializeField]
    AudioSource m_Sound;

    void OnDestroy()
    {
        m_Sound.Play();
    }
}
