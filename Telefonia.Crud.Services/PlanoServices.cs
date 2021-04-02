using System;
using System.Linq;
using Telefonia.Crud.Infra.Database.Repository;
using Telefonia.Crud.Services.Messages;

namespace Telefonia.Crud.Services
{
    public class PlanoServices : IPlanoServices
    {
        private readonly IDddPlanoRepository _dDDTelefoniaRepository;
        private readonly IPlanoTelefoniaRepository _planoTelefoniaRepository;
        private readonly IOperadoraPlanoRepository _operadoraPlanoRepository;
        private readonly ITipoPlanoRepository _tipoPlanoRepository;

        public PlanoServices(IDddPlanoRepository dDDTelefoniaRepository,
            IPlanoTelefoniaRepository planoTelefoniaRepository,
            IOperadoraPlanoRepository operadoraPlanoRepository,
            ITipoPlanoRepository tipoPlanoRepository)
        {
            _dDDTelefoniaRepository = dDDTelefoniaRepository;
            _planoTelefoniaRepository = planoTelefoniaRepository;
            _operadoraPlanoRepository = operadoraPlanoRepository;
            _tipoPlanoRepository = tipoPlanoRepository;
        }

        public ObterPlanoMessageResponse BuscarPlanoPorId(ObterPlanoMessageRequest request)
        {
            var ddd = _dDDTelefoniaRepository.BuscarDDDPorNumero(request.Ddd);

            var plano = _planoTelefoniaRepository.BuscarPlanoPorId(request.IdPlano, ddd);

            ObterPlanoMessageResponse response = new ObterPlanoMessageResponse();


            if (ddd != null)
            {
                if (plano != null)
                {
                    var planoMessage = new PlanoMessage()
                    {
                        FranquiaInternet = plano.FranquiaInternet,
                        Min = plano.Min,
                        Operadora = plano.Operadora?.OperadoraNome,
                        TipoPlano = plano.Tipo?.Tipo,
                        Valor = plano.Valor
                    };

                    response = new ObterPlanoMessageResponse()
                    {
                        DDD = request.Ddd,
                        IdPlano = request.IdPlano,
                        Plano = planoMessage
                    };
                }
                else
                {
                    throw new Exception("Plano não existe na base de dados");
                }
            }
            else
            {
                throw new Exception("DDD não existe na base de dados");
            }

            return response;
        }


        public ObterPlanoPorDDDMessageResponse ListarPlanosPorDDD(ObterPlanoPorDDDMessageRequest request)
        {
            var ddd = _dDDTelefoniaRepository.BuscarDDDPorNumero(request.Ddd);
            ObterPlanoPorDDDMessageResponse response = new ObterPlanoPorDDDMessageResponse();

            if (ddd != null)
            {
                var planosDisponiveis = _planoTelefoniaRepository.ListarPlanosPorDDD(ddd);

                if(planosDisponiveis==null || !planosDisponiveis.Any())
                {
                    throw new Exception("DDD não possui planos disponíveis");
                }
                response.Ddd = request.Ddd;

                foreach (var plano in planosDisponiveis)
                {
                    var planoMessage = new PlanoMessage()
                    {
                        FranquiaInternet = plano.FranquiaInternet,
                        Min = plano.Min,
                        Operadora = plano.Operadora?.OperadoraNome,
                        TipoPlano = plano.Tipo?.Tipo,
                        Valor = plano.Valor
                    };
                    response.PlanosDisponiveis.Add(planoMessage);
                }
            }
            else
            {
                throw new Exception("DDD não existe na base de dados");
            }
            return response;
        }

        public ObterPlanoPorOperadoraMessageResponse ObterPlanoPorOperadora(ObterPlanoPorOperadoraMessageRequest request)
        {
            var ddd = _dDDTelefoniaRepository.BuscarDDDPorNumero(request.Ddd);
            ObterPlanoPorOperadoraMessageResponse response = new ObterPlanoPorOperadoraMessageResponse();

            if (ddd != null)
            {
                var operadora = _operadoraPlanoRepository.BuscarOperadoraPlanoPorId(request.OperadoraId);
                if (operadora != null)
                {
                    response.Operadora = operadora.OperadoraNome;
                    var planosDisponiveis = _planoTelefoniaRepository.BuscarPlanoPorOperadora(operadora, ddd);
                    
                    if (planosDisponiveis == null || !planosDisponiveis.Any())
                    {
                        throw new Exception("DDD não possui planos disponíveis para esta operadora");
                    }

                    foreach (var plano in planosDisponiveis)
                    {
                        var planoMessage = new PlanoMessage()
                        {
                            FranquiaInternet = plano.FranquiaInternet,
                            Min = plano.Min,
                            Operadora = plano.Operadora?.OperadoraNome,
                            TipoPlano = plano.Tipo?.Tipo,
                            Valor = plano.Valor
                        };
                        response.PlanosDisponiveis.Add(planoMessage);
                    }
                }
                else
                {
                    throw new Exception("Operadora não existe na base de dados");
                }

            }
            else
            {
                throw new Exception("DDD não existe na base de dados");
            }
            return response;
        }


        public ObterPlanoPorTipoMessageResponse ObterPlanoPorTipo(ObterPlanoPorTipoMessageRequest request)
        {
            var ddd = _dDDTelefoniaRepository.BuscarDDDPorNumero(request.Ddd);
            ObterPlanoPorTipoMessageResponse response = new ObterPlanoPorTipoMessageResponse();

            if (ddd != null)
            {
                var tipoPlano = _tipoPlanoRepository.BuscarTipoPlanoPorId(request.TipoPlanoId);
                if (tipoPlano != null)
                {
                    response.TipoPlano = tipoPlano.Tipo;
                    var planosDisponiveis = _planoTelefoniaRepository.BuscarPlanoPorTipo(tipoPlano, ddd);

                    if (planosDisponiveis == null || !planosDisponiveis.Any())
                    {
                        throw new Exception("DDD não possui planos disponíveis para este tipo de plano");
                    }

                    foreach (var plano in planosDisponiveis)
                    {
                        var planoMessage = new PlanoMessage()
                        {
                            FranquiaInternet = plano.FranquiaInternet,
                            Min = plano.Min,
                            Operadora = plano.Operadora?.OperadoraNome,
                            TipoPlano = plano.Tipo?.Tipo,
                            Valor = plano.Valor
                        };
                        response.PlanosDisponiveis.Add(planoMessage);
                    }
                }

            }
            else
            {
                throw new Exception("DDD não existe na base de dados");
            }
            return response;
        }

    }
}
