using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearButton : MonoBehaviour
{
    private GameObject _target;
    private void Awake()
    {
        _target = transform.parent.gameObject;
    }
    public void Clear()
    {
        _target.SetActive(false);
    }
}
