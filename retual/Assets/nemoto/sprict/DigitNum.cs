using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class DigitNum : MonoBehaviour {
    public int digitnum;
    public Sprite[] NumImage = new Sprite[10];
    public GameObject score;
    int Score;

    void Rendering(string text)
    {
        for (int i = 0; i < text.Length;i++ )
        {
            string name = text[i].ToString();
            Debug.Log(text.Length);
            if (i == digitnum)
            {
                if (name == null)
                {
                    transform.GetComponent<Image>().sprite = NumImage[0];

                }
                else
                {
                    transform.GetComponent<Image>().sprite = NumImage[Int32.Parse(name)];
                }
            }
            }
    }
	// Use this for initialization
	void Start () {
        score = transform.parent.gameObject;
	}
	
	// Update is called once per frame
	void Update () {
        Score = (int)(score.GetComponent<InputScore>().NowScoreCount*10) ;
        Rendering(Score.ToString("D4"));
	}
}
