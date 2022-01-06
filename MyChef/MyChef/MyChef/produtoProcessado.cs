using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyChef
{
    internal class produtoProcessado:produtoAlimentar
    {
        private string pp_marca;
        private int pp_unidadeEmbalagem;
        private int pp_diasValidade;

        public string Marca
        {
            get { return pp_marca; }
            set { pp_marca = value; }
        }

        public int UnidadesEmbalagem
        {
            get { return pp_unidadeEmbalagem; }
            set { pp_unidadeEmbalagem = value; }
        }

        public int DiasValidade
        {
            get { return pp_diasValidade;}
            set { pp_diasValidade = value;}
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
            p_maximoDistribuidores = 10;
        }

    }
}
