using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public GameObject Player;
    RectTransform rect;    //Ui는 트렌스폼과 달리 따로 변수를 만들어 줘야 한다.

    private void Awake()
    {
        rect = GetComponent<RectTransform>();
    }

    private void FixedUpdate()
    {
        rect.position = Camera.main.WorldToScreenPoint(new Vector3(Player.transform.position.x, (Player.transform.position.y), Player.transform.position.z));
    }
}