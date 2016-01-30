using UnityEngine;
using System.Collections;
//各ルーチンオブジェクトを読み込み
public class RoutineManager : MonoBehaviour {
    public GameObject[] RoutineObjs = new GameObject[24];
    public string ObjsName;
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
	
	}
}
