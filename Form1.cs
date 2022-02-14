using System;
using System.Runtime;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Azure.Devices.Client;
using Microsoft.Azure.Devices.Client.Exceptions;
using Newtonsoft.Json;
namespace IoTTrafficTool
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
           
            double dTemperatureThreshold = Convert.ToDouble(udTempThreshold.Value);
            double dHumidityThreshold = Convert.ToDouble(udHumidityThreshold.Value);

            int iSleepTime = Convert.ToInt32(udSleepTime.Value) * 1000;
            string sConn = txtConnection.Text;
            
            StringBuilder sb = new StringBuilder();
                        
            DeviceClient deviceClient = DeviceClient.CreateFromConnectionString(txtConnection.Text, TransportType.Mqtt);

            for (int i = 0; i < udNumEvents.Value; i++)
            {
                btnCreate.Text = "Running...";
                btnCreate.Enabled = false;
                btnCreate.Refresh();

                double dTemperature = Math.Round(Convert.ToDouble(udTempBase.Value) + rand.NextDouble() * 15, 2);
                double dHumidity = Math.Round(Convert.ToDouble(udHumidityBase.Value) + rand.NextDouble() * 20, 2);

                var telemetry = new
                {
                    messageId = DateTime.Now.Ticks,
                    deviceId = txtDeviceName.Text + (i % udNumDevices.Value).ToString(), 
                    temperature = dTemperature,
                    humidity = dHumidity
                };

                string sJSON = JsonConvert.SerializeObject(telemetry);
                Microsoft.Azure.Devices.Client.Message message = new Microsoft.Azure.Devices.Client.Message(Encoding.ASCII.GetBytes(sJSON));
                message.Properties.Add("temperatureAlert", (dTemperature > dTemperatureThreshold) ? "true" : "false");

                sb.Append(DateTime.Now + " Sending Message: " + sJSON + "\r\n");
                txtOutput.Text = sb.ToString();
                txtOutput.Refresh();
                
                try
                {
                    deviceClient.SendEventAsync(message);
                }
                catch (IotHubException ex)
                {
                    sb.Append(ex.Message);
                    sb.Append(ex.InnerException);
                }
            }
            btnCreate.Text = "Create IoT Events";
            btnCreate.Enabled = true;
            btnCreate.Refresh();
        }
    }
}
