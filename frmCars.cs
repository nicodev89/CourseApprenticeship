using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace AssignmentNicoloRossi
{
    public partial class frmCars : Form
    {
        // Declaring a DAO object, a list of Car and a index as global variables
        private CarsDAO DAO;
        private List<Car> CarList;
        private int currentIndex = 0;

        public frmCars()
        {
            InitializeComponent();
            DAO = new CarsDAO();
            CarList = new List<Car>();
        }

        private void frmCars_Load(object sender, EventArgs e)
        {
            GetDataFromDB();
        }


        // this method use the DAO object to retrieve data from the table and populate the list of Cars
        public void GetDataFromDB()
        {
            CarList = DAO.SelectAll(out string error);

            //if the string error is not empty there is some issue. Will be displayed to user
            if (error.Equals(String.Empty))
            {
                PopulateForm();
            }
            else
            {
                MessageBox.Show("Error found:\n " + error, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        public void PopulateForm()
        {
            // using the list of Car the form will be filled and the label with the record number
            // N of NN will be updated as well
            if (CarList.Count > 0)
            {
                TxBRegistNum.Text = CarList[currentIndex].VehicleRegNo;

                TxBMake.Text = CarList[currentIndex].Make;
                TxBEngine.Text = CarList[currentIndex].EngineSize;
                TxBPrice.Text = CarList[currentIndex].RentalPerDay.ToString("C");
                DtTPkDate.Value = CarList[currentIndex].DateRegistered;
                CbxAvailability.Checked = CarList[currentIndex].Available;

                LblRecordNofN.Text = $"{currentIndex + 1} of {CarList.Count}";
            }
            else
            {
                MessageBox.Show("The list of car is empty at the moment, please insert data in DB", "No car to show",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (currentIndex < CarList.Count - 1)
            {
                currentIndex++;
                PopulateForm();
            }
        }

        private void BtnPrev_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                PopulateForm();
            }
        }

        private void BtnFirst_Click(object sender, EventArgs e)
        {
            currentIndex = 0;
            PopulateForm();
        }

        private void BtnLast_Click(object sender, EventArgs e)
        {
            currentIndex = CarList.Count - 1;
            PopulateForm();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            PopulateForm();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Exit application?\nAll changes not saved will be lost."
                , "Are you sure?", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        //this method update a value
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            String RegistrationNumber = CarList[currentIndex].VehicleRegNo.ToLower();
            if (RegistrationNumber.Equals(TxBRegistNum.Text.ToLower()))
            {
                Car UpdatedCar = CreateCarFromForm(out string ErrorMessage);
                if (UpdatedCar != null)
                {
                    if (DAO.PerformNonQuery(query: "Update", out string ErrorWithQuery, UpdatedCar))
                    {
                        MessageBox.Show("Car data updated successfully");
                        GetDataFromDB();
                    }
                    else
                    {
                        MessageBox.Show(ErrorWithQuery, "Error in the query", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                else
                {
                    MessageBox.Show(ErrorMessage, "Error in the fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("Car Registration number cannot be update", "Error in the fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method to add a new car to the database
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Car NewCar = CreateCarFromForm(out string ErrorMessage);

            if (NewCar != null)
            {
                if (DAO.PerformNonQuery(query: "Insert", out string ErrorWithQuery, NewCar))
                {
                    MessageBox.Show("The car was added to the database", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    currentIndex = 0;
                    GetDataFromDB();
                }
                else
                {
                    MessageBox.Show(ErrorWithQuery, "Execution error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(ErrorMessage, "Cannot insert data from form", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // this method takes data from the form and return a Car object (null if there are errors)
        // It will check if all fields have values and return a String with error message
        // (empty if all fields are ok)
        private Car CreateCarFromForm(out string Message)
        {
            Car car = new Car();
            Message = VerifyValues(out decimal Price);

            if (Message.Equals(String.Empty))
            {
                car.VehicleRegNo = TxBRegistNum.Text;
                car.Make = TxBMake.Text;
                car.EngineSize = TxBEngine.Text;
                car.RentalPerDay = Price;
                car.DateRegistered = DtTPkDate.Value;
                car.Available = CbxAvailability.Checked;

            }
            else
            {
                car = null;
            }

            return car;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {

            // ask confirmation to the user
            if (MessageBox.Show("Are you sure you want to delete permanently this record?\n\n" +
                "This operation cannot be reversed", "Delete this record?", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning) == DialogResult.OK)
            {
                if (DAO.PerformNonQuery(query: "Delete", out string error, RegNum: TxBRegistNum.Text) == true)
                {
                    MessageBox.Show("Car record deleted successfully");
                    if (currentIndex >= CarList.Count - 1)
                    {
                        currentIndex--;

                    }
                    GetDataFromDB();

                }
                else
                {
                    MessageBox.Show(error, "Error in the query", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // this method only verify that values in the form are correct.
        // returns a string with errors (or empty) and a decimal for the parced
        // value of the Price of the car rent
        private string VerifyValues(out decimal Price)
        {

            string Message = "";
            if (TxBRegistNum.Text.Equals(String.Empty) || TxBRegistNum.Text.Length != 8)
            {
                Message += "Registation Number needs to be 8 characters long \n";
            }
            if (TxBMake.Text.Equals(String.Empty))
            {
                Message += "Make cannot be empty \n";
            }
            if (!Decimal.TryParse(TxBPrice.Text, NumberStyles.Currency,
                CultureInfo.CurrentCulture.NumberFormat, out decimal price))
            {
                Message += "price value cannot be parsed";
            }
            if (TxBEngine.Text.Equals(String.Empty))
            {
                Message += "Engine size cannot be empty";
            }
            Price = price;
            return Message;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            FrmSearch search = new FrmSearch();
            search.Show();
        }
    }
}
