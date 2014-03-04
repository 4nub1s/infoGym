using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using infoGym.frms;
using infoGym.Classes.Negocio;


namespace infoGym
{
    public partial class frmPrincipal : Form
    {
        private Usuario user;
        public frmPrincipal(Usuario user)
        {
            InitializeComponent();
            this.user = user;
            lblCon.Text = user.getUltimaCon();
            lblLogado.Text = user.Login;
        }

        private void termosResponsabilidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                new frmTermoControlar(user).ShowDialog();
            }
            catch
            {
                MessageBox.Show("Você não tem acesso a essa opção!", "Acesso não permitido!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }



        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                new frmRelFuncionario().ShowDialog();
            }
            catch
            {
                MessageBox.Show("Você não tem acesso a essa opção!", "Acesso não permitido!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void alunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                new frmRelatorioAluno().ShowDialog();
            }
            catch
            {
                MessageBox.Show("Você não tem acesso a essa opção!", "Acesso não permitido!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void relatóriosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void caixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void mToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                new frmRelModalidade().ShowDialog();
            }
            catch
            {
                MessageBox.Show("Você não tem acesso a essa opção!", "Acesso não permitido!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmRelFornecedores().ShowDialog();
        }

        private void avaliaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                new frmRelAvaliacoesFisicas().ShowDialog();
            }
            catch
            {
                MessageBox.Show("Você não tem acesso a essa opção!", "Acesso não permitido!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
         
        }

        private void desToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                new frmRelDespesas().ShowDialog();
            }
            catch
            {
                MessageBox.Show("Você não tem acesso a essa opção!", "Acesso não permitido!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void mensalidadesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                new frmRelMensalidades().ShowDialog();
            }
            catch
            {
                MessageBox.Show("Você não tem acesso a essa opção!", "Acesso não permitido!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                new frmAluGerenciamento(false, user).ShowDialog();
            }
            catch
            {
                MessageBox.Show("Você não tem acesso a essa opção!", "Acesso não permitido!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                user.deslogar();
            }
            else
                e.Cancel = true;
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                new frmAluGerenciamento(false, user).ShowDialog();
            }
            catch{
                MessageBox.Show("Você não tem acesso a essa opção!", "Acesso não permitido!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                new frmUserAlteraSenha(user).ShowDialog();
            }
            catch
            {
                MessageBox.Show("Você não tem acesso a essa opção!", "Acesso não permitido!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }



        private void funcionáriosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                new frmExeGerenciar().ShowDialog();
            }
            catch
            {
                MessageBox.Show("Você não tem acesso a essa opção!", "Acesso não permitido!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                new frmCaixaFechar().ShowDialog();
            }
            catch
            {
                MessageBox.Show("Você não tem acesso a essa opção!", "Acesso não permitido!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void informaçõesEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Empresa emp = new Empresa();
                emp = emp.getEmp();
                if (emp == null)
                    new frmEmpresa("Cadastro").ShowDialog();
                else
                    new frmEmpresa("Atualiza").ShowDialog();
            }
            catch
            {
                MessageBox.Show("Você não tem acesso a essa opção!", "Acesso não permitido!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void fornecedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                new frmFornGerenciar(false).ShowDialog();
            }
            catch
            {
                MessageBox.Show("Você não tem acesso a essa opção!", "Acesso não permitido!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void produtosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                new frmFuncGerenciamento(false).ShowDialog();
            }
            catch
            {
                MessageBox.Show("Você não tem acesso a essa opção!", "Acesso não permitido!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void exerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                new frmProdGerenciar(false).ShowDialog();
            }
            catch
            {
                MessageBox.Show("Você não tem acesso a essa opção!", "Acesso não permitido!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void modalidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                new frmUsuarioControlar(user).ShowDialog();
            }
            catch
            {
                MessageBox.Show("Você não tem acesso a essa opção!", "Acesso não permitido!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void gerenciamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            try
            {
                new frmModGerenciar(false).ShowDialog();
            }
            catch
            {
                MessageBox.Show("Você não tem acesso a essa opção!", "Acesso não permitido!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        private void menuAluCad_Click(object sender, EventArgs e)
        {
            try
            {
                new frmAluNovo("", user).ShowDialog();
            }
            catch
            {
                MessageBox.Show("Você não tem acesso a essa opção!", "Acesso não permitido!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void menuExeCad_Click(object sender, EventArgs e)
        {
            try
            {
                new frmExeNovo("").ShowDialog();
            }
            catch
            {
                MessageBox.Show("Você não tem acesso a essa opção!", "Acesso não permitido!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void menuFornCad_Click(object sender, EventArgs e)
        {
            try
            {
                new frmFornNovo("").ShowDialog();
            }
            catch
            {
                MessageBox.Show("Você não tem acesso a essa opção!", "Acesso não permitido!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void menuFuncCad_Click(object sender, EventArgs e)
        {
            try
            {
                new frmFuncNovo("").ShowDialog();
            }
            catch
            {
                MessageBox.Show("Você não tem acesso a essa opção!", "Acesso não permitido!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void menuModCad_Click(object sender, EventArgs e)
        {
            try
            {
                new frmModNova("").ShowDialog();
            }
            catch
            {
                MessageBox.Show("Você não tem acesso a essa opção!", "Acesso não permitido!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void menuProdCad_Click(object sender, EventArgs e)
        {
            try
            {
                new frmProdNovo("").ShowDialog();
            }
            catch
            {
                MessageBox.Show("Você não tem acesso a essa opção!", "Acesso não permitido!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void menuUserCad_Click(object sender, EventArgs e)
        {
            try
            {
                new frmUserCad().ShowDialog();
            }
            catch
            {
                MessageBox.Show("Você não tem acesso a essa opção!", "Acesso não permitido!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void abrirCaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Caixa cai = new Caixa();
                cai.CaiData = DateTime.Today.ToShortDateString();
                cai = cai.getCaixaByData();
                if (cai.UserAbriu == "") //se atual ainda não foi aberto
                {
                    if (cai.isAntFechado()) //verifica se anterior foi fechado
                    {
                        new frmCaixaNovo(user).ShowDialog();
                    }
                    else
                        MessageBox.Show("Caixa anterior deve ser fechado para que o atual possa ser aberto!",
                        "Você se esqueceu de fechar o caixa?", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                    MessageBox.Show("Caixa já está aberto!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch
            {
                MessageBox.Show("Você não tem acesso a essa opção!", "Acesso não permitido!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void controlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                new frmCaixaControlar(user, false).ShowDialog();   
            }
            catch
            {
                MessageBox.Show("Você não tem acesso a essa opção!", "Acesso não permitido!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void fecharToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                Caixa cai = new Caixa();
                cai.CaiData = DateTime.Today.ToShortDateString();
                cai = cai.getCaixaByData();
                cai.CaiData = DateTime.Today.ToShortDateString();
                if(cai.CaiAbert != "")
                    if(!cai.isFechado())
                        new frmCaixaControlar(user, true).ShowDialog();
                    else
                        MessageBox.Show("Caixa já foi fechado!", "Fechar de novo?", 
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                    MessageBox.Show("Caixa ainda não foi aberto!", "Fechar sem abrir?",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch
            {
                MessageBox.Show("Você não tem acesso a essa opção!", "Acesso não permitido!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                new frmTermoNovo(user, "").ShowDialog();
            }
            catch
            {
                MessageBox.Show("Você não tem acesso a essa opção!", "Acesso não permitido!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void controlarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                new frmTermoControlar(user).ShowDialog();
            }
            catch
            {
                MessageBox.Show("Você não tem acesso a essa opção!", "Acesso não permitido!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void novoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                new frmVendaNova(user, "").ShowDialog();
            }
            catch
            {
                MessageBox.Show("Você não tem acesso a essa opção!", "Acesso não permitido!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void controlarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                new frmVendaControlar(user, "").ShowDialog();
            }
            catch
            {
                MessageBox.Show("Você não tem acesso a essa opção!", "Acesso não permitido!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            novoToolStripMenuItem1_Click(sender, e);
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            try
            {
                new frmMatriculaNova(user, "", "").ShowDialog();
            }
            catch
            {
                MessageBox.Show("Você não tem acesso a essa opção!", "Acesso não permitido!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void matrículasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                new frmMatriculaControlar(user).ShowDialog();
            }
            catch
            {
                MessageBox.Show("Você não tem acesso a essa opção!", "Acesso não permitido!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        private void despesasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                new frmDespesaControlar(user).ShowDialog();
            }
            catch
            {
                MessageBox.Show("Você não tem acesso a essa opção!", "Acesso não permitido!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void agendarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                new frmAvControlar(user).ShowDialog();
            }
            catch
            {
                MessageBox.Show("Você não tem acesso a essa opção!", "Acesso não permitido!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void backupToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                new frmBackupGerenciar(user).ShowDialog();
            }
            catch
            {
                MessageBox.Show("Você não tem acesso a essa opção!", "Acesso não permitido!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void fichasDeTreinoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                new frmFichaControlar(user).ShowDialog();
            }
            catch
            {
                MessageBox.Show("Você não tem acesso a essa opção!", "Acesso não permitido!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }







    }
}
