namespace Web_Browser
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.urltextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.históricoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.favoritosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.favButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.forwardButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(29, 86);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(514, 294);
            this.webBrowser1.TabIndex = 3;
            this.webBrowser1.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowser1_Navigated);
            // 
            // urltextBox
            // 
            this.urltextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.urltextBox.Location = new System.Drawing.Point(209, 48);
            this.urltextBox.Name = "urltextBox";
            this.urltextBox.Size = new System.Drawing.Size(272, 20);
            this.urltextBox.TabIndex = 8;
            this.urltextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.urltextBox_KeyPress);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.históricoToolStripMenuItem,
            this.imprimirToolStripMenuItem,
            this.favoritosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(574, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // históricoToolStripMenuItem
            // 
            this.históricoToolStripMenuItem.Name = "históricoToolStripMenuItem";
            this.históricoToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.históricoToolStripMenuItem.Text = "Histórico";
            this.históricoToolStripMenuItem.Click += new System.EventHandler(this.históricoToolStripMenuItem_Click);
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.imprimirToolStripMenuItem.Text = "Imprimir";
            this.imprimirToolStripMenuItem.Click += new System.EventHandler(this.imprimirToolStripMenuItem_Click);
            // 
            // favoritosToolStripMenuItem
            // 
            this.favoritosToolStripMenuItem.Name = "favoritosToolStripMenuItem";
            this.favoritosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.favoritosToolStripMenuItem.Text = "Favoritos";
            this.favoritosToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.favoritosToolStripMenuItem_DropDownItemClicked);
            // 
            // favButton
            // 
            this.favButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.favButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.favButton.BackColor = System.Drawing.SystemColors.Control;
            this.favButton.BackgroundImage = global::Web_Browser.Properties.Resources.Button_Favorite_icon;
            this.favButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.favButton.Location = new System.Drawing.Point(487, 34);
            this.favButton.MaximumSize = new System.Drawing.Size(56, 46);
            this.favButton.Name = "favButton";
            this.favButton.Size = new System.Drawing.Size(56, 46);
            this.favButton.TabIndex = 10;
            this.favButton.UseVisualStyleBackColor = false;
            this.favButton.Click += new System.EventHandler(this.favButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackgroundImage = global::Web_Browser.Properties.Resources.back_icon;
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Location = new System.Drawing.Point(29, 34);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(43, 46);
            this.backButton.TabIndex = 9;
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.BackgroundImage = global::Web_Browser.Properties.Resources.home_icon;
            this.homeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Location = new System.Drawing.Point(127, 34);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(51, 46);
            this.homeButton.TabIndex = 6;
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // forwardButton
            // 
            this.forwardButton.BackgroundImage = global::Web_Browser.Properties.Resources.forward_icon;
            this.forwardButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.forwardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forwardButton.Location = new System.Drawing.Point(78, 34);
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.Size = new System.Drawing.Size(43, 46);
            this.forwardButton.TabIndex = 5;
            this.forwardButton.UseVisualStyleBackColor = true;
            this.forwardButton.Click += new System.EventHandler(this.forwardButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 392);
            this.Controls.Add(this.favButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.urltextBox);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.forwardButton);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Web Browser";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button forwardButton;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.TextBox urltextBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button favButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem favoritosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem históricoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
    }
}

