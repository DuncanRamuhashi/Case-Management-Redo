using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Management_Redo
{
    internal class Program
    {
        private static List<OriginalCase> originalCases = new List<OriginalCase>();
        private static CourtCase courtCase;
        static void Main(string[] args)
        {
            loadDummyData();
            while (true)
            {
                Console.Clear();

                Console.WriteLine("Welcome to the Case Management System \n");
                Console.WriteLine(" =----------------------------------------=\n");
                Console.WriteLine("Enter 0 to exit.\n");
                Console.WriteLine("Please enter the Originating Case Number: \n");

                int originatingCaseNumber = int.Parse(Console.ReadLine());
                if (originatingCaseNumber == 0)
                {
                    break;
                }
                else
                {
                    foreach (OriginalCase originalCase in originalCases)
                    {
                        Dictionary<string, string> defendants = new Dictionary<string, string>();
                        List<string> charges = new List<string>();
                        if (originalCase.getCaseNumber() == originatingCaseNumber.ToString())
                        {


                            while (true)
                            {
                                Console.WriteLine("Enter the Number of Defendants: \n");
                                int numberOfDefendants = int.Parse(Console.ReadLine());


                                //ictionary<int, string> defendants
                                //for defendants
                                for (int d = 0; d < numberOfDefendants; d++)
                                {

                                    Console.WriteLine($"Enter the name of Defendant {d + 1}: \n");
                                    string defendantName = "";
                                    defendantName = Console.ReadLine();
                                    Console.WriteLine($"Enter the ID of Defendant {defendantName}: \n");
                                    string defendantId = Console.ReadLine();
                                    if (defendantName == null)
                                    {
                                        Console.WriteLine("Defendant name cannot be empty. Please try again.");
                                        continue;
                                    }
                                    else
                                    {
                                        defendants[defendantName] = defendantId;

                                    }

                                }
                                Console.WriteLine("Enter the Number of Charges: \n");
                                int numberOfCharges = 0;
                                numberOfCharges = int.Parse(Console.ReadLine());

                                //   for charges
                                for (int c = 0; c < numberOfCharges; c++)
                                {
                                    Console.WriteLine($"Enter the name of Charge {c + 1}: \n");
                                    string chargeName = Console.ReadLine();
                                    if (chargeName == null)
                                    {
                                        Console.WriteLine("Charge name cannot be empty. Please try again.");
                                        continue;
                                    }
                                    else
                                    {
                                        charges.Add(chargeName);
                                    }
                                }
                                break;

                            }



                            courtCase = new CourtCase(1, originalCase.getCaseNumber(), charges, defendants);

                            courtCase.assignOriginalCase(originalCase);

                            // Now for Court

                            Console.WriteLine("Enter the Court Name: \n");
                            string courtName = Console.ReadLine();
                            Console.WriteLine("Enter the Court Location: \n");
                            string courtLocation = Console.ReadLine();

                            courtCase.assignCourt(1, courtName, courtLocation);

                            // now for Judge
                            Console.WriteLine("Enter the Judge Name: \n");
                            string judgeName = Console.ReadLine();
                            courtCase.assignJudge(1, judgeName);

                            // now for Prosecutor
                            Console.WriteLine("Enter the Prosecutor Name: \n");
                            string prosecutorName = Console.ReadLine();
                            courtCase.assignProsecutor(1, prosecutorName);

                            // now for status

                            while (true)
                            {
                                Console.WriteLine("Select Case Option: \n");
                                Console.WriteLine("1. Open");
                                Console.WriteLine("2. Closed");
                                Console.WriteLine("3. Pending");
                                Console.WriteLine("4. On Hold");
                                Console.WriteLine("5. Dismissed");
                                Console.WriteLine("Enter the number corresponding to the case status: \n");
                                int statusNumber = int.Parse(Console.ReadLine());

                                if (statusNumber == 1)
                                {
                                    courtCase.updateStatus("Open");
                                }
                                else if (statusNumber == 2)
                                {
                                    courtCase.updateStatus("Closed");
                                }
                                else if (statusNumber == 3)
                                {
                                    courtCase.updateStatus("Pending");
                                }
                                else if (statusNumber == 4)
                                {
                                    courtCase.updateStatus("On Hold");
                                }
                                else if (statusNumber == 5)
                                {
                                    courtCase.updateStatus("Dismissed");
                                }
                                else
                                {
                                    Console.WriteLine("Invalid option. Please try again.");
                                    continue;
                                }

                                break;

                            }





                        }


                    }
                    // Last part
                    Console.Clear();
                    Console.WriteLine("============================================================");
                    Console.WriteLine("Case Information: \n");
                    Console.WriteLine("============================================================");

                    Console.WriteLine(courtCase.displayCaseInfo());

                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
            }
        }
        private static void loadDummyData()
        {
            // ORIGINAL CASES


            OriginalCase case1 = new OriginalCase(1, "1001", "State vs John Doe", "Johannesburg", 2026);

            originalCases.Add(case1);

            OriginalCase case2 = new OriginalCase(2, "1002", "State vs Michael Smith", "Pretoria", 2026);
            originalCases.Add(case2);

            OriginalCase case3 = new OriginalCase(3, "1003", "State vs David Mokoena", "Soweto", 2025);


            originalCases.Add(case3);



            // COURTS


            // Court court1 = new Court(1, "Johannesburg High Court", "Johannesburg");


        }
    }
}
