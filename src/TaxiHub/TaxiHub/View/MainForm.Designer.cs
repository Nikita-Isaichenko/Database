namespace TaxiHub
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DriversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CarsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FeedBackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitContextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutContextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainToolStrip = new System.Windows.Forms.ToolStrip();
            this.ExitToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.AboutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.DriversToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.OrdersToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ClientsToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.CarsToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.FeedBackToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.связныеСправочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заказыКлиентовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip.SuspendLayout();
            this.MainContextMenuStrip.SuspendLayout();
            this.MainToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.BackColor = System.Drawing.Color.Gold;
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.HelpToolStripMenuItem,
            this.ReferencesToolStripMenuItem,
            this.связныеСправочникиToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(685, 24);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.FileToolStripMenuItem.Text = "Файл";
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Image = global::TaxiHub.Properties.Resources.free_icon_exit_603120;
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.ExitToolStripMenuItem.Text = "Выход";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripMenuItem});
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.HelpToolStripMenuItem.Text = "Справка";
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Image = global::TaxiHub.Properties.Resources.information;
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.O)));
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.AboutToolStripMenuItem.Text = "О программе";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // ReferencesToolStripMenuItem
            // 
            this.ReferencesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DriversToolStripMenuItem,
            this.OrdersToolStripMenuItem,
            this.ClientsToolStripMenuItem,
            this.CarsToolStripMenuItem,
            this.FeedBackToolStripMenuItem});
            this.ReferencesToolStripMenuItem.Name = "ReferencesToolStripMenuItem";
            this.ReferencesToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.ReferencesToolStripMenuItem.Text = "Справочники";
            // 
            // DriversToolStripMenuItem
            // 
            this.DriversToolStripMenuItem.Image = global::TaxiHub.Properties.Resources.free_icon_taxi_driver_1189447;
            this.DriversToolStripMenuItem.Name = "DriversToolStripMenuItem";
            this.DriversToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.DriversToolStripMenuItem.Text = "Водители";
            this.DriversToolStripMenuItem.Click += new System.EventHandler(this.DriversToolStripMenuItem_Click);
            // 
            // OrdersToolStripMenuItem
            // 
            this.OrdersToolStripMenuItem.Image = global::TaxiHub.Properties.Resources.free_icon_order_5220625;
            this.OrdersToolStripMenuItem.Name = "OrdersToolStripMenuItem";
            this.OrdersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.OrdersToolStripMenuItem.Text = "Заказы";
            this.OrdersToolStripMenuItem.Click += new System.EventHandler(this.OrdersToolStripMenuItem_Click);
            // 
            // ClientsToolStripMenuItem
            // 
            this.ClientsToolStripMenuItem.Image = global::TaxiHub.Properties.Resources.free_icon_passenger_1611682;
            this.ClientsToolStripMenuItem.Name = "ClientsToolStripMenuItem";
            this.ClientsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ClientsToolStripMenuItem.Text = "Клиенты";
            this.ClientsToolStripMenuItem.Click += new System.EventHandler(this.ClientsToolStripMenuItem_Click);
            // 
            // CarsToolStripMenuItem
            // 
            this.CarsToolStripMenuItem.Image = global::TaxiHub.Properties.Resources.taxi;
            this.CarsToolStripMenuItem.Name = "CarsToolStripMenuItem";
            this.CarsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.CarsToolStripMenuItem.Text = "Машины";
            this.CarsToolStripMenuItem.Click += new System.EventHandler(this.CarsToolStripMenuItem_Click);
            // 
            // FeedBackToolStripMenuItem
            // 
            this.FeedBackToolStripMenuItem.Image = global::TaxiHub.Properties.Resources.free_icon_review_8292169;
            this.FeedBackToolStripMenuItem.Name = "FeedBackToolStripMenuItem";
            this.FeedBackToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.FeedBackToolStripMenuItem.Text = "Отзывы";
            this.FeedBackToolStripMenuItem.Click += new System.EventHandler(this.FeedBackToolStripMenuItem_Click);
            // 
            // MainContextMenuStrip
            // 
            this.MainContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.AboutContextToolStripMenuItem});
            this.MainContextMenuStrip.Name = "MainContextMenuStrip";
            this.MainContextMenuStrip.Size = new System.Drawing.Size(150, 48);
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitContextToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // ExitContextToolStripMenuItem
            // 
            this.ExitContextToolStripMenuItem.Image = global::TaxiHub.Properties.Resources.free_icon_exit_603120;
            this.ExitContextToolStripMenuItem.Name = "ExitContextToolStripMenuItem";
            this.ExitContextToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.ExitContextToolStripMenuItem.Text = "Выход";
            this.ExitContextToolStripMenuItem.Click += new System.EventHandler(this.ExitContextToolStripMenuItem_Click);
            // 
            // AboutContextToolStripMenuItem
            // 
            this.AboutContextToolStripMenuItem.Image = global::TaxiHub.Properties.Resources.information;
            this.AboutContextToolStripMenuItem.Name = "AboutContextToolStripMenuItem";
            this.AboutContextToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.AboutContextToolStripMenuItem.Text = "О программе";
            this.AboutContextToolStripMenuItem.Click += new System.EventHandler(this.AboutContextToolStripMenuItem_Click);
            // 
            // MainToolStrip
            // 
            this.MainToolStrip.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.MainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitToolStripButton,
            this.AboutToolStripButton,
            this.DriversToolStripButton,
            this.OrdersToolStripButton,
            this.ClientsToolStripButton,
            this.CarsToolStripButton,
            this.FeedBackToolStripButton});
            this.MainToolStrip.Location = new System.Drawing.Point(0, 24);
            this.MainToolStrip.Name = "MainToolStrip";
            this.MainToolStrip.Size = new System.Drawing.Size(685, 25);
            this.MainToolStrip.TabIndex = 2;
            this.MainToolStrip.Text = "toolStrip1";
            // 
            // ExitToolStripButton
            // 
            this.ExitToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ExitToolStripButton.Image = global::TaxiHub.Properties.Resources.free_icon_exit_603120;
            this.ExitToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExitToolStripButton.Name = "ExitToolStripButton";
            this.ExitToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.ExitToolStripButton.Text = "toolStripButton1";
            this.ExitToolStripButton.ToolTipText = "Выход";
            this.ExitToolStripButton.Click += new System.EventHandler(this.ExitToolStripButton_Click);
            // 
            // AboutToolStripButton
            // 
            this.AboutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AboutToolStripButton.Image = global::TaxiHub.Properties.Resources.information;
            this.AboutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AboutToolStripButton.Name = "AboutToolStripButton";
            this.AboutToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.AboutToolStripButton.Text = "toolStripButton2";
            this.AboutToolStripButton.ToolTipText = "О программе";
            this.AboutToolStripButton.Click += new System.EventHandler(this.AboutToolStripButton_Click);
            // 
            // DriversToolStripButton
            // 
            this.DriversToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DriversToolStripButton.Image = global::TaxiHub.Properties.Resources.free_icon_taxi_driver_1189447;
            this.DriversToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DriversToolStripButton.Name = "DriversToolStripButton";
            this.DriversToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.DriversToolStripButton.Text = "Водители";
            this.DriversToolStripButton.Click += new System.EventHandler(this.DriversToolStripButton_Click);
            // 
            // OrdersToolStripButton
            // 
            this.OrdersToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OrdersToolStripButton.Image = global::TaxiHub.Properties.Resources.free_icon_order_5220625;
            this.OrdersToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OrdersToolStripButton.Name = "OrdersToolStripButton";
            this.OrdersToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.OrdersToolStripButton.Text = "toolStripButton2";
            this.OrdersToolStripButton.Click += new System.EventHandler(this.OrdersToolStripButton_Click);
            // 
            // ClientsToolStripButton
            // 
            this.ClientsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ClientsToolStripButton.Image = global::TaxiHub.Properties.Resources.free_icon_passenger_1611682;
            this.ClientsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ClientsToolStripButton.Name = "ClientsToolStripButton";
            this.ClientsToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.ClientsToolStripButton.Text = "toolStripButton3";
            this.ClientsToolStripButton.Click += new System.EventHandler(this.ClientsToolStripButton_Click);
            // 
            // CarsToolStripButton
            // 
            this.CarsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CarsToolStripButton.Image = global::TaxiHub.Properties.Resources.taxi;
            this.CarsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CarsToolStripButton.Name = "CarsToolStripButton";
            this.CarsToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.CarsToolStripButton.Text = "toolStripButton5";
            this.CarsToolStripButton.Click += new System.EventHandler(this.CarsToolStripButton_Click);
            // 
            // FeedBackToolStripButton
            // 
            this.FeedBackToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FeedBackToolStripButton.Image = global::TaxiHub.Properties.Resources.free_icon_review_8292169;
            this.FeedBackToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FeedBackToolStripButton.Name = "FeedBackToolStripButton";
            this.FeedBackToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.FeedBackToolStripButton.Text = "toolStripButton4";
            this.FeedBackToolStripButton.Click += new System.EventHandler(this.FeedBackToolStripButton_Click);
            // 
            // связныеСправочникиToolStripMenuItem
            // 
            this.связныеСправочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.заказыКлиентовToolStripMenuItem});
            this.связныеСправочникиToolStripMenuItem.Name = "связныеСправочникиToolStripMenuItem";
            this.связныеСправочникиToolStripMenuItem.Size = new System.Drawing.Size(142, 20);
            this.связныеСправочникиToolStripMenuItem.Text = "Связные справочники";
            // 
            // заказыКлиентовToolStripMenuItem
            // 
            this.заказыКлиентовToolStripMenuItem.Name = "заказыКлиентовToolStripMenuItem";
            this.заказыКлиентовToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.заказыКлиентовToolStripMenuItem.Text = "Заказы клиентов";
            this.заказыКлиентовToolStripMenuItem.Click += new System.EventHandler(this.заказыКлиентовToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 389);
            this.ContextMenuStrip = this.MainContextMenuStrip;
            this.Controls.Add(this.MainToolStrip);
            this.Controls.Add(this.MenuStrip);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::TaxiHub.Properties.Settings.Default, "FormPosition", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = global::TaxiHub.Properties.Settings.Default.FormPosition;
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "MainForm";
            this.Text = "TaxiHub";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.MainContextMenuStrip.ResumeLayout(false);
            this.MainToolStrip.ResumeLayout(false);
            this.MainToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip MainContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitContextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutContextToolStripMenuItem;
        private System.Windows.Forms.ToolStrip MainToolStrip;
        private System.Windows.Forms.ToolStripButton ExitToolStripButton;
        private System.Windows.Forms.ToolStripButton AboutToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem ReferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DriversToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OrdersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CarsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FeedBackToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton DriversToolStripButton;
        private System.Windows.Forms.ToolStripButton OrdersToolStripButton;
        private System.Windows.Forms.ToolStripButton ClientsToolStripButton;
        private System.Windows.Forms.ToolStripButton FeedBackToolStripButton;
        private System.Windows.Forms.ToolStripButton CarsToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem связныеСправочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заказыКлиентовToolStripMenuItem;
    }
}

