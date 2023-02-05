using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class MoneyManager : MonoBehaviour
{
    /*Variables*/
    [SerializeField] TextMeshProUGUI currancyBalanceText;  //displays the current balance/ammount of money the player has

    int startingBalance = 350;    //how much money the player starts with
    int currnetBalance;           //how much money the player currently has
    int goalBalance = 2000;       //how much money the player needs to have to win

    bool gameOver = false;        //when the player makes enough money they win the game 

    // Start is called before the first frame update
    void Start()
    {
        //set the starting current balance
        currnetBalance = startingBalance;

        //show balance on screen
        DisplayBalance();
    }//end start method

    //display balance text is called at the start and also when the balance changes
    private void DisplayBalance()
    {
        currancyBalanceText.text = $"{currancyBalanceText}";
    }//end display balance tmethod

    //this method is called whenever a player chooses to sell a plant
    public void SellPlant(int plantPrice)
    {
        //increase the current balance
        currnetBalance += plantPrice;

        //check to see if they won
        HasEnoughToWin();

    }//end of sell plant method

    //buy plant is called whenever a player chooses to buy a new plant
    public bool BuyPlant( int plantPrice)
    {
        //variables
        bool isSuccessfulTransaction;

        //check to see if they have enough money to buy the plant
        if(currnetBalance >= plantPrice)
        {
            //update balance
            currnetBalance -= plantPrice;

            //mark the transation as succesful
            isSuccessfulTransaction = true;
        }//end if has enough money
        else
        {
            //not enough money
            isSuccessfulTransaction = false;

        }//end else

        return isSuccessfulTransaction;
    }//end of buy plant method

    //Has enough to win is called everytime the player makes money
    void HasEnoughToWin()
    {
        //if they met the goal to win the game
        if(currnetBalance >= goalBalance)
        {
            //they win
            gameOver = true;

        }//end if

        else
        {
            //they didnt win yet
            gameOver = false;

        }//end else

    }//end hasEnoughToWin method

    //this is called when checking to see if the game is over/the player has won
    public bool GetHasWon()
    {
        return gameOver;
    }//end method for getting win status

}//end class
