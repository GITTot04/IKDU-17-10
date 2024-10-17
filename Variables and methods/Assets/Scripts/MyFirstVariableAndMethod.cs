using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstVariableAndMethod : MonoBehaviour
{
    // HOMEWORK: Write an age increase function with comments. 1: Return age next year. 2: Return age after "n" years. 3: Confirm it with Debug.Log()
    int currentAge = 20;
    int ageIncrease = 4;
    /*
    int a = 512;
    int b = 731;
    */
    void Start()
    {
        //HOMEWORK
        Debug.Log("My current age: " + currentAge);
        Debug.Log("My age next year: " + IncreaseAge(currentAge));
        Debug.LogFormat("My age in {0} years: " + IncreaseAge(currentAge, ageIncrease), ageIncrease);
        ageIncrease = 7;
        Debug.LogFormat("My age in {0} years: " + IncreaseAge(currentAge, ageIncrease), ageIncrease);
        ageIncrease = 28;
        Debug.LogFormat("My age in {0} years: " + IncreaseAge(currentAge, ageIncrease), ageIncrease);

        /*
        Debug.LogFormat("a={0} b={1}", a, b);
        int tempValue = a;
        a = b;
        b = tempValue;
        Debug.LogFormat("a={0} b={1}", a, b);

        int d0 = 10;
        int d1 = 20;
        Debug.Log("d0=" + d0 + " d1=" + d1);
        (d0, d1) = SwapValue(d0, d1);
        Debug.Log("d0=" + d0 + " d1=" + d1);

        float f0 = 1.5f;
        float f1 = 7.3f;
        (f0, f1) = SwapValue(f0, f1);
        Debug.Log("f0=" + f0 + " f1=" + f1);
        */
    }
    /// <summary>
    /// Increases age by one and returns the value
    /// </summary>
    private int IncreaseAge(int age)
    {
        return age + 1;
    }
    /// <summary>
    /// Increases age by an integer and returns the value
    /// </summary>
    private int IncreaseAge(int age, int years)
    {
        return age + years;
    }
    /*
    /// <summary>
    /// Returns the value of two integers in opposite order as a tuple
    /// </summary>
    private (int, int) SwapValue(int a, int b)
    {
        return (b, a);
    }
    /// <summary>
    /// Returns the value of two floats in opposite order as a tuple
    /// </summary>
    private (float, float) SwapValue(float a, float b)
    {
        return (b, a);
    }
    */
}