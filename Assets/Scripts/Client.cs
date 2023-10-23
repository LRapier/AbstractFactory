using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Client : MonoBehaviour
{
    public Toggle vegetarian;
    public Toggle snack;
    public TMP_Dropdown restaurant;
    public GameObject result;
    public TextMeshProUGUI mealName;
    public Image mealImage;
    public Sprite[] images;

    public void CreateMeal()
    {
        var requirements = new MealRequirements();

        requirements.Vegetarian = vegetarian.isOn;
        requirements.Snack = snack.isOn;
        requirements.Restaurant = restaurant.value;

        var meal = GetMeal(requirements);

        Debug.Log(meal.GetType().Name);

        result.SetActive(true);
        switch(meal.GetType().Name)
        {
            case "BigMac":
                mealImage.sprite = images[0];
                mealName.text = "Big Mac";
                break;
            case "Hotcakes":
                mealImage.sprite = images[1];
                mealName.text = "Hot Cakes";
                break;
            case "McNuggets":
                mealImage.sprite = images[2];
                mealName.text = "4 Piece McNugget";
                break;
            case "ApplePie":
                mealImage.sprite = images[3];
                mealName.text = "Apple Pie";
                break;
            case "CrunchwrapSupreme":
                mealImage.sprite = images[4];
                mealName.text = "Crunchwrap Supreme";
                break;
            case "Quesadilla":
                mealImage.sprite = images[5];
                mealName.text = "Quesadilla";
                break;
            case "NachosGrande":
                mealImage.sprite = images[6];
                mealName.text = "Nachos Grande";
                break;
            case "Nachos":
                mealImage.sprite = images[7];
                mealName.text = "Nachos";
                break;
            case "MeatMountain":
                mealImage.sprite = images[8];
                mealName.text = "The Meat Mountain";
                break;
            case "Nothing":
                mealImage.sprite = images[9];
                mealName.text = "Nothing hahahahaha";
                break;
            case "RoastBeefSlider":
                mealImage.sprite = images[10];
                mealName.text = "Roast Beef Slider";
                break;
            case "CheeseSticks":
                mealImage.sprite = images[11];
                mealName.text = "Mozzarella Sticks";
                break;
        }
    }
    private static IMeal GetMeal(MealRequirements requirements)
    {
        var factory = new MealFactory(requirements);
        return factory.Create();
    }
    public void GoBack()
    {
        result.SetActive(false);
    }
}