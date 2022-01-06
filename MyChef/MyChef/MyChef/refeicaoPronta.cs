using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyChef
{
    internal class refeicaoPronta:produtoProcessado
    {
        private string rp_modoPreparacao;
        private int rp_tempoPreparacao;
        private bool rp_gourmet;

        public string ModoPreparacao
        {
            get { return rp_modoPreparacao; }
            set { rp_modoPreparacao = value; }
        }

        public int TempoPreparacao
        {
            get { return rp_tempoPreparacao; }
            set { rp_tempoPreparacao = value; }
        }

        public bool Gourmet
        {
            get { return rp_gourmet; }
            set { rp_gourmet = value;}
        }

        public override void CriarProduto(int Codigo, string Nome, double Peso)
        {
            p_codigo = Codigo;
            p_nome = Nome;
            p_custo = 0;
            p_proteinas = 0;
            p_carboHidratos = 0;
            p_lipidos = 0;
            p_alergenios = true;
            p_pesoUnidade = Peso;
            p_numeroDistribuidores = 0;
            p_distribuidorPrincipal = "";
            p_maximoDistribuidores = 2;
        }
    }
}
