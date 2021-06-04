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
            this.Location = Screen.AllScreens[0].WorkingArea.Location;

            //déplacement du pannel à la même hauteur que button Accueil
            panelButtonSelectionne.Height = buttonAccueil.Height;
            panelButtonSelectionne.Top = buttonAccueil.Top;

            //afficher l'écran d'accueil
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
            //déplacement du pannel à la même hauteur que button Accueil
            panelButtonSelectionne.Height = buttonAccueil.Height;
            panelButtonSelectionne.Top = buttonAccueil.Top;

            //afficher l'écran des clients
            userControlAccueil1.BringToFront();
        }

        private void buttonClients_Click(object sender, EventArgs e)
        {
            //déplacement du pannel à la même hauteur que button client
            panelButtonSelectionne.Height = buttonClients.Height;
            panelButtonSelectionne.Top = buttonClients.Top;
            
            //afficher l'écran d'accueil
            userControlClients1.BringToFront();
        }

        private void buttonModeles_Click(object sender, EventArgs e)
        {
            
            panelButtonSelectionne.Height = buttonModeles.Height;
            panelButtonSelectionne.Top = buttonModeles.Top;

            //afficher l'écran des modèles
            userControlModeles1.BringToFront();
        }

        private void buttonVehicules_Click(object sender, EventArgs e)
        {
            
            panelButtonSelectionne.Height = buttonVehicules.Height;
            panelButtonSelectionne.Top = buttonVehicules.Top;

            //afficher l'écran des véhicules
            userControlVehiculescs1.BringToFront();
        }

        private void buttonPieces_Click(object sender, EventArgs e)
        {
            panelButtonSelectionne.Height = buttonPieces.Height;
            panelButtonSelectionne.Top = buttonPieces.Top;

            //afficher l'écran des pièces
            userControlPieces1.BringToFront();
        }

        private void buttonInterventions_Click(object sender, EventArgs e)
        {
            panelButtonSelectionne.Height = buttonInterventions.Height;
            panelButtonSelectionne.Top = buttonInterventions.Top;

            //afficher l'écran des interventions
            userControlIntervetions1.BringToFront();
        }

        private void buttonEntretiens_Click(object sender, EventArgs e)
        {
            panelButtonSelectionne.Height = buttonEntretiens.Height;
            panelButtonSelectionne.Top = buttonEntretiens.Top;

            //afficher l'écran des entretients
            userControlEntretiens1.BringToFront();
        }
    }
}
