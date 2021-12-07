﻿using CursoWindowsFormsBiblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Frm_ValidaCPF : Form
    {
        public Frm_ValidaCPF()
        {
            InitializeComponent();
        }       

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            this.Lbl_Resultado.Text = "";
            this.Msk_CPF.Text = "";
        }

        private void Btn_Valida_Click(object sender, EventArgs e)
        {
            bool validaCPF = false;
            validaCPF = Cls_Uteis.Valida(Msk_CPF.Text);
            switch(validaCPF)
            {
                case true:
                    this.Lbl_Resultado.Text = "CPF VÁLIDO";
                    this.Lbl_Resultado.ForeColor = Color.Green;
                    break;
                case false:
                    this.Lbl_Resultado.Text = "CPF INVÁLIDO";
                    this.Lbl_Resultado.ForeColor = Color.Red;
                    break;
            }
        }
    }
}
