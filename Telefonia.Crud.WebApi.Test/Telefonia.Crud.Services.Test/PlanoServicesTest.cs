using AutoFixture.NUnit3;
using Moq;
using NUnit.Framework;
using System;
using Telefonia.Crud.Infra.Database.Model;
using Telefonia.Crud.Infra.Database.Repository;
using Telefonia.Crud.Services.Test.Tooling;

namespace Telefonia.Crud.Services.Test
{
    [TestFixture(Author = "Mica Rodrigues", Category = "Services", Description = "Testa Update Plano", TestOf = typeof(Services.PlanoServices))]

    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test(Author = "Mica Rodrigues", Description = "Quando o TipoPlano não existe na base de dados, retorna exceção com mensagem")]
        [AutoMoqData]
        public void QuandoTipoPlanoNaoExiste_ExcessaoEhLancadaComMensagem([Frozen] Mock<ITipoPlanoRepository> moqTipoPlanoRepository,
            [Frozen] Mock<IOperadoraPlanoRepository> moqOperadoraPlanoRepository,
            [Frozen] Mock<IDddPlanoRepository> moqDddTelefoniaRepository,
            PlanoServices SUT)
        {
            TipoPlano tipoPlano = null;
            moqTipoPlanoRepository.Setup(_ => _.BuscarTipoPlanoPorNome(It.IsAny<string>())).Returns(tipoPlano);

            var requestAtualizarPlano = new AtualizarPlanoMessageRequest();
            requestAtualizarPlano.PlanoUpdate = new Messages.PlanoMessage()
            {
                TipoPlano = "Qualquer um"
            };

            Assert.That(() => SUT.AtualizarPlano(requestAtualizarPlano), Throws.TypeOf<Exception>());
        }

        [Test(Author = "Mica Rodrigues", Description = "Quando o Operadora não existe na base de dados, retorna exceção com mensagem")]
        [AutoMoqData]
        public void QuandoOperadoraDoPlanoNaoExiste_ExcessaoEhLancadaComMensagem([Frozen] Mock<ITipoPlanoRepository> moqTipoPlanoRepository,
            [Frozen] Mock<IOperadoraPlanoRepository> moqOperadoraPlanoRepository,
            [Frozen] Mock<IDddPlanoRepository> moqDddTelefoniaRepository,
            PlanoServices SUT)
        {
            TipoPlano tipoPlano = new TipoPlano();
            moqTipoPlanoRepository.Setup(_ => _.BuscarTipoPlanoPorNome(It.IsAny<string>())).Returns(tipoPlano);

            Operadora operadora = null;
            moqOperadoraPlanoRepository.Setup(_ => _.BuscarOperadoraPlanoPorNome(It.IsAny<string>())).Returns(operadora);

            var requestAtualizarPlano = new AtualizarPlanoMessageRequest();
            requestAtualizarPlano.PlanoUpdate = new Messages.PlanoMessage()
            {
                TipoPlano = "Qualquer um",
                Operadora="Tanto faz"
            };

            Assert.That(() => SUT.AtualizarPlano(requestAtualizarPlano), Throws.TypeOf<Exception>());
        }

        [Test(Author = "Mica Rodrigues", Description = "Quando o ddd do plano não existe na base de dados, retorna exceção com mensagem")]
        [AutoMoqData]
        public void QuandoDddDoPlanoNaoExiste_ExcessaoEhLancadaComMensagem([Frozen] Mock<ITipoPlanoRepository> moqTipoPlanoRepository,
           [Frozen] Mock<IOperadoraPlanoRepository> moqOperadoraPlanoRepository,
           [Frozen] Mock<IDddPlanoRepository> moqDddTelefoniaRepository,
           PlanoServices SUT)
        {
            TipoPlano tipoPlano = new TipoPlano();
            moqTipoPlanoRepository.Setup(_ => _.BuscarTipoPlanoPorNome(It.IsAny<string>())).Returns(tipoPlano);

            Operadora operadora = new Operadora();
            moqOperadoraPlanoRepository.Setup(_ => _.BuscarOperadoraPlanoPorNome(It.IsAny<string>())).Returns(operadora);

            Ddd ddd = null;
            moqDddTelefoniaRepository.Setup(_ => _.BuscarDDDPorNumero(It.IsAny<int>())).Returns(ddd);

            var requestAtualizarPlano = new AtualizarPlanoMessageRequest();
            requestAtualizarPlano.PlanoUpdate = new Messages.PlanoMessage()
            {
                TipoPlano = "Qualquer um",
                Operadora = "Tanto faz",
                Ddd=215
            };

            Assert.That(() => SUT.AtualizarPlano(requestAtualizarPlano), Throws.TypeOf<Exception>());
        }
    }
}