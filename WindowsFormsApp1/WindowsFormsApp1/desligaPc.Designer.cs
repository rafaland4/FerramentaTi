namespace WindowsFormsApp1
{
    partial class desligaPc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnEscolhaH = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDesligaMin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCancelaDesl = new System.Windows.Forms.Button();
            this.btnDesligaAgora = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEscolhaH);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Location = new System.Drawing.Point(206, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 168);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Escolha o horário para agendar";
            // 
            // btnEscolhaH
            // 
            this.btnEscolhaH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscolhaH.Location = new System.Drawing.Point(50, 106);
            this.btnEscolhaH.Name = "btnEscolhaH";
            this.btnEscolhaH.Size = new System.Drawing.Size(235, 25);
            this.btnEscolhaH.TabIndex = 1;
            this.btnEscolhaH.Text = "Agendar";
            this.btnEscolhaH.UseVisualStyleBackColor = true;
            this.btnEscolhaH.Click += new System.EventHandler(this.btnEscolhaH_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(50, 62);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(235, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnDesligaMin);
            this.groupBox2.Location = new System.Drawing.Point(206, 248);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(321, 168);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Desligar daqui a ";
            // 
            // btnDesligaMin
            // 
            this.btnDesligaMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesligaMin.Location = new System.Drawing.Point(50, 106);
            this.btnDesligaMin.Name = "btnDesligaMin";
            this.btnDesligaMin.Size = new System.Drawing.Size(235, 26);
            this.btnDesligaMin.TabIndex = 1;
            this.btnDesligaMin.Text = "Agendar";
            this.btnDesligaMin.UseVisualStyleBackColor = true;
            this.btnDesligaMin.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Desliga Em Minutos";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDesligaAgora);
            this.groupBox3.Controls.Add(this.btnCancelaDesl);
            this.groupBox3.Location = new System.Drawing.Point(206, 422);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(321, 168);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Desligar";
            // 
            // btnCancelaDesl
            // 
            this.btnCancelaDesl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelaDesl.Location = new System.Drawing.Point(50, 106);
            this.btnCancelaDesl.Name = "btnCancelaDesl";
            this.btnCancelaDesl.Size = new System.Drawing.Size(235, 28);
            this.btnCancelaDesl.TabIndex = 1;
            this.btnCancelaDesl.Text = "Cancelar o desligamento";
            this.btnCancelaDesl.UseVisualStyleBackColor = true;
            this.btnCancelaDesl.Click += new System.EventHandler(this.btnCancelaDesl_Click);
            // 
            // btnDesligaAgora
            // 
            this.btnDesligaAgora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesligaAgora.Location = new System.Drawing.Point(50, 62);
            this.btnDesligaAgora.Name = "btnDesligaAgora";
            this.btnDesligaAgora.Size = new System.Drawing.Size(235, 25);
            this.btnDesligaAgora.TabIndex = 2;
            this.btnDesligaAgora.Text = "Desligar";
            this.btnDesligaAgora.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(50, 80);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(235, 20);
            this.textBox1.TabIndex = 3;
            // 
            // desligaPc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 607);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "desligaPc";
            this.Text = "desligaPc";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEscolhaH;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDesligaMin;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDesligaAgora;
        private System.Windows.Forms.Button btnCancelaDesl;
    }
}