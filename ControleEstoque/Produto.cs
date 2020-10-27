using System;
using System.Globalization;

namespace Curso {
    class Produto {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque(){
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade){
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade){
            Quantidade -= quantidade;
        }

        //sobreposição
        public override string ToString()
        {
            return Nome 
            + ", $ " 
            + Preco.ToString("F2", CultureInfo.InvariantCuture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCuture);
        }
    }
}