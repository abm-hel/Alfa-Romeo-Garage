using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alfa_Romeo_Garage
{
    public partial class MainForm : Form
    {
        //Variables qu'on va utliser pour déplacer la fenêtre
        int mov;
        int movX;
        int movY;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //poitionnement de la fenêtre
            this.Location = Screen.AllScreens[1].WorkingArea.Location;
            
            panelButtonSelectionne.Height = buttonAccueil.Height;
            userControlAccueil1.BringToFront();
        }

        private void panelPosition_MouseDown(object sender, MouseEventArgs e)
        {
            //position de la souris
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void panelPosition_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void panelPosition_MouseMove(object sender, MouseEventArgs e)
        {
            //déplacement de la fenêtre
            if(mov==1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void buttonAccueil_Click(object sender, EventArgs e)
        {
            panelButtonSelectionne.Height = buttonAccueil.Height;
            userControlAccueil1.BringToFront();
        }

        private void buttonClients_Click(object sender, EventArgs e)
        {

        }
    }
}
