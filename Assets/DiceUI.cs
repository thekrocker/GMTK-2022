using System;
using System.Collections;
using System.Collections.Generic;
using _Project.Scripts.Managers;
using UnityEngine;
using UnityEngine.UI;

public class DiceUI : MonoBehaviour
{
    private Image _img;
    [SerializeField] private Sprite[] sprites;


    private void Awake()
    {
        _img = GetComponent<Image>();
    }

    private void OnEnable()
    {
        Actions.OnDiceRoll += SetSprite;
    }

    private void OnDisable()
    {
        Actions.OnDiceRoll -= SetSprite;
    }

    public void SetSprite(int idx)
    {
        _img.sprite = sprites[idx - 1];
    }
}