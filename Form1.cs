using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;

namespace SR0._01_Mediensteuerung
{
    public partial class Form1 : Form
    {
        string STX = "\x02"; //Steuerzeichen STX wird für Extron Umschalter benötigt
        string comport = "serialPort3"; //Hier wird die zu steuernde Kamera initial festgelegt
        string picturemute = "undef"; //Hier wird gespeichert ob der Extron Scaler ein Bild aus gibt
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
            
            if (picturemute != "unmuted")
            {
                Thread.Sleep(1500);
                serialPort1.Write("0B");
                picturemute = "unmuted";
                
            }
            Thread.Sleep(500);
        }

        private void Roland_Kamera_Whiteboard_Click(object sender, EventArgs e)
        {
            comport = "serialPort3";
            this.radioButton1.Checked = true;
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

            if (picturemute != "unmuted")
            {
                Thread.Sleep(1500);
                serialPort1.Write("0B");
                picturemute = "unmuted";

            }
            Thread.Sleep(500);
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

            if (picturemute != "unmuted")
            {
                Thread.Sleep(1500);
                serialPort1.Write("0B");
                picturemute = "unmuted";

            }
            Thread.Sleep(500);
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

            if (picturemute != "unmuted")
            {
                Thread.Sleep(1500);
                serialPort1.Write("0B");
                picturemute = "unmuted";

            }
            Thread.Sleep(500);
        }

        private void Roland_HDMI_Pult_Click(object sender, EventArgs e)
        {
            if (serialPort2.IsOpen)
            {
                serialPort2.Write(STX + "PGM:0;");
            }
            else
            {
                serialPort2.Open();
                serialPort2.Write(STX + "PGM:0;");
            }
        }

        private void Roland_Dokumenten_Kamera_Click(object sender, EventArgs e)
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

        private void Roland_Kamera_Tafel_Click(object sender, EventArgs e)
        {
            comport = "serialPort4";
            this.radioButton2.Checked = true;
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

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            comport = "serialPort3";
            button11.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            comport = "serialPort4";
            button11.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (picturemute != "muted")
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Write("2B");
                }
                else
                {
                    serialPort1.Open();
                    serialPort1.Write("2B");
                }
                picturemute = "muted";
                Thread.Sleep(500);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            var dataByte = new byte[] { 0x81, 0x01, 0x04, 0x3F, 0x02, 0x00, 0xFF }; //Preset0
            if (comport == "serialPort3")
            {
                if (serialPort3.IsOpen)
                {
                    serialPort3.Write(dataByte, 0, 7);
                }
                else
                {
                    serialPort3.Open();
                    serialPort3.Write(dataByte, 0, 7);
                }
            }
            else
            {
                if (serialPort4.IsOpen)
                {
                    serialPort4.Write(dataByte, 0, 7);
                }
                else
                {
                    serialPort4.Open();
                    serialPort4.Write(dataByte, 0, 7);
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var dataByte = new byte[] { 0x81, 0x01, 0x04, 0x3F, 0x02, 0x01, 0xFF }; //Preset1
            if (comport == "serialPort3")
            {
                if (serialPort3.IsOpen)
                {
                    serialPort3.Write(dataByte, 0, 7);
                }
                else
                {
                    serialPort3.Open();
                    serialPort3.Write(dataByte, 0, 7);
                }
            }
            else
            {
                if (serialPort4.IsOpen)
                {
                    serialPort4.Write(dataByte, 0, 7);
                }
                else
                {
                    serialPort4.Open();
                    serialPort4.Write(dataByte, 0, 7);
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var dataByte = new byte[] { 0x81, 0x01, 0x04, 0x3F, 0x02, 0x02, 0xFF }; //Preset2
            if (comport == "serialPort3")
            {
                if (serialPort3.IsOpen)
                {
                    serialPort3.Write(dataByte, 0, 7);
                }
                else
                {
                    serialPort3.Open();
                    serialPort3.Write(dataByte, 0, 7);
                }
            }
            else
            {
                if (serialPort4.IsOpen)
                {
                    serialPort4.Write(dataByte, 0, 7);
                }
                else
                {
                    serialPort4.Open();
                    serialPort4.Write(dataByte, 0, 7);
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            var dataByte = new byte[] { 0x81, 0x01, 0x04, 0x3F, 0x02, 0x03, 0xFF }; //Preset3
            if (comport == "serialPort3")
            {
                if (serialPort3.IsOpen)
                {
                    serialPort3.Write(dataByte, 0, 7);
                }
                else
                {
                    serialPort3.Open();
                    serialPort3.Write(dataByte, 0, 7);
                }
            }
            else
            {
                if (serialPort4.IsOpen)
                {
                    serialPort4.Write(dataByte, 0, 7);
                }
                else
                {
                    serialPort4.Open();
                    serialPort4.Write(dataByte, 0, 7);
                }
            }
        }
    }
}
