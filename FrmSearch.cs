using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentNicoloRossi
{
    public partial class FrmSearch : Form
    {
        CarsDAO DAO;
        public FrmSearch()
        {
            InitializeComponent();
            DAO = new CarsDAO();
        }

        // values for the drop down combox will be added when the form is loaded
        private void FrmSearch_Load(object sender, EventArgs e)
        {

            CmBxColumn.Items.Add("VehicleRegNo");
            CmBxColumn.Items.Add("Make");
            CmBxColumn.Items.Add("EngineSize");
            CmBxColumn.Items.Add("DateRegistered");
            CmBxColumn.Items.Add("RentalPerDay");
            CmBxColumn.Items.Add("Available");

        }


        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        // changing operators available based on the column selected since some column contains varchars and
        // in some cases wouldn't make sense the research
        private void CmBxColumn_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmBxOperator.Items.Clear();
            CmBxOperator.Text = "";
            LblInfo.Text = "";
            switch (CmBxColumn.SelectedIndex)
            {
                //strings and bool that can be compared with = and !=
                case 0:
                case 1:
                case 5:
                    CmBxOperator.Items.Add("=");
                    CmBxOperator.Items.Add("!=");
                    break;
 
                // others like date or the size can use also other operators
                case 4:
                case 3:
                case 2:
                    CmBxOperator.Items.Add("=");
                    CmBxOperator.Items.Add("!=");
                    CmBxOperator.Items.Add(">=");
                    CmBxOperator.Items.Add(">");
                    CmBxOperator.Items.Add("<");
                    CmBxOperator.Items.Add("<=");
                    break;
                // if CarEngine will be selected user need to be told how to insert it correctly
                // so that operators can work properly.
                // Even if it is a string the comparison can be made correctly if user type correctly

                default:
                    break;
            }

            // informing user on correct input
            if (CmBxColumn.SelectedIndex == 0)
            {
                LblInfo.Text = "Insert the Registration number of 8 alphanumeric characters (ex:BV557UTR)";
            }
            else if (CmBxColumn.SelectedIndex == 1)
            {
                LblInfo.Text = "Insert the brand of the vehicle (ex: Mazda)";

            }
            else if (CmBxColumn.SelectedIndex == 2)
            {
                LblInfo.Text = "Insert a value in Litres(ex: 1.5L or 1.2L)";

            }
            else if (CmBxColumn.SelectedIndex == 3)
            {
                LblInfo.Text = "Insert a date in format YYYY/MM/DD (ex: 2007/03/24)";

            }
            else if (CmBxColumn.SelectedIndex == 4)
            {
                LblInfo.Text = "Insert only numbers with point as decimal separator (ex: 100.30)";

            }
            else if (CmBxColumn.SelectedIndex == 5)
            {
                LblInfo.Text = "Insert True or 1 for Available and False or 0 for Not Available";

            }

        }

        // this event will check that everything is ok before sending the research request
        // to the DB with the CarsDAO method and displaying the Dataset
        private void BtnRun_Click(object sender, EventArgs e)
        {
            string Message = "";
            string Column = "";
            string LogicalOperator = "";
            string Value = "";


            // following if statement will check that everything is fine with the values selected

            if (CmBxColumn.SelectedIndex < 0)
            {
                Message += "No column value selected\n";
            }
            if (CmBxOperator.SelectedIndex < 0)
            {
                Message += "No operator selected\n";
            }

            if (TxBxValue.Text.Equals(String.Empty))
            {
                Message += "You need to insert a value";
            }
            if (CmBxColumn.SelectedIndex == 4 
                && decimal.TryParse(TxBxValue.Text, out decimal price) == false)
            {
                Message += "Error parsing the value for the price";
            }

            // if there are no error proceed with query
            if (Message.Length == 0) 
            {
                Column = CmBxColumn.Text;
                LogicalOperator = CmBxOperator.Text;
                Value = TxBxValue.Text;
                DataSet data = DAO.Search(Column, LogicalOperator, Value, out bool success);

                if (!success)
                {
                    MessageBox.Show("It wasn't possible to complete the query. Verify the input are in correct format", 
                        "Error with Database request",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                else
                {
                    dataGridView1.DataSource = data;
                    dataGridView1.DataMember = "Data result";
                }
                
            }
            else
            {
                MessageBox.Show(Message, "Error in the fields",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void LblEngSize_Click(object sender, EventArgs e)
        {

        }
    }
}
