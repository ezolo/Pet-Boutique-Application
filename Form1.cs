//Programmer: Eva Zolotarev
//Program: Lab #3
//Date: 2/24/2020
//Class: ISM 3232
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        //Declare class-level constants for later use in the programs
        private const decimal FLEA_REMOVAL_PRICE = 5.00m;
        private const decimal NAIL_CLIPPING_PRICE = 4.50m;
        private const decimal SHAMPOO_PRICE = 4.00m;
        private const decimal FUR_TRIMMING_PRICE = 9.00m;

        public Form1()
        {
            InitializeComponent();
        }



        private void otherButton_CheckedChanged(object sender, EventArgs e)
        {
            if  (otherButton.Checked)
            {
                otherLabel.Enabled = true;
                petTypeTextBox.Enabled = true;
                petTypeTextBox.Focus();
            }
            else
            {
                otherLabel.Enabled = false;
                petTypeTextBox.Enabled = false;
                petTypeTextBox.Text = ""; //Clear contents of this control
            }
        }

        private void totalButton_Click(object sender, EventArgs e)
        {
            decimal totalOutputFee = 0.00m;

            //deals with the checked boxes
            if (fleaCheckBox.Checked)
            {
                totalOutputFee += FLEA_REMOVAL_PRICE;
            }
            if (nailClippingCheckBox.Checked)
            {
                totalOutputFee += NAIL_CLIPPING_PRICE;
            }
            if (shampooCheckBox.Checked)
            {
                totalOutputFee += SHAMPOO_PRICE;
            }
            if (furTrimmingCheckBox.Checked)
            {
                totalOutputFee += FUR_TRIMMING_PRICE;
            }
            //Display the total fee in the label
            feeOutputLabel.Text = totalOutputFee.ToString("c");

            //Send focus to the clear button
            clearButton.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Assign the service price values to labels on form 
            fleaRemovalLabel.Text = FLEA_REMOVAL_PRICE.ToString("c");
            nailClippingLabel.Text = NAIL_CLIPPING_PRICE.ToString("c");
            shampooLabel.Text = SHAMPOO_PRICE.ToString("c");
            furTrimmingLabel.Text = FUR_TRIMMING_PRICE.ToString("c");
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //clears everything, entered before
            ownerNameTextBox.Text = "";
            ownerPhoneTextBox.Text = "";
            petNameTextBox.Text = "";
            dobTextBox.Text = "";
            catButton.Checked = true;
            fleaCheckBox.Checked = false;
            nailClippingCheckBox.Checked = false;
            shampooCheckBox.Checked = false;
            furTrimmingCheckBox.Checked = false;
            feeOutputLabel.Text = "";

            //Send focus to first data entry control form
            ownerNameTextBox.Focus();
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            //closes program
            this.Close();
        }
    }
}
