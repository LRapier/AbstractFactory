using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleFactory : AbstractVehicleFactory
{
    private readonly IVehicleFactory factory;
    private readonly VehicleRequirements requirements;

    public VehicleFactory(VehicleRequirements requirements)
    {
        factory = requirements.HasEngine ? new PoweredFactory() : new ManPoweredFactory();
        this.requirements = requirements;
    }
    public override IVehicle Create()
    {
        return factory.Create(requirements);
    }
}