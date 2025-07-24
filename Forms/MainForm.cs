using System;
using System.Diagnostics;
using System.Windows.Forms;
namespace RealEstateManagementSystem.Forms {
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // Event handler for managing properties button click
        private void btnManageProperties_Click(object sender, EventArgs e)
        {
            //    
            ManagePropertiesForm managePropertiesForm = new ManagePropertiesForm();
            managePropertiesForm.ShowDialog();
        }

        // Event handler for reserving vacation button click
        private void btnReserveVacation_Click(object sender, EventArgs e)
        {
            //     
            ReserveVacationForm reserveVacationForm = new ReserveVacationForm();
            reserveVacationForm.ShowDialog();
        }

        // Event handler for displaying information about the software
        private void btnInfo_Click(object sender, EventArgs e)
        {
            //      
            string infoMessage = "   \"   .\n\n" +
                                 ":\n" +
                                 "1.  \n" +
                                 "2.  '\n" +
                                 "3.  \n" +
                                 "4.  ";

            MessageBox.Show(infoMessage, "  ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Overridden method called when the form is closed
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);

            // Call the method to kill the process when the form is closed
            KillProcessByName("RealEstateManagementSystem");

            // Exit the application
            Application.Exit();
        }

        // Method to kill the process by name
        private void KillProcessByName(string processName)
        {
            // Get all processes with the specified name
            Process[] processes = Process.GetProcessesByName(processName);

            // Iterate through each process and kill it
            foreach (Process process in processes)
            {
                try
                {
                    process.Kill(); // Terminate the process
                    process.WaitForExit(); // Wait for the process to terminate
                }
                catch (Exception ex)
                {
                    // Display an error message if there's an issue killing the process
                    MessageBox.Show($"Error terminating process: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
