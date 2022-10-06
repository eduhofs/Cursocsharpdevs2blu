﻿using Devs2Blu.ProjetosAula.SistemaCadastro.Forms.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devs2Blu.ProjetosAula.SistemaCadastro.Forms
{
    public partial class Form1 : Form
    {
        public MySqlConnection Conn { get; set; }
        public ConvenioRepository ConvenioRepository = new ConvenioRepository();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region TesteConexao
            /*Conn = ConnectionMySQL.GetConnection();

            if (Conn.State == ConnectionState.Open)
            {
                MessageBox.Show("Conexão efetuada com sucesso!", "Conexão ao MySql", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Conn.Close();
            }*/
            #endregion

            PopulaComboConvenio();
        }

        #region Methods

        private void PopulaComboConvenio()
        {
            var listConvenios = ConvenioRepository.FetchAll();

            while (listConvenios.Read())
            {
                comboBoxConvenio.Items.Add(listConvenios.GetString("nome"));
            }
        }

        #endregion

        private void radioButtonTipoPessoaFisica_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonTipoPessoaFisica.Checked)
            {
                labelCGCCPF.Text = "CPF";
                labelCGCCPF.Visible = true;
            }
        }

        private void radioButtonTipoPessoaJuridica_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonTipoPessoaJuridica.Checked)
            {
                labelCGCCPF.Text = "CNPJ";
                labelCGCCPF.Visible = true;
            }
        }
    }
}
