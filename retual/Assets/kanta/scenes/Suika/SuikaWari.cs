using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SuikaWari : MonoBehaviour {


    [SerializeField]
    ParText m_ParText;

    int m_MaxBreak;
    int m_BreakCount;

    void Start()
    {
        m_BreakCount = 0;
        m_MaxBreak = 0;
        int c = transform.childCount;
        for (int i = 0; i < c; i++)
        {
            var suika = transform.GetChild(i);
            int s = suika.childCount;
            for (int j = 0; j < s; j++)
            {
                var joint = suika.GetChild(j).GetComponent<FixedJoint>();
                if (joint)
                {
                    m_MaxBreak++;
                    m_BreakCount++;
                }
            }
        }
    }

    void Update()
    {

        m_BreakCount = 0;
        int c = transform.childCount;
        for(int i = 0;i<c;i++)
        {
            var suika = transform.GetChild(i);
            int s = suika.childCount;
            for(int j = 0;j<s;j++)
            {
                var joint = suika.GetChild(j).GetComponent<FixedJoint>();
                if (joint)
                {
                    m_BreakCount++;
                }
            }
        }

        m_ParText.SetPar((m_MaxBreak - m_BreakCount) / (float)m_MaxBreak * 100.0f);
    }
}
