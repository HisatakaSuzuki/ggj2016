using UnityEngine;
using System.Collections;

public class StartButton : MonoBehaviour {

    [SerializeField]
    FindObject m_FOF;

    [SerializeField]
    GameObject m_RoutineContainer;

    public void OnButtonEnter()
    {
        int c = m_RoutineContainer.transform.childCount;
        for (int i = 0; i < c; i++)
        {
            var state = m_RoutineContainer.transform.GetChild(i).GetComponent<RoutineState>();
            if (state)
            {
                DataManager.Instance.storyData.SetStoryData(i,state.RoutineNumber);
            }
         
        }
        var obj = m_FOF.GetObject;
        if (obj)
            obj.GetComponent<GameSceneManager>().ChangeAnimationPhase();
    }
}
