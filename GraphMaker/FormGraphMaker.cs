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
            // Verify Inputs
            if (!CheckDataInput(textBoxData.Text))
            {
                MessageBox.Show("The data supplied were not integers or not separated correctly");
            }

            CheckCategories(textBoxCategories.Text);
            CheckTitle(textBoxGraphTitle.Text);
            CheckXAxisName(textBoxXAxisName.Text);
            CheckYAxisName(textBoxYAxisName.Text);

            // Display Data in Table
            PopulateDataTable();

            hh();
        }

        private void PopulateDataTable()
        {
            if (data.Count > 0)
            {
                SetupDataTable();

                dataGridView1.Rows.Clear();
                if (xAxisName.Length > 0)
                {
                    dataGridView1.Columns[0].Name = xAxisName;
                }
                else
                {
                    dataGridView1.Columns[0].Name = "X-Axis";
                }
                if (yAxisName.Length > 0)
                {
                    dataGridView1.Columns[1].Name = yAxisName;
                }
                else
                {
                    dataGridView1.Columns[1].Name = "Y-Axis";
                }

                DataGridViewRow row = new DataGridViewRow();

                for (int i = 0; i < data.Count; i++)
                {
                    dataGridView1.Rows.Add("", data[i].ToString());
                }
            }
        }

        private void SetupDataTable()
        {
            dataGridView1.ColumnCount = 2;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold);

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridView1.GridColor = Color.Black;
            dataGridView1.RowHeadersVisible = false;

            
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.MultiSelect = false;
        }
        private void hh()
        {
            Bitmap flag = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(flag);

            SolidBrush brush = new SolidBrush(Color.Red);
            SolidBrush brush2 = new SolidBrush(Color.White);
            int width = (int)g.VisibleClipBounds.Size.Width;
            int height = (int)g.VisibleClipBounds.Size.Height;
            //int max_value = data.Max();  // for responsive height
            int width_per_item = width / (2*data.Count);
            int height_ratio = height / 20;

           //g.FillRectangle(new SolidBrush(Color.Black), 0, 0, width, height);  // Clear the whole drawing area with a color

            for (int i = 0, j = 0; i < data.Count; j +=2, i++)
            {
                var value = data[i];
                int bar_height = height_ratio * value;
                g.FillRectangle(brush, new Rectangle(
                    new Point(j * width_per_item, height - bar_height),
                    new Size(width_per_item, bar_height)
                ));
                g.FillRectangle(brush2, new Rectangle(
                    new Point((j+1) * width_per_item, height),
                    new Size(width_per_item, bar_height)
                ));
            }
            pictureBox1.Image = flag;
        }
    }
}
