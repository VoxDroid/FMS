using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SPAAT.Pages
{
    public partial class Dashboard : UserControl
    {

        string connet = "Server=localhost;Database=fms;Username=root;Password=;";
        public Dashboard()
        {
            InitializeComponent();
            CalculateAndDisplayTotalRemainingBudget();
            CalculateAndDisplayTotalFunds();
        }

        private void budgetremainlabel_Click(object sender, EventArgs e)
        {

        }

        private void UpdateTheSelectedItemButton_Click(object sender, EventArgs e)
        {
            CalculateAndDisplayTotalRemainingBudget();
        }

        private void CalculateAndDisplayTotalRemainingBudget()
        {
            string sqlSelectTotalRemaining = "SELECT SUM(remaining) FROM budman";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connet))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(sqlSelectTotalRemaining, connection))
                    {
                        object result = command.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            decimal totalRemaining = Convert.ToDecimal(result);
                            budgetremainlabel.Text = $"Total Remaining Budget: {Environment.NewLine} ₱{totalRemaining:n0}";
                        }
                        else
                        {
                            budgetremainlabel.Text = "Total Remaining Budget: N/A";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void CalculateAndDisplayTotalFunds()
        {
            string sqlSelectTotalRemaining = "SELECT SUM(amount) FROM tranlo";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connet))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(sqlSelectTotalRemaining, connection))
                    {
                        object result = command.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            decimal totalRemaining = Convert.ToDecimal(result);
                            totalfundslabel.Text = $"Total Funds: {Environment.NewLine} ₱{totalRemaining:n0}";
                        }
                        else
                        {
                            totalfundslabel.Text = "Total Funds: N/A";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            CalculateAndDisplayTotalRemainingBudget();
            CalculateAndDisplayTotalFunds();
        }
    }
}
