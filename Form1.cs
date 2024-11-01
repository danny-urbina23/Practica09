using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica09
{
    public partial class TemperaturaSensor : Form
    {
        delegate void SetTextDelegate(string value);
        public SerialPort ArduinoPort
        {
            get;
        }

        public TemperaturaSensor()
        {
            InitializeComponent();
            ArduinoPort = new System.IO.Ports.SerialPort();
            ArduinoPort.PortName = "COM5";
            ArduinoPort.BaudRate = 9600;
            ArduinoPort.DataBits = 8;
            ArduinoPort.ReadTimeout = 1000;
            ArduinoPort.WriteTimeout = 1000;
            ArduinoPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            this.btnconectar.Click += btnconectar_Click;
        }
        private void DataReceivedHandler(object Sender, SerialDataReceivedEventArgs e)
        {
            string dato = ArduinoPort.ReadLine();
            Escribirtxt(dato);
        }
        private void Escribirtxt(string dato)
        {
            if (InvokeRequired)
                try
                {
                    Invoke(new SetTextDelegate(Escribirtxt), dato);
                }
                catch
                {

                }
            else
                lbltemperatura.Text = dato;
        }

        private void btnconectar_Click(object sender, EventArgs e)
        {
            btndesconectar.Enabled = true;
            btnconectar.Enabled = false;
            try
            {
                if (!ArduinoPort.IsOpen)
                    ArduinoPort.Open();
                if (int.TryParse(txtescribir.Text, out int temperatureLimmit))
                {
                    // Convierte el valor a una cadena y luego em un arreglo de bytes
                    string limitString = temperatureLimmit.ToString();
                    ArduinoPort.Write(limitString);
                }
                else
                {
                    MessageBox.Show("Ingrese un valor numero valido en el textbox");
                }
                lblcon.Text = "Conexion OK";
                lblcon.ForeColor = System.Drawing.Color.LimeGreen;

            }
            catch
            {
                MessageBox.Show("Configure el puerto de comunicacion o desconecte");
            }
        }

        private void btndesconectar_Click(object sender, EventArgs e)
        {
            btnconectar.Enabled = true;
            btndesconectar.Enabled = false;
            ArduinoPort.Close();
            lblcon.Text = "Desconectado";
            lblcon.ForeColor = System.Drawing.Color.Red;
            lbltemperatura.Text = "00.0";
        }

        // Basura
        private void txtescribir_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
