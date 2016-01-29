using UnityEngine;
using System.Collections;

public class SaraYogore : MonoBehaviour {

    

    void OnTriggerBegin(Collider target)
    {
        if (target.tag == "Player")
        {
            Destroy(target);
        }
    }
}
