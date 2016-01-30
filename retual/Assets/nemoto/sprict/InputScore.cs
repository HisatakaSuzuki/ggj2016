using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class InputScore : MonoBehaviour {
    public float score;

    public float count;
    public float addcount;
    public float NowScoreCount;
    public bool countStop;
    public GameObject RisultObj;

    public void InputScoretoText()
    {
        transform.GetComponent<Text>().text = "Score Is " ;
        NowScoreCount = score;
    }

    public void addScoretoText()
    {
        count += addcount;
        transform.GetComponent<Text>().text = "Score Is ";
        NowScoreCount = count;
    }
	// Use this for initialization
	void Start () {
        RisultObj = GameObject.Find("DataManagerSingleton");
	}
	
	// Update is called once per frame
	void Update () {
        if (!countStop)
        {
            if (count < score)
            {
                addScoretoText();
            }
            else
            {
                countStop = true;
                InputScoretoText();
            }
        }
	}
}
