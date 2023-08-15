using System.Collections;
using UnityEngine;

public class OtherAmbulance : MonoBehaviour
{
    public GameObject beaconLights;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "OtherPlayer")
        {
            beaconLights.SetActive(false);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "OtherPlayer")
        {
            beaconLights.SetActive(true);
        }
    }
}
