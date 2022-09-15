using DependencyInjectionSample.Controller;
using System;
using System.Windows.Forms;

namespace DependencyInjectionSample
{
    public partial class Dialog : Form
    {

        private LogController LogController;
        public Dialog(LogController logController)
        {
            InitializeComponent();
            LogController = logController;
        }  

        private void Dialog_Load(object sender, EventArgs e)
        {
            //label_ScopeUUID.Text = LogController.OperationId("Scoped")+"\n"+ LogController.ScopedLogRepository.InvaildOperationId("Scoped");
            richTextBox_Info.AppendText(LogController.OperationID()+"\n\n");
            richTextBox_Info.AppendText(LogController.LogService.OperationID() + "\n\n");
            richTextBox_Info.AppendText("\n\n\n");


            //richTextBox_Info.AppendText(LogController.QueryLogCount() + "\n\n");
            //richTextBox_Info.AppendText(LogController.LogService.QueryLogCount() + "\n\n");

        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
