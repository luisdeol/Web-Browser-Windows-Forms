namespace Web_Browser
{
    partial class Historico
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
            this.historicoListBox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // historicoListBox
            // 
            this.historicoListBox.FormattingEnabled = true;
            this.historicoListBox.Location = new System.Drawing.Point(12, 50);
            this.historicoListBox.Name = "historicoListBox";
            this.historicoListBox.Size = new System.Drawing.Size(454, 199);
            this.historicoListBox.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Web_Browser.Properties.Resources.DeleteAll_icon;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(12, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 36);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Historico
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.historicoListBox);
            this.Name = "Historico";
            this.Text = "Historico";
            this.Load += new System.EventHandler(this.Historico_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox historicoListBox;
        private System.Windows.Forms.Button button1;
    }
}