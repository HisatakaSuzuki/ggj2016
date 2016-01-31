using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[RequireComponent(typeof (Image))]
public class DragUI : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public Transform canvasTran;
    public  RectTransform obj;
    public Vector3 startPosition;
    public GameObject CopyObj;
    public GameObject eobj;
    public Image i;

    void Awake()
    {
        
        canvasTran = transform.parent.parent;

    }

    public void OnBeginDrag(PointerEventData e)
    {
        CreateCopyObj();
        CopyObj.transform.position = Input.mousePosition;
        transform.GetComponent<AudioSource>().Play();
        
    }

    public void OnDrag(PointerEventData e)
    {
        var t = GameObject.Find("UniqueCanvas");
        var v = t.GetComponent<RectTransform>().position;
        Vector3 p = Input.mousePosition;
        //p *= GameObject.Find("UniqueCanvas").GetComponent<RectTransform>().localScale.x;
        //p *= Screen.width / p.x; 
            

        //p.x =( p.x* (p.x / v.x) ) - p.x*((p.x / v.x) )/2.0f;
        //p.x = p.x + v.x / Screen.width ;
        //p.y = + p.y;

        Debug.Log(Screen.width);

        var x = p.x /Screen.width;
        var y = p.y /Screen.height;

        
        var pos = t.GetComponent<RectTransform>().position;
        var size = t.GetComponent<RectTransform>().sizeDelta;
        var x2 = size.x;
        var y2 = size.y;
        var x3 = size.x - pos.y;
        var y3 = size.y - pos.x;
        //var x = p.x / Screen.width;
        //var y = p.y / Screen.height;


        p.x = (x * x2 - x3/2 - 32+8);
        p.y = (y * y2 - y3/2 - 200+32);
        p.z = v.z;
        
         
        CopyObj.transform.localPosition = p;
        //CopyObj.GetComponent<RectTransform>().transform.position = p;

    }

    public void OnEndDrag(PointerEventData e)
    {
        gameObject.GetComponent<Image>().color = Vector4.one;
        Destroy(CopyObj);
    }

    
    public void CreateCopyObj(){
        CopyObj = new GameObject("CopyObj");
        CopyObj.transform.SetParent(canvasTran);
        CopyObj.transform.SetAsLastSibling();
        CopyObj.transform.localScale = Vector3.one;
        CopyObj.transform.parent = GameObject.Find("UniqueCanvas").transform;
        CopyObj.transform.position = CopyObj.transform.position + Vector3.forward;

        // レイキャストがブロックされないように
        CanvasGroup canvasGroup = CopyObj.AddComponent<CanvasGroup>();
        canvasGroup.blocksRaycasts = false;

        Image CopyImage = CopyObj.AddComponent<Image>();
        Image sourceImage = transform.GetComponent<Image>();

        CopyImage.sprite = sourceImage.sprite;
        //CopyImage.rectTransform.sizeDelta = sourceImage.rectTransform.sizeDelta;
        CopyImage.rectTransform.sizeDelta = new Vector2(100,100);
        CopyImage.color = sourceImage.color;
        CopyImage.material = sourceImage.material;

        gameObject.GetComponent<Image>().color = Vector4.one * 0.4f;
    }
	
}
