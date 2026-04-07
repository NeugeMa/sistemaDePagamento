using System.Globalization; // classe CultureInfo
using sistemaDePagamento.Models;
using sistemaDePagamento.Service;

string opcao = string.Empty;

while (opcao != "3") {
  Menu.ExibirMenu();
  opcao = Console.ReadLine() ?? string.Empty;

  switch (opcao) {
    case "1":
      Console.Write("Informe o valor do pagamento: ");
      decimal valorCartao = decimal.Parse(Console.ReadLine()!, new CultureInfo("pt-BR"));

      Console.Write("Informe o número do cartão: ");
      string numeroCartao = Console.ReadLine()!;

      var cartao = new PagamentoCartao
      {
        Valor = valorCartao,
        NumeroCartao = numeroCartao,
        DataPagamento = DateTime.Now
      };

      Console.WriteLine(cartao.ProcessarPagamento());
      break;

    case "2":
      Console.Write("Informe o valor do pagamento: ");
      decimal valorBoleto = decimal.Parse(Console.ReadLine()!, new CultureInfo("pt-BR"));

      Console.Write("Informe o código de barras: ");
      string codigoBarras = Console.ReadLine()!;

      var boleto = new PagamentoBoleto
      {
        Valor = valorBoleto,
        CodigoBarras = codigoBarras,
        DataPagamento = DateTime.Now
      };

      Console.WriteLine(boleto.ProcessarPagamento());
      break;

    case "3":
      Console.WriteLine("Saindo do sistema...");
      break;

    default:
      Console.WriteLine("Opção inválida! Tente novamente.");
      break;
  }

  Console.WriteLine();
}
