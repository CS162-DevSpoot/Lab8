/**
* Description of the project.
*
* @author Nathaniel A Rivera
* @version CS162 Lab 8, 05/31/2024
*
*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Ch14_Lab8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<StoreData> Data = new List<StoreData>();
        private List<StoreData> searchData = new List<StoreData>();

        public void form_OnLoad(object sender, EventArgs e)
        {
            try
            {
                StreamReader csvFile = File.OpenText("DJIA.csv");

                while (!csvFile.EndOfStream)
                {
                    string[] dataTokens = csvFile.ReadLine().Split(',');
                    var date = DateTime.Parse(dataTokens[0]);
                    var closingVal = decimal.Parse(dataTokens[1]);
                    var openingVal = decimal.Parse(dataTokens[2]);
                    var highVal = decimal.Parse(dataTokens[3]);
                    var lowVal = decimal.Parse(dataTokens[4]);

                    StoreData newEntry = new StoreData(date, closingVal, openingVal, highVal, lowVal);
                    Data.Add(newEntry);
                    date_ListBox.Items.Add(date.ToString("MM/dd/yy"));
                }
            }catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void exit_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void date_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
