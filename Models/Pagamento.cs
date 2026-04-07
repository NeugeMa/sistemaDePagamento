namespace sistemaDePagamento.Models;

public abstract class Pagamento {
  public decimal Valor { get; set; }
  public DateTime DataPagamento { get; set; }
  public abstract string ProcessarPagamento();
}
