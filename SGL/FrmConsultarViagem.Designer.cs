namespace SGL
{
    partial class FrmConsultarViagem
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_Status = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_De = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_SaidaDe = new System.Windows.Forms.DateTimePicker();
            this.dtp_SaidaAte = new System.Windows.Forms.DateTimePicker();
            this.btnAplicarFiltros = new System.Windows.Forms.Button();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_Resultados = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Resultados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(267, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consultar Viagem";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Limpar);
            this.groupBox1.Controls.Add(this.btnAplicarFiltros);
            this.groupBox1.Controls.Add(this.dtp_SaidaAte);
            this.groupBox1.Controls.Add(this.dtp_SaidaDe);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtp_De);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmb_Status);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 378);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros da Consulta";
            // 
            // cmb_Status
            // 
            this.cmb_Status.FormattingEnabled = true;
            this.cmb_Status.Items.AddRange(new object[] {
            "Todos",
            "Em Andamento",
            "Concluida"});
            this.cmb_Status.Location = new System.Drawing.Point(98, 84);
            this.cmb_Status.Name = "cmb_Status";
            this.cmb_Status.Size = new System.Drawing.Size(121, 23);
            this.cmb_Status.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Status:";
            // 
            // dtp_De
            // 
            this.dtp_De.AutoSize = true;
            this.dtp_De.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_De.Location = new System.Drawing.Point(17, 136);
            this.dtp_De.Name = "dtp_De";
            this.dtp_De.Size = new System.Drawing.Size(65, 16);
            this.dtp_De.TabIndex = 4;
            this.dtp_De.Text = "Saída de:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Saída até:";
            // 
            // dtp_SaidaDe
            // 
            this.dtp_SaidaDe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_SaidaDe.Location = new System.Drawing.Point(98, 131);
            this.dtp_SaidaDe.Name = "dtp_SaidaDe";
            this.dtp_SaidaDe.Size = new System.Drawing.Size(121, 21);
            this.dtp_SaidaDe.TabIndex = 8;
            // 
            // dtp_SaidaAte
            // 
            this.dtp_SaidaAte.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_SaidaAte.Location = new System.Drawing.Point(98, 175);
            this.dtp_SaidaAte.Name = "dtp_SaidaAte";
            this.dtp_SaidaAte.Size = new System.Drawing.Size(121, 21);
            this.dtp_SaidaAte.TabIndex = 9;
            // 
            // btnAplicarFiltros
            // 
            this.btnAplicarFiltros.Location = new System.Drawing.Point(23, 230);
            this.btnAplicarFiltros.Name = "btnAplicarFiltros";
            this.btnAplicarFiltros.Size = new System.Drawing.Size(75, 31);
            this.btnAplicarFiltros.TabIndex = 10;
            this.btnAplicarFiltros.Text = "Aplicar";
            this.btnAplicarFiltros.UseVisualStyleBackColor = true;
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.Location = new System.Drawing.Point(144, 230);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(75, 31);
            this.btn_Limpar.TabIndex = 11;
            this.btn_Limpar.Text = "Limpar";
            this.btn_Limpar.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_Resultados);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(291, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(497, 371);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultados da Viagem";
            // 
            // dgv_Resultados
            // 
            this.dgv_Resultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Resultados.Location = new System.Drawing.Point(18, 20);
            this.dgv_Resultados.Name = "dgv_Resultados";
            this.dgv_Resultados.ReadOnly = true;
            this.dgv_Resultados.Size = new System.Drawing.Size(473, 333);
            this.dgv_Resultados.TabIndex = 0;
            // 
            // FrmConsultarViagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FrmConsultarViagem";
            this.Text = "FrmConsultarViagem";
            this.Load += new System.EventHandler(this.FrmConsultarViagem_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Resultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label dtp_De;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_Status;
        private System.Windows.Forms.Button btn_Limpar;
        private System.Windows.Forms.Button btnAplicarFiltros;
        private System.Windows.Forms.DateTimePicker dtp_SaidaAte;
        private System.Windows.Forms.DateTimePicker dtp_SaidaDe;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_Resultados;
    }
}