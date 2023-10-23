using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MealFactory : AbstractMealFactory
{
    private readonly IMealFactory factory;
    private readonly MealRequirements requirements;

    public MealFactory(MealRequirements requirements)
    {
        switch (requirements.Restaurant)
        {
            case 0:
                factory = new McDonaldsFactory();
                break;
            case 1:
                factory = new TacoBellFactory();
                break;
            case 2:
                factory = new ArbysFactory();
                break;
        }
        this.requirements = requirements;
    }
    public override IMeal Create()
    {
        return factory.Create(requirements);
    }
}