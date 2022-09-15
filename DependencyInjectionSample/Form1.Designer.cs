
namespace DependencyInjectionSample
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button_Add = new System.Windows.Forms.Button();
            this.richTextBox_Info = new System.Windows.Forms.RichTextBox();
            this.Button_Transient = new System.Windows.Forms.Button();
            this.Button_Scoped = new System.Windows.Forms.Button();
            this.Button_Singleton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button_Printer = new System.Windows.Forms.Button();
            this.richTextBox_PrinterInfo = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 22);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(677, 388);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button_Add);
            this.tabPage1.Controls.Add(this.richTextBox_Info);
            this.tabPage1.Controls.Add(this.Button_Transient);
            this.tabPage1.Controls.Add(this.Button_Scoped);
            this.tabPage1.Controls.Add(this.Button_Singleton);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(669, 362);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Instance";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(25, 271);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(106, 23);
            this.button_Add.TabIndex = 6;
            this.button_Add.Text = "Add Log";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // richTextBox_Info
            // 
            this.richTextBox_Info.Location = new System.Drawing.Point(137, 22);
            this.richTextBox_Info.Name = "richTextBox_Info";
            this.richTextBox_Info.Size = new System.Drawing.Size(459, 300);
            this.richTextBox_Info.TabIndex = 5;
            this.richTextBox_Info.Text = "";
            // 
            // Button_Transient
            // 
            this.Button_Transient.Location = new System.Drawing.Point(25, 117);
            this.Button_Transient.Name = "Button_Transient";
            this.Button_Transient.Size = new System.Drawing.Size(106, 28);
            this.Button_Transient.TabIndex = 4;
            this.Button_Transient.Tag = "Scoped";
            this.Button_Transient.Text = "Transient API";
            this.Button_Transient.UseVisualStyleBackColor = true;
            this.Button_Transient.Click += new System.EventHandler(this.Button_Transient_Click);
            // 
            // Button_Scoped
            // 
            this.Button_Scoped.Location = new System.Drawing.Point(25, 68);
            this.Button_Scoped.Name = "Button_Scoped";
            this.Button_Scoped.Size = new System.Drawing.Size(106, 28);
            this.Button_Scoped.TabIndex = 1;
            this.Button_Scoped.Tag = "Scoped";
            this.Button_Scoped.Text = "Scoped API";
            this.Button_Scoped.UseVisualStyleBackColor = true;
            this.Button_Scoped.Click += new System.EventHandler(this.Button_Scoped_Click);
            // 
            // Button_Singleton
            // 
            this.Button_Singleton.Location = new System.Drawing.Point(25, 22);
            this.Button_Singleton.Name = "Button_Singleton";
            this.Button_Singleton.Size = new System.Drawing.Size(106, 28);
            this.Button_Singleton.TabIndex = 0;
            this.Button_Singleton.Tag = "Singleton";
            this.Button_Singleton.Text = "Singleton API";
            this.Button_Singleton.UseVisualStyleBackColor = true;
            this.Button_Singleton.Click += new System.EventHandler(this.Button_Singleton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.richTextBox_PrinterInfo);
            this.tabPage2.Controls.Add(this.button_Printer);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(669, 362);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Multi Method 抽換";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button_Printer
            // 
            this.button_Printer.Location = new System.Drawing.Point(18, 6);
            this.button_Printer.Name = "button_Printer";
            this.button_Printer.Size = new System.Drawing.Size(75, 23);
            this.button_Printer.TabIndex = 0;
            this.button_Printer.Text = "Printer";
            this.button_Printer.UseVisualStyleBackColor = true;
            this.button_Printer.Click += new System.EventHandler(this.button_Printer_Click);
            // 
            // richTextBox_PrinterInfo
            // 
            this.richTextBox_PrinterInfo.Location = new System.Drawing.Point(99, 8);
            this.richTextBox_PrinterInfo.Name = "richTextBox_PrinterInfo";
            this.richTextBox_PrinterInfo.Size = new System.Drawing.Size(530, 350);
            this.richTextBox_PrinterInfo.TabIndex = 1;
            this.richTextBox_PrinterInfo.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 425);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "DI Sample";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button Button_Singleton;
        private System.Windows.Forms.Button Button_Scoped;
        private System.Windows.Forms.Button Button_Transient;
        private System.Windows.Forms.RichTextBox richTextBox_Info;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.RichTextBox richTextBox_PrinterInfo;
        private System.Windows.Forms.Button button_Printer;
    }
}

