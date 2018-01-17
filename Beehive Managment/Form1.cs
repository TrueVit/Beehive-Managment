using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beehive_Managment
{
    public partial class Form1 : Form
    {
        Queen queen;

        public Form1()
        {
            string[] jobs = new string[6] {"Nectar collector", "Honey manufacturing",
                "Egg care", "Baby bee tutoring", "Hive maintenance", "Sting patrol"};
            InitializeComponent();
            Worker[] workers = new Worker[4];
            workers[0] = new Worker(new string[] { "Nectar collector", "Honey manufacturing" });
            workers[1] = new Worker(new string[] { "Egg care", "Baby bee tutoring" });
            workers[2] = new Worker(new string[] { "Hive maintenance", "Sting patrol" });
            workers[3] = new Worker(new string[] { "Nectar collector", "Honey manufacturing",
                "Egg care", "Baby bee tutoring", "Hive maintenance", "Sting patrol" });
            queen = new Queen(workers);

            foreach (var job in jobs)
            {
                workerBeeJob.Items.Add(job);
            }
            workerBeeJob.SelectedIndex = 0;
        }

        private void assignJobButton_Click(object sender, EventArgs e)
        {
            string job = workerBeeJob.SelectedItem.ToString();
            int shift = (int)shifts.Value;
            string resultText;
            if (queen.AssignWork(job, shift))
                resultText = "Job '" + job + "' assigned successufuly for " + shift + " shifts";
            else
                resultText = "There aren't free bees";
            reportTextbox.Text += resultText + "\r\n";
        }

        private void nextShift_Click(object sender, EventArgs e)
        {
            reportTextbox.Text += queen.WorkTheNextShift();
        }
    }
}
