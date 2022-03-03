namespace geradorSenhas
{
    partial class Form1
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cb_caracter = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cb_upper = new System.Windows.Forms.CheckBox();
            this.cb_lower = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_tamanho = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_gerarSenha = new System.Windows.Forms.Button();
            this.btn_openFile = new System.Windows.Forms.Button();
            this.btn_saveFile = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.lb_info2 = new System.Windows.Forms.Label();
            this.lb_senhas = new System.Windows.Forms.ListBox();
            this.lb_senhaSalva = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Aquamarine;
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.panel3);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Controls.Add(this.btn_gerarSenha);
            this.splitContainer1.Panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.splitContainer1_Panel1_MouseMove);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lb_senhaSalva);
            this.splitContainer1.Panel2.Controls.Add(this.btn_openFile);
            this.splitContainer1.Panel2.Controls.Add(this.btn_saveFile);
            this.splitContainer1.Panel2.Controls.Add(this.btn_save);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.panel4);
            this.splitContainer1.Panel2.Controls.Add(this.lb_senhas);
            this.splitContainer1.Size = new System.Drawing.Size(731, 565);
            this.splitContainer1.SplitterDistance = 222;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(15, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Senha Complexas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(15, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Senha Simples";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.cb_caracter);
            this.panel3.Location = new System.Drawing.Point(11, 370);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 74);
            this.panel3.TabIndex = 21;
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            // 
            // cb_caracter
            // 
            this.cb_caracter.AutoSize = true;
            this.cb_caracter.Checked = true;
            this.cb_caracter.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_caracter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_caracter.Location = new System.Drawing.Point(12, 24);
            this.cb_caracter.Name = "cb_caracter";
            this.cb_caracter.Size = new System.Drawing.Size(145, 17);
            this.cb_caracter.TabIndex = 10;
            this.cb_caracter.Text = "Caracteres Especiais";
            this.cb_caracter.UseVisualStyleBackColor = true;
            this.cb_caracter.CheckedChanged += new System.EventHandler(this.cb_caracter_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(15, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Definição";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cb_upper);
            this.panel2.Controls.Add(this.cb_lower);
            this.panel2.Location = new System.Drawing.Point(11, 238);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 105);
            this.panel2.TabIndex = 19;
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // cb_upper
            // 
            this.cb_upper.AutoSize = true;
            this.cb_upper.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_upper.Location = new System.Drawing.Point(12, 19);
            this.cb_upper.Name = "cb_upper";
            this.cb_upper.Size = new System.Drawing.Size(136, 17);
            this.cb_upper.TabIndex = 8;
            this.cb_upper.Text = "Somente Maiúsculo";
            this.cb_upper.UseVisualStyleBackColor = true;
            this.cb_upper.CheckedChanged += new System.EventHandler(this.cb_upper_CheckedChanged);
            // 
            // cb_lower
            // 
            this.cb_lower.AutoSize = true;
            this.cb_lower.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_lower.Location = new System.Drawing.Point(12, 53);
            this.cb_lower.Name = "cb_lower";
            this.cb_lower.Size = new System.Drawing.Size(136, 17);
            this.cb_lower.TabIndex = 9;
            this.cb_lower.Text = "Somente Minúsculo";
            this.cb_lower.UseVisualStyleBackColor = true;
            this.cb_lower.CheckedChanged += new System.EventHandler(this.cb_lower_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tb_tamanho);
            this.panel1.Location = new System.Drawing.Point(11, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 87);
            this.panel1.TabIndex = 14;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tamanho da Senha:";
            // 
            // tb_tamanho
            // 
            this.tb_tamanho.Location = new System.Drawing.Point(12, 42);
            this.tb_tamanho.Name = "tb_tamanho";
            this.tb_tamanho.Size = new System.Drawing.Size(176, 20);
            this.tb_tamanho.TabIndex = 14;
            this.tb_tamanho.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_tamanho_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::geradorSenhas.Properties.Resources.modelo_novo;
            this.pictureBox1.Location = new System.Drawing.Point(22, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btn_gerarSenha
            // 
            this.btn_gerarSenha.BackColor = System.Drawing.Color.Blue;
            this.btn_gerarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gerarSenha.ForeColor = System.Drawing.Color.White;
            this.btn_gerarSenha.Location = new System.Drawing.Point(43, 482);
            this.btn_gerarSenha.Name = "btn_gerarSenha";
            this.btn_gerarSenha.Size = new System.Drawing.Size(126, 37);
            this.btn_gerarSenha.TabIndex = 5;
            this.btn_gerarSenha.Text = "Gerar Senha";
            this.btn_gerarSenha.UseVisualStyleBackColor = false;
            this.btn_gerarSenha.Click += new System.EventHandler(this.btn_gerarSenha_Click);
            // 
            // btn_openFile
            // 
            this.btn_openFile.BackColor = System.Drawing.Color.Blue;
            this.btn_openFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_openFile.ForeColor = System.Drawing.Color.White;
            this.btn_openFile.Location = new System.Drawing.Point(106, 420);
            this.btn_openFile.Name = "btn_openFile";
            this.btn_openFile.Size = new System.Drawing.Size(126, 37);
            this.btn_openFile.TabIndex = 29;
            this.btn_openFile.Text = "Abrir Arquivo";
            this.btn_openFile.UseVisualStyleBackColor = false;
            this.btn_openFile.Click += new System.EventHandler(this.btn_openFile_Click);
            // 
            // btn_saveFile
            // 
            this.btn_saveFile.BackColor = System.Drawing.Color.Blue;
            this.btn_saveFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saveFile.ForeColor = System.Drawing.Color.White;
            this.btn_saveFile.Location = new System.Drawing.Point(254, 420);
            this.btn_saveFile.Name = "btn_saveFile";
            this.btn_saveFile.Size = new System.Drawing.Size(126, 37);
            this.btn_saveFile.TabIndex = 28;
            this.btn_saveFile.Text = "Gerar Arquivo";
            this.btn_saveFile.UseVisualStyleBackColor = false;
            this.btn_saveFile.Click += new System.EventHandler(this.btn_saveFile_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Blue;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(179, 218);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(126, 37);
            this.btn_save.TabIndex = 24;
            this.btn_save.Text = "Salvar a Senha";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(21, 495);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Informações";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(12, 495);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 23;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.lb_info2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 502);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(508, 63);
            this.panel4.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(185, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Luiz Felipe - 2022";
            // 
            // lb_info2
            // 
            this.lb_info2.AutoSize = true;
            this.lb_info2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_info2.Location = new System.Drawing.Point(2, 13);
            this.lb_info2.Name = "lb_info2";
            this.lb_info2.Size = new System.Drawing.Size(16, 13);
            this.lb_info2.TabIndex = 11;
            this.lb_info2.Text = "---";
            this.lb_info2.Visible = false;
            // 
            // lb_senhas
            // 
            this.lb_senhas.FormattingEnabled = true;
            this.lb_senhas.Location = new System.Drawing.Point(15, 50);
            this.lb_senhas.Name = "lb_senhas";
            this.lb_senhas.Size = new System.Drawing.Size(472, 160);
            this.lb_senhas.TabIndex = 12;
            // 
            // lb_senhaSalva
            // 
            this.lb_senhaSalva.FormattingEnabled = true;
            this.lb_senhaSalva.Location = new System.Drawing.Point(15, 272);
            this.lb_senhaSalva.Name = "lb_senhaSalva";
            this.lb_senhaSalva.Size = new System.Drawing.Size(472, 121);
            this.lb_senhaSalva.TabIndex = 30;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(731, 565);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerador de Senhas";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btn_gerarSenha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox cb_caracter;
        private System.Windows.Forms.ListBox lb_senhas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_tamanho;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox cb_upper;
        private System.Windows.Forms.CheckBox cb_lower;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lb_info2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_openFile;
        private System.Windows.Forms.Button btn_saveFile;
        private System.Windows.Forms.ListBox lb_senhaSalva;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

