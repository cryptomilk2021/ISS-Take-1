namespace ISS_Take_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lstBoxSatelites = new System.Windows.Forms.ListBox();
            this.sateliteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sateliteDBContextBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sateliteBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.sateliteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lblSatName = new System.Windows.Forms.Label();
            this.lblNORADId = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTimestamp = new System.Windows.Forms.Label();
            this.lblLatitude = new System.Windows.Forms.Label();
            this.lblLongitude = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.LblLoadFeedback = new System.Windows.Forms.Label();
            this.lblNbrOfHits = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.sateliteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sateliteDBContextBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sateliteBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sateliteBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstBoxSatelites
            // 
            this.lstBoxSatelites.DisplayMember = "NORADId";
            this.lstBoxSatelites.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstBoxSatelites.FormattingEnabled = true;
            this.lstBoxSatelites.HorizontalExtent = 1;
            this.lstBoxSatelites.ItemHeight = 15;
            this.lstBoxSatelites.Location = new System.Drawing.Point(51, 63);
            this.lstBoxSatelites.Name = "lstBoxSatelites";
            this.lstBoxSatelites.Size = new System.Drawing.Size(217, 319);
            this.lstBoxSatelites.TabIndex = 0;
            this.lstBoxSatelites.TabStop = false;
            this.lstBoxSatelites.ValueMember = "NORADId";
            this.lstBoxSatelites.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstBoxSatelites_MouseClick);
            this.lstBoxSatelites.SelectedIndexChanged += new System.EventHandler(this.lstBoxSatelites_SelectedIndexChanged);
            // 
            // sateliteBindingSource
            // 
            this.sateliteBindingSource.DataSource = typeof(Satelite);
            // 
            // sateliteDBContextBindingSource
            // 
            this.sateliteDBContextBindingSource.DataSource = typeof(SateliteDBContext);
            // 
            // sateliteBindingSource2
            // 
            this.sateliteBindingSource2.DataSource = typeof(Satelite);
            // 
            // sateliteBindingSource1
            // 
            this.sateliteBindingSource1.DataSource = typeof(Satelite);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Satelite";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSatName
            // 
            this.lblSatName.AutoSize = true;
            this.lblSatName.Location = new System.Drawing.Point(637, 33);
            this.lblSatName.Name = "lblSatName";
            this.lblSatName.Size = new System.Drawing.Size(57, 15);
            this.lblSatName.TabIndex = 2;
            this.lblSatName.Text = "unknown";
            // 
            // lblNORADId
            // 
            this.lblNORADId.AutoSize = true;
            this.lblNORADId.Location = new System.Drawing.Point(418, 33);
            this.lblNORADId.Name = "lblNORADId";
            this.lblNORADId.Size = new System.Drawing.Size(71, 15);
            this.lblNORADId.TabIndex = 3;
            this.lblNORADId.Text = "not selected";
            this.lblNORADId.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(333, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "NORAD Id:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(560, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sat Name:";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(416, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "longitude";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(416, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "latitude";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(416, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "timestamp";
            // 
            // lblTimestamp
            // 
            this.lblTimestamp.AutoSize = true;
            this.lblTimestamp.Location = new System.Drawing.Point(497, 83);
            this.lblTimestamp.Name = "lblTimestamp";
            this.lblTimestamp.Size = new System.Drawing.Size(57, 15);
            this.lblTimestamp.TabIndex = 11;
            this.lblTimestamp.Text = "unknown";
            // 
            // lblLatitude
            // 
            this.lblLatitude.AutoSize = true;
            this.lblLatitude.Location = new System.Drawing.Point(497, 68);
            this.lblLatitude.Name = "lblLatitude";
            this.lblLatitude.Size = new System.Drawing.Size(57, 15);
            this.lblLatitude.TabIndex = 10;
            this.lblLatitude.Text = "unknown";
            // 
            // lblLongitude
            // 
            this.lblLongitude.AutoSize = true;
            this.lblLongitude.Location = new System.Drawing.Point(497, 53);
            this.lblLongitude.Name = "lblLongitude";
            this.lblLongitude.Size = new System.Drawing.Size(57, 15);
            this.lblLongitude.TabIndex = 9;
            this.lblLongitude.Text = "unknown";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.fileToolStripMenuItem,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit...";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(12, 20);
            // 
            // LblLoadFeedback
            // 
            this.LblLoadFeedback.AutoSize = true;
            this.LblLoadFeedback.Location = new System.Drawing.Point(404, 412);
            this.LblLoadFeedback.Name = "LblLoadFeedback";
            this.LblLoadFeedback.Size = new System.Drawing.Size(38, 15);
            this.LblLoadFeedback.TabIndex = 13;
            this.LblLoadFeedback.Text = "label7";
            // 
            // lblNbrOfHits
            // 
            this.lblNbrOfHits.AutoSize = true;
            this.lblNbrOfHits.Location = new System.Drawing.Point(544, 413);
            this.lblNbrOfHits.Name = "lblNbrOfHits";
            this.lblNbrOfHits.Size = new System.Drawing.Size(0, 15);
            this.lblNbrOfHits.TabIndex = 14;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(163, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(105, 23);
            this.textBox1.TabIndex = 15;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblNbrOfHits);
            this.Controls.Add(this.LblLoadFeedback);
            this.Controls.Add(this.lblTimestamp);
            this.Controls.Add(this.lblLatitude);
            this.Controls.Add(this.lblLongitude);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNORADId);
            this.Controls.Add(this.lblSatName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstBoxSatelites);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "My Sat App";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sateliteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sateliteDBContextBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sateliteBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sateliteBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lstBoxSatelites;
        private Label label1;
        private Label lblSatName;
        private BindingSource sateliteBindingSource;
        private BindingSource sateliteBindingSource1;
        private BindingSource sateliteBindingSource2;
        private BindingSource sateliteDBContextBindingSource;
        private Label lblNORADId;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label lblTimestamp;
        private Label lblLatitude;
        private Label lblLongitude;
        private BindingSource bindingSource1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Label LblLoadFeedback;
        private Label lblNbrOfHits;
        private TextBox textBox1;
        //lstBoxSatelites.
    }
}