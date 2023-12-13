using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemManagermentButton : MonoBehaviour
{
    private ItmeStates _itmeStates;
    private Button InstlButton;
    private Button UnInstlButton;

    private void Start()
    {
        _itmeStates = transform.GetComponentInChildren<ItmeStates>();
        InstlButton = GameManager.I.InstlButton;
        UnInstlButton = GameManager.I.UnInstlButton;
    }
    private void SetTextMeshProUGUI(string path, string text)
    {
        GameObject.Find("PopUpUi").transform.Find(path).GetComponent<TextMeshProUGUI>().text = text;
    }

    public void SomeFunction(ItmeStates _itmeStates)
    {
        SetTextMeshProUGUI("ItemManagement/Item/Name", _itmeStates.Name);
        SetTextMeshProUGUI("ItemManagement/Item/Explanation", _itmeStates.Explanation);
        SetTextMeshProUGUI("ItemManagement/States/Strength/Text", _itmeStates.Strength.ToString());
        SetTextMeshProUGUI("ItemManagement/States/Health/Text", _itmeStates.Health.ToString());
        SetTextMeshProUGUI("ItemManagement/States/Agility/Text", _itmeStates.Agility.ToString());
        SetTextMeshProUGUI("ItemManagement/States/Intellect/Text", _itmeStates.Intellect.ToString());
        SetTextMeshProUGUI("ItemManagement/States/Luck/Text", _itmeStates.Luck.ToString());
    }
    public void ItemManagermenting()
    {
        GameManager.I.CurrentItme = GameManager.I.ItemDictionary[_itmeStates.Name];
        SomeFunction(_itmeStates);
        GameObject.Find("PopUpUi")
           .transform.Find("ItemManagement")
           .transform.Find("Item")
           .transform.Find("Icon")
           .transform.Find("Image")
           .GetComponent<Image>().sprite = Resources.Load<Sprite>($"Item/{_itmeStates.name.Remove(_itmeStates.name.Length - 7)}");
        if (GameManager.I.ItemDictionary[GameManager.I.CurrentItme.Name].IsInstl == true)
        {
            InstlButton.interactable = false;
            UnInstlButton.interactable = true;
        }
        else
        {
            InstlButton.interactable = true;
            UnInstlButton.interactable = false;
        }
    }
}
