using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

// $G$ THE-001 (-14) Grade: 86 on patterns selection / accuracy in implementation / description / document / diagrams (50%) (see comments in document)
// $G$ RUL-007 (-160) Late submission (-4 days).
// $G$ CSS-999 (-10) Coding Standards and StyleCop errors.
// $G$ DSN-999 (-7) Wrong implementation of Builder pattern - All methods (but one) is private.

namespace BasicFacebookFeatures
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            FacebookService.s_UseForamttedToStrings = true;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}
