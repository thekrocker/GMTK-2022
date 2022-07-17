using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthUpgrader : BaseUpgrader
{
    public override void Upgrade()
    {
        foreach (var stat in stats)
        {
            stat.initialHealth = targetAmount;
        }
    }
}