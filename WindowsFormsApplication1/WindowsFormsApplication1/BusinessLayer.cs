using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class BusinessLayer
    {
        # region Variables
        private string varName;
        private string varAddress;
        private string varEmailId;
        private int varPhoneNumber;
        # endregion Variables

        public string Name
        {
            get
            {
                return varName;
            }
            set
            {
                varName = value;
            }
        }
        public string Address
        {
            get
            {
                return varAddress;
            }
            set
            {
                varAddress = value;
            }
        }
        public string EmailId
        {
            get {
                return varEmailId;
            }
            set
            {
                varEmailId = value;
            }
        }
        public int Phonenumber
        {
            get {
                return varPhoneNumber;
            }
            set
            {
                varPhoneNumber = value;
            }
        }

        #region Insert Details

        #endregion
    }
}
