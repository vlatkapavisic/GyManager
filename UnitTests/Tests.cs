using System;
using System.Collections.Generic;
using GyManager;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class Tests
    {
        //Tests work for data in GyManager's constructor.

        private IGyManager gymanager;

        [TestMethod]
        public void TestAddMember()
        {
            gymanager = Factory.CreateGyManagerForTests();
            gymanager.AddMember("Testa", "Testić", "1234567891234");
            Assert.IsTrue(gymanager.MemberExists("1234567891234"));
        }

        [TestMethod]
        public void TestAddProgramAndInstructor()
        {
            gymanager = Factory.CreateGyManagerForTests();
            gymanager.AddProgramAndInstructor("Test program", 100, 30, "Testa", "Testić", "1234567891234", 1000);
            Assert.IsTrue(gymanager.ProgramExists("Test program"));
            Assert.IsTrue(gymanager.InstructorExists("1234567891234"));
        }

        [TestMethod]
        public void TestDeleteMember()
        {
            gymanager = Factory.CreateGyManagerForTests();
            gymanager.AddMember("Testa", "Testić", "1234567891234");
            gymanager.DeleteMember("1234567891234");
            Assert.IsFalse(gymanager.MemberExists("1234567891234"));
        }

        [TestMethod]
        public void TestFireAndHire()
        {
            gymanager = Factory.CreateGyManagerForTests();
            gymanager.AddProgramAndInstructor("Test program", 100, 30, "Testa", "Testić", "1234567891234", 1000);
            gymanager.FireInstructorAndHireAnother("1234567891234", "Testadva", "Testićdva", "1234567891232");
            Assert.IsFalse(gymanager.InstructorExists("1234567891234"));
            Assert.IsTrue(gymanager.InstructorExists("1234567891232"));
        }

        [TestMethod]
        public void TestEnrollANewProgram()
        {
            gymanager = Factory.CreateGyManagerForTests();
            int n = gymanager.GetNumberOfMembersOnAProgram("Yoga");
            gymanager.EnrollANewProgram("Yoga", "2209990335110");
            Assert.AreEqual(n + 1, gymanager.GetNumberOfMembersOnAProgram("Yoga"));
        }

        [TestMethod]
        public void TestUnenrollAProgram()
        {
            gymanager = Factory.CreateGyManagerForTests();
            int n = gymanager.GetNumberOfMembersOnAProgram("Yoga");
            gymanager.UnenrollAProgram("Yoga", "1111111111116"); 
            Assert.AreEqual(n - 1, gymanager.GetNumberOfMembersOnAProgram("Yoga"));
        }

        [TestMethod]
        public void TestPayMembershipAndSalary()
        {
            gymanager = Factory.CreateGyManagerForTests();
            int cr = gymanager.GetCashRegisterValue();
            int salary = gymanager.GetInstructorsSalary("1111111111110");
            gymanager.PaySalary("1111111111110");
            Assert.AreEqual(cr - salary, gymanager.GetCashRegisterValue());
            cr = gymanager.GetCashRegisterValue();
            int membership = gymanager.GetMembership("2209990335110");
            gymanager.PayMembership("2209990335110");
            Assert.AreEqual(cr + membership, gymanager.GetCashRegisterValue());
        }

        [TestMethod]
        [ExpectedException(typeof(GyManagerException))]
        public void TestWrongJmbg()
        {
            gymanager = Factory.CreateGyManagerForTests();
            //gymanager.AddMember("Vlatka", "Pavišić", "220999033511a");
            //gymanager.AddMember("Vlatka", "Pavišić", "2209990335110");
            gymanager.AddMember("Vlatka", "Pavišić", "22099903351182918664");
        }

        [TestMethod]
        [ExpectedException(typeof(GyManagerException))]
        public void TestWrongProgramOrInstructor()
        {
            gymanager = Factory.CreateGyManagerForTests();
            gymanager.AddProgramAndInstructor("Aerobic", 120, 20, "Renata", "Sopek", "1111111111110", 1000);
        }

        [TestMethod]
        [ExpectedException(typeof(GyManagerException))]
        public void TestDeleteAMemberThatDoesntExist()
        {
            gymanager = Factory.CreateGyManagerForTests();
            gymanager.DeleteMember("2209990335777");
        }

        [TestMethod]
        [ExpectedException(typeof(GyManagerException))]
        public void TestEnrollAProgramTwice()
        {
            gymanager = Factory.CreateGyManagerForTests();
            gymanager.EnrollANewProgram("Yoga", "220999033110");
            gymanager.EnrollANewProgram("Yoga", "220999033110");
        }

        [TestMethod]
        [ExpectedException(typeof(GyManagerException))]
        public void TestUnenrollAProgramThatMemberDidntEnroll()
        {
            gymanager = Factory.CreateGyManagerForTests();
            gymanager.UnenrollAProgram("Yoga", "220999033110");
        }

        [TestMethod]
        [ExpectedException(typeof(GyManagerException))]
        public void TestHireAMember()
        {
            gymanager = Factory.CreateGyManagerForTests();
            gymanager.FireInstructorAndHireAnother("1111111111110", "Vlatka", "Pavišić", "2209990335110");
        }

    }
}
