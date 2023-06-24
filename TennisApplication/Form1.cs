using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml; 

namespace TennisApplication
{
    public partial class Form1 : Form
    {
        public static List<Player> playerList = new List<Player>();
        

        public Form1()
        {
            InitializeComponent();
            ChangeScreen(this, new MenuScreen());

            //couldnt get xml working
            XmlReader reader = XmlReader.Create("Resources/playerInfo.xml");

            while (reader.NodeType == XmlNodeType.Text)
            {
                int i = 0;
                string firstName, lastName, dob, gender;
                int rating;

                firstName = reader.ReadString();

                reader.ReadToNextSibling("lastName"); 
                lastName = reader.ReadString();

                reader.ReadToNextSibling("age");
                dob = reader.ReadString();

                reader.ReadToNextSibling("gender");
                gender = reader.ReadString();

                reader.ReadToNextSibling("rating");
                rating = Convert.ToInt32(reader.ReadString());

                Player p = new Player(firstName, lastName, gender, 0, dob, rating, null); 
                playerList.Add(p);
            }
        }

        public static void ChangeScreen(object sender, UserControl next)
        {
            Form f; // will either be the sender or parent of sender 
            if (sender is Form)
            {
                f = (Form)sender;
            }
            else
            {
                UserControl current = (UserControl)sender;
                f = current.FindForm();
                f.Controls.Remove(current);
            }

            next.Location = new Point((f.ClientSize.Width - next.Width) / 2,
                (f.ClientSize.Height - next.Height) / 2);
            
            f.Controls.Add(next);
            next.Focus();
        }

        public static void xmlUpdater()
        {
           XmlWriter writer = XmlWriter.Create("Resources/playerInfo.xml");
            
            writer.WriteStartElement("List");

            foreach (Player p in playerList)
            {
                writer.WriteStartElement("Player");
                writer.WriteElementString("firstName", p.firstName);
                writer.WriteElementString("lastName", p.lastName);
                writer.WriteElementString("age", p.age);
                writer.WriteElementString("gender", p.gender);
                writer.WriteElementString("rating",p.rating.ToString());
                writer.WriteEndElement();
            }
            writer.WriteEndElement();
            writer.Close();

        }

    }
    }
