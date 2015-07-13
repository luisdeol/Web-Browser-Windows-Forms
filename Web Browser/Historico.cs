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
        public Historico()
        {
            InitializeComponent();
        }

        private void Historico_Load(object sender, EventArgs e)
        {
            if (File.Exists(String.Concat((Path.GetDirectoryName(Application.ExecutablePath)), @"\historico.txt")))
            {
                StreamReader historico = new StreamReader((String.Concat((Path.GetDirectoryName(Application.ExecutablePath)), @"\historico.txt")));
                List<string> historicoList = historico.ReadToEnd().Split('\n').ToList();
                historicoList.Remove(historicoList.Last());
                historicoListBox.DataSource = historicoList;
            }
            else
            {
                File.CreateText((String.Concat((Path.GetDirectoryName(Application.ExecutablePath)), @"\historico.txt"))).Close();
                StreamReader historico = new StreamReader((String.Concat((Path.GetDirectoryName(Application.ExecutablePath)), @"\historico.txt")));
                List<string> historicoList = historico.ReadToEnd().Split('\n').ToList();
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
