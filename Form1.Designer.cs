
namespace SR0._01_Mediensteuerung
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Extron_VGA_Pult = new System.Windows.Forms.Button();
            this.Extron_HDMI_Pult = new System.Windows.Forms.Button();
            this.Extron_PC_Pult = new System.Windows.Forms.Button();
            this.Extron_Dokumenten_Kamera = new System.Windows.Forms.Button();
            this.Roland_Kamera_Tafel = new System.Windows.Forms.Button();
            this.Roland_Kamera_Whiteboard = new System.Windows.Forms.Button();
            this.Roland_Dokumenten_Kamera = new System.Windows.Forms.Button();
            this.Roland_HDMI_Pult = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort3 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort4 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Extron_VGA_Pult
            // 
            this.Extron_VGA_Pult.Location = new System.Drawing.Point(6, 49);
            this.Extron_VGA_Pult.Name = "Extron_VGA_Pult";
            this.Extron_VGA_Pult.Size = new System.Drawing.Size(124, 118);
            this.Extron_VGA_Pult.TabIndex = 1;
            this.Extron_VGA_Pult.Text = "VGA Pult";
            this.Extron_VGA_Pult.UseVisualStyleBackColor = true;
            this.Extron_VGA_Pult.Click += new System.EventHandler(this.Extron_VGA_Pult_Click);
            // 
            // Extron_HDMI_Pult
            // 
            this.Extron_HDMI_Pult.Location = new System.Drawing.Point(148, 182);
            this.Extron_HDMI_Pult.Name = "Extron_HDMI_Pult";
            this.Extron_HDMI_Pult.Size = new System.Drawing.Size(124, 118);
            this.Extron_HDMI_Pult.TabIndex = 2;
            this.Extron_HDMI_Pult.Text = "HDMI Pult";
            this.Extron_HDMI_Pult.UseVisualStyleBackColor = true;
            this.Extron_HDMI_Pult.Click += new System.EventHandler(this.Extron_HDMI_Pult_Click);
            // 
            // Extron_PC_Pult
            // 
            this.Extron_PC_Pult.Location = new System.Drawing.Point(6, 182);
            this.Extron_PC_Pult.Name = "Extron_PC_Pult";
            this.Extron_PC_Pult.Size = new System.Drawing.Size(124, 118);
            this.Extron_PC_Pult.TabIndex = 3;
            this.Extron_PC_Pult.Text = "PC Pult";
            this.Extron_PC_Pult.UseVisualStyleBackColor = true;
            this.Extron_PC_Pult.Click += new System.EventHandler(this.Extron_PC_Pult_Click);
            // 
            // Extron_Dokumenten_Kamera
            // 
            this.Extron_Dokumenten_Kamera.Location = new System.Drawing.Point(148, 49);
            this.Extron_Dokumenten_Kamera.Name = "Extron_Dokumenten_Kamera";
            this.Extron_Dokumenten_Kamera.Size = new System.Drawing.Size(124, 118);
            this.Extron_Dokumenten_Kamera.TabIndex = 4;
            this.Extron_Dokumenten_Kamera.Text = "Dokumenten Kamera";
            this.Extron_Dokumenten_Kamera.UseVisualStyleBackColor = true;
            this.Extron_Dokumenten_Kamera.Click += new System.EventHandler(this.Extron_Dokumenten_Kamera_Click);
            // 
            // Roland_Kamera_Tafel
            // 
            this.Roland_Kamera_Tafel.Location = new System.Drawing.Point(148, 182);
            this.Roland_Kamera_Tafel.Name = "Roland_Kamera_Tafel";
            this.Roland_Kamera_Tafel.Size = new System.Drawing.Size(124, 118);
            this.Roland_Kamera_Tafel.TabIndex = 9;
            this.Roland_Kamera_Tafel.Text = "Kamera\r\nTafel";
            this.Roland_Kamera_Tafel.UseVisualStyleBackColor = true;
            this.Roland_Kamera_Tafel.Click += new System.EventHandler(this.Roland_Kamera_Tafel_Click);
            // 
            // Roland_Kamera_Whiteboard
            // 
            this.Roland_Kamera_Whiteboard.Location = new System.Drawing.Point(4, 182);
            this.Roland_Kamera_Whiteboard.Name = "Roland_Kamera_Whiteboard";
            this.Roland_Kamera_Whiteboard.Size = new System.Drawing.Size(124, 118);
            this.Roland_Kamera_Whiteboard.TabIndex = 8;
            this.Roland_Kamera_Whiteboard.Text = "Kamera Whiteboard";
            this.Roland_Kamera_Whiteboard.UseVisualStyleBackColor = true;
            this.Roland_Kamera_Whiteboard.Click += new System.EventHandler(this.Roland_Kamera_Whiteboard_Click);
            // 
            // Roland_Dokumenten_Kamera
            // 
            this.Roland_Dokumenten_Kamera.Location = new System.Drawing.Point(148, 42);
            this.Roland_Dokumenten_Kamera.Name = "Roland_Dokumenten_Kamera";
            this.Roland_Dokumenten_Kamera.Size = new System.Drawing.Size(124, 118);
            this.Roland_Dokumenten_Kamera.TabIndex = 7;
            this.Roland_Dokumenten_Kamera.Text = "Dokumenten Kamera";
            this.Roland_Dokumenten_Kamera.UseVisualStyleBackColor = true;
            this.Roland_Dokumenten_Kamera.Click += new System.EventHandler(this.Roland_Dokumenten_Kamera_Click);
            // 
            // Roland_HDMI_Pult
            // 
            this.Roland_HDMI_Pult.Location = new System.Drawing.Point(4, 42);
            this.Roland_HDMI_Pult.Name = "Roland_HDMI_Pult";
            this.Roland_HDMI_Pult.Size = new System.Drawing.Size(124, 118);
            this.Roland_HDMI_Pult.TabIndex = 6;
            this.Roland_HDMI_Pult.Text = "HDMI Pult\r\n\"Streaming\"";
            this.Roland_HDMI_Pult.UseVisualStyleBackColor = true;
            this.Roland_HDMI_Pult.Click += new System.EventHandler(this.Roland_HDMI_Pult_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Extron_VGA_Pult);
            this.groupBox1.Controls.Add(this.Extron_HDMI_Pult);
            this.groupBox1.Controls.Add(this.Extron_PC_Pult);
            this.groupBox1.Controls.Add(this.Extron_Dokumenten_Kamera);
            this.groupBox1.Location = new System.Drawing.Point(20, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 312);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Beamer";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Roland_Kamera_Tafel);
            this.groupBox2.Controls.Add(this.Roland_HDMI_Pult);
            this.groupBox2.Controls.Add(this.Roland_Dokumenten_Kamera);
            this.groupBox2.Controls.Add(this.Roland_Kamera_Whiteboard);
            this.groupBox2.Location = new System.Drawing.Point(420, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(284, 312);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Videokonferenz";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM4";
            // 
            // serialPort2
            // 
            this.serialPort2.PortName = "COM5";
            // 
            // serialPort3
            // 
            this.serialPort3.PortName = "COM6";
            // 
            // serialPort4
            // 
            this.serialPort4.PortName = "COM7";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Location = new System.Drawing.Point(20, 330);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(684, 314);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kamera Steuerung";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(19, 191);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(154, 78);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Tafel\r\nKamera";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(19, 65);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(207, 78);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Whiteboard\r\nKamera";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(579, 195);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 62);
            this.button6.TabIndex = 5;
            this.button6.Text = "-";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button6_MouseDown);
            this.button6.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button6_MouseUp);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(579, 59);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 62);
            this.button5.TabIndex = 4;
            this.button5.Text = "+";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            this.button5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button5_MouseDown);
            this.button5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button5_MouseUp);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(431, 127);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 62);
            this.button4.TabIndex = 3;
            this.button4.Text = "▶";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button4_MouseDown);
            this.button4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button4_MouseUp);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(350, 195);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 62);
            this.button3.TabIndex = 2;
            this.button3.Text = "▼";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button3_MouseDown);
            this.button3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button3_MouseUp);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(266, 127);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 62);
            this.button2.TabIndex = 1;
            this.button2.Text = "◀";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button2_MouseDown);
            this.button2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button2_MouseUp);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(350, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 62);
            this.button1.TabIndex = 0;
            this.button1.Text = "▲";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
            this.button1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button1_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(747, 652);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(769, 708);
            this.MinimumSize = new System.Drawing.Size(769, 708);
            this.Name = "Form1";
            this.Text = "ACI Seminarraum 0.01 Mediensteuerung";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Extron_VGA_Pult;
        private System.Windows.Forms.Button Extron_HDMI_Pult;
        private System.Windows.Forms.Button Extron_PC_Pult;
        private System.Windows.Forms.Button Extron_Dokumenten_Kamera;
        private System.Windows.Forms.Button Roland_Kamera_Tafel;
        private System.Windows.Forms.Button Roland_Kamera_Whiteboard;
        private System.Windows.Forms.Button Roland_Dokumenten_Kamera;
        private System.Windows.Forms.Button Roland_HDMI_Pult;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.IO.Ports.SerialPort serialPort1;
        private System.IO.Ports.SerialPort serialPort2;
        private System.IO.Ports.SerialPort serialPort3;
        private System.IO.Ports.SerialPort serialPort4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

