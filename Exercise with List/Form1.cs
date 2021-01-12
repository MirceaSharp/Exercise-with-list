using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Exercise_with_List
{
    public partial class Form1 : Form
    {
        List<string> studentList = new List<string>();
        List<int> pointsList = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnReadStudent_Click(object sender, EventArgs e)
        {
            ReadStudents();
            ShowStudents();


        }


        private void btnReadPoints_Click(object sender, EventArgs e)
        {
            ReadPoints();
            ShowPoints();
        }


        private void btnEmpty_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
        }
        private void ReadStudents()
        {

            if (System.IO.File.Exists("Students.txt"))
            {



                StreamReader readObject = new StreamReader("Students.txt");
                string input = "";



                while (readObject.EndOfStream != true)
                {
                    input = readObject.ReadLine();
                    studentList.Add(input);
                }
                readObject.Close();

            }
            else
            {
                MessageBox.Show("File not found");
            }
        }
        private void ShowStudents()
        {
            for (int i = 0; i < studentList.Count; i++)
            {
                txtResult.Text += studentList[i] + Environment.NewLine;
            }


        }

        private void ReadPoints()
        {
            if (System.IO.File.Exists("Points.txt"))
            {
                StreamReader readObject = new StreamReader("Points.txt");
                string input = "";

                while (readObject.EndOfStream != true)
                {

                    input = readObject.ReadLine();
                    pointsList.Add(Convert.ToInt32(input));


                }

            }
            else
            {
                MessageBox.Show("File not found");
            }


        }
        private void ShowPoints()
        {
            for (int i = 0; i < pointsList.Count; i++)
            {
                txtResult.Text += pointsList[i] + Environment.NewLine;
            }
        }





        private void txtResult_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
