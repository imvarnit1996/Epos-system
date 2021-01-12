using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Assignment5
{
    public partial class Form1 : Form
    {
        readonly string[] commodities = new string[] {
            "Shirt",
            "Jeans",
            "T-shirt",
            "Trousers",
            "Skirt ",
            "Vest",
            "Shorts",
            "Jackets",
            "SweatShirts",
            "Sportswear",
            "Sweaters",
            "Jersies",
            "Towels",
            "Kitchen Napkins",
            "Blankets",
            "Curtains" };

        readonly string[] sizes = new string[] {
            "Small",
            "Medium",
            "Regular",
            "Large",
            "Extra Large" };

        readonly decimal[,] price = {{3.45m, 3.50m,  3.55m,  3.38m,  6.83m,  3.4m,   4.49m,  4.05m,  5.5m,   8.5m,   4.25m,  4.5m,  5.36m,   6.0m,   3.23m,  4.45m},
                               {2.95m,  3.0m,   3.05m,  2.99m,  5.69m,  2.9m,   3.99m,  3.12m,  4.49m,  8.89m,  3.75m,  3.97m,  5.0m,   5.5m,   2.23m,  3.95m},
                               {3.45m,  3.5m,   3.55m,  3.38m,  6.83m,  3.4m,   4.49m,  4.05m,  5.5m,   8.5m,   4.25m,  4.5m,   5.36m,  6.0m,   3.23m,  4.45m},
                               {3.99m,  3.99m,  4.0m,   3.99m,  6.99m,  3.59m,  4.99m,  4.49m,  6.51m,  8.11m,  4.75m,  5.03m,  5.72m,  6.5m,   4.23m,  4.95m},
                               {4.53m,  4.48m,  4.45m,  4.6m,   9.99m,  3.78m,  5.49m,  4.93m,  7.52m,  7.72m,  5.25m,  5.56m,  6.08m,  7.0m,   5.23m,  5.45m}};

        readonly int[,] stock = {{2,  4,  6,  8,  12, 12, 8,  4,  0,  3,  6,  9,  12, 10, 55, 6},
                                 {3,  4,  5,  6,  45, 8,  5,  2,  7,  8,  9,  10, 11, 7,  3,  5},
                                 {4,  7,  10, 13, 34, 19, 12, 5,  4,  6,  8,  10, 12, 8,  4,  0},
                                 {5,  13, 11, 12, 23, 12, 4,  7,  10, 8,  6,  4,  21, 4,  6,  8},
                                 {6,  2,  0,  2,  4,  6,  3,  4,  5,  6,  7,  8,  9,  6,  23, 8}};

        int commoditiesIndex, sizeIndex, quantity, totalCommodities, totalNoTrans;
        decimal totalPrice, collectivePrice, totalSaleValue;
        string receipt, time_OrderId;
        bool count = true;

        int[,] tempStock = new int[5, 16];
        int[,] closingStock = new int[5, 16];


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
            try
            {
                //read the stock form the closing stock
                String input = File.ReadAllText(@"Closing Stock.txt");
                
                int i = 0,j = 0;
                foreach (var row in input.Split('\n'))
                {
                    j = 0;
                    foreach (var col in row.Trim().Split(','))
                    {
                        stock[i, j] = int.Parse(col.Trim());
                        j++;
                    }
                    i++;
                }

                // read the price from the text file
                String loadPrice = File.ReadAllText("Prices.txt");

                int k = 0,l = 0;
                foreach (var row in loadPrice.Split('\n'))
                {
                    l = 0;
                    foreach (var col in row.Trim().Split(','))
                    {
                        price[k, l] = int.Parse(col.Trim());
                        l++;
                    }
                    k++;
                }
            }
            catch { }
            panel2.Visible = false;
            proceedButton.Enabled = false;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            commoditiesIndex = commoditiesListBox.SelectedIndex;
            sizeIndex = sizeListBox.SelectedIndex;

            if (commoditiesIndex == -1)
            {
                MessageBox.Show("please select a commodity");

            }
            else if (sizeIndex == -1)
            {
                MessageBox.Show("please select a size");

            }
            else
            {
                if (int.TryParse(quantityNumericUpDown.Text, out quantity) && quantity != 0)
                {
                    try
                    {
                        if (count)
                        {
                            // Clone the value only the first time 
                            tempStock = stock.Clone() as int[,];
                        }

                        if (quantity <= tempStock[sizeIndex, commoditiesIndex])
                        {

                            collectivePrice = (price[sizeIndex, commoditiesIndex] * quantity);
                            dataGridView1.Rows.Add(commodities[commoditiesIndex], sizes[sizeIndex], quantityNumericUpDown.Text, price[sizeIndex, commoditiesIndex], collectivePrice);
                            tempStock[sizeIndex, commoditiesIndex] -= quantity;

                            count = false; // clone is stopped by the flag

                            quantityNumericUpDown.Text = "0";
                            proceedButton.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("There is only " + tempStock[sizeIndex, commoditiesIndex] + " available");
                            quantityNumericUpDown.Focus();
                            quantityNumericUpDown.Text = tempStock[sizeIndex, commoditiesIndex].ToString();
                        }
                    }
                    catch { }

                }
                else
                {
                    MessageBox.Show("Please enter the valid input");
                }
            }
        }

        public void priceChangeDetection(string sender)
        {

            commoditiesIndex = commoditiesListBox.SelectedIndex;
            sizeIndex = sizeListBox.SelectedIndex;

            if (commoditiesIndex >= 0 && sizeIndex >= 0)
            {

                priceTextBox.Text = price[sizeIndex, commoditiesIndex].ToString();
                collectivePriceTextBox.Text = ((price[sizeIndex, commoditiesIndex]) * quantityNumericUpDown.Value).ToString();

            }
        }

        private void commoditiesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            quantityNumericUpDown.Text = "0";
            priceChangeDetection((sender as ListBox).Name);
        }

        private void sizeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            quantityNumericUpDown.Text = "0";
            priceChangeDetection((sender as ListBox).Name);
        }
        private void quantityNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

            priceChangeDetection((sender as NumericUpDown).Name);
        }

        private void proceedButton_Click(object sender, EventArgs e)
        {
            try
            {
                //add the all the collective values
                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {
                    totalPrice += Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value.ToString());
                }
                totalPriceLabel.Text = totalPrice.ToString();
            }
            catch { }
            panel1.Visible = false;
            panel2.Visible = true;
            proceedButton.Enabled = false;
            newButton.Enabled = false;
            deleteItem.Enabled = false;
            completeOrderButton.Focus();
            completeOrderButton.Enabled = true;
            CancelOrder.Enabled = true;

        }
        private void deleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                // delete the row and add the quantity back to the Tempstock
                var rowindex = dataGridView1.CurrentCell.RowIndex;

                if (dataGridView1.Rows.Count > 1 && dataGridView1.Rows[rowindex].Cells[0].Value != null)
                {
                    tempStock[sizeIndex, commoditiesIndex] += Convert.ToInt32(dataGridView1.Rows[rowindex].Cells[2].Value.ToString());
                    dataGridView1.Rows.RemoveAt(rowindex);

                    if (rowindex == 0)
                    {
                        collectivePriceTextBox.Text = "0";
                        priceTextBox.Text = "0";
                        proceedButton.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("Select a non empty row");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception message" + ex.Message);
                MessageBox.Show("Select a non empty row");
            }
        }

        // complete the traction and clone the tempstock to the closing stock
        private void completeOrderButton_Click(object sender, EventArgs e)
        {

            int dgvRowIndex = dataGridView1.RowCount;
            time_OrderId = "Order ID: " + DateTime.Now.ToString("yyMMddHHmmss") 
                         + " Date: " + DateTime.Now.ToString("dd-MM-yyyy") 
                         + " Time: " + DateTime.Now.ToString("hh:mm:ss");
            try
            {
                for (int i = 0; i < dgvRowIndex - 1; i++)
                {
                    receipt += (Environment.NewLine + "Item: " + dataGridView1.Rows[i].Cells[0].Value.ToString() + " size: " + dataGridView1.Rows[i].Cells[1].Value.ToString() + " Quantiy: " + dataGridView1.Rows[i].Cells[2].Value.ToString() + " Individual Price: " + dataGridView1.Rows[i].Cells[3].Value.ToString() + " Collective price: " + dataGridView1.Rows[i].Cells[4].Value.ToString()).ToString();
                    totalCommodities += Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value.ToString());

                }

                MessageBox.Show("Order sucessfull" + Environment.NewLine + time_OrderId + receipt);

            }
            catch { }

            totalNoTrans += 1; //for summary
            completeOrderButton.Enabled = false;
            totalSaleValue += totalPrice;
            newButton.Enabled = true;
            CancelOrder.Enabled = false;
            clearButton.Enabled = false;
            collectivePriceTextBox.Text = "";
            priceTextBox.Text = "";
            closingStock = tempStock.Clone() as int[,]; // clone for the live stock

            var fileName = @"Orders.txt";
            StreamWriter TR;
            TR = File.AppendText(fileName);
            TR.WriteLine(Environment.NewLine + time_OrderId + receipt + ";");
            TR.Flush();
            TR.Close();

        }

        // for clearing fields on new cancel and no button
        public void ClearFields()
        {
            commoditiesListBox.Text = "";
            sizeListBox.Text = "";
            quantityNumericUpDown.Text = "0";
            dataGridView1.Rows.Clear();
            Items.Visible = true;
            collectivePriceTextBox.Text = "";
            priceTextBox.Text = "";
            commoditiesListBox.Focus();
            receipt = "";
            completeOrderButton.Enabled = true;
            CancelOrder.Enabled = true;
            totalPriceLabel.Text = "";
            deleteItem.Enabled = true;
            proceedButton.Enabled = false;
            clearButton.Enabled = true;
            panel1.Visible = true;
            totalPrice = 0;
            panel2.Visible = false;
        }

        // For new Order
        private void newButton_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void cancelButton_Click_1(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void exit_Button_Click(object sender, EventArgs e)
        {
            if (receipt == null || receipt == "")
            {
                this.Close();

            }
            else
            {
                DialogResult exit = MessageBox.Show("ARE YOU SURE YOU WANT TO EXIT(THIS END THE ORDER FOR THE DAY)", "WARNING", MessageBoxButtons.YesNo);
                if (exit == DialogResult.Yes)
                {
                    try
                    {
                        //write the closing stock to file so it can load the for the next day
                        StreamWriter FS = new StreamWriter(@"Closing Stock.txt");

                        for (int i = 0; i < sizes.Length; i++)
                        {
                            for (int j = 0; j < commodities.Length; j++)
                            {
                                if (j != 15) FS.Write(closingStock[i, j] + ",");
                                if (j == 15) FS.Write(closingStock[i, j]);
                            }
                            FS.WriteLine();
                        }
                        FS.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Exception \n" + ex);
                    }
                    this.Close();
                }
                else if (exit == DialogResult.No)
                {
                    ClearFields();
                }
            }
        }

        // summar of daily sales
        private void summary_Button_Click(object sender, EventArgs e)
        {
            summaryTabPage.Visible = true;
            try
            {
                totalCommoditiesLabel.Text = totalCommodities.ToString();
                totalSaleValueLabel.Text = totalSaleValue.ToString();
                totalNoTransLable.Text = totalNoTrans.ToString();
                decimal average = (totalSaleValue / totalNoTrans);
                averageLable.Text = average.ToString();
            }
            catch { }

        }

        //clears and ready for the new Order
        private void clearButton_Click(object sender, EventArgs e)
        {
            commoditiesListBox.Text = "";
            sizeListBox.Text = "";
            quantityNumericUpDown.Text = "0";
            dataGridView1.Rows.Clear();
            Items.Visible = true;
            commoditiesListBox.Focus();
            deleteItem.Enabled = true;
            panel1.Visible = true;
            totalPriceLabel.Text = "";
            panel2.Visible = false;
            collectivePriceTextBox.Text = "";
            priceTextBox.Text = "";
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string search_text = searchTextBox.Text.Trim();

            if (search_text != "" && search_text.Length == 12)
            {

                String input = File.ReadAllText(@"Orders.txt");
                string[] orders = input.Split(';');

                foreach (string order in orders)
                {
                    if (order.Contains(search_text))
                    {
                        searchResultLabel.Text = order.Trim().Trim(); ;
                        return;
                    }
                }
                searchResultLabel.Text = "Cannot find anything";
            }
            else
            {
                searchResultLabel.Text = "Cannot find anything";
            }
        }

        //Empty methods
        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void totalCommoditiesLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void priceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchResultLabel_Click(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_Click(object sender, EventArgs e)
        {

        }

        private void averageLable_Click(object sender, EventArgs e)
        {

        }

        private void totalNoTransLable_Click(object sender, EventArgs e)
        {

        }

        private void totalSaleValueLabel_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void totalPriceLabel_Click(object sender, EventArgs e)
        {

        }

        private void CollectivePriceLabel_Click(object sender, EventArgs e)
        {

        }

        private void collectivePriceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void HeadSearhLabel_Click(object sender, EventArgs e)
        {

        }

        private void SearchLabel_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void BottomToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void RightToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void LeftToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void summaryTabPage_Click(object sender, EventArgs e) { }

        private void searchTabPage_Click(object sender, EventArgs e)
        {

        }

    }
}