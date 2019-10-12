using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment2_N01387542_MarlMazo_5101B
{
    public partial class Coordinate_Assignment2_N01387542 : System.Web.UI.Page
    {   
        //Validate The page first
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                Page.Validate();
                if (Page.IsValid)
                {
                    //Initialize variables to convert to integers
                    int xValue_Coordinate = Convert.ToInt32(xValue_Number.Text);
                    int yValue_Coordinate = Convert.ToInt32(yValue_Number.Text);

                    //Values are X coordinate is positive and Y coordinate is positive
                    //Coordinates are in Quadrant I
                    if (xValue_Coordinate >0 && yValue_Coordinate > 0)
                    {
                        results_Number.InnerHtml = "Your coordinates lies under Quadrant I";
                    }
                    //Values are X-coordinate is negative and Y-coordinate is positive
                    //Coordinates are in Quadrant II
                    else if (xValue_Coordinate <0 && yValue_Coordinate > 0)
                    {
                        results_Number.InnerHtml = "Your coordinates lies under Quadrant II";
                    }
                    //Values are X-coordinate is negative and Y-coordinate is negative
                    //Coordinates are in Quadrant III
                    else if(xValue_Coordinate <0 && yValue_Coordinate <0)
                    {
                        results_Number.InnerHtml = "Your coordinates lies under Quadrant III";
                    }
                    //Values are X-coordinate is positive and Y-coordinate is negative
                    //Coordinates are in Quadrant IV
                    else if(xValue_Coordinate > 0 && yValue_Coordinate < 0)
                    {
                        results_Number.InnerHtml = "Your coordinates lies under Quadrant IV";
                    }
                    // if X = 0, it will be in x-origin
                    else if(xValue_Coordinate == 0)
                    {
                        results_Number.InnerHtml = "Your coordinates lies in the X-origin";
                    }
                    //if y =0, it will be in y-origin
                    else if(yValue_Coordinate == 0)
                    {
                        results_Number.InnerHtml = "Your coordinates lies in the Y-origin";
                    }
                    //Values of X-coordinate and Y-coordinate are in origin
                    // Values X = 0 and Y = 0
                    else
                    {
                        results_Number.InnerHtml = "Your coordinates lies in the origin";
                    }
                }
            }
        }
    }
}