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


    private void Update()                
    {
        //����� �Է��� �����ϰ� �����ϴ� ó��
        if (isDead)
        {
            //��� �� ó���� �� �̻� �������� �ʰ� ����
            return;
        }
        //���콺 ���� ��ư�� ��������&&�ִ� ���� Ƚ��(2)�� �������� �ʾҴٸ�
        if (Input.GetMouseButtonDown(0) && jumpCount < 2)
        {
            //���� Ƚ�� ����
            jumpCount++;
            //���� ������ �ӵ��� ���������� ����(0,0)�� ����
            playerRigidbdy.velocity = Vector2.zero;
            //������ٵ� �������� �� �ֱ�
            playerRigidbdy.AddForce(new Vector2(0, jumpForce));
            //����� �ҽ� ���
            playerAudio.Play();
        }
        else if (Input.GetMouseButtonUp(0) && playerRigidbdy.velocity.y > 0)
        {
            //���콺 ���� ��ư���� ���� ���� ���� && �ӵ��� y ���� ������(���� ��� ��)
            //���� �ӵ��� �������� ����
            playerRigidbdy.velocity = playerRigidbdy.velocity * 0.5f;
           
        }
        //�ִϸ������� Grounded �Ķ���͸� isGounded ������ ����
        animator.SetBool("Grounded", isGrounded);
    }

    private void Die()
    {
        //�ִϸ������� Dis Ʈ���� �Ķ���͸� ��
        animator.SetTrigger("Die");

        //����� �ҽ��� �Ҵ�� ����� Ŭ���� deathClip���� ����
        playerAudio.clip = deathClip;
        //��� ȿ���� ���
        playerAudio.Play();

        //�ӵ��� ����(0,0)�� ����
        playerRigidbdy.velocity = Vector2.zero;
        //��� ���¸� true�� ����
        isDead = true;

        //���� �Ŵ����� ���ӿ��� ó�� ����
        GameManager.instane.OnplayerDead();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Dead" && !isDead) 
        {
            Die();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //�ٴڿ� ������� �����ϴ� ó��
        //� �ݶ��̴��� �������, �浹 ǥ���� ������ ���� ������
        if (collision.contacts[0].normal.y>0.7f)
        {
            //isGrounded�� true�� �����ϰ�, ���� ���� Ƚ���� 0���� ����
            isGrounded = true;
            jumpCount = 0;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        //�ٴڿ��� ������� �����ϴ� ó��
        //� �ݶ��̴����� ������ ��� isGrounded�� false�� ����
        isGrounded = false;
        
    }

}
