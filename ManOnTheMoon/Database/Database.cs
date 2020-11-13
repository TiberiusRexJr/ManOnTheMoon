using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Web;
using System.Web.WebSockets;

namespace ManOnTheMoon.Database
{
    public class Database
    {
        string DatabaseURL = "../App_Data/ManOnTheMoonDB.mdf";

        #region Constructor
            public Database()
        {
            try
            {

            DataContext db = new DataContext(DatabaseURL);
            }
            catch(Exception e)
            {
                System.Console.WriteLine(e.Message);
            }

        }
        #endregion
        #region Methods
        #region CRUD
        //Create
        #region Create
            
        #endregion
        //ReTrieve
        #region Retrieve

        #endregion
        //Update
        #region Update

        #endregion
        //Delete
        #region Delete

        #endregion
        #endregion
        #endregion
    }
}