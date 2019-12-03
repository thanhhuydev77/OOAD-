﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Account
    {
        private string connectionString;

        public string ConnectionString {
            get { return connectionString; }
            set { connectionString = value; }
        }

        public DAL_Account() {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

        public int UpdateAccount(string username, string password) {
            using (SqlConnection con = new SqlConnection(connectionString)) {
                using (SqlCommand cmd = new SqlCommand()) {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = "Update [dbo].[tblAccount] set passWord = '" + password + "' where userName = '" + username + "'";
                    try {
                        con.Open();
                        var reader = cmd.ExecuteNonQuery();
                        if (reader > 0) {
                            con.Close();
                            con.Dispose();
                            return 1;
                        }
                    } catch {
                        con.Close();
                    }
                }

            }
            return 0;
        }

        public int loadright(string data) {
            string query = string.Empty;
            query = "SELECT phanquyen FROM tblnhanvien a,tblaccount b where a.userid = b.id and b.userName ='" + data + "' ";
            using (SqlConnection con = new SqlConnection(connectionString)) {
                using (SqlCommand cmd = new SqlCommand()) {
                    int result = 0;
                    cmd.Connection = con;
                    cmd.CommandText = query;



                    try {
                        con.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows == true) {
                            while (reader.Read()) {
                                
                                    result = (int)reader[0];
                                }
                        }
                        con.Close();
                        con.Dispose();
                        return result;

                    } catch {
                        con.Close();
                    }
                }
                return 0;
            }
        
    }

        public int CheckLogin(string username, string password) {
            using (SqlConnection con = new SqlConnection(connectionString)) {
                using (SqlCommand cmd = new SqlCommand()) {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "CheckLogin";

                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);



                    //try
                    {
                        con.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows) {
                            con.Close();
                            con.Dispose();
                            return 1;
                        }
                    }
                    //catch
                    {
                        con.Close();
                    }
                }

            }
            return 0;
        }

        public string findstaffname(string username) {
            string query = string.Empty;
            query = "SELECT hoten FROM tblnhanvien a,tblaccount b where a.userid = b.id and b.userName ='"+username+"' ";
            using (SqlConnection con = new SqlConnection(connectionString)) {
                using (SqlCommand cmd = new SqlCommand()) {
                    string result = "";
                    cmd.Connection = con;
                    cmd.CommandText = query;



                    try {
                        con.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows == true) {
                            while (reader.Read()) {
                                result = (string)(reader[0]);
                            }
                        }
                        con.Close();
                        con.Dispose();
                        return result;

                    } catch {
                        con.Close();
                    }
                }
                return "";
            }
        }
    }
}
