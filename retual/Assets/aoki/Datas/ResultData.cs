using UnityEngine;
using System.Collections;

[System.Serializable]
public class ResultData
{
    public float score=100f;
    public bool isClear;

    public ResultData()
    {
        isClear = false;
    }
    /*
    public ResultData( bool isclear )
    {
        this.isClear = isclear;
    }
    */
}
