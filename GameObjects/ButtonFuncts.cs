using UnityEngine;

public class ButtonFuncts : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadScene(int SceneNum)
    {
        Scenez.instance.LoadScene(SceneNum);
    }

    public void Restart()
    {
        Time.timeScale = 1.0f;
        Scenez.instance.ReloadScene();
    }
}
