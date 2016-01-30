using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class InputScore : MonoBehaviour {
    public float score;

    public float count;
    public float addcount;
    public bool countStop;

    public void InputScoretoText()
    {
        transform.GetComponent<Text>().text = "Score Is " + score.ToString("f2");
    }

    public void addScoretoText()
    {
        count += addcount;
        transform.GetComponent<Text>().text = "Score Is " + count.ToString("f2");
    }
	// Use this for initialization
	void Start () {
        
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
