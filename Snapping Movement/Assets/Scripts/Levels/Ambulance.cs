using System.Collections;
using UnityEngine;

public class Ambulance : MonoBehaviour
{
    public GameObject beaconLights;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            beaconLights.SetActive(false);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            beaconLights.SetActive(true);
        }
    }
}
