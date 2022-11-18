using Prog260_Heap;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeapHomework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Heap myHeap;
        private void Form1_Load(object sender, EventArgs e)
        {
            myHeap = new Heap(20);
        }

        private void buttonAddReser_Click(object sender, EventArgs e)
        {
            //create new Person object
            //assign properties
            //insert object into myHeap
            myHeap.Insert(new Person(Convert.ToInt32(textBoxResNoInput.Text), textBoxFirstNameInput.Text, textBoxLastNameInput.Text));
            //clear the 3 input textboxes
            textBoxResNoInput.Clear();
            textBoxFirstNameInput.Clear();
            textBoxLastNameInput.Clear();
        }

        private void buttonGetReser_Click(object sender, EventArgs e)
        {
            if (myHeap.IsEmpty == true)
            {
                textBoxResNoOutput.Text = "No More Reservations";
                textBoxFirstNameOutput.Clear();
                textBoxLastNameOutput.Clear();
            }
            else
            {
                //call to hashtable to find the highest priority item
                //assign it it's own variable
                Person nextPerson = myHeap.RemoveMaxNode();
                //provide relevant data to form box
                textBoxResNoOutput.Text = Convert.ToString(nextPerson.ReservationNumber);
                textBoxFirstNameOutput.Text = nextPerson.FirstName;
                textBoxLastNameOutput.Text = nextPerson.LastName;
            }
        }
     
    }
}