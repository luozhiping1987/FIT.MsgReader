using System;
using System.Windows.Forms;

namespace FIT.MsgViewer
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
            try
            {
                ViewerControl uc = new ViewerControl();
                uc.Dock = DockStyle.Fill;
                uc.ApplyFormEvents = true;
                Form frm = new Form();
                frm.Controls.Add(uc);                
                Application.Run(frm);
            }
            catch (Exception exception)
            {
                // ReSharper disable once LocalizableElement
                MessageBox.Show(exception.Message, "An exception occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
