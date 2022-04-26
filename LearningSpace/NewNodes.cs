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
    public partial class NewNodes : Form
    {
        Thread th;
        public NewNodes()
        {
            InitializeComponent();
        }

        private void buttonBackToNodes_Click(object sender, EventArgs e)
        {
            th = new Thread(openBackNotes);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            Close();
        }
        private void openBackNotes()
        {
            Application.Run(new Nodes());
        }
    }
}
