using DIPLibrary;
using System;


namespace DependancyInversionPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPerson owner = Factory.CreatePerson();
            {
                owner.FirstName = "Monika";
                owner.LastName = "Johan";
                owner.EmailAddress = "monika@monika.com";
                owner.PhoneNumber = "07111222333";
            };

            IChore chore = Factory.CreateChore();
            {
                chore.ChoreName = "Take out the trash";
                chore.Owner = owner;
            }

            chore.PerformedWork(3);
            chore.PerformedWork(1.5);
            chore.CompleteChore();

            Console.ReadLine();

        }
    }
}
