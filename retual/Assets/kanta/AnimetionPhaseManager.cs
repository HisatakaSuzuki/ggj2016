using UnityEngine;
using System.Collections;

public class AnimetionPhaseManager : MonoBehaviour {

    [SerializeField]
    testplayer m_Player;

    bool m_PhaseActive = false;

    public bool isPhaseActive
    {
        set
        {
            m_PhaseActive = value;
            if(m_Player)m_Player.enabled = value;
        }
        get
        {
            return m_PhaseActive;
        }
    }

    void Awake()
    {
        isPhaseActive = false;
    }
}
