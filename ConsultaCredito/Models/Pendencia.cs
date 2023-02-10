namespace ConsultaCredito.Models;

public class Pendencia
{
    public string? CPF { get; set; }
    public string? NomePessoa { get; set; }
    public string? NomeReclamante { get; set; }
    public string? DescricaoPendencia { get; set; }
    public DateTime DataPendencia { get; set; }
    public double VlPendencia { get; set; }
}