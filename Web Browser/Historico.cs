using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web_Browser
{
    public partial class Historico : Form
    {
        string pathHist = String.Concat((Path.GetDirectoryName(Application.ExecutablePath)), @"\historico.txt");
        public Historico()
        {
            InitializeComponent();
        }

        private void Historico_Load(object sender, EventArgs e)
        {
            if (File.Exists(pathHist))
            {
                StreamReader historico = new StreamReader((pathHist));
                List<string> historicoList = historico.ReadToEnd().Split('\n').ToList();
                historicoList.Remove(historicoList.Last());
                historicoListBox.DataSource = historicoList;
            }
            else
            {
                File.CreateText((pathHist)).Close();
                StreamReader historico = new StreamReader((pathHist));
                List<string> historicoList = historico.ReadToEnd().Split('\n').ToList();
                historico.Close();
                historicoListBox.DataSource = historicoList;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Tem certeza que deseja Limpar o Histórico?", "Limpar Histórico", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                System.GC.Collect();
                System.GC.WaitForPendingFinalizers();
                File.Delete((String.Concat((Path.GetDirectoryName(Application.ExecutablePath)), @"\historico.txt")));
            }
            else
            {}
            historicoListBox.DataSource = null;
        }
    }
}
