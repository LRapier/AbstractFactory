using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManPoweredFactory : IVehicleFactory
{
    public IVehicle Create(VehicleRequirements requirements)
    {
        if (requirements.NumberOfWheels == 1 && requirements.Passengers == 1)
            return new Unicycle();
        else if (requirements.NumberOfWheels == 2 && requirements.Passengers == 1)
            return new Scooter();
        else if (requirements.NumberOfWheels == 2 && requirements.Passengers <= 2)
            return new Bicycle();
        else if (requirements.NumberOfWheels == 3 && requirements.Passengers == 1)
            return new Tricycle();
        else if (requirements.NumberOfWheels == 4 && requirements.Passengers == 1)
            return new TrainingWheels();
        else if (requirements.NumberOfWheels == 4 && requirements.Passengers <= 2)
            return new ToyCar();
        else if (requirements.NumberOfWheels == 4 && requirements.Passengers <= 4)
            return new TapedBikes();
        else
            return new ImpossibleManpowered();
    }
}
