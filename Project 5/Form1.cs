using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_5
{
    public partial class Form1 : Form
    {
        
        /*
         * A basic auto repair shop made for a C# class at TCC
         * 
         * Arick Mounts
         */
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double SaLD = 0;
            SaLD += oilLubeCharges();
            SaLD += flushCharges();
            SaLD += miscCharges();
            SaLD += otherCharges();
            SandLText.Text = SaLD.ToString("C");
            partsText.Text = partsCharges().ToString("C");
            TaxText.Text = taxCalc(partsCharges()).ToString("C");
            feesText.Text = totalCalc(SaLD, partsCharges(), taxCalc(partsCharges())).ToString("C");

        }

        private double totalCalc(double service, double parts, double tax)
        {
            return service + parts + tax;
        }

        private double taxCalc(double parts)
        {
            return parts * .06;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            clearFees();
            clearFlushes();
            clearMisc();
            clearOilLube();
            clearOther();
        }

        private void clearFees()
        {
            SandLText.Text = "";
            partsText.Text = "";
            TaxText.Text = "";
            feesText.Text = "";

        }

        private void clearOilLube()
        {
            lubeJob.Checked = false;
            oilChange.Checked = false;
        }
        private void clearFlushes()
        {
            radiatorFlush.Checked = false;
            transmissionFlush.Checked = false;
        }
        private void clearMisc()
        {
            inspection.Checked = false;
            replaceMuffler.Checked = false;
            tireRotation.Checked = false;
        }
        private void clearOther()
        {
            partsNum.Value = 0;
            laborNum.Value = 0;
        }

        private double oilLubeCharges()
        {
            double SandLDoub = 0;
            if (oilChange.Checked)
            {
                SandLDoub += 26.00;
            }
            if (lubeJob.Checked)
            {
                SandLDoub += 18.00;

            }
            return SandLDoub;
        }

        private double flushCharges()
        {
            double flushCharges = 0;
            if (radiatorFlush.Checked)
            {
                flushCharges += 30.00;
            }
            if (transmissionFlush.Checked)
            {
                flushCharges += 80.00;
            }
            return flushCharges;
        }

        private double miscCharges()
        {
            double miscCharges = 0;
            if (inspection.Checked)
            {
                miscCharges += 15.00;
            }
            if (replaceMuffler.Checked)
            {
                miscCharges += 100.00;
            }
            if (tireRotation.Checked)
            {
                miscCharges += 20.00;
            }
            return miscCharges;
        }

        private double partsCharges()
        {
            return (double)partsNum.Value;
        }

        private double otherCharges()
        {
            return (double)laborNum.Value;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void laborNum_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
