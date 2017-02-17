using System.ServiceProcess;
using System.Diagnostics;

namespace Service
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceController service = new ServiceController("MSSQL$SQLEXPRESS");
            //Microsoft SQL Server Management Studio Path
            ProcessStartInfo exe = new ProcessStartInfo(@"C:\Program Files (x86)\Microsoft SQL Server\120\Tools\Binn\ManagementStudio\Ssms.exe");
            if (service.Status == ServiceControllerStatus.Stopped)
            {
                service.Start();
            }
            Process process = Process.Start(exe);
            process.WaitForExit();
            service.Stop();
        }
    }
}
