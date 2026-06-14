using System.Collections;
using UnityEngine;

public class InstantiateFruit : MonoBehaviour
{

    FruitEvents fruitEvents;
    public static bool isSpawned = false;

    void Awake()
    {
        fruitEvents = GameObject.Find("FruitEvents").GetComponent<FruitEvents>();
    }
    void Start()
    {
        fruitEvents.SpawnRandomFruit();
        StartCoroutine(SpawnFruit());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator SpawnFruit()
    {
        while (true)
        {
            if (ContainerScript.IsGameOver == false)
            {
                if (isSpawned == true)
                {
                    yield return new WaitForSeconds(1f);
                    fruitEvents.SpawnRandomFruit();
                    isSpawned = false;

                }
                else
                {
                    yield return null;

                }
            }
            else 
            {
                yield return null;
            }
        }
    }

}
