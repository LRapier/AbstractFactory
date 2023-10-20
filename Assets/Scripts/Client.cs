using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Client : MonoBehaviour
{
    public Toggle hasEngine;
    public TMP_InputField wheelCount;
    public TMP_InputField passengerCount;
    public TextMeshProUGUI vehicle;

    public void CreateVehicle()
    {
        var requirements = new VehicleRequirements();

        requirements.HasEngine = hasEngine.isOn;
        requirements.Passengers = int.Parse(passengerCount.text);
        requirements.NumberOfWheels = int.Parse(wheelCount.text);

        var vehicle = GetVehicle(requirements);

        Debug.Log(vehicle.GetType().Name);
        this.vehicle.text = vehicle.GetType().Name;
    }
    private static IVehicle GetVehicle(VehicleRequirements requirements)
    {
        var factory = new VehicleFactory(requirements);
        return factory.Create();
    }
}