namespace RKIS_WorkTest.Forms
{
    partial class FormBoats
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBoats));
            System.Windows.Forms.Label basePriceLabel;
            System.Windows.Forms.Label boat_IDLabel;
            System.Windows.Forms.Label boatTypeLabel;
            System.Windows.Forms.Label colourLabel;
            System.Windows.Forms.Label mastLabel;
            System.Windows.Forms.Label modelLabel;
            System.Windows.Forms.Label numberOfRowersLabel;
            System.Windows.Forms.Label vATLabel;
            System.Windows.Forms.Label woodLabel;
            this.boatBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.boatBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.boatDataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.basePriceTextBox = new System.Windows.Forms.TextBox();
            this.boat_IDTextBox = new System.Windows.Forms.TextBox();
            this.boatTypeTextBox = new System.Windows.Forms.TextBox();
            this.colourTextBox = new System.Windows.Forms.TextBox();
            this.mastCheckBox = new System.Windows.Forms.CheckBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.numberOfRowersTextBox = new System.Windows.Forms.TextBox();
            this.vATTextBox = new System.Windows.Forms.TextBox();
            this.woodTextBox = new System.Windows.Forms.TextBox();
            this.boatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            basePriceLabel = new System.Windows.Forms.Label();
            boat_IDLabel = new System.Windows.Forms.Label();
            boatTypeLabel = new System.Windows.Forms.Label();
            colourLabel = new System.Windows.Forms.Label();
            mastLabel = new System.Windows.Forms.Label();
            modelLabel = new System.Windows.Forms.Label();
            numberOfRowersLabel = new System.Windows.Forms.Label();
            vATLabel = new System.Windows.Forms.Label();
            woodLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.boatBindingNavigator)).BeginInit();
            this.boatBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boatDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boatBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // boatBindingNavigator
            // 
            this.boatBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.boatBindingNavigator.BindingSource = this.boatBindingSource;
            this.boatBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.boatBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.boatBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.boatBindingNavigatorSaveItem});
            this.boatBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.boatBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.boatBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.boatBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.boatBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.boatBindingNavigator.Name = "boatBindingNavigator";
            this.boatBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.boatBindingNavigator.Size = new System.Drawing.Size(1321, 25);
            this.boatBindingNavigator.TabIndex = 0;
            this.boatBindingNavigator.Text = "bindingNavigator1";
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
            // boatBindingNavigatorSaveItem
            // 
            this.boatBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.boatBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("boatBindingNavigatorSaveItem.Image")));
            this.boatBindingNavigatorSaveItem.Name = "boatBindingNavigatorSaveItem";
            this.boatBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.boatBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.boatBindingNavigatorSaveItem.Click += new System.EventHandler(this.boatBindingNavigatorSaveItem_Click);
            // 
            // boatDataGridView
            // 
            this.boatDataGridView.AutoGenerateColumns = false;
            this.boatDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.boatDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.boatDataGridView.DataSource = this.boatBindingSource;
            this.boatDataGridView.Location = new System.Drawing.Point(0, 38);
            this.boatDataGridView.Name = "boatDataGridView";
            this.boatDataGridView.Size = new System.Drawing.Size(1245, 220);
            this.boatDataGridView.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 525);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // basePriceLabel
            // 
            basePriceLabel.AutoSize = true;
            basePriceLabel.Location = new System.Drawing.Point(10, 273);
            basePriceLabel.Name = "basePriceLabel";
            basePriceLabel.Size = new System.Drawing.Size(61, 13);
            basePriceLabel.TabIndex = 3;
            basePriceLabel.Text = "Base Price:";
            // 
            // basePriceTextBox
            // 
            this.basePriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.boatBindingSource, "BasePrice", true));
            this.basePriceTextBox.Location = new System.Drawing.Point(116, 270);
            this.basePriceTextBox.Name = "basePriceTextBox";
            this.basePriceTextBox.Size = new System.Drawing.Size(104, 20);
            this.basePriceTextBox.TabIndex = 4;
            // 
            // boat_IDLabel
            // 
            boat_IDLabel.AutoSize = true;
            boat_IDLabel.Location = new System.Drawing.Point(10, 299);
            boat_IDLabel.Name = "boat_IDLabel";
            boat_IDLabel.Size = new System.Drawing.Size(45, 13);
            boat_IDLabel.TabIndex = 5;
            boat_IDLabel.Text = "boat ID:";
            // 
            // boat_IDTextBox
            // 
            this.boat_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.boatBindingSource, "boat_ID", true));
            this.boat_IDTextBox.Location = new System.Drawing.Point(116, 296);
            this.boat_IDTextBox.Name = "boat_IDTextBox";
            this.boat_IDTextBox.Size = new System.Drawing.Size(104, 20);
            this.boat_IDTextBox.TabIndex = 6;
            // 
            // boatTypeLabel
            // 
            boatTypeLabel.AutoSize = true;
            boatTypeLabel.Location = new System.Drawing.Point(10, 325);
            boatTypeLabel.Name = "boatTypeLabel";
            boatTypeLabel.Size = new System.Drawing.Size(59, 13);
            boatTypeLabel.TabIndex = 7;
            boatTypeLabel.Text = "Boat Type:";
            // 
            // boatTypeTextBox
            // 
            this.boatTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.boatBindingSource, "BoatType", true));
            this.boatTypeTextBox.Location = new System.Drawing.Point(116, 322);
            this.boatTypeTextBox.Name = "boatTypeTextBox";
            this.boatTypeTextBox.Size = new System.Drawing.Size(104, 20);
            this.boatTypeTextBox.TabIndex = 8;
            // 
            // colourLabel
            // 
            colourLabel.AutoSize = true;
            colourLabel.Location = new System.Drawing.Point(10, 351);
            colourLabel.Name = "colourLabel";
            colourLabel.Size = new System.Drawing.Size(40, 13);
            colourLabel.TabIndex = 9;
            colourLabel.Text = "Colour:";
            // 
            // colourTextBox
            // 
            this.colourTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.boatBindingSource, "Colour", true));
            this.colourTextBox.Location = new System.Drawing.Point(116, 348);
            this.colourTextBox.Name = "colourTextBox";
            this.colourTextBox.Size = new System.Drawing.Size(104, 20);
            this.colourTextBox.TabIndex = 10;
            // 
            // mastLabel
            // 
            mastLabel.AutoSize = true;
            mastLabel.Location = new System.Drawing.Point(10, 379);
            mastLabel.Name = "mastLabel";
            mastLabel.Size = new System.Drawing.Size(33, 13);
            mastLabel.TabIndex = 11;
            mastLabel.Text = "Mast:";
            // 
            // mastCheckBox
            // 
            this.mastCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.boatBindingSource, "Mast", true));
            this.mastCheckBox.Location = new System.Drawing.Point(116, 374);
            this.mastCheckBox.Name = "mastCheckBox";
            this.mastCheckBox.Size = new System.Drawing.Size(104, 24);
            this.mastCheckBox.TabIndex = 12;
            this.mastCheckBox.Text = "checkBox1";
            this.mastCheckBox.UseVisualStyleBackColor = true;
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.Location = new System.Drawing.Point(10, 407);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new System.Drawing.Size(39, 13);
            modelLabel.TabIndex = 13;
            modelLabel.Text = "Model:";
            // 
            // modelTextBox
            // 
            this.modelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.boatBindingSource, "Model", true));
            this.modelTextBox.Location = new System.Drawing.Point(116, 404);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(104, 20);
            this.modelTextBox.TabIndex = 14;
            // 
            // numberOfRowersLabel
            // 
            numberOfRowersLabel.AutoSize = true;
            numberOfRowersLabel.Location = new System.Drawing.Point(10, 433);
            numberOfRowersLabel.Name = "numberOfRowersLabel";
            numberOfRowersLabel.Size = new System.Drawing.Size(100, 13);
            numberOfRowersLabel.TabIndex = 15;
            numberOfRowersLabel.Text = "Number Of Rowers:";
            // 
            // numberOfRowersTextBox
            // 
            this.numberOfRowersTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.boatBindingSource, "NumberOfRowers", true));
            this.numberOfRowersTextBox.Location = new System.Drawing.Point(116, 430);
            this.numberOfRowersTextBox.Name = "numberOfRowersTextBox";
            this.numberOfRowersTextBox.Size = new System.Drawing.Size(104, 20);
            this.numberOfRowersTextBox.TabIndex = 16;
            // 
            // vATLabel
            // 
            vATLabel.AutoSize = true;
            vATLabel.Location = new System.Drawing.Point(10, 459);
            vATLabel.Name = "vATLabel";
            vATLabel.Size = new System.Drawing.Size(31, 13);
            vATLabel.TabIndex = 17;
            vATLabel.Text = "VAT:";
            // 
            // vATTextBox
            // 
            this.vATTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.boatBindingSource, "VAT", true));
            this.vATTextBox.Location = new System.Drawing.Point(116, 456);
            this.vATTextBox.Name = "vATTextBox";
            this.vATTextBox.Size = new System.Drawing.Size(104, 20);
            this.vATTextBox.TabIndex = 18;
            // 
            // woodLabel
            // 
            woodLabel.AutoSize = true;
            woodLabel.Location = new System.Drawing.Point(10, 485);
            woodLabel.Name = "woodLabel";
            woodLabel.Size = new System.Drawing.Size(39, 13);
            woodLabel.TabIndex = 19;
            woodLabel.Text = "Wood:";
            // 
            // woodTextBox
            // 
            this.woodTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.boatBindingSource, "Wood", true));
            this.woodTextBox.Location = new System.Drawing.Point(116, 482);
            this.woodTextBox.Name = "woodTextBox";
            this.woodTextBox.Size = new System.Drawing.Size(104, 20);
            this.woodTextBox.TabIndex = 20;
            // 
            // boatBindingSource
            // 
            this.boatBindingSource.DataSource = typeof(RKIS_WorkTest.Models.Boat);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "boat_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "boat_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Model";
            this.dataGridViewTextBoxColumn2.HeaderText = "Model";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "BoatType";
            this.dataGridViewTextBoxColumn3.HeaderText = "BoatType";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NumberOfRowers";
            this.dataGridViewTextBoxColumn4.HeaderText = "NumberOfRowers";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Mast";
            this.dataGridViewTextBoxColumn5.HeaderText = "Mast";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Colour";
            this.dataGridViewTextBoxColumn6.HeaderText = "Colour";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Wood";
            this.dataGridViewTextBoxColumn7.HeaderText = "Wood";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "BasePrice";
            this.dataGridViewTextBoxColumn8.HeaderText = "BasePrice";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "VAT";
            this.dataGridViewTextBoxColumn9.HeaderText = "VAT";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // FormBoats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 652);
            this.Controls.Add(basePriceLabel);
            this.Controls.Add(this.basePriceTextBox);
            this.Controls.Add(boat_IDLabel);
            this.Controls.Add(this.boat_IDTextBox);
            this.Controls.Add(boatTypeLabel);
            this.Controls.Add(this.boatTypeTextBox);
            this.Controls.Add(colourLabel);
            this.Controls.Add(this.colourTextBox);
            this.Controls.Add(mastLabel);
            this.Controls.Add(this.mastCheckBox);
            this.Controls.Add(modelLabel);
            this.Controls.Add(this.modelTextBox);
            this.Controls.Add(numberOfRowersLabel);
            this.Controls.Add(this.numberOfRowersTextBox);
            this.Controls.Add(vATLabel);
            this.Controls.Add(this.vATTextBox);
            this.Controls.Add(woodLabel);
            this.Controls.Add(this.woodTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.boatDataGridView);
            this.Controls.Add(this.boatBindingNavigator);
            this.Name = "FormBoats";
            this.Text = "Лодки";
            this.Load += new System.EventHandler(this.FormBoats_Load);
            ((System.ComponentModel.ISupportInitialize)(this.boatBindingNavigator)).EndInit();
            this.boatBindingNavigator.ResumeLayout(false);
            this.boatBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boatDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boatBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource boatBindingSource;
        private System.Windows.Forms.BindingNavigator boatBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton boatBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView boatDataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.TextBox basePriceTextBox;
        private System.Windows.Forms.TextBox boat_IDTextBox;
        private System.Windows.Forms.TextBox boatTypeTextBox;
        private System.Windows.Forms.TextBox colourTextBox;
        private System.Windows.Forms.CheckBox mastCheckBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox numberOfRowersTextBox;
        private System.Windows.Forms.TextBox vATTextBox;
        private System.Windows.Forms.TextBox woodTextBox;
    }
}