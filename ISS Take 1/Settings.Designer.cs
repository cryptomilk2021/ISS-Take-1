namespace ISS_Take_1
{
    partial class Settings
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
            this.lstAPIs = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lstTrackableSats = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstAvailableSats = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstAPIs
            // 
            this.lstAPIs.FormattingEnabled = true;
            this.lstAPIs.ItemHeight = 15;
            this.lstAPIs.Location = new System.Drawing.Point(38, 72);
            this.lstAPIs.Name = "lstAPIs";
            this.lstAPIs.Size = new System.Drawing.Size(120, 94);
            this.lstAPIs.TabIndex = 0;
            this.lstAPIs.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current API Keys";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(38, 186);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 23);
            this.textBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(178, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Use";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lstTrackableSats
            // 
            this.lstTrackableSats.FormattingEnabled = true;
            this.lstTrackableSats.ItemHeight = 15;
            this.lstTrackableSats.Location = new System.Drawing.Point(273, 72);
            this.lstTrackableSats.Name = "lstTrackableSats";
            this.lstTrackableSats.Size = new System.Drawing.Size(120, 94);
            this.lstTrackableSats.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Trackable Sats";
            // 
            // lstAvailableSats
            // 
            this.lstAvailableSats.FormattingEnabled = true;
            this.lstAvailableSats.ItemHeight = 15;
            this.lstAvailableSats.Location = new System.Drawing.Point(471, 72);
            this.lstAvailableSats.Name = "lstAvailableSats";
            this.lstAvailableSats.Size = new System.Drawing.Size(120, 94);
            this.lstAvailableSats.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(471, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Avaliable Sats";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(273, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "On click gets deleted";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(470, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "On click gets added";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(341, 319);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 31);
            this.button2.TabIndex = 10;
            this.button2.Text = "Clear tracking table";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstAvailableSats);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstTrackableSats);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstAPIs);
            this.Name = "Settings";
            this.Text = "Options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lstAPIs;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private ListBox lstTrackableSats;
        private Label label2;
        private ListBox lstAvailableSats;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button2;
    }
}