using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

//���ӿ��� ���¸� ǥ���ϰ�, ���� ������ UI�� �����ϴ� ���� �Ŵ���
//������ �� �ϳ��� ���� �Ŵ����� ������ �� ����
public class GameManager : MonoBehaviour
{
    public static GameManager instane; //�̱����� �Ҵ��� ���� ����

    public bool isGameovr = false; //���ӿ��� ����
    public TextMeshProUGUI scoreText; //������ ����� UI�ؽ�Ʈ
    public GameObject gameoverUI; //���ӿ��� �� Ȱ��ȭ�� UI ���� ������Ʈ

    private int score = 0; //���� ����

    //���� ���۰� ���ÿ� �̱����� ����
    private void Awake()
    {
        //�̱��� ���� instance�� ��� �ִ°�?
        if (instane == null)
        {
            //instance�� ��� �ִٸ�(null) �װ����� �ڱ� �ڽ��� �Ҵ�
            instane = this;
        }
        else
        {
            //instance�� �̹� �ٸ� GameManager ������Ʈ�� �Ҵ�Ǿ� �ִ� ���

            //���� �� �� �̻��� GameManager ������Ʈ�� �Ҵ�Ǿ� �ִ� ���
            //�̱��� ������Ʈ�� �ϳ��� �����ؾ� �ϹǷ� �ڽ��� ���� ������Ʈ�� �ı�
            Debug.LogWarning("���� �� �� �̻��� ���� �Ŵ����� �����մϴ�");
            Destroy(gameObject);
        }
    }

    
    void Update()
    {
        //���ӿ��� ���¿��� ������ ������Ҽ� �ְ� �ϴ� ó��
        if (isGameovr && Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    //������ ������Ű�� �޼���
   public void AddScore(int newScore)
    {
        //���ӿ����� �ƴ϶��
        if (isGameovr)
        {
            //������ ����
            score += newScore;
            scoreText.text = "Score:" + score;
        }
    }
    //�÷��̾� ĳ���� ��� �� ���ӿ����� �����ϴ� �޼���
    public void OnplayerDead()
    {
        isGameovr = true;
        gameoverUI.SetActive(true);
    }
}
