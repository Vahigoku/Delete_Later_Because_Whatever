using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class DaysOfWeeksOfSomething : MonoBehaviour
{
    string[] weekDays = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
    string[] importantActivities = { "Build Gunpla", "Dance, Dance, Revolution", "Taser tasting", "Lego building", "Arbejde", "On the knees with the wide mouth", "WhO" };
    int dayNumber = 1;
    int maxWeekDays = 7;
    
    public void Start()
    {
        
        if (dayNumber < maxWeekDays)
        {
            for (int i = 0; i < maxWeekDays; i++)
            {
                Activity();
                //Debug.Log("-----------------------------------");
                dayNumber += 1;

            }
           
        }
        else
        {
            Debug.Log("Wha?");

        }
    }
    public void Activity()
    {
        int randomActivity = Random.Range(0, 6);
        switch (dayNumber)
        {
            case 1:
                Debug.Log(weekDays[0]);
                Debug.Log(importantActivities[randomActivity]);
                Debug.Log("-----------------------------------");
                break;
            case 2:
                Debug.Log(weekDays[1]);
                Debug.Log(importantActivities[randomActivity]);
                Debug.Log("-----------------------------------");
                break;
            case 3:
                Debug.Log(weekDays[2]);
                Debug.Log(importantActivities[randomActivity]);
                Debug.Log("-----------------------------------");
                break;
            case 4:
                Debug.Log(weekDays[3]);
                Debug.Log(importantActivities[randomActivity]);
                Debug.Log("-----------------------------------");
                break;
            case 5:
                Debug.Log(weekDays[4]);
                Debug.Log(importantActivities[randomActivity]);
                Debug.Log("-----------------------------------");
                break;
            case 6:
                Debug.Log(weekDays[5]);
                Debug.Log(importantActivities[randomActivity]);
                Debug.Log("-----------------------------------");
                break;
            case 7:
                Debug.Log(weekDays[6]);
                Debug.Log(importantActivities[randomActivity]);
                Debug.Log("-----------------------------------");
                break;

        }
    } 
}
