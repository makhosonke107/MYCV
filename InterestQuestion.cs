using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuturePath.Business_Logic
{
    public  class InterestQuestion
    {

        private string interestText;
        private int interestID;

        public InterestQuestion(string interestText, int interestID)
        {
            this.interestText= interestText;
            this.interestID=interestID;
        }

        public InterestQuestion()
        {
            interestText="";
            interestID = 0;


        }
        /*  getQuestion() as a List */
    }
}
