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

namespace Assignment4
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

        int commodities_index, size_index, quantity, total_commodities, total_number_of_transactions;
        decimal total_price, collective_price, total_sales_value;
        string receipt, time_date_orderId;
        bool count = true;

        int[,] temp_stock = new int[5, 16];
        int[,] closing_stock = new int[5, 16];


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
                        stock[j, j] = int.Parse(col.Trim());
                        j++;
                    }
                    j++;
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

        private void AddButton_Click(object sender, EventArgs e)
        {
            commodities_index = commoditiesListBox.SelectedIndex;
            size_index = sizeListBox.SelectedIndex;

            if (commodities_index == -1)
            {
                MessageBox.Show("please select a commodity");
            }
            else if (size_index == -1)
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
                            temp_stock = stock.Clone() as int[,];
                        }

                        if (quantity <= temp_stock[size_index, commodities_index])
                        {

                            collective_price = (price[size_index, commodities_index] * quantity);
                            dataGridView1.Rows.Add(commodities[commodities_index], sizes[size_index], quantityNumericUpDown.Text, price[size_index, commodities_index], collective_price);
                            temp_stock[size_index, commodities_index] -= quantity;

                            count = false; // clone is stopped by the flag

                            quantityNumericUpDown.Text = "0";
                            proceedButton.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("There is only " + temp_stock[size_index, commodities_index] + " available");
                            quantityNumericUpDown.Focus();
                            quantityNumericUpDown.Text = temp_stock[size_index, commodities_index].ToString();
                        }
                    }
                    catch { }

                }
                else
                {
                    MessageBox.Show("Please enter the valid quantity");
                }
            }
        }

        public void PriceChangeDetection(string sender)
        {

            commodities_index = commoditiesListBox.SelectedIndex;
            size_index = sizeListBox.SelectedIndex;

            if (commodities_index >= 0 && size_index >= 0)
            {
                priceTextBox.Text = price[size_index, commodities_index].ToString();
                collectivePriceTextBox.Text = ((price[size_index, commodities_index]) * quantityNumericUpDown.Value).ToString();
            }
        }

        private void commoditiesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            quantityNumericUpDown.Text = "0";
            PriceChangeDetection((sender as ListBox).Name);
        }

        private void sizeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            quantityNumericUpDown.Text = "0";
            PriceChangeDetection((sender as ListBox).Name);
        }
        private void quantityNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

            PriceChangeDetection((sender as NumericUpDown).Name);
        }

        private void ProceedButton_Click(object sender, EventArgs e)
        {
            try
            {
                //add the all the collective values
                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {
                    total_price += Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value.ToString());
                }
                totalPriceLabel.Text = total_price.ToString();
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
        private void DeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                // delete the row and add the quantity back to the Tempstock
                var row_index = dataGridView1.CurrentCell.RowIndex;

                if (dataGridView1.Rows.Count > 1 && dataGridView1.Rows[row_index].Cells[0].Value != null)
                {
                    temp_stock[size_index, commodities_index] += Convert.ToInt32(dataGridView1.Rows[row_index].Cells[2].Value.ToString());
                    dataGridView1.Rows.RemoveAt(row_index);

                    if (row_index == 0)
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
        private void CompleteOrderButton_Click(object sender, EventArgs e)
        {

            time_date_orderId = "Order ID: " + DateTime.Now.ToString("yyMMddHHmmss") 
                         + " Date: " + DateTime.Now.ToString("dd-MM-yyyy") 
                         + " Time: " + DateTime.Now.ToString("hh:mm:ss");
            try
            {
                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {
                    receipt += (Environment.NewLine + "Item: " + dataGridView1.Rows[i].Cells[0].Value.ToString() + " size: " + dataGridView1.Rows[i].Cells[1].Value.ToString() + " Quantiy: " + dataGridView1.Rows[i].Cells[2].Value.ToString() + " Individual Price: " + dataGridView1.Rows[i].Cells[3].Value.ToString() + " Collective price: " + dataGridView1.Rows[i].Cells[4].Value.ToString()).ToString();
                    total_commodities += Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value.ToString());

                }

                MessageBox.Show("Order sucessfull" + Environment.NewLine + time_date_orderId + receipt);

            }
            catch { }

            total_number_of_transactions += 1; //for summary
            total_sales_value += total_price;
            completeOrderButton.Enabled = false;
            newButton.Enabled = true;
            CancelOrder.Enabled = false;
            clearButton.Enabled = false;
            collectivePriceTextBox.Text = "";
            priceTextBox.Text = "";
            closing_stock = temp_stock.Clone() as int[,]; // clone for the live stock

            var fileName = @"Orders.txt";
            StreamWriter TR;
            TR = File.AppendText(fileName);
            TR.WriteLine(Environment.NewLine + time_date_orderId + receipt + ";");
            TR.Flush();
            TR.Close();

        }

        // for clearing fields on new cancel and no button
        public void ClearFields()
        {
            commoditiesListBox.SelectedIndex = -1;
            sizeListBox.SelectedIndex = -1;
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
            total_price = 0;
            panel2.Visible = false;

        }

        // For placing the new Order
        private void NewButton_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        //Cancelling the correntorder
        private void CancelButton_Click_1(object sender, EventArgs e)
        {
            ClearFields();
        }

        //exit the application and updating stock in ClosingStock.txt file
        private void Exit_Button_Click(object sender, EventArgs e)
        {
            if (receipt == null)
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
                                if (j != 15) FS.Write(closing_stock[j, j] + ",");
                                if (j == 15) FS.Write(closing_stock[j, j]);
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
        private void Summary_Button_Click(object sender, EventArgs e)
        {
    
            try
            {
                totalCommoditiesLabel.Text = total_commodities.ToString();
                totalSaleValueLabel.Text = total_sales_value.ToString();
                totalNoTransLable.Text = total_number_of_transactions.ToString();
                decimal average = (total_sales_value / total_number_of_transactions);
                averageLable.Text = average.ToString();
            }
            catch { }

        }

        //clears the filed for new cart elemets
        private void ClearButton_Click(object sender, EventArgs e)
        {
            commoditiesListBox.SelectedIndex = -1;
            sizeListBox.SelectedIndex = -1;
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

        private void SearchButton_Click(object sender, EventArgs e)
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
                        searchResultLabel.Text = order.Trim();
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

        private void button1_Click_1(object sender, EventArgs e)
        {



            try
            {
                //write the closing stock to file so it can load the for the next day
                StreamWriter FS = new StreamWriter(@"Management Report.txt");

                for (int i = 0; i < sizes.Length; i++)
                {
                    FS.Write ("-----------------" + sizes[i]+"-----------------" +"\n");
                    for (int j = 0; j < commodities.Length; j++)
                    {
                        
                        
                       FS.Write("Item: " + commodities[j]  +"   "+ "Stock available: " + closing_stock[i, j] + Environment.NewLine);
                       
                    }
                    FS.WriteLine();
                }

                MessageBox.Show("Saved to Management report.txt ");
            FS.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception \n" + ex);
            }


        }


        //Empty methods
        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void ToolStripButton1_Click(object sender, EventArgs e)
        {

        }
        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void TotalCommoditiesLabel_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label9_Click_1(object sender, EventArgs e)
        {

        }

        private void Label10_Click(object sender, EventArgs e)
        {

        }

        private void PriceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchResultLabel_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripContainer1_Click(object sender, EventArgs e)
        {

        }

        private void AverageLable_Click(object sender, EventArgs e)
        {

        }

        private void TotalNoTransLable_Click(object sender, EventArgs e)
        {

        }

        private void TotalSaleValueLabel_Click(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TotalPriceLabel_Click(object sender, EventArgs e)
        {

        }

        private void CollectivePriceLabel_Click(object sender, EventArgs e)
        {

        }

        private void CollectivePriceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void HeadSearhLabel_Click(object sender, EventArgs e)
        {

        }

        private void SearchLabel_Click(object sender, EventArgs e)
        {

        }

        private void ToolTip1_Popup(object sender, PopupEventArgs e)
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

        private void Label10_Click_1(object sender, EventArgs e)
        {

        }

       

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
        private void SummaryTabPage_Click(object sender, EventArgs e) {
            
        }

        private void SearchTabPage_Click(object sender, EventArgs e)
        {
			
        }

    }
}