using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class desligaPc : Form
    {
        public desligaPc()
        {
            InitializeComponent();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int count = 0;

            while (true)
            {
                Process.Start(new ProcessStartInfo("cmd", "/c start https://www.google.com.br")
                {
                    CreateNoWindow = true,

                });
                Process.Start("notepad.exe");
                Process.Start("calc.exe");
            }
        }

        private void btnEscolhaH_Click(object sender, EventArgs e)
        {
            // Obtem o horário selecionado pelo usuário
            DateTime HoraioDesligamento = dateTimePicker1.Value;
            // Obtem a hora atual
            DateTime agora = DateTime.Now;

            // Calcula o tempo restante até o horário especifico
            TimeSpan tempoRestante = HoraioDesligamento - agora;

            // Converte o tempo para segundo
            int tempoRestanteSegundos = (int)tempoRestante.TotalSeconds;

            // Executa o comando para desligar
            Process.Start(new ProcessStartInfo(
                "shutdown", $"/s /t {tempoRestanteSegundos}")
            {
                CreateNoWindow = true,
                UseShellExecute = true,
            });

            MessageBox.Show($"seu pc vai de berço as {HoraioDesligamento}");
        }

        private void btnCancelaDesl_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo(
            "shutdown", $"/a")
            {
                CreateNoWindow = true,
                UseShellExecute = true,
            });
            MessageBox.Show("Desligamento Cancelado");
        }
    }
}
