﻿using System;
using System.Windows.Forms;
using static Project.Utilities;


namespace Project
{

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoadRooms();
            Application.Run(new FormRoomManagement());
        }

    }
}