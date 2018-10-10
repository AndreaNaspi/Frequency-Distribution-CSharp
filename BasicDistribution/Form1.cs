using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicDistribution
{
    public partial class Form1 : Form
    {
        /*
         * List of students from file Dataset.csv
        */ 
        private LinkedList<Student> listStudent;

        // Initialize all GUI components
        public Form1()
        {
            InitializeComponent();
        }

        // Inizialize empty list and select default value on distribution combobox
        private void Form1_Load(object sender, EventArgs e)
        {
            listStudent = new LinkedList<Student>();
            distributionOn.SelectedIndex = 0;
        }

        // Load File click event
        private void button1_Click(object sender, EventArgs e)
        {
            // Re-initialize empty list and empty text box (maybe the file is updated)
            textFile.Text = "";
            listStudent = new LinkedList<Student>();
            // Read file and skip first line (column names)
            var file = File.ReadAllLines("../../../Dataset.csv").Skip(1);
            // Iterate over lines of the file
            foreach (var line in file)
            {
                // Split the line values by ';'
                String[] lineValues = line.Split(';');
                // Create student instance with the line values and add it to the list of students
                Student newStudent = new Student(lineValues[0].Trim(), Convert.ToInt32(lineValues[1].Trim()), Convert.ToInt32(lineValues[2].Trim()), Convert.ToInt32(lineValues[3].Trim()));
                listStudent.AddLast(newStudent);
                // For Each lines update the text file textbox with the line values (to string)
                textFile.Text += newStudent.getGender() + ", Age: " + newStudent.getAge() + ", Weight: " + newStudent.getWeight() + ", Height: " + newStudent.getHeight() + Environment.NewLine;
            }
        }

        // Frequency distribution click event
        private void button2_Click(object sender, EventArgs e)
        {
            // Students list empty exception
            if(!listStudent.Any())
                MessageBox.Show("Load the file before the distrubion!", "Distribution Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                // Re-initialize eempty text box (maybe the file is updated)
                textDistribution.Text = "";
                // Get dictionary (property value, counter) based on property selected by distribution combobox 
                // and order by value
                var orderedDict = getDict(distributionOn.Text.Trim()).OrderBy(x => x.Value);

                // Find the actual property with switch on the distribution combobox
                string actualProperty = "";
                switch (distributionOn.Text.Trim())
                {
                    case "Age":
                        actualProperty = "age";
                        break;
                    case "Weight":
                        actualProperty = "weight";
                        break;
                    case "Height":
                        actualProperty = "height";
                        break;
                }

                // Finally iterate over the dictionary and update the distribution textbox with the dictionary values (to string)
                foreach (var pair in orderedDict)
                    textDistribution.Text += pair.Value + " student with " + actualProperty + " " + pair.Key + Environment.NewLine;
            }
        }

        // Method to transform the list to a dictionary (property value, counter)
        private Dictionary<int, int> getDict(String keyOption)
        {
            // Initialize empty dictionary (property value, counter)
            Dictionary<int, int> dict = new Dictionary<int, int>();
            // Initialize a filed to maintain the property value (initialized to 0)
            int actualKey = 0;
            // Find the actual property witch switch on distribution combobox 
            switch (keyOption)
            {
                /* Iterate over the students list and insert into the dictionary (age value, counter) pairs
                 * If the pair exist -> sum 1 to the counter
                 * Else create new pair with (age value, 1) 
                 */
                case "Age":

                    foreach (var student in listStudent)
                    {
                        actualKey = student.getAge();
                        if (dict.ContainsKey(actualKey))
                            dict[actualKey] += 1;
                        else
                            dict.Add(actualKey, 1);
                    }
                    break;
                /* Iterate over the students list and insert into the dictionary (weight value, counter) pairs
                 * If the pair exist -> sum 1 to the counter
                 * Else create new pair with (weight value, 1) 
                 */
                case "Weight":
                    foreach (var student in listStudent)
                    {
                        actualKey = student.getWeight();
                        if (dict.ContainsKey(actualKey))
                            dict[actualKey] += 1;
                        else
                            dict.Add(actualKey, 1);
                    }
                    break;
                /* Iterate over the students list and insert into the dictionary (height value, counter) pairs
                 * If the pair exist -> sum 1 to the counter
                 * Else create new pair with (height value, 1) 
                 */
                case "Height":
                    foreach (var student in listStudent)
                    {
                        actualKey = student.getHeight();
                        if (dict.ContainsKey(actualKey))
                            dict[actualKey] += 1;
                        else
                            dict.Add(actualKey, 1);
                    }
                    break;
            }
            // Finally return the dict with the pairs (property value, counter)
            return dict;
        }

        // Method to manage the index change on the distribution comboboxs
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }
    }
}
