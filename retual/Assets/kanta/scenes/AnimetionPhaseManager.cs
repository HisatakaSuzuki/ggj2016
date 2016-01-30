using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class AnimetionPhaseManager : MonoBehaviour {

    [SerializeField]
    PlayerAnimation m_Player;
    [SerializeField]
    GetScreenShot m_ScreenShot;

    int m_CurrentRoutine;

    void Start()
    {
        m_Player.AnimePlay(0);
    }

    public void Play()
    {
        m_CurrentRoutine = 0;
        CombiAnimate();
        StartCoroutine(onPlayRoutine());
    }
    struct CombiAnimeData
    {
        public int[] checkAnimes;
        public int number;
        public CombiAnimeData( int[] animes, int number )
        {
            this.checkAnimes = animes;
            this.number = number;
        }
    };

    void CombiAnimate()
    {
        var storyNumbers = DataManager.Instance.storyData.storyNumber;
        int maxCount = storyNumbers.Length;
        List<CombiAnimeData> combiAnimes = new List<CombiAnimeData>();
        combiAnimes.Add(new CombiAnimeData(m_Player.LeftWalkAnimation, 26));
        combiAnimes.Add(new CombiAnimeData(m_Player.RightWalkAnimation,27));
        
        foreach (CombiAnimeData combiAnimeData in combiAnimes )
        {
            int count = 0;
            for (int i = 0; i < maxCount; ++i)
            {
                if( storyNumbers[i] == combiAnimeData.checkAnimes[count] )
                {
                    ++count;
                }
                else if( count > 0 )
                {
                    --count;
                    i--;
                }
                else
                {
                    count = 0;
                }
                if (count >= combiAnimeData.checkAnimes.Length )
                {
                    SetCombiAnime( combiAnimeData, storyNumbers, count, i + 1 - count);
                    count = 0;
                }
            }
        }
    }

    void SetCombiAnime( CombiAnimeData combiAnimeData, int[] storyNumbers, int count, int first )
    {

        // 関数
        //int first = i+1 - count;
        int maxCount = storyNumbers.Length;
        storyNumbers[first] = combiAnimeData.number;
        while (count > 1)
        {
            //storyNumbers[first + 1] = 0;
            for (int j = first+1; j < maxCount - 1; ++j)
            {
                storyNumbers[j] = storyNumbers[j + 1];
            }
            storyNumbers[maxCount - 1] = 0;
            
            count--;
        }
        count = 0;
    }


    IEnumerator onPlayRoutine()
    {
        for (int i = 0; i < 16; i++)
        {
            int number = DataManager.Instance.storyData.storyNumber[i];
            m_CurrentRoutine = number;
            if (i == 14 || (i != 15 && DataManager.Instance.storyData.storyNumber[i+1] == 0))
            {
                m_ScreenShot.getScreenShot();
            }
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
