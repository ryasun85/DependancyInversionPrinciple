namespace DIPLibrary
{
    public interface IChore
    {
        string ChoreName { get; set; }
        double HoursQWorked { get; }
        bool IsComplete { get; }
        IPerson Owner { get; set; }

        void CompleteChore();
        void PerformedWork(double hours);
    }
}