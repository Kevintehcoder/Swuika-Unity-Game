using UnityEngine;

public class ContainerScript : MonoBehaviour
{
    [SerializeField]GameObject GameOverUI;
    public static bool IsGameOver = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame


    private void OnTriggerExit2D(Collider2D collision)
    {
        GameOver();
    }

    public void GameOver()
    {
        Time.timeScale = 0;
        IsGameOver = true;
        GameOverUI.SetActive(true);
        
        
    }
}
