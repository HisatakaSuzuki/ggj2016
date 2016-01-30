using UnityEngine;
using System.Collections;

[System.Serializable]
public class PlayerHarfData {

    public int leg;
    public int knee;
    // 足首
    public int ankle;

    public int arm;
    public int elbow;

    public PlayerHarfData()
    {
        leg = 0;
        knee = 0;
        ankle = 0;
        arm = 0;
        elbow = 0;
    }
        

}
