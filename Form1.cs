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
        private List<StoreData> copyData = new List<StoreData>();

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
                    copyData.Add(newEntry);
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

        bool debounce = false;
        private void date_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexSelected = date_ListBox.SelectedIndex;
            StoreData selectedData = Data[indexSelected];
            loadData(selectedData);
        }

        private void cloestDate_Button_Click(object sender, EventArgs e)
        {
            if (debounce) { return; }
            try
            {
                decimal enteredValue = decimal.Parse(value_TextBox.Text);
                var dataFound = Data.Find(item => item.ClosingValue >= enteredValue);
                if(dataFound == null) { MessageBox.Show("No Data Found."); return; }
                loadData(dataFound);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void allDates_Button_Click(object sender, EventArgs e)
        {
            try
            {
                decimal enteredValue = decimal.Parse(value_TextBox.Text);
                var dataFound = Data.FindAll(item => item.ClosingValue >= enteredValue);
                if (dataFound == null) { MessageBox.Show("No Data Found."); return; }
                Data = dataFound;

                debounce = true;
                date_ListBox.Items.Clear();
                Data.ForEach(item => date_ListBox.Items.Add(item.Date.ToString("MM/dd/yyyy")));
                debounce = false;
                

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void loadData(StoreData dataToLoad)
        {
            opening_Label.Text = dataToLoad.OpeningValue.ToString("c");
            closing_Label.Text = dataToLoad.ClosingValue.ToString("c");
            high_Label.Text = dataToLoad.HighValue.ToString("c");
            low_Label.Text = dataToLoad.LowValue.ToString("c");
            date_Label.Text = dataToLoad.Date.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            debounce = true;
            date_ListBox.Items.Clear();
            Data = copyData;

            Data.ForEach(item => date_ListBox.Items.Add(item.Date.ToString("MM/dd/yyyy")));
            debounce = false;
        }
    }
}
