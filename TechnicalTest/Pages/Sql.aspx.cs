using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace TechnicalTest.Pages
{
    public partial class Sql : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Part 1 - Modify the InsertUsers function to insert Users into the database. Uncomment the line below to begin
            //InsertUsers();

            // Part 2 - Modify the SQL command within the DisplayActiveUsers function to display users that are activated. Uncomment the line below to begin
            //DisplayActiveUsers();

            // Part 3 - Determine the issue with the SqlBug function. Uncomment the line below to begin
            //SqlBug();
        }

        /// <summary>
        /// Insert 5 users into the Users table using SQL. 
        /// Use "enLabelDatabase.dbo.[User]" for the table name. The columns and their datatypes can be viewed in the SQL Server Object Explorer window
        /// Make sure to insert some users that are "Activated" and some that are not
        /// </summary>
        protected void InsertUsers()
        {
            string sqlCommand = ""; // Put insert statements here

            ExecuteNonQuery(sqlCommand, "enLabelDatabase");


        }
        /// <summary>
        ///  Write a SQL statement to retrieve all active users from the Users table. 
        ///  Use "enLabelDatabase.dbo.[User]" for the table name and "Activated" as the column
        /// </summary>
        protected void DisplayActiveUsers()
        {
            string sqlCommand = ""; //Edit this line
            DataSet dataSet = ExecuteDataSet(sqlCommand, "enLabelDatabase");


            gridView.DataSource = dataSet.Tables[0];
            gridView.DataBind();
        }

        /// <summary>
        /// Resolve any issues with the below function
        /// </summary>
        /// <returns></returns>
        protected DataSet SqlBug()
        {
            string sqlCommand = "SELECT Users FROM enLabelDatabase.dbo.[User]";

            DataSet dataSet = ExecuteDataSet(sqlCommand, "enLabelDtabase");
            return dataSet;
        }



        /// <summary>
        /// Basic function for executing SQL queries on the database
        /// </summary>
        /// <param name="sqlCommand"></param>
        /// <param name="databaseName"></param>
        /// <returns></returns>
        protected DataSet ExecuteDataSet(string sqlCommand, string databaseName)
        {
            var databaseProviderFactory = new DatabaseProviderFactory();

            Database database = databaseProviderFactory.Create("enLabelDatabase");
            DbCommand dbCommand = database.GetSqlStringCommand(sqlCommand);

            DataSet dataSet = database.ExecuteDataSet(dbCommand);
            return dataSet;
        }

        /// <summary>
        /// Basic function for executing SQL commands on the database
        /// </summary>
        /// <param name="sqlCommand"></param>
        /// <param name="databaseName"></param>
        /// <returns></returns>
        protected int ExecuteNonQuery(string sqlCommand, string databaseName)
        {
            var databaseProviderFactory = new DatabaseProviderFactory();

            Database database = databaseProviderFactory.Create("enLabelDatabase");
            DbCommand dbCommand = database.GetSqlStringCommand(sqlCommand);

            int rowsAffected = database.ExecuteNonQuery(dbCommand);
            return rowsAffected;
        }
    }
}