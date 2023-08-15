using UnityEngine;

public class Player : MonoBehaviour
{
    public Vector2 yPos;
    public float offset = 1;
    public bool canGoUp = true;
    public bool canGoDown = true;
    public bool canGoLeft = true;
    public bool canGoRight = true;

    OtherPlayer player;

    void Start()
    {
        player = FindObjectOfType<OtherPlayer>();
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow) && canGoUp)
        {
            yPos = new Vector2(transform.position.x, transform.position.y + offset);
            transform.position = yPos;
            player.MoveDown();
        }

        if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow) && canGoDown)
        {
            yPos = new Vector2(transform.position.x, transform.position.y - offset);
            transform.position = yPos;           
            player.MoveUp();
        }

        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow) && canGoLeft)
        {
            yPos = new Vector2(transform.position.x - offset, transform.position.y);
            transform.position = yPos;
            player.MoveRight();
        }

        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow) && canGoRight)
        {
            yPos = new Vector2(transform.position.x + offset, transform.position.y);
            transform.position = yPos;
            
            player.MoveLeft();
        }
    }
}
