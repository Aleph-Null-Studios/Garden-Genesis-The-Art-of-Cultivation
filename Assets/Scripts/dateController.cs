using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class dateController : MonoBehaviour
{
    /*variables*/
    //buttons
    [SerializeField] Button dayJumpButton;  //when pressed increases day
    [SerializeField] Button weekJumpButton;  //when pressed increases week
    [SerializeField] Button monthJumpButton;  //when pressed increases month
    [SerializeField] Button yearJumpButton;  //when pressed increases year

    //date
    int curYear;            //which year it currently is 
    int curMonth;           //which month it currently is
    int curDay;             //which day it currently is 

    //max time restraints
    int numMonthsInYear = 18;   //Number of months in the year
    int numWeeksInMonth = 3;    //Number of weeks in a month
    int numDaysInWeek = 10;     //Number of days in the week
    int numDaysInYear;          //Number of days in a year (defined in start)
    int numDaysInMonth;         //Number of days in the month (defined in start)



    //time relative
    int curDayInWeek;       //which day of the week is it
    int curWeekInMonth;     //which week of the month is it

    //total tracker
    int totalDays;          //how many days have passed since start of game

    // Start is called before the first frame update
    void Start()
    {
        //start the day counter
        totalDays = 0; //this starts at 0 because no days have passed. 

        //current date would be the very first day
        curYear = 1;
        curMonth = 1;
        curDay = 1;

        curDayInWeek = 1;
        curWeekInMonth = 1;
        
        //set variables
        numDaysInYear = numMonthsInYear * numWeeksInMonth * numDaysInWeek;
        numDaysInMonth = numWeeksInMonth * numDaysInWeek;
    }//end of start method

    // Update is called once per frame
    void Update()
    {
        
    }//end of update method

    //CheckEnd is called when time is increased
    bool CheckEnd(string checkingEndOf)
    {
        //if you have a valid search
        if (checkingEndOf == "week" || checkingEndOf == "month" || checkingEndOf == "year")
        {
            //if what you are checking is currently above the maximun of what it could be
            if ((checkingEndOf == "week" && curDayInWeek > numDaysInWeek) ||
                (checkingEndOf == "month" && curWeekInMonth > numWeeksInMonth) ||
                (checkingEndOf == "year" && curMonth > numMonthsInYear))
            {
                //it is the end of the date variable you are checking
                return true;
            }//end if past max range

            else
            {
                //the date is still in range
                return false;
            }//end else in range
        }//end if checking week,month,year

        //search invalid
        else
        {
            Debug.Log("Invalid search condition");
            return false;
        }//end search invalid

    }//end of check end method

    //Increase time is called when a button is pressed 
    void IncreaseTime(Button inputChanging)
    {
        /*varibales*/
        int numDaysChanging = 0;

        //search for a valid button being pressed
        if (inputChanging == dayJumpButton || inputChanging == weekJumpButton || inputChanging == monthJumpButton || inputChanging == yearJumpButton)
        {
            //find out how many days are changing based on the button pressed.
            if (inputChanging == dayJumpButton)
            {
                numDaysChanging = 1;
            }//end day button
            else if (inputChanging == weekJumpButton)
            {
                numDaysChanging = numDaysInWeek;
            }//end week button
            else if (inputChanging == monthJumpButton)
            {
                numDaysChanging = numDaysInMonth;
            }//end month button
            else if (inputChanging == yearJumpButton)
            {
                numDaysChanging = numMonthsInYear;
            }//end year button

            //change the days
            totalDays += numDaysChanging;

        }//end corrent button
        else
        {
            Debug.Log("Time not effected");
           
        }//end else

    }//end of increase time method

    //called when the time changes
    void UpdateTime(int numDaysChanged)
    {
        /*variables*/
        bool isEndOf;
        int intWeekDayDif;

    

    }//end of method update time

    void timeLeft()
    {

    }
}//end of class 
