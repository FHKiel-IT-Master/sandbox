using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_Application
{
    public class Search
    {
        private string a;

        public Search(string t)
        {
            a = t;
        }

        public string GetResults()
        {
            return "String = "+a+"\nvestibulum molestie lacus. Aenean nonummy hendrerit mauris. Phasellu porta."
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