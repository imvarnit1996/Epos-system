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
        readonly string[] commodities = new string[] { "Shirt",
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


        readonly string[] size = new string[] { "Small", "Medium", "Regular", "Large", "Extra Large" };


        readonly decimal[,] price = {{0.00m, 3.50m,  3.55m,  3.38m,  6.83m,  3.4m,   4.49m,  4.05m,  5.5m,   8.5m,   4.25m,  4.5m,  5.36m,   6.0m,   3.23m,  4.45m},
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
        string receipt, totalReceipt;
        bool count = true;


        int[,] tempStock = new int[5, 16];
        int[,] formatedStock = new int[5, 16];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            try
            {
                //read the stock form the formated stock
                String input = File.ReadAllText("formatedStock.txt");
                //  Console.WriteLine(input);
                int i = 0, j = 0;

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
                String loadPrice = File.ReadAllText("prices.txt");
                Console.WriteLine(loadPrice);

                int k = 0, l = 0;

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

        //add button picks the value from the array and writes to the grid box

        private void addButton_Click(object sender, EventArgs e)
        {
            commoditiesIndex = commoditiesListBox.SelectedIndex;
            sizeIndex = sizeListBox.SelectedIndex;


            if(commoditiesIndex == -1  )
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

                            dataGridView1.Rows.Add(commodities[commoditiesIndex], size[sizeIndex], quantityNumericUpDown.Text, price[sizeIndex, commoditiesIndex], collectivePrice);

                            //stock[sizeIndex, commoditiesIndex] -= quantity;
                            tempStock[sizeIndex, commoditiesIndex] -= quantity;

                            count = false; // clone is stopped by the flag

                            // commoditiesListBox.SelectedIndex = -1;
                            // sizeListBox.SelectedIndex = -1;
                            quantityNumericUpDown.Text = "0";

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
                proceedButton.Enabled = true;
            }
             
           

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
               // Console.WriteLine("row count "+dataGridView1.Rows.Count);
                

                // delete the row and add the quantity back to the Tempstock
             
                 if (dataGridView1.Rows.Count > 1 /*&& dataGridView1.CurrentRow.Index == dataGridView1.Rows.Count*/) 
                {
                    int rowindex = dataGridView1.CurrentCell.RowIndex;
                 //   Console.WriteLine("row index "+rowindex);

                    tempStock[sizeIndex, commoditiesIndex] += Convert.ToInt32(dataGridView1.Rows[rowindex].Cells[2].Value.ToString());
                    dataGridView1.Rows.RemoveAt(rowindex);
                    if (dataGridView1.Rows[0].Index == 0) proceedButton.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Select a non empty row");
                }

            }
            catch
            {
            
            }
        }

        // complete the traction and clone the tempstock to the formated stock
        private void completeOrderButton_Click(object sender, EventArgs e)
        {

            int dgvRowIndex = dataGridView1.RowCount;
            try
            {
               for (int i = 0; i < dgvRowIndex - 1; i++)
                {

                    var myTransactionId = DateTime.Now.ToString("yyyyMMddhhmmss");
                    DateTime dateTime = DateTime.UtcNow.Date;
                    // Console.WriteLine(dateTime.ToString("dd-MM-yyyy"));
                    
                    receipt += ("transaction ID: " + myTransactionId +" Date: "+ DateTime.Now.ToString("dd-MM-yyyy") +" Time: "+ DateTime.Now.ToString("hh:mm:ss") + " Item: " + dataGridView1.Rows[i].Cells[0].Value.ToString() + " size: " + dataGridView1.Rows[i].Cells[1].Value.ToString() + " Quantiy: " + dataGridView1.Rows[i].Cells[2].Value.ToString() + " Individual Price :" + dataGridView1.Rows[i].Cells[3].Value.ToString() + " Collective price :" + dataGridView1.Rows[i].Cells[4].Value.ToString() + "\n").ToString();
                    totalReceipt += (receipt + "\n");
                    Console.WriteLine("total recipet" + totalReceipt);

                    totalCommodities += Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value.ToString());

                    // transcount += 1;

                    // myTransactionId = "0";

                }
                MessageBox.Show("Order sucessfull \n" + receipt);
            }
            catch { }

            //totalCommodities += (dataGridView1.RowCount - 1);
            totalNoTrans += 1; //for summeary
            completeOrderButton.Enabled = false;
            totalSaleValue += totalPrice;
            newButton.Enabled = true;
            CancelOrder.Enabled = false;
            clearButton.Enabled = false;
            formatedStock = tempStock.Clone() as int[,];  // clone for the live stock

        }

        // For new Order
        private void newButton_Click(object sender, EventArgs e)
        {
            commoditiesListBox.Text = "";
            sizeListBox.Text = "";
            quantityNumericUpDown.Text = "";
            dataGridView1.Rows.Clear();
            mealTabPage.Visible = true;

            commoditiesListBox.Focus();
            receipt = "";
            completeOrderButton.Enabled = true;
            CancelOrder.Enabled = true;
            totalPriceLabel.Text = "";
            deleteItem.Enabled = true;

            panel1.Visible = true;
            proceedButton.Enabled = true;
            totalPrice = 0;
            panel2.Visible = false;
        }

        private void cancelButton_Click_1(object sender, EventArgs e)
        {
            commoditiesListBox.Text = "";
            sizeListBox.Text = "";
            quantityNumericUpDown.Text = "";
            dataGridView1.Rows.Clear();
            mealTabPage.Visible = true;

            commoditiesListBox.Focus();
            receipt = "";
            completeOrderButton.Enabled = true;
            totalPriceLabel.Text = "";
            deleteItem.Enabled = true;

            panel1.Visible = true;
            proceedButton.Enabled = true;
            totalPrice = 0;
            panel2.Visible = false;
        }


        private void exit_Button_Click(object sender, EventArgs e)
        {
            if (totalReceipt == null ) this.Close();
            else
            {
                DialogResult exit = MessageBox.Show("ARE YOU SURE YOU WANT TO EXIT(THIS END THE TRANSACTION FOR THE DAY)", "WARNING", MessageBoxButtons.YesNo);
                if (exit == DialogResult.Yes)
                {
                    try
                    {
                        //write the formated stock to file so it can load the for the next day
                        StreamWriter FS = new StreamWriter("formatedStock.txt");

                        for (int i = 0; i < size.Length; i++)
                        {
                            for (int j = 0; j < commodities.Length; j++)
                            {
                                if (j != 15)
                                    FS.Write(formatedStock[i, j] + ",");
                                if (j == 15)
                                    FS.Write(formatedStock[i, j]);
                            }
                            FS.WriteLine();
                        }

                        FS.Close();
                        // summary Transaction 
                        var myUniqueFileName = string.Format("Transactions.txt");
                        StreamWriter TR;
                        TR = File.CreateText(myUniqueFileName);
                        TR.WriteLine("*******************Transaction for the day******************");
                        TR.WriteLine("************************************************************");
                        TR.WriteLine(totalReceipt + "\n");
                        TR.Flush();
                        TR.Close();

                    }
                    catch { }
                    this.Close();
                }
                else if (exit == DialogResult.No)
                {
                    commoditiesListBox.Text = "";
                    sizeListBox.Text = "";
                    quantityNumericUpDown.Text = "";
                    dataGridView1.Rows.Clear();
                    mealTabPage.Visible = true;
                    // completeTabPage.Visible = false;
                    commoditiesListBox.Focus();
                    receipt = "";
                    completeOrderButton.Enabled = true;
                    totalPriceLabel.Text = "";
                    deleteItem.Enabled = true;

                    panel1.Visible = true;
                    proceedButton.Enabled = true;
                    totalPrice = 0;
                    panel2.Visible = false;
                }
            }
           

        }

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

        //clears and ready for the new transaction
        private void clearButton_Click(object sender, EventArgs e)
        {
            commoditiesListBox.Text = "";
            sizeListBox.Text = "";
            quantityNumericUpDown.Text = "";
            dataGridView1.Rows.Clear();
            mealTabPage.Visible = true;
            commoditiesListBox.Focus();
            deleteItem.Enabled = true;
            panel1.Visible = true;
            totalPriceLabel.Text = "";
            panel2.Visible = false;
        }

        private void commoditiesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            proceedButton.Enabled = false;
        }

      

        private void employeeButton_Click(object sender, EventArgs e)
        {
            summaryTabPage.Visible = false;
            mealTabPage.Visible = true;
        }

        //Empty methods
        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void sizeListBox_SelectedIndexChanged(object sender, EventArgs e)
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

        private void quantityNumericUpDown_ValueChanged(object sender, EventArgs e)
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
        private void summaryTabPage_Click(object sender, EventArgs e)
        {
        }


        private void searchTabPage_Click(object sender, EventArgs e)
        {

        }

    }
}
