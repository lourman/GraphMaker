using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphMaker
{
    public partial class FormGraphMaker : Form
    {
        // Fields to store all inputs needed for creating the graph
        List<int> data = new List<int>();
        List<string> categories = new List<string>();
        string graphTitle = "";
        string xAxisName = "";
        string yAxisName = "";

        /// <summary>
        /// Constructor of Form 
        /// </summary>
        public FormGraphMaker()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Verifying method for input data. Makes sure that they are separated by
        /// comma or space and that the entered values are integers.
        /// </summary>
        /// <param name="input">The input string to verify</param>
        /// <returns>True if all data are integers. False if the data were not integers 
        /// or not separated correctly.</returns>
        private bool CheckDataInput(string input)
        {
            // Make sure that it returns false if no data supplied.
            bool result = false;

            // Split the data if a comma or a space is found
            string[] arrayOfIntegers = input.Split(new char[]{ ' ', ','});

            // Convert each string in the array of values to integers
            foreach(string s in arrayOfIntegers)
            {
                int value;
                // Make sure that the string supplied is an integer if not then return false
                result = int.TryParse(s, out value);
                if (result)
                {
                    data.Add(value);
                }
                else
                {
                    data.Clear();
                    break;
                }
            }

            return result;
        }

        /// <summary>
        /// Categories saved in the categories array if the input is valid
        /// </summary>
        /// <param name="input">The input string to verify</param>
        /// <returns>True if a valid input. False if an empty input is provided or if just a comma is provided.</returns>
        private bool CheckCategories(string input)
        {
            // Make sure that it returns false if no categories are supplied.
            bool result = false;

            if (input.Length > 0)
            {
                // Split the data if a comma or a space is found
                string[] arrayOfCategories = input.Split(',');

                // Check if the first element is not empty
                if (arrayOfCategories[0].Length > 0)
                {
                    categories = arrayOfCategories.ToList();
                    result = true;
                }
                else
                {
                    categories.Clear();
                }
            }
            return result;
        }

        /// <summary>
        /// Saves title name if input has characters.
        /// </summary>
        /// <param name="input">The input string to verify</param>
        /// <returns>True if a valid input. False if an empty input is provided </returns>
        private bool CheckTitle(string input)
        {
            // Make sure that it returns false if the input is not supplied.
            bool result = false;

            if (input.Length > 0)
            {
                graphTitle = input;
                result = true;
            }
            else
            {
                graphTitle = "";
            }

            return result;
        }

        /// <summary>
        /// Saves X Axis name if input has characters.
        /// </summary>
        /// <param name="input">The input string to verify</param>
        /// <returns>True if a valid input. False if an empty input is provided </returns>
        private bool CheckXAxisName(string input)
        {
            // Make sure that it returns false if the input is not supplied.
            bool result = false;

            if (input.Length > 0)
            {
                xAxisName = input;
                result = true;
            }
            else
            {
                xAxisName = "";
            }

            return result;
        }

        /// <summary>
        /// Saves Y Axis name if input has characters.
        /// </summary>
        /// <param name="input">The input string to verify</param>
        /// <returns>True if a valid input. False if an empty input is provided </returns>
        private bool CheckYAxisName(string input)
        {
            // Make sure that it returns false if the input is not supplied.
            bool result = false;

            if (input.Length > 0)
            {
                yAxisName = input;
                result = true;
            }
            else
            {
                yAxisName = "";
            }

            return result;
        }


        /// <summary>
        /// Saves the user inputs to data.        
        /// </summary>
        /// <remarks> The drawing of the data has not yet been implemented</remarks>
        /// <param name="sender">Reference to the control/object that raised the event</param>
        /// <param name="e">Event data</param>
        private void buttonCreateGraph_Click(object sender, EventArgs e)
        {
            if (!CheckDataInput(textBoxData.Text))
            {
                MessageBox.Show("The data supplied were not integers or not separated correctly");
            }

            CheckCategories(textBoxCategories.Text);
            CheckTitle(textBoxGraphTitle.Text);
            CheckXAxisName(textBoxXAxisName.Text);
            CheckYAxisName(textBoxYAxisName.Text);

            dataGridView1.ColumnCount = 2;
            DataGridViewRow row = new DataGridViewRow();

            foreach (var d in data)
            {
                dataGridView1.Rows.Add("", d.ToString());
            }
        }
    }
}
