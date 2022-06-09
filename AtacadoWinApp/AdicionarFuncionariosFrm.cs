﻿using Atacado.POCO.RH;
using Atacado.Service.RH;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtacadoWinApp
{
    public partial class AdicionarFuncionariosFrm : Form
    {
        public AdicionarFuncionariosFrm()
        {
            InitializeComponent();
        }

        private void FecharBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SalvarBtn_Click(object sender, EventArgs e)
        {
            FuncionarioPOCO poco = new FuncionarioPOCO()
            {
                Cpf = CpfTxt.Text,
                Nome = NomeTxt.Text,
                SobreNome = SobrenomeTxt.Text,
                Telefone = TelefoneTxt.Text,
                Endereco = TelefoneTxt.Text,
                Email = EmailTxt.Text,
                Rg = RgTxt.Text,
                DtNascimento = DtNascimentoDtp.Value
            };

            FuncionarioService srv = new FuncionarioService();
            if (srv.Validar(poco) == false)
            {
                string mensagem = srv.MensagensDeErro.Aggregate((x, y) => x + ";\n" + y);
                MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string mensagem = "CPF Válido.";
                MessageBox.Show(mensagem, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return;
        }

        private void NomeTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void TesteBtn_Click(object sender, EventArgs e)
        {
            if (SexoCmb.SelectedIndex == -1)
                MessageBox.Show("Erro");
            else
            {
                string texto = SexoCmb.SelectedValue.ToString();
                MessageBox.Show(texto);
            }
        }

        private void DtNascimentoDtp_ValueChanged(object sender, EventArgs e)
        {
            //DateTime dt = DtNascimentoDtp.Value;
           // MessageBox.Show(Convert.ToString(dt));
        }

        private void IdadeTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void SexoCmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PreencherSexoCmb()
        {
            SexoCmb.Items.Clear();

            SexoCmb.DisplayMember = "Value";
            SexoCmb.ValueMember = "Key";

            Dictionary<string, string> items = new Dictionary<string, string>();
            items.Add("M", "Masculino");
            items.Add("F", "Feminino");

            SexoCmb.DataSource = new BindingSource(items, null);

            SexoCmb.SelectedIndex = 0;


        }
    }
}
