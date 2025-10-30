namespace GestEmpresa_Afonso
{
    partial class frmEmpregados
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cb_Cargo = new ComboBox();
            tb_Nome = new TextBox();
            tb_Telefone = new TextBox();
            label4 = new Label();
            checkBox1 = new CheckBox();
            tb_Email = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            label6 = new Label();
            gp_Morada = new GroupBox();
            pl_Projeto = new Panel();
            tb_Rua = new TextBox();
            tb_CodPostal = new TextBox();
            tb_Localidade = new TextBox();
            tb_Projeto = new TextBox();
            label7 = new Label();
            tb_ID = new TextBox();
            bt_Cancelar = new Button();
            bt_ok = new Button();
            gp_Morada.SuspendLayout();
            pl_Projeto.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(15, 12);
            label1.Name = "label1";
            label1.Size = new Size(75, 23);
            label1.TabIndex = 0;
            label1.Text = "Cargo";
            // 
            // label2
            // 
            label2.Location = new Point(14, 46);
            label2.Name = "label2";
            label2.Size = new Size(75, 23);
            label2.TabIndex = 0;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.Location = new Point(15, 83);
            label3.Name = "label3";
            label3.Size = new Size(75, 23);
            label3.TabIndex = 0;
            label3.Text = "Email";
            // 
            // cb_Cargo
            // 
            cb_Cargo.FormattingEnabled = true;
            cb_Cargo.Location = new Point(96, 12);
            cb_Cargo.Name = "cb_Cargo";
            cb_Cargo.Size = new Size(172, 23);
            cb_Cargo.TabIndex = 1;
            // 
            // tb_Nome
            // 
            tb_Nome.Location = new Point(95, 46);
            tb_Nome.Name = "tb_Nome";
            tb_Nome.Size = new Size(343, 23);
            tb_Nome.TabIndex = 2;
            // 
            // tb_Telefone
            // 
            tb_Telefone.Location = new Point(391, 80);
            tb_Telefone.Name = "tb_Telefone";
            tb_Telefone.Size = new Size(159, 23);
            tb_Telefone.TabIndex = 2;
            // 
            // label4
            // 
            label4.Location = new Point(363, 12);
            label4.Name = "label4";
            label4.Size = new Size(75, 23);
            label4.TabIndex = 0;
            label4.Text = "ID";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(494, 13);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(56, 19);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Editar";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // tb_Email
            // 
            tb_Email.Location = new Point(96, 80);
            tb_Email.Name = "tb_Email";
            tb_Email.Size = new Size(172, 23);
            tb_Email.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(391, 109);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(159, 23);
            dateTimePicker1.TabIndex = 4;
            // 
            // label5
            // 
            label5.Location = new Point(291, 80);
            label5.Name = "label5";
            label5.Size = new Size(75, 23);
            label5.TabIndex = 0;
            label5.Text = "Telefone";
            // 
            // label6
            // 
            label6.Location = new Point(291, 109);
            label6.Name = "label6";
            label6.Size = new Size(127, 23);
            label6.TabIndex = 0;
            label6.Text = "Data Nascimento";
            // 
            // gp_Morada
            // 
            gp_Morada.Controls.Add(tb_Localidade);
            gp_Morada.Controls.Add(tb_CodPostal);
            gp_Morada.Controls.Add(tb_Rua);
            gp_Morada.Location = new Point(15, 167);
            gp_Morada.Name = "gp_Morada";
            gp_Morada.Size = new Size(545, 124);
            gp_Morada.TabIndex = 5;
            gp_Morada.TabStop = false;
            gp_Morada.Text = "Morda";
            // 
            // pl_Projeto
            // 
            pl_Projeto.Controls.Add(tb_Projeto);
            pl_Projeto.Controls.Add(label7);
            pl_Projeto.Location = new Point(14, 311);
            pl_Projeto.Name = "pl_Projeto";
            pl_Projeto.Size = new Size(546, 59);
            pl_Projeto.TabIndex = 6;
            // 
            // tb_Rua
            // 
            tb_Rua.Location = new Point(17, 22);
            tb_Rua.Name = "tb_Rua";
            tb_Rua.Size = new Size(518, 23);
            tb_Rua.TabIndex = 0;
            // 
            // tb_CodPostal
            // 
            tb_CodPostal.Location = new Point(17, 64);
            tb_CodPostal.Name = "tb_CodPostal";
            tb_CodPostal.Size = new Size(140, 23);
            tb_CodPostal.TabIndex = 0;
            // 
            // tb_Localidade
            // 
            tb_Localidade.Location = new Point(188, 64);
            tb_Localidade.Name = "tb_Localidade";
            tb_Localidade.Size = new Size(347, 23);
            tb_Localidade.TabIndex = 0;
            // 
            // tb_Projeto
            // 
            tb_Projeto.Location = new Point(82, 18);
            tb_Projeto.Name = "tb_Projeto";
            tb_Projeto.Size = new Size(454, 23);
            tb_Projeto.TabIndex = 0;
            // 
            // label7
            // 
            label7.Location = new Point(18, 18);
            label7.Name = "label7";
            label7.Size = new Size(57, 23);
            label7.TabIndex = 0;
            label7.Text = "Projeto";
            // 
            // tb_ID
            // 
            tb_ID.Location = new Point(391, 9);
            tb_ID.Name = "tb_ID";
            tb_ID.Size = new Size(76, 23);
            tb_ID.TabIndex = 2;
            // 
            // bt_Cancelar
            // 
            bt_Cancelar.Location = new Point(382, 384);
            bt_Cancelar.Name = "bt_Cancelar";
            bt_Cancelar.Size = new Size(85, 24);
            bt_Cancelar.TabIndex = 7;
            bt_Cancelar.Text = "&Cancelar";
            bt_Cancelar.UseVisualStyleBackColor = true;
            // 
            // bt_ok
            // 
            bt_ok.Location = new Point(475, 384);
            bt_ok.Name = "bt_ok";
            bt_ok.Size = new Size(85, 24);
            bt_ok.TabIndex = 7;
            bt_ok.Text = "&Ok";
            bt_ok.UseVisualStyleBackColor = true;
            // 
            // frmEmpregados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(593, 420);
            Controls.Add(bt_ok);
            Controls.Add(bt_Cancelar);
            Controls.Add(pl_Projeto);
            Controls.Add(gp_Morada);
            Controls.Add(dateTimePicker1);
            Controls.Add(checkBox1);
            Controls.Add(tb_Email);
            Controls.Add(tb_Telefone);
            Controls.Add(tb_ID);
            Controls.Add(tb_Nome);
            Controls.Add(cb_Cargo);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmEmpregados";
            Text = "frmEmpregados";
            gp_Morada.ResumeLayout(false);
            gp_Morada.PerformLayout();
            pl_Projeto.ResumeLayout(false);
            pl_Projeto.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cb_Cargo;
        private TextBox tb_Nome;
        private TextBox tb_Telefone;
        private Label label4;
        private CheckBox checkBox1;
        private TextBox tb_Email;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private Label label6;
        private GroupBox gp_Morada;
        private Panel pl_Projeto;
        private TextBox tb_Localidade;
        private TextBox tb_CodPostal;
        private TextBox tb_Rua;
        private TextBox tb_Projeto;
        private Label label7;
        private TextBox tb_ID;
        private Button bt_Cancelar;
        private Button bt_ok;
    }
}