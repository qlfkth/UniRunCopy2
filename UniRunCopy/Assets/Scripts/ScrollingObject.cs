using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//���� ������Ʈ�� ��� �������� �����̴� ��ũ��Ʈ
public class ScrollingObject : MonoBehaviour
{
    public float speed = 10;// �̵��ӵ�
    
  
    void Update()
    {
        //���� ������Ʈ�� ���� �ӵ��� �������� �����̵��ϴ� ó��
        //�ʴ� speed�� �ӵ��� �������� �����̵�
        if (!GameManager.instane.isGameovr)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        
    }
}
