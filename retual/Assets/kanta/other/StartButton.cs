using UnityEngine;
using System.Collections;

public class StartButton : MonoBehaviour {

    [SerializeField]
    FindObject m_FOF;

    public void OnButtonEnter()
    {
        var obj = m_FOF.GetObject;
        if (obj)
            obj.GetComponent<GameSceneManager>().ChangeAnimationPhase();
    }
}
