using System.Collections;
using UnityEngine;

public class HasWon : MonoBehaviour
{
    public GameObject winScreen;
    Ambulance car;
    OtherAmbulance otherCar;
    void Start()
    {
        car = FindObjectOfType<Ambulance>();
        otherCar = FindObjectOfType<OtherAmbulance>();
    }


    void Update()
    {
        if(!car.beaconLights.activeSelf && !otherCar.beaconLights.activeSelf)
        {
            winScreen.SetActive(true);
        }
    }
}
