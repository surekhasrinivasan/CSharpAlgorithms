using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountEmailsByDomain
{
    // Program that lists the total number of emails by domain
    // Ex: Input : "aa@xyz.com;cc@abc.com;bb@abc.com;dd@abc.com";
    //    Output : Domain = xyz.com & Count = 1, Domain = abc.com & Count = 3

    class Program
    {
        static void Main(string[] args)
        {
            // List of emails separated by semi colon. 
            string UserInputEmails = "aa@xyz.com;cc@abc.com;bb@abc.com;dd@abc.com";

            // Split the string into string array
            string[] UserEmails = UserInputEmails.Split(';');

            // select only the domain part of the emails into a string array, using substring() function
            string[] EmailsDomain = UserEmails.Select(x => x.Substring(x.LastIndexOf("@") + 1)).ToArray();

            // Group the emails by email domain, and select the Domain and respective count
            var Result = EmailsDomain.GroupBy(x => x).Select(y => new { Domain = y.Key, Count = y.Count() });

            // Finally print the domain name and the emails count
            foreach(var obj in Result)
            {
                Console.WriteLine("Domain = {0} & Count= {1}", obj.Domain, obj.Count);
            }
        }
    }
}
