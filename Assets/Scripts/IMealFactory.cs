using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMealFactory
{
    IMeal Create(MealRequirements requirements);
}