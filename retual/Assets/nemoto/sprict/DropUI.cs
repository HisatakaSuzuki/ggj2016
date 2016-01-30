using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DropUI : MonoBehaviour ,IDropHandler,IPointerEnterHandler,IPointerExitHandler{
    public Image iconImage;
    public Sprite nowSprite;
   


    void Start()
    {
        nowSprite = transform.GetComponent<Image>().sprite;
    }

    public void RemoveSelf()
    {
        Destroy(gameObject);
    }

    public void OnPointerEnter(PointerEventData e)
    {

        if (e.pointerDrag == null)
            return;
        Debug.Log(e.pointerDrag.name);

        var item = transform.parent.FindChild("space");
        int index = transform.GetSiblingIndex();
        item.transform.SetSiblingIndex(index);

        //Image droppedImage = e.pointerDrag.GetComponent<Image>();
        //transform.GetComponent<Image>().sprite = droppedImage.sprite;
        //transform.GetComponent<Image>().color = Vector4.one * 0.6f;

    }
    public void OnPointerExit(PointerEventData e)
    {
        return;
        if (e.pointerDrag == null) return;
        transform.GetComponent<Image>().sprite = nowSprite;
        if (nowSprite == null)
            transform.GetComponent<Image>().color = Vector4.zero;
        else
            transform.GetComponent<Image>().color = Vector4.one;
    }

    public void OnDrop(PointerEventData e)
    {
        Debug.Log(e.pointerDrag.name);
        Image droppedImage = e.pointerDrag.GetComponent<Image>();
        transform.GetComponent<Image>().sprite = droppedImage.sprite;
        nowSprite = droppedImage.sprite;
        transform.GetComponent<Image>().color = Vector4.one;
        if (e.pointerDrag.GetComponent<RoutineState>() == null) return;//オブジェクトのルーチン番号の受け渡し
        Debug.Log(e.pointerDrag.GetComponent<RoutineState>().RoutineNumber);
        transform.GetComponent<RoutineState>().RoutineNumber = e.pointerDrag.GetComponent<RoutineState>().RoutineNumber;
       

    }
}
