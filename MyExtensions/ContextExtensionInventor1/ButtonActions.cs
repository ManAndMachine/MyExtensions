using System.Windows;

namespace ContextExtensionInventor1
{
    internal class ButtonActions
    {
        public static void Button1_Execute()
        {
            //TODO: add code below for the button click callback.


            //tests our connection to our logger.
            ContextExtensionInventor1.log.Debug("Button Extension button was clicked!");
            //shows the user a messagebox
            MessageBox.Show("Hello from the first context menu extension!");
            //tests our connection to the Inventor application itself.
            Reporting reporter = new Reporting();
            reporter.UpdateStatusBar("Hello from the first context menu extension!");
        }
    }
}
