using UnityEngine;
using System.Collections;

public class PlayerAnimation : MonoBehaviour {

    
    public PlayerHarfData left = new PlayerHarfData();
    public PlayerHarfData right = new PlayerHarfData();


    public int fall;

    public GameObject MainObject;
    public GameObject AnimeObject;
    public GameObject AnimedObject;
    public GameObject NoMoveObject;

    public GameObject oneObject;
    public GameObject twoObject;


    public Animator animator;

    //static readonly int hashStatePositive = Animator.StringToHash("Positive");
    static readonly int hashStateBothHandsdown = Animator.StringToHash("BothHandsdown");
    static readonly int hashStateBothHandsUp = Animator.StringToHash("BothHandsUp");
    static readonly int hashStateBothFalling = Animator.StringToHash("Falling");
    static readonly int hashStateLeftForeArm_in = Animator.StringToHash("LeftForeArm_in");
    static readonly int hashStateBothLeftForeArm_out = Animator.StringToHash("LeftForeArm_out");
    static readonly int hashStateLeftForeArmdown = Animator.StringToHash("LeftForeArmdown");
    static readonly int hashStateLeftForeArmUp = Animator.StringToHash("LeftForeArmUp");
    static readonly int hashStateLeftHanddown = Animator.StringToHash("LeftHanddown");
    static readonly int hashStateLeftHandUp = Animator.StringToHash("LeftHandUp");
    static readonly int hashStateLeftLegdown = Animator.StringToHash("LeftLegdown");
    static readonly int hashStateLeftLegUp = Animator.StringToHash("LeftLegUp");
    static readonly int hashStateLeftwalk = Animator.StringToHash("Leftwalk");
    static readonly int hashStateRightForeArm_in = Animator.StringToHash("RightForeArm_in");
    static readonly int hashStateRightForeArm_out = Animator.StringToHash("RightForeArm_out");
    static readonly int hashStateRightHanddown = Animator.StringToHash("RightHanddown");
    static readonly int hashStateRightHandUp = Animator.StringToHash("RightHandUp");
    static readonly int hashStateRightLegdown = Animator.StringToHash("RightLegdown");
    static readonly int hashStateRightLegUp = Animator.StringToHash("RightLegUp");
    static readonly int hashStateRightwalk = Animator.StringToHash("Rightwalk");
    static readonly int hashStatestand = Animator.StringToHash("stand");
    static readonly int hashStatewalk = Animator.StringToHash("walk");

    int[] hashs =
    {
        hashStateBothHandsdown,
        hashStateBothHandsUp,
        hashStateBothFalling,
        hashStateLeftForeArm_in,
        hashStateBothLeftForeArm_out,
        hashStateLeftForeArmdown,
        hashStateLeftForeArmUp ,
        hashStateLeftHanddown ,
        hashStateLeftHandUp ,
        hashStateLeftLegdown ,
        hashStateLeftLegUp,
        hashStateLeftwalk ,
        hashStateRightForeArm_in ,
        hashStateRightForeArm_out ,
        hashStateRightHanddown,
        hashStateRightHandUp,
        hashStateRightLegdown,
        hashStateRightLegUp ,
        hashStateRightwalk ,
        hashStatestand,
        hashStatewalk,
    };
    [Range(0,20)]
    public int hashnum = 0;
    
    // Use this for initialization
    void Start () {
        Debug.Log(Quaternion.FromToRotation(new Vector3( 0.0f, 1.0f, 0.0f), Vector3.zero));
    }
	
	// Update is called once per frame
	void Update () {
        
        /*
        if( Input.GetKeyDown( KeyCode.A ) )
        {
            animator.Play( hashs[hashnum] );
           
           
        }
        if (Input.GetMouseButtonDown(0))
        {
            hashnum++;
        }
        if (Input.GetMouseButtonDown(1))
        {
            hashnum--;
        }
        */

        if (animator.GetCurrentAnimatorStateInfo(0).IsName("StandEnd"))
        {
            Transform[] now = AnimeObject.GetComponentsInChildren<Transform>();
            Transform[] before = AnimedObject.GetComponentsInChildren<Transform>();

            Transform[] main = MainObject.GetComponentsInChildren<Transform>();
            for (int i = 0; i < main.Length; ++i)
            {
                before[i].localRotation = main[i].localRotation;
            }

                //Debug.Log("aa");
        }
        else if (!animator.GetCurrentAnimatorStateInfo(0).IsName("Stand"))
        {

            Transform[] now = AnimeObject.GetComponentsInChildren<Transform>();
            Transform[] before = AnimedObject.GetComponentsInChildren<Transform>();

            Transform[] main = MainObject.GetComponentsInChildren<Transform>();

            Transform[] nomove = NoMoveObject.GetComponentsInChildren<Transform>();
            //Debug.Log("bb");
            for (int i = 0; i < main.Length; ++i)
            {

                //before[i].rotation = now[i].rotation;
                //main[i].position = before[i].position + now[i].position - before[i].position;
                //main[i].rotation.SetFromToRotation( now[i].localRotation.eulerAngles, main[i].rotation.eulerAngles * 2.0f );

                //main[i].rotation = nomove[i].rotation * (Quaternion.FromToRotation(nomove[i].rotation.eulerAngles, now[i].rotation.eulerAngles));
                main[i].localScale = before[i].localScale + now[i].localScale - nomove[i].localScale;

                //Debug.Log(Quaternion.FromToRotation(now[i].rotation.eulerAngles, before[i].rotation.eulerAngles).x);
                Vector3 anime = now[i].localRotation.eulerAngles;

                Vector3 nomoveAngle = nomove[i].localRotation.eulerAngles;
                Vector3 ans = anime - nomoveAngle;

                ans.x = -Mathf.DeltaAngle(ans.x, 0);
                ans.y = -Mathf.DeltaAngle(ans.y, 0);
                ans.z = -Mathf.DeltaAngle(ans.z, 0);
                //ans.x *= -1;
                //main[i].rotation = nomove[i].rotation * Quaternion.Euler( Mathf.DeltaAngle(nomoveAngle.x, anime.x ), Mathf.DeltaAngle(nomoveAngle.y, anime.y), Mathf.DeltaAngle(nomoveAngle.z, anime.z));
                main[i].localRotation = before[i].localRotation * Quaternion.Euler(ans);

                

            }

           

        }
    
        

    }

    public bool AnimePlay( int animeNum )
    {
        bool isPlay = false;
        if(animator.GetCurrentAnimatorStateInfo(0).IsName("Stand"))
        {
            isPlay = true;
        }
        animator.Play( hashs[animeNum] );
        return isPlay;
    }
}
