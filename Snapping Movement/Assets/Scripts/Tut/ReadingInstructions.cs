using UnityEngine;

public class ReadingInstructions : MonoBehaviour
{
    public GameObject info;
    void Awake()
    {
        Time.timeScale = 0.0001f;
    }
    
    public void PlayGame()
    {
        Time.timeScale = 1f;
        info.SetActive(false);
    }
}
