
namespace WindowsFormsApp1
{
    partial class PrincipalForm
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
            this.gbxChamado = new System.Windows.Forms.GroupBox();
            this.btnNovoChamado = new System.Windows.Forms.Button();
            this.gbxListaChamado = new System.Windows.Forms.GroupBox();
            this.lvChamado = new System.Windows.Forms.ListView();
            this.gbxEditarNovoChamado = new System.Windows.Forms.GroupBox();
            this.btnCancelarChamado = new System.Windows.Forms.Button();
            this.btnSalvarChamado = new System.Windows.Forms.Button();
            this.txtDescricaoChamado = new System.Windows.Forms.TextBox();
            this.txtTituloChamado = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDataChamado = new System.Windows.Forms.MaskedTextBox();
            this.btnEditarChamado = new System.Windows.Forms.Button();
            this.gbxEditarNovoEquipamento = new System.Windows.Forms.GroupBox();
            this.txtValorEquipamento = new System.Windows.Forms.MaskedTextBox();
            this.btnCancelarEquipamento = new System.Windows.Forms.Button();
            this.btnSalvarEquipamento = new System.Windows.Forms.Button();
            this.txtSerieEquipamento = new System.Windows.Forms.TextBox();
            this.txtFabricanteEquipamento = new System.Windows.Forms.TextBox();
            this.txtNomeEquipamento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDataEquipamento = new System.Windows.Forms.MaskedTextBox();
            this.lvEquipamento = new System.Windows.Forms.ListView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnNovoEquipamento = new System.Windows.Forms.Button();
            this.btnEditarEquipamento = new System.Windows.Forms.Button();
            this.btnExcluirEquipamento = new System.Windows.Forms.Button();
            this.gbxEquipamento = new System.Windows.Forms.GroupBox();
            this.cbxEquipamentoChamado = new System.Windows.Forms.ComboBox();
            this.dtpEquipamento = new System.Windows.Forms.DateTimePicker();
            this.dtpChamado = new System.Windows.Forms.DateTimePicker();
            this.gbxChamado.SuspendLayout();
            this.gbxListaChamado.SuspendLayout();
            this.gbxEditarNovoChamado.SuspendLayout();
            this.gbxEditarNovoEquipamento.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbxEquipamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxChamado
            // 
            this.gbxChamado.Controls.Add(this.btnNovoChamado);
            this.gbxChamado.Controls.Add(this.gbxListaChamado);
            this.gbxChamado.Controls.Add(this.gbxEditarNovoChamado);
            this.gbxChamado.Controls.Add(this.btnEditarChamado);
            this.gbxChamado.Location = new System.Drawing.Point(413, 18);
            this.gbxChamado.Name = "gbxChamado";
            this.gbxChamado.Size = new System.Drawing.Size(364, 425);
            this.gbxChamado.TabIndex = 0;
            this.gbxChamado.TabStop = false;
            this.gbxChamado.Text = "Chamados";
            // 
            // btnNovoChamado
            // 
            this.btnNovoChamado.Location = new System.Drawing.Point(16, 27);
            this.btnNovoChamado.Name = "btnNovoChamado";
            this.btnNovoChamado.Size = new System.Drawing.Size(75, 23);
            this.btnNovoChamado.TabIndex = 1;
            this.btnNovoChamado.Text = "Novo";
            this.btnNovoChamado.UseVisualStyleBackColor = true;
            this.btnNovoChamado.Click += new System.EventHandler(this.btnNovoChamado_Click);
            // 
            // gbxListaChamado
            // 
            this.gbxListaChamado.Controls.Add(this.lvChamado);
            this.gbxListaChamado.Location = new System.Drawing.Point(16, 69);
            this.gbxListaChamado.Name = "gbxListaChamado";
            this.gbxListaChamado.Size = new System.Drawing.Size(327, 168);
            this.gbxListaChamado.TabIndex = 0;
            this.gbxListaChamado.TabStop = false;
            this.gbxListaChamado.Text = "Lista Chamado";
            // 
            // lvChamado
            // 
            this.lvChamado.FullRowSelect = true;
            this.lvChamado.GridLines = true;
            this.lvChamado.HideSelection = false;
            this.lvChamado.Location = new System.Drawing.Point(16, 26);
            this.lvChamado.Name = "lvChamado";
            this.lvChamado.Size = new System.Drawing.Size(298, 128);
            this.lvChamado.TabIndex = 0;
            this.lvChamado.UseCompatibleStateImageBehavior = false;
            this.lvChamado.View = System.Windows.Forms.View.Details;
            // 
            // gbxEditarNovoChamado
            // 
            this.gbxEditarNovoChamado.Controls.Add(this.dtpChamado);
            this.gbxEditarNovoChamado.Controls.Add(this.cbxEquipamentoChamado);
            this.gbxEditarNovoChamado.Controls.Add(this.btnCancelarChamado);
            this.gbxEditarNovoChamado.Controls.Add(this.btnSalvarChamado);
            this.gbxEditarNovoChamado.Controls.Add(this.txtDescricaoChamado);
            this.gbxEditarNovoChamado.Controls.Add(this.txtTituloChamado);
            this.gbxEditarNovoChamado.Controls.Add(this.label7);
            this.gbxEditarNovoChamado.Controls.Add(this.label8);
            this.gbxEditarNovoChamado.Controls.Add(this.label9);
            this.gbxEditarNovoChamado.Controls.Add(this.label10);
            this.gbxEditarNovoChamado.Controls.Add(this.txtDataChamado);
            this.gbxEditarNovoChamado.Location = new System.Drawing.Point(16, 257);
            this.gbxEditarNovoChamado.Name = "gbxEditarNovoChamado";
            this.gbxEditarNovoChamado.Size = new System.Drawing.Size(327, 154);
            this.gbxEditarNovoChamado.TabIndex = 0;
            this.gbxEditarNovoChamado.TabStop = false;
            this.gbxEditarNovoChamado.Text = "Editar/Novo";
            // 
            // btnCancelarChamado
            // 
            this.btnCancelarChamado.Location = new System.Drawing.Point(17, 119);
            this.btnCancelarChamado.Name = "btnCancelarChamado";
            this.btnCancelarChamado.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarChamado.TabIndex = 10;
            this.btnCancelarChamado.Text = "Cancelar";
            this.btnCancelarChamado.UseVisualStyleBackColor = true;
            this.btnCancelarChamado.Click += new System.EventHandler(this.btnCancelarChamado_Click);
            // 
            // btnSalvarChamado
            // 
            this.btnSalvarChamado.Location = new System.Drawing.Point(240, 119);
            this.btnSalvarChamado.Name = "btnSalvarChamado";
            this.btnSalvarChamado.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarChamado.TabIndex = 9;
            this.btnSalvarChamado.Text = "Salvar";
            this.btnSalvarChamado.UseVisualStyleBackColor = true;
            this.btnSalvarChamado.Click += new System.EventHandler(this.btnSalvarChamado_Click);
            // 
            // txtDescricaoChamado
            // 
            this.txtDescricaoChamado.Location = new System.Drawing.Point(115, 39);
            this.txtDescricaoChamado.Name = "txtDescricaoChamado";
            this.txtDescricaoChamado.Size = new System.Drawing.Size(200, 20);
            this.txtDescricaoChamado.TabIndex = 5;
            // 
            // txtTituloChamado
            // 
            this.txtTituloChamado.Location = new System.Drawing.Point(17, 39);
            this.txtTituloChamado.Name = "txtTituloChamado";
            this.txtTituloChamado.Size = new System.Drawing.Size(92, 20);
            this.txtTituloChamado.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Selecione Equipamento:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(112, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Descrição:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Título:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(196, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Data Abertura.";
            // 
            // txtDataChamado
            // 
            this.txtDataChamado.Location = new System.Drawing.Point(127, 122);
            this.txtDataChamado.Mask = "00/00/0000";
            this.txtDataChamado.Name = "txtDataChamado";
            this.txtDataChamado.Size = new System.Drawing.Size(71, 20);
            this.txtDataChamado.TabIndex = 8;
            this.txtDataChamado.ValidatingType = typeof(System.DateTime);
            // 
            // btnEditarChamado
            // 
            this.btnEditarChamado.Location = new System.Drawing.Point(97, 27);
            this.btnEditarChamado.Name = "btnEditarChamado";
            this.btnEditarChamado.Size = new System.Drawing.Size(75, 23);
            this.btnEditarChamado.TabIndex = 2;
            this.btnEditarChamado.Text = "Editar";
            this.btnEditarChamado.UseVisualStyleBackColor = true;
            this.btnEditarChamado.Click += new System.EventHandler(this.btnEditarChamado_Click);
            // 
            // gbxEditarNovoEquipamento
            // 
            this.gbxEditarNovoEquipamento.Controls.Add(this.dtpEquipamento);
            this.gbxEditarNovoEquipamento.Controls.Add(this.txtValorEquipamento);
            this.gbxEditarNovoEquipamento.Controls.Add(this.btnCancelarEquipamento);
            this.gbxEditarNovoEquipamento.Controls.Add(this.btnSalvarEquipamento);
            this.gbxEditarNovoEquipamento.Controls.Add(this.txtSerieEquipamento);
            this.gbxEditarNovoEquipamento.Controls.Add(this.txtFabricanteEquipamento);
            this.gbxEditarNovoEquipamento.Controls.Add(this.txtNomeEquipamento);
            this.gbxEditarNovoEquipamento.Controls.Add(this.label5);
            this.gbxEditarNovoEquipamento.Controls.Add(this.label4);
            this.gbxEditarNovoEquipamento.Controls.Add(this.label3);
            this.gbxEditarNovoEquipamento.Controls.Add(this.label2);
            this.gbxEditarNovoEquipamento.Controls.Add(this.label1);
            this.gbxEditarNovoEquipamento.Controls.Add(this.txtDataEquipamento);
            this.gbxEditarNovoEquipamento.Location = new System.Drawing.Point(16, 257);
            this.gbxEditarNovoEquipamento.Name = "gbxEditarNovoEquipamento";
            this.gbxEditarNovoEquipamento.Size = new System.Drawing.Size(327, 154);
            this.gbxEditarNovoEquipamento.TabIndex = 0;
            this.gbxEditarNovoEquipamento.TabStop = false;
            this.gbxEditarNovoEquipamento.Text = "Editar/Novo";
            // 
            // txtValorEquipamento
            // 
            this.txtValorEquipamento.Location = new System.Drawing.Point(135, 78);
            this.txtValorEquipamento.Mask = "00000,00";
            this.txtValorEquipamento.Name = "txtValorEquipamento";
            this.txtValorEquipamento.Size = new System.Drawing.Size(57, 20);
            this.txtValorEquipamento.TabIndex = 7;
            this.txtValorEquipamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCancelarEquipamento
            // 
            this.btnCancelarEquipamento.Location = new System.Drawing.Point(17, 119);
            this.btnCancelarEquipamento.Name = "btnCancelarEquipamento";
            this.btnCancelarEquipamento.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarEquipamento.TabIndex = 10;
            this.btnCancelarEquipamento.Text = "Cancelar";
            this.btnCancelarEquipamento.UseVisualStyleBackColor = true;
            this.btnCancelarEquipamento.Click += new System.EventHandler(this.btnCancelarEquipamento_Click);
            // 
            // btnSalvarEquipamento
            // 
            this.btnSalvarEquipamento.Location = new System.Drawing.Point(240, 119);
            this.btnSalvarEquipamento.Name = "btnSalvarEquipamento";
            this.btnSalvarEquipamento.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarEquipamento.TabIndex = 9;
            this.btnSalvarEquipamento.Text = "Salvar";
            this.btnSalvarEquipamento.UseVisualStyleBackColor = true;
            this.btnSalvarEquipamento.Click += new System.EventHandler(this.btnSalvarEquipamento_Click);
            // 
            // txtSerieEquipamento
            // 
            this.txtSerieEquipamento.Location = new System.Drawing.Point(17, 78);
            this.txtSerieEquipamento.Name = "txtSerieEquipamento";
            this.txtSerieEquipamento.Size = new System.Drawing.Size(113, 20);
            this.txtSerieEquipamento.TabIndex = 6;
            // 
            // txtFabricanteEquipamento
            // 
            this.txtFabricanteEquipamento.Location = new System.Drawing.Point(212, 39);
            this.txtFabricanteEquipamento.Name = "txtFabricanteEquipamento";
            this.txtFabricanteEquipamento.Size = new System.Drawing.Size(103, 20);
            this.txtFabricanteEquipamento.TabIndex = 5;
            // 
            // txtNomeEquipamento
            // 
            this.txtNomeEquipamento.Location = new System.Drawing.Point(17, 39);
            this.txtNomeEquipamento.Name = "txtNomeEquipamento";
            this.txtNomeEquipamento.Size = new System.Drawing.Size(189, 20);
            this.txtNomeEquipamento.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(132, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Valor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "N. Série:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fabricante:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Data Fabricação";
            // 
            // txtDataEquipamento
            // 
            this.txtDataEquipamento.Location = new System.Drawing.Point(121, 121);
            this.txtDataEquipamento.Mask = "00/00/0000";
            this.txtDataEquipamento.Name = "txtDataEquipamento";
            this.txtDataEquipamento.Size = new System.Drawing.Size(71, 20);
            this.txtDataEquipamento.TabIndex = 8;
            this.txtDataEquipamento.ValidatingType = typeof(System.DateTime);
            // 
            // lvEquipamento
            // 
            this.lvEquipamento.FullRowSelect = true;
            this.lvEquipamento.GridLines = true;
            this.lvEquipamento.HideSelection = false;
            this.lvEquipamento.Location = new System.Drawing.Point(16, 26);
            this.lvEquipamento.Name = "lvEquipamento";
            this.lvEquipamento.Size = new System.Drawing.Size(298, 128);
            this.lvEquipamento.TabIndex = 0;
            this.lvEquipamento.UseCompatibleStateImageBehavior = false;
            this.lvEquipamento.View = System.Windows.Forms.View.Details;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lvEquipamento);
            this.groupBox3.Location = new System.Drawing.Point(16, 69);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(327, 168);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lista Equipamento";
            // 
            // btnNovoEquipamento
            // 
            this.btnNovoEquipamento.Location = new System.Drawing.Point(17, 27);
            this.btnNovoEquipamento.Name = "btnNovoEquipamento";
            this.btnNovoEquipamento.Size = new System.Drawing.Size(75, 23);
            this.btnNovoEquipamento.TabIndex = 1;
            this.btnNovoEquipamento.Text = "Novo";
            this.btnNovoEquipamento.UseVisualStyleBackColor = true;
            this.btnNovoEquipamento.Click += new System.EventHandler(this.btnNovoEquipamento_Click);
            // 
            // btnEditarEquipamento
            // 
            this.btnEditarEquipamento.Location = new System.Drawing.Point(98, 27);
            this.btnEditarEquipamento.Name = "btnEditarEquipamento";
            this.btnEditarEquipamento.Size = new System.Drawing.Size(75, 23);
            this.btnEditarEquipamento.TabIndex = 2;
            this.btnEditarEquipamento.Text = "Editar";
            this.btnEditarEquipamento.UseVisualStyleBackColor = true;
            this.btnEditarEquipamento.Click += new System.EventHandler(this.btnEditarEquipamento_Click);
            // 
            // btnExcluirEquipamento
            // 
            this.btnExcluirEquipamento.Location = new System.Drawing.Point(179, 27);
            this.btnExcluirEquipamento.Name = "btnExcluirEquipamento";
            this.btnExcluirEquipamento.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirEquipamento.TabIndex = 3;
            this.btnExcluirEquipamento.Text = "Excluir";
            this.btnExcluirEquipamento.UseVisualStyleBackColor = true;
            this.btnExcluirEquipamento.Click += new System.EventHandler(this.btnExcluirEquipamento_Click);
            // 
            // gbxEquipamento
            // 
            this.gbxEquipamento.Controls.Add(this.btnExcluirEquipamento);
            this.gbxEquipamento.Controls.Add(this.groupBox3);
            this.gbxEquipamento.Controls.Add(this.gbxEditarNovoEquipamento);
            this.gbxEquipamento.Controls.Add(this.btnEditarEquipamento);
            this.gbxEquipamento.Controls.Add(this.btnNovoEquipamento);
            this.gbxEquipamento.Location = new System.Drawing.Point(26, 18);
            this.gbxEquipamento.Name = "gbxEquipamento";
            this.gbxEquipamento.Size = new System.Drawing.Size(357, 426);
            this.gbxEquipamento.TabIndex = 5;
            this.gbxEquipamento.TabStop = false;
            this.gbxEquipamento.Text = "Equipamentos";
            // 
            // cbxEquipamentoChamado
            // 
            this.cbxEquipamentoChamado.FormattingEnabled = true;
            this.cbxEquipamentoChamado.Location = new System.Drawing.Point(17, 78);
            this.cbxEquipamentoChamado.Name = "cbxEquipamentoChamado";
            this.cbxEquipamentoChamado.Size = new System.Drawing.Size(176, 21);
            this.cbxEquipamentoChamado.TabIndex = 11;
            // 
            // dtpEquipamento
            // 
            this.dtpEquipamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEquipamento.Location = new System.Drawing.Point(198, 78);
            this.dtpEquipamento.Name = "dtpEquipamento";
            this.dtpEquipamento.Size = new System.Drawing.Size(116, 20);
            this.dtpEquipamento.TabIndex = 11;
            // 
            // dtpChamado
            // 
            this.dtpChamado.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpChamado.Location = new System.Drawing.Point(199, 79);
            this.dtpChamado.Name = "dtpChamado";
            this.dtpChamado.Size = new System.Drawing.Size(116, 20);
            this.dtpChamado.TabIndex = 11;
            // 
            // Geral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 462);
            this.Controls.Add(this.gbxChamado);
            this.Controls.Add(this.gbxEquipamento);
            this.Name = "Geral";
            this.Text = "Geral";
            this.gbxChamado.ResumeLayout(false);
            this.gbxListaChamado.ResumeLayout(false);
            this.gbxEditarNovoChamado.ResumeLayout(false);
            this.gbxEditarNovoChamado.PerformLayout();
            this.gbxEditarNovoEquipamento.ResumeLayout(false);
            this.gbxEditarNovoEquipamento.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.gbxEquipamento.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxChamado;
        private System.Windows.Forms.GroupBox gbxEditarNovoEquipamento;
        private System.Windows.Forms.TextBox txtNomeEquipamento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtDataEquipamento;
        private System.Windows.Forms.ListView lvEquipamento;
        private System.Windows.Forms.Button btnCancelarEquipamento;
        private System.Windows.Forms.Button btnSalvarEquipamento;
        private System.Windows.Forms.TextBox txtSerieEquipamento;
        private System.Windows.Forms.TextBox txtFabricanteEquipamento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnNovoEquipamento;
        private System.Windows.Forms.Button btnEditarEquipamento;
        private System.Windows.Forms.Button btnExcluirEquipamento;
        private System.Windows.Forms.GroupBox gbxEquipamento;
        private System.Windows.Forms.MaskedTextBox txtValorEquipamento;
        private System.Windows.Forms.Button btnNovoChamado;
        private System.Windows.Forms.GroupBox gbxListaChamado;
        private System.Windows.Forms.ListView lvChamado;
        private System.Windows.Forms.Button btnEditarChamado;
        private System.Windows.Forms.GroupBox gbxEditarNovoChamado;
        private System.Windows.Forms.Button btnCancelarChamado;
        private System.Windows.Forms.Button btnSalvarChamado;
        private System.Windows.Forms.TextBox txtDescricaoChamado;
        private System.Windows.Forms.TextBox txtTituloChamado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox txtDataChamado;
        private System.Windows.Forms.ComboBox cbxEquipamentoChamado;
        private System.Windows.Forms.DateTimePicker dtpEquipamento;
        private System.Windows.Forms.DateTimePicker dtpChamado;
    }
}