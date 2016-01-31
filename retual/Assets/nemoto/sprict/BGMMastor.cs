using UnityEngine;
using System.Collections;

public class BGMMastor : MonoBehaviour {

    private static bool Created = false;

    public AudioClip titleBGM;
    public AudioClip MainBGM;
    public string MainSceneName;
    public bool MainSceneChack;

    void Awake()
    {
        if(!Created){
        DontDestroyOnLoad(transform.gameObject);
        Created =true;
    }else{
        Destroy(transform.gameObject);
    }
    }
	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {
        if (!MainSceneChack)
        {
            if (Application.loadedLevelName == MainSceneName)
            {
                transform.GetComponent<AudioSource>().clip = MainBGM;
                transform.GetComponent<AudioSource>().Play();
                MainSceneChack = true;
            }
        }
        else
        {
             if (Application.loadedLevelName != MainSceneName)
            {
                transform.GetComponent<AudioSource>().clip = titleBGM;
                transform.GetComponent<AudioSource>().Play();
                MainSceneChack=false;
            }
        }
	
	}
}
