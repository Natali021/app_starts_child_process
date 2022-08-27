
namespace WindowsFormsApp_2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_StartCalc = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.MyProcess = new System.Diagnostics.Process();
            this.textBox_ExitCode = new System.Windows.Forms.TextBox();
            this.label_ExitCode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_StartCalc
            // 
            this.button_StartCalc.BackColor = System.Drawing.Color.Teal;
            this.button_StartCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_StartCalc.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button_StartCalc.Location = new System.Drawing.Point(330, 47);
            this.button_StartCalc.Name = "button_StartCalc";
            this.button_StartCalc.Size = new System.Drawing.Size(112, 41);
            this.button_StartCalc.TabIndex = 0;
            this.button_StartCalc.Text = "StartCalc";
            this.button_StartCalc.UseVisualStyleBackColor = false;
            this.button_StartCalc.Click += new System.EventHandler(this.button_StartCalc_Click);
            // 
            // button_Close
            // 
            this.button_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Close.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button_Close.Location = new System.Drawing.Point(440, 150);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(128, 41);
            this.button_Close.TabIndex = 2;
            this.button_Close.Text = "Close";
            this.button_Close.UseVisualStyleBackColor = false;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // MyProcess
            // 
            this.MyProcess.EnableRaisingEvents = true;
            this.MyProcess.StartInfo.Domain = "";
            this.MyProcess.StartInfo.LoadUserProfile = false;
            this.MyProcess.StartInfo.Password = null;
            this.MyProcess.StartInfo.StandardErrorEncoding = null;
            this.MyProcess.StartInfo.StandardOutputEncoding = null;
            this.MyProcess.StartInfo.UserName = "";
            this.MyProcess.SynchronizingObject = this;
            this.MyProcess.Exited += new System.EventHandler(this.MyProcess_Exited);
            // 
            // textBox_ExitCode
            // 
            this.textBox_ExitCode.Location = new System.Drawing.Point(216, 170);
            this.textBox_ExitCode.Multiline = true;
            this.textBox_ExitCode.Name = "textBox_ExitCode";
            this.textBox_ExitCode.Size = new System.Drawing.Size(129, 147);
            this.textBox_ExitCode.TabIndex = 3;
            // 
            // label_ExitCode
            // 
            this.label_ExitCode.AutoSize = true;
            this.label_ExitCode.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_ExitCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_ExitCode.Location = new System.Drawing.Point(224, 150);
            this.label_ExitCode.Name = "label_ExitCode";
            this.label_ExitCode.Size = new System.Drawing.Size(103, 17);
            this.label_ExitCode.TabIndex = 4;
            this.label_ExitCode.Text = "Status Process";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_ExitCode);
            this.Controls.Add(this.textBox_ExitCode);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.button_StartCalc);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_StartCalc;
        private System.Windows.Forms.Button button_Close;
        private System.Diagnostics.Process MyProcess;
        private System.Windows.Forms.TextBox textBox_ExitCode;
        private System.Windows.Forms.Label label_ExitCode;
    }
}

