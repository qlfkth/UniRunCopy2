using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test02 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string uesrlnput = "80";

        int number = int.Parse(uesrlnput);
        if (number > 0)
        {
            if (number >= 90)
            {
                Debug.Log("입력하신 점수" + number + "은A학점 입니다.");
            }
            else if (number >= 80)
            {
                Debug.Log("입력하신 점수" + number + "은B학점 입니다.");
            }
            else if (number >= 70)
            {
                Debug.Log("입력하신 점수" + number + "은C학점 입니다.");
            }
            else if (number < 70)
            {
                Debug.Log("입력하신 점수" + number + "은F점 입니다.");
            }




        }
    }
}

    

