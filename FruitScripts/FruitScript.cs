using NUnit.Framework.Constraints;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using static FruitDataBase;

public class FruitScript : MonoBehaviour
{
    [SerializeField]FruitDataBase.Fruits currentFruit;
    ScoreScript scoreScript;
    FruitEvents fruitEvent;
    Rigidbody2D rb2d;
    public bool clicked = false;
    [SerializeField] int ScoreIncrease;

    public bool leveledSpawn = false;
    static LayerMask LastFruitOption;

    public bool IsInContainer = false;

    void Awake()
    {
        fruitEvent = FindAnyObjectByType<FruitEvents>();
        scoreScript = FindAnyObjectByType<ScoreScript>();

        LastFruitOption = LayerMask.NameToLayer("FruitTwelve");
        rb2d = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        if (leveledSpawn == true)
        {
            clicked = true;
        }
    }

    private void Update()
    {
        Debug.Log("Is in container: "+IsInContainer);
        if (Mouse.current.leftButton.wasPressedThisFrame && clicked == false)
        {
            clicked = true;
            InstantiateFruit.isSpawned = true;
        }


        if (clicked == false)
        {
            rb2d.linearVelocity = Vector3.zero;
            FruitFollowMouse();
        }


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == gameObject.layer && gameObject.GetInstanceID() < collision.gameObject.GetInstanceID())
        {
            if (gameObject.layer != LastFruitOption.value)
            {
                fruitEvent.SpawnChoices(gameObject.transform.position, currentFruit);

            }


            scoreScript.IncreaseScore(ScoreIncrease);
            CleanUpObject(collision.gameObject, gameObject);
        }
    }




    public void CleanUpObject(GameObject objectone, GameObject objecttwo)
    { 
        Destroy(objectone);
        Destroy(objecttwo);
    }

    public void FruitFollowMouse()
    {
        if (leveledSpawn == false)
        {
            Vector3 MousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
            MousePos.x = Mathf.Clamp(MousePos.x, -19, 20);
            MousePos = new Vector3(MousePos.x, 20, 0);
            transform.position = MousePos;
        }
    }


}
