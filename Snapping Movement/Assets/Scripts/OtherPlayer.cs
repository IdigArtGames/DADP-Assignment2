using UnityEngine;

public class OtherPlayer : MonoBehaviour
{
    public Vector2 offset;
    private float Pos = 1f;
    public void MoveUp()
    {
        offset = new Vector2(transform.position.x, transform.position.y + Pos);
        transform.position = offset;

    }

    public void MoveDown()
    {
        offset = new Vector2(transform.position.x, transform.position.y -Pos);
        transform.position = offset;
    }

    public void MoveRight()
    {
        offset = new Vector2(transform.position.x + Pos, transform.position.y);
        transform.position = offset;
    }

    public void MoveLeft()
    {
        offset = new Vector2(transform.position.x - Pos, transform.position.y);
        transform.position = offset;
    }
}
