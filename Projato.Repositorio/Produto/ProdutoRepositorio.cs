using Projato.Dados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projato.Repositorio.Produto
{
    public class ProdutoRepositorio : IDisposable
    {
        public ProdutoRepositorio()
        {
        }

        public bool CadastarProduto(int idCategoria, string nomeProduto, double valorProduto)
        {
            try
            {
                using (var contexto = new Model1())
                {
                    contexto.Produto.Add(new Dados.Produto()
                    {
                        CategoriaIdCategoria = idCategoria,
                        NomeProduto = nomeProduto,
                        ValorProduto = valorProduto,
                        DescricaoProduto = "Gen",
                        IndicadorVitrine = "S"
                        
                    });
                    return contexto.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {
                return false;
            }

        }


        public List<Dados.Produto> BuscarProduto(string nome)
        {
            try
            {
                using (var contexto = new Model1())
                {
                    if (string.IsNullOrEmpty(nome))
                    {
                        var b = contexto.Produto.ToList();
                        return contexto.Produto.ToList();
                    }
                    return contexto.Produto.Where(x => x.NomeProduto.ToUpper().Equals(nome.ToUpper())).ToList();

                }
            }
            catch (Exception e)
            {
                return null;

            }
        }


        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
