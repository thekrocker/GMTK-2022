using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour
{
   public void RandomNumber(int maxNum)
   {
    int randomNum = Random.Range(1,maxNum+1);
    Debug.Log(randomNum);
   }
}
