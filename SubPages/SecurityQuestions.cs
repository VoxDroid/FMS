using Bunifu.UI.WinForms;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SPAAT.SubPages
{
    public partial class SecurityQuestions : UserControl
    {
        private List<string> allQuestions;
        private string initialOption = "-- Select Security Question --";
        private bool isUpdating = false;

        public SecurityQuestions()
        {
            InitializeComponent();

            allQuestions = new List<string>
            {
                "What is the name of your first pet?",
                "In which city were you born?",
                "What is your mother's maiden name?",
                "What is the name of your favorite childhood teacher?",
                "What is the model of your first car?",
                "What is the name of your favorite book?",
                "What is the name of your best friend from childhood?",
                "What is the make of your first computer or laptop?",
                "What was the street you lived on in third grade?",
                "In which year did you graduate from high school?",
                "What is your favorite movie?",
                "What is the name of the street you grew up on?",
                "What is your favorite color?",
                "In which country would you like to retire?",
                "What is the name of the company where you had your first job?",
                "What is your favorite sports team?",
                "What is the middle name of your oldest sibling?",
                "What is the name of the elementary school you attended?",
                "What is the last name of your favorite high school teacher?",
                "What is your favorite holiday destination?"
            };

            InitializeComboBox(sq1);
            InitializeComboBox(sq2);
            InitializeComboBox(sq3);

            sq1.SelectedIndexChanged += (s, e) => UpdateComboBoxItems(sq1, sq2, sq3);
            sq2.SelectedIndexChanged += (s, e) => UpdateComboBoxItems(sq2, sq1, sq3);
            sq3.SelectedIndexChanged += (s, e) => UpdateComboBoxItems(sq3, sq1, sq2);
        }

        private void InitializeComboBox(Guna2ComboBox comboBox)
        {
            comboBox.Items.Add(initialOption);
            comboBox.Items.AddRange(allQuestions.ToArray());
            comboBox.SelectedItem = initialOption;
        }

        private void UpdateComboBoxItems(Guna2ComboBox currentComboBox, params Guna2ComboBox[] dependentComboBoxes)
        {
            if (isUpdating) return;

            isUpdating = true;

            foreach (Guna2ComboBox dependentComboBox in dependentComboBoxes)
            {
                if (dependentComboBox != currentComboBox)
                {
                    string selectedInDependent = dependentComboBox.SelectedItem?.ToString();

                    dependentComboBox.Items.Clear();
                    dependentComboBox.Items.AddRange(allQuestions.ToArray());
                    dependentComboBox.Items.Insert(0, initialOption);

                    if (selectedInDependent != null && dependentComboBox.Items.Contains(selectedInDependent))
                    {
                        dependentComboBox.SelectedItem = selectedInDependent;
                    }
                    else
                    {
                        dependentComboBox.SelectedItem = initialOption;
                    }
                }
            }

            isUpdating = false;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            var mainForm = this.ParentForm as Main;

            if (mainForm != null)
            {
                BunifuPages pagesControl = mainForm.GetPagesControl();

                if (pagesControl != null)
                {
                    pagesControl.SelectedIndex = 9;
                }
            }
        }
    }
}