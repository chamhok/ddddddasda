using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateInventory: MonoBehaviour
{
    public ItmeStatsHandeler itmeStatsHandeler;
    public GameObject Content;
    private GameObject _space;
    private ItmeStates _itmeState;

    private void Start()
    {
        foreach (var item in itmeStatsHandeler.StatsModifiers)
        {
            GameManager.I.ItemDictionary.Add(item.Name, item);

        }
    }
    public void Inventory()
    {
        if (Content.transform.childCount > 0)
        {
            foreach (Transform item in Content.transform)
            {
                Destroy(item.gameObject);
            }
        }

       
        foreach (var value in GameManager.I.ItemDictionary.Values)
        {
            _space = Instantiate(value.itemSO.Prefeb, Content.transform);
            if (value.IsInstl)
            {
                _space.transform.Find("Mounting").gameObject.SetActive(true);

            }
            else
            {
                _space.transform.Find("Mounting").gameObject.SetActive(false);
            }
            _itmeState = Instantiate(value, _space.transform);
            _space.name = _itmeState.name;
            _space.transform.Find("Icon").GetComponent<Image>().sprite = Resources.Load<Sprite>($"Item/{_itmeState.name.Remove(_itmeState.name.Length - 7)}");
        }
        for (int i = 0; i < 40; i++)
        {
            _space = Instantiate(_itmeState.itemSO.Prefeb, Content.transform);
            _space.transform.Find("Icon").gameObject.SetActive(false);
        }
    }
}
