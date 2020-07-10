using System;
using System.Linq;
using NUnit.Framework;
using Star.Expense.Domain.Entities;
using Star.Expense.Domain.Interfaces;
using Star.Expense.Domain.Services;

namespace Star.Expense.Domain.Tests.ServiceTests
{
    [TestFixture]
    public class TagServiceTest
    {
        private ITagService _service;

        [SetUp]
        public void SetUp()
        {
            _service = new TagService();
        }

        [Test]
        public void CanCreateNewTag()
        {
            // Arrange
            var newTag = new Tag()
            {
                Name = "Estrela"
            };

            // Act
            _service.CreateTag(newTag);

            // Asserts
            Assert.IsTrue(_service.GetTags().First().Name == "Estrela");
        }
        
        [Test]
        public void FailWhenAddingSameTagName()
        {
            // Arrange
            var newTag = new Tag()
            {
                Name = "Estrela"
            };

            // Act
            _service.CreateTag(newTag);

            // Asserts
            Assert.Throws<Exception>(() =>
            {
                _service.CreateTag(newTag);
            });
        }
    }
}