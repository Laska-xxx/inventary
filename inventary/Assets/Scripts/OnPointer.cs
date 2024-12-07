using UnityEngine;
using UnityEngine.EventSystems;

public class OnPointer : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private InventaryManager manager;
    private ScriptableObj item;

    public void SetManager(InventaryManager manager)
    {
        this.manager = manager;
    }

    public void SetItem(ScriptableObj item)
    {
        this.item = item;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (manager != null && item != null)
        {
            manager.ShowInfo(item);
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (manager != null)
        {
            manager.ClearInfo();
        }
    }
}
