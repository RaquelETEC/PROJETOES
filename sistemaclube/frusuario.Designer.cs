namespace sistemaclube
{
    partial class frusuario
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label lOGINLabel;
            System.Windows.Forms.Label sENHALabel;
            System.Windows.Forms.Label fUNCAOLabel;
            System.Windows.Forms.Label bLOQUEADOLabel;
            System.Windows.Forms.Label iD_USUARIOLabel;
            this.sistemaDataSet = new sistemaclube.sistemaDataSet();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioTableAdapter = new sistemaclube.sistemaDataSetTableAdapters.usuarioTableAdapter();
            this.tableAdapterManager = new sistemaclube.sistemaDataSetTableAdapters.TableAdapterManager();
            this.lOGINTextBox = new System.Windows.Forms.TextBox();
            this.sENHATextBox = new System.Windows.Forms.TextBox();
            this.fUNCAOComboBox = new System.Windows.Forms.ComboBox();
            this.bLOQUEADOComboBox = new System.Windows.Forms.ComboBox();
            this.btexcluir = new System.Windows.Forms.Button();
            this.btcancelar = new System.Windows.Forms.Button();
            this.btsalvar = new System.Windows.Forms.Button();
            this.btinserir = new System.Windows.Forms.Button();
            this.usuarioDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btvoltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.iD_USUARIOTextBox = new System.Windows.Forms.TextBox();
            lOGINLabel = new System.Windows.Forms.Label();
            sENHALabel = new System.Windows.Forms.Label();
            fUNCAOLabel = new System.Windows.Forms.Label();
            bLOQUEADOLabel = new System.Windows.Forms.Label();
            iD_USUARIOLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lOGINLabel
            // 
            lOGINLabel.AutoSize = true;
            lOGINLabel.BackColor = System.Drawing.Color.Transparent;
            lOGINLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            lOGINLabel.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lOGINLabel.ForeColor = System.Drawing.Color.White;
            lOGINLabel.Location = new System.Drawing.Point(53, 36);
            lOGINLabel.Name = "lOGINLabel";
            lOGINLabel.Size = new System.Drawing.Size(51, 15);
            lOGINLabel.TabIndex = 3;
            lOGINLabel.Text = "E-mail:";
            // 
            // sENHALabel
            // 
            sENHALabel.AutoSize = true;
            sENHALabel.BackColor = System.Drawing.Color.Transparent;
            sENHALabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            sENHALabel.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sENHALabel.ForeColor = System.Drawing.Color.White;
            sENHALabel.Location = new System.Drawing.Point(53, 85);
            sENHALabel.Name = "sENHALabel";
            sENHALabel.Size = new System.Drawing.Size(48, 15);
            sENHALabel.TabIndex = 5;
            sENHALabel.Text = "Senha:";
            // 
            // fUNCAOLabel
            // 
            fUNCAOLabel.AutoSize = true;
            fUNCAOLabel.BackColor = System.Drawing.Color.Transparent;
            fUNCAOLabel.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fUNCAOLabel.ForeColor = System.Drawing.Color.White;
            fUNCAOLabel.Location = new System.Drawing.Point(53, 191);
            fUNCAOLabel.Name = "fUNCAOLabel";
            fUNCAOLabel.Size = new System.Drawing.Size(56, 15);
            fUNCAOLabel.TabIndex = 9;
            fUNCAOLabel.Text = "Função:";
            // 
            // bLOQUEADOLabel
            // 
            bLOQUEADOLabel.AutoSize = true;
            bLOQUEADOLabel.BackColor = System.Drawing.Color.Transparent;
            bLOQUEADOLabel.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bLOQUEADOLabel.ForeColor = System.Drawing.Color.White;
            bLOQUEADOLabel.Location = new System.Drawing.Point(53, 138);
            bLOQUEADOLabel.Name = "bLOQUEADOLabel";
            bLOQUEADOLabel.Size = new System.Drawing.Size(77, 15);
            bLOQUEADOLabel.TabIndex = 10;
            bLOQUEADOLabel.Text = "Bloqueado:";
            // 
            // sistemaDataSet
            // 
            this.sistemaDataSet.DataSetName = "sistemaDataSet";
            this.sistemaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "usuario";
            this.usuarioBindingSource.DataSource = this.sistemaDataSet;
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.cad_quadraTableAdapter = null;
            this.tableAdapterManager.horariosTableAdapter = null;
            this.tableAdapterManager.reservaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = sistemaclube.sistemaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuarioTableAdapter = this.usuarioTableAdapter;
            // 
            // lOGINTextBox
            // 
            this.lOGINTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "LOGIN", true));
            this.lOGINTextBox.Location = new System.Drawing.Point(42, 54);
            this.lOGINTextBox.Name = "lOGINTextBox";
            this.lOGINTextBox.Size = new System.Drawing.Size(547, 20);
            this.lOGINTextBox.TabIndex = 4;
            // 
            // sENHATextBox
            // 
            this.sENHATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "SENHA", true));
            this.sENHATextBox.Location = new System.Drawing.Point(42, 103);
            this.sENHATextBox.Name = "sENHATextBox";
            this.sENHATextBox.Size = new System.Drawing.Size(121, 20);
            this.sENHATextBox.TabIndex = 6;
            // 
            // fUNCAOComboBox
            // 
            this.fUNCAOComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "FUNCAO", true));
            this.fUNCAOComboBox.FormattingEnabled = true;
            this.fUNCAOComboBox.Items.AddRange(new object[] {
            "Adiministrador(a)",
            "Zelador(a)"});
            this.fUNCAOComboBox.Location = new System.Drawing.Point(42, 209);
            this.fUNCAOComboBox.Name = "fUNCAOComboBox";
            this.fUNCAOComboBox.Size = new System.Drawing.Size(121, 21);
            this.fUNCAOComboBox.TabIndex = 10;
            // 
            // bLOQUEADOComboBox
            // 
            this.bLOQUEADOComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "BLOQUEADO", true));
            this.bLOQUEADOComboBox.FormattingEnabled = true;
            this.bLOQUEADOComboBox.Items.AddRange(new object[] {
            "S",
            "N"});
            this.bLOQUEADOComboBox.Location = new System.Drawing.Point(42, 156);
            this.bLOQUEADOComboBox.Name = "bLOQUEADOComboBox";
            this.bLOQUEADOComboBox.Size = new System.Drawing.Size(121, 21);
            this.bLOQUEADOComboBox.TabIndex = 11;
            // 
            // btexcluir
            // 
            this.btexcluir.BackColor = System.Drawing.Color.Transparent;
            this.btexcluir.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btexcluir.FlatAppearance.BorderSize = 2;
            this.btexcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btexcluir.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btexcluir.ForeColor = System.Drawing.Color.White;
            this.btexcluir.Location = new System.Drawing.Point(1206, 204);
            this.btexcluir.Name = "btexcluir";
            this.btexcluir.Size = new System.Drawing.Size(105, 38);
            this.btexcluir.TabIndex = 27;
            this.btexcluir.Text = "Excluir";
            this.btexcluir.UseVisualStyleBackColor = false;
            this.btexcluir.Click += new System.EventHandler(this.btexcluir_Click);
            // 
            // btcancelar
            // 
            this.btcancelar.BackColor = System.Drawing.Color.Transparent;
            this.btcancelar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btcancelar.FlatAppearance.BorderSize = 2;
            this.btcancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btcancelar.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcancelar.ForeColor = System.Drawing.Color.White;
            this.btcancelar.Location = new System.Drawing.Point(1206, 150);
            this.btcancelar.Name = "btcancelar";
            this.btcancelar.Size = new System.Drawing.Size(105, 38);
            this.btcancelar.TabIndex = 26;
            this.btcancelar.Text = "Cancelar";
            this.btcancelar.UseVisualStyleBackColor = false;
            this.btcancelar.Click += new System.EventHandler(this.btcancelar_Click);
            // 
            // btsalvar
            // 
            this.btsalvar.BackColor = System.Drawing.Color.Transparent;
            this.btsalvar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btsalvar.FlatAppearance.BorderSize = 2;
            this.btsalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btsalvar.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsalvar.ForeColor = System.Drawing.Color.White;
            this.btsalvar.Location = new System.Drawing.Point(1206, 97);
            this.btsalvar.Name = "btsalvar";
            this.btsalvar.Size = new System.Drawing.Size(105, 38);
            this.btsalvar.TabIndex = 25;
            this.btsalvar.Text = "Salvar";
            this.btsalvar.UseVisualStyleBackColor = false;
            this.btsalvar.Click += new System.EventHandler(this.btsalvar_Click);
            // 
            // btinserir
            // 
            this.btinserir.BackColor = System.Drawing.Color.Transparent;
            this.btinserir.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btinserir.FlatAppearance.BorderSize = 2;
            this.btinserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btinserir.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btinserir.ForeColor = System.Drawing.Color.White;
            this.btinserir.Location = new System.Drawing.Point(1206, 44);
            this.btinserir.Name = "btinserir";
            this.btinserir.Size = new System.Drawing.Size(105, 38);
            this.btinserir.TabIndex = 24;
            this.btinserir.Text = "Inserir";
            this.btinserir.UseVisualStyleBackColor = false;
            this.btinserir.Click += new System.EventHandler(this.btinserir_Click);
            // 
            // usuarioDataGridView
            // 
            this.usuarioDataGridView.AllowUserToAddRows = false;
            this.usuarioDataGridView.AllowUserToDeleteRows = false;
            this.usuarioDataGridView.AutoGenerateColumns = false;
            this.usuarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usuarioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.usuarioDataGridView.DataSource = this.usuarioBindingSource;
            this.usuarioDataGridView.GridColor = System.Drawing.Color.Silver;
            this.usuarioDataGridView.Location = new System.Drawing.Point(45, 270);
            this.usuarioDataGridView.Name = "usuarioDataGridView";
            this.usuarioDataGridView.ReadOnly = true;
            this.usuarioDataGridView.Size = new System.Drawing.Size(1266, 365);
            this.usuarioDataGridView.TabIndex = 28;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_USUARIO";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "LOGIN";
            this.dataGridViewTextBoxColumn2.HeaderText = "Login";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 400;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SENHA";
            this.dataGridViewTextBoxColumn3.HeaderText = "Senha";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 400;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "BLOQUEADO";
            this.dataGridViewTextBoxColumn4.HeaderText = "Bloqueado";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 102;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "FUNCAO";
            this.dataGridViewTextBoxColumn5.HeaderText = "Função";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 220;
            // 
            // btvoltar
            // 
            this.btvoltar.BackColor = System.Drawing.Color.Blue;
            this.btvoltar.FlatAppearance.BorderSize = 0;
            this.btvoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btvoltar.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btvoltar.ForeColor = System.Drawing.Color.White;
            this.btvoltar.Location = new System.Drawing.Point(1313, 10);
            this.btvoltar.Name = "btvoltar";
            this.btvoltar.Size = new System.Drawing.Size(32, 23);
            this.btvoltar.TabIndex = 29;
            this.btvoltar.Text = "<";
            this.btvoltar.UseVisualStyleBackColor = false;
            this.btvoltar.Click += new System.EventHandler(this.btvoltar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(44, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 15);
            this.label1.TabIndex = 62;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(44, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 15);
            this.label2.TabIndex = 63;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(44, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 15);
            this.label3.TabIndex = 64;
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(44, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 15);
            this.label4.TabIndex = 65;
            this.label4.Text = "*";
            // 
            // iD_USUARIOLabel
            // 
            iD_USUARIOLabel.AutoSize = true;
            iD_USUARIOLabel.BackColor = System.Drawing.Color.Transparent;
            iD_USUARIOLabel.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iD_USUARIOLabel.ForeColor = System.Drawing.Color.White;
            iD_USUARIOLabel.Location = new System.Drawing.Point(470, 160);
            iD_USUARIOLabel.Name = "iD_USUARIOLabel";
            iD_USUARIOLabel.Size = new System.Drawing.Size(84, 15);
            iD_USUARIOLabel.TabIndex = 65;
            iD_USUARIOLabel.Text = "ID USUARIO:";
            // 
            // iD_USUARIOTextBox
            // 
            this.iD_USUARIOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "ID_USUARIO", true));
            this.iD_USUARIOTextBox.Location = new System.Drawing.Point(560, 157);
            this.iD_USUARIOTextBox.Name = "iD_USUARIOTextBox";
            this.iD_USUARIOTextBox.Size = new System.Drawing.Size(100, 20);
            this.iD_USUARIOTextBox.TabIndex = 66;
            // 
            // frusuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::sistemaclube.Properties.Resources.Clube_de_tênis_fundo;
            this.ClientSize = new System.Drawing.Size(1365, 655);
            this.Controls.Add(iD_USUARIOLabel);
            this.Controls.Add(this.iD_USUARIOTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btvoltar);
            this.Controls.Add(this.usuarioDataGridView);
            this.Controls.Add(this.btexcluir);
            this.Controls.Add(this.btcancelar);
            this.Controls.Add(this.btsalvar);
            this.Controls.Add(this.btinserir);
            this.Controls.Add(bLOQUEADOLabel);
            this.Controls.Add(this.bLOQUEADOComboBox);
            this.Controls.Add(lOGINLabel);
            this.Controls.Add(this.lOGINTextBox);
            this.Controls.Add(sENHALabel);
            this.Controls.Add(this.sENHATextBox);
            this.Controls.Add(fUNCAOLabel);
            this.Controls.Add(this.fUNCAOComboBox);
            this.Name = "frusuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Cadastros de usuario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frusuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sistemaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private sistemaDataSet sistemaDataSet;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private sistemaDataSetTableAdapters.usuarioTableAdapter usuarioTableAdapter;
        private sistemaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox lOGINTextBox;
        private System.Windows.Forms.TextBox sENHATextBox;
        private System.Windows.Forms.ComboBox fUNCAOComboBox;
        private System.Windows.Forms.ComboBox bLOQUEADOComboBox;
        private System.Windows.Forms.Button btexcluir;
        private System.Windows.Forms.Button btcancelar;
        private System.Windows.Forms.Button btsalvar;
        private System.Windows.Forms.Button btinserir;
        private System.Windows.Forms.DataGridView usuarioDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button btvoltar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox iD_USUARIOTextBox;
    }
}