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
    public partial class Form1 : Form
    {
        string pathFav = String.Concat((Path.GetDirectoryName(Application.ExecutablePath)), @"\fav.txt");
        string pathHist = String.Concat((Path.GetDirectoryName(Application.ExecutablePath)), @"\historico.txt");
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
            if (File.Exists(pathFav))
            {
                StreamReader fav = new StreamReader(pathFav);
                List<string> favLista = fav.ReadToEnd().Split('\n').ToList();
                fav.Close();
                favLista.Remove(favLista.Last());
                foreach (string itens in favLista)
                    {
                        ToolStripMenuItem favItem = new ToolStripMenuItem();
                        favItem.Text = itens;
                        favoritosToolStripMenuItem.DropDownItems.Insert(favoritosToolStripMenuItem.DropDownItems.Count, favItem);
                    }
            }
            else
            {
                File.CreateText((pathFav)).Close();
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void forwardButton_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }


        private void urltextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            string conditionW="www.";
            if (e.KeyChar == 13)
            {
                if (urltextBox.Text.Contains("http://")||urltextBox.Text.Contains("https://"))
                {
                    if (urltextBox.Text.Substring(7, 4)==conditionW.ToLower()){
                        webBrowser1.Navigate(new Uri(urltextBox.Text)); 
                    }
                    else{
                        webBrowser1.Navigate(new Uri(urltextBox.Text.Insert(7, "www.")));
                    }
                }
                else
                {
                    if (urltextBox.Text.Substring(0, 3) == conditionW.ToLower())
                    {
                        webBrowser1.Navigate(new Uri("http://" + urltextBox.Text));
                    }
                    else 
                    {
                            webBrowser1.Navigate(new Uri("http://www." + urltextBox.Text));
                    }
                }
            }
        }

        private void favButton_Click(object sender, EventArgs e)
        {
            if (File.Exists(pathFav))
                {
                    StreamReader favFile = new StreamReader(pathFav);
                    string favList = favFile.ReadToEnd();
                    favFile.Close();
                    using (StreamWriter file = new StreamWriter(pathFav, true))
                    {
                        if (!favList.Contains(webBrowser1.Url.ToString()))
                        {
                            file.WriteLine(webBrowser1.Url.ToString());
                            ToolStripMenuItem favItem = new ToolStripMenuItem();
                            favItem.Text = webBrowser1.Url.ToString();
                            favoritosToolStripMenuItem.DropDownItems.Insert(favoritosToolStripMenuItem.DropDownItems.Count, favItem);
                    }
                }
            }
            else 
                {
                    File.CreateText(String.Concat((Path.GetDirectoryName(Application.ExecutablePath)), @"\fav.txt")).Close();
                    StreamReader favFile = new StreamReader(String.Concat((Path.GetDirectoryName(Application.ExecutablePath)), @"\fav.txt"));
                    string favList = favFile.ReadToEnd();
                    favFile.Close();
                    using (StreamWriter file = new StreamWriter(String.Concat((Path.GetDirectoryName(Application.ExecutablePath)), @"\fav.txt"), true))
                    {
                        if (!favList.Contains(webBrowser1.Url.ToString()))
                        {
                            file.WriteLine(webBrowser1.Url.ToString());
                            ToolStripMenuItem favItem = new ToolStripMenuItem();
                            favItem.Text = webBrowser1.Url.ToString();
                            favoritosToolStripMenuItem.DropDownItems.Insert(favoritosToolStripMenuItem.DropDownItems.Count, favItem);
                        }
                    }
                }  
            }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            urltextBox.Text = webBrowser1.Url.ToString();
            if (File.Exists(pathHist))
            {
                StreamReader hist = new StreamReader(pathHist);
                List<string> historicoList = hist.ReadToEnd().Split('\n').Select(h => h.Trim()).ToList();
                hist.Close();
                historicoList.Remove(historicoList.Last());
                int i = historicoList.Count;
                if (new FileInfo(pathHist).Length > 0)
                {
                    if (!historicoList[i - 1].Equals((webBrowser1.Url.ToString())))
                    {
                        using (StreamWriter historico = new StreamWriter((pathHist), true))
                        {
                            historico.WriteLine(webBrowser1.Url.ToString());
                        }
                    }
                }
                else
                {
                    using (StreamWriter historico = new StreamWriter(pathHist, true))
                    {
                        historico.WriteLine(webBrowser1.Url.ToString());
                    }
                }
            }
            else
            {
                File.CreateText(pathHist).Close();
                using (StreamWriter historico = new StreamWriter(pathHist, true))
                    {
                        historico.WriteLine(webBrowser1.Url.ToString());
                    }
                }
            }
        


        private void favoritosToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            webBrowser1.Navigate(new Uri(e.ClickedItem.Text));
        }

        private void históricoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Historico historicoForm = new Historico();
            historicoForm.Show();
        }



        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.ShowPrintDialog();
        }
        }
    }
