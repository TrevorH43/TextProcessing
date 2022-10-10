using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextProcessing
{
    public partial class CSVDisplayForm : Form
    {
        public CSVDisplayForm()
        {
            InitializeComponent();
        }

        private void selectCSVButton_Click(object sender, EventArgs e)
        {
            // Add a filter
            openFileDialog1.Filter = "Excel Files|*.csv;";

            // Check if user selected a file.
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(openFileDialog1.FileName);
            }
            string line, field;
            string[] fields;
            int count = 0;
            DataTable dt = new DataTable();
            DataRow dr = null;

            openFileDialog1.Filter = "CSV Files (*.csv)|*.csv";

            // Check if user selected a file.
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Open the selected file using a stream reader
                using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
                {
                    // While there is more data to process, read the record
                    while ((line = sr.ReadLine()) != null)
                    {
                        // Split each read record into individual fields based on comma separation
                        fields = line.Split(',');

                        // if there are any fields, then process the file.  
                        if (fields.Length > 0)
                        {
                            // If the count is not 0, meaning not the first row, then add a row to the datatable
                            if (count != 0)
                                dr = dt.NewRow();

                            // Now, lets process the data in those fields.
                            for (int i = 0; i < fields.Length; i++)
                            {
                                // Get the field 
                                field = fields[i];
                                if (count == 0)             // Row 0 == Headers to go in table columns
                                {
                                    // Replace any spaces with underscores and remove double quotes
                                    dt.Columns.Add(field.Replace(' ', '_').Replace("\"", "").ToUpper());        // Replace all spaces with underscores
                                }
                                else
                                {
                                    // place the value in the row column
                                    dr[i] = field.Replace("\"", "");
                                }
                            }

                            // We didn't generate a row for the first row in the CSV file because it gets stored as
                            // part of the columns of the datagrid and not a row within the datagrid.  So, if we created
                            // a row, we want to add it.
                            if (count != 0)
                                dt.Rows.Add(dr);

                            // Increment the counter
                            count++;
                        }
                    }
                }

                dataGridView.DataSource = dt.DefaultView;
            }
        }

    }
 }
            
