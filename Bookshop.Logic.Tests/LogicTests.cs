using Bookshop.Logic.Contracts;
using Bookshop.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bookshop.Logic.Tests
{
    [TestClass]
    public class LogicTests
    {
        private readonly IBookRepository repo = new BookRepository();

        [TestMethod]
        public void BookRepository_Should_show_All_Books()
        {
            // Act
            var result = repo.GetAll();

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void BookRepository_Should_Create_Book()
        {
            Book book = new Book
            {
                ISBN = "123456",
                Language = Language.Deutsch,
                Title = "Moderne Architektur im Web",
                CategoryId = 1
            };

            repo.Add(book);
            bool result = repo.SaveAll();

            Assert.IsTrue(result);
        }
    }
}
