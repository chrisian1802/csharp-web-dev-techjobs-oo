using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobTest
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void TestSettingJobId()
        {
            Job idTest = new Job();
            Job idTest2 = new Job();
            Assert.IsFalse(idTest.Id == idTest2.Id);
            Assert.IsTrue(idTest.Id + 1 == idTest2.Id);

        }

        [TestMethod]
        public void TestFullConstructor()
        {
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            Assert.AreEqual(job1.Name, "Product tester");
            Assert.AreEqual(job1.EmployerName.Value, "ACME");
            Assert.AreEqual(job1.EmployerLocation.Value, "Desert");
            Assert.AreEqual(job1.JobType.Value, "Quality control");
            Assert.AreEqual(job1.JobCoreCompetency.Value, "Persistence");
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Job job2 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            Assert.IsFalse(Equals(job1, job2));
        }

        [TestMethod]
        public void TestToStringMethodFirstLineBlank()
        {
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            string toString = job1.ToString();

            Assert.AreEqual(toString[0], '\n');
            Assert.AreEqual(toString[toString.Length - 1], '\n');
        }

        [TestMethod]
        public void TestStringMethodLabels()
        {
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            string check = job1.ToString();

            Assert.IsTrue(check.Contains("\nId: "));

            Assert.IsTrue(check.Contains("\nName: "));
            Assert.IsTrue(check.Contains("\nEmployer: "));
            Assert.IsTrue(check.Contains("\nLocation: "));
            Assert.IsTrue(check.Contains("\nPosition Type: "));
            Assert.IsTrue(check.Contains("\nCore Competency: "));
        }

        [TestMethod]
        public void TestToStringFieldValues()
        {
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            //string toString = job1.ToString();

            Assert.AreEqual(job1.Name, "Product tester");
            Assert.AreEqual(job1.EmployerName.Value, "ACME");
            Assert.AreEqual(job1.EmployerLocation.Value, "Desert");
            Assert.AreEqual(job1.JobType.Value, "Quality control");
            Assert.AreEqual(job1.JobCoreCompetency.Value, "Persistence");
        }

    }
}