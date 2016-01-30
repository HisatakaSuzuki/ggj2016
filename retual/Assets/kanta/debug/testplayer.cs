using UnityEngine;
using System.Collections;

public class testplayer : MonoBehaviour {

    Rigidbody m_Rigidbody;
    int m_CurrentRoutine;

    void OnEnable()
    {
        m_CurrentRoutine = 0;
        m_Rigidbody = GetComponent<Rigidbody>();
        StartCoroutine(onPlayRoutine());
    }
	
	// Update is called once per frame
	void Update () {

        UpdateRoutine(m_CurrentRoutine);
       //float speed = 4.0f * Time.deltaTime;
       ////if (Input.GetKey(KeyCode.LeftShift))
       ////{
       ////    speed += 4.0f * Time.deltaTime;
       ////}
       //if (Input.GetKey(KeyCode.UpArrow))
       //{
       //    m_Rigidbody.MovePosition(Vector3.forward * speed);
       //}
       //if (Input.GetKey(KeyCode.DownArrow))
       //{
       //    m_Rigidbody.MovePosition(Vector3.forward * -speed);
       //}
       //if (Input.GetKey(KeyCode.RightArrow))
       //{
       //    m_Rigidbody.MovePosition(Vector3.right * speed);
       //}
       //if (Input.GetKey(KeyCode.LeftArrow))
       //{
       //    m_Rigidbody.MovePosition(Vector3.right * -speed);
       //}
	}

    IEnumerator onPlayRoutine()
    {
        for (int i = 0; i < 16; i++)
        {
            int number = DataManager.Instance.storyData.storyNumber[i];
            m_CurrentRoutine = number;

            if (m_CurrentRoutine == 0) yield break;

            yield return new WaitForSeconds(1.0f);

        }
        yield break;
    }

    void UpdateRoutine(int routine)
    {
        float speed = 1.0f * Time.deltaTime;
        switch (routine)
        {
            case 0:
                return;

            case 1:
                m_Rigidbody.MovePosition(transform.position + Vector3.forward * speed);
                return;

            case 2:
                m_Rigidbody.MovePosition(transform.position + Vector3.forward * -speed);
                return;

            case 3:
                m_Rigidbody.MovePosition(transform.position + Vector3.right * speed);
                return;

            case 4:
                m_Rigidbody.MovePosition(transform.position + Vector3.right * -speed);
                return;
        }
    }
}
