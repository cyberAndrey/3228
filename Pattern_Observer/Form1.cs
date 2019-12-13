using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Pattern_Observer
{
    public partial class Pattern_Observer : Form

    {
        Subject subject = new Subject();
        Observer observer;

        public Pattern_Observer()
        {
            InitializeComponent();
            observer = new Observer(subject, "Наблюдатель", "\t\t");
        }

        private void Pattern_Observer_Load(object sender, EventArgs e)
        {
        }

        private void ButTop_Click(object sender, EventArgs e)
        {
            TBOutput.Clear();
            observer.stateNow = String.Empty;
            subject.simulator.Top = !subject.simulator.Top;
            LabTop.Visible = !LabTop.Visible;
            subject.Go();
            Thread.Sleep(1000);
            TBOutput.Text = observer.stateNow;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ButRight_Click(object sender, EventArgs e)
        {
            TBOutput.Clear();
            observer.stateNow = String.Empty;
            subject.simulator.Right = !subject.simulator.Right;
            LabRight.Visible = !LabRight.Visible;
            subject.Go();
            Thread.Sleep(10);
            TBOutput.Text = observer.stateNow;
        }

        private void ButLeft_Click(object sender, EventArgs e)
        {
            TBOutput.Clear();
            observer.stateNow = String.Empty;
            subject.simulator.Left = !subject.simulator.Left;
            LabLeft.Visible = !LabLeft.Visible;
            subject.Go();
            Thread.Sleep(1000);
            TBOutput.Text = observer.stateNow;
        }

        private void ButBot_Click(object sender, EventArgs e)
        {
            TBOutput.Clear();
            observer.stateNow = String.Empty;
            subject.simulator.Bot = !subject.simulator.Bot;
            LabBot.Visible = !LabBot.Visible;
            subject.Go();
            Thread.Sleep(1000);
            TBOutput.Text = observer.stateNow;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
