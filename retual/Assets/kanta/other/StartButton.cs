using UnityEngine;
using System.Collections;

public class StartButton : MonoBehaviour {

    [SerializeField]
    FindObject m_FOF;

    [SerializeField]
    GameObject m_RoutineContainer;


    bool m_Zoom;
    [SerializeField]
    GameObject m_MainCamera;

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

        };
        DataManager.Instance.storyData.SetStoryData(c-1, 0);
        var obj = m_FOF.GetObject;
        if (obj)
            obj.GetComponent<GameSceneManager>().ChangeAnimationPhase();

        m_Zoom = true;
    }

    void Start()
    {
        m_Zoom = false;
    }

    void Update()
    {
        if (!m_Zoom) return;
        m_MainCamera.transform.position = m_MainCamera.transform.position + Vector3.forward * 100 * Time.deltaTime;
    }
}
