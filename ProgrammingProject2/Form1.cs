using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammingProject2
{
    public partial class steakOrderForm : Form
    {
        public steakOrderForm()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            string meat = "";
            string selectedTemperature = "";
            string selectedTopper1 = "";
            string selectedTopper2 = "";

            if (cutsListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select your preferred cut of steak.");
            }

            if (!mediumRareRadioButton.Checked && !slightlyUnderMRRadioButton.Checked)
            {
                MessageBox.Show("Please select your preferred temperature.");
            }

            if (cutsListBox.SelectedIndex != -1)
            {
                meat = cutsListBox.SelectedItem.ToString();

                if (mediumRareRadioButton.Checked)
                {
                    selectedTemperature = "medium rare";
                }

                if (slightlyUnderMRRadioButton.Checked)
                {
                    selectedTemperature = "slightly under medium rare";
                }

                if (mushroomCheckbox.Checked)
                {
                    selectedTopper1 = "mushrooms";
                }
                else
                {
                    selectedTopper1 = "";
                }

                if (shrimpCheckbox.Checked)
                {
                    selectedTopper2 = "shrimp";
                }
                else
                {
                    selectedTopper2 = "";
                }

                if (!mushroomCheckbox.Checked && !shrimpCheckbox.Checked && cutsListBox.SelectedIndex != -1 && (mediumRareRadioButton.Checked || slightlyUnderMRRadioButton.Checked))
                {
                    orderLabel.Text = "You have ordered" + meat + ", cooked " + selectedTemperature + ", and no toppers.\n" +
                        "Thank You!";
                }

                if (mushroomCheckbox.Checked && !shrimpCheckbox.Checked && cutsListBox.SelectedIndex != -1 && (mediumRareRadioButton.Checked || slightlyUnderMRRadioButton.Checked))
                {
                    orderLabel.Text = "You have ordered" + meat + ", cooked " + selectedTemperature + ", and " + selectedTopper1 + "\n"
                        + "Thank You!";
                }

                if (!mushroomCheckbox.Checked && shrimpCheckbox.Checked && cutsListBox.SelectedIndex != -1 && (mediumRareRadioButton.Checked || slightlyUnderMRRadioButton.Checked))
                {
                    orderLabel.Text = "You have ordered" + meat + ", cooked " + selectedTemperature + ", and " + selectedTopper2 + "\n"
                        + "Thank You!";
                }

                if (mushroomCheckbox.Checked && shrimpCheckbox.Checked && cutsListBox.SelectedIndex != -1 && (mediumRareRadioButton.Checked || slightlyUnderMRRadioButton.Checked))
                {
                    orderLabel.Text = "You have ordered" + meat + ", cooked " + selectedTemperature + ", and " + selectedTopper1 + " and " + selectedTopper2 + "\n"
                        + "Thank You!";
                }

            }

           

            
         }

            
        

        private void button2_Click(object sender, EventArgs e)
        {
            orderLabel.Text = "";
        }
    }
}

