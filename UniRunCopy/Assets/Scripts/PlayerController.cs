using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//PlayerController는 플레이어 캐릭터로서 Player 게임 오브젝트를 제어함
public class PlayerController : MonoBehaviour
{
    public AudioClip deathClip;//사망 시 재생할 오디오 클립
    public float jumpForce = 700f; // 점프 함
    private int jumpCount = 0;//누적 점프 횟수
    private bool isGrounded = false;//바닥에 닿았는지 나타냄
    private bool isDead = false;//사망상태

    private Rigidbody2D playerRigidbdy;//사용할 리지드바디 컴포넌트
    private Animator animator;//사용할 애니메이터 컴포넌트
    private AudioSource playerAudio;//사용할 오디오 소스 컴포넌트




    void Start()
    {
        //게임 오브젝트로부터 사용할 ㅅ컴포넌트들을 가져와 변수에 할당
        playerRigidbdy = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        playerAudio = GetComponent<AudioSource>();

    }


    private void Update()                
    {
        //사용자 입력을 감지하고 점프하는 처리
        if (isDead)
        {
            //사망 시 처리르 더 이상 진행하지 않고 종료
            return;
        }
        //마우스 왼쪽 버튼을 눌렀으며&&최대 점프 횟수(2)에 도달하지 않았다면
        if (Input.GetMouseButtonDown(0) && jumpCount < 2)
        {
            //점프 횟수 증가
            jumpCount++;
            //점프 직전에 속도를 순간적으로 제로(0,0)로 변경
            playerRigidbdy.velocity = Vector2.zero;
            //리지드바디에 위쪽으로 힘 주기
            playerRigidbdy.AddForce(new Vector2(0, jumpForce));
            //오디오 소스 재생
            playerAudio.Play();
        }
        else if (Input.GetMouseButtonUp(0) && playerRigidbdy.velocity.y > 0)
        {
            //마우스 왼쪽 버튼에서 손으 떼는 순간 && 속도의 y 갑이 양수라면(위로 상승 중)
            //현재 속도를 절반으로 변경
            playerRigidbdy.velocity = playerRigidbdy.velocity * 0.5f;
           
        }
        //애니메이터의 Grounded 파라미터를 isGounded 값으로 갱신
        animator.SetBool("Grounded", isGrounded);
    }

    private void Die()
    {
        //애니메이터의 Dis 트리거 파라미터를 셋
        animator.SetTrigger("Die");

        //오디오 소스에 할당된 오디오 클립을 deathClip으로 변경
        playerAudio.clip = deathClip;
        //사망 효과음 재생
        playerAudio.Play();

        //속도를 제로(0,0)로 변경
        playerRigidbdy.velocity = Vector2.zero;
        //사망 상태를 true로 변경
        isDead = true;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
       
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //바닥에 닿았음을 감지하는 처리
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        //바닥에서 벗어났음을 감지하는 처리
    }

}
