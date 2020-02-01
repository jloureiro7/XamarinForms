﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using App01_ConsultarCEP.Servico.Modelo;
using App01_ConsultarCEP.Servico;

namespace App01_ConsultarCEP
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            BOTAO.Clicked += BuscarCEP;
        }

        private void BuscarCEP(object sender, EventArgs args)
        {
            //Lógica do Programa
            string cep = CEP.Text.Trim();

            if (isValidCEP(cep))
            {
                Endereco end = ViaCEPServico.BuscarEnderecoViaCEP(cep);
                RESULTADO.Text = string.Format("Endereço: {2} de {3} {0}, {1}", end.localidade, end.uf, end.logradouro, end.bairro);
            }   
        }
        private bool isValidCEP(string cep)
        {
            //Validações
            bool valido = true;
            if(cep.Length != 8) 
            {
                DisplayAlert("Erro", "CEP Inválido! O CEP deve conter 8 caracteres", "OK");
                valido = false; 
            }
            int NovoCEP = 0;
            if (!int.TryParse(cep, out NovoCEP)) 
            {
                DisplayAlert("Erro", "CEP Inválido! O CEP deve ser composto apenas por números", "OK");
                valido = false; 
            }
            return valido;
        }
    }
}
