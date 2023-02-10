using ConsultaCredito.Models;

namespace ConsultaCredito.Services;

public interface IServicoConsultaCredito
{
    IList<Pendencia>? ConsultarPendenciasPorCPF(string cpf);
}