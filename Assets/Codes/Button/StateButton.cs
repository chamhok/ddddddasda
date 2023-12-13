using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class StateButton : MonoBehaviour
{
    private StatesSO states;

    private void SetTextMeshProUGUI(string path, string text)
    {
        GameObject.Find("PopUpUi").transform.Find(path).GetComponent<TextMeshProUGUI>().text = text;
    }

    private void SomeFunction(StatesSO states)
    {
        SetTextMeshProUGUI("State/States/Strength/CurrentStrength", states.Strength.ToString());
        SetTextMeshProUGUI("State/States/Health/CurrentHealth", states.Health.ToString());
        SetTextMeshProUGUI("State/States/Agility/CurrentAgility", states.Agility.ToString());
        SetTextMeshProUGUI("State/States/Intellect/CurrentIntellect", states.Intellect.ToString());
        SetTextMeshProUGUI("State/States/Luck/CurrentLuck", states.Luck.ToString());
    }

    public void States()
    {
        states = GameManager.I._characterStats.StatesSO;
        SomeFunction(states);
    }

}
