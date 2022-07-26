using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test03 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string Class = "4";
        string userlnput = "65";
        int number = int.Parse(Class);
        int velru = int.Parse(userlnput);

        if (number > 4 || number < 0 || velru > 100 || velru < 0) ;
        {
            Debug.Log("°æ°í");
            return;



        }

    }

    
}
