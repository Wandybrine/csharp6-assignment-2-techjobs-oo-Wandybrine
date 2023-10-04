
namespace TechJobs.Tests
{
	[TestClass]
	public class JobTests
	{
        //Testing Objects
        //initalize your testing objects here

        //Testing objects
        Job job1 = new Job();

        Job job2 = new Job();

        Job job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new 
            PositionType("Quality control"), new CoreCompetency("Persistence"));

        Job job4 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new 
            PositionType("Quality control"), new CoreCompetency("Persistence"));

        [TestMethod]
        public void Test_Setting_Job_Id()
        {
            Job job1 = new Job();
            Job job2 = new Job();

            int jobId1 = job1.Id;
            int jobId2 = job2.Id;

            Assert.AreEqual(jobId1 + 1, jobId2, "Job IDs should differ by 1.");
        }

        [TestMethod]
        public void TestToStringStartsAndEndsWithNewLine()
        {
            // Arrange
            Job job = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            // Act
            string jobString = job.ToString();

            // Assert
            Assert.IsTrue(jobString.StartsWith("\n"), "String should start with a newline.");
            Assert.IsTrue(jobString.EndsWith("\n"), "String should end with a newline.");
        }

        [TestMethod]
        public void TestToStringContainsCorrectLabelsAndData()
        {
            // Arrange
            Job job = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new 
                PositionType("Quality control"), new CoreCompetency("Persistence"));

            // Act
            string jobString = job.ToString();

            // Assert
            Assert.IsTrue(jobString.Contains("\nID: 1\n"));
            Assert.IsTrue(jobString.Contains("Name: Product tester\n"));
            Assert.IsTrue(jobString.Contains("Employer: ACME\n"));
            Assert.IsTrue(jobString.Contains("Location: Desert\n"));
            Assert.IsTrue(jobString.Contains("Position Type: Quality control\n"));
            Assert.IsTrue(jobString.Contains("Core Competency: Persistence\n"));
        }

        [TestMethod]
        public void TestToStringHandlesEmptyField()
        {
            // Arrange
            Job job = new Job("Product tester", new Employer(""), new Location("Desert"), new PositionType(""), new CoreCompetency(""));

            // Act
            string jobString = job.ToString();

            // Assert
            Assert.IsTrue(jobString.Contains("Employer: Data not available\n"));
            Assert.IsTrue(jobString.Contains("Position Type: Data not available\n"));
        }
    }
}
    

