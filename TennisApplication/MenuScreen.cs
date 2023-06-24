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
    public partial class MenuScreen : UserControl
    {
        public MenuScreen()
        {
            InitializeComponent();
        }

        private void playerButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new playerListScreen());
        }

        private void gameButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new gameListScreen());
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            Form1.xmlUpdater(); 
            f.Close(); 
        }
    }
}
