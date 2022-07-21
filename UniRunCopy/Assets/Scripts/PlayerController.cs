using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//PlayerController�� �÷��̾� ĳ���ͷμ� Player ���� ������Ʈ�� ������
public class PlayerController : MonoBehaviour
{
    public AudioClip deathClip;//��� �� ����� ����� Ŭ��
    public float jumpForce = 700f; // ���� ��
    private int jumpCount = 0;//���� ���� Ƚ��
    private bool isGrounded = false;//�ٴڿ� ��Ҵ��� ��Ÿ��
    private bool isDead = false;//�������

    private Rigidbody2D playerRigidbdy;//����� ������ٵ� ������Ʈ
    private Animator animator;//����� �ִϸ����� ������Ʈ
    private AudioSource playerAudio;//����� ����� �ҽ� ������Ʈ



    
    void Start()
    {
        //���� ������Ʈ�κ��� ����� ��������Ʈ���� ������ ������ �Ҵ�
        playerRigidbdy = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        playerAudio = GetComponent<AudioSource>();

    }


    void Update()
    {
        //����� �Է��� �����ϰ� �����ϴ� ó��
    }

    private void Die()
    {
        //���ó��
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //Ʈ���� �ݶ��̴��� ���� ��ֹ����� �浹�� ����,�浹������ �� �ѹ�
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //�ٴڿ� ������� �����ϴ� ó��
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        //�ٴڿ��� ������� �����ϴ� ó��
    }

}
