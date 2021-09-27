using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SR0._01_Mediensteuerung
{
      public partial class Form1 : Form
    {
        string STX = "\x02"; //Steuerzeichen STX wird für Extron Umschalter benötigt
        string comport = "serialPort3";
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Extron_VGA_Pult_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Write("X1!");
            }
            else
            {
                serialPort1.Open();
                serialPort1.Write("X1!");
            }
        }

        private void Roland_Kamera_Whiteboard_Click(object sender, EventArgs e)
        {
            comport = "serialPort3";
            this.radioButton1.Checked = true;
            if (serialPort2.IsOpen)
            {
                serialPort2.Write(STX + "PGM:3;");
            }
            else
            {
                serialPort2.Open();
                serialPort2.Write(STX + "PGM:3;");
            }
        }

        private void Extron_Dokumenten_Kamera_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Write("X4!");
            }
            else
            {
                serialPort1.Open();
                serialPort1.Write("X4!");
            }
        }

        private void Extron_PC_Pult_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Write("X3!");
            }
            else
            {
                serialPort1.Open();
                serialPort1.Write("X3!");
            }
        }

        private void Extron_HDMI_Pult_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Write("X2!");
            }
            else
            {
                serialPort1.Open();
                serialPort1.Write("X2!");
            }
        }

        private void Roland_HDMI_Pult_Click(object sender, EventArgs e)
        {
            if (serialPort2.IsOpen)
            {
                serialPort2.Write(STX + "PGM:1;");
            }
            else
            {
                serialPort2.Open();
                serialPort2.Write(STX + "PGM:1;");
            }
        }

        private void Roland_Dokumenten_Kamera_Click(object sender, EventArgs e)
        {
            if (serialPort2.IsOpen)
            {
                serialPort2.Write(STX + "PGM:2;");
            }
            else
            {
                serialPort2.Open();
                serialPort2.Write(STX + "PGM:2;");
            }
        }

        private void Roland_Kamera_Tafel_Click(object sender, EventArgs e)
        {
            comport = "serialPort4";
            this.radioButton2.Checked = true;
            if (serialPort2.IsOpen)
            {
                serialPort2.Write(STX + "PGM:4;");
            }
            else
            {
                serialPort2.Open();
                serialPort2.Write(STX + "PGM:4;");
            }
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            var dataByte = new byte[] { 0x81,0x01,0x06,0x01,0x01,0x01,0x03,0x01,0xFF }; //UP
            if (comport == "serialPort3")
            {
                if (serialPort3.IsOpen)
                {
                    serialPort3.Write(dataByte, 0, 9);
                }
                else
                {
                    serialPort3.Open();
                    serialPort3.Write(dataByte, 0, 9);
                }
            }
            else
            { 
                if (serialPort4.IsOpen)
                {
                    serialPort4.Write(dataByte, 0, 9);
                }
                else
                {
                    serialPort4.Open();
                    serialPort4.Write(dataByte, 0, 9);
                }
            }
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            var dataByte = new byte[] { 0x81, 0x01, 0x06, 0x01, 0x01, 0x01, 0x03, 0x03, 0xFF }; //STOP
            if (comport == "serialPort3")
            {
                if (serialPort3.IsOpen)
                {
                    serialPort3.Write(dataByte, 0, 9);
                }
                else
                {
                    serialPort3.Open();
                    serialPort3.Write(dataByte, 0, 9);
                }
            }
            else
            {
                if (serialPort4.IsOpen)
                {
                    serialPort4.Write(dataByte, 0, 9);
                }
                else
                {
                    serialPort4.Open();
                    serialPort4.Write(dataByte, 0, 9);
                }
            }
        }

        private void button3_MouseDown(object sender, MouseEventArgs e)
        {
            var dataByte = new byte[] { 0x81, 0x01, 0x06, 0x01, 0x01, 0x01, 0x03, 0x02, 0xFF }; //DOWN
            if (comport == "serialPort3")
            {
                if (serialPort3.IsOpen)
                {
                    serialPort3.Write(dataByte, 0, 9);
                }
                else
                {
                    serialPort3.Open();
                    serialPort3.Write(dataByte, 0, 9);
                }
            }
            else
            {
                if (serialPort4.IsOpen)
                {
                    serialPort4.Write(dataByte, 0, 9);
                }
                else
                {
                    serialPort4.Open();
                    serialPort4.Write(dataByte, 0, 9);
                }
            }
        }

        private void button3_MouseUp(object sender, MouseEventArgs e)
        {
            var dataByte = new byte[] { 0x81, 0x01, 0x06, 0x01, 0x01, 0x01, 0x03, 0x03, 0xFF }; //STOP
            if (comport == "serialPort3")
            {
                if (serialPort3.IsOpen)
                {
                    serialPort3.Write(dataByte, 0, 9);
                }
                else
                {
                    serialPort3.Open();
                    serialPort3.Write(dataByte, 0, 9);
                }
            }
            else
            {
                if (serialPort4.IsOpen)
                {
                    serialPort4.Write(dataByte, 0, 9);
                }
                else
                {
                    serialPort4.Open();
                    serialPort4.Write(dataByte, 0, 9);
                }
            }
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            var dataByte = new byte[] { 0x81, 0x01, 0x06, 0x01, 0x01, 0x01, 0x01, 0x03, 0xFF }; //LEFT
            if (comport == "serialPort3") 
            {
                if (serialPort3.IsOpen)
                {
                    serialPort3.Write(dataByte, 0, 9);
                }
                else
                {
                    serialPort3.Open();
                    serialPort3.Write(dataByte, 0, 9);
                }
            }
            else
            {
                if (serialPort4.IsOpen)
                {
                    serialPort4.Write(dataByte, 0, 9);
                }
                else
                {
                    serialPort4.Open();
                    serialPort4.Write(dataByte, 0, 9);
                }
            }
        }

        private void button2_MouseUp(object sender, MouseEventArgs e)
        {
            var dataByte = new byte[] { 0x81, 0x01, 0x06, 0x01, 0x01, 0x01, 0x03, 0x03, 0xFF }; //STOP
            if (comport == "serialPort3")
            {
                if (serialPort3.IsOpen)
                {
                    serialPort3.Write(dataByte, 0, 9);
                }
                else
                {
                    serialPort3.Open();
                    serialPort3.Write(dataByte, 0, 9);
                }
            }
            else
            {
                if (serialPort4.IsOpen)
                {
                    serialPort4.Write(dataByte, 0, 9);
                }
                else
                {
                    serialPort4.Open();
                    serialPort4.Write(dataByte, 0, 9);
                }
            }
        }

        private void button4_MouseDown(object sender, MouseEventArgs e)
        {
            var dataByte = new byte[] { 0x81, 0x01, 0x06, 0x01, 0x01, 0x01, 0x02, 0x03, 0xFF }; //RIGHT
            if (comport == "serialPort3") 
            {
                if (serialPort3.IsOpen)
                {
                    serialPort3.Write(dataByte, 0, 9);
                }
                else
                {
                    serialPort3.Open();
                    serialPort3.Write(dataByte, 0, 9);
                }
            }
            else
            {
                if (serialPort4.IsOpen)
                {
                    serialPort4.Write(dataByte, 0, 9);
                }
                else
                {
                    serialPort4.Open();
                    serialPort4.Write(dataByte, 0, 9);
                }
            }
        }

        private void button4_MouseUp(object sender, MouseEventArgs e)
        {
            var dataByte = new byte[] { 0x81, 0x01, 0x06, 0x01, 0x01, 0x01, 0x03, 0x03, 0xFF }; //STOP
            if (comport == "serialPort3")
            {
                if (serialPort3.IsOpen)
                {
                    serialPort3.Write(dataByte, 0, 9);
                }
                else
                {
                    serialPort3.Open();
                    serialPort3.Write(dataByte, 0, 9);
                }
            }
            else
            {
                if (serialPort4.IsOpen)
                {
                    serialPort4.Write(dataByte, 0, 9);
                }
                else
                {
                    serialPort4.Open();
                    serialPort4.Write(dataByte, 0, 9);
                }
            }
        }

        private void button5_MouseDown(object sender, MouseEventArgs e)
        {
            var dataByte = new byte[] { 0x81, 0x01, 0x04, 0x07, 0x02, 0xFF }; //ZOOM IN
            if (comport == "serialPort3") 
            {
                if (serialPort3.IsOpen)
                {
                    serialPort3.Write(dataByte, 0, 6);
                }
                else
                {
                    serialPort3.Open();
                    serialPort3.Write(dataByte, 0, 6);
                }
            }
            else
            {
                if (serialPort4.IsOpen)
                {
                    serialPort4.Write(dataByte, 0, 6);
                }
                else
                {
                    serialPort4.Open();
                    serialPort4.Write(dataByte, 0, 6);
                }
            }
        }

        private void button5_MouseUp(object sender, MouseEventArgs e)
        {
            var dataByte = new byte[] { 0x81, 0x01, 0x04, 0x07, 0x00, 0xFF }; //ZOOM STOP
            if (comport == "serialPort3") 
            {
                if (serialPort3.IsOpen)
                {
                    serialPort3.Write(dataByte, 0, 6);
                }
                else
                {
                    serialPort3.Open();
                    serialPort3.Write(dataByte, 0, 6);
                }
            }
            else
            {
                if (serialPort4.IsOpen)
                {
                    serialPort4.Write(dataByte, 0, 6);
                }
                else
                {
                    serialPort4.Open();
                    serialPort4.Write(dataByte, 0, 6);
                }
            }
        }

        private void button6_MouseDown(object sender, MouseEventArgs e)
        {
            var dataByte = new byte[] { 0x81, 0x01, 0x04, 0x07, 0x03, 0xFF }; //ZOOM OUT
            if (comport == "serialPort3")
            {
                if (serialPort3.IsOpen)
                {
                    serialPort3.Write(dataByte, 0, 6);
                }
                else
                {
                    serialPort3.Open();
                    serialPort3.Write(dataByte, 0, 6);
                }
            }
            else
            {
                if (serialPort4.IsOpen)
                {
                    serialPort4.Write(dataByte, 0, 6);
                }
                else
                {
                    serialPort4.Open();
                    serialPort4.Write(dataByte, 0, 6);
                }
            }
        }

        private void button6_MouseUp(object sender, MouseEventArgs e)
        {
            var dataByte = new byte[] { 0x81, 0x01, 0x04, 0x07, 0x00, 0xFF }; //ZOOM STOP
            if (comport == "serialPort3") 
            {
                if (serialPort3.IsOpen)
                {
                    serialPort3.Write(dataByte, 0, 6);
                }
                else
                {
                    serialPort3.Open();
                    serialPort3.Write(dataByte, 0, 6);
                }
            }
            else
            {
                if (serialPort4.IsOpen)
                {
                    serialPort4.Write(dataByte, 0, 6);
                }
                else
                {
                    serialPort4.Open();
                    serialPort4.Write(dataByte, 0, 6);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e) //Tafelkamera soll gesteuert werden
        {
            comport = "serialPort4";
        }

        private void button8_Click(object sender, EventArgs e) //Whiteboardkamera soll gesteuert werden
        {
            comport = "serialPort3";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            comport = "serialPort3";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            comport = "serialPort4";
        }
    }
}
