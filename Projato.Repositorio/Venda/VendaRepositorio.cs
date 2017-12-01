using Projato.Dados;
using Projato.Repositorio.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projato.Repositorio.Venda
{
    public class VendaRepositorio : IDisposable
    {

        public VendaRepositorio()
        {

        }
        /// <summary>
        /// Método para cadastrar Venda
        /// </summary>
        /// <param name="idProduto"></param>
        /// <param name="idCliente"></param>
        /// <param name="qtde"></param>
        /// <returns></returns>
        public bool CadastrarVenda(int idProduto, int idCliente, int qtde)
        {
            try
            {
                using (var contexto = new Model1())
                {
                    contexto.Venda.Add(new Dados.Venda()
                    {
                        ID_CLIENTE = idCliente,
                        ID_PRODUTO = idProduto,
                        QTDE = qtde,
                        DT_HR_COMPRA = DateTime.Now,
                    });
                    return contexto.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {

                return false;
            }
        }

        /// <summary>
        /// Método para buscar vendas
        /// </summary>
        /// <param name="idProduto"></param>
        /// <param name="idCliente"></param>
        /// <returns></returns>
        public List<VendaVM> BuscarVenda(int? idProduto, int? idCliente)
        {
            try
            {
                List<Dados.Venda> vendas;

                using (var contexto = new Model1())
                {

                    if (idProduto.HasValue && idCliente.HasValue)
                    {
                        vendas = contexto.Venda.Where(x => x.ID_PRODUTO == idProduto && x.ID_CLIENTE == idCliente).ToList();

                    }
                    else if (idProduto.HasValue && !idCliente.HasValue)
                    {
                        vendas = contexto.Venda.Where(x => x.ID_PRODUTO == idProduto).ToList();
                    }
                    else if (!idProduto.HasValue && idCliente.HasValue)
                    {
                        vendas = contexto.Venda.Where(x => x.ID_CLIENTE == idCliente).ToList();
                    }
                    else
                    {
                        vendas = contexto.Venda.ToList();
                    }

                    if (!vendas.Any()) return new List<VendaVM>();

                    var vendasVM = new List<VendaVM>();

                    foreach (var item in vendas)
                    {
                        var cliente = BuscarCliente(item.ID_CLIENTE);
                        var produto = BuscarProduto(item.ID_PRODUTO);

                        var venda = new VendaVM()
                        {
                            Data = item.DT_HR_COMPRA,
                            DescricaoProduto = produto.NomeProduto,
                            NomeCliente = cliente.NomeLogin,
                            Preco = produto.ValorProduto,
                            Qtde = 199
                        };
                        vendasVM.Add(venda);
                    }
                    

                    return vendasVM;

                }
            }
            catch (Exception e)
            {

                return null;
            }
        }

        private Dados.Produto BuscarProduto(int idProduto)
        {
            using (var contexto = new Model1())
            {
                return contexto.Produto.Find(idProduto);
            }

        }

        private Dados.Login BuscarCliente(int idCliente)
        {
            using (var contexto = new Model1())
            {
                return contexto.Login.Find(idCliente);
            }
        }


        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
