using System.Collections;
using System.Collections.Generic;
using _Project.Scripts.Managers;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Dice : MonoBehaviour
{
    public int randomNum;
    private int _diceCount = 6;

    public void GetRandomDice()
    {
        randomNum = Random.Range(1, _diceCount + 1);
        Actions.OnDiceRoll?.Invoke(randomNum);
    }
}