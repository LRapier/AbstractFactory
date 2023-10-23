using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TacoBellFactory : IMealFactory
{
    public IMeal Create(MealRequirements requirements)
    {
        if (requirements.Vegetarian)
        {
            if (requirements.Snack)
                return new Nachos();
            else
                return new Quesadilla();
        }
        else
        {
            if (requirements.Snack)
                return new NachosGrande();
            else
                return new CrunchwrapSupreme();
        }
    }
}
