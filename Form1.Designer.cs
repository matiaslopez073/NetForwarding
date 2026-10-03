namespace NetForwarding
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cmbRedPorts = new System.Windows.Forms.ComboBox();
            this.localIp = new System.Windows.Forms.TextBox();
            this.localPort = new System.Windows.Forms.TextBox();
            this.externalIp = new System.Windows.Forms.TextBox();
            this.externalPort = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.subtitleLabel = new System.Windows.Forms.Label();
            this.configPanel = new System.Windows.Forms.Panel();
            this.consoleLabel = new System.Windows.Forms.Label();
            this.headerPanel.SuspendLayout();
            this.configPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbRedPorts
            // 
            this.cmbRedPorts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
            this.cmbRedPorts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbRedPorts.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbRedPorts.ForeColor = System.Drawing.Color.White;
            this.cmbRedPorts.Location = new System.Drawing.Point(20, 45);
            this.cmbRedPorts.Name = "cmbRedPorts";
            this.cmbRedPorts.Size = new System.Drawing.Size(175, 25);
            this.cmbRedPorts.TabIndex = 1;
            this.cmbRedPorts.SelectedIndexChanged += new System.EventHandler(this.cmbRedPorts_SelectedIndexChanged);
            // 
            // localIp
            // 
            this.localIp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
            this.localIp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.localIp.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.localIp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.localIp.Location = new System.Drawing.Point(212, 45);
            this.localIp.Name = "localIp";
            this.localIp.Size = new System.Drawing.Size(125, 25);
            this.localIp.TabIndex = 2;
            // 
            // localPort
            // 
            this.localPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
            this.localPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.localPort.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.localPort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.localPort.Location = new System.Drawing.Point(348, 45);
            this.localPort.Name = "localPort";
            this.localPort.Size = new System.Drawing.Size(60, 25);
            this.localPort.TabIndex = 3;
            // 
            // externalIp
            // 
            this.externalIp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
            this.externalIp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.externalIp.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.externalIp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.externalIp.Location = new System.Drawing.Point(423, 45);
            this.externalIp.Name = "externalIp";
            this.externalIp.Size = new System.Drawing.Size(125, 25);
            this.externalIp.TabIndex = 4;
            // 
            // externalPort
            // 
            this.externalPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
            this.externalPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.externalPort.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.externalPort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.externalPort.Location = new System.Drawing.Point(560, 45);
            this.externalPort.Name = "externalPort";
            this.externalPort.Size = new System.Drawing.Size(60, 25);
            this.externalPort.TabIndex = 5;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(635, 35);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(95, 40);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "+  AGREGAR";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(20, 530);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 40);
            this.button1.TabIndex = 14;
            this.button1.Text = "VER REGLAS";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(155, 530);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 40);
            this.button2.TabIndex = 15;
            this.button2.Text = "BORRAR REGLAS";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(620, 530);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 40);
            this.button3.TabIndex = 16;
            this.button3.Text = "LIMPIAR CONSOLA";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(170)))), ((int)(((byte)(180)))));
            this.label1.Location = new System.Drawing.Point(18, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADAPTADOR DE RED";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(170)))), ((int)(((byte)(180)))));
            this.label2.Location = new System.Drawing.Point(210, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "IP LOCAL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(170)))), ((int)(((byte)(180)))));
            this.label3.Location = new System.Drawing.Point(420, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "IP DESTINO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(170)))), ((int)(((byte)(180)))));
            this.label4.Location = new System.Drawing.Point(345, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "PUERTO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(170)))), ((int)(((byte)(180)))));
            this.label5.Location = new System.Drawing.Point(558, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "PUERTO";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(20)))), ((int)(((byte)(23)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Consolas", 10F);
            this.richTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(220)))), ((int)(((byte)(150)))));
            this.richTextBox1.Location = new System.Drawing.Point(20, 240);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(750, 270);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.Black;
            this.headerPanel.Controls.Add(this.titleLabel);
            this.headerPanel.Controls.Add(this.subtitleLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(790, 72);
            this.headerPanel.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(22, 10);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(199, 32);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "NET Forwarding";
            // 
            // subtitleLabel
            // 
            this.subtitleLabel.AutoSize = true;
            this.subtitleLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.subtitleLabel.ForeColor = System.Drawing.Color.White;
            this.subtitleLabel.Location = new System.Drawing.Point(25, 43);
            this.subtitleLabel.Name = "subtitleLabel";
            this.subtitleLabel.Size = new System.Drawing.Size(252, 15);
            this.subtitleLabel.TabIndex = 1;
            this.subtitleLabel.Text = "Network Port Forwarding Manager  •  ANDINA";
            // 
            // configPanel
            // 
            this.configPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.configPanel.Controls.Add(this.label1);
            this.configPanel.Controls.Add(this.cmbRedPorts);
            this.configPanel.Controls.Add(this.label2);
            this.configPanel.Controls.Add(this.localIp);
            this.configPanel.Controls.Add(this.label4);
            this.configPanel.Controls.Add(this.localPort);
            this.configPanel.Controls.Add(this.label3);
            this.configPanel.Controls.Add(this.externalIp);
            this.configPanel.Controls.Add(this.label5);
            this.configPanel.Controls.Add(this.externalPort);
            this.configPanel.Controls.Add(this.buttonAdd);
            this.configPanel.Location = new System.Drawing.Point(20, 92);
            this.configPanel.Name = "configPanel";
            this.configPanel.Size = new System.Drawing.Size(750, 105);
            this.configPanel.TabIndex = 1;
            // 
            // consoleLabel
            // 
            this.consoleLabel.AutoSize = true;
            this.consoleLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.consoleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(170)))), ((int)(((byte)(180)))));
            this.consoleLabel.Location = new System.Drawing.Point(20, 215);
            this.consoleLabel.Name = "consoleLabel";
            this.consoleLabel.Size = new System.Drawing.Size(147, 15);
            this.consoleLabel.TabIndex = 2;
            this.consoleLabel.Text = "CONSOLA / RESULTADOS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(790, 595);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.configPanel);
            this.Controls.Add(this.consoleLabel);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NET Forwarding - Andina";
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.configPanel.ResumeLayout(false);
            this.configPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbRedPorts;
        private System.Windows.Forms.TextBox localIp;
        private System.Windows.Forms.TextBox localPort;
        private System.Windows.Forms.TextBox externalPort;
        private System.Windows.Forms.TextBox externalIp;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label subtitleLabel;
        private System.Windows.Forms.Panel configPanel;
        private System.Windows.Forms.Label consoleLabel;
    }
}

