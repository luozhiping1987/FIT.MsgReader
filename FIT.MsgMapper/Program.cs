using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FIT.MsgMapper
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

            MainControl uc = new MainControl();
            uc.Dock = DockStyle.Fill;
            uc.ApplyFormEvents = false;
            Form frm = new Form();
            frm.Controls.Add(uc);

            Application.Run(frm);
        }
    }
}
