/*
 * Name : Manthan Jansari 
 * Student Id : 000741486
 * Date: 12-01-2018
 * purpose : This program is use to read file and display data by the doctor 1 - 12 and format display it to the user by assending order 
 * Statement of Authorship : I, Manthan Jansari,000741486 certify that this material is my original work. No other person's work has been used without due acknowledgement.
 * 
 */
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

namespace lab5B
{
    public partial class Form1 : Form
    {
        int getIndex=0;
        List<Doctor> dList = new List<Doctor>();
        List<Companion> cList = new List<Companion>();
        List<Episode> eList = new List<Episode>();
        public Form1()
        {
            InitializeComponent();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Check if the file exist of not and then spass value by spliting to the class by the first cgaracter of the string
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

            textBox1.Text = "";
            textBox2.Text = "";

            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            listBox1.Items.Clear();
            comboBox1.Items.Clear();
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "TEXT File |*.txt|Text Files|*.TXT";
            openFileDialog1.ShowDialog();
            
            if (File.Exists(openFileDialog1.FileName))
            {
                comboBox1.Items.Clear();
                comboBox1.Items.Add("First");
                comboBox1.Items.Add("Secound");
                comboBox1.Items.Add("Third");
                comboBox1.Items.Add("Fourth");
                comboBox1.Items.Add("Fifth");
                comboBox1.Items.Add("Sixth");
                comboBox1.Items.Add("Seventh");
                comboBox1.Items.Add("Eighth");
                comboBox1.Items.Add("Nine");
                comboBox1.Items.Add("Tenth");
                comboBox1.Items.Add("Eleventh");
                comboBox1.Items.Add("Twelfth");


                String input = "";
                FileStream file = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(file);
                while ((input = reader.ReadLine()) != null)
                {
                    string[] exploded = input.Split('|');
                    if(exploded[0][1]==' ')
                    {
                        if (exploded[0][0] == 'D')
                        {


                            Doctor d1=new Doctor(Convert.ToInt32(exploded[1]),exploded[2],Convert.ToInt32(exploded[3]),Convert.ToInt32(exploded[4]),Convert.ToInt32(exploded[5]));
                            dList.Add(d1);
                         
                        }else if(exploded[0][0]=='E'){

                            Episode e1 = new Episode(exploded[1],Convert.ToInt32(exploded[2]),Convert.ToInt32(exploded[3]),exploded[4]);
                            eList.Add(e1);
                        }
                        else if (exploded[0][0] == 'C')
                        {
                            Companion c1 = new Companion(exploded[1].Trim(),exploded[2].Trim(),Convert.ToInt32(exploded[3]),exploded[4]);
                            cList.Add(c1);

                        }


                    }
                        
                }
                
            }
            else
            {
                MessageBox.Show("Not able to find file...");
            }
            

            

        }
        
        /// <summary>
        /// Form load disable all properties of form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;
            textBox5.ReadOnly = true;
            
        }
        /// <summary>
        /// Combo box index change event to display appropriate data to the user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            getIndex = comboBox1.SelectedIndex + 1;
            var mydoc_comp = from mydoctor in dList
                             join mycompanion in cList on mydoctor.Ordinal equals mycompanion.DOCTOR
                             where getIndex == mydoctor.Ordinal
                             orderby mydoctor.AGE
                             select new { mydoctor.ACTOR, mydoctor.AGE, mydoctor.SERIES };
            var myepi_comp = from myepisode in eList
                             join mycompanion in cList on myepisode.STORY equals mycompanion.DEBUT
                             where getIndex == mycompanion.DOCTOR
                             orderby myepisode.YEAR
                             select new { mycompanion.ACTOR, myepisode.YEAR,mycompanion.Name, myepisode.TITLE };
            textBox4.Text = mydoc_comp.First().AGE.ToString();

            textBox1.Text = myepi_comp.First().YEAR.ToString();
            textBox2.Text = mydoc_comp.First().ACTOR;
            textBox3.Text = mydoc_comp.First().SERIES.ToString();
            textBox4.Text= myepi_comp.First().YEAR.ToString();
            textBox5.Text = myepi_comp.First().TITLE.ToString();

            //for eachloop to print Data in list box
            foreach (var dr in myepi_comp)
            {
                String s = String.Format( dr.Name.Trim()+" ("+ dr.ACTOR.Trim()+")");
                String s1 = String.Format("\""+dr.TITLE.Trim()+"\" ("+dr.YEAR+")\n");
                String s2 = "";
                listBox1.Items.Add(s);
                listBox1.Items.Add(s1);
                listBox1.Items.Add(s2);


            }

        }
    }
}
