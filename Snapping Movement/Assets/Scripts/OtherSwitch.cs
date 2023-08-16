using System.Collections;
using UnityEngine;

public class OtherSwitch : MonoBehaviour
{
    public GameObject[] spikes;
    private float afterThis = 2f;
    public Animator[] anim;
    bool hasBeenDestroyed = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && hasBeenDestroyed == false)
        {
            for (int i = 0; i < spikes.Length; i++)
            {
                StartCoroutine(Wait());
                anim[i].SetTrigger("Spikes");
                hasBeenDestroyed = true;
            }
        }
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(afterThis);
        for (int i = 0; i < spikes.Length; i++)
        {
            Destroy(spikes[i]);
        }
    }
}
