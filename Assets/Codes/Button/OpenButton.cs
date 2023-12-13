using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenButton : MonoBehaviour
{
    public void OpenInventory()
    {
        GameObject.Find("PopUpUi").transform.Find("Inventory").gameObject.SetActive(true);
    }
    public void OpenState()
    {
        GameObject.Find("PopUpUi").transform.Find("State").gameObject.SetActive(true);
    } 
    public void OpenItemManagement()
    {
        GameObject.Find("PopUpUi").transform.Find("ItemManagement").gameObject.SetActive(true);
    }
}
