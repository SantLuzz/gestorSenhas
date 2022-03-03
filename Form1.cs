using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace geradorSenhas
{
    public partial class Form1 : Form
    {
        int tamanho = 0;

        string senha = "";
        string finalPass = string.Empty;
        int maxAsc = 122;
        int minAsc = 48;
        string exePath = System.Environment.CurrentDirectory;

        List<string> senhas = new List<string>();
        List<string> senhaSalva = new List<string>();
        List<string> senhaBackup = new List<string>();

        public Form1()
        {
            InitializeComponent();
            lb_senhas.DataSource = senhas;
        }

        private void attLb(ListBox lb, List<string> list)
        {
            lb.DataSource = null;
            lb.DataSource = list;
        }

        private void btn_gerarSenha_Click(object sender, EventArgs e)
        {
            
            if(tb_tamanho.Text == "")
            {
                MessageBox.Show("O Campo Tamanho  não pode ser vazio!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                tamanho = int.Parse(tb_tamanho.Text);
            }

            if(cb_lower.Checked == true && cb_upper.Checked == true)
            {
                MessageBox.Show("A senha só pode ser Maiuscula ou minuscula", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            finalPass = gerarSenha(minAsc, maxAsc);
            

            if(cb_lower.Checked == true)
            {
                senhas.Add(finalPass.ToLower());
                attLb(lb_senhas, senhas);

            }else if(cb_upper.Checked == true){
                senhas.Add(finalPass.ToUpper());
                attLb(lb_senhas, senhas);

            }else if(cb_caracter.Checked == true)
            {
                senhas.Add(gerarSenhaComplexa(minAsc, maxAsc));
                attLb(lb_senhas, senhas);
            }
            else
            {
                senhas.Add(finalPass);
                attLb(lb_senhas, senhas);
            }
            
        }

        private void cb_caracter_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_caracter.Checked)
            {
                cb_lower.Checked = false;
                cb_upper.Checked = false;
                minAsc = 33;
                maxAsc = 126;
                //MessageBox.Show(minAsc + "," + maxAsc);
            }
        }

        private void cb_upper_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_upper.Checked)
            {
                cb_lower.Checked = false;
                cb_caracter.Checked = false;
            }
        }

        private void cb_lower_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_lower.Checked)
            {
                cb_upper.Checked = false;
                cb_caracter.Checked = false;
            }
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            lb_info2.Visible = true;
            lb_info2.Text = "Senhas simples são compostas de Letras (Maiúsculas ou Minusculas) e Números!";
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            lb_info2.Visible = true;
            lb_info2.Text = "Informe o tamanho da senha e a quantidade de combinações que você deseja gerar";
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            lb_info2.Visible = true;
            lb_info2.Text = "Senhas Complexas são formadas por Letras maiúsculas, minúsculas, números e caracteres especiais!";
        }

        private void splitContainer1_Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            lb_info2.Visible = true;
            lb_info2.Text = "Quanto maior for a senha mais pode demorar para gerar, seja paciente!";
        }

        private void tb_tamanho_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }



        private string gerarSenha(int min, int max)
        {
            senha = string.Empty;

            for (int i = 0; i < tamanho; i++)
            {
                Random rand = new Random();
                int cod = Convert.ToInt32(rand.Next(min, max).ToString());

                //definir qual o filtro dos valores, letras e numeros (padrão), caracter especial (marcado no combo box)
                if ((cod >= 48 && cod <= 57) || (cod >= 97 && cod <= 122))
                {
                    string asc = ((char)cod).ToString();
                    if (!senha.Contains(asc))
                    {
                        senha += asc;
                    }
                    else
                    {
                        i--;
                    }
                }
                else
                {
                    i--;
                }
            }


            return senha;
        }


        private string gerarSenhaComplexa(int min, int max)
        {
            senha = string.Empty;
            for (int i = 0; i < tamanho; i++)
            {
                Random rand = new Random();
                int cod = Convert.ToInt32(rand.Next(min, max).ToString());

                if (cod >= min && cod <= max)
                {
                    string asc = ((char)cod).ToString();
                    if (!senha.Contains(asc))
                    {
                        senha += asc;
                    }
                    else
                    {
                        i--;
                    }
                }
                else
                {
                    i--;
                }
            }
            return senha;
        }

        //Rotinas para salvar a senha geradas
        private void btn_save_Click(object sender, EventArgs e)
        {
                if (lb_senhas.Text != "")
                {
                    senhaSalva.Add(senhas[lb_senhas.SelectedIndex]);
                    attLb(lb_senhaSalva, senhaSalva);
                }
                else
                {
                    MessageBox.Show("Selecione a senha que deseja salvar!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
        

        }


        private void btn_saveFile_Click(object sender, EventArgs e)
        {
            if(lb_senhaSalva.Text != "")
            {
                string versao = senhas.ElementAt(0);
                try
                {
                    
                    if (System.IO.File.Exists(exePath + @"\\password.lfs"))
                    {

                        using (var file = new StreamWriter(exePath + @"\\pass-"+versao+".lfs"))
                        {
                            foreach (var fileWriter in senhaSalva)
                            {
                                file.WriteLine(fileWriter);
                            }
                        }
                    }
                    else
                    {
                        using (var file = new StreamWriter(exePath + @"\\password.lfs"))
                        {
                            foreach (var fileWriter in senhaSalva)
                            {
                                file.WriteLine(fileWriter);
                            }
                        }
                    }
                    MessageBox.Show("Arquivo de Backup gerado com sucesso!");
                    senhaSalva.Clear();
                    attLb(lb_senhaSalva, senhaSalva);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
           

        }

        private void btn_openFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (lb_senhaSalva.Items.Count > 0)
                {
                    if(MessageBox.Show("É altamente recomendado que salve as senhas geradas primeiro! Deseja Salvar os arquivos?","Aviso",MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        try
                        {
                            if(lb_senhaSalva.Text != "")
                            {
                                string versao = senhas.ElementAt(0);
                                if (System.IO.File.Exists(exePath + @"\\password.lfs"))
                                {

                                    using (var file = new StreamWriter(exePath + @"\\pass" + versao + ".lfs"))
                                    {
                                        foreach (var fileWriter in senhaSalva)
                                        {
                                            file.WriteLine(fileWriter);
                                        }
                                    }
                                    MessageBox.Show("Arquivo de Backup gerado com sucesso!");
                                    senhaSalva.Clear();
                                    attLb(lb_senhaSalva, senhaSalva);
                                    return;
                                }
                            }
  
                        }
                        catch (Exception ex)
                        {
                            throw ex;
                        }
                    }
                    else
                    {
                        senhaSalva.Clear();
                        attLb(lb_senhaSalva, senhaSalva);

                    }

                }


                this.openFileDialog1.Title = "Abrir Senhas";
                this.openFileDialog1.InitialDirectory = exePath;
                this.openFileDialog1.Filter = "(*.lfs)|*.lfs";
                senhaBackup.Clear();
                attLb(lb_senhaSalva, senhaBackup);

                DialogResult dr = this.openFileDialog1.ShowDialog();
                

                if(dr == System.Windows.Forms.DialogResult.OK)
                {

                    FileStream arq = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                    StreamReader sr = new StreamReader(arq);
                    sr.BaseStream.Seek(0, SeekOrigin.Begin);

                    string linha = sr.ReadLine();

                    while(linha != null)
                    {
                        senhaBackup.Add(linha);
                        lb_senhaSalva.Text = senhaBackup.ToString();
                        linha = sr.ReadLine();
                    }
                    attLb(lb_senhaSalva, senhaBackup);
                }
            }catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
