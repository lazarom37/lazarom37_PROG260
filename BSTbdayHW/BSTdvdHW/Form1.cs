using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Birthday
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Bday_BST myBST = new Bday_BST();

        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            Birthday newBirthday = new Birthday();
            newBirthday.Date = Convert.ToInt32(textBoxBday.Text);
            newBirthday.Name = textBoxName.Text;
            newBirthday.Ideas = textBoxIdeas.Text;
            myBST.AddRec(newBirthday);  // showing error since Bday_BST code does not
            // currently accept object of type Birthday

        }

        private void buttonLookUp_Click(object sender, EventArgs e)
        {
            Birthday existingBirthday;
            existingBirthday = myBST.FindRec(Convert.ToInt32(textBoxLookUpDate.Text));
            // showing error since Bday_BST code does not return a Birthday object
            textBoxName.Text = existingBirthday.Name;
            textBoxIdeas.Text = existingBirthday.Ideas;

        }

    }
}
