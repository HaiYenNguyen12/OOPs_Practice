using Ex14.Entity;
using Ex14.Management;
using Newtonsoft.Json;

namespace StudentTest
{
    public class StudentTest
    {
        private Management m1;
        [SetUp]
        public void Setup()
        {
            var l1 = new List<Student>()
            {
                new GoodStudent(10,"Mama Award", 1, "Nguyen Van A", DateTime.Parse("12/03/1997"), "Female", "0971065979","DUT","Good"),
                new GoodStudent(9,"Mama Award", 2, "Nguyen Van C", DateTime.Parse("12/03/1997"), "Female", "0971065979","DUT","Good"),
                new GoodStudent(9,"Mama Award", 3, "Nguyen Van B", DateTime.Parse("12/03/1997"), "Female", "0971065979","DUT","Good"),
                new NormalStudent(900,60,4,"Nguyen Van D",DateTime.Parse("12/03/1997"), "Female", "0971065979","DUT","Good"),
                new NormalStudent(800,50,5,"Nguyen Van E",DateTime.Parse("12/03/1997"), "Female", "0971065979","DUT","Good"),
                new NormalStudent(900,50,6,"Nguyen Van F",DateTime.Parse("12/03/1997"), "Female", "0971065979","DUT","Good"),
                new NormalStudent(900,50,7,"Nguyen Van H",DateTime.Parse("12/03/1997"), "Female", "0971065979","DUT","Good"),
            };

            m1 = new Ex14.Management.Management(l1);
        }

        [Test]
        public void NumberRecruiLessThanNumberGoodStudentAndSortByName()
        {
            List<Student> actual_result = m1.RecruitStudent(2);
            List<Student> expected_result = new List<Student>
            {
                new GoodStudent(10,"Mama Award", 1, "Nguyen Van A", DateTime.Parse("12/03/1997"), "Female", "0971065979","DUT","Good"),
                new GoodStudent(9,"Mama Award", 3, "Nguyen Van B", DateTime.Parse("12/03/1997"), "Female", "0971065979","DUT","Good"),
            };

            var expected = JsonConvert.SerializeObject(expected_result);
            var result = JsonConvert.SerializeObject(actual_result);
            //Assert.AreEqual(expected, result);
            Assert.That(expected,Is.EqualTo(result));
        }

        [Test]
        public void NumberRecruitGoodLessThanNumberGoodStudent()
        {
            var actual_result = m1.RecruitStudent(1);
            var expected_result = new List<Student>
            {
                new GoodStudent(10,"Mama Award", 1, "Nguyen Van A", DateTime.Parse("12/03/1997"), "Female", "0971065979","DUT","Good"),
            };
            var expected = JsonConvert.SerializeObject(expected_result);
            var result = JsonConvert.SerializeObject(actual_result);
            //Assert.AreEqual(expected, result);
            Assert.That(expected, Is.EqualTo(result));
        }

        [Test]
        public void NumberRecruitGoodEqualNumberGoodStudent()
        {
            var actual_result = m1.RecruitStudent(3);
            var expected_result = new List<Student>
            {
                new GoodStudent(10,"Mama Award", 1, "Nguyen Van A", DateTime.Parse("12/03/1997"), "Female", "0971065979","DUT","Good"),
                new GoodStudent(9,"Mama Award", 2, "Nguyen Van C", DateTime.Parse("12/03/1997"), "Female", "0971065979","DUT","Good"),
                new GoodStudent(9,"Mama Award", 3, "Nguyen Van B", DateTime.Parse("12/03/1997"), "Female", "0971065979","DUT","Good"),
            };
            var expected = JsonConvert.SerializeObject(expected_result);
            var result = JsonConvert.SerializeObject(actual_result);
            //Assert.AreEqual(expected, result);
            Assert.That(expected, Is.EqualTo(result));
        }

        [Test]
        public void NumberRecruitMoreThanNumberGoodStudent()
        {
            var actual_result = m1.RecruitStudent(4);
            var expected_result = new List<Student>
            {
                new GoodStudent(10,"Mama Award", 1, "Nguyen Van A", DateTime.Parse("12/03/1997"), "Female", "0971065979","DUT","Good"),
                new GoodStudent(9,"Mama Award", 2, "Nguyen Van C", DateTime.Parse("12/03/1997"), "Female", "0971065979","DUT","Good"),
                new GoodStudent(9,"Mama Award", 3, "Nguyen Van B", DateTime.Parse("12/03/1997"), "Female", "0971065979","DUT","Good"),
                new NormalStudent(900,60,4,"Nguyen Van D",DateTime.Parse("12/03/1997"), "Female", "0971065979","DUT","Good"),
            };
            var expected = JsonConvert.SerializeObject(expected_result);
            var result = JsonConvert.SerializeObject(actual_result);
            //Assert.AreEqual(expected, result);
            Assert.That(expected, Is.EqualTo(result));
        }

        [Test]
        public void NumberRecruitMoreThanNumberGoodStudentAndEqualEntryPoint()
        {
            var actual_result = m1.RecruitStudent(5);
            var expected_result = new List<Student>
            {
                new GoodStudent(10,"Mama Award", 1, "Nguyen Van A", DateTime.Parse("12/03/1997"), "Female", "0971065979","DUT","Good"),
                new GoodStudent(9,"Mama Award", 2, "Nguyen Van C", DateTime.Parse("12/03/1997"), "Female", "0971065979","DUT","Good"),
                new GoodStudent(9,"Mama Award", 3, "Nguyen Van B", DateTime.Parse("12/03/1997"), "Female", "0971065979","DUT","Good"),
                new NormalStudent(900,60,4,"Nguyen Van D",DateTime.Parse("12/03/1997"), "Female", "0971065979","DUT","Good"),
                new NormalStudent(900,50,6,"Nguyen Van F",DateTime.Parse("12/03/1997"), "Female", "0971065979","DUT","Good"),
            };
            var expected = JsonConvert.SerializeObject(expected_result);
            var result = JsonConvert.SerializeObject(actual_result);
            //Assert.AreEqual(expected, result);
            Assert.That(expected, Is.EqualTo(result));
        }
    }
}