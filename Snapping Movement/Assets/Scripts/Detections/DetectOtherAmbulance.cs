using UnityEngine;

public class DetectOtherAmbulance : MonoBehaviour
{
    Player player;

    private void Start()
    {
        player = FindObjectOfType<Player>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Front")
        {
            player.canGoUp = false;
        }

        if(collision.gameObject.tag == "Left")
        {
            player.canGoLeft= false;
        }

        if (collision.gameObject.tag == "Right")
        {
            player.canGoRight = false;
        }

        if (collision.gameObject.tag == "Back")
        {
            player.canGoDown = false;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Front")
        {
            player.canGoUp = true;
        }

        if (collision.gameObject.tag == "Left")
        {
            player.canGoLeft = true;
        }

        if ((collision.gameObject.tag == "Right"))
        {
            player.canGoRight = true;
        }

        if(collision.gameObject.tag == "Back")
        {
            player.canGoDown = true;
        }
    }
}
