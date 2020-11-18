using ConsultaCEP.Servico.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ConsultaCEP
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
            //TO DO - Lógica do programa

            //Validações.
            string cep = CEP.Text.Trim(); //trim removo todo espaço do inicio e fim caso seja espaço em branco(vazio)
            //chama o metodo direto porque criamos um metodo static
            Endereco end = ViaCEPServico.BuscarEnderecoViaCEP(cep);

            RESULTADO.Text = string.Format("Endereço: {2} Bairro: {3} - {0}, {1}", end.localidade, end.uf, end.logradouro, end.bairro);
        }
    }
}
