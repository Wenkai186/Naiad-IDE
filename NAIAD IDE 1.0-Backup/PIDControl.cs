using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;
using System.Net.Sockets;

namespace NAIADIDE
{
    public partial class PIDControl : Form
    {
        string sFileName = null;
        public PIDControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XDocument document = new XDocument();
            XElement information = new XElement("Information");
            document.Add(information);

            XElement position = new XElement("Position");
            XElement orientation = new XElement("Orientation");
            information.Add(position);
            information.Add(orientation);


            XElement tpxp = new XElement("TPXP");
            tpxp.SetValue(tPXP.Text);
            XElement tpxi = new XElement("TPXI");
            tpxi.SetValue(tPXI.Text);
            XElement tpxd = new XElement("TPXD");
            tpxd.SetValue(tPXD.Text);

            XElement tpyp = new XElement("TPYP");
            tpyp.SetValue (tPYP.Text);
            XElement tpyi = new XElement("TPYI");
            tpyi.SetValue(tPYI.Text);
            XElement tpyd = new XElement("TPYD");
            tpyd.SetValue(tPYD.Text);
            
            XElement tpzp = new XElement("TPZP");
            tpzp.SetValue(tPZP.Text);
            XElement tpzi = new XElement("TPZI");
            tpzi.SetValue(tPZI.Text);
            XElement tpzd = new XElement("TPZD");
            tpzd.SetValue(tPZD.Text);
            position.Add(tpxp);
            position.Add(tpxi);
            position.Add(tpxd);
            position.Add(tpyp);
            position.Add(tpyi);
            position.Add(tpyd);
            position.Add(tpzp);
            position.Add(tpzi);
            position.Add(tpzd);


            XElement toxp = new XElement("TOXP");
            toxp.SetValue(tOXP.Text);
            XElement toxi = new XElement("TOXI");
            toxi.SetValue(tOXI.Text);
            XElement toxd = new XElement("TOXD");
            toxd.SetValue(tOXD.Text);

            XElement toyp = new XElement("TOYP");
            toyp.SetValue(tOYP.Text);
            XElement toyi = new XElement("TOYI");
            toyi.SetValue(tOYI.Text);
            XElement toyd = new XElement("TOYD");
            toyd.SetValue(tOYD.Text);

            XElement tozp = new XElement("TOZP");
            tozp.SetValue(tOZP.Text);
            XElement tozi = new XElement("TOZI");
            tozi.SetValue(tOZI.Text);
            XElement tozd = new XElement("TOZD");
            tozd.SetValue(tOZD.Text);
            orientation.Add(toxp);
            orientation.Add(toxi);
            orientation.Add(toxd);
            orientation.Add(toyp);
            orientation.Add(toyi);
            orientation.Add(toyd);
            orientation.Add(tozp);
            orientation.Add(tozi);
            orientation.Add(tozd);
            
            if (sFileName != null)
            {
                if (MessageBox.Show("Want to save the XML file", "System", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //dt.OrginalImg.Save(sFileName);
                    document.Save(sFileName);
                }

            }
            else
            {
                SaveFileDialog sfd = new SaveFileDialog();
                //sfd.Filter = "XML(*.xml)|*.xml|JSON(*.json)|*.json";
                sfd.Filter = "XML(*.xml)|*.xml";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    document.Save(sfd.FileName);
                    sFileName = sfd.FileName;

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                XmlRead(openFileDialog.FileName);
            }
            
        }
        public void XmlRead(string fileName)
        {
            XDocument xmlDoc = XDocument.Load(fileName);
            XElement root = xmlDoc.Root;
            XElement positionElement = root.Element("Position");
            tPXP.Text = positionElement.Element("TPXP").Value.ToString();
            tPXI.Text = positionElement.Element("TPXI").Value.ToString();
            tPXD.Text = positionElement.Element("TPXD").Value.ToString();
            tPYP.Text = positionElement.Element("TPYP").Value.ToString();
            tPYI.Text = positionElement.Element("TPYI").Value.ToString();
            tPYD.Text = positionElement.Element("TPYD").Value.ToString();
            tPZP.Text = positionElement.Element("TPZP").Value.ToString();
            tPZI.Text = positionElement.Element("TPZI").Value.ToString();
            tPZD.Text = positionElement.Element("TPZD").Value.ToString();

            XElement orientationElement = root.Element("Orientation");
            tOXP.Text = orientationElement.Element("TOXP").Value.ToString();
            tOXI.Text = orientationElement.Element("TOXI").Value.ToString();
            tOXD.Text = orientationElement.Element("TOXD").Value.ToString();
            tOYP.Text = orientationElement.Element("TOYP").Value.ToString();
            tOYI.Text = orientationElement.Element("TOYI").Value.ToString();
            tOYD.Text = orientationElement.Element("TOYD").Value.ToString();
            tOZP.Text = orientationElement.Element("TOZP").Value.ToString();
            tOZI.Text = orientationElement.Element("TOZI").Value.ToString();
            tOZD.Text = orientationElement.Element("TOZD").Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {

           string youWant =  CreateJson();
           try
           {
               string ipAddress = textBox1.Text.ToString();
               int portNumber = Convert.ToInt32(textBox2.Text);
               if (ipAddress == null || textBox2.Text == null)
               {
                   MessageBox.Show("The information that you enter is not correct\n Please check it", "Oops,Caution");
               }
               else
               {
                   //TcpClient client = new TcpClient("192.168.1.11", 314);
                   TcpClient client = new TcpClient(ipAddress, portNumber);
                   NetworkStream stream = client.GetStream();
                   //string jsonString = json1;
                   byte[] outMessage = System.Text.Encoding.ASCII.GetBytes(youWant);
                   stream.Write(outMessage, 0, outMessage.Length);
                   //json2.RemoveAll();
                   stream.Flush();
               }
           }
            catch 
                {
                    MessageBox.Show("Please check your IP address and port number!", "Oops");
                }
            //string ipAddress = textBox1.Text.ToString();
            //int portNumber = Convert.ToInt32(textBox2.Text);
            
            

        }
        public string CreateJson()
        {
            JObject json = new JObject();
            JObject Position = new JObject();
            JObject Orientation = new JObject();

            Position.Add("PXP", tPXP.Text);
            Position.Add("PXI", tPXI.Text);
            Position.Add("PXD", tPXD.Text);
            Position.Add("PYP", tPYP.Text);
            Position.Add("PYI", tPYI.Text);
            Position.Add("PYD", tPYD.Text);
            Position.Add("PZP", tPZP.Text);
            Position.Add("PZI", tPZI.Text);
            Position.Add("PZD", tPZD.Text);

            Orientation.Add("OXP", tOXP.Text);
            Orientation.Add("OXI", tOXI.Text);
            Orientation.Add("OXD", tOXD.Text);
            Orientation.Add("OYP", tOYP.Text);
            Orientation.Add("OYI", tOYI.Text);
            Orientation.Add("OYD", tOYD.Text);
            Orientation.Add("OZP", tOZP.Text);
            Orientation.Add("OZI", tOZI.Text);
            Orientation.Add("OZD", tOZD.Text);

            json.Add("target", "pid");
            json.Add("Position",Position);
            json.Add("Orientation",Orientation);
            return json.ToString();
        }
    }
}
