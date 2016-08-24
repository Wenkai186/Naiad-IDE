using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.Text.RegularExpressions;
using System.Net.Sockets;

namespace NAIADIDE
{
    public partial class CanMessage : Form
    {
        public CanMessage()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string id = @"^[0-9]{1,}$";
            //string len = @"^[0-9]{1,}$";
            //string b1_b8 = @"^[0-9]{1,}$";

            JObject json = new JObject();
            JObject canMessage = new JObject();
            JObject Id = new JObject();
            JObject Len = new JObject();
            JObject B1_B8 = new JObject();
            //JObject Target = new JObject();

           canMessage.Add("target","can");
            string iD = tbID.Text;
            string lEN = llen.Text;
            //string wb1 = tbb1.Text;
            //string wb2 = tbb2.Text;
            //string wb3 = tbb3.Text;
            //string wb4 = tbb4.Text;
            //string wb5 = tbb5.Text;
            //string wb6 = tbb6.Text;
            //string wb7 = tbb7.Text;
            //string wb8 = tbb8.Text;
            List<TextBox> strs = new List<TextBox>();
            strs.Add(tbb1);
            strs.Add(tbb2);
            strs.Add(tbb3);
            strs.Add(tbb4);
            strs.Add(tbb5);
            strs.Add(tbb6);
            strs.Add(tbb7);
            strs.Add(tbb8);
            printShow print = idShow;
            CreateJson(id, canMessage, iD, idShow,"id");

            bool strCheck = CheckNull(strs);
            if (strCheck)
            {
                foreach (TextBox stringitem in strs)
                {
                    strs.Sort((x,y)=>x.TabIndex.CompareTo(y.TabIndex));
                    int indexItem = strs.IndexOf(stringitem) +1;
                    //if (System.Text.RegularExpressions.Regex.IsMatch(stringitem.Text, "^[0-9a-zA-Z]"))
                    //{
                    //    MessageBox.Show("This textbox accepts only alphabetical characters");
                    //    stringitem.Text.Remove(stringitem.Text.Length - 1);
                    //}
                    if (System.Text.RegularExpressions.Regex.IsMatch(stringitem.Text, @"^[a-zA-Z]$"))
                    {
                        byte[] asciiBytes = Encoding.ASCII.GetBytes(stringitem.Text);
                        canMessage.Add("b" + indexItem.ToString(), asciiBytes[0].ToString());
                    }
                    else
                        canMessage.Add("b" + indexItem.ToString(), stringitem.Text);
                    

                }
                canMessage.Add("len", (strs.Count).ToString());
                llen.Text = (strs.Count).ToString();
            }
            else
                foreach (TextBox item in strs)
                {
                    int indexItem = strs.IndexOf(item) + 1;
                    if (item.Text != "")
                    {
                        //if (System.Text.RegularExpressions.Regex.IsMatch(item.Text, @"^[0-9a-zA-Z]"))
                        //{
                        //    MessageBox.Show("This textbox accepts only alphabetical characters and numbers");
                        //    item.Text.Remove(item.Text.Length - 1);
                        //}
                        if (System.Text.RegularExpressions.Regex.IsMatch(item.Text, @"^[a-zA-Z]{1,10}$"))
                        {
                           // int aa = (int)(item.Text);
                            byte[] asciiBytes = Encoding.ASCII.GetBytes(item.Text);
                            canMessage.Add("b" + indexItem.ToString(), asciiBytes[0].ToString());
                        }
                        else
                            canMessage.Add("b" + indexItem.ToString(), item.Text);
                    }
                    else
                    {
                        canMessage.Add("len", (indexItem-1).ToString());
                        llen.Text = (indexItem - 1).ToString();
                        break;
                    }

                }

            json.Add("CAN Message", canMessage);//.ToString());
            try
            {
                string ipAddress = tbIP.Text.ToString();
                int portNumber = Convert.ToInt32(tbP.Text);
                if (ipAddress == null || tbP.Text == null)
                {
                    MessageBox.Show("The information that you enter is not correct\n Please check it", "Oops,Caution");
                }
                else
                {
                    //TcpClient client = new TcpClient("192.168.1.11", 314);
                    TcpClient client = new TcpClient(ipAddress, portNumber);
                    NetworkStream stream = client.GetStream();
                    //string jsonString = json1;
                    byte[] outMessage = System.Text.Encoding.ASCII.GetBytes(json.ToString());
                    stream.Write(outMessage, 0, outMessage.Length);
                    //json2.RemoveAll();
                    stream.Flush();
                }
            }
            catch
            {
                MessageBox.Show("Please check your IP address and port number!", "Oops");
            }
        }
        public delegate void printShow();
        public bool CheckNull(List<TextBox> list)
        {
            foreach (TextBox sss in list)
            {
                if (sss.Text == "")
                    return false;
               
            }
            return true;
        }
        private  void CreateJson(string id, JObject Id, string iD,printShow delg,string ID)
        {
            Match m = Regex.Match(iD, id);
            if (!m.Success)
            {
                //MessageBox.Show("This is not a valid IP address", "oops");
                if (delg != null)
                    delg();
            }
            else
                Id.Add(ID, iD);
        }
        private void idShow()
        {
            MessageBox.Show("This is not a valid ID address", "oops");
        }
        private void lenShow()
        {
            MessageBox.Show("The Len is not a valid value", "oops");
        }
        private void bShow()
        {
            MessageBox.Show("b1-b8 is not a valid value", "oops");
        }

       
    }
}
