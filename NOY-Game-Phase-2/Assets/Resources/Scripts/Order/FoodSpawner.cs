using UnityEngine;
using UnityEngine.UI;

public class FoodSpawner : MonoBehaviour
{
    public GameObject foodItemPrefab;
    public Transform contentPanel;
    public Sprite[] goFoods;
    public Sprite[] growFoods;
    public Sprite[] glowFoods;

    void Start()
    {
        SpawnFood(goFoods, FoodData.FoodType.Go);
        SpawnFood(growFoods, FoodData.FoodType.Grow);
        SpawnFood(glowFoods, FoodData.FoodType.Glow);
    }

    void SpawnFood(Sprite[] sprites, FoodData.FoodType type)
    {
        foreach (Sprite sprite in sprites)
        {
            GameObject item = Instantiate(foodItemPrefab, contentPanel);
            var foodData = item.GetComponent<FoodData>();
            foodData.foodType = type;
            foodData.SetSprite(sprite);
        }
    }
}
