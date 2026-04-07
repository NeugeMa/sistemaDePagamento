namespace sistemaDePagamento.Models;

public class PagamentoBoleto : Pagamento {
  public string CodigoBarras { get; set; } = string.Empty;

  public override string ProcessarPagamento() {
    return $"Processando pagamento de R$ {Valor:N2} via Boleto (Cod Barra: {CodigoBarras}) na data {DataPagamento:dd/MM/yyyy}.";
  }
}
