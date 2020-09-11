using AutoMapper;
using Core.CQRS;
using Domain.Interfaces;
using Domain.Models;
using Moq;
using NUnit.Framework;
using Services.DTOs;
using Services.Mappings;
using Services.Services;
using Services.Services.Interfaces;
using System;

namespace ApiTests.UnitTests
{
	public class GuiaTest
	{
		public GuiaTest()
		{
		}

		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void When_RepositoryReturnsNull_Then_ResultNull()
		{
			var repoMock = new Mock<IRepository<Guia>>();
			Guia expected = null;
			repoMock.Setup(x => x.Find(It.IsAny<Guid>())).Returns(expected);

			var serviceMock = new Mock<IContratoService>();

			var mapper = new MapperConfiguration(config => config.AddProfile<MappingProfiles>()).CreateMapper();
			var busMock = new Mock<IBus>();
			var service = new GuiaService(repoMock.Object, mapper, busMock.Object, serviceMock.Object);

			var result = service.Get(Guid.NewGuid());

			Assert.IsNull(result);
		}

		[Test]
		public void When_ContratoIsInativo_Then_ThrowsArgumentException()
		{
			var repoMock = new Mock<IRepository<Guia>>();
			Guia guiaExpected = null;
			repoMock.Setup(x => x.Find(It.IsAny<Guid>())).Returns(guiaExpected);

			var contratoServiceMock = new Mock<IContratoService>();
			ContratoDTO contratoExpected = new ContratoDTO();
			contratoExpected.Situcont = "Inativo";
			contratoServiceMock.Setup(x => x.Get(It.IsAny<Guid>())).Returns(contratoExpected);

			var mapper = new MapperConfiguration(config => config.AddProfile<MappingProfiles>()).CreateMapper();
			var busMock = new Mock<IBus>();
			var service = new GuiaService(repoMock.Object, mapper, busMock.Object, contratoServiceMock.Object);

			CreateGuiaDTO guiaDTO = new CreateGuiaDTO();

			Assert.Throws(typeof(ArgumentException),
				new TestDelegate(() => service.Save(guiaDTO)));
		}
	}
}
