﻿using System;
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
        private LinkedList<Student> listStudent;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listStudent = new LinkedList<Student>();
            distributionOn.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textFile.Text = "";
            listStudent = new LinkedList<Student>();
            var file = File.ReadAllLines("Dataset.csv").Skip(1);
            foreach(var line in file)
            {
                String[] lineValues = line.Split(';');
                Student newStudent = new Student(lineValues[0].Trim(), Convert.ToInt32(lineValues[1].Trim()), Convert.ToInt32(lineValues[2].Trim()), Convert.ToInt32(lineValues[3].Trim()));
                listStudent.AddLast(newStudent);
                textFile.Text += newStudent.getGender() + ", Age: " + newStudent.getAge() + ", Weight: " + newStudent.getWeight() + ", Height: " + newStudent.getHeight() + Environment.NewLine;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(!listStudent.Any())
                MessageBox.Show("Load the file before the distrubion!", "Distribution Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                textDistribution.Text = "";
                var orderedDict = getDict(distributionOn.Text.Trim()).OrderBy(x => x.Value);
                foreach (var pair in orderedDict)
                {
                    switch (distributionOn.Text.Trim())
                    {
                        case "Age":
                            textDistribution.Text += pair.Value + " student with age " + pair.Key + Environment.NewLine;
                            break;
                        case "Weight":
                            textDistribution.Text += pair.Value + " student with weight " + pair.Key + Environment.NewLine;
                            break;
                        case "Height":
                            textDistribution.Text += pair.Value + " student with height " + pair.Key + Environment.NewLine;
                            break;
                    }
                }
            }
        }

        private Dictionary<int, int> getDict(String keyOption)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            foreach (var student in listStudent)
            {
                int actualKey = 0;
                switch (keyOption)
                {
                    case "Age":
                        actualKey = student.getAge();
                        break;
                    case "Weight":
                        actualKey = student.getWeight();
                        break;
                    case "Height":
                        actualKey = student.getHeight();
                        break;
                }
                if(dict.ContainsKey(actualKey))
                    dict[actualKey] += 1;
                else
                    dict.Add(actualKey, 1);
            }
            return dict;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }
    }

    public class Student
    {
     
        private String gender;
        private int age;
        private int weight;
        private int height;

        public Student(String gender, int age, int weight, int height)
        {
            this.gender = gender;
            this.age = age;
            this.weight = weight;
            this.height = height;
        }

        public String getGender()
        {
            return gender;
        }

        public int getAge()
        {
            return age;
        }

        public int getWeight()
        {
            return weight;
        }

        public int getHeight()
        {
            return height;
        }

        public void setGender(String gender)
        {
            this.gender = gender;
        }

        public void setAge(int age)
        {
            this.age = age;
        }

        public void setWeight(int weight)
        {
            this.weight = weight;
        }

        public void setHeight(int height)
        {
            this.height = height;
        }
    }
}