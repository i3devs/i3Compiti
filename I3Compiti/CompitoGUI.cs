using I3Compiti.Model;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I3Compiti
{
    public partial class CompitoGUI : MaterialForm
    {
        public CompitoGUI(Compito compito)
        {
            InitializeComponent();

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue400, Primary.Blue500, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);


            materialSingleLineTextFieldAuthor.Text = compito.Autore;
            materialSingleLineTextFieldDataConsegna.Text = compito.Data.ToString();
            materialSingleLineTextFieldDescription.Text = compito.Descrizione;
            materialSingleLineTextFieldMateria.Text = compito.Materia;
            materialSingleLineTextFieldTempoRimanente.Text = "TODO";
        }
    }
}
