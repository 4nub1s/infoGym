using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using infoGym.Classes.Negocio;

namespace infoGym
{
    public partial class frmFichaNova : Form
    {
        Usuario user;
        Aluno aluno;
        Ficha ficha;
        bool isCadastrado;
        public frmFichaNova(Usuario user)
        {
            InitializeComponent();
            isCadastrado = false;
            this.user = user;
            this.aluno = new Aluno();
            cbbObj.SelectedIndex = 0;
        }

        private void btnTreiAdd_Click(object sender, EventArgs e)
        {
            //add letra na grid
        }

        private void btnTreiAtualizar_Click(object sender, EventArgs e)
        {
            new frmFichaItemTreino("").ShowDialog();
        }

        private void btnAluBuscar_Click(object sender, EventArgs e)
        {
            frmAluGerenciamento frmAlu = new frmAluGerenciamento(true, user);
            frmAlu.ShowDialog();
            if (frmAlu.getPesquisaRealizada())
            {
                aluno.Id = frmAlu.getAluId();
                aluno = aluno.getAlunoById();
                ttbAluno.Text = aluno.Nome;
            }
            else
            {
                aluno.Id = 0;
                ttbAluno.Text = "";
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (ttbAluno.Text == "")
                ttbAluno.BackColor = Color.Red;
            else
            {
                ttbAluno.BackColor = Color.White;
                ficha = new Ficha();
                ficha.DtIni = dtpIni.Value.ToString();
                ficha.DtIni = dtpFim.Value.ToString();
                ficha.Finalidade = cbbObj.Text;
                ficha.Status = "true";


                isCadastrado = true;
            }
        }

        private void tbTreinos_Click(object sender, EventArgs e)
        {
            
        }

        private void tbTreinos_Enter(object sender, EventArgs e)
        {
       
        }
    }
}
