using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
     for(int i = 0; i < 2; i++)
        {
            for (int j = 0; j <= i; j++) 
            {
                Debug.Log("*");
            }
        }



    }
}



