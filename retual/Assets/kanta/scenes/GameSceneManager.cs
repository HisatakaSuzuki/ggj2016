using UnityEngine;
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

        if (DataManager.Instance != null)
        {
            switch (DataManager.Instance.stageData.number)
            {
                case 1:
                    if (SceneManager.GetSceneByName("saraarai").isLoaded == false)
                    {
                        SceneManager.LoadScene("saraarai", LoadSceneMode.Additive);
                    }
                    break;
                case 2:
                    if (SceneManager.GetSceneByName("suika").isLoaded == false)
                    {
                        SceneManager.LoadScene("suika", LoadSceneMode.Additive);
                    }
                    break;
                case 3:
                    if (SceneManager.GetSceneByName("ryouri").isLoaded == false)
                    {
                        SceneManager.LoadScene("ryouri", LoadSceneMode.Additive);
                    }
                    break;
            }
        }
    }


    public void ChangeAnimationPhase()
    {
        m_CurrentPhase = GameScenePhase.Animationm;
        var m = GameObject.Find("AnimationPhaseManager");
        if (m) m.GetComponent<AnimetionPhaseManager>().Play();
    }

    public void ChangeResultPhase()
    {
        m_CurrentPhase = GameScenePhase.Animationm;
        var m = GameObject.Find("AnimationPhaseManager");
        if (m) ;// m.GetComponent<AnimetionPhaseManager>().Play();
    }
}
