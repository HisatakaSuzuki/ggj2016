using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class StoryData  {

    public int[] storyNumber = new int[100];

    public void SetStoryData( int num, int storyNum )
    {
        this.storyNumber[num] = storyNum;
    }

    /*
    書き方
    public int number;
    public StoryData( int num )
    {
        this.number = num;
    }

    */
}
