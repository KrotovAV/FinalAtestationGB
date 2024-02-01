using DataBaseUsers.Repository;
using DataBaseMessage.Repository;

using Microsoft.AspNetCore.Mvc;
using Moq;
using UserService.AuthorizationModel;
using UserService.Controllers;


namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {


        //private LoginController _controller;
        //private Mock<IUserRepository> _userRepositoryMock;

        //[SetUp]
        //public void Setup()
        //{
        //    _userRepositoryMock = new Mock<IUserRepository>();
        //    _controller = new LoginController(new ConfigurationManager(), _userRepositoryMock.Object);
        //}

        [TestMethod]
        public void SendMessage_Success()
        {
            // Arrange
            var repository = new MessagRepository();

            // Act
            var id = repository.SendMessage("Hello, World!", "John Doe", "Jane Doe");

            // Assert
            Assert.AreNotEqual(id, Guid.Empty);
        }


        [TestMethod]
        public void GetAllMessages_Success()
        {
            // Arrange
            var repository = new MessagRepository();

            // Act
            var messages = repository.GetAllMessages("Jane Doe");

            // Assert
            Assert.IsNotNull(messages);
        }


        //[TestMethod]
        //public void GetAllMessages_ReturnsEmptyList_ForNonExistingUser()
        //{
        //    // Arrange
        //    var repository = new MessagRepository();

        //    // Act
        //    var messages = repository.GetAllMessages("NonExistingUser");

        //    // Assert
        //    Assert.IsNotNull(messages);
        //}

        [TestMethod]
        public void AddUser_Should_Return_OkResult()
        {
            // Arrange
            var userLogin = new LoginModel { Name = "John", Password = "password" };

            // Act
            var result = _controller.AddUser(userLogin) as OkResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(200, result.StatusCode);
        }
    }
}