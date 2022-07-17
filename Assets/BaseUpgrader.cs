using System;
using _Project.Scripts;
using TMPro;
using UnityEngine;

public abstract class BaseUpgrader : MonoBehaviour
{
    [SerializeField] protected EnemyStats[] stats;

    [SerializeField] private TextMeshProUGUI infoText;
    [TextArea(10, 15)] [SerializeField] private string info;
    
    [SerializeField] protected int targetAmount = 20;


    private void Start()
    {
        SetInfoText();
    }

    private void SetInfoText()
    {
        infoText.text = $"{info} by {targetAmount}";
    }

    public abstract void Upgrade();
}