using System;
using System.Linq;
using NUnit.Framework;
using Star.Expense.Domain.Entities;
using Star.Expense.Domain.Interfaces;
using Star.Expense.Domain.Services;

namespace Star.Expense.Domain.Tests.ServiceTests
{
    [TestFixture]
    public class CategoryServiceTest
    {
        private ICategoryService _service;

        [SetUp]
        public void SetUp()
        {
            _service = new CategoryService();
        }

        [Test]
        public void CanCreateNewCategory()
        {
            // Arrange
            var newCategory = new Category()
            {
                Name = "Estrela"
            };

            // Act
            _service.CreateCategory(newCategory);

            // Asserts
            Assert.IsTrue(_service.GetCategories().First().Name == "Estrela");
        }
        
        [Test]
        public void FailWhenAddingSameTagName()
        {
            // Arrange
            var newCategory = new Category()
            {
                Name = "Estrela"
            };

            // Act
            _service.CreateCategory(newCategory);

            // Asserts
            Assert.Throws<Exception>(() =>
            {
                _service.CreateCategory(newCategory);
            });
        }
    }
}