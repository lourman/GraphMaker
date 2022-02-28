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

            // Make sure you clear the data list before
            data.Clear();
            // Convert each string in the array of values to integers
            foreach (string s in arrayOfIntegers)
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

            DrawBarGraph();
        }

        /// <summary>
        /// Populates the datagridview. 
        /// </summary>
        private void PopulateDataTable()
        {
            if (data.Count > 0)
            {
                SetupDataTable();

                dataGridViewData.Rows.Clear();
                if (xAxisName.Length > 0)
                {
                    dataGridViewData.Columns[0].Name = xAxisName;
                }
                else
                {
                    dataGridViewData.Columns[0].Name = "X-Axis";
                }
                if (yAxisName.Length > 0)
                {
                    dataGridViewData.Columns[1].Name = yAxisName;
                }
                else
                {
                    dataGridViewData.Columns[1].Name = "Y-Axis";
                }

                DataGridViewRow row = new DataGridViewRow();

                for (int i = 0; i < data.Count; i++)
                {
                    if (i < categories.Count)
                    {
                        dataGridViewData.Rows.Add(categories[i], data[i].ToString());
                    }
                    else
                    {
                        dataGridViewData.Rows.Add("", data[i].ToString());
                    }
                }
            }
        }

        /// <summary>
        /// Setup the DataGridView        
        /// </summary>
        private void SetupDataTable()
        {
            dataGridViewData.ColumnCount = 2;
            dataGridViewData.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dataGridViewData.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewData.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridViewData.Font, FontStyle.Bold);
            dataGridViewData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewData.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dataGridViewData.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewData.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridViewData.GridColor = Color.Black;
            dataGridViewData.RowHeadersVisible = false;            
            dataGridViewData.AllowUserToAddRows = false;
            dataGridViewData.ReadOnly = true;
            dataGridViewData.MultiSelect = false;
        }


        /// <summary>
        /// Draws the bar graph
        /// </summary>
        private void DrawBarGraph()
        {
            // Setup the chart area
            SetupChartArea();

            // Get the graphics from the bitmap image
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(bmp);

            // Add an offset for making sure the arrows apear the end of the axis
            int offset = 5;
        
            // Brush for the bars
            SolidBrush barBrush = new SolidBrush(Color.Blue);

            // Get width and height of drawing area
            int width = (int)g.VisibleClipBounds.Size.Width - offset;
            int height = (int)g.VisibleClipBounds.Size.Height - offset;
            
            // Calculate the height ratio depending on the maximum data value and the width of each bar,
            // taking into account that a space is needed between the bars.
            int max_value = data.Max(); 
            int width_per_item = (width) / (2*data.Count);
            int height_ratio = (height) / max_value;

            // Create a pen with an arrow end
            Pen PenAxis = new Pen(Color.Red);
            PenAxis.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;

            // Draw the axis
            g.DrawLine(PenAxis, offset, height-1 - offset, width - offset, height-1 - offset);            
            g.DrawLine(PenAxis, offset, height - 1 - offset, offset, offset);
            
            for (int i = 0, j = 0; i < data.Count; j +=2, i++)
            {
                var value = data[i];
                int bar_height = height_ratio * value;
                // Rectangle respresenting the bar
                Rectangle bar = new Rectangle(new Point(j * width_per_item + offset, height - bar_height - offset), new Size(width_per_item, bar_height));
                g.FillRectangle(barBrush, bar);
                
            }
            pictureBox1.Image = bmp;
        }

        /// <summary>
        /// Make sure all labels are populated for the bar chart area
        /// </summary>
        private void SetupChartArea()
        {
            labelChartTitleLabel.Text = graphTitle;
            labelXAxisLabel.Text = xAxisName;
            labelYAxisLabel.Text = yAxisName;
        }
    }
}
