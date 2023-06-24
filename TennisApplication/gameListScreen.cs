using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TennisApplication
{
    public partial class gameListScreen : UserControl
    {
        public gameListScreen()
        {
            InitializeComponent();

            foreach (Player p in Form1.playerList)
            {
                playerOneBox.Items.Add($"{p.firstName}, {p.lastName}");
                playerTwoBox.Items.Add($"{p.firstName}, {p.lastName}"); 
            }

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new MenuScreen());
        }

        public void toggleMenu(string mode)
        {
            if (mode == "gameAddition")
            {
                titleLabel.Text = "Game Addition";
                addSaveButton.Text = "Add Player";
                removeButton.Visible = false; 
            }
            else if (mode == "gameSearch")
            {
                titleLabel.Text = "Search";
                addSaveButton.Text = "Search";
                removeButton.Visible = false;
            }
            else if (mode == "gameEditor")
            {
                titleLabel.Text = "Editor";
                addSaveButton.Text = "Save";
                removeButton.Visible = true;
            }
        }

       
        private void searchAddButton_Click(object sender, EventArgs e)
        {
            if (searchAddButton.Text == "Add")
            {
                toggleMenu("addPlayer");
                searchAddButton.Text = "Search";

            }
            else if (searchAddButton.Text == "Search")
            {
                toggleMenu("search");
                searchAddButton.Text = "Add";
            }
        }

        private void playerOneBox_Enter(object sender, EventArgs e)
        {
            playerOneBox.Text = ""; 
        }

        private void playerTwoBox_Enter(object sender, EventArgs e)
        {
            playerTwoBox.Text = "";
        }

        private void playerTwoBox_Leave(object sender, EventArgs e)
        {
            for (int i = 0; i < playerTwoBox.Items.Count; i++)
            {
               
            }
        }
    }

}

