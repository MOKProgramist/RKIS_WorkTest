namespace RKIS_WorkTest.Forms
{
    partial class FormOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrders));
            System.Windows.Forms.Label boat_IDLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label customer_IDLabel;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label deliveryAddressLabel;
            System.Windows.Forms.Label order_IDLabel;
            System.Windows.Forms.Label salesperson_IDLabel;
            this.orderBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.orderBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.orderDataGridView = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.boat_IDTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.customer_IDTextBox = new System.Windows.Forms.TextBox();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.deliveryAddressTextBox = new System.Windows.Forms.TextBox();
            this.order_IDTextBox = new System.Windows.Forms.TextBox();
            this.salesperson_IDTextBox = new System.Windows.Forms.TextBox();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            boat_IDLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            customer_IDLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            deliveryAddressLabel = new System.Windows.Forms.Label();
            order_IDLabel = new System.Windows.Forms.Label();
            salesperson_IDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingNavigator)).BeginInit();
            this.orderBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // orderBindingNavigator
            // 
            this.orderBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.orderBindingNavigator.BindingSource = this.orderBindingSource;
            this.orderBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.orderBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.orderBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.orderBindingNavigatorSaveItem});
            this.orderBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.orderBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.orderBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.orderBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.orderBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.orderBindingNavigator.Name = "orderBindingNavigator";
            this.orderBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.orderBindingNavigator.Size = new System.Drawing.Size(1334, 25);
            this.orderBindingNavigator.TabIndex = 0;
            this.orderBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // orderBindingNavigatorSaveItem
            // 
            this.orderBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.orderBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("orderBindingNavigatorSaveItem.Image")));
            this.orderBindingNavigatorSaveItem.Name = "orderBindingNavigatorSaveItem";
            this.orderBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.orderBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.orderBindingNavigatorSaveItem.Click += new System.EventHandler(this.orderBindingNavigatorSaveItem_Click);
            // 
            // orderDataGridView
            // 
            this.orderDataGridView.AllowUserToOrderColumns = true;
            this.orderDataGridView.AutoGenerateColumns = false;
            this.orderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.orderDataGridView.DataSource = this.orderBindingSource;
            this.orderDataGridView.Location = new System.Drawing.Point(371, 37);
            this.orderDataGridView.Name = "orderDataGridView";
            this.orderDataGridView.Size = new System.Drawing.Size(951, 296);
            this.orderDataGridView.TabIndex = 1;
            this.orderDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderDataGridView_CellContentClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(27, 310);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Назад";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // boat_IDLabel
            // 
            boat_IDLabel.AutoSize = true;
            boat_IDLabel.Location = new System.Drawing.Point(24, 50);
            boat_IDLabel.Name = "boat_IDLabel";
            boat_IDLabel.Size = new System.Drawing.Size(46, 13);
            boat_IDLabel.TabIndex = 65;
            boat_IDLabel.Text = "Boat ID:";
            // 
            // boat_IDTextBox
            // 
            this.boat_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "Boat_ID", true));
            this.boat_IDTextBox.Location = new System.Drawing.Point(119, 47);
            this.boat_IDTextBox.Name = "boat_IDTextBox";
            this.boat_IDTextBox.Size = new System.Drawing.Size(200, 20);
            this.boat_IDTextBox.TabIndex = 66;
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(24, 76);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(27, 13);
            cityLabel.TabIndex = 67;
            cityLabel.Text = "City:";
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "City", true));
            this.cityTextBox.Location = new System.Drawing.Point(119, 73);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(200, 20);
            this.cityTextBox.TabIndex = 68;
            // 
            // customer_IDLabel
            // 
            customer_IDLabel.AutoSize = true;
            customer_IDLabel.Location = new System.Drawing.Point(24, 102);
            customer_IDLabel.Name = "customer_IDLabel";
            customer_IDLabel.Size = new System.Drawing.Size(68, 13);
            customer_IDLabel.TabIndex = 69;
            customer_IDLabel.Text = "Customer ID:";
            // 
            // customer_IDTextBox
            // 
            this.customer_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "Customer_ID", true));
            this.customer_IDTextBox.Location = new System.Drawing.Point(119, 99);
            this.customer_IDTextBox.Name = "customer_IDTextBox";
            this.customer_IDTextBox.Size = new System.Drawing.Size(200, 20);
            this.customer_IDTextBox.TabIndex = 70;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(24, 129);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(33, 13);
            dateLabel.TabIndex = 71;
            dateLabel.Text = "Date:";
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.orderBindingSource, "Date", true));
            this.dateDateTimePicker.Location = new System.Drawing.Point(119, 125);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateDateTimePicker.TabIndex = 72;
            // 
            // deliveryAddressLabel
            // 
            deliveryAddressLabel.AutoSize = true;
            deliveryAddressLabel.Location = new System.Drawing.Point(24, 154);
            deliveryAddressLabel.Name = "deliveryAddressLabel";
            deliveryAddressLabel.Size = new System.Drawing.Size(89, 13);
            deliveryAddressLabel.TabIndex = 73;
            deliveryAddressLabel.Text = "Delivery Address:";
            // 
            // deliveryAddressTextBox
            // 
            this.deliveryAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "DeliveryAddress", true));
            this.deliveryAddressTextBox.Location = new System.Drawing.Point(119, 151);
            this.deliveryAddressTextBox.Name = "deliveryAddressTextBox";
            this.deliveryAddressTextBox.Size = new System.Drawing.Size(200, 20);
            this.deliveryAddressTextBox.TabIndex = 74;
            // 
            // order_IDLabel
            // 
            order_IDLabel.AutoSize = true;
            order_IDLabel.Location = new System.Drawing.Point(24, 180);
            order_IDLabel.Name = "order_IDLabel";
            order_IDLabel.Size = new System.Drawing.Size(50, 13);
            order_IDLabel.TabIndex = 75;
            order_IDLabel.Text = "Order ID:";
            // 
            // order_IDTextBox
            // 
            this.order_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "Order_ID", true));
            this.order_IDTextBox.Location = new System.Drawing.Point(119, 177);
            this.order_IDTextBox.Name = "order_IDTextBox";
            this.order_IDTextBox.Size = new System.Drawing.Size(200, 20);
            this.order_IDTextBox.TabIndex = 76;
            // 
            // salesperson_IDLabel
            // 
            salesperson_IDLabel.AutoSize = true;
            salesperson_IDLabel.Location = new System.Drawing.Point(24, 206);
            salesperson_IDLabel.Name = "salesperson_IDLabel";
            salesperson_IDLabel.Size = new System.Drawing.Size(82, 13);
            salesperson_IDLabel.TabIndex = 77;
            salesperson_IDLabel.Text = "Salesperson ID:";
            // 
            // salesperson_IDTextBox
            // 
            this.salesperson_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "Salesperson_ID", true));
            this.salesperson_IDTextBox.Location = new System.Drawing.Point(119, 203);
            this.salesperson_IDTextBox.Name = "salesperson_IDTextBox";
            this.salesperson_IDTextBox.Size = new System.Drawing.Size(200, 20);
            this.salesperson_IDTextBox.TabIndex = 78;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(RKIS_WorkTest.Models.Order);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Order_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Order_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn2.HeaderText = "Date";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Salesperson_ID";
            this.dataGridViewTextBoxColumn3.HeaderText = "Salesperson_ID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Customer_ID";
            this.dataGridViewTextBoxColumn4.HeaderText = "Customer_ID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Boat_ID";
            this.dataGridViewTextBoxColumn5.HeaderText = "Boat_ID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "DeliveryAddress";
            this.dataGridViewTextBoxColumn6.HeaderText = "DeliveryAddress";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "City";
            this.dataGridViewTextBoxColumn7.HeaderText = "City";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Boat";
            this.dataGridViewTextBoxColumn8.HeaderText = "Boat";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Contract";
            this.dataGridViewTextBoxColumn9.HeaderText = "Contract";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Customer";
            this.dataGridViewTextBoxColumn10.HeaderText = "Customer";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Order_Details";
            this.dataGridViewTextBoxColumn11.HeaderText = "Order_Details";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Sales_Person";
            this.dataGridViewTextBoxColumn12.HeaderText = "Sales_Person";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // FormOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1334, 1061);
            this.Controls.Add(boat_IDLabel);
            this.Controls.Add(this.boat_IDTextBox);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(customer_IDLabel);
            this.Controls.Add(this.customer_IDTextBox);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dateDateTimePicker);
            this.Controls.Add(deliveryAddressLabel);
            this.Controls.Add(this.deliveryAddressTextBox);
            this.Controls.Add(order_IDLabel);
            this.Controls.Add(this.order_IDTextBox);
            this.Controls.Add(salesperson_IDLabel);
            this.Controls.Add(this.salesperson_IDTextBox);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.orderDataGridView);
            this.Controls.Add(this.orderBindingNavigator);
            this.Name = "FormOrders";
            this.Text = "Заказы";
            this.Load += new System.EventHandler(this.FormOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingNavigator)).EndInit();
            this.orderBindingNavigator.ResumeLayout(false);
            this.orderBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.BindingNavigator orderBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton orderBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView orderDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox boat_IDTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox customer_IDTextBox;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.TextBox deliveryAddressTextBox;
        private System.Windows.Forms.TextBox order_IDTextBox;
        private System.Windows.Forms.TextBox salesperson_IDTextBox;
    }
}