using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerAnimation : MonoBehaviour {

    
    public PlayerHarfData left = new PlayerHarfData();
    public PlayerHarfData right = new PlayerHarfData();
    [SerializeField]
    AudioSource whistleSE;

    public int fall;

    public GameObject MainObject;
    public GameObject AnimeObject;
    public GameObject AnimedObject;
    public GameObject NoMoveObject;

    public GameObject oneObject;
    public GameObject twoObject;


    public Animator animator;

    bool isStart = false;
    bool isFirstFrame = false;

    public float warkSpeed;

    //static readonly int hashStatePositive = Animator.StringToHash("Positive");
    static readonly int hashStateBothHandsdown = Animator.StringToHash("BothHandsdown");
    static readonly int hashStateBothHandsUp = Animator.StringToHash("BothHandsUp");
    static readonly int hashStateBothFalling = Animator.StringToHash("Falling");
    static readonly int hashStateLeftForeArm_in = Animator.StringToHash("LeftForeArm_in");
    static readonly int hashStateLeftForeArm_out = Animator.StringToHash("LeftForeArm_out");
    static readonly int hashStateLeftForeArmdown = Animator.StringToHash("LeftForeArmdown");
    static readonly int hashStateLeftForeArmUp = Animator.StringToHash("LeftForeArmUp");
    static readonly int hashStateLeftHanddown = Animator.StringToHash("LeftHanddown");
    static readonly int hashStateLeftHandUp = Animator.StringToHash("LeftHandUp");
    static readonly int hashStateLeftLegdown = Animator.StringToHash("LeftLegdown");
    //11~
    static readonly int hashStateLeftLegUp = Animator.StringToHash("LeftLegUp");
    static readonly int hashStateLeftwalk = Animator.StringToHash("Leftwalk");
    static readonly int hashStateRightForeArm_in = Animator.StringToHash("RightForeArm_in");
    static readonly int hashStateRightForeArm_out = Animator.StringToHash("RightForeArm_out");
    static readonly int hashStateRightForeArmdown = Animator.StringToHash("RightForeArmdown");
    static readonly int hashStateRightForeArmUp = Animator.StringToHash("RightForeArmdown");

    static readonly int hashStateRightHanddown = Animator.StringToHash("RightHanddown");
    static readonly int hashStateRightHandUp = Animator.StringToHash("RightHandUp");
    static readonly int hashStateRightLegdown = Animator.StringToHash("RightLegdown");
    static readonly int hashStateRightLegUp = Animator.StringToHash("RightLegUp");
    //21~
    static readonly int hashStateRightwalk = Animator.StringToHash("Rightwalk");
    static readonly int hashStatestand = Animator.StringToHash("stand");
    static readonly int hashStatewalk = Animator.StringToHash("walk");

    static readonly int hashStateBothFloating = Animator.StringToHash("Floating");
    static readonly int hashStateBothFloating2 = Animator.StringToHash("Floating2");
    static readonly int hashStateLeftBlendWalk = Animator.StringToHash("LeftBlendWalk");
    static readonly int hashStateRightBlendWalk = Animator.StringToHash("RightBlendWalk");
    static readonly int hashStateSquat = Animator.StringToHash("Squat1");



    int[] hashs =
    {
        
        hashStateLeftHandUp ,
        hashStateLeftHanddown ,
        hashStateRightHanddown,
        hashStateRightHandUp,
        
        hashStateLeftForeArm_in,
        hashStateRightForeArm_in ,

        hashStateLeftForeArmUp ,
        hashStateLeftForeArmdown,

        hashStateRightForeArmUp,
        hashStateRightForeArmdown,
        //11
        hashStateLeftForeArm_out,
        hashStateRightForeArm_out ,
        hashStateBothFalling,
        hashStateLeftLegUp,
        hashStateLeftLegdown ,
        hashStateRightLegUp ,
        hashStateRightLegdown,
        hashStateBothFloating,
        //hashStateRightwalk ,
        hashStateLeftwalk ,
        hashStateBothHandsdown,
        //21
        hashStateBothHandsUp,
        hashStatestand,
        hashStatewalk,
        hashStateBothFloating,
        hashStateBothFloating2,
        hashStateLeftBlendWalk,
        hashStateRightBlendWalk,
        hashStateSquat,
    };

    public int[] LeftWalkAnimation =
    {
        14,
        13,
        15
    };

    public int[] RightWalkAnimation =
    {
        16,
        13,
        17
    };

    public int[] SquatLeftAnimation =
    {
        14,
        16,
    };

    public int[] SquatRightAnimation =
    {
        16,
        14,
    };


    [Range(0,20)]
    public int hashnum = 0;

    List<int> routineBox = new List<int>();
    
    // Use this for initialization
    void Start () {
        Debug.Log(Quaternion.FromToRotation(new Vector3( 0.0f, 1.0f, 0.0f), Vector3.zero));
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        
        /*
        if( Input.GetKeyDown( KeyCode.A ) )
        {
            animator.Play( hashs[hashnum] );
            isStart = true;
           
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
        if (isFirstFrame)
        {
            isFirstFrame = false;
            Transform[] now = AnimeObject.GetComponentsInChildren<Transform>();
            Transform[] before = AnimedObject.GetComponentsInChildren<Transform>();

            Transform[] main = MainObject.GetComponentsInChildren<Transform>();

            Transform[] nomove = NoMoveObject.GetComponentsInChildren<Transform>();
            //Debug.Log("bb");
            for (int i = 0; i < main.Length; ++i)
            {
                nomove[i].rotation = now[i].rotation;
            }
        }
        if ( isStart  )
        {
            isFirstFrame = true;
            isStart = false;
            return;
        }

        if (animator.GetCurrentAnimatorStateInfo(0).IsName("LeftBlendWalk") || animator.GetCurrentAnimatorStateInfo(0).IsName("RightBlendWalk"))
        {
            animator.SetFloat("Blend", animator.GetCurrentAnimatorStateInfo(0).normalizedTime);
            MainObject.transform.position += this.transform.forward * warkSpeed * Time.fixedDeltaTime;

            //Debug.Log("aa");
        }
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("Squat1")|| animator.GetCurrentAnimatorStateInfo(0).IsName("Squat2"))
        {
            animator.SetFloat("Blend", 0.5f);
            MainObject.transform.position += this.transform.up * -warkSpeed * Time.fixedDeltaTime;


        }
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
                //main[i].localScale = before[i].localScale + now[i].localScale - nomove[i].localScale;

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
        routineBox.Add( animeNum );
        isStart = true;
       
        animator.Play( hashs[animeNum] );
        
        return isPlay;
    }
}
