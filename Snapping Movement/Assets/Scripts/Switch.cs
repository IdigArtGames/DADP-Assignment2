using System.Collections;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public GameObject[] spikes;
    private float afterThis = 3f;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "OtherPlayer")
        {
            for (int i=0; i<spikes.Length; i++)
            {
                StartCoroutine(Wait());
            }
        }
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(afterThis);
        for (int i=0;i<spikes.Length;i++)
        {
            Destroy(spikes[i]);
        } 
    }
}
