﻿using AutoMapper;
using Core.CQRS;
using Domain.Interfaces;
using Domain.Models;
using Moq;
using NUnit.Framework;
using Services.Mappings;
using Services.Services;
using System;

namespace ApiTests.UnitTests
{
	public class MedicoTest
	{
		public MedicoTest()
		{
		}

		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void When_RepositoryReturnsNull_Then_ResultNull()
		{
			var repoMock = new Mock<IRepository<Medico>>();
			Medico expected = null;
			repoMock.Setup(x => x.Find(It.IsAny<Guid>())).Returns(expected);

			var mapper = new MapperConfiguration(config => config.AddProfile<MappingProfiles>()).CreateMapper();
			var busMock = new Mock<IBus>();
			var service = new MedicoService(repoMock.Object, mapper, busMock.Object);

			var result = service.Get(Guid.NewGuid());

			Assert.IsNull(result);
		}
	}
}
