using System;
using System.Text.RegularExpressions;

namespace Lab2._3REGEX
{
    class Program
    {
        public static void ValidPhone()
        {
            //string[] phoneNums = {
            //    "111-111-1111",
            //    "586-713-8196",
            //    "911"
            // foreach (string phoneNum in phoneNums)
            //};


            Regex regPhoneNum = new Regex(@"[0-9]{3}-[0-9]{3}-[0-9]{4}");

            bool userCont = false;

            while (userCont == false)
            {
                Console.WriteLine("Enter a phone number:");
                string phoneNum = Console.ReadLine();
                bool matchedPhoneNum = regPhoneNum.IsMatch(phoneNum);
                if (matchedPhoneNum)
                {
                    Console.WriteLine($"{phoneNum} is valid, Thank you!");
                    userCont = true;
                }
                else
                {
                    Console.WriteLine("Not a valid number. Please enter in XXX-XXX-XXXX format");
                }
            }
        }
        public static void ValidDate()
        {
            Regex regDate = new Regex(@"^[0-9]{2}/[0-9]{2}/[0-9]{4}$");

            bool userCont = false;
            while (!userCont)
            {
                Console.WriteLine("Enter a date:");
                string date = Console.ReadLine();
                bool matchedDate = regDate.IsMatch(date);
                if (matchedDate)
                {

                    Console.WriteLine($"{date} is  valid, Thank You!");
                    userCont = true;
                }
                else
                {
                    Console.WriteLine("Enter valid date in XX/XX/XXXX format");
                }



            }
        }
        public static void ValidEmail()
        {
            Regex regEmail = new Regex(@"(^[A-Za-z0-9]{5,10}@[A-Za-z0-9]{5,20}\.[A-Za-z0-9]{2,3})$");
            bool userCont = false;
            while (!userCont)
            {
                Console.WriteLine("Enter an email");
                string email = Console.ReadLine();
                bool matchedEmail = regEmail.IsMatch(email);

                if (matchedEmail)
                {
                    Console.WriteLine($"{email} is valid. Thank you!");
                    userCont = true;
                }
                else
                {
                    Console.WriteLine("Enter a valid email");
                }
            }
            }
        public static void ValidName()
        {


            Regex reg = new Regex(@"(^[A-Z]{1}([a-z]||\s||[A-Z]){1,29})$");
            bool userCont = false;

            while (!userCont)
            {
                Console.WriteLine("Enter a name:");
                string name = Console.ReadLine();
                bool matchedName = reg.IsMatch(name);

                if (matchedName)
                {
                    Console.WriteLine($"{name} is valid, Thank you!");
                    userCont = true;
                }
                else
                {
                    Console.WriteLine("Retry again. Name must start with upper case and contain only letters.");
                }

            }

            }
            static void Main(string[] args)
        {
            ValidName();
             ValidEmail();
            ValidDate();
            ValidPhone();

        }



    }
}

