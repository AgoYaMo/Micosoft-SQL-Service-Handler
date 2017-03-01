using System.ServiceProcess;
using System.Diagnostics;

namespace Service
{
    class Program
    {
        static void Main(string[] args)
        {
            //Server name
            //SQLEXPRESS
            //ServiceController service = new ServiceController("MSSQL$SQLEXPRESS");
            //MSSQLSERVER
            ServiceController service = new ServiceController("MSSQLSERVER");
            
            ProcessStartInfo exe = new ProcessStartInfo();

            //Microsoft SQL Server Management Studio Path
            //2014
            //exe.FileName = @"C:\Program Files (x86)\Microsoft SQL Server\120\Tools\Binn\ManagementStudio\Ssms.exe";
            //2016
            exe.FileName = @"C:\Program Files (x86)\Microsoft SQL Server\130\Tools\Binn\ManagementStudio\Ssms.exe";

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
