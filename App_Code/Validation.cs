using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GSMS.App_Code
{
    class Validate
    {
         /*   //validation for email
         public string ValidateEmail(string email)
         {
             bool isValid = true;
               if (string.IsNullOrEmpty(email))
               {
                   isValid = false;
               }
               else
               {
                   try
                   {
                       MailAddress m = new MailAddress(email);
                       isValid = true;
                   }
                   catch (FormatException)
                   {
                       isValid = false;
                   }
               }
             return("the mail id is " + isValid);
         }
         public string ValidateName(string nameInput)
         {
             //validation for Name
             bool isValid = true;
             if (string.IsNullOrEmpty(nameInput))
                 isValid = false;
             else
             {
                 isValid = Regex.IsMatch(nameInput, @"^[a-zA-Z]+$");
                 foreach (char c in nameInput)
                 {
                     if (!Char.IsLetter(c))
                         isValid = false;
                 }
             }
             return("the name is " + isValid);
         }
         public string ValidateNumber(string phone)
         {
             //validation for Number
             bool isValid = true;
        
             foreach (char c in phone)
             {
                 if (!Char.IsDigit(c))
                     isValid = false;
             }
            return("the number is " + isValid);
         }*/
    }
}
