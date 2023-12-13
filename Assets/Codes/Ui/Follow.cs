using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public GameObject Player;
    RectTransform rect;    //Ui�� Ʈ�������� �޸� ���� ������ ����� ��� �Ѵ�.

    private void Awake()
    {
        rect = GetComponent<RectTransform>();
    }

    private void FixedUpdate()
    {
        rect.position = Camera.main.WorldToScreenPoint(new Vector3(Player.transform.position.x, (Player.transform.position.y), Player.transform.position.z));
    }
}