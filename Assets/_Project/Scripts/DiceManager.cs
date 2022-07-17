using System;
using System.Collections;
using System.Collections.Generic;
using _Project.Scripts.Managers;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;

public class DiceManager : MonoBehaviour
{
    [SerializeField] private GameObject diceCanvas;
    [SerializeField] private BaseUpgrader[] upgrades;
    [SerializeField] private Button rollDiceButton;

    private Dice _dice;

    private void Awake()
    {
        _dice = GetComponent<Dice>();
    }

    private void OnEnable()
    {
        Actions.OnWaveEnd += OpenDiceCanvas;
        Actions.OnDiceRoll += HandleUpgrades;
    }

    private void OnDisable()
    {
        Actions.OnWaveEnd -= OpenDiceCanvas;
        Actions.OnDiceRoll -= HandleUpgrades;
    }

    public void RollDice()
    {
        _dice.GetRandomDice();
        rollDiceButton.interactable = false;

    }

    private void OpenDiceCanvas()
    {
        diceCanvas.SetActive(true);
        rollDiceButton.interactable = true;
    }

    private void HandleUpgrades(int diceNumber)
    {
        var upgIdex = diceNumber - 1;

        Debug.Log(diceNumber);
        

        StartCoroutine(CO_HandleUpgrade());

        IEnumerator CO_HandleUpgrade()
        {
            yield return new WaitForSeconds(1f);
            upgrades[upgIdex].transform.DOScale(Vector3.one * 1.3f, 1f).SetLoops(2, LoopType.Yoyo).OnComplete(() => upgrades[upgIdex].Upgrade());
            
            yield return new WaitForSeconds(3f);
            
            diceCanvas.SetActive(false);
            
            Actions.OnUpgraded?.Invoke();
        }

    }
}