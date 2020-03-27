using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Todolist
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            ///Lors du lancement de l'application, les données sont extraites du fichier XML, le statut des tâches et la durée restante est mis à jour et elles sont affichées
            InitializeComponent();
            List<TaskClass> Tasklist = Deserialize();
            for (int i = 0; i < Tasklist.Count; i++)
            {
                Tasklist[i].Status = State(Tasklist[i].StartDate, Tasklist[i].Deadline, Tasklist[i].Progress);
                Tasklist[i].Daysleft = (Tasklist[i].Deadline - DateTime.Today).TotalDays;
            }
            dataGridView1.DataSource = OngoingTask(Tasklist); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //Création d'une nouvelle tâche: ouverture de la liste du fichier XML, ajout de la nouvelle tâche à la liste, mise à jour de l'ordre, mise à jour de la liste XML et affichage des données.
                TaskClass Newtask = new TaskClass(CategoryText.Text, TitleText.Text, StartdateText.Text, DeadlineText.Text, Convert.ToInt32(ProgressText.Text), "", 0);
                Newtask.Status = State(Newtask.StartDate, Newtask.Deadline, Newtask.Progress);
                Newtask.Progress = (Newtask.Deadline - DateTime.Today).TotalDays;
                if (Newtask.Title != "" && Newtask.Deadline >= Newtask.StartDate && Newtask.Progress <= 100 && Newtask.Progress >= 0)
                {
                    List<TaskClass> Tasklist = Deserialize();
                    if (!Tasklist.Exists(Task => Task.Title == TitleText.Text && Task.Category == CategoryText.Text && Task.StartDate == Newtask.StartDate && Task.Deadline == Newtask.Deadline))
                    {
                        Tasklist.Add(Newtask);
                        Tasklist = Tasklist.OrderBy(x => x.Deadline).ToList();
                        Serialize(Tasklist);
                        dataGridView1.DataSource = OngoingTask(Tasklist);
                    }
                    else { MessageBox.Show("Cette tâche existe déjà"); }
                }
                else if (Newtask.Deadline < Newtask.StartDate) { MessageBox.Show("Deadline incohérente"); }
                else if (Newtask.Title == "") { MessageBox.Show("Renseigner un titre"); }
                else if (Newtask.Progress > 100 || Newtask.Progress < 0) { MessageBox.Show("L'avancement doit avoir une valeur entre 0% et 100%"); }
            }
            catch (System.FormatException) { MessageBox.Show( "Erreur détecteée. Veuillez vérifier les données entrées"); }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                //Modification d'une tâche sélectionnée: ouverture de la liste du fichier XML, recherche de la tâche sélectionnée, mise à jour des données, mise à jour de la liste XML et affichage des données.
                if (TitleText.Text != "" && DeadlineText.Text != "" && DateTime.Parse(DeadlineText.Text) >= DateTime.Parse(StartdateText.Text) && Convert.ToInt32(ProgressText.Text) <= 100 && Convert.ToInt32(ProgressText.Text) >= 0)
                {
                    int index;
                    List<TaskClass> Tasklist = Deserialize();
                    index = Tasklist.FindIndex(Task => Task.Title == TaskToModify.Text);

                    if (MessageBox.Show("Etes vous sûr de mettre à jour les données?", "Mise à jour des données", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Tasklist[index] = new TaskClass(CategoryText.Text, TitleText.Text, StartdateText.Text, DeadlineText.Text, Convert.ToInt32(ProgressText.Text), State(DateTime.Parse(StartdateText.Text), DateTime.Parse(DeadlineText.Text), Convert.ToInt32(ProgressText.Text)), (DateTime.Parse(DeadlineText.Text) - DateTime.Today).TotalDays);
                        Tasklist = Tasklist.OrderBy(x => x.Deadline).ToList();
                        Serialize(Tasklist);
                        dataGridView1.DataSource = OngoingTask(Tasklist);
                    }
                }
                else if (Convert.ToInt32(ProgressText.Text) > 100 || Convert.ToInt32(ProgressText.Text) < 0) { MessageBox.Show("L'avancement doit avoir une valeur entre 0% et 100%"); }
                else { MessageBox.Show("Information incomplète ou incohérente"); }
            }
            catch (System.FormatException) { MessageBox.Show("Erreur détectée. Veuillez vérifier les données entrées"); }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Renvois des données de la tâche sélectionné dans le datagridview de l'interface vers les textboxs (utiliser pour simplifier l'usage des fonctions ajout, modification et suppression de tâche)
            int index = e.RowIndex;
            DataGridViewRow Selectedrow = dataGridView1.Rows[index];
            CategoryText.Text = Selectedrow.Cells[0].Value.ToString();
            TitleText.Text = Selectedrow.Cells[1].Value.ToString();
            StartdateText.Text = Selectedrow.Cells[2].Value.ToString();
            DeadlineText.Text = Selectedrow.Cells[3].Value.ToString();
            ProgressText.Text = Selectedrow.Cells[4].Value.ToString();
            TaskToModify.Text = TitleText.Text;
        }

        private void DeleteTask_Click(object sender, EventArgs e)
        {
            //Suppression d'une tâche : ouverture de la liste du fichier XML, recherche de la tâche sélectionnée, suppression des données, mise à jour de la liste XML et affichage de la nouvelle liste
            List<TaskClass> Tasklist = Deserialize();
            int index;
            index = Tasklist.FindIndex(Task => Task.Title == TaskToModify.Text);
            if (MessageBox.Show("Supprimer les données sélectionnées?", "Suppresion des données", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Tasklist.RemoveAt(index);
                Serialize(Tasklist);
                dataGridView1.DataSource = OngoingTask(Tasklist);
            }
        }

        static List<TaskClass> Deserialize()
        {
            //Méthode permettant de récupérer les données stockées dans le fichier XML sous forme d'une liste 
            List<TaskClass> Tasklist;
            XmlSerializer XmlTaskDes = new XmlSerializer(typeof(List<TaskClass>));
            TextReader rdr = new StreamReader(@"C:\Users\jonat\Documents\Village de l'emploi\Todolist project\TodolistC#\Todolist\bin\Debug\TaskData.xml");
            object Deserilized1 = XmlTaskDes.Deserialize(rdr);
            Tasklist = (List<TaskClass>)Deserilized1;
            rdr.Close();
            return Tasklist;
        }

        static void Serialize(List<TaskClass> Tasklist)
        {
            //Méthode permettant de transcrire les données d'une liste dans le fichier XML (processus inverse de la méthode deserialize)
            XmlSerializer XmlTask = new XmlSerializer(typeof(List<TaskClass>));
            StreamWriter Write = new StreamWriter(@"C:\Users\jonat\Documents\Village de l'emploi\Todolist project\TodolistC#\Todolist\bin\Debug\TaskData.xml");
            XmlTask.Serialize(Write, Tasklist);
            Write.Close();
        }

        static string State(DateTime aStartdate, DateTime aDeadline, Double astate)
        {
            //Méthode permettant de définir à partir des dates et de l'avancement (Progress) l'état (Status) d'une tâche, c'est à dire si elle est en retard ou non.
            String State;
            Double Total = (aDeadline - aStartdate).TotalHours;
            Double TotalNow = (DateTime.Now - aStartdate).TotalHours;
            Double Progress = TotalNow / (Total); //Peut être rajouté 24h sachant qu'une date est défini à 00h00min lors de sa création
            if(Progress<1 || astate!=100)
            {
                if (Progress >= 0.25 && Progress < 0.5 && astate >= 25) { State = "In time"; }
                else if (Progress >= 0.5 && Progress < 0.75 && astate >= 50) { State = "In time"; }
                else if (Progress >= 0.75 && Progress < 1 && astate >= 75) { State = "In time"; }
                else if (Progress < 0.25) { State = "In time"; }
                else if (Progress == 1 && astate == 100) { State = "In time"; }
                else { State = "Delayed"; }
            }
            else { State = "In time"; }
            return State;
        }

        static List<TaskClass> OngoingTask(List<TaskClass> Tasklist)
        {
            //Méthode permettant de lister uniquement les tâches non réalisés (Progress < 100%) 
            for (int i = 0; i<Tasklist.Count; i++)
            {if (Tasklist[i].Progress == 100) { Tasklist.Remove(Tasklist[i]); i--; }}
            return Tasklist;
        }
    }
}
