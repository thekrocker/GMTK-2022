using System.Collections;
using System.Collections.Generic;
using _Project.Scripts.Managers;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Dice : MonoBehaviour
{
    public GameObject TextBox;
    public int randomNum;

    public void RandomNumber(int maxNum)
    {
        randomNum = Random.Range(1, maxNum + 1);
        TextBox.GetComponent<TextMeshProUGUI>().text = "" + randomNum;
    }


    public void GetDiceResult()
    {
        switch (randomNum)
        {
            case 1:
                Actions.OnUpgradeDamage?.Invoke();
                break;
            case 2:
                Actions.OnUpgradeHealth?.Invoke();
                break;
            case 3:
                Actions.OnUpgradeMovementSpeed?.Invoke();
                break;
            case 4:
                Actions.OnUpgradeWaveCount?.Invoke();
                break;
        }
    }
}