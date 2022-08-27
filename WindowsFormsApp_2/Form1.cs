using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;/*подключаем*/


namespace WindowsFormsApp_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //инициализируем свойство StartInfo
            MyProcess.StartInfo = new System.Diagnostics.ProcessStartInfo("HW_2_Calc.exe");  //запускаем приложение - картинку калькулятора
            //см в папке Debug файл екзешный. Можно поставить любой другой и тут его прописать для запуска         
        }

        private void button_StartCalc_Click(object sender, EventArgs e)
        {

            MyProcess.Start();
            this.textBox_ExitCode.Text = "Start";
            //ожидаем закрытия процесса
            // MyProcess.WaitForExit();
            /* Есть два способа получить уведомление о завершении связанного процесса: 
            синхронно и асинхронно. Синхронное уведомление означает вызов метода WaitForExit для блокировки текущего потока до завершения 
            процесса. В асинхронном уведомлении используется событие Exited , которое позволяет вызывающему потоку тем временем продолжить
            выполнение. В последнем случае для EnableRaisingEvents необходимо установить значение, чтобы trueвызывающее приложение
            получило событие Exited.*/
                      
        }

      
        private void button_Close_Click(object sender, EventArgs e)
        {
            
            if (!MyProcess.HasExited)
            {
                MyProcess.CloseMainWindow();
                MyProcess.Close();
                //MyProcess.Kill();
            }
        }

        //событие завершения процесса
        private void MyProcess_Exited(object sender, EventArgs e)
        {
            //выводим код с которым завершился процесс  
            string text= "ExitCode = " + MyProcess.ExitCode.ToString();
            //this.textBox_ExitCode.Text = MyProcess.ExitCode.ToString();
            this.textBox_ExitCode.Text = text;
            //MyProcess.Close();
        }
    }
}

       
   
