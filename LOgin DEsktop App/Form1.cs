using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace LOgin_DEsktop_App
{
    public partial class Form1 : Form
    {

        string patternNameAndSurname = @"^[A-Za-z]+$";
        string patternNumber = @"^\+\d{3}\d{3}\d{6}$";



        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

            radioBtMale.Checked = true;

        }



        private void buttonLoad_Click(object sender, EventArgs e)
        {
            string userNameFile = textBoxSearchName.Text + ".json";
            try
            {
                using FileStream fs = new FileStream(userNameFile, FileMode.Open);
                fs.Close();
                string user = File.ReadAllText(userNameFile);
                User? checkUser = Newtonsoft.Json.JsonConvert.DeserializeObject<User>(user);
                if (checkUser != null)
                {
                    textBoxSurname.Text = checkUser.Property_Surname;
                    textBoxName.Text = checkUser.Property_Name;
                    textBoxCounty.Text = checkUser.Property_Country;
                    textBoxCity.Text = checkUser.Property_City;
                    textBoxTelNum.Text = checkUser.Property_Phone;
                    dateTimePickerBith.Text = checkUser.Property_Date;
                    if (checkUser.Property_Gender != null)
                    {
                        checkUser.Property_Gender.ToLower();
                        if (checkUser.Property_Gender == "male")
                        {
                            radioBtMale.Checked = true;
                        }
                        if (checkUser.Property_Gender == "female")
                        {
                            radioBtFamale.Checked = true;
                        }

                    }

                }
                fs.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void textBoxSearchName_TextChanged(object sender, EventArgs e)
        {
            buttonLoad.Enabled = true;
            if (textBoxSearchName.Text == "")
            {
                buttonLoad.Enabled = false;

            }
        }

        private void textBoxSurname_TextChanged(object sender, EventArgs e)
        {
            textBoxSearchName.Text = "";
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            textBoxSearchName.Text = "";

        }

        private void textBoxCounty_TextChanged(object sender, EventArgs e)
        {
            textBoxSearchName.Text = "";

        }

        private void textBoxCity_TextChanged(object sender, EventArgs e)
        {
            textBoxSearchName.Text = "";

        }

        private void textBoxTelNum_TextChanged(object sender, EventArgs e)
        {
            textBoxSearchName.Text = "";

        }

        private void dateTimePickerBith_ValueChanged(object sender, EventArgs e)
        {
            textBoxSearchName.Text = "";

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            bool check = true;
            if (textBoxSurname.Text == "")
            {
                MessageBox.Show("Surname can not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                check = false;

            }

            if (textBoxName.Text == "")
            {
                MessageBox.Show("Name can not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                check = false;

            }

            if (textBoxCounty.Text == "")
            {
                MessageBox.Show("Country can not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                check = false;

            }
            if (textBoxCity.Text == "")
            {
                MessageBox.Show("City can not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                check = false;
            }
            if (textBoxTelNum.Text == "")
            {
                MessageBox.Show("Phone number can not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                check = false;

            }

            if (!Regex.IsMatch(textBoxSurname.Text, patternNameAndSurname))
            {
                MessageBox.Show("Wrong surname type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                check = false;

            }

            if (!Regex.IsMatch(textBoxName.Text, patternNameAndSurname))
            {
                MessageBox.Show("Wrong name type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                check = false;
            }
            if (!Regex.IsMatch(textBoxTelNum.Text, patternNumber))
            {
                MessageBox.Show("Wrong phone number type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                check = false;
            }

            if (check)
            {
                string userFileName = textBoxName.Text + ".json";
                if (radioBtFamale.Checked)
                {
                    try
                    {
                        using FileStream fs = new FileStream(userFileName, FileMode.Open);
                        MessageBox.Show("File with this name now exists ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxSurname.Text = "";
                        textBoxName.Text = "";
                        textBoxCounty.Text = "";
                        textBoxCity.Text = "";
                        textBoxTelNum.Text = "";
                        dateTimePickerBith.Text = "";
                        radioBtMale.Checked = true;
                        fs.Close();

                    }
                    catch (Exception)
                    {

                        User newUser = new User(textBoxSurname.Text, textBoxName.Text, textBoxCounty.Text, textBoxCity.Text, textBoxTelNum.Text, dateTimePickerBith.Text, "Female");
                        using FileStream fs = new FileStream(userFileName, FileMode.Create);
                        fs.Close();

                        JsonSerializerOptions options = new JsonSerializerOptions();
                        options.WriteIndented = true;

                        File.WriteAllText(userFileName, JsonSerializer.Serialize(newUser, options));
                        MessageBox.Show("Your data successfully saved", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBoxSurname.Text = "";
                        textBoxName.Text = "";
                        textBoxCounty.Text = "";
                        textBoxCity.Text = "";
                        textBoxTelNum.Text = "";
                        dateTimePickerBith.Text = "";

                        radioBtMale.Checked = true;
                        fs.Close();

                    }


                }
                else
                {
                    try
                    {
                        using FileStream fs = new FileStream(userFileName, FileMode.Open);
                        MessageBox.Show("File with this name now exists ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxSurname.Text = "";
                        textBoxName.Text = "";
                        textBoxCounty.Text = "";
                        textBoxCity.Text = "";
                        textBoxTelNum.Text = "";
                        dateTimePickerBith.Text = "";

                        radioBtMale.Checked = true;
                        fs.Close();
                    }
                    catch (Exception)
                    {

                        User newUser = new User(textBoxSurname.Text, textBoxName.Text, textBoxCounty.Text, textBoxCity.Text, textBoxTelNum.Text, dateTimePickerBith.Text, "Male");
                        using FileStream fs = new FileStream(userFileName, FileMode.Create);
                        fs.Close();
                        JsonSerializerOptions options = new JsonSerializerOptions();
                        options.WriteIndented = true;

                        File.WriteAllText(userFileName, JsonSerializer.Serialize(newUser, options));
                        MessageBox.Show("Your data successfully saved", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBoxSurname.Text = "";
                        textBoxName.Text = "";
                        textBoxCounty.Text = "";
                        textBoxCity.Text = "";
                        textBoxTelNum.Text = "";
                        dateTimePickerBith.Text = "";

                        radioBtMale.Checked = true;
                        fs.Close();

                    }

                }
            }
          

        }
    }
}