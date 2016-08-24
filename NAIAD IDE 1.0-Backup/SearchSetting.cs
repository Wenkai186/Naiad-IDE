using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace NAIADIDE
{
    public partial class SearchSetting : Form
    {
        string w_searchProperty;
        public string searchProperty
        {
            get { return w_searchProperty; }
            set { w_searchProperty = value; }
        }
       // string wstr;
        //JObject searchProperty = new JObject();
        public SearchSetting()
        {
            InitializeComponent();
        }

        private void bYes_Click(object sender, EventArgs e)
        {
          
            string searchs  ="";
           // w_searchProperty = new JObject();
            switch (comboBox.SelectedItem.ToString())
            { 
                case "Search Light":
                    searchs = searchs + comboBox.SelectedItem;
                    break;
                case "Search Door":
                    searchs = searchs + comboBox.SelectedItem;
                    break;
                case "Search Toy":
                    searchs = searchs + comboBox.SelectedItem;
                    break;
                case "Search Fish":
                    searchs = searchs + comboBox.SelectedItem;
                    break;
            }
            //if (comboBox.SelectedItem.ToString() == "Search Light")
            //    searchs = searchs + comboBox.SelectedItem;
            //if (comboBox.SelectedItem.ToString() == "Search Door")
            //    searchs = searchs + comboBox.SelectedItem;
            //if (comboBox.SelectedItem.ToString() == "Search Toy")
            //    searchs = searchs + comboBox.SelectedItem;
            //if (comboBox.SelectedItem.ToString() == "Search Fish")
            //    searchs = searchs + comboBox.SelectedItem;
            w_searchProperty = searchs;
            //w_searchProperty.Add("Search", searchs);
            
           // return searchProperty.ToString();
           // w_str = searchProperty.ToString();
            
            
        }

       

    }
}
