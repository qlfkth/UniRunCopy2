using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test01 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string userlnput = "10";

        int number=int.Parse(userlnput);
        if (number > 0)
        {
            if (number % 2 == 0)
            {
                Debug.Log("0보다 큰 짝수");
            }
            else
            {
                Debug.Log("0보다 큰 홀수");

            }
            Debug.Log(number % 2 == 0?"0보다 큰 짝수":"0보다 큰 홀수");
        }
        else
        {
            Debug.Log("0보다 작거나 같은수");

        }


    }

   
}
