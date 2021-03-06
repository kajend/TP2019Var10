﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Model;
using WindowsFormsApp1.Services;

namespace WindowsFormsApp1
{
    public partial class User : Form
    {
        private UserModel user;
        public User(UserModel user)
        {
            InitializeComponent();
            this.user = user;
        }
      
        private void Button1_Click(object sender, EventArgs e)
        {
            if (!new CheckerToOrders().CanDoNewOrder(user.Name))
            {
                MessageBox.Show("У вас больше 3 заказов");
                return;
            }
            CreateOrder newForm = new CreateOrder(user);
            newForm.Show();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            StateOrder newForm = new StateOrder(user);
            newForm.Show();
        }
    }
}
