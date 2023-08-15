using UnityEngine;
using UnityEngine.SceneManagement;

public class Panel : MonoBehaviour
{
    public GameObject panel;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player" || collision.gameObject.tag == "OtherPlayer")
        {
            panel.SetActive(true);
        }
    }
}
