using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningSpace
{
    public partial class Nodes : Form
    {
        Thread th;
        public Nodes()
        {
            InitializeComponent();
        }

        private void nodesToMenu_Click(object sender, EventArgs e)
        {
            th = new Thread(openMenuForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            Close();

        }
        private void openMenuForm()
        {
            Application.Run(new MenuForm());
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            
        }

        private void buttonNewNotes_Click(object sender, EventArgs e)
        {
            th = new Thread(openNewNotes);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            Close();
        }
        private void openNewNotes()
        {
            Application.Run(new Calendar());
        }
    }
}
