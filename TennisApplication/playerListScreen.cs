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
    public partial class playerListScreen : UserControl
    {
        List<int> playerIndexes = new List<int>();
        int lastLenght = 0;

        public playerListScreen()
        {
            InitializeComponent();
            backPanel.Visible = true;
            toggleMenu("addPlayer", true); 
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new MenuScreen());
        }

        private void addSaveButton_Click(object sender, EventArgs e)
        {
            bool checkTwo = false;
            if (addSaveButton.Text == "Add Player")
            {
                //Checks to see if a player with the same first and lastname exists
                foreach (Player p in Form1.playerList)
                {
                    if (firstNameTestBox.Text == p.firstName && lastNameTextBox.Text == p.lastName)
                    {
                        checkTwo = true;
                    }
                }

                //if the name is original it procceeds with the code
                if (checkTwo == false)
                {
                    //used a try catch statment so the code doesnt just break
                    try
                    {
                        bool check = true;
                        if (dobComboBox.Text.Length == 10)
                        {
                            for (int i = 0; i < 9; i++)
                            {
                                //checks to make sure the date of birth is formated proporly
                                if (char.IsDigit(dobComboBox.Text, i) != true && i != 4 && i != 7)
                                {
                                    check = false;
                                    break;
                                }
                                else if (dobComboBox.Text.Substring(i, 1) != "/" && (i == 4 || i == 7))
                                {
                                    check = false;
                                }
                            }
                        }
                        else
                        {
                            check = false;
                        }

                        //if the formate is propour the code proceeds 
                        if (check == true)
                        {
                            ///creates a new player and adds it to a list
                            Player newPlayer = new Player(firstNameTestBox.Text, lastNameTextBox.Text, genderBox.Text, 0, dobComboBox.Text, Convert.ToInt32(ratingBox.Text), null);
                            Form1.playerList.Add(newPlayer);

                            //informs the player on the addition of the player
                            warningLabel.Text = $"Added: {newPlayer.firstName} {newPlayer.lastName}\n" +
                                $"DOB: {newPlayer.age}\n" +
                                $"Gender: {newPlayer.gender}\n" +
                                $"Rating: {newPlayer.rating}";
                        }
                        //if the formating was incorrect
                        else
                        {
                            warningLabel.Text = "please enter the correct information";
                        }
                    }
                    //also use for formating issues
                    catch
                    {
                        warningLabel.Text = "please enter the correct information";
                    }

                    //sends no filters through the search
                    //ie all players are listed
                    updateList(",,,,,,");

                }
                //informs the user the player already exisits
                else
                {
                    warningLabel.Text = "A player with this name already exists!";
                }
            }

            //if the system is in search mode
            else if (addSaveButton.Text == "Search")
            {
                //gets rid of formating for search if the player leaves the feilds blank
                if (dobComboBox.Text == "Year/Month/Days")
                {
                    dobComboBox.Text = "";
                }
                if (genderBox.Text == "Use Selection")
                {
                    genderBox.Text = "";
                }
                if (ratingBox.Text == "Use Selection")
                {
                    ratingBox.Text = "";
                }
                //updates the list through a string format
                updateList($"{firstNameTestBox.Text},{lastNameTextBox.Text},{ageTextBox.Text},{genderBox.Text},{ratingBox.Text},");
            }
            //if the system is in save mode
            else if (addSaveButton.Text == "Save")
            {
                //figures out which player is being changed
                int selectedIndex = 0;
                for (int i = 0; i < listBox1.SelectedItem.ToString().Length; i++)
                {
                    //finds the index of the string (in the list) in which there is no text
                    if (listBox1.SelectedItem.ToString().Substring(i, 1) == " ")
                    {
                        selectedIndex = i;
                    }
                }
               
                foreach (Player p in Form1.playerList)
                {
                    //using substrings to split the first and last names and match them up with the player in the list
                    if (listBox1.SelectedItem.ToString().Substring(0, selectedIndex) == p.firstName && listBox1.SelectedItem.ToString().Substring(selectedIndex, listBox1.SelectedItem.ToString().Length - selectedIndex) == $" {p.lastName}")
                    {
                        p.firstName = firstNameTestBox.Text;
                        p.lastName = lastNameTextBox.Text;
                        p.age = dobComboBox.Text;
                        p.gender = genderBox.Text;
                        p.rating = Convert.ToInt32(ratingBox.Text);
                    }
                }

                //once again updates the list with no filter
                updateList(",,,,,,");
            }

        }

        private void updateList(string filterContent)
        {
            //Filter Format 
            //formate used in the "decoder"
            //First,Last,Age,Gender,Wins,Rating;
            warningLabel.Text = "";

            //finds the positions of the commas in the string 
            List<int> BreakContentIndex = new List<int>();
            for (int i = 0; i < filterContent.Length; i++)
            {
                if (filterContent.Substring(i, 1) == ",")
                {
                    BreakContentIndex.Add(i);
                }
            }

            //an index of all the players to be included in the list
            playerIndexes.Clear();

            foreach (Player player in Form1.playerList)
            {
                int age = 0;

                if (addSaveButton.Text == "Search")
                {
                    //checks to see if the players birth month is greater them the current dates
                    if (Convert.ToInt32(player.age.Substring(5, 2)) > Convert.ToInt32(DateTime.Now.ToString("MM")))
                    {
                        //the age is them to set to a year younger then the difference between the current date and their birth year as they havene
                        //turned yet in the current year
                        age = (Convert.ToInt32(DateTime.Now.ToString("yyy"))) - Convert.ToInt32(player.age.Substring(0, 4)) - 1;
                    }
                    else if (Convert.ToInt32(player.age.Substring(5, 2)) == Convert.ToInt32(DateTime.Now.ToString("MM")))
                    {
                        //the system then checks if the months are the same then sees if their day is greater then the current and adjusts age accordingly
                        if (Convert.ToInt32(player.age.Substring(8, 2)) > Convert.ToInt32(DateTime.Now.ToString("dd")))
                        {
                            age = (Convert.ToInt32(DateTime.Now.ToString("yyy"))) - Convert.ToInt32(player.age.Substring(0, 4)) - 1;
                        }
                        else
                        {
                            age = (Convert.ToInt32(DateTime.Now.ToString("yyy"))) - Convert.ToInt32(player.age.Substring(0, 4));
                        }
                    }
                    else
                    {
                        age = (Convert.ToInt32(DateTime.Now.ToString("yyy"))) - Convert.ToInt32(player.age.Substring(0, 4));
                    }
                }

                //adds all players in playerlist to the index of players to be displayed.
                //if failed the index is simply removed


                playerIndexes.Add(Form1.playerList.IndexOf(player));

                for (int i = 0; i < BreakContentIndex.Count; i++)
                {

                    //This portion of the code utilizes the comma index list created earlier(BreakContentIndex) along side the original string that arived within the method
                    //the as the i value icreases a seperate portion is compared. That is why the formating of the text being sent across is so important. 

                    string data;
                    if (i == 0)
                    {
                        data = filterContent.Substring(0, BreakContentIndex[i]);
                    }
                    else
                    {
                        data = filterContent.Substring(BreakContentIndex[i - 1] + 1, BreakContentIndex[i] - BreakContentIndex[i - 1] - 1);
                    }


                    if (i == 0)
                    {
                        if (data == "" || data == player.firstName)
                        {

                        }
                        else if (data != player.firstName)
                        {
                            playerIndexes.Remove(Form1.playerList.IndexOf(player));
                        }
                    }
                    if (i == 1)
                    {
                        if (data == "" || data == player.lastName)
                        {

                        }
                        else if (data != player.lastName)
                        {
                            playerIndexes.Remove(Form1.playerList.IndexOf(player));
                        }
                    }
                    if (i == 2)
                    {
                        if (addSaveButton.Text == "Search")
                        {
                            try
                            {
                                if (Convert.ToInt32(data) == age)
                                {

                                }
                                else
                                {
                                    playerIndexes.Remove(Form1.playerList.IndexOf(player));
                                }
                            }
                            catch
                            {
                                if (data == "")
                                {

                                }
                                else
                                {
                                    playerIndexes.Remove(Form1.playerList.IndexOf(player));
                                }
                            }

                        }
                        else
                        {
                            if (data == "" || data == player.age)
                            {

                            }
                            else if (data != player.age)
                            {
                                playerIndexes.Remove(Form1.playerList.IndexOf(player));
                            }
                        }

                    }
                    if (i == 3)
                    {
                        if (data == "" || data == player.gender)
                        {

                        }
                        else if (data != player.gender)
                        {
                            playerIndexes.Remove(Form1.playerList.IndexOf(player));
                        }
                    }
                    if (i == 4)
                    {
                        if (data == "" || data == player.rating.ToString())
                        {

                        }
                        else if (data != player.rating.ToString())
                        {
                            playerIndexes.Remove(Form1.playerList.IndexOf(player));
                        }
                    }


                }

            }

            //a simple for each to add players to the list box
            listBox1.Items.Clear();
            foreach (int p in playerIndexes)
            {
                listBox1.Items.Add($"{Form1.playerList[p].firstName} {Form1.playerList[p].lastName}");
            }

            //if there are no players found in the list
            if (listBox1.Items.Count == 0)
            {
                warningLabel.Text = "No players found"; 
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //triggered everytime the user changes the index
           
            //if the user is deselecting
            if (listBox1.SelectedItem == null)
            { }
            else
            {
                //changes the formate of menu to edit
                toggleMenu("edit", true);

                //much like the other formater this for loop finds the location of the space inbetween the first and last names of the player
                int space = 0;
                for (int i = 0; i < listBox1.SelectedItem.ToString().Length; i++)
                {
                    if (listBox1.SelectedItem.ToString().Substring(i, 1) == " ")
                    {
                        space = i;
                    }
                }

                //the index is then used to match a player in playerList
                foreach (Player p in Form1.playerList)
                {
                    string temp = listBox1.SelectedItem.ToString().Substring(space, listBox1.SelectedItem.ToString().Length - space);
                    if (listBox1.SelectedItem.ToString().Substring(0, space) == p.firstName && listBox1.SelectedItem.ToString().Substring(space, listBox1.SelectedItem.ToString().Length - space) == $" {p.lastName}")
                    {
                        //fills respective boxes with players stats
                        firstNameTestBox.Text = p.firstName;
                        lastNameTextBox.Text = p.lastName;
                        dobComboBox.Text = p.age;
                        genderBox.Text = p.gender;
                        ratingBox.Text = p.rating.ToString();
                    }
                }
            }
            
        }

        private void deselectButton_Click(object sender, EventArgs e)
        {
            //resets a bunch of stuff like text boxes filters and selected items
            listBox1.SelectedItem = null;
            updateList(",,,,,,");
            clearText(); 
        }

        #region toggleOpen
        private void filterButton_Click(object sender, EventArgs e)
        {
            //the toggle button which switches the menu between search and addition
            if (searchAddButton.Text == "Add")
            {
                toggleMenu("addPlayer", true);
                searchAddButton.Text = "Search";

            }
            else if (searchAddButton.Text == "Search")
            {
                toggleMenu("search", true);
                searchAddButton.Text = "Add";
            }
        }

        public void toggleMenu(string mode, bool open)
        {
            //changes the text on screen to best fit what the user is doing
            if (open == true)
            {
                backPanel.Visible = true;
                if (mode == "addPlayer")
                {
                    clearText();
                    titleLabel.Text = "Player Addition";
                    addSaveButton.Text = "Add Player";
                    warningLabel.Text = $"Please enter player information into the boxes below";
                    ageTextBox.Visible = false;
                    dobComboBox.Visible = true;
                    ageLabel.Text = "Date of Birth";
                }

                if (mode == "search")
                {
                    clearText();
                    titleLabel.Text = "Search";
                    addSaveButton.Text = "Search";
                    warningLabel.Text = $"Please enter filter information into the boxes below, you may leave fields blank";
                    dobComboBox.Visible = false;
                    ageTextBox.Visible = true;
                    ageLabel.Text = "Age";
                }

                if (mode == "edit")
                {
                    titleLabel.Text = "Edit Player";
                    ageTextBox.Visible = false;
                    dobComboBox.Visible = true;
                    ageLabel.Text = "Date of Birth";
                    addSaveButton.Text = "Save";
                    //used to remove players, thus is only relavent once a player has been selected
                    removeButton.Visible = true;
                    warningLabel.Text = "make changes in the feilds below";
                }
                else
                {
                    removeButton.Visible = false;
                }
            }
            else
            {
                backPanel.Visible = false;
            }

        }

        #endregion

        #region TextChanging

        //most of the methods within the textChanging region are simply qaulity of life implementations
        //for example, when you enter a text box the text is removed making the user experaince smoother, faster and more enjoyable.
        private void ageBox_Enter(object sender, EventArgs e)
        {
            dobComboBox.Text = "";
        }
        private void ageBox_Leave(object sender, EventArgs e)
        {
            bool check = true;
            //checks if the dob box is formated correctly
            if (dobComboBox.Text.Length == 10)
            {
                for (int i = 0; i < 9; i++)
                {
                    if (char.IsDigit(dobComboBox.Text, i) != true && i != 4 && i != 7)
                    {
                        check = false;
                        break;
                    }
                    else if (dobComboBox.Text.Substring(i, 1) != "/" && (i == 4 || i == 7))
                    {
                        check = false;
                    }
                }
            }
            else
            {
                check = false;
            }

            //if not the text is just reverted back
            if (dobComboBox.Text == "")
            {
                dobComboBox.Text = "Year/Month/Days";
            }
            else if (check == false)
            {
                dobComboBox.Text = "Year/Month/Days";
            }
            else
            {

            }
        }

        private void genderBox_Enter(object sender, EventArgs e)
        {
            genderBox.Text = "";
        }

        private void genderBox_Leave(object sender, EventArgs e)
        {
            //left a gap so there wouldnt be index issues when deciding to keep text when the text box was "left"
            genderBox.Text += "                                      ";
            if (genderBox.Text.Substring(0, 4) == "Male")
            {
                genderBox.Text = "Male";
            }
            else if (genderBox.Text.Substring(0, 6) == "Female")
            {
                genderBox.Text = "Female";
            }
            else if (genderBox.Text.Substring(0, 5) == "Other")
            {
                genderBox.Text = "Other";
            }
            else
            {
                genderBox.Text = "Use Selection";
            }

        }

        private void ratingBox_Enter(object sender, EventArgs e)
        {
            ratingBox.Text = "";
        }

        private void ratingBox_Leave(object sender, EventArgs e)
        {
            try
            {
                //decides if the formating of the box is propour, if not fixes it
                //since I used a try catch it also blocks text
                if (Convert.ToInt32(ratingBox.Text) >= 1 && Convert.ToInt32(ratingBox.Text) <= 5)
                { 
                }
                else
                {
                    ratingBox.Text = "Use Selection";
                }
            }
            catch
            {
                ratingBox.Text = "Use Selection";
            }
        }

        private void dobComboBox_TextChanged(object sender, EventArgs e)
        {
            //Another quality of life change implemented
            //this code automatically adds dashes and sets the usesrs curser in the text box at the appriate times 
            if (dobComboBox.Text.Length == 4)
            {
                dobComboBox.Text += "/";
                dobComboBox.SelectionStart = 6;
            }
            else if (dobComboBox.Text.Length == 7)
            {
                dobComboBox.Text += "/";
                dobComboBox.SelectionStart = 9;
            }

            //this code allows the player to clear the box with just one back click as the adding ages can be kind of tricky
            foreach (Player p in Form1.playerList)
            {
                //checks if the value of the last length is larger then the current length
                //ie, if the backspace button was used
                if (lastLenght > dobComboBox.TextLength && dobComboBox.Text != p.age)
                {
                    dobComboBox.Text = "";
                    lastLenght = 0;
                }
            }
            lastLenght = dobComboBox.TextLength;
        }


        public void clearText()
        {
            //just clears a bunch of text
            firstNameTestBox.Text = "";
            lastNameTextBox.Text = "";
            ageTextBox.Text = "";
            dobComboBox.Text = "Year/Month/Days";
            genderBox.Text = "Use Selection";
            ratingBox.Text = "Use Selection";
            warningLabel.Text = ""; 

        }
        #endregion

        private void removeButton_Click(object sender, EventArgs e)
        {
            //finds the space inbetween the first and last
            int selectedIndex = 0;
            for (int i = 0; i < listBox1.SelectedItem.ToString().Length; i++)
            {
                if (listBox1.SelectedItem.ToString().Substring(i, 1) == " ")
                {
                    selectedIndex = i;
                }
            }
            //uses the found index to determan which player within the list gets the axe
            foreach (Player p in Form1.playerList)
            {
                if (listBox1.SelectedItem.ToString().Substring(0, selectedIndex) == p.firstName && listBox1.SelectedItem.ToString().Substring(selectedIndex, listBox1.SelectedItem.ToString().Length - selectedIndex) == $" {p.lastName}")
                {
                    //removes the player from the list and resets screen
                    Form1.playerList.Remove(p);
                    updateList(",,,,,,");
                    clearText();
                    break; 
                }
            }
        }
    }
}
    