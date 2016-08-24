using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections;
using Newtonsoft.Json;
//using Newtonsoft.
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Converters;
using System.Xml.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text.RegularExpressions;



namespace NAIADIDE
{
    public partial class NaiadIDE : Form
    {
        
        List<IPaintItem> unitNameList = new List<IPaintItem>();
        List<IPaintItem> straightLineNameList = new List<IPaintItem>();
        List<IPaintItem> curveLineNameList = new List<IPaintItem>();
        private IPaintItem w_currentItem = null;
         private string sFileName;
        // List<string> strList = new List<string>();
         string strList;
        // private PaintPanel pp;
         
         //private static JObject json1= new JObject();
         //private static JObject json2= new JObject();
        public NaiadIDE()
        {
            InitializeComponent();
            this.tSButton1.AllowDrop = true;//ToolStripButton1.AllowDrop = true;
            this.tsButton2.AllowDrop = true;
            this.tsButton3.AllowDrop = true;
            this.tsButton5.AllowDrop = true;
            this.tsButton6.AllowDrop = true;
           // tSButton1.MouseDown += new MouseEventHandler(tSButton1_MouseDown);
           // panel1.DragDrop += new DragEventHandler(panel1_DragDrop);
            //panel1.DragEnter += new DragEventHandler(panel1_DragEnter);
            panel1.MouseDoubleClick += new MouseEventHandler(panel1_MouseDoubleClick);
        }

        void panel1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           IPaintItem item = this.panel1.GetItemAtPoint(e.Location);

            SearchSetting set = new SearchSetting();
            set.ShowDialog();
            //strList.Add(set.searchProperty);
            strList = set.searchProperty;
            item.doubleClickCheck = true;
        }
        //void panel_MouseDoubleClick(object sender, MouseEventArgs e)
        //{
        //    IPaintItem item = this.panel1.GetItemAtPoint(e.Location);
            
        //    SearchSetting set = new SearchSetting();
        //    set.ShowDialog();
        //    strList.Add(set.Str);
        //    item.doubleClickCheck = true;
            
        //}
        void panel1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Link;//The data from the drag source is linked to the drop target.
        }

        void tSButton1_MouseDown(object sender, MouseEventArgs e)
        {
            toolStrip1.DoDragDrop("Search Target", DragDropEffects.Link);
        }
        void tsButton2_MouseDown(object sender, MouseEventArgs e)
        {
            toolStrip1.DoDragDrop("Tracing Light", DragDropEffects.Link);
        }
        void tsButton5_MouseDown(object sender, MouseEventArgs e)
        {
            toolStrip1.DoDragDrop("Change Shape", DragDropEffects.Link);
        }
        void tsButton6_MouseDown(object sender, MouseEventArgs e)
        {
            toolStrip1.DoDragDrop("Fire Torpedo", DragDropEffects.Link);
        }
        // private IPaintItem m_currentitem = null;
        #region drag tasks into Panel
        void panel1_DragDrop(object sender, DragEventArgs e)
        {
            string itemType = e.Data.GetData(typeof(string)).ToString();
            Point leftTopPoint = this.PointToScreen(this.panel1.Location);
            switch (itemType)
            {
                case"Search Target":
                    //Point leftTopPoint = this.PointToScreen(this.panel1.Location);
                    PaintUnit search = new PaintUnit("Search Target", NAIAD_IDE_1._0.Properties.Resources.Search, new Point(e.X - leftTopPoint.X - NAIAD_IDE_1._0.Properties.Resources.Search.Width / 2,
                                e.Y - leftTopPoint.Y - NAIAD_IDE_1._0.Properties.Resources.Search.Height / 2), new Pen(Color.Gray), this.Font,false,1);
                    this.panel1.PaintItems.Add(search);//.PaintItems.Add(item);
                    this.panel1.Refresh();//Reloads the file that is currently displayed in the object.
                    break;
                case "Tracing Light":

                    PaintUnit trace = new PaintUnit("Tracing Light", NAIAD_IDE_1._0.Properties.Resources.trace, new Point(e.X - leftTopPoint.X - NAIAD_IDE_1._0.Properties.Resources.trace.Width / 2,
                                e.Y - leftTopPoint.Y - NAIAD_IDE_1._0.Properties.Resources.trace.Height / 2), new Pen(Color.Gray), this.Font,false,2);
                    this.panel1.PaintItems.Add(trace);//.PaintItems.Add(item);
                    this.panel1.Refresh();//Reloads the file that is currently displayed in the object.
                    break;
                case "Change Shape":
                    //Point leftTopPoint = this.PointToScreen(this.panel1.Location);
                    PaintUnit change = new PaintUnit("Change Shape", NAIAD_IDE_1._0.Properties.Resources.Search, new Point(e.X - leftTopPoint.X - NAIAD_IDE_1._0.Properties.Resources.Search.Width / 2,
                                e.Y - leftTopPoint.Y - NAIAD_IDE_1._0.Properties.Resources.Search.Height / 2), new Pen(Color.Gray), this.Font, false, 3);
                    this.panel1.PaintItems.Add(change);//.PaintItems.Add(item);
                    this.panel1.Refresh();//Reloads the file that is currently displayed in the object.
                    break;
                case "Fire Torpedo":
                    //Point leftTopPoint = this.PointToScreen(this.panel1.Location);
                    PaintUnit fire = new PaintUnit("Fire Torpedo", NAIAD_IDE_1._0.Properties.Resources.Search, new Point(e.X - leftTopPoint.X - NAIAD_IDE_1._0.Properties.Resources.Search.Width / 2,
                                e.Y - leftTopPoint.Y - NAIAD_IDE_1._0.Properties.Resources.Search.Height / 2), new Pen(Color.Gray), this.Font, false, 4);
                    this.panel1.PaintItems.Add(fire);//.PaintItems.Add(item);
                    this.panel1.Refresh();//Reloads the file that is currently displayed in the object.
                    break;
                default:
                    break;
            }
            
            //this.panel1.G
           // PaintPanel();

        }
        #endregion
        int wCount = 1;
        int wDigital = 1;
        private void Line_Click(object sender, EventArgs e)
        {
            this.tsButton3.Checked = !this.tsButton3.Checked;
            
        }

        private void tsButton4_Click(object sender, EventArgs e)
        {
            this.tsButton4.Checked = !this.tsButton4.Checked;
        }

        #region Panel Mouse Down function

        private void panel1_MouseDown(object sender,MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                foreach (IPaintItem item in this.panel1.PaintItems)
                {
                    item.selectStatus = false;
                }
                IPaintItem selectedUnit = this.panel1.GetItemAtPoint(e.Location);
                if (selectedUnit != null && selectedUnit is PaintUnit)
                {
                    if (tsButton3.Checked)
                    {
                       
                        DrawLine line = new DrawLine("line"+wCount.ToString(), e.Location, new Pen(Color.Black, 10), this.Font,wDigital);
                        line.StartPoint = (PaintUnit)selectedUnit;
                        line.StartPoint.itemLocation = ((PaintUnit)selectedUnit).itemLocation;
                        w_currentItem = line;
                        panel1.DrawLine = true;
                    }
                    else if (tsButton4.Checked)
                    {

                        CallBackLine curve = new CallBackLine("line" + wCount.ToString(), e.Location, new Pen(Color.Black, 10), this.Font);
                        curve.StartPoint = (PaintUnit)selectedUnit;
                        if (selectedUnit.status)
                        {
                            MessageBox.Show("This task has already CallBack once and can't CallBack again.\nPlease find another solution!", "You are in TROUBLE!");
                        }
                        else
                        {
                            selectedUnit.status = true;
                            w_currentItem = curve;
                            panel1.DrawLine = true;
                        }

                    }
                    else
                    {

                        selectedUnit.selectStatus = true;
                    }
                }
            }
            
        }
        #endregion

        #region Panle1 MouseUp function

        private void panle1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (tsButton3.Checked && (w_currentItem != null && w_currentItem is DrawLine))
                {
                    IPaintItem selectedunit = this.panel1.GetItemAtPoint(e.Location);
                    if (selectedunit != null && selectedunit is PaintUnit)
                    {
                        ((DrawLine)w_currentItem).EndPoint = (PaintUnit)selectedunit;
                        if (((DrawLine)w_currentItem).EndPoint.itemLocation == ((DrawLine)w_currentItem).StartPoint.itemLocation)
                        {
                            MessageBox.Show("Please chose another end point!", "OOPs");
                        }
                        else
                        {
                            this.panel1.PaintItems.Add(w_currentItem);
                            wCount++;
                            wDigital++;
                        }
                        
                    }
                    this.tsButton3.Checked = false;
                    w_currentItem = null;


                }
                if (tsButton4.Checked && (w_currentItem != null && w_currentItem is CallBackLine))
                {
                    IPaintItem selectedunit = this.panel1.GetItemAtPoint(e.Location);
                    if (selectedunit != null && selectedunit is PaintUnit)
                    {
                        ((CallBackLine)w_currentItem).EndPoint = (PaintUnit)selectedunit;
                        if (((CallBackLine)w_currentItem).EndPoint.itemLocation == ((CallBackLine)w_currentItem).StartPoint.itemLocation)
                        {
                            MessageBox.Show("Please chose another end point!", "OOPs");
                            selectedunit.status = false;
                        }
                        //if(((CallBackLine)w_currentItem).ArrPoints[2] == ((CallBackLine)w_currentItem).ArrPoints[0])
                        else
                        {
                            this.panel1.PaintItems.Add(w_currentItem);
                            wCount++;
                        }

                    }
                    else
                        ((CallBackLine)w_currentItem).StartPoint.status = false;
                    this.tsButton4.Checked = false;
                    w_currentItem = null;
                }
                panel1.DrawLine = false;

            }
            this.panel1.Refresh();
        }
        #endregion

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #region Save the file as Json format
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {


            string json0 = CreateJsonString();

            SaveFileDialog saveJson = new SaveFileDialog();
          

                saveJson.Filter = "JSON(*.json)|*.json";

                if (saveJson.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveJson.FileName, json0);
                }
           
            unitNameList.Clear();
            straightLineNameList.Clear();
            curveLineNameList.Clear();
            
                
        }

        
        #endregion

        #region Save the file as XML format
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAsXml();
            
            //doc.Save("Mission Control.xml");
        }

        private void SaveAsXml()
        {
            
            int lineCount = 1;
            bool checkMark = false;
            PutItemInList();
            unitNameList.Sort((x, y) => x.itemLocation.X.CompareTo(y.itemLocation.X));
            straightLineNameList.Sort((x, y) => x.itemLocation.X.CompareTo(y.itemLocation.X));
           
            XDocument doc = new XDocument();
            XElement structure = new XElement("Structure");
            XElement unit = new XElement("Mission");
            XElement straightLine = new XElement("StraightLine");
            XElement curveLine = new XElement("CurveLine");
            foreach (DrawLine lineItem in straightLineNameList)
            {
                if (straightLineNameList[straightLineNameList.Count - 1] == lineItem)
                {
                    foreach (PaintUnit unitItem in unitNameList)
                    {
                        int unitCount = unitNameList.IndexOf(unitItem) + 1;
                        XElement step = new XElement("Step" + unitCount.ToString());
                        XElement unitName = new XElement("unitName");
                        XElement unitLocation = new XElement("unitLocation");
                        XElement callBack = new XElement("CallBack");
                        XElement setting = new XElement("Setting");
                        if (unitItem.itemLocation == lineItem.StartPoint.itemLocation)
                        {
                            unitName.SetValue(unitItem.itemName);
                            unitLocation.SetValue(unitItem.itemLocation);
                            GetXMLCallBack(unitItem, callBack,setting);
                            step.Add(unitName);
                            step.Add(unitLocation);
                            step.Add(callBack);
                            step.Add(setting);
                            unit.Add(step);
                        }
                    }
                    checkMark = true;
                    if (checkMark)
                    {
                       
                        //S unitNameList.Sort((x, y) => x.itemLocation.X.CompareTo(y.itemLocation.X));
                        foreach (PaintUnit unitItem in unitNameList)
                        {
                            int unitCount = unitNameList.IndexOf(unitItem) + 1;
                            XElement step = new XElement("Step" + unitCount.ToString());
                            XElement unitName = new XElement("unitName");
                            XElement unitLocation = new XElement("unitLocation");
                            XElement callBack = new XElement("CallBack");
                            XElement setting = new XElement("Setting");
                            if (unitItem.itemLocation == lineItem.EndPoint.itemLocation)
                            {
                                unitName.SetValue(unitItem.itemName);
                                unitLocation.SetValue(unitItem.itemLocation);
                                GetXMLCallBack(unitItem, callBack,setting);
                                step.Add(unitName);
                                step.Add(unitLocation);
                                step.Add(callBack);
                                step.Add(setting);
                                unit.Add(step);
                            }
                        }
                        checkMark = false;
                    }
                }
                #region change
                // else if (straightLineNameList[straightLineNameList.Count - 2] == lineItem)
                //{

                //    foreach (PaintUnit unitItem in unitNameList)
                //    {
                //       int unitCount = unitNameList.IndexOf(unitItem) + 1;
                //        XElement step = new XElement("Step" + unitCount.ToString());
                //        XElement unitName = new XElement("unitName");
                //        XElement unitLocation = new XElement("unitLocation");
                //        XElement callBack = new XElement("CallBack");
                //        if (unitItem.itemLocation == lineItem.StartPoint.itemLocation)
                //        {
                //           unitName.SetValue(unitItem.itemName);
                //            unitLocation.SetValue(unitItem.itemLocation);
                //            GetXMLCallBack(unitItem, callBack);
                //            step.Add(unitName);
                //            step.Add(unitLocation);
                //            step.Add(callBack);
                //            unit.Add(step);

                //        }
                //    }
                //    checkMark = true;
                //    if (checkMark)
                //    {
                //       //S unitNameList.Sort((x, y) => x.itemLocation.X.CompareTo(y.itemLocation.X));
                //        foreach (PaintUnit unitItem in unitNameList)
                //        {
                //           int unitCount = unitNameList.IndexOf(unitItem) + 1;
                //            XElement step = new XElement("Step" + unitCount.ToString());
                //            XElement unitName = new XElement("unitName");
                //            XElement unitLocation = new XElement("unitLocation");
                //            XElement callBack = new XElement("CallBack");
                //            if (unitItem.itemLocation == lineItem.EndPoint.itemLocation)
                //            {
                //               unitName.SetValue(unitItem.itemName);
                //                unitLocation.SetValue(unitItem.itemLocation);
                //                GetXMLCallBack(unitItem, callBack);
                //                step.Add(unitName);
                //                step.Add(unitLocation);
                //                step.Add(callBack);
                //                unit.Add(step);
                //            }
                //        }
                //        checkMark = false;
                //    }
                //}
                #endregion
                else
                    foreach (PaintUnit unitItem in unitNameList)
                    {
                        int unitCount = unitNameList.IndexOf(unitItem) + 1;
                            XElement step = new XElement("Step" + unitCount.ToString());
                            XElement unitName = new XElement("unitName");
                            XElement unitLocation = new XElement("unitLocation");
                            XElement callBack = new XElement("CallBack");
                            XElement setting = new XElement("Setting");
                            if (unitItem.itemLocation == lineItem.StartPoint.itemLocation)
                            {
                               unitName.SetValue(unitItem.itemName);
                                unitLocation.SetValue(unitItem.itemLocation);
                                GetXMLCallBack(unitItem, callBack,setting);
                                step.Add(unitName);
                                step.Add(unitLocation);
                                step.Add(callBack);
                                step.Add(setting);
                                unit.Add(step);
                            }
                    }
           

            }
            foreach (DrawLine item in straightLineNameList)
            {

                XElement line = new XElement("line" + lineCount.ToString());
                XElement lineName = new XElement("LineName");
                XElement lineStartPoint = new XElement("lineStartPoint");
                XElement lineEndPoint = new XElement("lineEndPoint");

                lineName.SetValue(item.itemName);
                lineStartPoint.SetValue(item.StartPoint.itemLocation);
                lineEndPoint.SetValue(item.EndPoint.itemLocation);
                line.Add(lineName);
                line.Add(lineStartPoint);
                line.Add(lineEndPoint);
                straightLine.Add(line);
                //structure.Add(straightLine);
                lineCount++;
            }
            structure.Add(unit);
            structure.Add(straightLine);
            doc.Add(structure);
            if (sFileName != null)
            {
                if (MessageBox.Show("Want to save the XML file", "System", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //dt.OrginalImg.Save(sFileName);
                    doc.Save(sFileName);
                }

            }
            else
            {
                SaveFileDialog sfd = new SaveFileDialog();
                //sfd.Filter = "XML(*.xml)|*.xml|JSON(*.json)|*.json";
                sfd.Filter = "XML(*.xml)|*.xml";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    doc.Save(sfd.FileName);
                    sFileName = sfd.FileName;

                }
            }
            unitNameList.Clear();
            straightLineNameList.Clear();
            curveLineNameList.Clear();

        }

        private void GetXMLCallBack(PaintUnit unitItem, XElement callBack,XElement setting)
        {
            if (unitItem.doubleClickCheck)
            {
                setting.SetValue(strList);
                //strList.Clear();
            }
            if (unitItem.status)
            {
                foreach (CallBackLine curveItem in curveLineNameList)
                {
                    if (curveItem.StartPoint.itemLocation == unitItem.itemLocation)
                    {
                        foreach (PaintUnit unit1 in unitNameList)
                        {
                            int indexofUnit = unitNameList.IndexOf(unit1) + 1;
                            if (curveItem.EndPoint.itemLocation == unit1.itemLocation)
                            {
                                callBack.SetValue("step" + indexofUnit.ToString());
                            }
                        }
                    }
                }
            }
            else
                callBack.SetValue("null");
            
        }

        private void PutItemInList()
        {
            unitNameList.Clear();
            straightLineNameList.Clear();
            curveLineNameList.Clear();
            for (int i = 0; i < this.panel1.PaintItems.Count; i++)
            {
                if (this.panel1.PaintItems[i] is PaintUnit)
                    unitNameList.Add(this.panel1.PaintItems[i]);
                else if (this.panel1.PaintItems[i] is DrawLine)
                    straightLineNameList.Add(this.panel1.PaintItems[i]);
                else if (this.panel1.PaintItems[i] is CallBackLine)
                    curveLineNameList.Add(this.panel1.PaintItems[i]);
            }
        }

        #endregion
        //bool checkConnect = false;
        //public TcpClient createNewClient(string ipAddress, int portNumber)
        //{
        //    TcpClient client = new TcpClient(ipAddress,portNumber);
        //    checkConnect = true;
        //    return client;
        //}
        private void bTCP_Click(object sender, EventArgs e)
        {
            
           
            ////if(bTCP==checked)
            //if (!checkConnect)
            //{
            //    //TcpClient client = new TcpClient("192.168.1.11", 314);
            //    createNewClient("192.168.1.11", 314);
            //}
            try
            {
                string json1 = CreateJsonString();
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
                    byte[] outMessage = System.Text.Encoding.ASCII.GetBytes(json1);
                    stream.Write(outMessage, 0, outMessage.Length);
                    //json2.RemoveAll();
                    stream.Flush();
                    //json1.RemoveAll();
                }
            }
            catch
            {
                MessageBox.Show("Please check your IP address and port number!", "Oops");
            }
            //string ipAddress = textBox1.Text.ToString();
            //int portNumber = Convert.ToInt32(textBox2.Text);
            
            ////TcpClient client = new TcpClient("192.168.1.11", 314);
            //TcpClient client = new TcpClient(ipAddress, portNumber);
            //NetworkStream stream = client.GetStream();
            ////string jsonString = json1;
            //byte[] outMessage = System.Text.Encoding.ASCII.GetBytes(json1);
            //stream.Write(outMessage, 0, outMessage.Length);
            ////json2.RemoveAll();
            //stream.Flush();
           // json1.RemoveAll();
            unitNameList.Clear();
            straightLineNameList.Clear();
            curveLineNameList.Clear();
            //show("reading here00");
            //byte[] inStream = new byte[20056];
            ////Console.WriteLine("reading here00");
            //show("reading here01");
            //stream.Read(inStream, 0, (int)client.ReceiveBufferSize);
            //show("reading here02");
            //string returndata = System.Text.Encoding.ASCII.GetString(inStream);
            //show("reading here03");
            ////Console.WriteLine(returndata);
            //show("reading here04");

            //label1.Text = returndata;
            
            //stream.Flush();
            //stream.Close();
            //client.Close();
        }
        public void show(string str)
        {
            //Console.WriteLine(str);
            label1.Text = str;
        }
        private string CreateJsonString()
        {
            
            int wCount = 1;
            PutItemInList();

            unitNameList.Sort((x, y) => x.itemLocation.X.CompareTo(y.itemLocation.X));
            straightLineNameList.Sort((x,y)=>x.itemLocation.X.CompareTo(y.itemLocation.X));
            JObject json1 = new JObject();
            bool checkMark = false;
            foreach (DrawLine line in straightLineNameList)
            {

                if (straightLineNameList[straightLineNameList.Count - 1] == line)
                {
                    foreach (PaintUnit item in unitNameList)
                    {
                        string itemName = item.itemName;

                        JObject json2 = new JObject();
                        

                        if (item.itemLocation == line.StartPoint.itemLocation)
                        {
                            CreateSubJsonString(item, itemName, json2);


                            json1.Add("step" + wCount.ToString(), json2);
                            //json2.RemoveAll();
                            wCount++;


                        }



                    }
                    checkMark = true;
                    if (checkMark)
                    {
                        //S unitNameList.Sort((x, y) => x.itemLocation.X.CompareTo(y.itemLocation.X));
                        foreach (PaintUnit uitem in unitNameList)
                        {
                            string itemName = uitem.itemName;

                            JObject json2 = new JObject();
                            if (uitem.itemLocation == line.EndPoint.itemLocation)
                            {
                                CreateSubJsonString(uitem, itemName, json2);
                                json1.Add("step" + wCount.ToString(), json2);
                                //json2.RemoveAll();
                                wCount++;


                            }
                        }
                        checkMark = false;
                    }
                }
                #region
                //else if (straightLineNameList[straightLineNameList.Count - 2] == line)
                //{

                //    foreach (PaintUnit item in unitNameList)
                //    {
                //        string itemName = item.itemName;

                //        JObject json2 = new JObject();
                //        if (item.itemLocation == line.StartPoint.itemLocation)
                //        {
                //            CreateSubJsonString(item, itemName, json2);
                //            json1.Add("step" + wCount.ToString(), json2);
                //            //json2.RemoveAll();
                //            wCount++;


                //        }



                //    }

                //    checkMark = true;
                //    if (checkMark)
                //    {
                //        //S unitNameList.Sort((x, y) => x.itemLocation.X.CompareTo(y.itemLocation.X));
                //        foreach (PaintUnit uitem in unitNameList)
                //        {
                //            string itemName = uitem.itemName;

                //            JObject json2 = new JObject();
                //            if (uitem.itemLocation == line.EndPoint.itemLocation)
                //            {
                //                CreateSubJsonString(uitem, itemName, json2);
                //                json1.Add("step" + wCount.ToString(), json2);
                //                //json2.RemoveAll();
                //                wCount++;


                //            }
                //        }
                //        checkMark = false;
                //    }
                //}
                #endregion
                else
                    foreach (PaintUnit item in unitNameList)
                    {
                        string itemName = item.itemName;

                        JObject json2 = new JObject();
                        if (item.itemLocation == line.StartPoint.itemLocation)
                        {
                            CreateSubJsonString(item, itemName, json2);
                            json1.Add("step" + wCount.ToString(), json2);
                            //json2.RemoveAll();
                            wCount++;

                        }
                    }

            }
            //return json1.ToString();
            return json1.ToString(Formatting.None);
        }

        private string CreateSubJsonString(PaintUnit item, string itemName, JObject json2)
        {
            unitNameList.Sort((x, y) => x.itemLocation.X.CompareTo(y.itemLocation.X));
            //int i = unitNameList.Count;
            //int callBackNnumber = 0;
            //foreach (PaintUnit unit in unitNameList)
            //{ 
                
            //}
            //PutItemInList();
            json2.Add("mission", itemName);
            if (item.doubleClickCheck)
            {
                JObject jset = new JObject();
                jset.Add("Set", strList);
                json2.Add("Setting", jset);
                // strList.Clear();
            }
            if (item.status)
            {

                foreach (CallBackLine curve in curveLineNameList)
                {
                    if (curve.StartPoint.itemLocation == item.itemLocation)
                    {
                        foreach (PaintUnit unit in unitNameList)
                        {
                            if (curve.EndPoint.itemLocation == unit.itemLocation)
                            {
                                //unitNameList.Sort((x, y) => x.itemLocation.X.CompareTo(y.itemLocation.X));
                                int indexofUnit = unitNameList.IndexOf(unit);
                                json2.Add("CallBack", "step" + (indexofUnit + 1).ToString());
                            }
                        }
                    }
                }
                //get curveline end point and return item
                //json2.Add("CallBack",return item.name)
            }
            else
                json2.Add("CallBack", null);
            
            return json2.ToString(Formatting.None);
        }
       

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            unitNameList.Clear();
            straightLineNameList.Clear();
            curveLineNameList.Clear();
            this.panel1.PaintItems.Clear();
            this.panel1.Refresh();
        }

       

        private void saveXML_Click(object sender, EventArgs e)
        {
            SaveAsXml();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you really want to DELETE ALL or Just kidding", "Oops,Caution", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                unitNameList.Clear();
                straightLineNameList.Clear();
                curveLineNameList.Clear();
                this.panel1.PaintItems.Clear();
                this.panel1.Refresh();
            }
            else
            {
                this.panel1.Refresh();
            }
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Do you really want to DELETE this or Just kidding","Oops",
            if ((this.panel1.PaintItems.Count - 1) >= 0)
                this.panel1.PaintItems.RemoveAt(this.panel1.PaintItems.Count - 1);
            else
                MessageBox.Show("There is no Unit can delete!", "Oops");
            this.panel1.Refresh();
           
            
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.PaintItems.RemoveAt(this.panel1.PaintItems.Count - 1);
            this.panel1.Refresh();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            unitNameList.Clear();
            straightLineNameList.Clear();
            curveLineNameList.Clear();
            this.panel1.PaintItems.Clear();
            this.panel1.Refresh();
        }

        private void welcomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog(this);
           
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog(this);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            PIDControl pidControl = new PIDControl();
            pidControl.ShowDialog();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            PutItemInList();
            //List<IPaintItem> deleteStraight =new List<IPaintItem>();
            //List<IPaintItem> deleteCurve = new List<IPaintItem>();
            //List<IPaintItem> deleteUnit = new List<IPaintItem>();
            foreach (IPaintItem item in this.panel1.PaintItems)
            {
                if (item.selectStatus)
                {
                    foreach (IPaintItem sLine in this.panel1.PaintItems)
                    {
                        if (sLine is DrawLine)
                        {
                            if (((DrawLine)sLine).EndPoint.itemLocation == item.itemLocation)
                            {
                                this.panel1.PaintItems.Remove(sLine);
                                this.panel1.Refresh();
                                break;
                            }
                        }
                        
                            
                    }
                    foreach (IPaintItem sLine in this.panel1.PaintItems)
                    {
                        if (sLine is DrawLine)
                        {
                            if (((DrawLine)sLine).StartPoint.itemLocation == item.itemLocation)
                            {
                                this.panel1.PaintItems.Remove(sLine);
                                this.panel1.Refresh();
                                break;
                            }
                        }


                    }


                    foreach (IPaintItem cLine in this.panel1.PaintItems)
                    {
                        if (cLine is CallBackLine)
                        {
                            if (((CallBackLine)cLine).EndPoint.itemLocation == item.itemLocation)
                            {
                                this.panel1.PaintItems.Remove(cLine);
                                this.panel1.Refresh();
                                break;
                            }
                        }


                    }
                    foreach (IPaintItem cLine in this.panel1.PaintItems)
                    {
                        if (cLine is CallBackLine)
                        {
                            if (((CallBackLine)cLine).StartPoint.itemLocation == item.itemLocation)
                            {
                                this.panel1.PaintItems.Remove(cLine);
                                this.panel1.Refresh();
                                break;
                            }
                        }


                    }
                    this.panel1.PaintItems.Remove(item);
                    break;
                }
            }
            //deleteStraight.Clear();
            //deleteCurve.Clear();
            //deleteUnit.Clear();
            this.panel1.Refresh();
            PutItemInList();
            
        }

        private void CanMessage_Click(object sender, EventArgs e)
        {
            CanMessage can = new CanMessage();
            can.ShowDialog();
        }

        private void NaiadIDE_Load(object sender, EventArgs e)
        {

        }
        //string pattern = @"^(d{1,2}|1dd|2[0-4]d|25[0-5]).(d{1,2}|1dd|2[0-4]d|25[0-5]).(d{1,2}|1dd|2[0-4]d|25[0-5]).(d{1,2}|1dd|2[0-4]d|25[0-5])$";
        
        ////string ipAddress = textbox1.Text;
        //public void IPcheck()
        //{
        //    string ipAddress = textBox1.Text;
        //     Match m = Regex.Match(ipAddress, pattern);
        //     if (!m.Success)
        //     {
        //         MessageBox.Show("This is not a valid IP address", "oops");
        //     }
        //    // return m.Success;
        //}
        //private void textBox1_TextChanged(object sender, EventArgs e)
        //{
        //    bool M = IPcheck();
        //    if (!M)
        //    {

        //        this.textBox1.Text.Remove(0, this.textBox1.Text.Count() - 1);
        //        MessageBox.Show("This is not a valid IP address", "oops");
        //    }
        //}
        //string nPattern = @"^[0-9]{3,}$";
        
        //private void textBox2_TextChanged(object sender, EventArgs e)
        //{
        //   string portNumber = textBox2.Text;
        //    Match mm = Regex.Match(portNumber, nPattern);
        //    if (!mm.Success)
        //    {
        //        MessageBox.Show("This is not a valid Port Number", "oops");
        //        this.textBox1.Text.Remove(0, this.textBox1.Text.Count() - 1);
        //    }
        //}

    }
}
