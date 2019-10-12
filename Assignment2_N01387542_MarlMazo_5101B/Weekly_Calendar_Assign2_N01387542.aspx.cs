using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



namespace Assignment2_N01387542_MarlMazo_5101B
{
    public partial class Weeky_Calendar_Assignment2_N01387542 : System.Web.UI.Page
    {
        // Initialize my Page
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                //Validating Page
                Page.Validate();
                if (Page.IsValid)
                {  
                    /*This code will work in any month with different number of Days.
                    Simple change the name_Month, days_Month, startDay_Month and initial_Day. startDay_Month should be the same as _initial_day*/
                    
                    //Initialize Values
                    string name_Month = "October";    
                    //Days in a month
                    int days_Month = 31;
                    //0 = Sunday, 1 = Monday, 2 = Tuesday, 3 = Wednesday, 4 = Thursday, 5 = Friday, 6 = Saturday
                    int startDay_Month = 2;
                    weekSummary_User.InnerHtml = "";
                    /* Similar with Start Day but a constant value that wont change.
                    This was neccessary for adding to the condition of FOR LOOP, because foreach loop starts its loop in Sunday to Saturday, thus changing the start day of the month
                    need to adjust the value of the condition to make it always true and get all the days in the month*/
                    const int initial_day = 2;
                    string[] weekDays_Month = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };               
                    int i = 0;

                    /* I used for loop earlier but it turns out that my increment value should be done within the foreach statement does, adding an increment of i++ will only add an extra value for i that will skip some of the loops I need.
                    So I used a while loop which the increment is on the last part of code*/

                    // This is to adjust the starting day of the month, since start day of every month is changing. Without adding length to the days_Month
                    //it wont print every value since every loop is done per 7 count in the FOREACH. Thus a values only divisible to 7 or until the 28th day will be printed.
                    //adding the initial_day - 1 will print every values until the last day of the Month
                    while ( i <= (days_Month+initial_day-1))
                    {
                        // Reference on Christine Bittle in-class example October 2019
                        foreach (ListItem workDay_User in workDay_User.Items)
                        {
                            
                            if (i <= (days_Month+initial_day-1))
                            {
                                //Values for startDay_Month should not be greather than 6, cause this variable is use in string [] weekDays_Month which can only take 0-6 values. 
                                if (startDay_Month <7)
                                {
                                    //Compare value to the string weekDays_Month to the Selected Value
                                    if (weekDays_Month[startDay_Month] == workDay_User.Value)
                                    {
                                        //Selected will print "work day"
                                        if (workDay_User.Selected)
                                        {
                                            weekSummary_User.InnerHtml += name_Month+" "+ (i-(initial_day-1)) + " is a " + weekDays_Month[startDay_Month] + "! Time to work...<br>";                                
                                        }
                                        //Unselected will print "Fun day"
                                        else
                                        {
                                            weekSummary_User.InnerHtml += name_Month+ " "+(i-(initial_day-1)) + " is a " + weekDays_Month[startDay_Month] + "! Time to have fun!<br>";    
                                        }
                                        //increment the value get all the days in a week
                                        startDay_Month++;
                                    }                    
                                }
                                //If startDay_Month increase more than 7, initial its value back to zero
                                else
                                {
                                    startDay_Month = 0;
                                    if (weekDays_Month[startDay_Month] == workDay_User.Value)
                                    {
                                        if (workDay_User.Selected)
                                        {
                                            weekSummary_User.InnerHtml += name_Month+" "+ (i-(initial_day-1)) + " is a " + weekDays_Month[startDay_Month]+ "! Time to work...<br>";                                      
                                        }
                                        else
                                        {
                                            weekSummary_User.InnerHtml += name_Month+" "+ (i-(initial_day-1)) + " is a " + weekDays_Month[startDay_Month]+ "! Time to have fun!<br>";              
                                        }
                                        startDay_Month++;
                                    }    
                                }
                            } 
                            //for the 7th value, i=7
                            //goes back to for loop with i++ as increment, i=8, thus removing i=7 to the loop if your using FOR LOOP with increment
                            i++;           
                        }
                    }
                }
            }
        }
        //Reference on Christine Bittle in-class example October 2019
        protected void WorkDay_User_Validate(object sender, ServerValidateEventArgs e)
        {   
            foreach(ListItem li in workDay_User.Items)
            {
                if (li.Selected)
                {
                    // return the code once it found only one li.selected = true
                    // It will stop all the code once it says to return values
                    e.IsValid = true;
                    return;
                }
                else
                {
                    e.IsValid = false;
                }
            }
            
        }
      
    }
}