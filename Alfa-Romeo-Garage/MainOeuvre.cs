using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projet_HEL.Classes;
using Projet_HEL.Acces;
using Projet_HEL.Gestion;
using System.Configuration;


namespace Alfa_Romeo_Garage
{
    public partial class FormMainOeuvre : Form
    {
        string connexionBD;
        private DataTable dataTableV;
        private BindingSource bindingSourcesV;
        string id;


        public FormMainOeuvre()
        {
            InitializeComponent();
        }
        private void ActiverBoutonsFormulaires(bool disponibilite)
        {
        }

    }
}
