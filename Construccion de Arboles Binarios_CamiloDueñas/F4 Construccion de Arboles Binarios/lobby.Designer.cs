
namespace F4_Construccion_de_Arboles_Binarios
{
    partial class lobby
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
            this.button4 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.escenario1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.escenario2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(360, 148);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "Volver";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.escenario1ToolStripMenuItem,
            this.escenario2ToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(467, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // escenario1ToolStripMenuItem
            // 
            this.escenario1ToolStripMenuItem.Name = "escenario1ToolStripMenuItem";
            this.escenario1ToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.escenario1ToolStripMenuItem.Text = "Escenario1";
            this.escenario1ToolStripMenuItem.Click += new System.EventHandler(this.escenario1ToolStripMenuItem_Click);
            // 
            // escenario2ToolStripMenuItem
            // 
            this.escenario2ToolStripMenuItem.Name = "escenario2ToolStripMenuItem";
            this.escenario2ToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.escenario2ToolStripMenuItem.Text = "Escenario2";
            this.escenario2ToolStripMenuItem.Click += new System.EventHandler(this.escenario2ToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(137, 123);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Interfaz del estudiante No.1052415703";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "CONTRUCCION DE ARBOLES BINARIOS";
            // 
            // lobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(467, 175);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "lobby";
            this.Text = "lobby";
            this.Load += new System.EventHandler(this.lobby_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem escenario1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem escenario2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}