using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyChef
{
    internal class produtoNatural:produtoAlimentar
    {
        private string pn_paisOrigem;
        private bool pn_biologico;

        public string PaisOrigem
        {
            get { return pn_paisOrigem;}
            set { pn_paisOrigem = value;}
        }

        public bool Biologico
        {
            get{ return pn_biologico;}
            set { pn_biologico = value;}
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
            p_maximoDistribuidores = 5;
        }

    }
}
