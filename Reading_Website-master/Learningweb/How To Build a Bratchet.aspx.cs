﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Learningweb
{
	public partial class How_To_Build_a_Bratchet : System.Web.UI.Page
	{
        static int quick = 0;
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
		{
            if (DropDownList2.SelectedIndex.Equals(1))
            {
                Label24.ForeColor = System.Drawing.Color.Black;
                Label2.ForeColor = System.Drawing.Color.Black;
                Label9.ForeColor = System.Drawing.Color.Black;
                Label3.ForeColor = System.Drawing.Color.Black;
                Label10.ForeColor = System.Drawing.Color.Black;
                Label4.ForeColor = System.Drawing.Color.Black;
                Label11.ForeColor = System.Drawing.Color.Black;
                Label12.ForeColor = System.Drawing.Color.Black;
                Label13.ForeColor = System.Drawing.Color.Black;
                Label14.ForeColor = System.Drawing.Color.Black;
                Label15.ForeColor = System.Drawing.Color.Black;
                Label16.ForeColor = System.Drawing.Color.Black;
                Label17.ForeColor = System.Drawing.Color.Black;
                Label5.ForeColor = System.Drawing.Color.Black;
                Label18.ForeColor = System.Drawing.Color.Black;
                Label6.ForeColor = System.Drawing.Color.Black;
                Label19.ForeColor = System.Drawing.Color.Black;
                Label7.ForeColor = System.Drawing.Color.Black;
                Label20.ForeColor = System.Drawing.Color.Black;
                Label21.ForeColor = System.Drawing.Color.Black;
                Label22.ForeColor = System.Drawing.Color.Black;
                Label8.ForeColor = System.Drawing.Color.Black;
                Label23.ForeColor = System.Drawing.Color.Black;
            }
            else if (DropDownList2.SelectedIndex.Equals(2))
            {
                Label24.ForeColor = System.Drawing.Color.Green;
                Label2.ForeColor = System.Drawing.Color.Green;
                Label9.ForeColor = System.Drawing.Color.Green;
                Label13.ForeColor = System.Drawing.Color.Green;
                Label10.ForeColor = System.Drawing.Color.Green;
                Label4.ForeColor = System.Drawing.Color.Green;
                Label11.ForeColor = System.Drawing.Color.Green;
                Label12.ForeColor = System.Drawing.Color.Green;
                Label13.ForeColor = System.Drawing.Color.Green;
                Label14.ForeColor = System.Drawing.Color.Green;
                Label15.ForeColor = System.Drawing.Color.Green;
                Label16.ForeColor = System.Drawing.Color.Green;
                Label17.ForeColor = System.Drawing.Color.Green;
                Label5.ForeColor = System.Drawing.Color.Green;
                Label18.ForeColor = System.Drawing.Color.Green;
                Label6.ForeColor = System.Drawing.Color.Green;
                Label19.ForeColor = System.Drawing.Color.Green;
                Label7.ForeColor = System.Drawing.Color.Green;
                Label20.ForeColor = System.Drawing.Color.Green;
                Label21.ForeColor = System.Drawing.Color.Green;
                Label22.ForeColor = System.Drawing.Color.Green;
                Label8.ForeColor = System.Drawing.Color.Green;
                Label23.ForeColor = System.Drawing.Color.Green;


            }
            else if (DropDownList2.SelectedIndex.Equals(3))
            {
                Label24.ForeColor = System.Drawing.Color.Blue;
                Label2.ForeColor = System.Drawing.Color.Blue;
                Label3.ForeColor = System.Drawing.Color.Blue;
                Label4.ForeColor = System.Drawing.Color.Blue;
                Label5.ForeColor = System.Drawing.Color.Blue;
                Label6.ForeColor = System.Drawing.Color.Blue;
                Label7.ForeColor = System.Drawing.Color.Blue;
                Label8.ForeColor = System.Drawing.Color.Blue;
                Label9.ForeColor = System.Drawing.Color.Blue;
                Label10.ForeColor = System.Drawing.Color.Blue;
                Label11.ForeColor = System.Drawing.Color.Blue;
                Label12.ForeColor = System.Drawing.Color.Blue;
                Label13.ForeColor = System.Drawing.Color.Blue;
                Label14.ForeColor = System.Drawing.Color.Blue;
                Label15.ForeColor = System.Drawing.Color.Blue;
                Label16.ForeColor = System.Drawing.Color.Blue;
                Label17.ForeColor = System.Drawing.Color.Blue;
                Label18.ForeColor = System.Drawing.Color.Blue;
                Label19.ForeColor = System.Drawing.Color.Blue;
                Label20.ForeColor = System.Drawing.Color.Blue;
                Label21.ForeColor = System.Drawing.Color.Blue;
                Label22.ForeColor = System.Drawing.Color.Blue;
                Label23.ForeColor = System.Drawing.Color.Blue;
            }
            else if (DropDownList2.SelectedIndex.Equals(4))
            {
                Label24.ForeColor = System.Drawing.Color.Red;
                Label2.ForeColor = System.Drawing.Color.Red;
                Label3.ForeColor = System.Drawing.Color.Red;
                Label4.ForeColor = System.Drawing.Color.Red;
                Label5.ForeColor = System.Drawing.Color.Red;
                Label6.ForeColor = System.Drawing.Color.Red;
                Label7.ForeColor = System.Drawing.Color.Red;
                Label8.ForeColor = System.Drawing.Color.Red;
                Label9.ForeColor = System.Drawing.Color.Red;
                Label10.ForeColor = System.Drawing.Color.Red;
                Label11.ForeColor = System.Drawing.Color.Red;
                Label12.ForeColor = System.Drawing.Color.Red;
                Label13.ForeColor = System.Drawing.Color.Red;
                Label14.ForeColor = System.Drawing.Color.Red;
                Label15.ForeColor = System.Drawing.Color.Red;
                Label16.ForeColor = System.Drawing.Color.Red;
                Label17.ForeColor = System.Drawing.Color.Red;
                Label18.ForeColor = System.Drawing.Color.Red;
                Label19.ForeColor = System.Drawing.Color.Red;
                Label20.ForeColor = System.Drawing.Color.Red;
                Label21.ForeColor = System.Drawing.Color.Red;
                Label22.ForeColor = System.Drawing.Color.Red;
                Label23.ForeColor = System.Drawing.Color.Red;
            }
            else if (DropDownList2.SelectedIndex.Equals(5))
            {
                Label24.ForeColor = System.Drawing.Color.Purple;
                Label2.ForeColor = System.Drawing.Color.Purple;
                Label3.ForeColor = System.Drawing.Color.Purple;
                Label4.ForeColor = System.Drawing.Color.Purple;
                Label5.ForeColor = System.Drawing.Color.Purple;
                Label6.ForeColor = System.Drawing.Color.Purple;
                Label7.ForeColor = System.Drawing.Color.Purple;
                Label8.ForeColor = System.Drawing.Color.Purple;
                Label9.ForeColor = System.Drawing.Color.Purple;
                Label10.ForeColor = System.Drawing.Color.Purple;
                Label11.ForeColor = System.Drawing.Color.Purple;
                Label12.ForeColor = System.Drawing.Color.Purple;
                Label13.ForeColor = System.Drawing.Color.Purple;
                Label14.ForeColor = System.Drawing.Color.Purple;
                Label15.ForeColor = System.Drawing.Color.Purple;
                Label16.ForeColor = System.Drawing.Color.Purple;
                Label17.ForeColor = System.Drawing.Color.Purple;
                Label18.ForeColor = System.Drawing.Color.Purple;
                Label19.ForeColor = System.Drawing.Color.Purple;
                Label20.ForeColor = System.Drawing.Color.Purple;
                Label21.ForeColor = System.Drawing.Color.Purple;
                Label22.ForeColor = System.Drawing.Color.Purple;
                Label23.ForeColor = System.Drawing.Color.Purple;
            }
            else if (DropDownList2.SelectedIndex.Equals(6))
            {
                Label24.ForeColor = System.Drawing.Color.Orange;
                Label2.ForeColor = System.Drawing.Color.Orange;
                Label3.ForeColor = System.Drawing.Color.Orange;
                Label4.ForeColor = System.Drawing.Color.Orange;
                Label5.ForeColor = System.Drawing.Color.Orange;
                Label6.ForeColor = System.Drawing.Color.Orange;
                Label7.ForeColor = System.Drawing.Color.Orange;
                Label8.ForeColor = System.Drawing.Color.Orange;
                Label9.ForeColor = System.Drawing.Color.Orange;
                Label10.ForeColor = System.Drawing.Color.Orange;
                Label11.ForeColor = System.Drawing.Color.Orange;
                Label12.ForeColor = System.Drawing.Color.Orange;
                Label13.ForeColor = System.Drawing.Color.Orange;
                Label14.ForeColor = System.Drawing.Color.Orange;
                Label15.ForeColor = System.Drawing.Color.Orange;
                Label16.ForeColor = System.Drawing.Color.Orange;
                Label17.ForeColor = System.Drawing.Color.Orange;
                Label18.ForeColor = System.Drawing.Color.Orange;
                Label19.ForeColor = System.Drawing.Color.Orange;
                Label20.ForeColor = System.Drawing.Color.Orange;
                Label21.ForeColor = System.Drawing.Color.Orange;
                Label22.ForeColor = System.Drawing.Color.Orange;
                Label23.ForeColor = System.Drawing.Color.Orange;
            }
            else if (DropDownList2.SelectedIndex.Equals(7))
            {
                Label24.ForeColor = System.Drawing.Color.Yellow;
                Label2.ForeColor = System.Drawing.Color.Yellow;
                Label3.ForeColor = System.Drawing.Color.Yellow;
                Label4.ForeColor = System.Drawing.Color.Yellow;
                Label5.ForeColor = System.Drawing.Color.Yellow;
                Label6.ForeColor = System.Drawing.Color.Yellow;
                Label7.ForeColor = System.Drawing.Color.Yellow;
                Label8.ForeColor = System.Drawing.Color.Yellow;
                Label9.ForeColor = System.Drawing.Color.Yellow;
                Label10.ForeColor = System.Drawing.Color.Yellow;
                Label11.ForeColor = System.Drawing.Color.Yellow;
                Label12.ForeColor = System.Drawing.Color.Yellow;
                Label13.ForeColor = System.Drawing.Color.Yellow;
                Label14.ForeColor = System.Drawing.Color.Yellow;
                Label15.ForeColor = System.Drawing.Color.Yellow;
                Label16.ForeColor = System.Drawing.Color.Yellow;
                Label17.ForeColor = System.Drawing.Color.Yellow;
                Label18.ForeColor = System.Drawing.Color.Yellow;
                Label19.ForeColor = System.Drawing.Color.Yellow;
                Label20.ForeColor = System.Drawing.Color.Yellow;
                Label21.ForeColor = System.Drawing.Color.Yellow;
                Label22.ForeColor = System.Drawing.Color.Yellow;
                Label23.ForeColor = System.Drawing.Color.Yellow;

            }
        }

        protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList3.SelectedIndex.Equals(1))
            {
                Label24.Font.Size = FontUnit.XXSmall;
                Label2.Font.Size = FontUnit.XXSmall;
                Label3.Font.Size = FontUnit.XXSmall;
                Label4.Font.Size = FontUnit.XXSmall;
                Label5.Font.Size = FontUnit.XXSmall;
                Label6.Font.Size = FontUnit.XXSmall;
                Label7.Font.Size = FontUnit.XXSmall;
                Label8.Font.Size = FontUnit.XXSmall;
                Label9.Font.Size = FontUnit.XXSmall;
                Label10.Font.Size = FontUnit.XXSmall;
                Label11.Font.Size = FontUnit.XXSmall;
                Label12.Font.Size = FontUnit.XXSmall;
                Label13.Font.Size = FontUnit.XXSmall;
                Label14.Font.Size = FontUnit.XXSmall;
                Label15.Font.Size = FontUnit.XXSmall;
                Label16.Font.Size = FontUnit.XXSmall;
                Label17.Font.Size = FontUnit.XXSmall;
                Label18.Font.Size = FontUnit.XXSmall;
                Label19.Font.Size = FontUnit.XXSmall;
                Label20.Font.Size = FontUnit.XXSmall;
                Label21.Font.Size = FontUnit.XXSmall;
                Label22.Font.Size = FontUnit.XXSmall;
                Label23.Font.Size = FontUnit.XXSmall;
            }
            else if (DropDownList3.SelectedIndex.Equals(2))
            {
                Label24.Font.Size = FontUnit.XSmall;
                Label2.Font.Size = FontUnit.XSmall;
                Label3.Font.Size = FontUnit.XSmall;
                Label4.Font.Size = FontUnit.XSmall;
                Label5.Font.Size = FontUnit.XSmall;
                Label6.Font.Size = FontUnit.XSmall;
                Label7.Font.Size = FontUnit.XSmall;
                Label8.Font.Size = FontUnit.XSmall;
                Label9.Font.Size = FontUnit.XSmall;
                Label10.Font.Size = FontUnit.XSmall;
                Label11.Font.Size = FontUnit.XSmall;
                Label12.Font.Size = FontUnit.XSmall;
                Label13.Font.Size = FontUnit.XSmall;
                Label14.Font.Size = FontUnit.XSmall;
                Label15.Font.Size = FontUnit.XSmall;
                Label16.Font.Size = FontUnit.XSmall;
                Label17.Font.Size = FontUnit.XSmall;
                Label18.Font.Size = FontUnit.XSmall;
                Label19.Font.Size = FontUnit.XSmall;
                Label20.Font.Size = FontUnit.XSmall;
                Label21.Font.Size = FontUnit.XSmall;
                Label22.Font.Size = FontUnit.XSmall;
                Label23.Font.Size = FontUnit.XSmall;
            }
            else if (DropDownList3.SelectedIndex.Equals(3))
            {
                Label24.Font.Size = FontUnit.Small;
                Label2.Font.Size = FontUnit.Small;
                Label3.Font.Size = FontUnit.Small;
                Label4.Font.Size = FontUnit.Small;
                Label5.Font.Size = FontUnit.Small;
                Label6.Font.Size = FontUnit.Small;
                Label7.Font.Size = FontUnit.Small;
                Label8.Font.Size = FontUnit.Small;
                Label9.Font.Size = FontUnit.Small;
                Label10.Font.Size = FontUnit.Small;
                Label11.Font.Size = FontUnit.Small;
                Label12.Font.Size = FontUnit.Small;
                Label13.Font.Size = FontUnit.Small;
                Label14.Font.Size = FontUnit.Small;
                Label15.Font.Size = FontUnit.Small;
                Label16.Font.Size = FontUnit.Small;
                Label17.Font.Size = FontUnit.Small;
                Label18.Font.Size = FontUnit.Small;
                Label19.Font.Size = FontUnit.Small;
                Label20.Font.Size = FontUnit.Small;
                Label21.Font.Size = FontUnit.Small;
                Label22.Font.Size = FontUnit.Small;
                Label23.Font.Size = FontUnit.Small;
            }
            else if (DropDownList3.SelectedIndex.Equals(4))
            {
                Label24.Font.Size = FontUnit.Medium;
                Label2.Font.Size = FontUnit.Medium;
                Label3.Font.Size = FontUnit.Medium;
                Label4.Font.Size = FontUnit.Medium;
                Label5.Font.Size = FontUnit.Medium;
                Label6.Font.Size = FontUnit.Medium;
                Label7.Font.Size = FontUnit.Medium;
                Label8.Font.Size = FontUnit.Medium;
                Label9.Font.Size = FontUnit.Medium;
                Label10.Font.Size = FontUnit.Medium;
                Label11.Font.Size = FontUnit.Medium;
                Label12.Font.Size = FontUnit.Medium;
                Label13.Font.Size = FontUnit.Medium;
                Label14.Font.Size = FontUnit.Medium;
                Label15.Font.Size = FontUnit.Medium;
                Label16.Font.Size = FontUnit.Medium;
                Label17.Font.Size = FontUnit.Medium;
                Label18.Font.Size = FontUnit.Medium;
                Label19.Font.Size = FontUnit.Medium;
                Label20.Font.Size = FontUnit.Medium;
                Label21.Font.Size = FontUnit.Medium;
                Label22.Font.Size = FontUnit.Medium;
                Label23.Font.Size = FontUnit.Medium;
            }
            else if (DropDownList3.SelectedIndex.Equals(5))
            {
                Label24.Font.Size = FontUnit.Large;
                Label2.Font.Size = FontUnit.Large;
                Label3.Font.Size = FontUnit.Large;
                Label4.Font.Size = FontUnit.Large;
                Label5.Font.Size = FontUnit.Large;
                Label6.Font.Size = FontUnit.Large;
                Label7.Font.Size = FontUnit.Large;
                Label8.Font.Size = FontUnit.Large;
                Label9.Font.Size = FontUnit.Large;
                Label10.Font.Size = FontUnit.Large;
                Label11.Font.Size = FontUnit.Large;
                Label12.Font.Size = FontUnit.Large;
                Label13.Font.Size = FontUnit.Large;
                Label14.Font.Size = FontUnit.Large;
                Label15.Font.Size = FontUnit.Large;
                Label16.Font.Size = FontUnit.Large;
                Label17.Font.Size = FontUnit.Large;
                Label18.Font.Size = FontUnit.Large;
                Label19.Font.Size = FontUnit.Large;
                Label20.Font.Size = FontUnit.Large;
                Label21.Font.Size = FontUnit.Large;
                Label22.Font.Size = FontUnit.Large;
                Label23.Font.Size = FontUnit.Large;
            }
            else if (DropDownList3.SelectedIndex.Equals(6))
            {
                Label24.Font.Size = FontUnit.XLarge;
                Label2.Font.Size = FontUnit.XLarge;
                Label3.Font.Size = FontUnit.XLarge;
                Label4.Font.Size = FontUnit.XLarge;
                Label5.Font.Size = FontUnit.XLarge;
                Label6.Font.Size = FontUnit.XLarge;
                Label7.Font.Size = FontUnit.XLarge;
                Label8.Font.Size = FontUnit.XLarge;
                Label9.Font.Size = FontUnit.XLarge;
                Label10.Font.Size = FontUnit.XLarge;
                Label11.Font.Size = FontUnit.XLarge;
                Label12.Font.Size = FontUnit.XLarge;
                Label13.Font.Size = FontUnit.XLarge;
                Label14.Font.Size = FontUnit.XLarge;
                Label15.Font.Size = FontUnit.XLarge;
                Label16.Font.Size = FontUnit.XLarge;
                Label17.Font.Size = FontUnit.XLarge;
                Label18.Font.Size = FontUnit.XLarge;
                Label19.Font.Size = FontUnit.XLarge;
                Label20.Font.Size = FontUnit.XLarge;
                Label21.Font.Size = FontUnit.XLarge;
                Label22.Font.Size = FontUnit.XLarge;
                Label23.Font.Size = FontUnit.XLarge;
            }
            else if (DropDownList2.SelectedIndex.Equals(7))
            {
                Label24.Font.Size = FontUnit.XXLarge;
                Label2.Font.Size = FontUnit.XXLarge;
                Label3.Font.Size = FontUnit.XXLarge;
                Label4.Font.Size = FontUnit.XXLarge;
                Label5.Font.Size = FontUnit.XXLarge;
                Label6.Font.Size = FontUnit.XXLarge;
                Label7.Font.Size = FontUnit.XXLarge;
                Label8.Font.Size = FontUnit.XXLarge;
                Label9.Font.Size = FontUnit.XXLarge;
                Label10.Font.Size = FontUnit.XXLarge;
                Label11.Font.Size = FontUnit.XXLarge;
                Label12.Font.Size = FontUnit.XXLarge;
                Label13.Font.Size = FontUnit.XXLarge;
                Label14.Font.Size = FontUnit.XXLarge;
                Label15.Font.Size = FontUnit.XXLarge;
                Label16.Font.Size = FontUnit.XXLarge;
                Label17.Font.Size = FontUnit.XXLarge;
                Label18.Font.Size = FontUnit.XXLarge;
                Label19.Font.Size = FontUnit.XXLarge;
                Label20.Font.Size = FontUnit.XXLarge;
                Label21.Font.Size = FontUnit.XXLarge;
                Label22.Font.Size = FontUnit.XXLarge;
                Label23.Font.Size = FontUnit.XXLarge;
            }
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            quick++;
            Label25.Text = quick / 60 + ":" + ((quick % 60) >= 10 ? (quick % 60).ToString() : "0" + (quick % 60));
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {

            {
                string check = " select count(*) from [student] where Sidentity ='" + TextID.Text + "'";
                SqlCommand com = new SqlCommand(check, con);
                con.Open();
                int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
                con.Close();
                if (temp == 1)
                {
                    /*Adding new story to son list*/
                    string checks = " select count(*) from [storyrate]where Sidentity ='" + TextID.Text + "' and Storyname= '" + Nstory.Text + "'and Rate= '" + DropDownList4.Text + "'  ";
                    SqlCommand comm = new SqlCommand(checks, con);
                    con.Open();
                    int temps = Convert.ToInt32(comm.ExecuteScalar().ToString());
                    con.Close();
                    if (temps != 1)
                    {
                        string dat = "Insert into [storyrate](Sidentity,Storyname,Rate) Values('" + TextID.Text + "','" + Nstory.Text + "','" + DropDownList4.Text + "')";
                        SqlCommand commm = new SqlCommand(dat, con);
                        con.Open();
                        commm.ExecuteNonQuery();
                        con.Close();
                        string datt = "Insert into [readingtime](Sidentity,storyname,storyreadingtime) Values('" + TextID.Text + "','" + Nstory.Text + "','" + Label25.Text + "')";
                        SqlCommand commmm = new SqlCommand(datt, con);
                        con.Open();
                        commmm.ExecuteNonQuery();
                        con.Close();
                        Label27.ForeColor = System.Drawing.Color.Green;
                        Label27.Text = "You have successfully Send the story.";
                        quick = 0;
                        Response.Redirect("finishreading.aspx");
                    }
                    else
                    {
                        Label8.ForeColor = System.Drawing.Color.Red;
                        Label27.Text = "This Story is already Rate.";
                        quick = 0;
                        Response.Redirect("Studentpage.aspx");
                    }
                }
                else
                {
                    Label27.ForeColor = System.Drawing.Color.Red;
                    Label27.Text = "This id doesn't exist !!.";
                }
                
            }
        }
    }
}