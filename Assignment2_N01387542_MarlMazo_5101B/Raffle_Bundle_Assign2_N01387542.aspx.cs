using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment2_N01387542_MarlMazo_5101B
{
    public partial class Raffle_Bundle_Assign2_N01387542 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Initialize the Page first
            if (Page.IsPostBack)
            {
                Page.Validate();
                if (Page.IsValid)
                {
                    //initilize values
                    int OrderedTickets_User = Convert.ToInt32(orderedTickets_User.Text);
                    // division of bundle
                    int number_Bundle = 0;
                    // total number of tickets per loop
                    int TotalNumber_Tickets = 0;
                    //maximum value of ticket, similar of what the OrderedTickets_User but it will decrease in value as the loop goes by
                    int MaximumNumber_Tickets = OrderedTickets_User;
                    double costPerTicket = 0.25;
                    //create a loop that will print every purchase ticket
                    // did try FOR Loop but I need the increment after the if-else statment, and has different increment depending on the bundle
                    results_Tickets.InnerHtml = "";
                    int i = 0;
      

                    while (i < OrderedTickets_User)
                    {
                       // if ticket purchase is less than and equal to 50, bundle of 1
                        if (OrderedTickets_User <= 50)
                        {
                            number_Bundle = 1;
                            TotalNumber_Tickets = TotalNumber_Tickets + number_Bundle;
                            // every time the TotalNumber_Tickets increase, the maximumNumber_Tickets decreasing.
                            MaximumNumber_Tickets = MaximumNumber_Tickets - number_Bundle;

                            if (MaximumNumber_Tickets < 0)
                            {
                                results_Tickets.InnerHtml += "Your leftover is " + ((MaximumNumber_Tickets % number_Bundle) + number_Bundle) + " ticket(s). That’s " + (TotalNumber_Tickets  + (MaximumNumber_Tickets % number_Bundle)) + " ticket(s)!<br>";
                            }
                            else
                            {
                                results_Tickets.InnerHtml += "You received a bundle of " + number_Bundle + "! That’s " + TotalNumber_Tickets + " ticket(s)!<br>";
                            }
                            i = i + number_Bundle;

                        }
                        //if ticket puchase is 51 to 150 including 150, bundle of 2
                        else if (OrderedTickets_User>51 && OrderedTickets_User <=150)
                        {
                            number_Bundle = 2;
                            TotalNumber_Tickets = TotalNumber_Tickets + number_Bundle;                         
                            MaximumNumber_Tickets = MaximumNumber_Tickets - number_Bundle;
                            
                            if (MaximumNumber_Tickets < 0)
                            {
                                results_Tickets.InnerHtml += "Your leftover is " + ((MaximumNumber_Tickets % number_Bundle)+number_Bundle) + " ticket(s). That’s " + (TotalNumber_Tickets + (MaximumNumber_Tickets % number_Bundle)) + " ticket(s)!<br>";
                            }
                            else
                            {
                                results_Tickets.InnerHtml += "You received a bundle of " + number_Bundle + "! That’s " + TotalNumber_Tickets + " ticket(s)!<br>";
                            }
                            i = i + number_Bundle;
                        }
                        // if ticket purchase is 151 to 300 including 300  bundle of 3
                        else if (OrderedTickets_User >150 && OrderedTickets_User <=300)
                        {
                            number_Bundle = 3;
                            TotalNumber_Tickets = TotalNumber_Tickets + number_Bundle;
                            MaximumNumber_Tickets = MaximumNumber_Tickets - number_Bundle;

                            if (MaximumNumber_Tickets < 0)
                            {
                                results_Tickets.InnerHtml += "Your leftover is " + ((MaximumNumber_Tickets % number_Bundle) + number_Bundle) + " ticket(s). That’s " + (TotalNumber_Tickets + (MaximumNumber_Tickets % number_Bundle)) + " ticket(s)!<br>";
                            }
                            else
                            {
                                results_Tickets.InnerHtml += "You received a bundle of " + number_Bundle + "! That’s " + TotalNumber_Tickets + " ticket(s)!<br>";
                            }
                            i = i + number_Bundle;
                        }
                        // if ticket purchase is 301 and above, bundle of 5
                        else
                        {
                            number_Bundle = 5;
                            TotalNumber_Tickets = TotalNumber_Tickets + number_Bundle;
                            MaximumNumber_Tickets = MaximumNumber_Tickets - number_Bundle;

                            if (MaximumNumber_Tickets < 0)
                            {
                                results_Tickets.InnerHtml += "Your leftover is " + ((MaximumNumber_Tickets % number_Bundle) + number_Bundle) + " ticket(s). That’s " + (TotalNumber_Tickets + (MaximumNumber_Tickets % number_Bundle)) + " ticket(s)!<br>";
                            }
                            else
                            {
                                results_Tickets.InnerHtml += "You received a bundle of " + number_Bundle + "! That’s " + TotalNumber_Tickets + " ticket(s)!<br>";
                            }
                            i = i + number_Bundle;
                        }        
                    }
                    //Print total cost and total number of tickets
                    results_Tickets.InnerHtml += "Your total ticket(s) is " + (TotalNumber_Tickets + (MaximumNumber_Tickets % number_Bundle)) + " and your cost is $" + ((TotalNumber_Tickets + (MaximumNumber_Tickets % number_Bundle)) * costPerTicket) + "cad!<br>";
        
                }
            }
        }
    }
}