using System;

namespace Assignment5
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.clearButton = new System.Windows.Forms.Button();
            this.exit_Button = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ragle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summaryTabPage = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.summary_Button = new System.Windows.Forms.Button();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.averageLable = new System.Windows.Forms.Label();
            this.totalNoTransLable = new System.Windows.Forms.Label();
            this.totalSaleValueLabel = new System.Windows.Forms.Label();
            this.totalCommoditiesLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mealTabPage = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CancelOrder = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.completeOrderButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CollectivePriceLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.collectivePriceTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteItem = new System.Windows.Forms.Button();
            this.quantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.proceedButton = new System.Windows.Forms.Button();
            this.sizeListBox = new System.Windows.Forms.ListBox();
            this.commoditiesListBox = new System.Windows.Forms.ListBox();
            this.CommoditiesLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.searchTabPage = new System.Windows.Forms.TabPage();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.summaryTabPage.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.mealTabPage.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(591, 31);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "Clea&r";
            this.toolTip1.SetToolTip(this.clearButton, "click here to clear");
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exit_Button
            // 
            this.exit_Button.Location = new System.Drawing.Point(696, 31);
            this.exit_Button.Name = "exit_Button";
            this.exit_Button.Size = new System.Drawing.Size(75, 23);
            this.exit_Button.TabIndex = 3;
            this.exit_Button.Text = "E&ND";
            this.toolTip1.SetToolTip(this.exit_Button, "click here to end ");
            this.exit_Button.UseVisualStyleBackColor = true;
            this.exit_Button.Click += new System.EventHandler(this.exit_Button_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ragle
            // 
            this.ragle.HeaderText = "Ragle";
            this.ragle.Name = "ragle";
            this.ragle.ReadOnly = true;
            // 
            // summaryTabPage
            // 
            this.summaryTabPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("summaryTabPage.BackgroundImage")));
            this.summaryTabPage.Controls.Add(this.label9);
            this.summaryTabPage.Controls.Add(this.summary_Button);
            this.summaryTabPage.Controls.Add(this.toolStripContainer1);
            this.summaryTabPage.Location = new System.Drawing.Point(4, 22);
            this.summaryTabPage.Name = "summaryTabPage";
            this.summaryTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.summaryTabPage.Size = new System.Drawing.Size(729, 437);
            this.summaryTabPage.TabIndex = 2;
            this.summaryTabPage.Text = "Summary";
            this.summaryTabPage.UseVisualStyleBackColor = true;
            this.summaryTabPage.Click += new System.EventHandler(this.summaryTabPage_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Font = new System.Drawing.Font("Segoe Script", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(289, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 35);
            this.label9.TabIndex = 20;
            this.label9.Text = "Daily Sales";
            this.label9.Click += new System.EventHandler(this.label9_Click_1);
            // 
            // summary_Button
            // 
            this.summary_Button.Location = new System.Drawing.Point(49, 32);
            this.summary_Button.Name = "summary_Button";
            this.summary_Button.Size = new System.Drawing.Size(75, 23);
            this.summary_Button.TabIndex = 19;
            this.summary_Button.Text = "&Summary";
            this.toolTip1.SetToolTip(this.summary_Button, "click here to get the summary");
            this.summary_Button.UseVisualStyleBackColor = true;
            this.summary_Button.Click += new System.EventHandler(this.summary_Button_Click);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.averageLable);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.totalNoTransLable);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.totalSaleValueLabel);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.totalCommoditiesLabel);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.label8);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.label7);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.label6);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.label5);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(614, 238);
            this.toolStripContainer1.ContentPanel.Load += new System.EventHandler(this.toolStripContainer1_ContentPanel_Load);
            this.toolStripContainer1.Location = new System.Drawing.Point(59, 117);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(614, 263);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStripContainer1.TopToolStripPanel.Click += new System.EventHandler(this.toolStripContainer1_TopToolStripPanel_Click);
            // 
            // averageLable
            // 
            this.averageLable.BackColor = System.Drawing.Color.DarkGray;
            this.averageLable.Location = new System.Drawing.Point(289, 141);
            this.averageLable.Name = "averageLable";
            this.averageLable.Size = new System.Drawing.Size(122, 24);
            this.averageLable.TabIndex = 7;
            // 
            // totalNoTransLable
            // 
            this.totalNoTransLable.BackColor = System.Drawing.Color.DarkGray;
            this.totalNoTransLable.ForeColor = System.Drawing.Color.Black;
            this.totalNoTransLable.Location = new System.Drawing.Point(289, 106);
            this.totalNoTransLable.Name = "totalNoTransLable";
            this.totalNoTransLable.Size = new System.Drawing.Size(122, 27);
            this.totalNoTransLable.TabIndex = 6;
            // 
            // totalSaleValueLabel
            // 
            this.totalSaleValueLabel.BackColor = System.Drawing.Color.DarkGray;
            this.totalSaleValueLabel.Location = new System.Drawing.Point(289, 63);
            this.totalSaleValueLabel.Name = "totalSaleValueLabel";
            this.totalSaleValueLabel.Size = new System.Drawing.Size(122, 28);
            this.totalSaleValueLabel.TabIndex = 5;
            // 
            // totalCommoditiesLabel
            // 
            this.totalCommoditiesLabel.BackColor = System.Drawing.Color.Silver;
            this.totalCommoditiesLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.totalCommoditiesLabel.Location = new System.Drawing.Point(289, 18);
            this.totalCommoditiesLabel.Name = "totalCommoditiesLabel";
            this.totalCommoditiesLabel.Size = new System.Drawing.Size(122, 28);
            this.totalCommoditiesLabel.TabIndex = 4;
            this.totalCommoditiesLabel.Click += new System.EventHandler(this.totalCommoditiesLabel_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(92, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = " Average sales: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(49, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(197, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Total number of transactions :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(103, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Total sales : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Number of commoditiess sold: ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // mealTabPage
            // 
            this.mealTabPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mealTabPage.BackgroundImage")));
            this.mealTabPage.Controls.Add(this.panel2);
            this.mealTabPage.Controls.Add(this.panel1);
            this.mealTabPage.Location = new System.Drawing.Point(4, 22);
            this.mealTabPage.Name = "mealTabPage";
            this.mealTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.mealTabPage.Size = new System.Drawing.Size(729, 437);
            this.mealTabPage.TabIndex = 0;
            this.mealTabPage.Text = "Meal Plan";
            this.mealTabPage.UseVisualStyleBackColor = true;
            this.mealTabPage.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.CancelOrder);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.completeOrderButton);
            this.panel2.Controls.Add(this.newButton);
            this.panel2.Controls.Add(this.totalPriceLabel);
            this.panel2.Location = new System.Drawing.Point(85, 315);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(543, 100);
            this.panel2.TabIndex = 23;
            // 
            // CancelOrder
            // 
            this.CancelOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelOrder.Location = new System.Drawing.Point(248, 52);
            this.CancelOrder.Name = "CancelOrder";
            this.CancelOrder.Size = new System.Drawing.Size(109, 23);
            this.CancelOrder.TabIndex = 4;
            this.CancelOrder.Text = "Cancel Order";
            this.toolTip1.SetToolTip(this.CancelOrder, "Click here to cancel order");
            this.CancelOrder.UseVisualStyleBackColor = true;
            this.CancelOrder.Click += new System.EventHandler(this.cancelButton_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Total Price : ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // completeOrderButton
            // 
            this.completeOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.completeOrderButton.Location = new System.Drawing.Point(248, 23);
            this.completeOrderButton.Name = "completeOrderButton";
            this.completeOrderButton.Size = new System.Drawing.Size(109, 23);
            this.completeOrderButton.TabIndex = 18;
            this.completeOrderButton.Text = "&Complete Order";
            this.toolTip1.SetToolTip(this.completeOrderButton, "click here for confirm");
            this.completeOrderButton.UseVisualStyleBackColor = true;
            this.completeOrderButton.Click += new System.EventHandler(this.completeOrderButton_Click);
            // 
            // newButton
            // 
            this.newButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newButton.Location = new System.Drawing.Point(389, 23);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(111, 52);
            this.newButton.TabIndex = 21;
            this.newButton.Text = "&New Order";
            this.toolTip1.SetToolTip(this.newButton, "Click here to new order");
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.BackColor = System.Drawing.Color.White;
            this.totalPriceLabel.Location = new System.Drawing.Point(83, 28);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(130, 25);
            this.totalPriceLabel.TabIndex = 20;
            this.totalPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CollectivePriceLabel);
            this.panel1.Controls.Add(this.priceLabel);
            this.panel1.Controls.Add(this.collectivePriceTextBox);
            this.panel1.Controls.Add(this.priceTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.deleteItem);
            this.panel1.Controls.Add(this.quantityNumericUpDown);
            this.panel1.Controls.Add(this.proceedButton);
            this.panel1.Controls.Add(this.sizeListBox);
            this.panel1.Controls.Add(this.commoditiesListBox);
            this.panel1.Controls.Add(this.CommoditiesLabel);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(6, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(717, 307);
            this.panel1.TabIndex = 22;
            this.toolTip1.SetToolTip(this.panel1, "click here get the total");
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // CollectivePriceLabel
            // 
            this.CollectivePriceLabel.AutoSize = true;
            this.CollectivePriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CollectivePriceLabel.Location = new System.Drawing.Point(451, 114);
            this.CollectivePriceLabel.Name = "CollectivePriceLabel";
            this.CollectivePriceLabel.Size = new System.Drawing.Size(112, 17);
            this.CollectivePriceLabel.TabIndex = 20;
            this.CollectivePriceLabel.Text = "Collective Price :";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(205, 114);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(101, 17);
            this.priceLabel.TabIndex = 19;
            this.priceLabel.Text = "Price for one : ";
            this.priceLabel.Click += new System.EventHandler(this.label10_Click);
            // 
            // collectivePriceTextBox
            // 
            this.collectivePriceTextBox.Location = new System.Drawing.Point(566, 113);
            this.collectivePriceTextBox.Name = "collectivePriceTextBox";
            this.collectivePriceTextBox.ReadOnly = true;
            this.collectivePriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.collectivePriceTextBox.TabIndex = 18;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(312, 113);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.ReadOnly = true;
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 17;
            this.priceTextBox.TextChanged += new System.EventHandler(this.priceTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Available";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // deleteItem
            // 
            this.deleteItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteItem.Location = new System.Drawing.Point(491, 51);
            this.deleteItem.Name = "deleteItem";
            this.deleteItem.Size = new System.Drawing.Size(64, 23);
            this.deleteItem.TabIndex = 12;
            this.deleteItem.Text = "DELETE";
            this.toolTip1.SetToolTip(this.deleteItem, "click here to delete the item in the row");
            this.deleteItem.UseVisualStyleBackColor = true;
            this.deleteItem.Click += new System.EventHandler(this.deleteItem_Click);
            // 
            // quantityNumericUpDown
            // 
            this.quantityNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityNumericUpDown.Location = new System.Drawing.Point(398, 36);
            this.quantityNumericUpDown.Name = "quantityNumericUpDown";
            this.quantityNumericUpDown.Size = new System.Drawing.Size(49, 21);
            this.quantityNumericUpDown.TabIndex = 15;
            this.quantityNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.quantityNumericUpDown.ValueChanged += new System.EventHandler(this.quantityNumericUpDown_ValueChanged);
            // 
            // proceedButton
            // 
            this.proceedButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proceedButton.Location = new System.Drawing.Point(576, 24);
            this.proceedButton.Name = "proceedButton";
            this.proceedButton.Size = new System.Drawing.Size(116, 45);
            this.proceedButton.TabIndex = 3;
            this.proceedButton.Text = "Proceed with the selected items";
            this.toolTip1.SetToolTip(this.proceedButton, "click here to get the total");
            this.proceedButton.UseVisualStyleBackColor = true;
            this.proceedButton.Click += new System.EventHandler(this.proceedButton_Click);
            // 
            // sizeListBox
            // 
            this.sizeListBox.FormattingEnabled = true;
            this.sizeListBox.Items.AddRange(new object[] {
            "Small ",
            "Medium",
            "Regular",
            "Large",
            "Extra Large"});
            this.sizeListBox.Location = new System.Drawing.Point(282, 12);
            this.sizeListBox.Name = "sizeListBox";
            this.sizeListBox.Size = new System.Drawing.Size(79, 69);
            this.sizeListBox.TabIndex = 14;
            this.sizeListBox.SelectedIndexChanged += new System.EventHandler(this.sizeListBox_SelectedIndexChanged);
            // 
            // commoditiesListBox
            // 
            this.commoditiesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commoditiesListBox.FormattingEnabled = true;
            this.commoditiesListBox.ItemHeight = 15;
            this.commoditiesListBox.Items.AddRange(new object[] {
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
            "Curtains"});
            this.commoditiesListBox.Location = new System.Drawing.Point(81, 12);
            this.commoditiesListBox.Name = "commoditiesListBox";
            this.commoditiesListBox.Size = new System.Drawing.Size(100, 274);
            this.commoditiesListBox.TabIndex = 13;
            this.commoditiesListBox.SelectedIndexChanged += new System.EventHandler(this.commoditiesListBox_SelectedIndexChanged);
            // 
            // CommoditiesLabel
            // 
            this.CommoditiesLabel.AutoSize = true;
            this.CommoditiesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommoditiesLabel.Location = new System.Drawing.Point(3, 28);
            this.CommoditiesLabel.Name = "CommoditiesLabel";
            this.CommoditiesLabel.Size = new System.Drawing.Size(57, 20);
            this.CommoditiesLabel.TabIndex = 0;
            this.CommoditiesLabel.Text = "Goods";
            this.CommoditiesLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.Location = new System.Drawing.Point(187, 156);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(517, 133);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Commodities";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "sizes";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantity";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Individual Price";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Collective Price";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(218, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Size";
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(500, 19);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(55, 23);
            this.addButton.TabIndex = 6;
            this.addButton.Text = " &ADD";
            this.toolTip1.SetToolTip(this.addButton, "Click here to add the items");
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(395, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Quantity";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.mealTabPage);
            this.tabControl1.Controls.Add(this.summaryTabPage);
            this.tabControl1.Controls.Add(this.searchTabPage);
            this.tabControl1.Location = new System.Drawing.Point(34, 70);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(737, 463);
            this.tabControl1.TabIndex = 1;
            // 
            // searchTabPage
            // 
            this.searchTabPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchTabPage.BackgroundImage")));
            this.searchTabPage.Location = new System.Drawing.Point(4, 22);
            this.searchTabPage.Name = "searchTabPage";
            this.searchTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.searchTabPage.Size = new System.Drawing.Size(729, 437);
            this.searchTabPage.TabIndex = 3;
            this.searchTabPage.Text = "Search";
            this.searchTabPage.UseVisualStyleBackColor = true;
            this.searchTabPage.Click += new System.EventHandler(this.searchTabPage_Click);
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 263);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(614, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.Padding = new System.Windows.Forms.Padding(0, 0, 25, 25);
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(614, 25);
            this.TopToolStripPanel.Click += new System.EventHandler(this.toolStripContainer1_TopToolStripPanel_Click);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightToolStripPanel.Location = new System.Drawing.Point(614, 25);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 238);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 25);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 238);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(614, 238);
            this.ContentPanel.Load += new System.EventHandler(this.toolStripContainer1_ContentPanel_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 614);
            this.Controls.Add(this.exit_Button);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "EPOS";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.summaryTabPage.ResumeLayout(false);
            this.summaryTabPage.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.mealTabPage.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

       

        #endregion
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exit_Button;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        //private System.Windows.Forms.DataGridViewTextBoxColumn sizes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ragle;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage mealTabPage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button completeOrderButton;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox sizeListBox;
        private System.Windows.Forms.ListBox commoditiesListBox;
        private System.Windows.Forms.Button deleteItem;
        private System.Windows.Forms.Label CommoditiesLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button proceedButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage summaryTabPage;
        private System.Windows.Forms.Button summary_Button;
        private System.Windows.Forms.NumericUpDown quantityNumericUpDown;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TabPage searchTabPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.Label averageLable;
        private System.Windows.Forms.Label totalNoTransLable;
        private System.Windows.Forms.Label totalSaleValueLabel;
        private System.Windows.Forms.Label totalCommoditiesLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.Button CancelOrder;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox collectivePriceTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label CollectivePriceLabel;
    }
}

