using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DropUI : MonoBehaviour ,IDropHandler,IPointerEnterHandler,IPointerExitHandler{
    public Image iconImage;
    public Sprite nowSprite;
   


    void Start()
    {
        nowSprite = null;
    }

    public void OnPointerEnter(PointerEventData e)
    {

        if (e.pointerDrag == null)
        
            return;
        
        Image droppedImage = e.pointerDrag.GetComponent<Image>();
        transform.GetComponent<Image>().sprite = droppedImage.sprite;
        transform.GetComponent<Image>().color = Vector4.one * 0.6f;
        
        
         
    }
    public void OnPointerExit(PointerEventData e)
    {
        if (e.pointerDrag == null) return;
        transform.GetComponent<Image>().sprite = nowSprite;
        if (nowSprite == null)
            transform.GetComponent<Image>().color = Vector4.zero;
        else
            transform.GetComponent<Image>().color = Vector4.one;
    }

    public void OnDrop(PointerEventData e)
    {
        
        Image droppedImage = e.pointerDrag.GetComponent<Image>();
        transform.GetComponent<Image>().sprite = droppedImage.sprite;
        nowSprite = droppedImage.sprite;
        transform.GetComponent<Image>().color = Vector4.one * 0.6f;
       
       

    }
}
