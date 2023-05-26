namespace TaxiHub.View
{
    partial class FormSQL
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
            this.SQLTabControl = new System.Windows.Forms.TabControl();
            this.ExampleTabPage = new System.Windows.Forms.TabPage();
            this.SelectDataGridView = new System.Windows.Forms.DataGridView();
            this.SelectGroupBox = new System.Windows.Forms.GroupBox();
            this.OrdersRadioButton = new System.Windows.Forms.RadioButton();
            this.ClientsRadioButton = new System.Windows.Forms.RadioButton();
            this.CarsRadioButton = new System.Windows.Forms.RadioButton();
            this.SelectTabPage = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FSelectGroupBox = new System.Windows.Forms.GroupBox();
            this.SelectProfitButton = new System.Windows.Forms.Button();
            this.SortDescCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PerAllTimeRadioButton = new System.Windows.Forms.RadioButton();
            this.PerYearRadioButton = new System.Windows.Forms.RadioButton();
            this.PerMonthRadioButton = new System.Windows.Forms.RadioButton();
            this.SelectProfitMoreTextBox = new System.Windows.Forms.TextBox();
            this.SelectMoreCheckBox = new System.Windows.Forms.CheckBox();
            this.SecondNameTextBox = new System.Windows.Forms.TextBox();
            this.SecondNameLabel = new System.Windows.Forms.Label();
            this.tabPageSubquery = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.OrderNumberLabel = new System.Windows.Forms.Label();
            this.UncorrelatedSubqueryRadioButton = new System.Windows.Forms.RadioButton();
            this.CorrelatedSubqueryRadioButton = new System.Windows.Forms.RadioButton();
            this.NumberOrderTextBox = new System.Windows.Forms.TextBox();
            this.ExecuteButton = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.TabPageDML = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.InsertRadioButton = new System.Windows.Forms.RadioButton();
            this.UpdateRadioButton = new System.Windows.Forms.RadioButton();
            this.DeleteRadioButton = new System.Windows.Forms.RadioButton();
            this.IdClientsTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ExecuteRequestButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MiddleTextBox = new System.Windows.Forms.TextBox();
            this.SecondTextBox = new System.Windows.Forms.TextBox();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BalanceTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SQLTabControl.SuspendLayout();
            this.ExampleTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectDataGridView)).BeginInit();
            this.SelectGroupBox.SuspendLayout();
            this.SelectTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.FSelectGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPageSubquery.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.TabPageDML.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // SQLTabControl
            // 
            this.SQLTabControl.Controls.Add(this.ExampleTabPage);
            this.SQLTabControl.Controls.Add(this.SelectTabPage);
            this.SQLTabControl.Controls.Add(this.tabPageSubquery);
            this.SQLTabControl.Controls.Add(this.TabPageDML);
            this.SQLTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SQLTabControl.Location = new System.Drawing.Point(0, 0);
            this.SQLTabControl.Name = "SQLTabControl";
            this.SQLTabControl.SelectedIndex = 0;
            this.SQLTabControl.Size = new System.Drawing.Size(800, 450);
            this.SQLTabControl.TabIndex = 0;
            // 
            // ExampleTabPage
            // 
            this.ExampleTabPage.Controls.Add(this.SelectDataGridView);
            this.ExampleTabPage.Controls.Add(this.SelectGroupBox);
            this.ExampleTabPage.Location = new System.Drawing.Point(4, 22);
            this.ExampleTabPage.Name = "ExampleTabPage";
            this.ExampleTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ExampleTabPage.Size = new System.Drawing.Size(792, 424);
            this.ExampleTabPage.TabIndex = 0;
            this.ExampleTabPage.Text = "Примеры запросов";
            this.ExampleTabPage.UseVisualStyleBackColor = true;
            // 
            // SelectDataGridView
            // 
            this.SelectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SelectDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectDataGridView.Location = new System.Drawing.Point(3, 82);
            this.SelectDataGridView.Name = "SelectDataGridView";
            this.SelectDataGridView.Size = new System.Drawing.Size(786, 339);
            this.SelectDataGridView.TabIndex = 1;
            // 
            // SelectGroupBox
            // 
            this.SelectGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.SelectGroupBox.Controls.Add(this.OrdersRadioButton);
            this.SelectGroupBox.Controls.Add(this.ClientsRadioButton);
            this.SelectGroupBox.Controls.Add(this.CarsRadioButton);
            this.SelectGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.SelectGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SelectGroupBox.Location = new System.Drawing.Point(3, 3);
            this.SelectGroupBox.Name = "SelectGroupBox";
            this.SelectGroupBox.Size = new System.Drawing.Size(786, 79);
            this.SelectGroupBox.TabIndex = 0;
            this.SelectGroupBox.TabStop = false;
            this.SelectGroupBox.Text = "Запросы по данным";
            // 
            // OrdersRadioButton
            // 
            this.OrdersRadioButton.AutoSize = true;
            this.OrdersRadioButton.Location = new System.Drawing.Point(278, 31);
            this.OrdersRadioButton.Margin = new System.Windows.Forms.Padding(15);
            this.OrdersRadioButton.Name = "OrdersRadioButton";
            this.OrdersRadioButton.Size = new System.Drawing.Size(64, 17);
            this.OrdersRadioButton.TabIndex = 2;
            this.OrdersRadioButton.TabStop = true;
            this.OrdersRadioButton.Text = "Заказы";
            this.OrdersRadioButton.UseVisualStyleBackColor = true;
            this.OrdersRadioButton.CheckedChanged += new System.EventHandler(this.OrdersRadioButton_CheckedChanged);
            // 
            // ClientsRadioButton
            // 
            this.ClientsRadioButton.AutoSize = true;
            this.ClientsRadioButton.Location = new System.Drawing.Point(163, 31);
            this.ClientsRadioButton.Margin = new System.Windows.Forms.Padding(15);
            this.ClientsRadioButton.Name = "ClientsRadioButton";
            this.ClientsRadioButton.Size = new System.Drawing.Size(69, 17);
            this.ClientsRadioButton.TabIndex = 1;
            this.ClientsRadioButton.TabStop = true;
            this.ClientsRadioButton.Text = "Клиенты";
            this.ClientsRadioButton.UseVisualStyleBackColor = true;
            this.ClientsRadioButton.CheckedChanged += new System.EventHandler(this.ClientsRadioButton_CheckedChanged);
            // 
            // CarsRadioButton
            // 
            this.CarsRadioButton.AutoSize = true;
            this.CarsRadioButton.Location = new System.Drawing.Point(48, 31);
            this.CarsRadioButton.Margin = new System.Windows.Forms.Padding(15);
            this.CarsRadioButton.Name = "CarsRadioButton";
            this.CarsRadioButton.Size = new System.Drawing.Size(68, 17);
            this.CarsRadioButton.TabIndex = 0;
            this.CarsRadioButton.TabStop = true;
            this.CarsRadioButton.Text = "Машины";
            this.CarsRadioButton.UseVisualStyleBackColor = true;
            this.CarsRadioButton.CheckedChanged += new System.EventHandler(this.CarsRadioButton_CheckedChanged);
            // 
            // SelectTabPage
            // 
            this.SelectTabPage.Controls.Add(this.dataGridView1);
            this.SelectTabPage.Controls.Add(this.FSelectGroupBox);
            this.SelectTabPage.Location = new System.Drawing.Point(4, 22);
            this.SelectTabPage.Name = "SelectTabPage";
            this.SelectTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.SelectTabPage.Size = new System.Drawing.Size(792, 424);
            this.SelectTabPage.TabIndex = 1;
            this.SelectTabPage.Text = "Полная запись SELECT";
            this.SelectTabPage.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 158);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(786, 263);
            this.dataGridView1.TabIndex = 1;
            // 
            // FSelectGroupBox
            // 
            this.FSelectGroupBox.Controls.Add(this.SelectProfitButton);
            this.FSelectGroupBox.Controls.Add(this.SortDescCheckBox);
            this.FSelectGroupBox.Controls.Add(this.groupBox1);
            this.FSelectGroupBox.Controls.Add(this.SelectProfitMoreTextBox);
            this.FSelectGroupBox.Controls.Add(this.SelectMoreCheckBox);
            this.FSelectGroupBox.Controls.Add(this.SecondNameTextBox);
            this.FSelectGroupBox.Controls.Add(this.SecondNameLabel);
            this.FSelectGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.FSelectGroupBox.Location = new System.Drawing.Point(3, 3);
            this.FSelectGroupBox.Name = "FSelectGroupBox";
            this.FSelectGroupBox.Size = new System.Drawing.Size(786, 155);
            this.FSelectGroupBox.TabIndex = 0;
            this.FSelectGroupBox.TabStop = false;
            this.FSelectGroupBox.Text = "Прибыль водителя";
            // 
            // SelectProfitButton
            // 
            this.SelectProfitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectProfitButton.Location = new System.Drawing.Point(326, 126);
            this.SelectProfitButton.Name = "SelectProfitButton";
            this.SelectProfitButton.Size = new System.Drawing.Size(124, 23);
            this.SelectProfitButton.TabIndex = 7;
            this.SelectProfitButton.Text = "Прибыль водителя";
            this.SelectProfitButton.UseVisualStyleBackColor = true;
            this.SelectProfitButton.Click += new System.EventHandler(this.SelectProfitButton_Click);
            // 
            // SortDescCheckBox
            // 
            this.SortDescCheckBox.AutoSize = true;
            this.SortDescCheckBox.Location = new System.Drawing.Point(16, 96);
            this.SortDescCheckBox.Margin = new System.Windows.Forms.Padding(10);
            this.SortDescCheckBox.Name = "SortDescCheckBox";
            this.SortDescCheckBox.Size = new System.Drawing.Size(252, 17);
            this.SortDescCheckBox.TabIndex = 6;
            this.SortDescCheckBox.Text = "Включить сортировку по убыванию прибыли";
            this.SortDescCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.PerAllTimeRadioButton);
            this.groupBox1.Controls.Add(this.PerYearRadioButton);
            this.groupBox1.Controls.Add(this.PerMonthRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(483, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 94);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Детализация прибыли водителя";
            // 
            // PerAllTimeRadioButton
            // 
            this.PerAllTimeRadioButton.AutoSize = true;
            this.PerAllTimeRadioButton.Location = new System.Drawing.Point(6, 65);
            this.PerAllTimeRadioButton.Name = "PerAllTimeRadioButton";
            this.PerAllTimeRadioButton.Size = new System.Drawing.Size(94, 17);
            this.PerAllTimeRadioButton.TabIndex = 2;
            this.PerAllTimeRadioButton.TabStop = true;
            this.PerAllTimeRadioButton.Text = "За все время";
            this.PerAllTimeRadioButton.UseVisualStyleBackColor = true;
            // 
            // PerYearRadioButton
            // 
            this.PerYearRadioButton.AutoSize = true;
            this.PerYearRadioButton.Location = new System.Drawing.Point(6, 42);
            this.PerYearRadioButton.Name = "PerYearRadioButton";
            this.PerYearRadioButton.Size = new System.Drawing.Size(58, 17);
            this.PerYearRadioButton.TabIndex = 1;
            this.PerYearRadioButton.TabStop = true;
            this.PerYearRadioButton.Text = "За год";
            this.PerYearRadioButton.UseVisualStyleBackColor = true;
            // 
            // PerMonthRadioButton
            // 
            this.PerMonthRadioButton.AutoSize = true;
            this.PerMonthRadioButton.Location = new System.Drawing.Point(6, 19);
            this.PerMonthRadioButton.Name = "PerMonthRadioButton";
            this.PerMonthRadioButton.Size = new System.Drawing.Size(73, 17);
            this.PerMonthRadioButton.TabIndex = 0;
            this.PerMonthRadioButton.TabStop = true;
            this.PerMonthRadioButton.Text = "За месяц";
            this.PerMonthRadioButton.UseVisualStyleBackColor = true;
            // 
            // SelectProfitMoreTextBox
            // 
            this.SelectProfitMoreTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SelectProfitMoreTextBox.Location = new System.Drawing.Point(179, 58);
            this.SelectProfitMoreTextBox.Name = "SelectProfitMoreTextBox";
            this.SelectProfitMoreTextBox.Size = new System.Drawing.Size(120, 20);
            this.SelectProfitMoreTextBox.TabIndex = 4;
            // 
            // SelectMoreCheckBox
            // 
            this.SelectMoreCheckBox.AutoSize = true;
            this.SelectMoreCheckBox.Location = new System.Drawing.Point(16, 59);
            this.SelectMoreCheckBox.Margin = new System.Windows.Forms.Padding(10);
            this.SelectMoreCheckBox.Name = "SelectMoreCheckBox";
            this.SelectMoreCheckBox.Size = new System.Drawing.Size(150, 17);
            this.SelectMoreCheckBox.TabIndex = 3;
            this.SelectMoreCheckBox.Text = "Выбрать прибыль более";
            this.SelectMoreCheckBox.UseVisualStyleBackColor = true;
            // 
            // SecondNameTextBox
            // 
            this.SecondNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SecondNameTextBox.Location = new System.Drawing.Point(179, 24);
            this.SecondNameTextBox.Name = "SecondNameTextBox";
            this.SecondNameTextBox.Size = new System.Drawing.Size(120, 20);
            this.SecondNameTextBox.TabIndex = 2;
            // 
            // SecondNameLabel
            // 
            this.SecondNameLabel.AutoSize = true;
            this.SecondNameLabel.Location = new System.Drawing.Point(13, 26);
            this.SecondNameLabel.Margin = new System.Windows.Forms.Padding(10);
            this.SecondNameLabel.Name = "SecondNameLabel";
            this.SecondNameLabel.Size = new System.Drawing.Size(106, 13);
            this.SecondNameLabel.TabIndex = 0;
            this.SecondNameLabel.Text = "Фамилия водителя";
            // 
            // tabPageSubquery
            // 
            this.tabPageSubquery.Controls.Add(this.dataGridView2);
            this.tabPageSubquery.Controls.Add(this.groupBox2);
            this.tabPageSubquery.Location = new System.Drawing.Point(4, 22);
            this.tabPageSubquery.Name = "tabPageSubquery";
            this.tabPageSubquery.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSubquery.Size = new System.Drawing.Size(792, 424);
            this.tabPageSubquery.TabIndex = 2;
            this.tabPageSubquery.Text = "Примеры подзапросов";
            this.tabPageSubquery.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ExecuteButton);
            this.groupBox2.Controls.Add(this.NumberOrderTextBox);
            this.groupBox2.Controls.Add(this.OrderNumberLabel);
            this.groupBox2.Controls.Add(this.UncorrelatedSubqueryRadioButton);
            this.groupBox2.Controls.Add(this.CorrelatedSubqueryRadioButton);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(786, 121);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Подзапросы по данным";
            // 
            // OrderNumberLabel
            // 
            this.OrderNumberLabel.AutoSize = true;
            this.OrderNumberLabel.Location = new System.Drawing.Point(15, 80);
            this.OrderNumberLabel.Name = "OrderNumberLabel";
            this.OrderNumberLabel.Size = new System.Drawing.Size(84, 13);
            this.OrderNumberLabel.TabIndex = 2;
            this.OrderNumberLabel.Text = "Оценка заказа";
            // 
            // UncorrelatedSubqueryRadioButton
            // 
            this.UncorrelatedSubqueryRadioButton.AutoSize = true;
            this.UncorrelatedSubqueryRadioButton.Location = new System.Drawing.Point(223, 31);
            this.UncorrelatedSubqueryRadioButton.Margin = new System.Windows.Forms.Padding(15);
            this.UncorrelatedSubqueryRadioButton.Name = "UncorrelatedSubqueryRadioButton";
            this.UncorrelatedSubqueryRadioButton.Size = new System.Drawing.Size(188, 17);
            this.UncorrelatedSubqueryRadioButton.TabIndex = 1;
            this.UncorrelatedSubqueryRadioButton.TabStop = true;
            this.UncorrelatedSubqueryRadioButton.Text = "Некоррелированный подзапрос";
            this.UncorrelatedSubqueryRadioButton.UseVisualStyleBackColor = true;
            // 
            // CorrelatedSubqueryRadioButton
            // 
            this.CorrelatedSubqueryRadioButton.AutoSize = true;
            this.CorrelatedSubqueryRadioButton.Location = new System.Drawing.Point(18, 31);
            this.CorrelatedSubqueryRadioButton.Margin = new System.Windows.Forms.Padding(15);
            this.CorrelatedSubqueryRadioButton.Name = "CorrelatedSubqueryRadioButton";
            this.CorrelatedSubqueryRadioButton.Size = new System.Drawing.Size(175, 17);
            this.CorrelatedSubqueryRadioButton.TabIndex = 0;
            this.CorrelatedSubqueryRadioButton.TabStop = true;
            this.CorrelatedSubqueryRadioButton.Text = "Коррелированный подзапрос";
            this.CorrelatedSubqueryRadioButton.UseVisualStyleBackColor = true;
            // 
            // NumberOrderTextBox
            // 
            this.NumberOrderTextBox.Location = new System.Drawing.Point(105, 77);
            this.NumberOrderTextBox.Name = "NumberOrderTextBox";
            this.NumberOrderTextBox.Size = new System.Drawing.Size(310, 20);
            this.NumberOrderTextBox.TabIndex = 3;
            // 
            // ExecuteButton
            // 
            this.ExecuteButton.Location = new System.Drawing.Point(476, 75);
            this.ExecuteButton.Name = "ExecuteButton";
            this.ExecuteButton.Size = new System.Drawing.Size(133, 23);
            this.ExecuteButton.TabIndex = 4;
            this.ExecuteButton.Text = "Выполнить подзапрос";
            this.ExecuteButton.UseVisualStyleBackColor = true;
            this.ExecuteButton.Click += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 124);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(786, 297);
            this.dataGridView2.TabIndex = 1;
            // 
            // TabPageDML
            // 
            this.TabPageDML.Controls.Add(this.dataGridView3);
            this.TabPageDML.Controls.Add(this.panel1);
            this.TabPageDML.Controls.Add(this.groupBox3);
            this.TabPageDML.Location = new System.Drawing.Point(4, 22);
            this.TabPageDML.Name = "TabPageDML";
            this.TabPageDML.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageDML.Size = new System.Drawing.Size(792, 424);
            this.TabPageDML.TabIndex = 3;
            this.TabPageDML.Text = "Запросы изменения данных";
            this.TabPageDML.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ExecuteRequestButton);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.IdClientsTextBox);
            this.groupBox3.Controls.Add(this.DeleteRadioButton);
            this.groupBox3.Controls.Add(this.UpdateRadioButton);
            this.groupBox3.Controls.Add(this.InsertRadioButton);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(786, 119);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Операторы";
            // 
            // InsertRadioButton
            // 
            this.InsertRadioButton.AutoSize = true;
            this.InsertRadioButton.Location = new System.Drawing.Point(18, 42);
            this.InsertRadioButton.Margin = new System.Windows.Forms.Padding(15);
            this.InsertRadioButton.Name = "InsertRadioButton";
            this.InsertRadioButton.Size = new System.Drawing.Size(160, 17);
            this.InsertRadioButton.TabIndex = 0;
            this.InsertRadioButton.TabStop = true;
            this.InsertRadioButton.Text = "Добавить данные клиента";
            this.InsertRadioButton.UseVisualStyleBackColor = true;
            // 
            // UpdateRadioButton
            // 
            this.UpdateRadioButton.AutoSize = true;
            this.UpdateRadioButton.Location = new System.Drawing.Point(218, 42);
            this.UpdateRadioButton.Margin = new System.Windows.Forms.Padding(15);
            this.UpdateRadioButton.Name = "UpdateRadioButton";
            this.UpdateRadioButton.Size = new System.Drawing.Size(185, 17);
            this.UpdateRadioButton.TabIndex = 1;
            this.UpdateRadioButton.TabStop = true;
            this.UpdateRadioButton.Text = "Обновить данные клиента по id";
            this.UpdateRadioButton.UseVisualStyleBackColor = true;
            // 
            // DeleteRadioButton
            // 
            this.DeleteRadioButton.AutoSize = true;
            this.DeleteRadioButton.Location = new System.Drawing.Point(433, 42);
            this.DeleteRadioButton.Margin = new System.Windows.Forms.Padding(15);
            this.DeleteRadioButton.Name = "DeleteRadioButton";
            this.DeleteRadioButton.Size = new System.Drawing.Size(179, 17);
            this.DeleteRadioButton.TabIndex = 2;
            this.DeleteRadioButton.TabStop = true;
            this.DeleteRadioButton.Text = "Удалить данные клиента по id";
            this.DeleteRadioButton.UseVisualStyleBackColor = true;
            // 
            // IdClientsTextBox
            // 
            this.IdClientsTextBox.Location = new System.Drawing.Point(112, 80);
            this.IdClientsTextBox.Name = "IdClientsTextBox";
            this.IdClientsTextBox.Size = new System.Drawing.Size(100, 20);
            this.IdClientsTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Id клиента";
            // 
            // ExecuteRequestButton
            // 
            this.ExecuteRequestButton.Location = new System.Drawing.Point(309, 90);
            this.ExecuteRequestButton.Name = "ExecuteRequestButton";
            this.ExecuteRequestButton.Size = new System.Drawing.Size(143, 23);
            this.ExecuteRequestButton.TabIndex = 5;
            this.ExecuteRequestButton.Text = "Выполнить запрос";
            this.ExecuteRequestButton.UseVisualStyleBackColor = true;
            this.ExecuteRequestButton.Click += new System.EventHandler(this.ExecuteRequestButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.BalanceTextBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.PhoneTextBox);
            this.panel1.Controls.Add(this.SecondTextBox);
            this.panel1.Controls.Add(this.MiddleTextBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.NameTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 110);
            this.panel1.TabIndex = 1;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(3, 232);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(786, 189);
            this.dataGridView3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Имя";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(85, 11);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(117, 20);
            this.NameTextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Номер телефона";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Отчество";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Фамилия";
            // 
            // MiddleTextBox
            // 
            this.MiddleTextBox.Location = new System.Drawing.Point(85, 81);
            this.MiddleTextBox.Name = "MiddleTextBox";
            this.MiddleTextBox.Size = new System.Drawing.Size(117, 20);
            this.MiddleTextBox.TabIndex = 10;
            // 
            // SecondTextBox
            // 
            this.SecondTextBox.Location = new System.Drawing.Point(85, 46);
            this.SecondTextBox.Name = "SecondTextBox";
            this.SecondTextBox.Size = new System.Drawing.Size(117, 20);
            this.SecondTextBox.TabIndex = 11;
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Location = new System.Drawing.Point(359, 11);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(117, 20);
            this.PhoneTextBox.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(251, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Баланс";
            // 
            // BalanceTextBox
            // 
            this.BalanceTextBox.Location = new System.Drawing.Point(310, 46);
            this.BalanceTextBox.Name = "BalanceTextBox";
            this.BalanceTextBox.Size = new System.Drawing.Size(117, 20);
            this.BalanceTextBox.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(534, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 44);
            this.button1.TabIndex = 15;
            this.button1.Text = "Показать таблицу";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SQLTabControl);
            this.Name = "FormSQL";
            this.Text = "SQL запросы";
            this.SQLTabControl.ResumeLayout(false);
            this.ExampleTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SelectDataGridView)).EndInit();
            this.SelectGroupBox.ResumeLayout(false);
            this.SelectGroupBox.PerformLayout();
            this.SelectTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.FSelectGroupBox.ResumeLayout(false);
            this.FSelectGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPageSubquery.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.TabPageDML.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl SQLTabControl;
        private System.Windows.Forms.TabPage ExampleTabPage;
        private System.Windows.Forms.GroupBox SelectGroupBox;
        private System.Windows.Forms.RadioButton OrdersRadioButton;
        private System.Windows.Forms.RadioButton ClientsRadioButton;
        private System.Windows.Forms.RadioButton CarsRadioButton;
        private System.Windows.Forms.TabPage SelectTabPage;
        private System.Windows.Forms.DataGridView SelectDataGridView;
        private System.Windows.Forms.GroupBox FSelectGroupBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton PerAllTimeRadioButton;
        private System.Windows.Forms.RadioButton PerYearRadioButton;
        private System.Windows.Forms.RadioButton PerMonthRadioButton;
        private System.Windows.Forms.TextBox SelectProfitMoreTextBox;
        private System.Windows.Forms.CheckBox SelectMoreCheckBox;
        private System.Windows.Forms.TextBox SecondNameTextBox;
        private System.Windows.Forms.Label SecondNameLabel;
        private System.Windows.Forms.CheckBox SortDescCheckBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button SelectProfitButton;
        private System.Windows.Forms.TabPage tabPageSubquery;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label OrderNumberLabel;
        private System.Windows.Forms.RadioButton UncorrelatedSubqueryRadioButton;
        private System.Windows.Forms.RadioButton CorrelatedSubqueryRadioButton;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button ExecuteButton;
        private System.Windows.Forms.TextBox NumberOrderTextBox;
        private System.Windows.Forms.TabPage TabPageDML;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IdClientsTextBox;
        private System.Windows.Forms.RadioButton DeleteRadioButton;
        private System.Windows.Forms.RadioButton UpdateRadioButton;
        private System.Windows.Forms.RadioButton InsertRadioButton;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ExecuteRequestButton;
        private System.Windows.Forms.TextBox SecondTextBox;
        private System.Windows.Forms.TextBox MiddleTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PhoneTextBox;
        private System.Windows.Forms.TextBox BalanceTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}