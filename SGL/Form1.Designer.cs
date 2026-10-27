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
            this.dgv_Veiculo = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Carga = new System.Windows.Forms.TextBox();
            this.txt_Consumo = new System.Windows.Forms.TextBox();
            this.txt_Modelo = new System.Windows.Forms.TextBox();
            this.txt_Placa = new System.Windows.Forms.TextBox();
            this.txt_VeiculoID = new System.Windows.Forms.TextBox();
            this.btn_ExcluirVeiculo = new System.Windows.Forms.Button();
            this.btn_ConsultarVeiculo = new System.Windows.Forms.Button();
            this.btn_EditarVeiculo = new System.Windows.Forms.Button();
            this.btn_SalvarVeiculo = new System.Windows.Forms.Button();
            this.tab_motorista = new System.Windows.Forms.TabPage();
            this.btn_BuscarCep = new System.Windows.Forms.Button();
            this.txt_Uf = new System.Windows.Forms.TextBox();
            this.txt_Cidade = new System.Windows.Forms.TextBox();
            this.txt_Bairro = new System.Windows.Forms.TextBox();
            this.txt_Logradouro = new System.Windows.Forms.TextBox();
            this.txt_Cep = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.dgv_Motorista = new System.Windows.Forms.DataGridView();
            this.txt_Telefone = new System.Windows.Forms.MaskedTextBox();
            this.txt_Cnh = new System.Windows.Forms.MaskedTextBox();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.txt_MotoristaID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_ExcluirMotorista = new System.Windows.Forms.Button();
            this.btn_ConsultarMotorista = new System.Windows.Forms.Button();
            this.btn_EditarMotorista = new System.Windows.Forms.Button();
            this.btn_SalvarMotorista = new System.Windows.Forms.Button();
            this.tab_Rota = new System.Windows.Forms.TabPage();
            this.dgv_Rota = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_Destino = new System.Windows.Forms.TextBox();
            this.txt_Distancia = new System.Windows.Forms.TextBox();
            this.txt_Origem = new System.Windows.Forms.TextBox();
            this.txt_RotaID = new System.Windows.Forms.TextBox();
            this.btn_ExcluirRota = new System.Windows.Forms.Button();
            this.btn_ConsultarRota = new System.Windows.Forms.Button();
            this.btn_EditarRota = new System.Windows.Forms.Button();
            this.btn_SalvarRota = new System.Windows.Forms.Button();
            this.tab_precocombustivel = new System.Windows.Forms.TabPage();
            this.dgv_Preco = new System.Windows.Forms.DataGridView();
            this.btn_ExcluirPreco = new System.Windows.Forms.Button();
            this.btn_ConsultarPreco = new System.Windows.Forms.Button();
            this.btn_EditarPreco = new System.Windows.Forms.Button();
            this.btn_SalvarPreco = new System.Windows.Forms.Button();
            this.dtp_DataConsulta = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_Preco = new System.Windows.Forms.TextBox();
            this.cmb_Combustivel = new System.Windows.Forms.ComboBox();
            this.txt_PrecoID = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tab_viagem = new System.Windows.Forms.TabPage();
            this.dgv_Viagem = new System.Windows.Forms.DataGridView();
            this.cmb_Motorista = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.cmb_Rota = new System.Windows.Forms.ComboBox();
            this.cmb_Veiculo = new System.Windows.Forms.ComboBox();
            this.dtp_Chegada = new System.Windows.Forms.DateTimePicker();
            this.chk_TemChegada = new System.Windows.Forms.CheckBox();
            this.dtp_Saida = new System.Windows.Forms.DateTimePicker();
            this.txt_ViagemID = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.dtp_Ate = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.btn_ExcluirViagem = new System.Windows.Forms.Button();
            this.btn_ConsultarViagem = new System.Windows.Forms.Button();
            this.btn_EditarViagem = new System.Windows.Forms.Button();
            this.btn_SalvarViagem = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tab_veiculo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Veiculo)).BeginInit();
            this.tab_motorista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Motorista)).BeginInit();
            this.tab_Rota.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Rota)).BeginInit();
            this.tab_precocombustivel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Preco)).BeginInit();
            this.tab_viagem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Viagem)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_veiculo);
            this.tabControl1.Controls.Add(this.tab_motorista);
            this.tabControl1.Controls.Add(this.tab_Rota);
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
            this.tab_veiculo.Controls.Add(this.dgv_Veiculo);
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
            // dgv_Veiculo
            // 
            this.dgv_Veiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Veiculo.Location = new System.Drawing.Point(358, 6);
            this.dgv_Veiculo.Name = "dgv_Veiculo";
            this.dgv_Veiculo.Size = new System.Drawing.Size(390, 377);
            this.dgv_Veiculo.TabIndex = 1;
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
            // txt_Carga
            // 
            this.txt_Carga.Location = new System.Drawing.Point(168, 351);
            this.txt_Carga.Name = "txt_Carga";
            this.txt_Carga.Size = new System.Drawing.Size(100, 20);
            this.txt_Carga.TabIndex = 8;
            // 
            // txt_Consumo
            // 
            this.txt_Consumo.Location = new System.Drawing.Point(168, 293);
            this.txt_Consumo.Name = "txt_Consumo";
            this.txt_Consumo.Size = new System.Drawing.Size(57, 20);
            this.txt_Consumo.TabIndex = 7;
            // 
            // txt_Modelo
            // 
            this.txt_Modelo.Location = new System.Drawing.Point(168, 167);
            this.txt_Modelo.Name = "txt_Modelo";
            this.txt_Modelo.Size = new System.Drawing.Size(173, 20);
            this.txt_Modelo.TabIndex = 6;
            // 
            // txt_Placa
            // 
            this.txt_Placa.Location = new System.Drawing.Point(168, 233);
            this.txt_Placa.Name = "txt_Placa";
            this.txt_Placa.Size = new System.Drawing.Size(100, 20);
            this.txt_Placa.TabIndex = 5;
            // 
            // txt_VeiculoID
            // 
            this.txt_VeiculoID.Location = new System.Drawing.Point(168, 104);
            this.txt_VeiculoID.Name = "txt_VeiculoID";
            this.txt_VeiculoID.Size = new System.Drawing.Size(173, 20);
            this.txt_VeiculoID.TabIndex = 4;
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
            // tab_motorista
            // 
            this.tab_motorista.Controls.Add(this.btn_BuscarCep);
            this.tab_motorista.Controls.Add(this.txt_Uf);
            this.tab_motorista.Controls.Add(this.txt_Cidade);
            this.tab_motorista.Controls.Add(this.txt_Bairro);
            this.tab_motorista.Controls.Add(this.txt_Logradouro);
            this.tab_motorista.Controls.Add(this.txt_Cep);
            this.tab_motorista.Controls.Add(this.label30);
            this.tab_motorista.Controls.Add(this.label29);
            this.tab_motorista.Controls.Add(this.label28);
            this.tab_motorista.Controls.Add(this.label27);
            this.tab_motorista.Controls.Add(this.label31);
            this.tab_motorista.Controls.Add(this.dgv_Motorista);
            this.tab_motorista.Controls.Add(this.txt_Telefone);
            this.tab_motorista.Controls.Add(this.txt_Cnh);
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
            // btn_BuscarCep
            // 
            this.btn_BuscarCep.Location = new System.Drawing.Point(146, 224);
            this.btn_BuscarCep.Name = "btn_BuscarCep";
            this.btn_BuscarCep.Size = new System.Drawing.Size(174, 23);
            this.btn_BuscarCep.TabIndex = 24;
            this.btn_BuscarCep.Text = "Buscar";
            this.btn_BuscarCep.UseVisualStyleBackColor = true;
            // 
            // txt_Uf
            // 
            this.txt_Uf.Location = new System.Drawing.Point(92, 354);
            this.txt_Uf.Name = "txt_Uf";
            this.txt_Uf.Size = new System.Drawing.Size(38, 20);
            this.txt_Uf.TabIndex = 23;
            // 
            // txt_Cidade
            // 
            this.txt_Cidade.Location = new System.Drawing.Point(92, 320);
            this.txt_Cidade.Name = "txt_Cidade";
            this.txt_Cidade.Size = new System.Drawing.Size(253, 20);
            this.txt_Cidade.TabIndex = 22;
            // 
            // txt_Bairro
            // 
            this.txt_Bairro.Location = new System.Drawing.Point(92, 291);
            this.txt_Bairro.Name = "txt_Bairro";
            this.txt_Bairro.Size = new System.Drawing.Size(253, 20);
            this.txt_Bairro.TabIndex = 21;
            // 
            // txt_Logradouro
            // 
            this.txt_Logradouro.Location = new System.Drawing.Point(92, 259);
            this.txt_Logradouro.Name = "txt_Logradouro";
            this.txt_Logradouro.Size = new System.Drawing.Size(253, 20);
            this.txt_Logradouro.TabIndex = 20;
            // 
            // txt_Cep
            // 
            this.txt_Cep.Location = new System.Drawing.Point(49, 227);
            this.txt_Cep.Name = "txt_Cep";
            this.txt_Cep.Size = new System.Drawing.Size(70, 20);
            this.txt_Cep.TabIndex = 19;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(6, 358);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(28, 16);
            this.label30.TabIndex = 18;
            this.label30.Text = "UF:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(6, 324);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(54, 16);
            this.label29.TabIndex = 17;
            this.label29.Text = "Cidade:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(6, 295);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(46, 16);
            this.label28.TabIndex = 16;
            this.label28.Text = "Bairro:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(6, 263);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(80, 16);
            this.label27.TabIndex = 15;
            this.label27.Text = "Logradouro:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(6, 231);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(37, 16);
            this.label31.TabIndex = 14;
            this.label31.Text = "CEP:";
            // 
            // dgv_Motorista
            // 
            this.dgv_Motorista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Motorista.Location = new System.Drawing.Point(370, 6);
            this.dgv_Motorista.Name = "dgv_Motorista";
            this.dgv_Motorista.Size = new System.Drawing.Size(382, 378);
            this.dgv_Motorista.TabIndex = 13;
            // 
            // txt_Telefone
            // 
            this.txt_Telefone.Location = new System.Drawing.Point(136, 191);
            this.txt_Telefone.Name = "txt_Telefone";
            this.txt_Telefone.Size = new System.Drawing.Size(209, 20);
            this.txt_Telefone.TabIndex = 12;
            // 
            // txt_Cnh
            // 
            this.txt_Cnh.Location = new System.Drawing.Point(125, 106);
            this.txt_Cnh.Name = "txt_Cnh";
            this.txt_Cnh.Size = new System.Drawing.Size(220, 20);
            this.txt_Cnh.TabIndex = 11;
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(136, 152);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(209, 20);
            this.txt_Nome.TabIndex = 10;
            // 
            // txt_MotoristaID
            // 
            this.txt_MotoristaID.Location = new System.Drawing.Point(102, 67);
            this.txt_MotoristaID.Name = "txt_MotoristaID";
            this.txt_MotoristaID.Size = new System.Drawing.Size(243, 20);
            this.txt_MotoristaID.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 16);
            this.label9.TabIndex = 7;
            this.label9.Text = "Fone do motorista:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "CNH do motorista:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Nome do motorista:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Motorista ID:";
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
            // btn_ConsultarMotorista
            // 
            this.btn_ConsultarMotorista.Location = new System.Drawing.Point(195, 6);
            this.btn_ConsultarMotorista.Name = "btn_ConsultarMotorista";
            this.btn_ConsultarMotorista.Size = new System.Drawing.Size(75, 37);
            this.btn_ConsultarMotorista.TabIndex = 2;
            this.btn_ConsultarMotorista.Text = "Consultar";
            this.btn_ConsultarMotorista.UseVisualStyleBackColor = true;
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
            // btn_SalvarMotorista
            // 
            this.btn_SalvarMotorista.Location = new System.Drawing.Point(6, 6);
            this.btn_SalvarMotorista.Name = "btn_SalvarMotorista";
            this.btn_SalvarMotorista.Size = new System.Drawing.Size(75, 37);
            this.btn_SalvarMotorista.TabIndex = 0;
            this.btn_SalvarMotorista.Text = "Salvar";
            this.btn_SalvarMotorista.UseVisualStyleBackColor = true;
            // 
            // tab_Rota
            // 
            this.tab_Rota.Controls.Add(this.dgv_Rota);
            this.tab_Rota.Controls.Add(this.label13);
            this.tab_Rota.Controls.Add(this.label12);
            this.tab_Rota.Controls.Add(this.label11);
            this.tab_Rota.Controls.Add(this.label10);
            this.tab_Rota.Controls.Add(this.txt_Destino);
            this.tab_Rota.Controls.Add(this.txt_Distancia);
            this.tab_Rota.Controls.Add(this.txt_Origem);
            this.tab_Rota.Controls.Add(this.txt_RotaID);
            this.tab_Rota.Controls.Add(this.btn_ExcluirRota);
            this.tab_Rota.Controls.Add(this.btn_ConsultarRota);
            this.tab_Rota.Controls.Add(this.btn_EditarRota);
            this.tab_Rota.Controls.Add(this.btn_SalvarRota);
            this.tab_Rota.Location = new System.Drawing.Point(4, 22);
            this.tab_Rota.Name = "tab_Rota";
            this.tab_Rota.Size = new System.Drawing.Size(768, 400);
            this.tab_Rota.TabIndex = 2;
            this.tab_Rota.Text = "Rota";
            this.tab_Rota.UseVisualStyleBackColor = true;
            // 
            // dgv_Rota
            // 
            this.dgv_Rota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Rota.Location = new System.Drawing.Point(389, 13);
            this.dgv_Rota.Name = "dgv_Rota";
            this.dgv_Rota.Size = new System.Drawing.Size(357, 366);
            this.dgv_Rota.TabIndex = 12;
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
            // txt_Destino
            // 
            this.txt_Destino.Location = new System.Drawing.Point(160, 261);
            this.txt_Destino.Name = "txt_Destino";
            this.txt_Destino.Size = new System.Drawing.Size(100, 20);
            this.txt_Destino.TabIndex = 7;
            // 
            // txt_Distancia
            // 
            this.txt_Distancia.Location = new System.Drawing.Point(160, 341);
            this.txt_Distancia.Name = "txt_Distancia";
            this.txt_Distancia.Size = new System.Drawing.Size(100, 20);
            this.txt_Distancia.TabIndex = 6;
            this.txt_Distancia.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txt_Origem
            // 
            this.txt_Origem.Location = new System.Drawing.Point(160, 174);
            this.txt_Origem.Name = "txt_Origem";
            this.txt_Origem.Size = new System.Drawing.Size(100, 20);
            this.txt_Origem.TabIndex = 5;
            // 
            // txt_RotaID
            // 
            this.txt_RotaID.Location = new System.Drawing.Point(160, 102);
            this.txt_RotaID.Name = "txt_RotaID";
            this.txt_RotaID.Size = new System.Drawing.Size(100, 20);
            this.txt_RotaID.TabIndex = 4;
            this.txt_RotaID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_ExcluirRota
            // 
            this.btn_ExcluirRota.Location = new System.Drawing.Point(295, 13);
            this.btn_ExcluirRota.Name = "btn_ExcluirRota";
            this.btn_ExcluirRota.Size = new System.Drawing.Size(75, 33);
            this.btn_ExcluirRota.TabIndex = 3;
            this.btn_ExcluirRota.Text = "Excluir";
            this.btn_ExcluirRota.UseVisualStyleBackColor = true;
            this.btn_ExcluirRota.Click += new System.EventHandler(this.btn_ExcluirRota_Click);
            // 
            // btn_ConsultarRota
            // 
            this.btn_ConsultarRota.Location = new System.Drawing.Point(200, 13);
            this.btn_ConsultarRota.Name = "btn_ConsultarRota";
            this.btn_ConsultarRota.Size = new System.Drawing.Size(75, 33);
            this.btn_ConsultarRota.TabIndex = 2;
            this.btn_ConsultarRota.Text = "Consultar";
            this.btn_ConsultarRota.UseVisualStyleBackColor = true;
            this.btn_ConsultarRota.Click += new System.EventHandler(this.btn_ConsultarRota_Click);
            // 
            // btn_EditarRota
            // 
            this.btn_EditarRota.Location = new System.Drawing.Point(109, 13);
            this.btn_EditarRota.Name = "btn_EditarRota";
            this.btn_EditarRota.Size = new System.Drawing.Size(75, 33);
            this.btn_EditarRota.TabIndex = 1;
            this.btn_EditarRota.Text = "Editar";
            this.btn_EditarRota.UseVisualStyleBackColor = true;
            this.btn_EditarRota.Click += new System.EventHandler(this.btn_EditarRota_Click);
            // 
            // btn_SalvarRota
            // 
            this.btn_SalvarRota.Location = new System.Drawing.Point(16, 13);
            this.btn_SalvarRota.Name = "btn_SalvarRota";
            this.btn_SalvarRota.Size = new System.Drawing.Size(75, 33);
            this.btn_SalvarRota.TabIndex = 0;
            this.btn_SalvarRota.Text = "Salvar";
            this.btn_SalvarRota.UseVisualStyleBackColor = true;
            this.btn_SalvarRota.Click += new System.EventHandler(this.btn_SalvarRota_Click);
            // 
            // tab_precocombustivel
            // 
            this.tab_precocombustivel.Controls.Add(this.dgv_Preco);
            this.tab_precocombustivel.Controls.Add(this.btn_ExcluirPreco);
            this.tab_precocombustivel.Controls.Add(this.btn_ConsultarPreco);
            this.tab_precocombustivel.Controls.Add(this.btn_EditarPreco);
            this.tab_precocombustivel.Controls.Add(this.btn_SalvarPreco);
            this.tab_precocombustivel.Controls.Add(this.dtp_DataConsulta);
            this.tab_precocombustivel.Controls.Add(this.label17);
            this.tab_precocombustivel.Controls.Add(this.label16);
            this.tab_precocombustivel.Controls.Add(this.txt_Preco);
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
            // dgv_Preco
            // 
            this.dgv_Preco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Preco.Location = new System.Drawing.Point(397, 14);
            this.dgv_Preco.Name = "dgv_Preco";
            this.dgv_Preco.Size = new System.Drawing.Size(351, 368);
            this.dgv_Preco.TabIndex = 13;
            // 
            // btn_ExcluirPreco
            // 
            this.btn_ExcluirPreco.Location = new System.Drawing.Point(307, 14);
            this.btn_ExcluirPreco.Name = "btn_ExcluirPreco";
            this.btn_ExcluirPreco.Size = new System.Drawing.Size(75, 33);
            this.btn_ExcluirPreco.TabIndex = 12;
            this.btn_ExcluirPreco.Text = "Excluir";
            this.btn_ExcluirPreco.UseVisualStyleBackColor = true;
            // 
            // btn_ConsultarPreco
            // 
            this.btn_ConsultarPreco.Location = new System.Drawing.Point(212, 14);
            this.btn_ConsultarPreco.Name = "btn_ConsultarPreco";
            this.btn_ConsultarPreco.Size = new System.Drawing.Size(75, 33);
            this.btn_ConsultarPreco.TabIndex = 11;
            this.btn_ConsultarPreco.Text = "Consultar";
            this.btn_ConsultarPreco.UseVisualStyleBackColor = true;
            // 
            // btn_EditarPreco
            // 
            this.btn_EditarPreco.Location = new System.Drawing.Point(114, 14);
            this.btn_EditarPreco.Name = "btn_EditarPreco";
            this.btn_EditarPreco.Size = new System.Drawing.Size(75, 33);
            this.btn_EditarPreco.TabIndex = 10;
            this.btn_EditarPreco.Text = "Editar";
            this.btn_EditarPreco.UseVisualStyleBackColor = true;
            // 
            // btn_SalvarPreco
            // 
            this.btn_SalvarPreco.Location = new System.Drawing.Point(17, 14);
            this.btn_SalvarPreco.Name = "btn_SalvarPreco";
            this.btn_SalvarPreco.Size = new System.Drawing.Size(75, 33);
            this.btn_SalvarPreco.TabIndex = 9;
            this.btn_SalvarPreco.Text = "Salvar";
            this.btn_SalvarPreco.UseVisualStyleBackColor = true;
            // 
            // dtp_DataConsulta
            // 
            this.dtp_DataConsulta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_DataConsulta.Location = new System.Drawing.Point(154, 280);
            this.dtp_DataConsulta.Name = "dtp_DataConsulta";
            this.dtp_DataConsulta.Size = new System.Drawing.Size(86, 20);
            this.dtp_DataConsulta.TabIndex = 8;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(28, 284);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(111, 16);
            this.label17.TabIndex = 7;
            this.label17.Text = "Data da consulta:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(65, 231);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(74, 16);
            this.label16.TabIndex = 6;
            this.label16.Text = "Preço (R$):";
            // 
            // txt_Preco
            // 
            this.txt_Preco.Location = new System.Drawing.Point(154, 227);
            this.txt_Preco.Name = "txt_Preco";
            this.txt_Preco.Size = new System.Drawing.Size(121, 20);
            this.txt_Preco.TabIndex = 4;
            // 
            // cmb_Combustivel
            // 
            this.cmb_Combustivel.FormattingEnabled = true;
            this.cmb_Combustivel.Items.AddRange(new object[] {
            "Gasolina",
            "Diesel",
            "Etanol",
            "GNV"});
            this.cmb_Combustivel.Location = new System.Drawing.Point(154, 163);
            this.cmb_Combustivel.Name = "cmb_Combustivel";
            this.cmb_Combustivel.Size = new System.Drawing.Size(121, 21);
            this.cmb_Combustivel.TabIndex = 3;
            // 
            // txt_PrecoID
            // 
            this.txt_PrecoID.Location = new System.Drawing.Point(154, 105);
            this.txt_PrecoID.Name = "txt_PrecoID";
            this.txt_PrecoID.Size = new System.Drawing.Size(121, 20);
            this.txt_PrecoID.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(55, 168);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(84, 16);
            this.label15.TabIndex = 1;
            this.label15.Text = "Combustível:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(77, 105);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 16);
            this.label14.TabIndex = 0;
            this.label14.Text = "Comb ID:";
            // 
            // tab_viagem
            // 
            this.tab_viagem.Controls.Add(this.dgv_Viagem);
            this.tab_viagem.Controls.Add(this.cmb_Motorista);
            this.tab_viagem.Controls.Add(this.label24);
            this.tab_viagem.Controls.Add(this.label23);
            this.tab_viagem.Controls.Add(this.cmb_Rota);
            this.tab_viagem.Controls.Add(this.cmb_Veiculo);
            this.tab_viagem.Controls.Add(this.dtp_Chegada);
            this.tab_viagem.Controls.Add(this.chk_TemChegada);
            this.tab_viagem.Controls.Add(this.dtp_Saida);
            this.tab_viagem.Controls.Add(this.txt_ViagemID);
            this.tab_viagem.Controls.Add(this.label22);
            this.tab_viagem.Controls.Add(this.dtp_Ate);
            this.tab_viagem.Controls.Add(this.label20);
            this.tab_viagem.Controls.Add(this.label19);
            this.tab_viagem.Controls.Add(this.label18);
            this.tab_viagem.Controls.Add(this.btn_ExcluirViagem);
            this.tab_viagem.Controls.Add(this.btn_ConsultarViagem);
            this.tab_viagem.Controls.Add(this.btn_EditarViagem);
            this.tab_viagem.Controls.Add(this.btn_SalvarViagem);
            this.tab_viagem.Location = new System.Drawing.Point(4, 22);
            this.tab_viagem.Name = "tab_viagem";
            this.tab_viagem.Size = new System.Drawing.Size(768, 400);
            this.tab_viagem.TabIndex = 4;
            this.tab_viagem.Text = "Viagem";
            this.tab_viagem.UseVisualStyleBackColor = true;
            // 
            // dgv_Viagem
            // 
            this.dgv_Viagem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Viagem.Location = new System.Drawing.Point(391, 13);
            this.dgv_Viagem.Name = "dgv_Viagem";
            this.dgv_Viagem.Size = new System.Drawing.Size(361, 373);
            this.dgv_Viagem.TabIndex = 18;
            // 
            // cmb_Motorista
            // 
            this.cmb_Motorista.FormattingEnabled = true;
            this.cmb_Motorista.Location = new System.Drawing.Point(170, 339);
            this.cmb_Motorista.Name = "cmb_Motorista";
            this.cmb_Motorista.Size = new System.Drawing.Size(121, 21);
            this.cmb_Motorista.TabIndex = 17;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(93, 339);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(65, 16);
            this.label24.TabIndex = 16;
            this.label24.Text = "Motorista:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(60, 302);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(106, 16);
            this.label23.TabIndex = 15;
            this.label23.Text = "Rota da viagem:";
            // 
            // cmb_Rota
            // 
            this.cmb_Rota.FormattingEnabled = true;
            this.cmb_Rota.Location = new System.Drawing.Point(172, 301);
            this.cmb_Rota.Name = "cmb_Rota";
            this.cmb_Rota.Size = new System.Drawing.Size(121, 21);
            this.cmb_Rota.TabIndex = 14;
            // 
            // cmb_Veiculo
            // 
            this.cmb_Veiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Veiculo.FormattingEnabled = true;
            this.cmb_Veiculo.Location = new System.Drawing.Point(172, 261);
            this.cmb_Veiculo.Name = "cmb_Veiculo";
            this.cmb_Veiculo.Size = new System.Drawing.Size(121, 21);
            this.cmb_Veiculo.TabIndex = 13;
            // 
            // dtp_Chegada
            // 
            this.dtp_Chegada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Chegada.Location = new System.Drawing.Point(172, 215);
            this.dtp_Chegada.Name = "dtp_Chegada";
            this.dtp_Chegada.Size = new System.Drawing.Size(105, 20);
            this.dtp_Chegada.TabIndex = 12;
            // 
            // chk_TemChegada
            // 
            this.chk_TemChegada.AutoSize = true;
            this.chk_TemChegada.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chk_TemChegada.Location = new System.Drawing.Point(172, 171);
            this.chk_TemChegada.Name = "chk_TemChegada";
            this.chk_TemChegada.Size = new System.Drawing.Size(134, 17);
            this.chk_TemChegada.TabIndex = 11;
            this.chk_TemChegada.Text = "Tem Data de Chegada";
            this.chk_TemChegada.UseVisualStyleBackColor = true;
            // 
            // dtp_Saida
            // 
            this.dtp_Saida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Saida.Location = new System.Drawing.Point(170, 119);
            this.dtp_Saida.Name = "dtp_Saida";
            this.dtp_Saida.Size = new System.Drawing.Size(107, 20);
            this.dtp_Saida.TabIndex = 10;
            // 
            // txt_ViagemID
            // 
            this.txt_ViagemID.Location = new System.Drawing.Point(172, 69);
            this.txt_ViagemID.Name = "txt_ViagemID";
            this.txt_ViagemID.Size = new System.Drawing.Size(100, 20);
            this.txt_ViagemID.TabIndex = 9;
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
            // dtp_Ate
            // 
            this.dtp_Ate.AutoSize = true;
            this.dtp_Ate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Ate.Location = new System.Drawing.Point(10, 219);
            this.dtp_Ate.Name = "dtp_Ate";
            this.dtp_Ate.Size = new System.Drawing.Size(156, 16);
            this.dtp_Ate.TabIndex = 7;
            this.dtp_Ate.Text = "Data e hora de chegada:";
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
            // btn_ExcluirViagem
            // 
            this.btn_ExcluirViagem.Location = new System.Drawing.Point(295, 13);
            this.btn_ExcluirViagem.Name = "btn_ExcluirViagem";
            this.btn_ExcluirViagem.Size = new System.Drawing.Size(75, 38);
            this.btn_ExcluirViagem.TabIndex = 3;
            this.btn_ExcluirViagem.Text = "Excluir";
            this.btn_ExcluirViagem.UseVisualStyleBackColor = true;
            // 
            // btn_ConsultarViagem
            // 
            this.btn_ConsultarViagem.Location = new System.Drawing.Point(202, 13);
            this.btn_ConsultarViagem.Name = "btn_ConsultarViagem";
            this.btn_ConsultarViagem.Size = new System.Drawing.Size(75, 38);
            this.btn_ConsultarViagem.TabIndex = 2;
            this.btn_ConsultarViagem.Text = "Consultar";
            this.btn_ConsultarViagem.UseVisualStyleBackColor = true;
            // 
            // btn_EditarViagem
            // 
            this.btn_EditarViagem.Location = new System.Drawing.Point(108, 13);
            this.btn_EditarViagem.Name = "btn_EditarViagem";
            this.btn_EditarViagem.Size = new System.Drawing.Size(75, 38);
            this.btn_EditarViagem.TabIndex = 1;
            this.btn_EditarViagem.Text = "Editar";
            this.btn_EditarViagem.UseVisualStyleBackColor = true;
            // 
            // btn_SalvarViagem
            // 
            this.btn_SalvarViagem.Location = new System.Drawing.Point(13, 13);
            this.btn_SalvarViagem.Name = "btn_SalvarViagem";
            this.btn_SalvarViagem.Size = new System.Drawing.Size(75, 38);
            this.btn_SalvarViagem.TabIndex = 0;
            this.btn_SalvarViagem.Text = "Salvar";
            this.btn_SalvarViagem.UseVisualStyleBackColor = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Veiculo)).EndInit();
            this.tab_motorista.ResumeLayout(false);
            this.tab_motorista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Motorista)).EndInit();
            this.tab_Rota.ResumeLayout(false);
            this.tab_Rota.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Rota)).EndInit();
            this.tab_precocombustivel.ResumeLayout(false);
            this.tab_precocombustivel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Preco)).EndInit();
            this.tab_viagem.ResumeLayout(false);
            this.tab_viagem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Viagem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_veiculo;
        private System.Windows.Forms.TabPage tab_motorista;
        private System.Windows.Forms.TabPage tab_Rota;
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
        private System.Windows.Forms.MaskedTextBox txt_Telefone;
        private System.Windows.Forms.MaskedTextBox txt_Cnh;
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
        private System.Windows.Forms.TextBox txt_RotaID;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_Preco;
        private System.Windows.Forms.ComboBox cmb_Combustivel;
        private System.Windows.Forms.TextBox txt_PrecoID;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtp_DataConsulta;
        private System.Windows.Forms.Button btn_SalvarViagem;
        private System.Windows.Forms.ComboBox cmb_Veiculo;
        private System.Windows.Forms.DateTimePicker dtp_Chegada;
        private System.Windows.Forms.CheckBox chk_TemChegada;
        private System.Windows.Forms.DateTimePicker dtp_Saida;
        private System.Windows.Forms.TextBox txt_ViagemID;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label dtp_Ate;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btn_ExcluirViagem;
        private System.Windows.Forms.Button btn_ConsultarViagem;
        private System.Windows.Forms.Button btn_EditarViagem;
        private System.Windows.Forms.ComboBox cmb_Motorista;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox cmb_Rota;
        private System.Windows.Forms.Button btn_SalvarPreco;
        private System.Windows.Forms.Button btn_ExcluirPreco;
        private System.Windows.Forms.Button btn_ConsultarPreco;
        private System.Windows.Forms.Button btn_EditarPreco;
        private System.Windows.Forms.DataGridView dgv_Veiculo;
        private System.Windows.Forms.DataGridView dgv_Motorista;
        private System.Windows.Forms.DataGridView dgv_Rota;
        private System.Windows.Forms.DataGridView dgv_Preco;
        private System.Windows.Forms.DataGridView dgv_Viagem;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Button btn_BuscarCep;
        private System.Windows.Forms.TextBox txt_Uf;
        private System.Windows.Forms.TextBox txt_Cidade;
        private System.Windows.Forms.TextBox txt_Bairro;
        private System.Windows.Forms.TextBox txt_Logradouro;
        private System.Windows.Forms.TextBox txt_Cep;
    }
}

