﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Universe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SolarSystem solarsystem = new SolarSystem();
            solarsystem.Name = "Sol system";
            textBox1.Text = solarsystem.Stars.ElementAt(0).ToString();
        }
    }
}
