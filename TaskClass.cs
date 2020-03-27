using System;

namespace Todolist
{
    //Classe créée pour représenter une tâche à travers ses attributs 
    public class TaskClass
    {
        public string Category { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime Deadline { get; set; } 
        public double Progress { get; set; }
        public string Status { get; set; }
        public double Daysleft { get; set; }

        public TaskClass(string aCategory, string aTitle, string aStartdate, string aDeadline, double aProgress, string aStatus, double aDaysleft)
        {
            Category = aCategory;
            Title = aTitle;
            if (aStartdate == "") { StartDate = DateTime.Today; }
            else { StartDate = DateTime.Parse(aStartdate); }
            if (aDeadline == "") { Deadline = StartDate; }
            else { Deadline = DateTime.Parse(aDeadline); }
            if (aProgress.ToString() == "") { Progress = 0; }
            else { Progress = aProgress; }
            Status = aStatus;
            Daysleft = aDaysleft;
        }

        public TaskClass() { } //Constructeur sans paramètres permettant la sérialisation
    }
}
