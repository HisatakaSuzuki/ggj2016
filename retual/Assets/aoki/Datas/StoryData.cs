using UnityEngine;
using System.Collections;

[System.Serializable]
public class StoryData  {

    public int[] storyNumber = new int[16];

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
