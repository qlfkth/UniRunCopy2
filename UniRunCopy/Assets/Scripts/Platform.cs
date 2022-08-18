using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�������μ� �ʿ��� ������ ���� ��ũ��Ʈ
public class Platform : MonoBehaviour
{
    public GameObject[] obstacles;//��ֹ� ������Ʈ��
    private bool stepped = false; //�÷��̾� ĳ���Ͱ� ��Ҵ°�

    //������Ʈ�� Ȱ��ȭ�� ������ �Ź� ����Ǵ� �޼���
    private void OnEnable()
    {
        //������ �����ϴ� ó��
        //���� ���¸� ����
        stepped = false;
        //��ֹ��� ����ŭ ����
        for(int i = 0; i < obstacles.Length; i++)
        {
            obstacles[i].SetActive(Random.Range(0, 3) == 0 ? true : false);
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        //�浹�� ������ �±װ� Player�̰� ������ �÷��̾� ĳ���Ͱ� ���� �ʾҴٸ�

        if (collision.collider.tag == "Player" && !stepped)
        {
            //������ �߰��ϰ� ���� ���¸� ������ ����
            stepped = true;
            GameManager.instane.AddScore(1);
        }
        

    }
}
