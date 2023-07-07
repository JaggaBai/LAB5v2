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
    }
}
