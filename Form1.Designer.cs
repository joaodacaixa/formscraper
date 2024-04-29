namespace formscraper
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Botao_Consulta = new Button();
            label1 = new Label();
            caixadetexto4 = new RichTextBox();
            caixadetexto5 = new RichTextBox();
            tabelao = new DataGridView();
            item = new DataGridViewTextBoxColumn();
            meta = new DataGridViewTextBoxColumn();
            pesoefetivo = new DataGridViewTextBoxColumn();
            realizado = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)tabelao).BeginInit();
            SuspendLayout();
            // 
            // Botao_Consulta
            // 
            Botao_Consulta.Location = new Point(27, 12);
            Botao_Consulta.Name = "Botao_Consulta";
            Botao_Consulta.Size = new Size(75, 23);
            Botao_Consulta.TabIndex = 0;
            Botao_Consulta.Text = "Consulta";
            Botao_Consulta.UseVisualStyleBackColor = true;
            Botao_Consulta.Click += Botao_Consulta_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 95);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 3;
            // 
            // caixadetexto4
            // 
            caixadetexto4.Location = new Point(182, 95);
            caixadetexto4.Name = "caixadetexto4";
            caixadetexto4.Size = new Size(221, 69);
            caixadetexto4.TabIndex = 7;
            caixadetexto4.Text = "";
            caixadetexto4.Visible = false;
            caixadetexto4.TextChanged += caixadetexto4_TextChanged;
            // 
            // caixadetexto5
            // 
            caixadetexto5.Location = new Point(409, 95);
            caixadetexto5.Name = "caixadetexto5";
            caixadetexto5.Size = new Size(221, 69);
            caixadetexto5.TabIndex = 8;
            caixadetexto5.Text = "";
            caixadetexto5.Visible = false;
            // 
            // tabelao
            // 
            tabelao.AllowUserToDeleteRows = false;
            tabelao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabelao.Columns.AddRange(new DataGridViewColumn[] { item, meta, pesoefetivo, realizado });
            tabelao.Location = new Point(108, 52);
            tabelao.Name = "tabelao";
            tabelao.ReadOnly = true;
            tabelao.RowTemplate.Height = 25;
            tabelao.Size = new Size(593, 484);
            tabelao.TabIndex = 10;
            // 
            // item
            // 
            item.HeaderText = "item";
            item.Name = "item";
            item.ReadOnly = true;
            item.Width = 300;
            // 
            // meta
            // 
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            meta.DefaultCellStyle = dataGridViewCellStyle1;
            meta.HeaderText = "meta";
            meta.Name = "meta";
            meta.ReadOnly = true;
            // 
            // pesoefetivo
            // 
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            pesoefetivo.DefaultCellStyle = dataGridViewCellStyle2;
            pesoefetivo.HeaderText = "pesoefetivo";
            pesoefetivo.Name = "pesoefetivo";
            pesoefetivo.ReadOnly = true;
            pesoefetivo.Width = 50;
            // 
            // realizado
            // 
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            realizado.DefaultCellStyle = dataGridViewCellStyle3;
            realizado.HeaderText = "realizado";
            realizado.Name = "realizado";
            realizado.ReadOnly = true;
            // 
            // Form1
            // 
            AccessibleName = "";
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 625);
            Controls.Add(tabelao);
            Controls.Add(caixadetexto5);
            Controls.Add(caixadetexto4);
            Controls.Add(label1);
            Controls.Add(Botao_Consulta);
            Name = "Form1";
            Text = "asdasdasdasd";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)tabelao).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Botao_Consulta;
        private Label label1;
        private RichTextBox caixadetexto4;
        private RichTextBox caixadetexto5;
        private DataGridView tabelao;
        private DataGridViewTextBoxColumn item;
        private DataGridViewTextBoxColumn meta;
        private DataGridViewTextBoxColumn pesoefetivo;
        private DataGridViewTextBoxColumn realizado;
    }
}