using System.Linq;
using Telefonia.Crud.Infra.Database.Model;

namespace Telefonia.Crud.Infra.Database.Context
{
    public static class DbTelefoniaInitializer
    {
        public static void StartDataBase(TelefoniaDatabaseContext context)
        {
            context.Database.EnsureCreated();

            if (context.Operadoras.Any())
            {
                return;
            }

            var vivo = new Operadora()
            {
                OperadoraNome = "vivo"
            };
            var claro = new Operadora()
            {
                OperadoraNome = "claro"
            };
            var tim = new Operadora()
            {
                OperadoraNome = "tim"
            };

            /*Incluindo Planos*/
            var controle = new TipoPlano()
            {
                Tipo = "Controle"
            };

            var prePago = new TipoPlano()
            {
                Tipo = "Pré-Pago"
            };

            var posPago = new TipoPlano()
            {
                Tipo = "Pós-Pago"
            };

            var plano1 = new Plano()
            {
                FranquiaInternet = "5Gb",
                Min = 300,
                Tipo = controle,
                Valor = new decimal(59.90),
                Operadora = vivo
            };

            var plano2 = new Plano()
            {
                FranquiaInternet = "8Gb",
                Min = 500,
                Tipo = posPago,
                Valor = new decimal(89.90),
                Operadora = claro
            };

            var plano3 = new Plano()
            {
                FranquiaInternet = "2Gb",
                Min = 100,
                Tipo = prePago,
                Valor = new decimal(10.90),
                Operadora = tim
            };

            /*Incluindo DDDs*/
            var ddd21 = new Ddd() { DDD = 21};
            var ddd11 = new Ddd() { DDD = 11 };
            var ddd41 = new Ddd() { DDD = 41 };
            var ddd24 = new Ddd() { DDD = 24 };

            ddd21.PlanosDisponiveis.Add(plano1);
            ddd21.PlanosDisponiveis.Add(plano2);
            ddd21.PlanosDisponiveis.Add(plano3);

            ddd11.PlanosDisponiveis.Add(plano1);
            ddd11.PlanosDisponiveis.Add(plano3);

            ddd41.PlanosDisponiveis.Add(plano1);
            ddd41.PlanosDisponiveis.Add(plano2);
            ddd41.PlanosDisponiveis.Add(plano3);
            
            ddd24.PlanosDisponiveis.Add(plano3);

            context.Ddds.Add(ddd21);
            context.Ddds.Add(ddd11);
            context.Ddds.Add(ddd41);
            context.Ddds.Add(ddd24);


            context.SaveChanges();

        }
    }
}
