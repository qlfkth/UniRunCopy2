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
                Debug.Log("0���� ū ¦��");
            }
            else
            {
                Debug.Log("0���� ū Ȧ��");

            }
            Debug.Log(number % 2 == 0?"0���� ū ¦��":"0���� ū Ȧ��");
        }
        else
        {
            Debug.Log("0���� �۰ų� ������");

        }


    }

   
}
