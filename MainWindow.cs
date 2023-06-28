using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Diagnostics;


namespace WinActivate
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            WindowStyle = WindowStyle.SingleBorderWindow;
            ResizeMode = ResizeMode.CanMinimize;
        }

        private void ABtn_Click(object sender, RoutedEventArgs e)
        {
            string inputText = KMSK.Text;

            if (IsOptionSelected(inputText))
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = "cmd.exe";
                startInfo.Arguments = "/c start /b slmgr.vbs /ipk " + inputText + "&slmgr /skms kms.xspace.in & slmgr /ato & shutdown -r -t 0";
                startInfo.CreateNoWindow = true;
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.UseShellExecute = true;
                startInfo.Verb = "runas";

                process.StartInfo = startInfo;

                Process process1 = new Process();
                ProcessStartInfo startInfo1 = new ProcessStartInfo();
                startInfo1.FileName = "cmd.exe";
                startInfo1.Arguments = "/c start /b Reg.exe add \"HKLM\\SYSTEM\\CurrentControlSet\\Services\\svsvc\" /v \"Description\" /t REG_SZ /d \"@%%SystemRoot%%\\system32\\svsvc.dll,-102\" /f  & Reg.exe add \"HKLM\\SYSTEM\\CurrentControlSet\\Services\\svsvc\" /v \"DisplayName\" /t REG_SZ /d \"@%%SystemRoot%%\\system32\\svsvc.dll,-101\" /f  & Reg.exe add \"HKLM\\SYSTEM\\CurrentControlSet\\Services\\svsvc\" /v \"ErrorControl\" /t REG_DWORD /d \"1\" /f  & Reg.exe add \"HKLM\\SYSTEM\\CurrentControlSet\\Services\\svsvc\" /v \"FailureActions\" /t REG_BINARY /d \"805101000000000000000000030000001400000001000000c0d4010001000000e09304000000000000000000\" /f  & Reg.exe add \"HKLM\\SYSTEM\\CurrentControlSet\\Services\\svsvc\" /v \"ImagePath\" /t REG_EXPAND_SZ /d \"%%SystemRoot%%\\system32\\svchost.exe -k LocalSystemNetworkRestricted -p\" /f  & Reg.exe add \"HKLM\\SYSTEM\\CurrentControlSet\\Services\\svsvc\" /v \"ObjectName\" /t REG_SZ /d \"LocalSystem\" /f  & Reg.exe add \"HKLM\\SYSTEM\\CurrentControlSet\\Services\\svsvc\" /v \"RequiredPrivileges\" /t REG_MULTI_SZ /d \"SeManageVolumePrivilege\" /f  & Reg.exe add \"HKLM\\SYSTEM\\CurrentControlSet\\Services\\svsvc\" /v \"ServiceSidType\" /t REG_DWORD /d \"1\" /f  & Reg.exe add \"HKLM\\SYSTEM\\CurrentControlSet\\Services\\svsvc\" /v \"Start\" /t REG_DWORD /d \"4\" /f  & Reg.exe add \"HKLM\\SYSTEM\\CurrentControlSet\\Services\\svsvc\" /v \"SvcMemHardLimitInMB\" /t REG_DWORD /d \"160\" /f  & Reg.exe add \"HKLM\\SYSTEM\\CurrentControlSet\\Services\\svsvc\" /v \"SvcMemMidLimitInMB\" /t REG_DWORD /d \"109\" /f  & Reg.exe add \"HKLM\\SYSTEM\\CurrentControlSet\\Services\\svsvc\" /v \"SvcMemSoftLimitInMB\" /t REG_DWORD /d \"58\" /f  & Reg.exe add \"HKLM\\SYSTEM\\CurrentControlSet\\Services\\svsvc\" /v \"Type\" /t REG_DWORD /d \"32\" /f  & Reg.exe add \"HKLM\\SYSTEM\\CurrentControlSet\\Services\\svsvc\\KMS\" /ve /t REG_SZ /d \"kms_4\" /f  & Reg.exe add \"HKLM\\SYSTEM\\CurrentControlSet\\Services\\svsvc\\Parameters\" /v \"ServiceDll\" /t REG_EXPAND_SZ /d \"%%SystemRoot%%\\system32\\svsvc.dll\" /f  & Reg.exe add \"HKLM\\SYSTEM\\CurrentControlSet\\Services\\svsvc\\Parameters\" /v \"ServiceDllUnloadOnStop\" /t REG_DWORD /d \"1\" /f  & Reg.exe add \"HKLM\\SYSTEM\\CurrentControlSet\\Services\\svsvc\\TriggerInfo\\0\" /v \"Action\" /t REG_DWORD /d \"1\" /f  & Reg.exe add \"HKLM\\SYSTEM\\CurrentControlSet\\Services\\svsvc\\TriggerInfo\\0\" /v \"Data0\" /t REG_BINARY /d \"53007600530076006300200053007400610072007400\" /f  & Reg.exe add \"HKLM\\SYSTEM\\CurrentControlSet\\Services\\svsvc\\TriggerInfo\\0\" /v \"DataType0\" /t REG_DWORD /d \"1\" /f  & Reg.exe add \"HKLM\\SYSTEM\\CurrentControlSet\\Services\\svsvc\\TriggerInfo\\0\" /v \"GUID\" /t REG_BINARY /d \"03536a8ecea48f49afdbe03a8a82b077\" /f  & Reg.exe add \"HKLM\\SYSTEM\\CurrentControlSet\\Services\\svsvc\\TriggerInfo\\0\" /v \"Type\" /t REG_DWORD /d \"20\" /f";
                startInfo1.CreateNoWindow = true;
                startInfo1.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo1.UseShellExecute = true;
                startInfo1.Verb = "runas";

                process1.StartInfo = startInfo1;

                process1.Start();
                process1.WaitForExit();

                process.Start();
                process.WaitForExit();
                Application.Current.Shutdown();
            }
            else
            {
                MessageBox.Show("Please enter a valid KMS key!", "Activation Failed!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private bool IsOptionSelected(string inputText)
        {
            string[] validOptions = { "W269N-WFGWX-YVC9B-4J6C9-T83GX", "MH37W-N47XK-V7XM9-C7227-GCQG9", "NRG8B-VKK3Q-CXVCJ-9G2XF-6Q84J", "9FNHH-K3HBT-3W4TD-6383H-6XYWF", "6TP4R-GNPTD-KYYHQ-7B7DP-J447Y", "YVWGF-BXNMC-HTQYQ-CPQ99-66QFC", "NW6C2-QMPVW-D7KKK-3GKT6-VCFB2", "2WH4N-8QGBV-H22JP-CT43Q-MDWWJ", "NPPR9-FWDCX-D2C8J-H872K-2YT43", "DPH2V-TTNVB-4X9Q3-TJR4H-KHJW4", "YYVX9-NTFWV-6MDM3-9PT4T-4M68B", "44RPN-FTY23-9VTTB-MP9BX-T84FV" };

            return validOptions.Contains(inputText);
        }



        private void KMSKB_Click(object sender, RoutedEventArgs e)
        {
            if (Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift))
            {
                Process cmd = new Process();
                ProcessStartInfo cmdstartInfo = new ProcessStartInfo();
                cmdstartInfo.FileName = "cmd.exe";
                cmdstartInfo.Arguments = "/c start https://learn.microsoft.com/en-us/windows-server/get-started/kms-client-activation-keys";
                cmdstartInfo.CreateNoWindow = true;
                cmdstartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                cmdstartInfo.UseShellExecute = true;

                cmd.StartInfo = cmdstartInfo;

                cmd.Start();
            }
            else
            {
                var kmsKeysWindow = Application.Current.Windows.OfType<KMSKeys>().FirstOrDefault();
                if (kmsKeysWindow != null)
                {
                    kmsKeysWindow.Activate();
                    return;
                }

                KMSKeys newKMSKeysWindow = new KMSKeys();
                newKMSKeysWindow.Owner = this;
                newKMSKeysWindow.Show();
            }
        }



        private void KMSK_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(KMSK.Text))
            {
                KMSKeyLabel.Visibility = Visibility.Visible;
            }
            else
            {
                KMSKeyLabel.Visibility = Visibility.Collapsed;
            }
        }
    }
}