using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TodoList.Models;

namespace TodoList.Tests
{
    [TestClass]
    public class ToDoItemTests
    {
        [TestMethod]
        public void ToDoItem_SetProperties_Success()
        {
            var id = 1;
            var dueDate = DateTime.Now.Date;
            var completedDate = DateTime.Now.Date;
            var description = "Test Description";

            var todoItem = new ToDoItem
            {
                Id = id,
                DueDate = dueDate,
                CompletedDate = completedDate,
                Description = description
            };

            Assert.AreEqual(id, todoItem.Id);
            Assert.AreEqual(dueDate, todoItem.DueDate);
            Assert.AreEqual(completedDate, todoItem.CompletedDate);
            Assert.AreEqual(description, todoItem.Description);
        }

        [TestMethod]
        public void ToDoItem_DefaultConstructor_Success()
        {
            var todoItem = new ToDoItem();

            Assert.AreEqual(default(int), todoItem.Id);
            Assert.AreEqual(default(DateTime), todoItem.DueDate);
            Assert.AreEqual(default(DateTime?), todoItem.CompletedDate);
            Assert.AreEqual(default(string), todoItem.Description);
        }

        [TestMethod]
        public void ToDoItem_CompletedDate_Null_Success()
        {
            var todoItem = new ToDoItem();

            todoItem.CompletedDate = null;

            Assert.IsNull(todoItem.CompletedDate);
        }

        [TestMethod]
        public void ToDoItem_CompletedDate_Set_Success()
        {
            var todoItem = new ToDoItem();
            var completedDate = DateTime.Now.Date;

            todoItem.CompletedDate = completedDate;

            Assert.AreEqual(completedDate, todoItem.CompletedDate);
        }
    }
}
