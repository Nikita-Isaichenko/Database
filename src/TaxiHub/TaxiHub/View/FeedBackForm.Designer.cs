namespace TaxiHub.View
{
    partial class FeedBackForm
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FeedBackForm));
            System.Windows.Forms.Label ratingLabel;
            this.taxiCompanyDataSet = new TaxiHub.TaxiCompanyDataSet();
            this.feedBackBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.feedBackTableAdapter = new TaxiHub.TaxiCompanyDataSetTableAdapters.FeedBackTableAdapter();
            this.tableAdapterManager = new TaxiHub.TaxiCompanyDataSetTableAdapters.TableAdapterManager();
            this.feedBackBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.feedBackBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.ratingComboBox = new System.Windows.Forms.ComboBox();
            idLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            ratingLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.taxiCompanyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedBackBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedBackBindingNavigator)).BeginInit();
            this.feedBackBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(12, 34);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(12, 61);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(33, 13);
            dateLabel.TabIndex = 3;
            dateLabel.Text = "Date:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(12, 112);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 7;
            descriptionLabel.Text = "Description:";
            // 
            // taxiCompanyDataSet
            // 
            this.taxiCompanyDataSet.DataSetName = "TaxiCompanyDataSet";
            this.taxiCompanyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // feedBackBindingSource
            // 
            this.feedBackBindingSource.DataMember = "FeedBack";
            this.feedBackBindingSource.DataSource = this.taxiCompanyDataSet;
            // 
            // feedBackTableAdapter
            // 
            this.feedBackTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CarsTableAdapter = null;
            this.tableAdapterManager.ClientsTableAdapter = null;
            this.tableAdapterManager.DriversTableAdapter = null;
            this.tableAdapterManager.FeedBackTableAdapter = this.feedBackTableAdapter;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TaxiHub.TaxiCompanyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // feedBackBindingNavigator
            // 
            this.feedBackBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.feedBackBindingNavigator.BindingSource = this.feedBackBindingSource;
            this.feedBackBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.feedBackBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.feedBackBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.feedBackBindingNavigatorSaveItem});
            this.feedBackBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.feedBackBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.feedBackBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.feedBackBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.feedBackBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.feedBackBindingNavigator.Name = "feedBackBindingNavigator";
            this.feedBackBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.feedBackBindingNavigator.Size = new System.Drawing.Size(301, 25);
            this.feedBackBindingNavigator.TabIndex = 0;
            this.feedBackBindingNavigator.Text = "bindingNavigator1";
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
            // feedBackBindingNavigatorSaveItem
            // 
            this.feedBackBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.feedBackBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("feedBackBindingNavigatorSaveItem.Image")));
            this.feedBackBindingNavigatorSaveItem.Name = "feedBackBindingNavigatorSaveItem";
            this.feedBackBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.feedBackBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.feedBackBindingNavigatorSaveItem.Click += new System.EventHandler(this.feedBackBindingNavigatorSaveItem_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.feedBackBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(81, 31);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(54, 20);
            this.idTextBox.TabIndex = 2;
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.feedBackBindingSource, "Date", true));
            this.dateDateTimePicker.Location = new System.Drawing.Point(81, 57);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateDateTimePicker.TabIndex = 4;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.feedBackBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(81, 109);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionTextBox.Size = new System.Drawing.Size(200, 111);
            this.descriptionTextBox.TabIndex = 8;
            // 
            // ratingLabel
            // 
            ratingLabel.AutoSize = true;
            ratingLabel.Location = new System.Drawing.Point(12, 85);
            ratingLabel.Name = "ratingLabel";
            ratingLabel.Size = new System.Drawing.Size(41, 13);
            ratingLabel.TabIndex = 8;
            ratingLabel.Text = "Rating:";
            // 
            // ratingComboBox
            // 
            this.ratingComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.feedBackBindingSource, "Rating", true));
            this.ratingComboBox.FormattingEnabled = true;
            this.ratingComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.ratingComboBox.Location = new System.Drawing.Point(81, 82);
            this.ratingComboBox.Name = "ratingComboBox";
            this.ratingComboBox.Size = new System.Drawing.Size(54, 21);
            this.ratingComboBox.TabIndex = 9;
            // 
            // FeedBackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 240);
            this.Controls.Add(ratingLabel);
            this.Controls.Add(this.ratingComboBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dateDateTimePicker);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.feedBackBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FeedBackForm";
            this.Text = "FeedBack";
            this.Load += new System.EventHandler(this.FeedBackForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.taxiCompanyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedBackBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedBackBindingNavigator)).EndInit();
            this.feedBackBindingNavigator.ResumeLayout(false);
            this.feedBackBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TaxiCompanyDataSet taxiCompanyDataSet;
        private System.Windows.Forms.BindingSource feedBackBindingSource;
        private TaxiCompanyDataSetTableAdapters.FeedBackTableAdapter feedBackTableAdapter;
        private TaxiCompanyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator feedBackBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton feedBackBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.ComboBox ratingComboBox;
    }
}