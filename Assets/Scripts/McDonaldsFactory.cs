using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class McDonaldsFactory : IMealFactory
{
    public IMeal Create(MealRequirements requirements)
    {
        if(requirements.Vegetarian)
        {
            if (requirements.Snack)
                return new ApplePie();
            else
                return new Hotcakes();
        }
        else
        {
            if (requirements.Snack)
                return new McNuggets();
            else
                return new BigMac();
        }
    }
}