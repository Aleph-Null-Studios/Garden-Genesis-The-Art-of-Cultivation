using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class dateController : MonoBehaviour
{
    /*variables*/

    //date
    int curYear;                //which year it currently is 
    int curMonth;               //which month it currently is (of the year)
    int curDay;                 //which day it currently is (of the month)

    //max time restraints
    int numMonthsInYear = 18;   //Number of months in each year
    int numDaysInMonth = 30;    //Number of days in each month 
    int numDaysInYear;          //Number of days in each (defined in start)
    
    //total tracker
    int totalDays;             //how many days have passed since the start of the gane

    // Start is called before the first frame update
    void Start()
    {
        //start the day counter
        totalDays = 0; //at the begining no days have passed so this is 0

        //current date would be the very first day
        curYear = 1;    
        curMonth = 1;
        curDay = 1;
        
        //set variables
        numDaysInYear = numMonthsInYear * numDaysInMonth;

    }//end of start method

    // Update is called once per frame
    void Update()
    {
        
    }//end of update method

   
    //Increase time is called when a button is pressed(onclick). The button will pass through the correct incrememnet of time to be changed. 
    void IncreaseTime(int numDaysChanging)
    {
        //update the total number of days based on the amount of time added.(selected with button)
        totalDays += numDaysChanging;

        //update the calander date
        UpdateTime();

    }//end of increase time method

    //called when the time changes
    void UpdateTime()
    {
        /*find the current day,month and year. */
        
        //current year = starting year (1) + this rounded down: (total days that have passed/total days in a year)
        curYear = 1 + Mathf.FloorToInt(totalDays / numDaysInYear);
        

    }//end of method update time

}//end of class 
