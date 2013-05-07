﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_Application
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //Here the connector to the database comes into play.
                //It will output an array of strings containing the "structure"
                //Here is just an example

                string[] ctxs = new String[10];
                ctxs[0] = "News"; ctxs[1] = "Sports"; ctxs[2] = "Music"; ctxs[3] = "Person"; ctxs[4] = "Country"; ctxs[5] = "Technology";
                ctxs[6] = "University"; ctxs[7] = "Clubs"; ctxs[8] = "Party"; ctxs[9] = "Magazines";

                LoadContext(ctxs);
            }

        }

        //Receives a array of strings to dynamically insert HTML into the contexts div
        protected void LoadContext(string[] ctx)
        {
            for (int i = 0; i < ctx.Length; i++)
            {
                contexts.InnerHtml += "<input id='tl_" + ctx[i] + "' type='button' value='" + ctx[i] + "' class='btn_tile' onclick='context_clicked(this.value)'/>";
            }
        }

        protected void Btn_Search_Click(object sender, EventArgs e)
        {
            string topic = TxtB_Input.Text == "" ? "Error" : TxtB_Input.Text;
            
            //Call the search class / refinement.

            //Redirect to the result page.
            Response.Redirect("s_results.aspx?topic="+topic+Hidden1.Value+"#!/page_results", true);
        }

        //Just an example of method. Probably won't be in this class, but in the search class.
        //The search page will request the results to show to the user.
        public static string GetResults()
        {
            return "vestibulum molestie lacus. Aenean nonummy hendrerit mauris. Phasellu porta."
                    + "Fusce suscipit varius mi. Cum sociis natoque penatibus et magnis dis parturient moascetur ridiculus mus. "
                    + "Nulla dui. Fusce feugiat malesuada odio. Morbi nunc odio gida atcursus necuctus a lorem. Maecenastrique orci ac sem.<br/>"
                    + "Duis tempor velit nec orci vulputate ac elementum ligula faucibus. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices" 
                    + "posuere cubilia Curae; Aenean malesuadravida dolor nec accumsan. Fusce tincidunt odio ac sem laoreet nec rhoncus lacus consectetur?" 
                    + "Nunc a pellentesque mi. Mauris ullamcorper scelerisque nulla a facilisis. Nunc id tellus dui. Donec ultricies gravida fringilla. "
                    + "Suspendisse cursus pretium eleifentudin, diam id lacinia bibendum, diam ligula feugiat felis, at porttitor."
                    + "Fusce suscipit varius mi. Cum sociis natoque penatibus et magnis dis parturient moascetur ridiculus mus. "
                    + "Nulla dui. Fusce feugiat malesuada odio. Morbi nunc odio gida atcursus necuctus a lorem. Maecenastrique orci ac sem.<br/>"
                    + "Duis tempor velit nec orci vulputate ac elementum ligula faucibus. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices"
                    + "posuere cubilia Curae; Aenean malesuadravida dolor nec accumsan. Fusce tincidunt odio ac sem laoreet nec rhoncus lacus consectetur?"
                    + "Nunc a pellentesque mi. Mauris ullamcorper scelerisque nulla a facilisis. Nunc id tellus dui. Donec ultricies gravida fringilla. "
                    + "Suspendisse cursus pretium eleifentudin, diam id lacinia bibendum, diam ligula feugiat felis, at porttitor.";
        }
    }
}