namespace SGL
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_veiculo = new System.Windows.Forms.TabPage();
            this.tab_motorista = new System.Windows.Forms.TabPage();
            this.txt_RotaID = new System.Windows.Forms.TabPage();
            this.tab_precocombustivel = new System.Windows.Forms.TabPage();
            this.tab_viagem = new System.Windows.Forms.TabPage();
            this.btn_SalvarVeiculo = new System.Windows.Forms.Button();
            this.btn_EditarVeiculo = new System.Windows.Forms.Button();
            this.btn_ConsultarVeiculo = new System.Windows.Forms.Button();
            this.btn_ExcluirVeiculo = new System.Windows.Forms.Button();
            this.txt_VeiculoID = new System.Windows.Forms.TextBox();
            this.txt_Placa = new System.Windows.Forms.TextBox();
            this.txt_Modelo = new System.Windows.Forms.TextBox();
            this.txt_Consumo = new System.Windows.Forms.TextBox();
            this.txt_Carga = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_SalvarMotorista = new System.Windows.Forms.Button();
            this.btn_EditarMotorista = new System.Windows.Forms.Button();
            this.btn_ConsultarMotorista = new System.Windows.Forms.Button();
            this.btn_ExcluirMotorista = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_MotoristaID = new System.Windows.Forms.TextBox();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.msk_Cnh = new System.Windows.Forms.MaskedTextBox();
            this.msk_Telefone = new System.Windows.Forms.MaskedTextBox();
            this.btn_SalvarRota = new System.Windows.Forms.Button();
            this.btn_EditarRota = new System.Windows.Forms.Button();
            this.btn_ConsultarRota = new System.Windows.Forms.Button();
            this.btn_ExcluirRota = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txt_Origem = new System.Windows.Forms.TextBox();
            this.txt_Distancia = new System.Windows.Forms.TextBox();
            this.txt_Destino = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_PrecoID = new System.Windows.Forms.TextBox();
            this.cmb_Combustivel = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.dtp_DataConsulta = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txt_ViagemID = new System.Windows.Forms.TextBox();
            this.dtp_DataHoraSaida = new System.Windows.Forms.DateTimePicker();
            this.check_ViagemConcluida = new System.Windows.Forms.CheckBox();
            this.dtp_DataHoraChegada = new System.Windows.Forms.DateTimePicker();
            this.cmb_VeiculoViagem = new System.Windows.Forms.ComboBox();
            this.cmb_RotaViagem = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.cmb_Motorista = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tab_veiculo.SuspendLayout();
            this.tab_motorista.SuspendLayout();
            this.txt_RotaID.SuspendLayout();
            this.tab_precocombustivel.SuspendLayout();
            this.tab_viagem.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_veiculo);
            this.tabControl1.Controls.Add(this.tab_motorista);
            this.tabControl1.Controls.Add(this.txt_RotaID);
            this.tabControl1.Controls.Add(this.tab_precocombustivel);
            this.tabControl1.Controls.Add(this.tab_viagem);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tab_veiculo
            // 
            this.tab_veiculo.Controls.Add(this.label5);
            this.tab_veiculo.Controls.Add(this.label4);
            this.tab_veiculo.Controls.Add(this.label3);
            this.tab_veiculo.Controls.Add(this.label2);
            this.tab_veiculo.Controls.Add(this.label1);
            this.tab_veiculo.Controls.Add(this.txt_Carga);
            this.tab_veiculo.Controls.Add(this.txt_Consumo);
            this.tab_veiculo.Controls.Add(this.txt_Modelo);
            this.tab_veiculo.Controls.Add(this.txt_Placa);
            this.tab_veiculo.Controls.Add(this.txt_VeiculoID);
            this.tab_veiculo.Controls.Add(this.btn_ExcluirVeiculo);
            this.tab_veiculo.Controls.Add(this.btn_ConsultarVeiculo);
            this.tab_veiculo.Controls.Add(this.btn_EditarVeiculo);
            this.tab_veiculo.Controls.Add(this.btn_SalvarVeiculo);
            this.tab_veiculo.Location = new System.Drawing.Point(4, 22);
            this.tab_veiculo.Name = "tab_veiculo";
            this.tab_veiculo.Padding = new System.Windows.Forms.Padding(3);
            this.tab_veiculo.Size = new System.Drawing.Size(768, 400);
            this.tab_veiculo.TabIndex = 0;
            this.tab_veiculo.Text = "Veiculo";
            this.tab_veiculo.UseVisualStyleBackColor = true;
            this.tab_veiculo.Click += new System.EventHandler(this.tab_veiculo_Click);
            // 
            // tab_motorista
            // 
            this.tab_motorista.Controls.Add(this.msk_Telefone);
            this.tab_motorista.Controls.Add(this.msk_Cnh);
            this.tab_motorista.Controls.Add(this.txt_Nome);
            this.tab_motorista.Controls.Add(this.txt_MotoristaID);
            this.tab_motorista.Controls.Add(this.label9);
            this.tab_motorista.Controls.Add(this.label8);
            this.tab_motorista.Controls.Add(this.label7);
            this.tab_motorista.Controls.Add(this.label6);
            this.tab_motorista.Controls.Add(this.btn_ExcluirMotorista);
            this.tab_motorista.Controls.Add(this.btn_ConsultarMotorista);
            this.tab_motorista.Controls.Add(this.btn_EditarMotorista);
            this.tab_motorista.Controls.Add(this.btn_SalvarMotorista);
            this.tab_motorista.Location = new System.Drawing.Point(4, 22);
            this.tab_motorista.Name = "tab_motorista";
            this.tab_motorista.Padding = new System.Windows.Forms.Padding(3);
            this.tab_motorista.Size = new System.Drawing.Size(768, 400);
            this.tab_motorista.TabIndex = 1;
            this.tab_motorista.Text = "Motorista";
            this.tab_motorista.UseVisualStyleBackColor = true;
            // 
            // txt_RotaID
            // 
            this.txt_RotaID.Controls.Add(this.label13);
            this.txt_RotaID.Controls.Add(this.label12);
            this.txt_RotaID.Controls.Add(this.label11);
            this.txt_RotaID.Controls.Add(this.label10);
            this.txt_RotaID.Controls.Add(this.txt_Destino);
            this.txt_RotaID.Controls.Add(this.txt_Distancia);
            this.txt_RotaID.Controls.Add(this.txt_Origem);
            this.txt_RotaID.Controls.Add(this.textBox1);
            this.txt_RotaID.Controls.Add(this.btn_ExcluirRota);
            this.txt_RotaID.Controls.Add(this.btn_ConsultarRota);
            this.txt_RotaID.Controls.Add(this.btn_EditarRota);
            this.txt_RotaID.Controls.Add(this.btn_SalvarRota);
            this.txt_RotaID.Location = new System.Drawing.Point(4, 22);
            this.txt_RotaID.Name = "txt_RotaID";
            this.txt_RotaID.Size = new System.Drawing.Size(768, 400);
            this.txt_RotaID.TabIndex = 2;
            this.txt_RotaID.Text = "Rota";
            this.txt_RotaID.UseVisualStyleBackColor = true;
            // 
            // tab_precocombustivel
            // 
            this.tab_precocombustivel.Controls.Add(this.dtp_DataConsulta);
            this.tab_precocombustivel.Controls.Add(this.label17);
            this.tab_precocombustivel.Controls.Add(this.label16);
            this.tab_precocombustivel.Controls.Add(this.textBox2);
            this.tab_precocombustivel.Controls.Add(this.cmb_Combustivel);
            this.tab_precocombustivel.Controls.Add(this.txt_PrecoID);
            this.tab_precocombustivel.Controls.Add(this.label15);
            this.tab_precocombustivel.Controls.Add(this.label14);
            this.tab_precocombustivel.Location = new System.Drawing.Point(4, 22);
            this.tab_precocombustivel.Name = "tab_precocombustivel";
            this.tab_precocombustivel.Size = new System.Drawing.Size(768, 400);
            this.tab_precocombustivel.TabIndex = 3;
            this.tab_precocombustivel.Text = "Preço Combustivel";
            this.tab_precocombustivel.UseVisualStyleBackColor = true;
            // 
            // tab_viagem
            // 
            this.tab_viagem.Controls.Add(this.cmb_Motorista);
            this.tab_viagem.Controls.Add(this.label24);
            this.tab_viagem.Controls.Add(this.label23);
            this.tab_viagem.Controls.Add(this.cmb_RotaViagem);
            this.tab_viagem.Controls.Add(this.cmb_VeiculoViagem);
            this.tab_viagem.Controls.Add(this.dtp_DataHoraChegada);
            this.tab_viagem.Controls.Add(this.check_ViagemConcluida);
            this.tab_viagem.Controls.Add(this.dtp_DataHoraSaida);
            this.tab_viagem.Controls.Add(this.txt_ViagemID);
            this.tab_viagem.Controls.Add(this.label22);
            this.tab_viagem.Controls.Add(this.label21);
            this.tab_viagem.Controls.Add(this.label20);
            this.tab_viagem.Controls.Add(this.label19);
            this.tab_viagem.Controls.Add(this.label18);
            this.tab_viagem.Controls.Add(this.button4);
            this.tab_viagem.Controls.Add(this.button3);
            this.tab_viagem.Controls.Add(this.button2);
            this.tab_viagem.Controls.Add(this.button1);
            this.tab_viagem.Location = new System.Drawing.Point(4, 22);
            this.tab_viagem.Name = "tab_viagem";
            this.tab_viagem.Size = new System.Drawing.Size(768, 400);
            this.tab_viagem.TabIndex = 4;
            this.tab_viagem.Text = "Viagem";
            this.tab_viagem.UseVisualStyleBackColor = true;
            // 
            // btn_SalvarVeiculo
            // 
            this.btn_SalvarVeiculo.Location = new System.Drawing.Point(6, 6);
            this.btn_SalvarVeiculo.Name = "btn_SalvarVeiculo";
            this.btn_SalvarVeiculo.Size = new System.Drawing.Size(75, 35);
            this.btn_SalvarVeiculo.TabIndex = 0;
            this.btn_SalvarVeiculo.Text = "Salvar ";
            this.btn_SalvarVeiculo.UseVisualStyleBackColor = true;
            this.btn_SalvarVeiculo.Click += new System.EventHandler(this.btn_SalvarVeiculo_Click);
            // 
            // btn_EditarVeiculo
            // 
            this.btn_EditarVeiculo.Location = new System.Drawing.Point(87, 6);
            this.btn_EditarVeiculo.Name = "btn_EditarVeiculo";
            this.btn_EditarVeiculo.Size = new System.Drawing.Size(75, 35);
            this.btn_EditarVeiculo.TabIndex = 1;
            this.btn_EditarVeiculo.Text = "Editar";
            this.btn_EditarVeiculo.UseVisualStyleBackColor = true;
            this.btn_EditarVeiculo.Click += new System.EventHandler(this.btn_EditarVeiculo_Click);
            // 
            // btn_ConsultarVeiculo
            // 
            this.btn_ConsultarVeiculo.Location = new System.Drawing.Point(168, 6);
            this.btn_ConsultarVeiculo.Name = "btn_ConsultarVeiculo";
            this.btn_ConsultarVeiculo.Size = new System.Drawing.Size(75, 35);
            this.btn_ConsultarVeiculo.TabIndex = 2;
            this.btn_ConsultarVeiculo.Text = "Consultar";
            this.btn_ConsultarVeiculo.UseVisualStyleBackColor = true;
            this.btn_ConsultarVeiculo.Click += new System.EventHandler(this.btn_ConsultarVeiculo_Click);
            // 
            // btn_ExcluirVeiculo
            // 
            this.btn_ExcluirVeiculo.Location = new System.Drawing.Point(249, 6);
            this.btn_ExcluirVeiculo.Name = "btn_ExcluirVeiculo";
            this.btn_ExcluirVeiculo.Size = new System.Drawing.Size(75, 35);
            this.btn_ExcluirVeiculo.TabIndex = 3;
            this.btn_ExcluirVeiculo.Text = "Excluir";
            this.btn_ExcluirVeiculo.UseVisualStyleBackColor = true;
            this.btn_ExcluirVeiculo.Click += new System.EventHandler(this.btn_ExcluirVeiculo_Click);
            // 
            // txt_VeiculoID
            // 
            this.txt_VeiculoID.Location = new System.Drawing.Point(168, 104);
            this.txt_VeiculoID.Name = "txt_VeiculoID";
            this.txt_VeiculoID.Size = new System.Drawing.Size(173, 20);
            this.txt_VeiculoID.TabIndex = 4;
            // 
            // txt_Placa
            // 
            this.txt_Placa.Location = new System.Drawing.Point(168, 233);
            this.txt_Placa.Name = "txt_Placa";
            this.txt_Placa.Size = new System.Drawing.Size(100, 20);
            this.txt_Placa.TabIndex = 5;
            // 
            // txt_Modelo
            // 
            this.txt_Modelo.Location = new System.Drawing.Point(168, 167);
            this.txt_Modelo.Name = "txt_Modelo";
            this.txt_Modelo.Size = new System.Drawing.Size(173, 20);
            this.txt_Modelo.TabIndex = 6;
            // 
            // txt_Consumo
            // 
            this.txt_Consumo.Location = new System.Drawing.Point(168, 293);
            this.txt_Consumo.Name = "txt_Consumo";
            this.txt_Consumo.Size = new System.Drawing.Size(57, 20);
            this.txt_Consumo.TabIndex = 7;
            // 
            // txt_Carga
            // 
            this.txt_Carga.Location = new System.Drawing.Point(168, 351);
            this.txt_Carga.Name = "txt_Carga";
            this.txt_Carga.Size = new System.Drawing.Size(100, 20);
            this.txt_Carga.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Veiculo ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Modelo do veiculo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Placa do veiculo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Consumo medio (Km/L):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Carga máxima (Kg):";
            // 
            // btn_SalvarMotorista
            // 
            this.btn_SalvarMotorista.Location = new System.Drawing.Point(6, 6);
            this.btn_SalvarMotorista.Name = "btn_SalvarMotorista";
            this.btn_SalvarMotorista.Size = new System.Drawing.Size(75, 37);
            this.btn_SalvarMotorista.TabIndex = 0;
            this.btn_SalvarMotorista.Text = "Salvar";
            this.btn_SalvarMotorista.UseVisualStyleBackColor = true;
            // 
            // btn_EditarMotorista
            // 
            this.btn_EditarMotorista.Location = new System.Drawing.Point(102, 6);
            this.btn_EditarMotorista.Name = "btn_EditarMotorista";
            this.btn_EditarMotorista.Size = new System.Drawing.Size(75, 37);
            this.btn_EditarMotorista.TabIndex = 1;
            this.btn_EditarMotorista.Text = "Editar";
            this.btn_EditarMotorista.UseVisualStyleBackColor = true;
            // 
            // btn_ConsultarMotorista
            // 
            this.btn_ConsultarMotorista.Location = new System.Drawing.Point(195, 6);
            this.btn_ConsultarMotorista.Name = "btn_ConsultarMotorista";
            this.btn_ConsultarMotorista.Size = new System.Drawing.Size(75, 37);
            this.btn_ConsultarMotorista.TabIndex = 2;
            this.btn_ConsultarMotorista.Text = "Consultar";
            this.btn_ConsultarMotorista.UseVisualStyleBackColor = true;
            // 
            // btn_ExcluirMotorista
            // 
            this.btn_ExcluirMotorista.Location = new System.Drawing.Point(289, 6);
            this.btn_ExcluirMotorista.Name = "btn_ExcluirMotorista";
            this.btn_ExcluirMotorista.Size = new System.Drawing.Size(75, 37);
            this.btn_ExcluirMotorista.TabIndex = 3;
            this.btn_ExcluirMotorista.Text = "Excluir";
            this.btn_ExcluirMotorista.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Motorista ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(29, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Nome do motorista:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(29, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "CNH do motorista:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(29, 257);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 16);
            this.label9.TabIndex = 7;
            this.label9.Text = "Fone do motorista:";
            // 
            // txt_MotoristaID
            // 
            this.txt_MotoristaID.Location = new System.Drawing.Point(170, 87);
            this.txt_MotoristaID.Name = "txt_MotoristaID";
            this.txt_MotoristaID.Size = new System.Drawing.Size(100, 20);
            this.txt_MotoristaID.TabIndex = 9;
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(170, 134);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(100, 20);
            this.txt_Nome.TabIndex = 10;
            // 
            // msk_Cnh
            // 
            this.msk_Cnh.Location = new System.Drawing.Point(170, 194);
            this.msk_Cnh.Name = "msk_Cnh";
            this.msk_Cnh.Size = new System.Drawing.Size(100, 20);
            this.msk_Cnh.TabIndex = 11;
            // 
            // msk_Telefone
            // 
            this.msk_Telefone.Location = new System.Drawing.Point(170, 250);
            this.msk_Telefone.Name = "msk_Telefone";
            this.msk_Telefone.Size = new System.Drawing.Size(100, 20);
            this.msk_Telefone.TabIndex = 12;
            // 
            // btn_SalvarRota
            // 
            this.btn_SalvarRota.Location = new System.Drawing.Point(16, 13);
            this.btn_SalvarRota.Name = "btn_SalvarRota";
            this.btn_SalvarRota.Size = new System.Drawing.Size(75, 33);
            this.btn_SalvarRota.TabIndex = 0;
            this.btn_SalvarRota.Text = "Salvar";
            this.btn_SalvarRota.UseVisualStyleBackColor = true;
            // 
            // btn_EditarRota
            // 
            this.btn_EditarRota.Location = new System.Drawing.Point(109, 13);
            this.btn_EditarRota.Name = "btn_EditarRota";
            this.btn_EditarRota.Size = new System.Drawing.Size(75, 33);
            this.btn_EditarRota.TabIndex = 1;
            this.btn_EditarRota.Text = "Editar";
            this.btn_EditarRota.UseVisualStyleBackColor = true;
            // 
            // btn_ConsultarRota
            // 
            this.btn_ConsultarRota.Location = new System.Drawing.Point(200, 13);
            this.btn_ConsultarRota.Name = "btn_ConsultarRota";
            this.btn_ConsultarRota.Size = new System.Drawing.Size(75, 33);
            this.btn_ConsultarRota.TabIndex = 2;
            this.btn_ConsultarRota.Text = "Consultar";
            this.btn_ConsultarRota.UseVisualStyleBackColor = true;
            // 
            // btn_ExcluirRota
            // 
            this.btn_ExcluirRota.Location = new System.Drawing.Point(295, 13);
            this.btn_ExcluirRota.Name = "btn_ExcluirRota";
            this.btn_ExcluirRota.Size = new System.Drawing.Size(75, 33);
            this.btn_ExcluirRota.TabIndex = 3;
            this.btn_ExcluirRota.Text = "Excluir";
            this.btn_ExcluirRota.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(160, 102);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_Origem
            // 
            this.txt_Origem.Location = new System.Drawing.Point(160, 174);
            this.txt_Origem.Name = "txt_Origem";
            this.txt_Origem.Size = new System.Drawing.Size(100, 20);
            this.txt_Origem.TabIndex = 5;
            // 
            // txt_Distancia
            // 
            this.txt_Distancia.Location = new System.Drawing.Point(160, 341);
            this.txt_Distancia.Name = "txt_Distancia";
            this.txt_Distancia.Size = new System.Drawing.Size(100, 20);
            this.txt_Distancia.TabIndex = 6;
            this.txt_Distancia.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txt_Destino
            // 
            this.txt_Destino.Location = new System.Drawing.Point(160, 261);
            this.txt_Destino.Name = "txt_Destino";
            this.txt_Destino.Size = new System.Drawing.Size(100, 20);
            this.txt_Destino.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(99, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 16);
            this.label10.TabIndex = 8;
            this.label10.Text = "Rota ID:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(55, 178);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 16);
            this.label11.TabIndex = 9;
            this.label11.Text = "Origem da rota:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(53, 265);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 16);
            this.label12.TabIndex = 10;
            this.label12.Text = "Destino da rota:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(13, 341);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(141, 16);
            this.label13.TabIndex = 11;
            this.label13.Text = "Distância da rota (Km):";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(86, 38);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 16);
            this.label14.TabIndex = 0;
            this.label14.Text = "Comb ID:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(64, 108);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(84, 16);
            this.label15.TabIndex = 1;
            this.label15.Text = "Combustível:";
            // 
            // txt_PrecoID
            // 
            this.txt_PrecoID.Location = new System.Drawing.Point(154, 34);
            this.txt_PrecoID.Name = "txt_PrecoID";
            this.txt_PrecoID.Size = new System.Drawing.Size(121, 20);
            this.txt_PrecoID.TabIndex = 2;
            // 
            // cmb_Combustivel
            // 
            this.cmb_Combustivel.FormattingEnabled = true;
            this.cmb_Combustivel.Items.AddRange(new object[] {
            "Gasolina",
            "Diesel",
            "Etanol",
            "GNV"});
            this.cmb_Combustivel.Location = new System.Drawing.Point(154, 107);
            this.cmb_Combustivel.Name = "cmb_Combustivel";
            this.cmb_Combustivel.Size = new System.Drawing.Size(121, 21);
            this.cmb_Combustivel.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(154, 264);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 4;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(74, 265);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(74, 16);
            this.label16.TabIndex = 6;
            this.label16.Text = "Preço (R$):";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(37, 359);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(111, 16);
            this.label17.TabIndex = 7;
            this.label17.Text = "Data da consulta:";
            // 
            // dtp_DataConsulta
            // 
            this.dtp_DataConsulta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_DataConsulta.Location = new System.Drawing.Point(154, 355);
            this.dtp_DataConsulta.Name = "dtp_DataConsulta";
            this.dtp_DataConsulta.Size = new System.Drawing.Size(86, 20);
            this.dtp_DataConsulta.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(108, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 38);
            this.button2.TabIndex = 1;
            this.button2.Text = "Editar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(202, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 38);
            this.button3.TabIndex = 2;
            this.button3.Text = "Consultar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(295, 13);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 38);
            this.button4.TabIndex = 3;
            this.button4.Text = "Excluir";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(93, 73);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(73, 16);
            this.label18.TabIndex = 4;
            this.label18.Text = "Viagem ID:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(30, 123);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(136, 16);
            this.label19.TabIndex = 5;
            this.label19.Text = "Data e hora de saída:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(44, 170);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(122, 16);
            this.label20.TabIndex = 6;
            this.label20.Text = "Viagem concluída?";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(10, 219);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(156, 16);
            this.label21.TabIndex = 7;
            this.label21.Text = "Data e hora de chegada:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(44, 266);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(122, 16);
            this.label22.TabIndex = 8;
            this.label22.Text = "Veículo da viagem:";
            // 
            // txt_ViagemID
            // 
            this.txt_ViagemID.Location = new System.Drawing.Point(172, 69);
            this.txt_ViagemID.Name = "txt_ViagemID";
            this.txt_ViagemID.Size = new System.Drawing.Size(100, 20);
            this.txt_ViagemID.TabIndex = 9;
            // 
            // dtp_DataHoraSaida
            // 
            this.dtp_DataHoraSaida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_DataHoraSaida.Location = new System.Drawing.Point(170, 119);
            this.dtp_DataHoraSaida.Name = "dtp_DataHoraSaida";
            this.dtp_DataHoraSaida.Size = new System.Drawing.Size(107, 20);
            this.dtp_DataHoraSaida.TabIndex = 10;
            // 
            // check_ViagemConcluida
            // 
            this.check_ViagemConcluida.AutoSize = true;
            this.check_ViagemConcluida.Location = new System.Drawing.Point(172, 171);
            this.check_ViagemConcluida.Name = "check_ViagemConcluida";
            this.check_ViagemConcluida.Size = new System.Drawing.Size(134, 17);
            this.check_ViagemConcluida.TabIndex = 11;
            this.check_ViagemConcluida.Text = "Tem Data de Chegada";
            this.check_ViagemConcluida.UseVisualStyleBackColor = true;
            // 
            // dtp_DataHoraChegada
            // 
            this.dtp_DataHoraChegada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_DataHoraChegada.Location = new System.Drawing.Point(172, 215);
            this.dtp_DataHoraChegada.Name = "dtp_DataHoraChegada";
            this.dtp_DataHoraChegada.Size = new System.Drawing.Size(105, 20);
            this.dtp_DataHoraChegada.TabIndex = 12;
            // 
            // cmb_VeiculoViagem
            // 
            this.cmb_VeiculoViagem.FormattingEnabled = true;
            this.cmb_VeiculoViagem.Location = new System.Drawing.Point(172, 261);
            this.cmb_VeiculoViagem.Name = "cmb_VeiculoViagem";
            this.cmb_VeiculoViagem.Size = new System.Drawing.Size(121, 21);
            this.cmb_VeiculoViagem.TabIndex = 13;
            // 
            // cmb_RotaViagem
            // 
            this.cmb_RotaViagem.FormattingEnabled = true;
            this.cmb_RotaViagem.Location = new System.Drawing.Point(411, 260);
            this.cmb_RotaViagem.Name = "cmb_RotaViagem";
            this.cmb_RotaViagem.Size = new System.Drawing.Size(121, 21);
            this.cmb_RotaViagem.TabIndex = 14;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(299, 261);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(106, 16);
            this.label23.TabIndex = 15;
            this.label23.Text = "Rota da viagem:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(547, 262);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(65, 16);
            this.label24.TabIndex = 16;
            this.label24.Text = "Motorista:";
            // 
            // cmb_Motorista
            // 
            this.cmb_Motorista.FormattingEnabled = true;
            this.cmb_Motorista.Location = new System.Drawing.Point(618, 260);
            this.cmb_Motorista.Name = "cmb_Motorista";
            this.cmb_Motorista.Size = new System.Drawing.Size(121, 21);
            this.cmb_Motorista.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tab_veiculo.ResumeLayout(false);
            this.tab_veiculo.PerformLayout();
            this.tab_motorista.ResumeLayout(false);
            this.tab_motorista.PerformLayout();
            this.txt_RotaID.ResumeLayout(false);
            this.txt_RotaID.PerformLayout();
            this.tab_precocombustivel.ResumeLayout(false);
            this.tab_precocombustivel.PerformLayout();
            this.tab_viagem.ResumeLayout(false);
            this.tab_viagem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_veiculo;
        private System.Windows.Forms.TabPage tab_motorista;
        private System.Windows.Forms.TabPage txt_RotaID;
        private System.Windows.Forms.TabPage tab_precocombustivel;
        private System.Windows.Forms.TabPage tab_viagem;
        private System.Windows.Forms.Button btn_ExcluirVeiculo;
        private System.Windows.Forms.Button btn_ConsultarVeiculo;
        private System.Windows.Forms.Button btn_EditarVeiculo;
        private System.Windows.Forms.Button btn_SalvarVeiculo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Carga;
        private System.Windows.Forms.TextBox txt_Consumo;
        private System.Windows.Forms.TextBox txt_Modelo;
        private System.Windows.Forms.TextBox txt_Placa;
        private System.Windows.Forms.TextBox txt_VeiculoID;
        private System.Windows.Forms.Button btn_ExcluirMotorista;
        private System.Windows.Forms.Button btn_ConsultarMotorista;
        private System.Windows.Forms.Button btn_EditarMotorista;
        private System.Windows.Forms.Button btn_SalvarMotorista;
        private System.Windows.Forms.MaskedTextBox msk_Telefone;
        private System.Windows.Forms.MaskedTextBox msk_Cnh;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.TextBox txt_MotoristaID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_ExcluirRota;
        private System.Windows.Forms.Button btn_ConsultarRota;
        private System.Windows.Forms.Button btn_EditarRota;
        private System.Windows.Forms.Button btn_SalvarRota;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_Destino;
        private System.Windows.Forms.TextBox txt_Distancia;
        private System.Windows.Forms.TextBox txt_Origem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox cmb_Combustivel;
        private System.Windows.Forms.TextBox txt_PrecoID;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtp_DataConsulta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmb_VeiculoViagem;
        private System.Windows.Forms.DateTimePicker dtp_DataHoraChegada;
        private System.Windows.Forms.CheckBox check_ViagemConcluida;
        private System.Windows.Forms.DateTimePicker dtp_DataHoraSaida;
        private System.Windows.Forms.TextBox txt_ViagemID;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cmb_Motorista;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox cmb_RotaViagem;
    }
}

