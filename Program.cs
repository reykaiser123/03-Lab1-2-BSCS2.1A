using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //assist to produce the looping
            bool firstloop = true;
            bool secondloop = true;
            bool thirdloop = true;

            //path
            String directoryPath = "C:\\Users\\User\\Documents\\Requirements";

            String[] fileCheck = {
                    "Form137.xlsx","GoodMoral.pdf","PSA.pdf", "MedicalCertification.pdf","SHSDiploma.pdf"
                };
            String[] askRequirements = {"Form137", "GoodMoral", "PSA", "MedicalCertification", "SHSDiploma" };
            String[] courses = { "Bachelor of Science in Computer Science (BSCS)", "Bachelor of Science in Information Technology (BSIT)",
                "Bachelor of Science Business Administration(BSBA)", "Bachelor of Science in Accountancy(BSA)" };
            String[] courseskey = {"A.BSCS", "B.BSIT", "C.BSBA", "D.BSA" };


            Console.WriteLine("STUDENT REGISTRATION");

            //looping where it keep repeating when invalid input
            while (firstloop)
            {
                Console.WriteLine("Welcome to STI \nAre you planning to enroll? Yes or No");
                String enroll = Console.ReadLine();

                //condition for enrollment
                if (enroll == "yes" || enroll == "Yes" || enroll == "YES")
                {
                  
                    Console.WriteLine("Please submit these requirements first to enroll. ");
                    
                    //THIS PRINT THE "askRequirements" above
                    foreach (String requirements in askRequirements)
                    {

                        Console.WriteLine(requirements);

                        //cancel Looping
                        firstloop = false;

                    }

                        //looping
                        while (secondloop)
                        {
                        
                            Console.WriteLine("Have you already submit all the requirements? Yes or No");
                            String submitReq = Console.ReadLine();

                            
                            //condition
                            if (submitReq == "yes" || submitReq == "Yes" || submitReq == "YES")
                            {

                            secondloop = false;

                            //to check the files in file manager
                              foreach (String fileName in fileCheck)
                              {

                               String filePath = Path.Combine(directoryPath, fileName);

                                  if (File.Exists(filePath))
                                  {

                                   Console.WriteLine("Document Submitted.");
                                    
                                  }
                                  else
                                  {

                                   Console.Write($" {fileName} you haven't submitted this requirements");//planned to repeat but i didnt use object and method for return so cant :P
                                    
                                  }
                                
                              }
                           
                             Console.WriteLine("All requirements are submitted. \n" +
                                 "=================================================================================================== \n" +
                                    "Please choose what course you will take.");

                            //print courses
                             foreach (string crs in courses)
                               {
                                   Console.WriteLine(crs.ToString());
                               }

                            while (thirdloop)
                            {
                                Console.WriteLine("Enter the letter of your choice: ");
                                String letter = Console.ReadLine().ToUpper();

                                //switch method because it will take longer for precise if else statement
                                switch (letter)
                                {
                                    case "BSCS":

                                        Console.WriteLine("===================================================================================================");
                                        Console.WriteLine("you have chosen BSCS these are the information for BSCS. \n" +
                                            "There is 4 year course in BSCS \n" +
                                            "Enrollment fee for first year student:" +
                                            "Cash 24,000PHP \n" +
                                            "Installment will be 10,000PHP and 14,000PHP will we divided in 4 months need to be paid in while taking BSCS");

                                        Console.WriteLine("after confirming your course please go to near sti branch for payment \n" +
                                            "Thank you for joining us.");
                                        thirdloop = false;
                                        break;

                                    case "BSIT":
                                        Console.WriteLine("===================================================================================================");
                                        Console.WriteLine("you have chosen BSIT these are the information for BSIT. \n" +
                                            "There is 4 year course in BSIT. \n" +
                                            "Enrollment fee for first year student:" +
                                            "Cash 24,000PHP \n" +
                                            "Installment will be 10,000PHP and 14,000PHP will we divided in 4 months need to be paid in while taking BSIT.");

                                        Console.WriteLine("after confirming your course please go to near sti branch for payment \n" +
                                            "Thank you for joining us.");

                                        thirdloop = false;
                                        break;

                                    case "BSBA":
                                        Console.WriteLine("===================================================================================================");
                                        Console.WriteLine("you have chosen BSBA these are the information for BSBA. \n" +
                                            "There is 4 year course in BSBA. \n" +
                                            "Enrollment fee for first year student:" +
                                            "Cash 24,000PHP \n" +
                                            "Installment will be 10,000PHP and 14,000PHP will we divided in 4 months need to be paid in while taking BSBA.");

                                        Console.WriteLine("after confirming your course please go to near sti branch for payment \n" +
                                            "Thank you for joining us.");

                                        thirdloop = false;
                                        break;

                                    case "BSA":
                                        Console.WriteLine("===================================================================================================");
                                        Console.WriteLine("you have chosen BSA these are the information for BSA. \n" +
                                            "There is 4 year course in BSA. \n" +
                                            "Enrollment fee for first year student:" +
                                            "Cash 24,000PHP \n" +
                                            "Installment will be 10,000PHP and 14,000PHP will we divided in 4 months need to be paid in while taking BSA.");

                                        Console.WriteLine("after confirming your course please go to near sti branch for payment \n" +
                                            "Thank you for joining us.");

                                        Console.WriteLine("===================================================================================================");

                                        thirdloop = false;
                                        break;

                                    default:
                                        Console.WriteLine("Invalid.");
                                        break;
                                }
                            }

                            }
                            //condition where it will stop if NO
                            else if (submitReq == "no" || submitReq == "No" || submitReq == "NO")
                            {
                            Console.WriteLine("PLease submit all your requirements before enrolling");
                            secondloop = false;

                            }
                          
                        }
                }
                //Stop at NO
                else if (enroll == "no" || enroll == "NO" || enroll == "No")
                {
                    Console.WriteLine("Please Come Again.");
                    firstloop = false;
                }
                //making sure so it wont stop stop looping as intended
                else
                {
                    firstloop = true;
                }

            }


        }
    }
}
