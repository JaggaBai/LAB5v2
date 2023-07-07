using LAB5.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    internal class TaskManagerTest
    {
        private TaskManager _taskManager;
        [SetUp]
        public void Setup()
        {
            _taskManager = new TaskManager();
        }
        [Test]
        public void AddTask_ShouldIncreaseTaskCount()
        {
            // Arrange
            var task = new LAB5.Model.Task("Test task");
            // Act
            _taskManager.AddTask(task);
            // Assert
            Assert.AreEqual(1, _taskManager.GetTasks().Count);
        }
        [Test]
        public void RemoveTask_ExistingTask_ShouldDecreaseTaskCount()
        {
            // Arrange
            var task1 = new LAB5.Model.Task("Test task");
            _taskManager.AddTask(task1);
            // Act
            _taskManager.RemoveTask(task1.Id);
            // Assert
            Assert.AreEqual(0, _taskManager.GetTasks().Count);
        }
        [Test]
        public void GetTasks_ShouldReturnAllTasks()
        {
            // Arrange
            var task3 = new LAB5.Model.Task("Test task");
            var task4 = new LAB5.Model.Task("Test task");
            _taskManager.AddTask(task3);
            _taskManager.AddTask(task4);
            // Act
            _taskManager.GetTasks();
            // Assert
            Assert.AreEqual(2, _taskManager.GetTasks().Count);
        }
    }
}
