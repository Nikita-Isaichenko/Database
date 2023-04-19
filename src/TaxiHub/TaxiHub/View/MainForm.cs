using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaxiHub.Properties;
using TaxiHub.Services;
using TaxiHub.View;

namespace TaxiHub
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ShowForm(Form form)
        {
            form.Show();
            form.Activate();
        }

        private void AboutText(string about)
        {
            MessageBox.Show(about,
                            "О программе",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = MessageBox.Show(
                                       "Вы хотите закрыть программу?",
                                       "Внимание",
                                       MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Question) !=
                                       DialogResult.Yes;

            Settings.Default.Save();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutText("(C) Исайченко Никита, 571-2, 2023");
        }

        private void ExitContextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AboutContextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutText("(C) Исайченко Никита, 571-2, 2023");
        }

        private void ExitToolStripButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AboutToolStripButton_Click(object sender, EventArgs e)
        {
            AboutText("(C) Исайченко Никита, 571-2, 2023");
        }

        private void DriversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(SingletonFactoryForm.DriversForm);
        }

        private void DriversToolStripButton_Click(object sender, EventArgs e)
        {
            ShowForm(SingletonFactoryForm.DriversForm);
        }

        private void OrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void OrdersToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void ClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ClientsToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void CarsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(SingletonFactoryForm.CarsForm);
        }

        private void CarsToolStripButton_Click(object sender, EventArgs e)
        {
            ShowForm(SingletonFactoryForm.CarsForm);
        }

        private void FeedBackToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FeedBackToolStripButton_Click(object sender, EventArgs e)
        {

        }
    }
}
