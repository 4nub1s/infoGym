using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using infoGym.Classes.Negocio;

namespace infoGym
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmLogin login = new frmLogin();
            Caixa cai = new Caixa();
            Application.Run(login);
            if (login.user.Logado)
            {
                cai.CaiData = DateTime.Today.ToShortDateString();
                cai = cai.getCaixaByData();
                if (cai.UserAbriu == "") //caixa atual não aberto ainda
                {
                    if (cai.isAntFechado()) //caixa anterior foi fechado
                    {
                        new frmCaixaNovo(login.user).ShowDialog();
                    }
                    else //caixa anterior não foi fechado ainda
                        MessageBox.Show("Caixa anterior deve ser fechado para que o atual possa ser aberto!",
                        "Você se esqueceu de fechar o caixa?", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                Application.Run(new frmPrincipal(login.user));
            }
        }
    }
}
