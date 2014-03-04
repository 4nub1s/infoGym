using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using infoGym.Classes.Negocio;
using infoGym.Classes;

namespace infoGym
{
    public partial class frmAvaliacao : Form
    {
        Avaliacao ava;
        Anamnese ana;
        Funcionario func;
        Aluno alu;
        Utils util;
        Perimetro per;
        Composicao comp;
        Neuromotor neuro;
        public frmAvaliacao(String avaId)
        {
            InitializeComponent();
            ava = new Avaliacao();
            func = new Funcionario();
            alu = new Aluno();
            ana = new Anamnese();
            per = new Perimetro();
            comp = new Composicao();
            neuro = new Neuromotor();
            util = new Utils();
            util.desabilitarCampos(tbAnamnese.Controls, false);
            ttbGeralSaude.Enabled = true;
            ttbAtividadeFisica.Enabled = true;
            ttbPartesModificar.Enabled = true;
            ttbObjetivoPraticaExe.Enabled = true;
            util.numericMaskFormata(tbPerimetros.Controls);
            util.numericMaskFormata(tbComposicao.Controls);
            util.numericMaskFormata(ttbNeuroWells);
            ava.Id = avaId;
            ava = ava.getById();
            func.Id = ava.FuncId;
            func.getDadosFunc();
            alu.Id = Convert.ToInt32(ava.AluId);
            alu = alu.getAlunoById();
            if (alu.Sexo == 'm')
            {
                lblProtocolo.Text = "Pollock - 3 dobras";
                ttbCompAxilarMedia.Enabled = false;
                ttbCompSubEscap.Enabled = false;
                ttbCompSupraIliaca.Enabled = false;
                ttbCompTricipital.Enabled = false;
            }
            else
            {
                lblProtocolo.Text = "Pollock - 7 dobras";
            }
            lblAvaliado.Text = alu.Nome;
            lblAvaliador.Text = func.Nome;
            lblIdade.Text = ""+util.getIdade(alu.DtNasc);
            lblCodigo.Text = ava.Id;
            if (!ava.jaRealizada())
            {
                ana.nova(ava.Id);
                per.nova(ava.Id);
                comp.nova(ava.Id, alu.Sexo);
                neuro.novo(ava.Id);
                ava = ava.getById();
            }
            setarCamposAna();
            setarCamposPer();
            setarCamposComp();
            setarCamposNeuro();
            lblData.Text = ava.DtRealizada;
            atualizaTermo();
        }

        private void atualizaTermo()
        {
            if (util.existeImgAssociada("anamnese", ana.AnaId))
                imgTermo.Image = imageList1.Images[1];
            else
                imgTermo.Image = imageList1.Images[0];
        }

        private void setarCamposNeuro()
        {
            neuro.Id = ava.NeuroId;
            neuro = neuro.getById();
            ttbNeuroWells.Text = neuro.Wells;
            try
            {
                numNeuroAbdominal.Value = Convert.ToDecimal(neuro.Abdominal);
            }
            catch { }
            try
            {
                numNeuroFlexao.Value = Convert.ToDecimal(neuro.Flexao);
            }
            catch { }
        }

        private void setarCamposComp()
        {
            comp.Id = ava.CompId;
            comp = comp.getById();
            ttbCompAbdominal.Text = comp.Abdominal;
            ttbCompAltura.Text = comp.Altura;
            ttbCompAxilarMedia.Text = comp.Axilar;
            ttbCompCoxa.Text = comp.Coxa;
            ttbCompPeitoral.Text = comp.Peitoral;
            ttbCompPeso.Text = comp.Peso;
            ttbCompSubEscap.Text = comp.Subescapular;
            ttbCompSupraIliaca.Text = comp.Supra;
            ttbCompTricipital.Text = comp.Tricipital;
            lblProtocolo.Text = comp.Protocolo;
            lblMassaGorda.Text = comp.MassaG;
            lblMassaMagra.Text = comp.MassaM;
            lblGorduraAtual.Text = comp.GorduraA;
            lblGorduraIdeal.Text = comp.GorduraI;
            lblIMCLegenda.Text = comp.ImcLegenda;
            util.ttbToNumeric(tbComposicao.Controls);
        }

        private void setarCamposPer()
        {
            per.Id = ava.PerId;
            per = per.getById();
            ttbPerAbdome.Text = per.Abdome;
            ttbPerAntD.Text = per.AntebracoD;
            ttbPerAntE.Text = per.AntebracoE;
            ttbPerBracoCD.Text = per.BracoContraD;
            ttbPerBracoCE.Text = per.BracoContraE;
            ttbPerBracoRD.Text = per.BracoRelaxD;
            ttbPerBracoRE.Text = per.BracoRelaxE;
            ttbPerCintura.Text = per.Cintura;
            ttbPerCoxaD.Text = per.CoxaD;
            ttbPerCoxaE.Text = per.CoxaE;
            ttbPerOmbro.Text = per.Ombro;
            ttbPerPantD.Text = per.PanturrilaD;
            ttbPerPantE.Text = per.PanturrilhaE;
            ttbPerPesc.Text = per.Pescoco;
            ttbPerQuadril.Text = per.Quadril;
            ttbPerToraxI.Text = per.ToraxInsp;
            ttbPerToraxR.Text = per.ToraxRelax;
            ttbPerRelacao.Text = per.Rcq;
            lblRelacao.Text = per.RcqLegenda;
            util.ttbToNumeric(tbPerimetros.Controls);
        }

        private void setarCamposAna()
        {
            ana.AnaId = ava.AnaId;
            ana = ana.getById();
            if (!ana.Alergia.Equals(""))
            {
                chkAlergia.Checked = true;
                if (ana.Alergia.Length > 1)
                    ttbAlergia.Text = ana.Alergia;
            }
            if (!ana.AtividadeFisica.Equals(""))
            {
                ttbAtividadeFisica.Text = ana.AtividadeFisica;
            }
            if (!ana.Bebida.Equals(""))
            {
                chkBebida.Checked = true;
            }
            if (!ana.Cirurgia.Equals(""))
            {
                chkCirurgia.Checked = true;
                if (ana.Cirurgia.Length > 1)
                    ttbCirurgia.Text = ana.Cirurgia;
            }
            if (!ana.Diabete_familia.Equals(""))
            {
                chkDiabeteFamilia.Checked = true;
                if (ana.Diabete_familia.Length > 1)
                    ttbDiabeteFamilia.Text = ana.Diabete_familia;
            }
            if (!ana.Diabetico.Equals(""))
            {
                chkDiabetico.Checked = true;
            }
            if (!ana.Dores.Equals(""))
            {
                chkDoresCorpo.Checked = true;
                if (ana.Dores.Length > 1)
                    ttbDoresCorpo.Text = ana.Dores;
            }
            if (!ana.Estado_geral.Equals(""))
            {
                ttbGeralSaude.Text = ana.Estado_geral;
            }
            if (!ana.Fumante.Equals(""))
            {
                chkCigarros.Checked = true;
                numCigarro.Value = Convert.ToInt32(ana.Fumante);
            }
            if (!ana.FumanteEx.Equals(""))
            {
                chkJaFumou.Checked = true;
                numCigarrosAnosSem.Value = Convert.ToInt32(ana.FumanteEx);
            }
            if (!ana.Gestante.Equals(""))
            {
                chkGestante.Checked = true;
            }
            if (!ana.Hipertenso.Equals(""))
            {
                chkHipertensao.Checked = true;
            }
            if (!ana.InfartoFamilia.Equals(""))
            {
                chkInfartoFamilia.Checked = true;
                if (ana.InfartoFamilia.Length > 1)
                    ttbInfartoFamilia.Text = ana.InfartoFamilia;
            }
            if (!ana.Medicamento.Equals(""))
            {
                chkUtilzaMedicamentos.Checked = true;
                if (ana.Medicamento.Length > 1)
                    ttbMedicamento.Text = ana.Medicamento;
            }
            if (!ana.Objetivo.Equals(""))
            {
                ttbObjetivoPraticaExe.Text = ana.Objetivo;
            }
            if (!ana.Osteoporose.Equals(""))
            {
                chkOsteoporose.Checked = true;
            }
            if (!ana.PartesCorpo.Equals(""))
            {
                ttbPartesModificar.Text = ana.PartesCorpo;
            }
            if (!ana.ProbCard.Equals(""))
            {
                chkCard.Checked = true;
                if (ana.ProbCard.Length > 1)
                    ttbCard.Text = ana.ProbCard;
            }
            if (!ana.ProbDesc.Equals(""))
            {
                chkDesconhecido.Checked = true;
                if (ana.ProbDesc.Length > 1)
                    ttbDesconhecido.Text = ana.ProbDesc;
            }
            if (!ana.ProbGastro.Equals(""))
            {
                chkGastro.Checked = true;
                if (ana.ProbGastro.Length > 1)
                    ttbGastro.Text = ana.ProbGastro;
            }
            if (!ana.ProbNeuro.Equals(""))
            {
                chkNeuro.Checked = true;
                if (ana.ProbNeuro.Length > 1)
                    ttbNeuro.Text = ana.ProbNeuro;
            }
            if (!ana.ProbOrto.Equals(""))
            {
                chkOrtopedicos.Checked = true;
                if (ana.ProbOrto.Length > 1)
                    ttbOrtopedicos.Text = ana.ProbOrto;
            }
            if (!ana.ProbResp.Equals(""))
            {
                chkRespiratorio.Checked = true;
                if (ana.ProbResp.Length > 1)
                    ttbRespiratorio.Text = ana.ProbResp;
            }
            if (!ana.Refeicoes.Equals(""))
            {
                numRef.Value = Convert.ToInt32(ana.Refeicoes);
            }
            if (!ana.Tontura.Equals(""))
            {
                chkTontura.Checked = true;
            }
            if (!ana.Vertigem.Equals(""))
            {
                chkVertigem.Checked = true;
            }
        }

        private void chkProblemasCard_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCard.Checked)
                ttbCard.Enabled = true;
            else
            {
                ttbCard.Enabled = false;
                ttbCard.Text = "";
            }
        }

        private void chkOrtopedicos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOrtopedicos.Checked)
                ttbOrtopedicos.Enabled = true;
            else
            {
                ttbOrtopedicos.Enabled = false;
                ttbOrtopedicos.Text = "";
            }
        }

        private void chkNeuro_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNeuro.Checked)
                ttbNeuro.Enabled = true;
            else
            {
                ttbNeuro.Enabled = false;
                ttbNeuro.Text = "";
            }
        }

        private void chkGastro_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGastro.Checked)
                ttbGastro.Enabled = true;
            else
            {
                ttbGastro.Enabled = false;
                ttbGastro.Text = "";
            }
        }

        private void chkRespiratorio_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRespiratorio.Checked)
                ttbRespiratorio.Enabled = true;
            else
            {
                ttbRespiratorio.Enabled = false;
                ttbRespiratorio.Text = "";
            }
        }

        private void chkDesconhecido_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDesconhecido.Checked)
                ttbDesconhecido.Enabled = true;
            else
            {
                ttbDesconhecido.Enabled = false;
                ttbDesconhecido.Text = "";
            }
        }

        private void chkCigarros_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCigarros.Checked)
                numCigarro.Enabled = true;
            else
                numCigarro.Enabled = false;
        }

        private void chkJaFumou_CheckedChanged(object sender, EventArgs e)
        {
            if (chkJaFumou.Checked)
                numCigarrosAnosSem.Enabled = true;
            else
                numCigarrosAnosSem.Enabled = false;
        }

        private void chkDiabeteFamilia_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDiabeteFamilia.Checked)
                ttbDiabeteFamilia.Enabled = true;
            else
            {
                ttbDiabeteFamilia.Text = "";
                ttbDiabeteFamilia.Enabled = false;
            }
        }

        private void chkAlergia_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAlergia.Checked)
                ttbAlergia.Enabled = true;
            else
            {
                ttbAlergia.Text = "";
                ttbAlergia.Enabled = false;
            }
        }

        private void chkInfartoFamilia_CheckedChanged(object sender, EventArgs e)
        {
            if (chkInfartoFamilia.Checked)
                ttbInfartoFamilia.Enabled = true;
            else
            {
                ttbInfartoFamilia.Text = "";
                ttbInfartoFamilia.Enabled = false;
            }
        }

        private void chkUtilzaMedicamentos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUtilzaMedicamentos.Checked)
                ttbMedicamento.Enabled = true;
            else
            {
                ttbMedicamento.Text = "";
                ttbMedicamento.Enabled = false;
            }
        }

        private void chkCirurgia_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCirurgia.Checked)
                ttbCirurgia.Enabled = true;
            else
            {
                ttbCirurgia.Text = "";
                ttbCirurgia.Enabled = false;
            }
        }

        private void chkDoresCorpo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDoresCorpo.Checked)
                ttbDoresCorpo.Enabled = true;
            else
            {
                ttbDoresCorpo.Text = "";
                ttbDoresCorpo.Enabled = false;
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (updateAnamnese())
            {
                if (updatePerimetro())
                {
                    if (updateComposicao())
                    {
                        if (updateNeuro())
                        {
                            MessageBox.Show("Alteração realizada com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                            MessageBox.Show("Ocorreram problemas ao realizar a alteração! (Neuromotores)", "Problemas!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                        MessageBox.Show("Ocorreram problemas ao realizar a alteração! (Composição)", "Problemas!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                    MessageBox.Show("Ocorreram problemas ao realizar a alteração! (Perímetros)", "Problemas!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                MessageBox.Show("Ocorreram problemas ao realizar a alteração! (Anamnese)", "Problemas!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private bool updateComposicao()
        {
            comp.Abdominal = ttbCompAbdominal.Text;
            comp.Altura = ttbCompAltura.Text;
            comp.Axilar = ttbCompAxilarMedia.Text;
            comp.Coxa = ttbCompCoxa.Text;
            if (lblGorduraAtual.Text == "---")
                comp.GorduraA = "";
            else
                comp.GorduraA = lblGorduraAtual.Text.Replace(",", ".");
            if (lblGorduraIdeal.Text == "---")
                comp.GorduraI = "";
            else
                comp.GorduraI = lblGorduraIdeal.Text.Replace(",", ".");
            if (lblIMC.Text == "---")
                comp.Imc = "";
            else
                comp.Imc = lblIMC.Text;
            comp.Imc = comp.Imc.Replace(",", ".");
            if (lblMassaGorda.Text == "---")
                comp.MassaG = "";
            else
                comp.MassaG = lblMassaGorda.Text.Replace(",", ".");
            if (lblMassaMagra.Text == "---")
                comp.MassaM = "";
            else
                comp.MassaM = lblMassaMagra.Text.Replace(",", ".");
            comp.Peitoral = ttbCompPeitoral.Text;
            comp.Peso = ttbCompPeso.Text;
            comp.Protocolo = lblProtocolo.Text;
            comp.Subescapular = ttbCompSubEscap.Text;
            comp.Supra = ttbCompSupraIliaca.Text;
            comp.Tricipital = ttbCompTricipital.Text;
            comp.ImcLegenda = lblIMCLegenda.Text;
            if (comp.update())
                return true;
            return false;
        }
        private bool updateNeuro()
        {
            neuro.Flexao = "" + numNeuroFlexao.Value;
            neuro.Abdominal = "" + numNeuroAbdominal.Value;
            neuro.Wells = ttbNeuroWells.Text;
            neuro.AbdominalLegenda = lblNeuroAbdominal.Text;
            neuro.FlexaoLegenda = lblNeuroFlexao.Text;
            neuro.WellsLegenda = lblNeuroWells.Text;
            if (neuro.atualiza())
                return true;
            return false;
        }

        private bool updatePerimetro()
        {
            per.Abdome = ttbPerAbdome.Text;
            per.AntebracoD = ttbPerAntD.Text;
            per.AntebracoE = ttbPerAntE.Text;
            per.BracoContraD = ttbPerBracoCD.Text;
            per.BracoContraE = ttbPerBracoCE.Text;
            per.BracoRelaxD = ttbPerBracoRD.Text;
            per.BracoRelaxE = ttbPerBracoRE.Text;
            per.Cintura = ttbPerCintura.Text;
            per.CoxaD = ttbPerCoxaD.Text;
            per.CoxaE = ttbPerCoxaE.Text;
            per.Ombro = ttbPerOmbro.Text;
            per.PanturrilaD = ttbPerPantD.Text;
            per.PanturrilhaE = ttbPerPantE.Text;
            per.Pescoco = ttbPerPesc.Text;
            per.Quadril = ttbPerQuadril.Text;
            per.ToraxInsp = ttbPerToraxI.Text;
            per.ToraxRelax = ttbPerToraxR.Text;
            per.Rcq = ttbPerRelacao.Text;
            per.Rcq = per.Rcq.Replace(",", ".");
            per.RcqLegenda = lblRelacao.Text;
            if (per.update())
                return true;
            return false;
        }

        private bool updateAnamnese()
        {
            if (chkAlergia.Checked && ttbAlergia.Text == "")
                ana.Alergia = "c";
            else
                ana.Alergia = ttbAlergia.Text;
            ana.AtividadeFisica = ttbAtividadeFisica.Text;
            if (chkBebida.Checked)
                ana.Bebida = "c";
            else
                ana.Bebida = "";
            if (chkCirurgia.Checked && ttbCirurgia.Text == "")
                ana.Cirurgia = "c";
            else
                ana.Cirurgia = ttbCirurgia.Text;
            if (chkDiabeteFamilia.Checked && ttbDiabeteFamilia.Text == "")
                ana.Diabete_familia = "c";
            else
                ana.Diabete_familia = ttbDiabeteFamilia.Text;
            if (chkDiabetico.Checked)
                ana.Diabetico = "c";
            else
                ana.Diabetico = "";
            if (chkDoresCorpo.Checked && ttbDoresCorpo.Text == "")
                ana.Dores = "c";
            else
                ana.Dores = ttbDoresCorpo.Text;
            ana.Estado_geral = ttbGeralSaude.Text;
            if (chkCigarros.Checked)
                ana.Fumante = "" + numCigarro.Value;
            else
                ana.Fumante = "";
            if (chkJaFumou.Checked)
                ana.FumanteEx = "" + numCigarrosAnosSem.Value;
            else
                ana.FumanteEx = "";
            if (chkGestante.Checked)
                ana.Gestante = "c";
            else
                ana.Gestante = "";
            if (chkHipertensao.Checked)
                ana.Hipertenso = "c";
            else
                ana.Hipertenso = "";
            if (chkInfartoFamilia.Checked && ttbInfartoFamilia.Text == "")
                ana.InfartoFamilia = "c";
            else
                ana.InfartoFamilia = ttbInfartoFamilia.Text;
            if (chkUtilzaMedicamentos.Checked && ttbMedicamento.Text == "")
                ana.Medicamento = "c";
            else
                ana.Medicamento = ttbMedicamento.Text;
            ana.Objetivo = ttbObjetivoPraticaExe.Text;
            if (chkOsteoporose.Checked)
                ana.Osteoporose = "c";
            else
                ana.Osteoporose = "";
            ana.PartesCorpo = ttbPartesModificar.Text;
            if (chkCard.Checked && ttbCard.Text == "")
                ana.ProbCard = "c";
            else
                ana.ProbCard = ttbCard.Text;
            if (chkDesconhecido.Checked && ttbDesconhecido.Text == "")
                ana.ProbDesc = "c";
            else
                ana.ProbDesc = ttbDesconhecido.Text;
            if (chkGastro.Checked && ttbGastro.Text == "")
                ana.ProbGastro = "c";
            else
                ana.ProbGastro = ttbGastro.Text;
            if (chkNeuro.Checked && ttbNeuro.Text == "")
                ana.ProbNeuro = "c";
            else
                ana.ProbNeuro = ttbNeuro.Text;
            if (chkOrtopedicos.Checked && ttbOrtopedicos.Text == "")
                ana.ProbOrto = "c";
            else
                ana.ProbOrto = ttbOrtopedicos.Text;
            if (chkRespiratorio.Checked && ttbRespiratorio.Text == "")
                ana.ProbResp = "c";
            else
                ana.ProbResp = ttbRespiratorio.Text;
            ana.Refeicoes = "" + numRef.Value;
            if (chkTontura.Checked)
                ana.Tontura = "c";
            else
                ana.Tontura = "";
            if (chkVertigem.Checked)
                ana.Vertigem = "c";
            else
                ana.Vertigem = "";
            if (ana.update())
                return true;
            return false;
        }

        private void btnTermo_Click(object sender, EventArgs e)
        {
            frmTermoAnamnese terAna = new frmTermoAnamnese(ana.AnaId);
            terAna.ShowDialog();
            atualizaTermo();
        }



        private void ttbPerQuadril_TextChanged(object sender, EventArgs e)
        {
            String[] result = per.RCQ(ttbPerCintura.Text, ttbPerQuadril.Text, alu.DtNasc, alu.Sexo);
            ttbPerRelacao.Text = result[0];
            lblRelacao.Text = result[1];
            if (lblRelacao.Text.Equals("risco baixo"))
                lblRelacao.ForeColor = Color.Blue;
            if (lblRelacao.Text.Equals("risco moderado"))
                lblRelacao.ForeColor = Color.BlueViolet;
            if (lblRelacao.Text.Equals("risco alto"))
                lblRelacao.ForeColor = Color.OrangeRed;
            if (lblRelacao.Text.Equals("risco muito alto"))
                lblRelacao.ForeColor = Color.Red;

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chama relatório!");
        }

        private void ttbCompPeso_TextChanged(object sender, EventArgs e)
        {
            String[] result = comp.IMC(ttbCompAltura.Text, ttbCompPeso.Text);
            lblIMC.Text = result[0];
            lblIMCLegenda.Text = result[1];
            if (lblIMCLegenda.Text.Equals("abaixo do peso") || lblIMCLegenda.Text.Equals("acima do peso")
                || lblIMCLegenda.Text.Equals("obeso"))
                lblIMCLegenda.ForeColor = Color.Red;
            else
                lblIMCLegenda.ForeColor = Color.Blue;
            ttbCompPeitoral_TextChanged(sender, e);
        }

        private void ttbCompPeitoral_TextChanged(object sender, EventArgs e)
        {
            String[] resultados = null;
            if(alu.Sexo == 'm')
                resultados = comp.getResultados(util.getIdade(alu.DtNasc), ttbCompPeso.Text, ttbCompPeitoral.Text,
                ttbCompAbdominal.Text, ttbCompCoxa.Text);
            else
                resultados = comp.getResultados(util.getIdade(alu.DtNasc), ttbCompPeso.Text, ttbCompPeitoral.Text,
                ttbCompAbdominal.Text, ttbCompCoxa.Text, ttbCompAxilarMedia.Text, ttbCompSubEscap.Text,
                ttbCompSupraIliaca.Text, ttbCompTricipital.Text);
            if (resultados[0] != "" && resultados[0] != null)
                lblGorduraAtual.Text = resultados[0];
            else
                lblGorduraAtual.Text = "---";
            if (resultados[1] != "" && resultados[1] != null)
                lblMassaGorda.Text = resultados[1];
            else
                lblMassaGorda.Text = "---";
            if (resultados[2] != "" && resultados[2] != null)
                lblMassaMagra.Text = resultados[2];
            else
                lblMassaMagra.Text = "---";
            if (resultados[3] != "" && resultados[3] != null)
                lblGorduraIdeal.Text = resultados[3];
            else
                lblGorduraIdeal.Text = "---";
        }

        private void numNeuroFlexao_ValueChanged(object sender, EventArgs e)
        {
            lblNeuroFlexao.Text = neuro.getFlexaoFaixa(numNeuroFlexao.Value, alu.Sexo);
            if (lblNeuroFlexao.Text == "Ruim" || lblNeuroFlexao.Text == "Abaixo da média")
                lblNeuroFlexao.ForeColor = Color.Red;
            if (lblNeuroFlexao.Text == "Média")
                lblNeuroFlexao.ForeColor = Color.Orange;
            if (lblNeuroFlexao.Text == "Acima da média" || lblNeuroFlexao.Text == "Excelente")
                lblNeuroFlexao.ForeColor = Color.Blue;

        }

        private void numNeuroAbdominal_ValueChanged(object sender, EventArgs e)
        {
            lblNeuroAbdominal.Text = neuro.getAbdominalFaixa(numNeuroAbdominal.Value, alu.Sexo);
            if (lblNeuroAbdominal.Text == "Ruim" || lblNeuroAbdominal.Text == "Abaixo da média")
                lblNeuroAbdominal.ForeColor = Color.Red;
            if (lblNeuroAbdominal.Text == "Média")
                lblNeuroAbdominal.ForeColor = Color.Orange;
            if (lblNeuroAbdominal.Text == "Acima da média" || lblNeuroAbdominal.Text == "Excelente")
                lblNeuroAbdominal.ForeColor = Color.Blue;
        }

        private void ttbNeuroWells_TextChanged(object sender, EventArgs e)
        {
            lblNeuroWells.Text = neuro.getWellsFaixa(ttbNeuroWells.Text, alu.Sexo);
            if (lblNeuroWells.Text == "Ruim" || lblNeuroWells.Text == "Abaixo da média")
                lblNeuroWells.ForeColor = Color.Red;
            if (lblNeuroWells.Text == "Média")
                lblNeuroWells.ForeColor = Color.Orange;
            if (lblNeuroWells.Text == "Acima da média" || lblNeuroWells.Text == "Excelente")
                lblNeuroWells.ForeColor = Color.Blue;
        }

    }
}
