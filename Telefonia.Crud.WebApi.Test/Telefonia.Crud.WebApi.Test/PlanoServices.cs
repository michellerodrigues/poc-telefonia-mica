using AutoFixture;
using Moq;
using NUnit.Core;
using NUnit.Framework;
using Ploeh.AutoFixture.NUnit2;
using Struik.AutoFixture.AutoMoq.AutoSetup;
using System;
using Telefonia.Crud.Infra.Database.Model;
using Telefonia.Crud.Infra.Database.Repository;
using Telefonia.Crud.Services;

namespace Telefonia.Crud.WebApi.Test
{
    [TestFixture(Author = "Mica Rodrigues", Category = "Services", Description = "Testa Update Plano", TestOf = typeof(Services.PlanoServices))]
    public class PlanoServices
    {
        private readonly Fixture fixture = null;
        public PlanoServices()
        {
            fixture = FixtureConcurrentlySafer.New();
        }
        [Test(Author = "Mica Rodrigues", Description = "Quando o ddd não existe na base de dados, retorna exceção com mensagem")]
        [AutoMoqData]
        public void Test1([Frozen] Mock<ITipoPlanoRepository> moqTipoPlanoRepository,
            [Frozen] Mock<IOperadoraPlanoRepository> moqOperadoraPlanoRepository,
            [Frozen] Mock<IDddPlanoRepository> moqDddTelefoniaRepository,
            Services.PlanoServices SUT)
        {
            Ddd ddd = null;
            moqDddTelefoniaRepository.Setup(_ => _.BuscarDDDPorNumero(It.IsAny<int>())).Returns(ddd);

            var requestAtualizarPlano = new AtualizarPlanoMessageRequest();

            Assert.That(() => SUT.AtualizarPlano(requestAtualizarPlano), Throws.TypeOf<Exception>());
        }
    }
}
