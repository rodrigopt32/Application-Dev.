using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyChef
{
    internal abstract class produtoAlimentar
    {
        public int p_codigo;
        public string p_nome;
        public double p_custo;
        public double p_proteinas;
        public double p_carboHidratos;
        public double p_lipidos;
        public bool p_alergenios;
        public double p_pesoUnidade;
        public int p_numeroDistribuidores;
        public string p_distribuidorPrincipal;
        public int p_maximoDistribuidores;

        public int Codigo
        {
            get { return p_codigo; }
        }
        public string Nome
        {
            get { return p_nome; }
            set { p_nome = value; }
        }
        public double Custo
        {
            get { return p_custo; }
            set { p_custo = value; }
        }
        public double Proteinas
        {
            get { return p_proteinas; }
            set { p_proteinas = value;}
        }
        public double CarboHidratos
        {
            get { return p_carboHidratos;}
            set { p_carboHidratos = value; }
        }
        public double Lipidos
        {
            get { return p_lipidos;}
            set { p_lipidos = value;}
        }
        public bool Alergenios
        {
            get { return p_alergenios;}
            set { p_alergenios = value;}
        }
        public double PesoUnidade
        {
            get { return p_pesoUnidade; }
            set { p_pesoUnidade = value; }
        }
        public int NumeroDistribuidores
        {
            get { return p_numeroDistribuidores;}
        }
        public string DistribuidorPrincipal
        {
            get { return p_distribuidorPrincipal;}
        }
        public int DistribuidoresMaximos
        {
            get { return p_maximoDistribuidores; }
        }

        public virtual void CriarProduto(int Codigo, string Nome, double Peso)
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
            p_maximoDistribuidores = 0;
        }
    }
}
