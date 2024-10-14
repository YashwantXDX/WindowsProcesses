using System.Diagnostics;

namespace WindowsProcesses
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer timer;

        public Form1()
        {
            InitializeComponent();
            InitializeDataGridView();
            InitializeTimer();
        }

        private void InitializeDataGridView()
        {
            // Columns for Memory usage and the name of Process
            dataGridViewProcesses.ColumnCount = 2;
            dataGridViewProcesses.Columns[0].Name = "Process Name";
            dataGridViewProcesses.Columns[1].Name = "Memory (MB)";

            // Data Grid Autosizing
            dataGridViewProcesses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // To update on each second, Set timer interval to 1000
        private void InitializeTimer()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(OnTimerTick); // Update on every tick
            timer.Start();
        }

        private void OnTimerTick(object sender, EventArgs e)
        {
            RefreshProcessList();
        }

        // Now to fetch the processes in decreasing order
        private void RefreshProcessList()
        {
            dataGridViewProcesses.Rows.Clear();

            try
            {
                // Get all running processes
                var processes = Process.GetProcesses();

                // Sorting 20 processes in descending order
                var topProcesses = processes
                    .OrderByDescending(p => p.WorkingSet64)
                    .Take(20)
                    .Select(p => new
                    {
                        ProcessName = p.ProcessName,
                        MemoryUsage = p.WorkingSet64 / (1024 * 1024) // Convert to MB
                    });

                // Show process name and memory usage side by side
                foreach (var process in topProcesses)
                {
                    dataGridViewProcesses.Rows.Add(process.ProcessName, process.MemoryUsage);
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show($"Error retrieving process data: {ex.Message}");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
