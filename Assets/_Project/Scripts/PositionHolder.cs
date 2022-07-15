using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionHolder : MonoBehaviour
{
    [SerializeField] private Position position;
    private void Update()
    {
        position.value = transform.position;
    }
}
