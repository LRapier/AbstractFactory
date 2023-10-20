using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoweredFactory : IVehicleFactory
{
    public IVehicle Create(VehicleRequirements requirements)
    {
        if (requirements.NumberOfWheels <= 2 && requirements.Passengers <= 2)
            return new Motorcycle();

        else if (requirements.NumberOfWheels == 4)
        {
            if (requirements.Passengers <= 2)
                return new SportsCar();
            else if (requirements.Passengers <= 4)
                return new Sedan();
            else if (requirements.Passengers <= 8)
                return new SUV();
            else
                return new Bus();
        }

        else
        {
            return new ImpossiblePowered();
        }
    }
}
