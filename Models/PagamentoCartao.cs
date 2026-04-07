namespace sistemaDePagamento.Models;

public class PagamentoCartao : Pagamento {
  public string NumeroCartao { get; set; } = string.Empty;

  public override string ProcessarPagamento() {
    return $"Processando pagamento de R$ {Valor:N2} via Cartão (Número: {NumeroCartao}) na data {DataPagamento:dd/MM/yyyy}.";
  }
}
