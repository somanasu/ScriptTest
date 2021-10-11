using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        int[] array = new int[5];
        array[0] = 34;
        array[1] = 28;
        array[2] = 73;
        array[3] = 13;
        array[4] = 98;    
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }
        for (int  i= 4;  i >= 0; i--)
        {
            Debug.Log(array[i]);
        }

    }
}