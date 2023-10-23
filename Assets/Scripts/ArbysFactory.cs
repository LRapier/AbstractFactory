using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArbysFactory : IMealFactory
{
    public IMeal Create(MealRequirements requirements)
    {
        if (requirements.Vegetarian)
        {
            if (requirements.Snack)
                return new CheeseSticks();
            else
                return new Nothing();
        }
        else
        {
            if (requirements.Snack)
                return new RoastBeefSlider();
            else
                return new MeatMountain();
        }
    }
}