using UnityEngine;
using System.Collections;

public class RechardReflection : MonoBehaviour {

    [SerializeField]
    GameObject m_RightHand;
    [SerializeField]
    GameObject m_RightHand2;
    [SerializeField]
    GameObject m_RightHand3;
    [SerializeField]
    GameObject m_RightHand4;
    [SerializeField]
    GameObject m_NullItem;



    public void EpicWeapon(GameObject weapon)
    {
        var w = Instantiate(weapon);
        var pos = w.transform.localPosition;
        var rot = w.transform.localRotation;
        w.transform.parent = m_RightHand.transform;
        w.transform.localPosition = pos;
        w.transform.localRotation = rot;
        var e = Instantiate(m_NullItem);
        e.transform.parent = m_RightHand2.transform;
        e.transform.localPosition = pos;
        e.transform.localRotation = rot;
        var e2 = Instantiate(m_NullItem);
        e2.transform.parent = m_RightHand3.transform;
        e2.transform.localPosition = pos;
        e2.transform.localRotation = rot;
        var e3 = Instantiate(m_NullItem);
        e3.transform.parent = m_RightHand4.transform;
        e3.transform.localPosition = pos;
        e3.transform.localRotation = rot;
    }
}
