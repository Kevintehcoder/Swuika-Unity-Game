using UnityEngine;

public class FruitDataBase : MonoBehaviour
{
    public GameObject FruitOne;
    public GameObject FruitTwo;
    public GameObject FruitThree;
    public GameObject FruitFour;
    public GameObject FruitFive;
    public GameObject FruitSix;
    public GameObject FruitSeven;
    public GameObject FruitEight;
    public GameObject FruitNine;
    public GameObject FruitTen;
    public GameObject FruitEleven;
    public GameObject FruitTwelve;

    public Fruits SelectedFruit;

    public enum Fruits
    { 
        None,
        FruitOne,
        FruitTwo,
        FruitThree,
        FruitFour,
        FruitFive,
        FruitSix,
        FruitSeven,
        FruitEight,
        FruitNine,
        FruitTen,
        FruitEleven,
        FruitTwelve,
    }



    public GameObject ReturnFruits()
    {
        switch (SelectedFruit)
        {
            case Fruits.FruitOne:
                {
                    return FruitOne;
                }
            case Fruits.FruitTwo:
                {
                    return FruitTwo;
                }
            case Fruits.FruitThree:
                {
                    return FruitThree;
                }
            case Fruits.FruitFour:
                {
                    return FruitFour;
                }
            case Fruits.FruitFive:
                {
                    return FruitFive;
                }
            case Fruits.FruitSix:
                { 
                    return FruitSix;
                }
            case Fruits.FruitSeven:
                {
                    return FruitSeven;
                }
            case Fruits.FruitEight:
                {
                    return FruitEight;
                }
            case Fruits.FruitNine:
                {
                    return FruitNine;
                }
            case Fruits.FruitTen:
                {
                    return FruitTen;
                }
            case Fruits.FruitEleven:
                {
                    return FruitEleven;
                }
            case Fruits.FruitTwelve:
                {
                    return FruitTwelve;
                }
            default:
                {
                    return null;
                }
                
        }

    }

}
