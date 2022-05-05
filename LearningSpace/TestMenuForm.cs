using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using yt_DesignUI;
using yt_DesignUI.Components;
using yt_DesignUI.Controls;

namespace LearningSpace
{
    public partial class TestMenuForm : Form
    {
        public TestMenuForm()
        {
            InitializeComponent();
            customizeDesing();
            Animator.Start();
        }

        private void customizeDesing()
        {
            panelSUB111.Visible = false;
            panelSUB222.Visible = false;
            panelSUB333.Visible = false;
            //...
        }

        private void HideSubMenu()
        {
            if(panelSUB111.Visible == true)
            {
                panelSUB111.Visible = false;
            }
            if(panelSUB222.Visible == true)
            {
                panelSUB222.Visible = false;
            }
            if(panelSUB333.Visible == true)
            {
                panelSUB333.Visible = false;
            }
        }

        private void ShowSubMenu(Panel subMenuPanel)
        {
            if(subMenuPanel.Visible == false)
            {
                HideSubMenu();
                subMenuPanel.Visible = true;
            }
            else
            {
                subMenuPanel.Visible = false;
            }
        }

        #region SUB111
        private void button1_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSUB111);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*
             любой код для всех кнопок , но написать строчку ниже надо во всех 
             */
            HideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*
             любой код для всех кнопок , но написать строчку ниже надо во всех 
             */
            HideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            /*
             любой код для всех кнопок , но написать строчку ниже надо во всех 
             */
            HideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            /*
             любой код для всех кнопок , но написать строчку ниже надо во всех 
             */
            HideSubMenu();
        }

        #endregion

        #region SUB222 & SUB333 ...

        
        private void button6_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSUB222);
        }

        //тут надо написать для всех кнопок закрывашки 

        private void button11_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSUB333);
        }
        //тут надо написать для всех кнопок закрывашки 
        private void button16_Click(object sender, EventArgs e)
        {
            //а это пусть будет что-то по типу помошника
            HideSubMenu();
        }
        #endregion

        private Form activeForm = null;

        private void openChildForm(Form childForm)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildBottom.Controls.Add(childForm);
            panelChildBottom.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

    }
}
