﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

// this works

namespace BrickBreaker
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Start the program centred on the Menu Screen
            MenuScreen ms = new MenuScreen();
            this.Controls.Add(ms);

            ms.Location = new Point((this.Width - ms.Width) / 2, (this.Height - ms.Height) / 2);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Need to add existing scores to the list in scores to keep them from being deleted on write(complete this action on reading the xml)

            XmlWriter writer = XmlWriter.Create("Resources/ScoreXML.xml", null);

            writer.WriteStartElement("HighScores");

            foreach (Scores s in Scores.scores)
            {
                writer.WriteStartElement("Player");

                writer.WriteElementString("name", s.name);
                writer.WriteElementString("score", s.score + "");

                writer.WriteEndElement();
            }

            writer.WriteEndElement();

            writer.Close();
        }
    }
}
