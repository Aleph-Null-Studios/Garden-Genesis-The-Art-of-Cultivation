using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class dateController : MonoBehaviour
{
    /*variables*/
    [SerializeField] TextMeshProUGUI dateText;  //displays the current date

    //date
    int curYear;                //which year it currently is 
    int curMonth;               //which month it currently is (of the year)
    int curDay;                 //which day it currently is (of the month)

    //total tracker
    int totalDays;              //Number of total days that have passed in the game. (used for plants growth)

    /*Customizable Variables*/

    //max time restraints
    int numMonthsInYear = 18;   //Number of months in each year
    int numDaysInMonth = 30;    //Number of days in each month (please do not pick a prime number because it breaks the system)

    //starting date 
    int startYear = 2023;       //starting year
    int startMonth = 2;         //starting month (must be equal to or less than number of months in each year)
    int startDay = 3;           //starting day (must be equal to or less than the number of days in each month)

    
    /*Methods*/

    // Start is called before the first frame update
    void Start()
    {
        //start the day counter
        totalDays = 1; //very first day so its set to 1

        //current date would be the very first day
        curYear = startYear;    
        curMonth = startMonth;
        curDay = startDay;

        //update the display of the date on screen
        dateText.text = $"{curMonth}/{curDay}/{curYear}";

    }//end of start method


    //Increase time is called when a button is pressed(onclick). The button will pass through the correct incrememnet of time to be changed. 
    public void IncreaseTime(int numDaysChanging)
    {
        /* This works assuming that the buttons only incrememnt by one at a time*/
        //update total days
        totalDays += numDaysChanging;

        //update current time

        //add the days that have changed
        curDay += numDaysChanging;
        
        //if the current day exceeds number of days in a month
        if(curDay>numDaysInMonth)
        {
            //the new curent day in month would be the current number minus the total possible days. The remainder is the new current day.
            curDay = curDay - numDaysInMonth;
            //it would be the next month so update month
            curMonth++;
        }//end day check

        //if the current year exceeds number of months in a year
        if(curMonth>numMonthsInYear)
        {
            //the new current month would be the remainder of number of months in a year subtracted from the current current month. 
            curMonth = curMonth - numMonthsInYear;
            //it would be a new year so update the year
            curYear++;
        }//end month check

        //update the display of the date on screen
        dateText.text = $"{curMonth}/{curDay}/{curYear}";

    }//end of increase time method

    //GetTotalDays is called from the plants to compare when they were planted and track their growth.
    public int GetTotalDays()
    {
        return totalDays;
    }


}//end of class 
