using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using Session;

namespace Access
{
    public partial class Form1 : Form
    {
        Broker b = new Broker();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Person p = new Person();
            p.FisrtName = txtFirstName.Text;
            p.LastName = txtLastName.Text;

            b.Insert(p);
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            cmbPeople.DataSource = b.FillComboBox();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Person oldPerson = new Person();
            Person newPerson = new Person();

            oldPerson = cmbPeople.SelectedItem as Person;

            newPerson.FisrtName = txtNewFirstName.Text;
            newPerson.LastName = txtNewLastName.Text;

            b.Update(oldPerson, newPerson);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Person p = new Person();
            p = cmbPeople.SelectedItem as Person;

            b.Delete(p);
        }
    }
}
