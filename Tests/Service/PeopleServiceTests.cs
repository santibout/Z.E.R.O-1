using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using services;
using System.Collections.Generic;
using models.Domain;

namespace Z.E.R.O_1.Tests
{
    [TestClass]
    public class PeopleServiceTest
    {
        [TestMethod]
        public void PeopleServices_SelectAll_Test()
        {
            PeopleService svc = new PeopleService();
            List<People> model = svc.SelectAll();
            Assert.IsNotNull(model);
        }

        [TestMethod]
        public void PeopleService_SelectById_Test()
        {
            PeopleService svc = new PeopleService();
            People PersonById = svc.SelectById(1);
            Assert.IsNotNull(PersonById, "We a null value");
        }

        //[TestMethod]
        //public void PeopleService_Update_Test()
        //{
        //    PeopleService svc = new PeopleService();
        //    svc.Update(new PeopleUpdateRequest()
        //    {
        //        Id = 2,
        //        FirstName = "UnitTestName02_changed",
        //        MiddleInitial = "UnitTestValue02_changed",
        //        LastName = "UnitTestName02_changed",
        //        DateOfBirth = 2000 / 01 / 02,
        //        ModifiedBy = "UnitTestUser02_changed"
        //    });
        //}

        //[TestMethod]
        //public void PeopleService_Insert_Test()
        //{
        //    PeopleService svc = new PeopleService();
        //    int AddPerson = svc.Insert(
        //        new PeopleAddRequest()
        //        {
        //            FirstName = "TestFirstName",
        //            MiddleInitial = "TestInitial",
        //            LastName = "TestLastName",
        //            DateOfBirth = 2000-01-02,
        //            ModifiedBy = "TestModifier"
        //        });
        //    Assert.IsInstanceOfType(AddPerson, typeof(int), "Expected result to be an int");
        //    Assert.IsTrue(AddPerson > 0, "Expected Result to be greater than 0");
        //}
        [TestMethod]
        public void PeopleService_Delete_Test()
        {
            PeopleService svc = new PeopleService();
            svc.Delete(6);
        }
    }
}

