using System;
 
using System.Collections.Generic;
 
using System.ComponentModel;
 
using System.Data;
 
using System.Drawing;
 
using System.Linq;
 
using System.Text;
 
using System.Windows.Forms;
 
using System.IO.Ports;
 

namespace Led_Yakma
{


    public partial class Form1 : Form
    {
        bool LedOn;


        string SerialAvailable;
        SerialPort serialport;


        public Form1()
        {
            InitializeComponent();
            serialport = new SerialPort();
            serialport.PortName = "COM4";
            serialport.BaudRate = 9600;
            //serialport.Open();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            serialport.Write("0");
            if (serialport.IsOpen) serialport.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serialport.Write("1");
            textBox1.Text = "Isik Acik!";

            button1.Enabled = false;
            button2.Enabled = true;
            LedOn = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            serialport.Write("0");
            textBox1.Text = "Led Kapalı";
            button1.Enabled = true;
            button2.Enabled = false;

            LedOn= false;
        }
       
    }
}
