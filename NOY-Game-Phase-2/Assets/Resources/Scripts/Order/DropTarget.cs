using UnityEngine;
using UnityEngine.EventSystems;

public class DropTarget : MonoBehaviour, IDropHandler
{
    public FoodData.FoodType acceptedType;

    public void OnDrop(PointerEventData eventData)
    {
        GameObject dragged = eventData.pointerDrag;
        if (dragged == null) return;

        FoodData foodData = dragged.GetComponent<FoodData>();
        if (foodData != null && foodData.foodType == acceptedType)
        {
            dragged.transform.SetParent(transform);
            dragged.GetComponent<RectTransform>().anchoredPosition = Vector2.zero;

            Debug.Log("Correct drop: " + foodData.foodType);
        }
        else
        {
            Debug.Log("Wrong drop! Expected: " + acceptedType + ", but got: " + foodData?.foodType.ToString());
            // Optionally: Play sound, shake, or reject item
        }
    }
}
