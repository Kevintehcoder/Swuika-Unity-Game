using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenez : MonoBehaviour
{
    public static Scenez instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReloadScene()
    {
        ScoreScript.ScoreData.Score = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void LoadScene(int sceneNum)
    {
        ScoreScript.ScoreData.Score = 0;
        SceneManager.LoadScene(sceneNum);
    }


}
