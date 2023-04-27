namespace TaxiHub.View
{
    partial class CarsForm
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
            System.Windows.Forms.Label carNumberLabel;
            System.Windows.Forms.Label colorLabel;
            System.Windows.Forms.Label seatsNumberLabel;
            System.Windows.Forms.Label releaseYearLabel;
            System.Windows.Forms.Label carBrandLabel;
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label lastDateTechnicalInspectionLabel;
            System.Windows.Forms.Label driversLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarsForm));
            this.taxiCompanyDataSet = new TaxiHub.TaxiCompanyDataSet();
            this.carsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carsTableAdapter = new TaxiHub.TaxiCompanyDataSetTableAdapters.CarsTableAdapter();
            this.tableAdapterManager = new TaxiHub.TaxiCompanyDataSetTableAdapters.TableAdapterManager();
            this.carsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.carsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.PropertyCarsBindingSourceToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripTextBoxFind = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButtonFind = new System.Windows.Forms.ToolStripButton();
            this.carNumberTextBox = new System.Windows.Forms.TextBox();
            this.colorTextBox = new System.Windows.Forms.TextBox();
            this.seatsNumberTextBox = new System.Windows.Forms.TextBox();
            this.releaseYearTextBox = new System.Windows.Forms.TextBox();
            this.carBrandTextBox = new System.Windows.Forms.TextBox();
            this.lastDateTechnicalInspectionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.driversTextBox = new System.Windows.Forms.TextBox();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.FilterCheckBox = new System.Windows.Forms.CheckBox();
            carNumberLabel = new System.Windows.Forms.Label();
            colorLabel = new System.Windows.Forms.Label();
            seatsNumberLabel = new System.Windows.Forms.Label();
            releaseYearLabel = new System.Windows.Forms.Label();
            carBrandLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            lastDateTechnicalInspectionLabel = new System.Windows.Forms.Label();
            driversLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.taxiCompanyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingNavigator)).BeginInit();
            this.carsBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // carNumberLabel
            // 
            carNumberLabel.AutoSize = true;
            carNumberLabel.Location = new System.Drawing.Point(14, 46);
            carNumberLabel.Margin = new System.Windows.Forms.Padding(5, 5, 3, 0);
            carNumberLabel.Name = "carNumberLabel";
            carNumberLabel.Size = new System.Drawing.Size(66, 13);
            carNumberLabel.TabIndex = 1;
            carNumberLabel.Text = "Car Number:";
            // 
            // colorLabel
            // 
            colorLabel.AutoSize = true;
            colorLabel.Location = new System.Drawing.Point(14, 72);
            colorLabel.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            colorLabel.Name = "colorLabel";
            colorLabel.Size = new System.Drawing.Size(34, 13);
            colorLabel.TabIndex = 3;
            colorLabel.Text = "Color:";
            // 
            // seatsNumberLabel
            // 
            seatsNumberLabel.AutoSize = true;
            seatsNumberLabel.Location = new System.Drawing.Point(14, 98);
            seatsNumberLabel.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            seatsNumberLabel.Name = "seatsNumberLabel";
            seatsNumberLabel.Size = new System.Drawing.Size(77, 13);
            seatsNumberLabel.TabIndex = 5;
            seatsNumberLabel.Text = "Seats Number:";
            // 
            // releaseYearLabel
            // 
            releaseYearLabel.AutoSize = true;
            releaseYearLabel.Location = new System.Drawing.Point(14, 124);
            releaseYearLabel.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            releaseYearLabel.Name = "releaseYearLabel";
            releaseYearLabel.Size = new System.Drawing.Size(74, 13);
            releaseYearLabel.TabIndex = 7;
            releaseYearLabel.Text = "Release Year:";
            // 
            // carBrandLabel
            // 
            carBrandLabel.AutoSize = true;
            carBrandLabel.Location = new System.Drawing.Point(14, 150);
            carBrandLabel.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            carBrandLabel.Name = "carBrandLabel";
            carBrandLabel.Size = new System.Drawing.Size(57, 13);
            carBrandLabel.TabIndex = 9;
            carBrandLabel.Text = "Car Brand:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(14, 176);
            statusLabel.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(40, 13);
            statusLabel.TabIndex = 11;
            statusLabel.Text = "Status:";
            // 
            // lastDateTechnicalInspectionLabel
            // 
            lastDateTechnicalInspectionLabel.AutoSize = true;
            lastDateTechnicalInspectionLabel.Location = new System.Drawing.Point(14, 203);
            lastDateTechnicalInspectionLabel.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            lastDateTechnicalInspectionLabel.Name = "lastDateTechnicalInspectionLabel";
            lastDateTechnicalInspectionLabel.Size = new System.Drawing.Size(158, 13);
            lastDateTechnicalInspectionLabel.TabIndex = 13;
            lastDateTechnicalInspectionLabel.Text = "Last Date Technical Inspection:";
            // 
            // driversLabel
            // 
            driversLabel.AutoSize = true;
            driversLabel.Location = new System.Drawing.Point(14, 228);
            driversLabel.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            driversLabel.Name = "driversLabel";
            driversLabel.Size = new System.Drawing.Size(43, 13);
            driversLabel.TabIndex = 15;
            driversLabel.Text = "Drivers:";
            // 
            // taxiCompanyDataSet
            // 
            this.taxiCompanyDataSet.DataSetName = "TaxiCompanyDataSet";
            this.taxiCompanyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carsBindingSource
            // 
            this.carsBindingSource.DataMember = "Cars";
            this.carsBindingSource.DataSource = this.taxiCompanyDataSet;
            // 
            // carsTableAdapter
            // 
            this.carsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CarsTableAdapter = this.carsTableAdapter;
            this.tableAdapterManager.ClientsTableAdapter = null;
            this.tableAdapterManager.DriversTableAdapter = null;
            this.tableAdapterManager.FeedBackTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TaxiHub.TaxiCompanyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // carsBindingNavigator
            // 
            this.carsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.carsBindingNavigator.BindingSource = this.carsBindingSource;
            this.carsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.carsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.carsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.carsBindingNavigatorSaveItem,
            this.toolStripSeparator1,
            this.PropertyCarsBindingSourceToolStripComboBox,
            this.toolStripTextBoxFind,
            this.toolStripButtonFind});
            this.carsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.carsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.carsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.carsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.carsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.carsBindingNavigator.Name = "carsBindingNavigator";
            this.carsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.carsBindingNavigator.Size = new System.Drawing.Size(611, 25);
            this.carsBindingNavigator.TabIndex = 0;
            this.carsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // carsBindingNavigatorSaveItem
            // 
            this.carsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.carsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("carsBindingNavigatorSaveItem.Image")));
            this.carsBindingNavigatorSaveItem.Name = "carsBindingNavigatorSaveItem";
            this.carsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.carsBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.carsBindingNavigatorSaveItem.Click += new System.EventHandler(this.carsBindingNavigatorSaveItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // PropertyCarsBindingSourceToolStripComboBox
            // 
            this.PropertyCarsBindingSourceToolStripComboBox.AutoSize = false;
            this.PropertyCarsBindingSourceToolStripComboBox.Name = "PropertyCarsBindingSourceToolStripComboBox";
            this.PropertyCarsBindingSourceToolStripComboBox.Size = new System.Drawing.Size(80, 23);
            // 
            // toolStripTextBoxFind
            // 
            this.toolStripTextBoxFind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBoxFind.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBoxFind.Name = "toolStripTextBoxFind";
            this.toolStripTextBoxFind.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripButtonFind
            // 
            this.toolStripButtonFind.Image = global::TaxiHub.Properties.Resources.free_icon_magnifier_2397983;
            this.toolStripButtonFind.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButtonFind.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFind.Name = "toolStripButtonFind";
            this.toolStripButtonFind.Size = new System.Drawing.Size(62, 22);
            this.toolStripButtonFind.Text = "Поиск";
            this.toolStripButtonFind.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripButtonFind.Click += new System.EventHandler(this.toolStripButtonFind_Click);
            // 
            // carNumberTextBox
            // 
            this.carNumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.carNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carsBindingSource, "CarNumber", true));
            this.carNumberTextBox.Location = new System.Drawing.Point(178, 43);
            this.carNumberTextBox.Margin = new System.Windows.Forms.Padding(3, 5, 5, 3);
            this.carNumberTextBox.Name = "carNumberTextBox";
            this.carNumberTextBox.Size = new System.Drawing.Size(205, 20);
            this.carNumberTextBox.TabIndex = 2;
            // 
            // colorTextBox
            // 
            this.colorTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.colorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carsBindingSource, "Color", true));
            this.colorTextBox.Location = new System.Drawing.Point(178, 69);
            this.colorTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.colorTextBox.Name = "colorTextBox";
            this.colorTextBox.Size = new System.Drawing.Size(205, 20);
            this.colorTextBox.TabIndex = 4;
            // 
            // seatsNumberTextBox
            // 
            this.seatsNumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.seatsNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carsBindingSource, "SeatsNumber", true));
            this.seatsNumberTextBox.Location = new System.Drawing.Point(178, 95);
            this.seatsNumberTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.seatsNumberTextBox.Name = "seatsNumberTextBox";
            this.seatsNumberTextBox.Size = new System.Drawing.Size(205, 20);
            this.seatsNumberTextBox.TabIndex = 6;
            // 
            // releaseYearTextBox
            // 
            this.releaseYearTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.releaseYearTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carsBindingSource, "ReleaseYear", true));
            this.releaseYearTextBox.Location = new System.Drawing.Point(178, 121);
            this.releaseYearTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.releaseYearTextBox.Name = "releaseYearTextBox";
            this.releaseYearTextBox.Size = new System.Drawing.Size(145, 20);
            this.releaseYearTextBox.TabIndex = 8;
            // 
            // carBrandTextBox
            // 
            this.carBrandTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.carBrandTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carsBindingSource, "CarBrand", true));
            this.carBrandTextBox.Location = new System.Drawing.Point(178, 147);
            this.carBrandTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.carBrandTextBox.Name = "carBrandTextBox";
            this.carBrandTextBox.Size = new System.Drawing.Size(205, 20);
            this.carBrandTextBox.TabIndex = 10;
            // 
            // lastDateTechnicalInspectionDateTimePicker
            // 
            this.lastDateTechnicalInspectionDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lastDateTechnicalInspectionDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.carsBindingSource, "LastDateTechnicalInspection", true));
            this.lastDateTechnicalInspectionDateTimePicker.Location = new System.Drawing.Point(178, 199);
            this.lastDateTechnicalInspectionDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.lastDateTechnicalInspectionDateTimePicker.Name = "lastDateTechnicalInspectionDateTimePicker";
            this.lastDateTechnicalInspectionDateTimePicker.Size = new System.Drawing.Size(205, 20);
            this.lastDateTechnicalInspectionDateTimePicker.TabIndex = 14;
            // 
            // driversTextBox
            // 
            this.driversTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.driversTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carsBindingSource, "Drivers", true));
            this.driversTextBox.Location = new System.Drawing.Point(178, 225);
            this.driversTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.driversTextBox.Name = "driversTextBox";
            this.driversTextBox.Size = new System.Drawing.Size(316, 20);
            this.driversTextBox.TabIndex = 16;
            // 
            // statusComboBox
            // 
            this.statusComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carsBindingSource, "Status", true));
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Items.AddRange(new object[] {
            "Свободна",
            "Занята"});
            this.statusComboBox.Location = new System.Drawing.Point(178, 173);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(145, 21);
            this.statusComboBox.TabIndex = 18;
            // 
            // FilterCheckBox
            // 
            this.FilterCheckBox.AutoSize = true;
            this.FilterCheckBox.Location = new System.Drawing.Point(535, 4);
            this.FilterCheckBox.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.FilterCheckBox.Name = "FilterCheckBox";
            this.FilterCheckBox.Size = new System.Drawing.Size(66, 17);
            this.FilterCheckBox.TabIndex = 19;
            this.FilterCheckBox.Text = "Фильтр";
            this.FilterCheckBox.UseVisualStyleBackColor = true;
            this.FilterCheckBox.CheckedChanged += new System.EventHandler(this.FilterCheckBox_CheckedChanged);
            // 
            // CarsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(611, 265);
            this.Controls.Add(this.FilterCheckBox);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(carNumberLabel);
            this.Controls.Add(this.carNumberTextBox);
            this.Controls.Add(colorLabel);
            this.Controls.Add(this.colorTextBox);
            this.Controls.Add(seatsNumberLabel);
            this.Controls.Add(this.seatsNumberTextBox);
            this.Controls.Add(releaseYearLabel);
            this.Controls.Add(this.releaseYearTextBox);
            this.Controls.Add(carBrandLabel);
            this.Controls.Add(this.carBrandTextBox);
            this.Controls.Add(statusLabel);
            this.Controls.Add(lastDateTechnicalInspectionLabel);
            this.Controls.Add(this.lastDateTechnicalInspectionDateTimePicker);
            this.Controls.Add(driversLabel);
            this.Controls.Add(this.driversTextBox);
            this.Controls.Add(this.carsBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(300, 150);
            this.Name = "CarsForm";
            this.Text = "Cars";
            this.Load += new System.EventHandler(this.CarsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.taxiCompanyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingNavigator)).EndInit();
            this.carsBindingNavigator.ResumeLayout(false);
            this.carsBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TaxiCompanyDataSet taxiCompanyDataSet;
        private System.Windows.Forms.BindingSource carsBindingSource;
        private TaxiCompanyDataSetTableAdapters.CarsTableAdapter carsTableAdapter;
        private TaxiCompanyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator carsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton carsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox carNumberTextBox;
        private System.Windows.Forms.TextBox colorTextBox;
        private System.Windows.Forms.TextBox seatsNumberTextBox;
        private System.Windows.Forms.TextBox releaseYearTextBox;
        private System.Windows.Forms.TextBox carBrandTextBox;
        private System.Windows.Forms.DateTimePicker lastDateTechnicalInspectionDateTimePicker;
        private System.Windows.Forms.TextBox driversTextBox;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxFind;
        private System.Windows.Forms.ToolStripButton toolStripButtonFind;
        private System.Windows.Forms.CheckBox FilterCheckBox;
        private System.Windows.Forms.ToolStripComboBox PropertyCarsBindingSourceToolStripComboBox;
    }
}