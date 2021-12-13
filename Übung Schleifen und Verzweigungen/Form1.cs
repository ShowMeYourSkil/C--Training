using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

/////////////////////////////////////////
/**
 * @author D
 * Copyright (c) 2022 
 * 
 * Projekt Detials: 2021 - SWD Übung
 **/
//////////////////////////////////////

namespace Übung_Schleifen_und_Verzweigungen
{ 
    public partial class Form1 : Form
    {
        public Form1()
        {
            //comboBox1 Items
            InitializeComponent();
            this.comboBox1.Items.Add("Kreis");
            this.comboBox1.Items.Add("Quadrat");
            this.comboBox1.Items.Add("Rechteck");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string input = Intera("Prompt", "Title", "Default");

            //Console.WriteLine("Programm gestartet");

            if (comboBox1.SelectedIndex < 0)
            {
                Console.WriteLine("Fehler: Keine Auswahl getroffen");
                MessageBox.Show("Ungültige Eingabe!");
            }
            if (comboBox1.SelectedIndex == 0)
            {
                
            }
            if (comboBox1.SelectedIndex == 1)
            {
                Console.WriteLine("Qudarat wurde gewählt");
            }
            if (comboBox1.SelectedIndex == 2)
            {
                Console.WriteLine("Rechteck wurde gewählt");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            // Case Switch - Labels und Buttons einblenden/ausblenden
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    label1.Text = "Radius";
                    label1.Visible = true;
                    label2.Visible = false;
                    textBox1.Visible = true;
                    textBox2.Visible = false;
                    break;

                case 1:
                    label1.Text = "Seite a";
                    label2.Text = "Seite b";
                    label1.Visible = true;
                    label2.Visible = true;
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    break;

                case 2:
                    label1.Text = "Seitenlänge";
                    label1.Visible = true;
                    label2.Visible = false;
                    textBox1.Visible = true;
                    textBox2.Visible = false;
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
