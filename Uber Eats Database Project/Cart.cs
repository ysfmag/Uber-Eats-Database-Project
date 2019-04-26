﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
namespace Uber_Eats_Database_Project
{ 
    public partial class Cart : Form
    {
        public int x;
        public cartItem[] cartItems;
        OracleConnection con;

        string ordb = "data source = orcl; user id =scott; password=tiger;";
        public Cart()
        {
            InitializeComponent();
        }

        private void Cart_Load(object sender, EventArgs e)
        {
            con = new OracleConnection(ordb);
            con.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "Count_GetCartItems";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("id", Helper.currentOrderId);
            cmd.Parameters.Add("cnt", OracleDbType.Int32, ParameterDirection.Output);
            cmd.ExecuteNonQuery();
            x = int.Parse(cmd.Parameters["cnt"].Value.ToString());
            con.Close();

            con = new OracleConnection(ordb);
            con.Open();
            OracleCommand cmd2 = new OracleCommand();
            cmd2.Connection = con;
            cmd2.CommandText = "GetCartItems";
            cmd2.CommandType = CommandType.StoredProcedure;
            cmd2.Parameters.Add("id", Helper.currentOrderId);
            cmd2.Parameters.Add("rows", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader dr = cmd2.ExecuteReader();
            //dr[0] foodname
            //dr[1] rest name
           
            //dr[2] price
            //dr[3] discount
            //dr 4 no of items
             cartItems = new cartItem[x];
            
            int i = 0;
            while (dr.Read())
            {
                cartItems[i] = new cartItem();
                cartItems[i].FoodName.Text = dr[0].ToString();
                cartItems[i].RestName.Text = dr[1].ToString();
                cartItems[i].RestLoc.Text = dr[2].ToString();
                cartItems[i].Price.Text = dr[3].ToString();
                cartItems[i].Discount.Text = (dr[4]).ToString();
                cartItems[i].NoOfItems.Text = (dr[5]).ToString();
                cartItems[i].cart_id = i;

                flowLayoutPanel1.Controls.Add(cartItems[i]);
                i++;

            }
            dr.Close();

            con.Close();

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Cart_Shown(object sender, EventArgs e)
        {
           
        }

        private void Cart_Activated(object sender, EventArgs e)
        {
           
        }

        private void flowLayoutPanel1_MouseMove(object sender, MouseEventArgs e)
        {
        }
        #region buttons hovers

        #endregion

        private void Confirm_Click(object sender, EventArgs e)
        {
            int z = flowLayoutPanel1.Controls.Count;
            for(int i = 0; i < z; i++)
            {
                con = new OracleConnection(ordb);
                con.Open();
                OracleCommand cmd4 = new OracleCommand();
                cmd4.Connection = con;
                cmd4.CommandText = "Update_Cart_Items";
                cmd4.CommandType = CommandType.StoredProcedure;
                cmd4.Parameters.Add("id", Helper.currentOrderId);
                cmd4.Parameters.Add("rest_name", cartItems[i].RestName.Text);
                cmd4.Parameters.Add("rest_loc", cartItems[i].RestLoc.Text);
                cmd4.Parameters.Add("food_name", cartItems[i].FoodName.Text);
                cmd4.Parameters.Add("no_of_items", cartItems[i].NoOfItems.Text);
                cmd4.ExecuteNonQuery();
                con.Close();
                con = new OracleConnection(ordb);
                con.Open();
                OracleCommand cmd5 = new OracleCommand();
                cmd5.Connection = con;
                cmd5.CommandText = "Update_Order_Status_nc_to_pd";
                cmd5.CommandType = CommandType.StoredProcedure;
                cmd5.Parameters.Add("id", Helper.currentOrderId);
                cmd5.ExecuteNonQuery();
            }
            OracleCommand cmd = new OracleCommand("Create_Cart", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("un", Helper.currentUserName);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
