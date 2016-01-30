using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DropWindow : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler
{

    [SerializeField]
    GameObject m_ContentArea;
    [SerializeField]
    GameObject m_RoutineItem;

    public void OnPointerEnter(PointerEventData e)
    {
    }
    public void OnPointerExit(PointerEventData e)
    {
        var item = m_ContentArea.transform.FindChild("space");
        item.transform.SetAsLastSibling();
    }

    public void OnDrop(PointerEventData e)
    {
        var item = Instantiate(m_RoutineItem);
        var ui = item.GetComponent<DropUI>();
        ui.OnDrop(e);
        ui.transform.parent = m_ContentArea.transform;
        ui.transform.localScale = new Vector3(1, 1, 1);

        var sitem = m_ContentArea.transform.FindChild("space");
        int index = sitem.GetSiblingIndex();
        ui.transform.SetSiblingIndex(index);
        sitem.transform.SetAsLastSibling();

    }
}
