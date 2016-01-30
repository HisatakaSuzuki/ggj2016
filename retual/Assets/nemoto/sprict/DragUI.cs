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
        CopyObj.transform.position = e.position;
        
    }

    public void OnDrag(PointerEventData e)
    {
        CopyObj.transform.position = e.position;
       
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
        CopyObj.transform.parent = GameObject.Find("Canvas").transform;

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
