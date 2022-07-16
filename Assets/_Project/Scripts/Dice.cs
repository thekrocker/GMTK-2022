using System.Collections;
using System.Collections.Generic;
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
}
