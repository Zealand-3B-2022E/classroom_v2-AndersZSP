using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassRoomNet60;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60.Tests
{
    [TestClass()]
    public class StuderendeTests
    {
        [DataTestMethod]
        [DataRow(12)]
        [DataRow(1)]
        [DataRow(2)]
        public void AarstidVinterTest(int maaned)
        {
            //Arrange
            Studerende stud = new Studerende("test",1234,maaned);

            //Act
            string aarstid = stud.Aarstid(maaned);

            //Assert
            Assert.AreEqual("Vinter", aarstid);
        }


        [DataTestMethod]
        [DataRow(3)]
        [DataRow(4)]
        [DataRow(5)]
        public void AarstidForaarTest(int maaned)
        {
            //Arrange
            Studerende stud = new Studerende("test", 1234, maaned);

            //Act
            string aarstid = stud.Aarstid(maaned);

            //Assert
            Assert.AreEqual("Forår", aarstid);
        }


        [DataTestMethod]
        [DataRow(6)]
        [DataRow(7)]
        [DataRow(8)]
        public void AarstidSommerTest(int maaned)
        {
            //Arrange
            Studerende stud = new Studerende("test", 1234, maaned);

            //Act
            string aarstid = stud.Aarstid(maaned);

            //Assert
            Assert.AreEqual("Sommer", aarstid);
        }


        [DataTestMethod]
        [DataRow(9)]
        [DataRow(10)]
        [DataRow(11)]
        public void AarstidEfteraarTest(int maaned)
        {
            //Arrange
            Studerende stud = new Studerende("test", 1234, maaned);

            //Act
            string aarstid = stud.Aarstid(maaned);

            //Assert
            Assert.AreEqual("Efterår", aarstid);
        }


        [DataTestMethod]
        [DataRow(13)]
        [DataRow(0)]
        [DataRow(-1)]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void UlovligFoedselsMaaned(int ulovligMaaned)
        {
            //Arrange
            var stud = new Studerende("Fejl", 5555, ulovligMaaned);
            //Act
            int maaned = stud.Fødselsmåned;
            //Assert
            Assert.Fail();
        }
    }
}