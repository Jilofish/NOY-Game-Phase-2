using UnityEngine;
using UnityEngine.UI;

public class FoodData : MonoBehaviour
{
    public enum FoodType { Go, Grow, Glow }
    public FoodType foodType;

    public void SetSprite(Sprite sprite)
    {
        GetComponent<Image>().sprite = sprite;
    }
}
