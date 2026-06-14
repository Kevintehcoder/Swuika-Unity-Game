using UnityEngine;

public class FruitEvents : MonoBehaviour
{
    FruitDataBase fruitDB;
    [Header("Random Generator")]
    [SerializeField] int RandomStart;
    [SerializeField] int RandomEnd;

    void Awake()
    {
        fruitDB = GameObject.Find("FruitDataBase").GetComponent<FruitDataBase>();


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnChoices(Vector3 Spawnlocation, FruitDataBase.Fruits currentFruit)
    {
        LevelFruitUp(currentFruit);
        Debug.Log(fruitDB.SelectedFruit);

        if (fruitDB.SelectedFruit != FruitDataBase.Fruits.None)
        {
            GameObject newFruit = fruitDB.ReturnFruits();
            
            SpawnFruit(newFruit, Spawnlocation);

        }
    }

    public void LevelFruitUp(FruitDataBase.Fruits currentFruit)
    {
        int CurrentPlace = (int)currentFruit;
        if (CurrentPlace != 12)
        {
            CurrentPlace += 1;
        }

        fruitDB.SelectedFruit = (FruitDataBase.Fruits)CurrentPlace;
        
    }

    public void SpawnFruit(GameObject newFruit, Vector3 Spawnlocation)
    {
        GameObject SpawnedFruit = Instantiate(newFruit, Spawnlocation, Quaternion.identity);
        FruitScript spawnedScript = SpawnedFruit.GetComponent<FruitScript>();
        spawnedScript.leveledSpawn = true;

    }

    public void SpawnRandomFruit()
    {
        RandomEnd = Mathf.Clamp(RandomEnd,1,12);
        RandomStart = Mathf.Clamp(RandomStart, 1, 12);
        int RandomIndex = Random.Range(RandomStart, RandomEnd);
        fruitDB.SelectedFruit = (FruitDataBase.Fruits)RandomIndex;

        GameObject newFruit = fruitDB.ReturnFruits();
        Instantiate(newFruit, gameObject.transform.position, Quaternion.identity);
    }

}
