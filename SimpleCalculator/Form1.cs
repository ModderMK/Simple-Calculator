using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SimpleCalculator
{
    public partial class Form : System.Windows.Forms.Form
    {
        decimal currentValue;
        decimal previousValue;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public Form()
        {
            InitializeComponent();
        }
        private void dragForm(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void changeRichtxtVisor(string text){
            richtxtVisor.Text = text;
            richtxtVisor.Refresh();
        }

        private void btnClick(object sender, EventArgs e)
        {
            var button = (Button)sender;
            String buttonName = button.Name.ToString();
            switch (buttonName){
                case "btnClear":

                    break;
                case "btnClearEntry":

                    break;
                case "btnBackspace":
                    
                    break;
                case "btnDivide":

                    break;
                case "btnMultiply":

                    break;
                case "btnMinus":

                    break;
                case "btnPlus":

                    break;
                case "btnEquals":

                    break;
                case "btnPlusMinus":

                    break;
                case "btnDot":

                    break;
                case "btnNumber0":

                    break;
                case "btnNumber1":

                    break;
                case "btnNumber2":

                    break;
                case "btnNumber3":

                    break;
                case "btnNumber4":

                    break;
                case "btnNumber5":

                    break;
                case "btnNumber6":

                    break;
                case "btnNumber7":

                    break;
                case "btnNumber8":

                    break;
                case "btnNumber9":

                    break;
                default:
                    MessageBox.Show("Object Name:"+buttonName, "ERRO:");
                    break;
            }
        }
    }
}