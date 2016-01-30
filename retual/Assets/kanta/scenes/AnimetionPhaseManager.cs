using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class AnimetionPhaseManager : MonoBehaviour {

    [SerializeField]
    PlayerAnimation m_Player;

    int m_CurrentRoutine;

    void Start()
    {
        m_Player.AnimePlay(0);
    }

    public void Play()
    {
        m_CurrentRoutine = 0;
        StartCoroutine(onPlayRoutine());
    }


    IEnumerator onPlayRoutine()
    {
        for (int i = 0; i < 16; i++)
        {
            int number = DataManager.Instance.storyData.storyNumber[i];
            m_CurrentRoutine = number;
            if (m_CurrentRoutine == 0) break;
            m_Player.AnimePlay(m_CurrentRoutine - 1);

            yield return new WaitForSeconds(1.0f);

        }

        yield return new WaitForSeconds(5.0f);

        if (SceneManager.GetSceneByName("result").isLoaded == false)
        {
            SceneManager.LoadScene("result", LoadSceneMode.Single);
        }
        yield break;
    }
}
