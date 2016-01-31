using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StageSelect : MonoBehaviour {

    [SerializeField]
    int m_StageNo;


    public void OnButton()
    {
        DataManager.Instance.stageData.number = m_StageNo;

        if (SceneManager.GetSceneByName("GameScene").isLoaded == false)
        {
            //SceneManager.LoadScene("GameScene", LoadSceneMode.Single);
            FadeManager.Instance.LoadLevel("GameScene",1f);
        }
    }
}
