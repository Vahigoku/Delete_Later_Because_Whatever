//using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgingAger : MonoBehaviour
{
  
    public int currentAge;
    public int maxAge = 10 ;
    public void Start()
    {
        currentAge += 1;
        Debug.Log(currentAge);
        /*currentAge = 0;
        Debug.Log("Age is set to 0, restarting...");*/
        Aging();
    }
    public void Aging()
    {
        for(int i = 0; maxAge > currentAge; i ++)
        {
            currentAge += 1;
            //Debug.Log("New ages:");
            Debug.Log(currentAge);
        }
    }
}
