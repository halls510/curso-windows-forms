using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CursoWindowsFormsBiblioteca.Cls_Uteis;

namespace CursoWindowsForms
{
    public partial class Frm_ValidaSenha_UC : UserControl
    {
        bool VerSenhaTxt = false;

        public Frm_ValidaSenha_UC()
        {
            InitializeComponent();
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            this.Txt_Senha.Text = "";
            this.Lbl_Resultado.Text = "";
        }

        private void Txt_Senha_KeyDown(object sender, KeyEventArgs e)
        {
            ChecaForcaSenha verifica = new ChecaForcaSenha();
            ChecaForcaSenha.ForcaDaSenha forca;
            forca = verifica.GetForcaDaSenha(this.Txt_Senha.Text);
            this.Lbl_Resultado.Text = forca.ToString();

            switch (this.Lbl_Resultado.Text)
            {
                case "Inaceitavel":
                case "Fraca":
                    Lbl_Resultado.ForeColor = Color.Red;
                    break;
                case "Aceitavel":
                    Lbl_Resultado.ForeColor = Color.Blue;
                    break;
                case "Forte":
                case "Segura":
                    Lbl_Resultado.ForeColor = Color.Green;
                    break;
            }
        }

        private void Btn_VerSenha_Click(object sender, EventArgs e)
        {
            if (this.VerSenhaTxt == false)
            {
                this.Txt_Senha.PasswordChar = '\0';
                this.VerSenhaTxt = true;
                this.Btn_VerSenha.Text = "Esconder Senha";
            }
            else
            {
                this.Txt_Senha.PasswordChar = '*';
                this.VerSenhaTxt = false;
                this.Btn_VerSenha.Text = "Ver Senha";
            }
        }
    }
}
