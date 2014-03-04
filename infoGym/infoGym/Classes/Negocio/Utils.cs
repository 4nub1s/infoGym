using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Drawing;
using infoGym.Classes.Negocio;
using System.Windows.Forms;
using System.IO;

/*
 * Classe criada por: João Carlos Fachini
 * utilizada pela primeira vez em seu estágio
 * no curso de Ciência da Computação
 * da FIPP UNOESTE.
 * Possui vários métodos que buscam facilitar a
 * realização de formatações utilizadas
 * em sistemas comerciais
 * */
namespace infoGym
{
    class Utils
    {
        Banco bco = new Banco();
        DataTable dt = null;
        String sql = "";

        /*
         *-----------------------------------------------------INICIO Tratamento campos obrigatórios-----------------------------------------------------------------------------------------------
         * Instruções de uso:
         * Set o campo tag dos campos que deseja tornar obrigatórios para 1
         * No construtor do form chame o método: setCamposObrigatorios(Controls);
         * No evento do botão que cofirma o cadastro ou atualização, chame o verificarPreenchimentoCamposObrigatorios();
         * Se retornar false não deixa confirmar a operação!
         * 
         * Caso queira que um campo se torne obrigatório em tempo de execução
         * set o seu tag como 0 e depois quando quiser torná-lo obrigatório set 1
         * */
        List<Control> camposObrigatorios = new List<Control>();
        public void setCamposObrigatorios(Control.ControlCollection componentes)
        {
            foreach (Control c in componentes)
            {
                if (c.Tag != null) //campos nulos nem são monitorados
                {
                    if (c.Tag.Equals("1") || c.Tag.Equals("0"))
                    {
                        camposObrigatorios.Add(c); //adiciona tanto campos 0 como 1
                        c.Click += new EventHandler(this.campoObrigatorio_Click);
                        c.TextChanged += new EventHandler(this.campoObrigatorio_Click);
                    }
                }
                if (c.Controls.Count > 0) //se for container de componentes chama recursivo (exemplo: groupbox)
                    setCamposObrigatorios(c.Controls);
            }
        }

        public bool verificarPreenchimentoCamposObrigatorios()
        {
            bool todosPreenchidos = true;
            foreach (Control c in camposObrigatorios)
            {
                if (c.Tag.Equals("1") && c.Text.Equals(""))
                {
                    todosPreenchidos = false;
                    c.BackColor = Color.Red;
                }
            }
            return todosPreenchidos;
        }

        private void campoObrigatorio_Click(object sender, EventArgs e)
        {
            if (sender.GetType().Equals(typeof(TextBox)))
                ((TextBox)sender).BackColor = Color.White;
            if (sender.GetType().Equals(typeof(MaskedTextBox)))
                ((MaskedTextBox)sender).BackColor = Color.White;
            if (sender.GetType().Equals(typeof(RichTextBox)))
                ((RichTextBox)sender).BackColor = Color.White;
        }
        /*
         *----------------------------------------------------- FIM Tratamento campos obrigatórios-----------------------------------------------------------------------------------------------
         * */

        /*
         * -----------------------------Início existeImgAssociada---------------------------------------
         * Utilizado para buscar por fotos associadas a um id de um usuário
         * procura dentro da pasta "nomePasta" se existe um arquivo chamado id.jpg
         * */
        public bool existeImgAssociada(String nomePasta, String id)
        {
            bool result = false;
            String fotoPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"\" + nomePasta + @"\";
            result = File.Exists(fotoPath + id + ".jpg");
            return result;
        }
        /*
         * ----------------------------Fim existeImgAssociada-------------------------------------------
         * */
        public void checarTodosCheckBox(Control.ControlCollection componentes, bool marcar)
        {
            foreach (Control c in componentes)
            {
                if(c.GetType().Equals(typeof(CheckBox)))
                    ((CheckBox)c).Checked = marcar;
                if (c.Controls.Count > 0) //se for container de componentes chama recursivo (exemplo: groupbox)
                    checarTodosCheckBox(c.Controls, marcar);
            }
        }

        public void desabilitarCampos(Control.ControlCollection componentes, bool marcar)
        {
            foreach (Control c in componentes)
            {
                if (c.GetType().Equals(typeof(TextBox)))
                    ((TextBox)c).Enabled = marcar;
                if (c.GetType().Equals(typeof(RichTextBox)))
                    ((RichTextBox)c).Enabled = marcar;
                if (c.Controls.Count > 0)
                    desabilitarCampos(c.Controls, marcar);
            }
        }

        public void moneyMaskFormata(Control.ControlCollection componentes)
        {
            foreach (Control c in componentes)
            {
                if (c.GetType().Equals(typeof(TextBox)))
                    moneyMaskFormata((TextBox)c);
                if (c.Controls.Count > 0)
                    moneyMaskFormata(c.Controls);
            }
        }

        public void moneyMaskFormata(TextBox ttb)
        {
            ttb.MaxLength = 10;
            ttb.Size = new Size(74, 20);
            ttb.KeyPress += new KeyPressEventHandler(this.moneyMask);
        }

        private void moneyMask(object sender, KeyPressEventArgs e)
        {
            bool jaPossuiVirgula = false;
            int numCasasPosVirgula = 0;
            int i = 0;
            while (i < ((TextBox)sender).Text.Length && !jaPossuiVirgula)
            {
                if (((TextBox)sender).Text[i] == ',')
                    jaPossuiVirgula = true;
                i++;
                if (jaPossuiVirgula)
                    numCasasPosVirgula = ((TextBox)sender).Text.Length - i;
            }

            if (e.KeyChar == '.') //substitui . por , deixando no padrão money postgre
                e.KeyChar = ',';

            if (e.KeyChar == ',')
                if (jaPossuiVirgula)
                    e.Handled = true; //impede digitação

            if (e.KeyChar != ',' && e.KeyChar != (char)8)
                if (!char.IsDigit(e.KeyChar) || numCasasPosVirgula > 1)
                    e.Handled = true;
        }

        public void numericMaskFormata(Control.ControlCollection componentes)
        {
            foreach (Control c in componentes)
            {
                if (c.GetType().Equals(typeof(TextBox)))
                    numericMaskFormata((TextBox)c);
                if (c.Controls.Count > 0)
                    numericMaskFormata(c.Controls);
            }
        }

        public void numericMaskFormata(TextBox ttb)
        {
            ttb.MaxLength = 10;
            ttb.Size = new Size(74, 20);
            ttb.KeyPress += new KeyPressEventHandler(this.numericMask);
        }

        private void numericMask(object sender, KeyPressEventArgs e)
        {
            bool jaPossuiPonto = false;
            int numCasasPosVirgula = 0;
            int i = 0;
            while (i < ((TextBox)sender).Text.Length && !jaPossuiPonto)
            {
                if (((TextBox)sender).Text[i] == '.')
                    jaPossuiPonto = true;
                i++;
                if (jaPossuiPonto)
                    numCasasPosVirgula = ((TextBox)sender).Text.Length - i;
            }

            if (e.KeyChar == ',') //substitui , por . deixando no padrão numeric postgre
                e.KeyChar = '.';

            if (e.KeyChar == '.')
                if (jaPossuiPonto)
                    e.Handled = true; //impede digitação

            if (e.KeyChar != '.' && e.KeyChar != (char)8)
                if (!char.IsDigit(e.KeyChar) || numCasasPosVirgula > 1)
                    e.Handled = true;
        }

        /*
         * ----------------------------ttbToNumeric Inicio----------------------------------------------
         * dado um conjunto de textbox que receberam um numeric do banco como string
         * sai trocando todas , por . para deixar no padrão numeric do postgre
        */
        public void ttbToNumeric(Control.ControlCollection componentes)
        {
            foreach (Control c in componentes)
            {
                if (c.GetType().Equals(typeof(TextBox)))
                    ((TextBox)c).Text = ((TextBox)c).Text.Replace(",", ".");
                if (c.Controls.Count > 0)
                    ttbToNumeric(c.Controls);
            }
        }
        //----------------------------ttbToNumeric Fim---------------------------------------------
        public DataTable getEstados()
        {
            sql = "SELECT * FROM estado";
            bco.conecta();
            bco.executeQuery(sql, out dt);
            bco.desconecta();
            return dt;
        }

        public int getIdade(String dtNasc)
        {
            TimeSpan idadeD = DateTime.Today.Subtract(Convert.ToDateTime(dtNasc));
            int idade = (int)idadeD.TotalDays / 365;
            return idade;
        }

        public DataTable getCidades(String estado)
        {
            sql = "SELECT cid_cod, cid_nome FROM cidade INNER JOIN estado ON cidade.est_cod = estado.est_cod WHERE estado.est_sigla = '@1'" +
                " ORDER BY cid_nome DESC";
            sql = sql.Replace("@1", estado);
            bco.conecta();
            bco.executeQuery(sql, out dt);
            bco.desconecta();
            return dt;
        }

        public bool validaEmail(String email)
        {
            String[] partes = email.Split('@');
            if (partes.Length != 2)
                return false;
            if (partes[0].Length == 0 || partes[1].Length == 0)
                return false;
            if (!partes[1].Contains('.'))
                return false;
            int contPontos = 0;
            for (int i = 0; i < partes[1].Length; i++)
                if (partes[1][i] == '.')
                    contPontos++;
            if (contPontos > 2)
                return false;
            if (partes[1][partes[1].Length - 1] == '.')
                return false;

            return true;
        }

        public bool validaSite(String site)
        {
            String[] partes = site.Split('.');
            if (partes.Length > 4)
                return false;
            if (partes.Length < 3)
                return false;
            if (!partes[0].ToLower().Equals("www"))
                return false;
            if (!partes[2].ToLower().Equals("com"))
                return false;
            if (partes.Length > 4)
                return false;
            return true;
        }

        public String filtraApenasNumeros(String semFiltro)
        {
            String definitiva = "";
            for (int i = 0; i < semFiltro.Length; i++)
            {
                if (semFiltro.ElementAt(i) >= 48 && semFiltro.ElementAt(i) <= 57) //numero
                    definitiva += semFiltro.ElementAt(i);
            }
            return definitiva;
        }

        public int getCodCidade(String cidade)
        {
            sql = "SELECT cid_cod FROM cidade WHERE cid_nome = '@1'";
            sql = sql.Replace("@1", cidade);
            bco.conecta();
            bco.executeQuery(sql, out dt);
            bco.desconecta();
            return Convert.ToInt32(dt.Rows[0]["cid_cod"]);
        }

        public String getNomeCidade(String codigo)
        {
            String cidade = "";
            sql = "SELECT cid_nome FROM cidade WHERE cid_cod = @1";
            sql = sql.Replace("@1", codigo);
            bco.conecta();
            bco.executeQuery(sql, out dt);
            bco.desconecta();
            cidade = dt.Rows[0]["cid_nome"].ToString();
            return cidade;
        }

        public String getEstadoDaCidade(String cidCod)
        {
            String estado = "";
            sql = "SELECT est_sigla FROM estado INNER JOIN cidade ON estado.est_cod = cidade.est_cod WHERE cidade.cid_cod = @1";
            sql = sql.Replace("@1", cidCod);
            bco.conecta();
            bco.executeQuery(sql, out dt);
            bco.desconecta();
            estado = dt.Rows[0]["est_sigla"].ToString();
            return estado;
        }

        public String dateToString(DateTime data)
        {
            String dataS = "";
            dataS += data.Day + "-" + data.Month + "-" + data.Year;
            return dataS;
        }

        public bool validaTel(String fone)
        {
            if (fone.Length == 11 || fone.Length == 10)
                return true;
            return false;
        }

        public void gravarFoto(String caminho, Image img)
        {
            try
            {
                img.Save(caminho);
            }
            catch(Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
        }

        public String moneyFormata(String money)
        {
            String result = "R$";
            result += money;
            if (!money.Contains(','))
                result += ",00";
            return result;
        }
    }
}
