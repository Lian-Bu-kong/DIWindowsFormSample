using Autofac;
using DependencyInjectionSample.Controller;
using DependencyInjectionSample.Printer;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DependencyInjectionSample
{

    public partial class Form1 : Form
    {
        private LogController LogController;
        private LogController2 LogController2;

        // 多重注入
        private IEnumerable<IPrinter> Printer;

        public Form1(IEnumerable<IPrinter> printer,
                     LogController logController, 
                     LogController2 logController2)
        {
            InitializeComponent();
            LogController = logController;
            LogController2 = logController2;
            // 多重注入
            Printer = printer;
        }


        private void Button_Singleton_Click(object sender, EventArgs e)
        {
            //var provider = DIServiceConfigure.GetProvider();
            //var logController = provider.GetRequiredService<ILogController>();
            var log = "Log1(Singleton):"+"UUID-"+LogController.OperationId("Singleton");
            var log2 = "Log2(Singleton):" + "UUID-" + LogController2.OperationId("Singleton");
            richTextBox_Info.AppendText(log+"\n");
            richTextBox_Info.AppendText(log2 + "\n");
            //richTextBox_Info.AppendText(LogController.QueryLogCount());
        }

        private void Button_Scoped_Click(object sender, EventArgs e)
        {
            // Controller Scope測試
            //var newProvider = DIServiceConfigure.GetProvider().CreateScope();
            //var logController = newProvider.ServiceProvider.GetRequiredService<LogController>();
            //var log = "Log1(Transient):" + "UUID-" + logController.GUID.ToString();
            //var log2 = "Log1(Transient):" + "UUID-" + logController.GUID.ToString();
            //richTextBox_Info.AppendText(log + "\n");
            //richTextBox_Info.AppendText(log2 + "\n");
            
            // Net DI
            var newProvider = DIServiceConfigure.GetProvider().CreateScope();
            var dilog = newProvider.ServiceProvider.GetRequiredService<Dialog>();

            // Autofac
            //var newProvider = AutofacConfig.Container.BeginLifetimeScope();
            //var dilog = newProvider.Resolve<Dialog>();
            dilog.Show();
        }

        private void Button_Transient_Click(object sender, EventArgs e)
        {
            // 模擬多次Request
            //var provider = DIServiceConfigure.GetProvider();
            //var logController = provider.GetRequiredService<LogController>();
            //var log = "Log1(Transient):" + "UUID-" + logController.GUID.ToString();
            //richTextBox_Info.AppendText(log + "\n");

            // 模擬單次Request
            var log = "Log1(Transient):" + "UUID-" + LogController.OperationId("Transient");
            var log2 = "Log2(Transient):" + "UUID-" + LogController2.OperationId("Transient");
            richTextBox_Info.AppendText(log + "\n");
            richTextBox_Info.AppendText(log2 + "\n");

            //richTextBox_Info.AppendText(LogController.QueryLogCount());
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            LogController.AddLog("TestLevel", "Test");
        }

        private void button_Printer_Click(object sender, EventArgs e)
        {
            foreach(var printer in Printer)
            {
                richTextBox_PrinterInfo.AppendText("\n");
                printer.PirnterOut("Printer Out");
            }
        }
    }
}
