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
                Debug.Log("�Է��Ͻ� ����" + number + "��A���� �Դϴ�.");
            }
            else if (number >= 80)
            {
                Debug.Log("�Է��Ͻ� ����" + number + "��B���� �Դϴ�.");
            }
            else if (number >= 70)
            {
                Debug.Log("�Է��Ͻ� ����" + number + "��C���� �Դϴ�.");
            }
            else if (number < 70)
            {
                Debug.Log("�Է��Ͻ� ����" + number + "��F�� �Դϴ�.");
            }




        }
    }
}

    

