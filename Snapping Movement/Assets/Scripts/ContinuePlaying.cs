using UnityEngine;

public class ContinuePlaying : MonoBehaviour
{
    public GameObject sound;

    private void Awake()
    {
        DontDestroyOnLoad(sound);
    }
}
