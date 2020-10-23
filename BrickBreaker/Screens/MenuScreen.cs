using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrickBreaker
{
    public partial class MenuScreen : UserControl
    {
        public MenuScreen()
        {
            InitializeComponent();
        }
        //closes the app
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            // Goes to the game screen
            GameScreen gs = new GameScreen();
            Form form = this.FindForm();

            form.Controls.Add(gs);
            form.Controls.Remove(this);

            gs.Location = new Point((form.Width - gs.Width) / 2, (form.Height - gs.Height) / 2);
        }

        //changes back colours
        private void playButton_Enter(object sender, EventArgs e)
        {
            playButton.BackColor = Color.LightSalmon;
            exitButton.BackColor = Color.LightGray;
            highScoreButton.BackColor = Color.LightGray;
            instructionsButton.BackColor = Color.LightGray;

        }
        //changes back colours
        private void exitButton_Enter(object sender, EventArgs e)
        {
            playButton.BackColor = Color.LightGray;
            exitButton.BackColor = Color.LightSalmon;
            highScoreButton.BackColor = Color.LightGray;
            instructionsButton.BackColor = Color.LightGray;
        }
        //goes to teh high score screen
        private void highScoreButton_Click(object sender, EventArgs e)
        {
            // Goes to the high scores screen
            HighScoreScreen hs = new HighScoreScreen();
            Form form = this.FindForm();

            form.Controls.Remove(this);
            form.Controls.Add(hs);

            hs.Focus();
            hs.Location = new Point((form.Width - hs.Width) / 2, (form.Height - hs.Height) / 2);
        }
        //goes to the instruction screen
        private void instructionsButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            InstructionsScreen ins = new InstructionsScreen();

            f.Controls.Remove(this);
            f.Controls.Add(ins);

            ins.Focus();
            ins.Location = new Point((f.Width - ins.Width) / 2, (f.Height - ins.Height) / 2);
        }
        //changes back colours
        private void instructionsButton_Enter(object sender, EventArgs e)
        {
            playButton.BackColor = Color.LightGray;
            exitButton.BackColor = Color.LightGray;
            highScoreButton.BackColor = Color.LightGray;
            instructionsButton.BackColor = Color.LightSalmon;
        }
        //changes back colours
        private void highScoreButton_Enter(object sender, EventArgs e)
        {
            highScoreButton.BackColor = Color.LightSalmon;
            exitButton.BackColor = Color.LightGray;

            playButton.BackColor = Color.LightGray;
            instructionsButton.BackColor = Color.LightGray;
        }

    }
    }

