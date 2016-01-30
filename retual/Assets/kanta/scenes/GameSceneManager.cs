﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameSceneManager : MonoBehaviour {

    public enum GameScenePhase{
        Thinking,
        Animationm,
        Result
    }

    GameScenePhase m_CurrentPhase;

    [SerializeField]
    string m_Thinking;
    [SerializeField]
    string m_Animetion;

    [SerializeField]
    AnimetionPhaseManager m_AnimetionPhaseManager;

    void Awake()
    //void Start()
    {
        m_CurrentPhase = GameScenePhase.Thinking;
        DontDestroyOnLoad(gameObject);
        if (SceneManager.GetSceneByName (m_Thinking).isLoaded == false)
        {
            SceneManager.LoadScene(m_Thinking, LoadSceneMode.Additive);
        }
        if (SceneManager.GetSceneByName(m_Animetion).isLoaded == false)
        {
            SceneManager.LoadScene(m_Animetion, LoadSceneMode.Additive);
        }

        
    }


    public void ChangeAnimationPhase()
    {
        m_CurrentPhase = GameScenePhase.Animationm;
        var m = GameObject.Find("AnimationPhaseManager");
        if (m) m.GetComponent<AnimetionPhaseManager>().isPhaseActive = true;
    }

    public void ChangeResultPhase()
    {
        m_CurrentPhase = GameScenePhase.Animationm;
        var m = GameObject.Find("AnimationPhaseManager");
        if (m) m.GetComponent<AnimetionPhaseManager>().isPhaseActive = true;
    }
}
