using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NPC : MonoBehaviour
{
    public GameObject bubble;
    public TextMeshProUGUI bubbleTMP;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            Player scriptPlayer = collision.GetComponent<Player>();

            //�������
            switch (GM.instance.eProgress)
            {
                case GM.Progress.����Ʈ�ޱ���:
                    bubbleTMP.text = "ü���� �ι�°�� �Ծ�";
                    GM.instance.eProgress = GM.Progress.����Ʈ����_����X;
                    break;
                case GM.Progress.����Ʈ����_����X:
                    bubbleTMP.text = "� �԰� ��";
                    break;
                case GM.Progress.����Ʈ����_����O:
                    //NPC���� �÷��̾���.itemNames ���ٹ��
                    //1. ������ ����
                    //2. �̱���
                    //3. collisionȰ��
                    if(scriptPlayer.itemNames[1] == "cherry")
                    {
                        //����Ʈ�� �����O
                        bubbleTMP.text = "���߾�.";
                        GM.instance.eProgress = GM.Progress.����Ʈ�Ϸ�;
                    }
                    else
                    {
                        //����Ʈ�� �����X
                        bubbleTMP.text = "������," + "\n" + "ü���� 2��°��";
                        GM.instance.eProgress = GM.Progress.����Ʈ����_����X;
                        scriptPlayer.itemNames.Clear();
                    }
                    break;
                case GM.Progress.����Ʈ�Ϸ�:
                    bubbleTMP.text = "�����߾�";
                    break;
            }

            bubble.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            bubble.SetActive(false);
        }
    }
}
