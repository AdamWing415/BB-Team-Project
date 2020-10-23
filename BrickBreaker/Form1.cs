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
using System.Xml.Linq;

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
            //reads scores from xml and adds to the scores list
            TsunamiReadXML();

            // Start the program centred on the Menu Screen
            MenuScreen ms = new MenuScreen();
            this.Controls.Add(ms);

            ms.Location = new Point((this.Width - ms.Width) / 2, (this.Height - ms.Height) / 2);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
           //writes scores to an xml

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

        private void TsunamiReadXML()
        {
            //reading xml

            XmlTextReader reader = new XmlTextReader("Resources/ScoreXML.xml");

            while (reader.Read())
            {

                if (reader.NodeType == XmlNodeType.Text)
                {
                    string name = reader.ReadString();

                    reader.ReadToNextSibling("score");
                    string score = reader.ReadString();

                    Scores newScore = new Scores(name, score);
                    Scores.scores.Add(newScore);
                }
            }
            reader.Close();
        }
    }
}
