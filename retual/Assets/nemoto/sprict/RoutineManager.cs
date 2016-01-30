using UnityEngine;
using System.Collections;
//各ルーチンオブジェクトを読み込み
public class RoutineManager : MonoBehaviour {
    public GameObject[] RoutineObjs = new GameObject[24];
    public int[] RoutineNums = new int[24];
    public string ObjsName;
    public bool Story;

    
	// Use this for initialization
	void Start () {
        RoutineObjs[1] = GameObject.Find(ObjsName + 1);
        for (int i = 0; i < RoutineObjs.Length;i++ )
        {
            RoutineObjs[i] = GameObject.Find(ObjsName+(i+1));
        }
	}
	
	// Update is called once per frame
	void Update () {
        for (int i = 0; i < RoutineNums.Length; i++)
        {
            RoutineNums[i] = RoutineObjs[i].GetComponent<RoutineState>().RoutineNumber;
        }

        if (Story)
        {
            GameObject d1 = GameObject.Find("DataManagerSingleton");
            StoryData S1 = d1.GetComponent<DataManager>().storyData;
            for (int i = 0; i < RoutineNums.Length; i++)
            {
                //S1.SetStoryData(i,RoutineNums[i]);
            }
        }
	}
}
