using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void informaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string info = $"Sistema Operacional : {Environment.OSVersion}\n" +
                          $"Arquitetura : {(Environment.Is64BitOperatingSystem ? "64 Bits" : "32" )}" +
                          $"Processador {System.Environment.GetEnvironmentVariable("PROCESSOR_IDENTIFIER")}";

            MessageBox.Show(info);

        }

        private void apagarAqruicosTempráriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Exibe uma Mensagem de Confirmação
            var result = MessageBox.Show("Certeza? Vai que da ruim : ", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                //Captura o caminho da pasta temporário do windows
                string tempPatch = Path.GetTempPath();
                // Rodar Metódo apagar os arquivos que vamos criar
                DeletarArquivosTemporários(tempPatch);
            }
            
        }

        private void DeletarArquivosTemporários(string tempPatch)
        {
            //Tente deletar
            try
            {
                // Se apasta Existir
                if (Directory.Exists(tempPatch))
                {
                    DirectoryInfo di = new DirectoryInfo(tempPatch);

                    // Deleta todos os arquivos encontrados
                    foreach (FileInfo file in di.GetFiles())
                    {
                        file.Delete();
                    }
                    // Deleta todas as pastas
                    foreach (DirectoryInfo dir in di.GetDirectories())
                    {
                        dir.Delete();
                    }
                }
                else
                {
                    MessageBox.Show("A pasta não existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void desligarComputadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Criar uma instância ('conexão') com o foem 2
            desligaPc desliga = new desligaPc();
            desliga.ShowDialog();
        }
    }
}

