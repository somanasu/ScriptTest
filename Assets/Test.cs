using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        int[] array = new int[5];
        array[0] = 0;
        array[1] = 1;
        array[2] = 2;
        array[3] = 3;
        array[4] = 4;    
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }
        for (int  i= 4;  i == -1; i--)
        {
            Debug.Log(array[i]);
        }

    }
}