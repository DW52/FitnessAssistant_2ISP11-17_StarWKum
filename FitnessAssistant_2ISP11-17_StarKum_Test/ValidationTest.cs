using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FitnessAssistant_2ISP11_17_StarKum_Test
{
    [TestClass]
    public class ValidationTest
    {

        [TestMethod]
        public void ValidationPassword_Lenght7_False()
        {
            //Arrange
            string password = "Aa1@aaa";
            bool ex = false;

            //Act
            bool act = FitnessAssistant_2ISP11_17_StarWKum.Classes.Validation.ValidationPassword(password);
            //Assert
            Assert.AreEqual(ex, act);
        }
        [TestMethod]
        public void ValidationPassword_IsLower_False()
        {
            //Arrange
            string password = "AAA7@AAA";
            bool ex = false;

            //Act
            bool act = FitnessAssistant_2ISP11_17_StarWKum.Classes.Validation.ValidationPassword(password);
            //Assert
            Assert.AreEqual(ex, act);
        }

            [TestMethod]
        public void ValidationPassword_Lenght21_False()
        {
            //Arrange
            string password = "Aa1@121212121212121212";
            bool ex = false;

            //Act
            bool act = FitnessAssistant_2ISP11_17_StarWKum.Classes.Validation.ValidationPassword(password);
            //Assert
            Assert.AreEqual(ex, act);
        }
        [TestMethod]
        public void ValidationPassword_CorrectPassword_True()
        {
            //Arrange
            string password = "Aa1@aaaaa";
            bool ex = true;

            //Act
            bool act = FitnessAssistant_2ISP11_17_StarWKum.Classes.Validation.ValidationPassword(password);
            //Assert
            Assert.AreEqual(ex, act);
        }
        [TestMethod]
        public void ValidationPassword_NotSpecSymbol_False()
        {
            //Arrange
            string password = "Aa1aaaaa";
            bool ex = false;

            //Act
            bool act = FitnessAssistant_2ISP11_17_StarWKum.Classes.Validation.ValidationPassword(password);
            //Assert
            Assert.AreEqual(ex, act);
        }
        [TestMethod]
        public void ValidationPassword_NotDigit_False()
        {
            //Arrange
            string password = "Aaaaaa@a";
            bool ex = false;

            //Act
            bool act = FitnessAssistant_2ISP11_17_StarWKum.Classes.Validation.ValidationPassword(password);
            //Assert
            Assert.AreEqual(ex, act);
        }
        [TestMethod]
        public void ValidationPassword_Null_False()
        {
            //Arrange
            string password = "";
            bool ex = false;

            //Act
            bool act = FitnessAssistant_2ISP11_17_StarWKum.Classes.Validation.ValidationPassword(password);
            //Assert
            Assert.AreEqual(ex, act);
        }
        [TestMethod]
        public void ValidationPassword_IsUpper_False()
        {
            //Arrange
            string password = "aaa9@aaa";
            bool ex = false;

            //Act
            bool act = FitnessAssistant_2ISP11_17_StarWKum.Classes.Validation.ValidationPassword(password);
            //Assert
            Assert.AreEqual(ex, act);
        }
       
        [TestMethod]
        public void ValidationPassword_WhiteSpace_False()
        {
            //Arrange
            string password = "AAa9@ AAA";
            bool ex = false;

            //Act
            bool act = FitnessAssistant_2ISP11_17_StarWKum.Classes.Validation.ValidationPassword(password);
            //Assert
            Assert.AreEqual(ex, act);
        }
        [TestMethod]
        public void ValidationPassword_OnlySpace_False()
        {
            //Arrange
            string password = "        ";
            bool ex = false;

            //Act
            bool act = FitnessAssistant_2ISP11_17_StarWKum.Classes.Validation.ValidationPassword(password);
            //Assert
            Assert.AreEqual(ex, act);
        }
       

        //------FLP-------

        [TestMethod]
        public void ValidationFLP_IsDigit_False()
        {
            //Arrange
            string fname = "Dar@@";
            bool ex = true;

            //Act
            bool act = FitnessAssistant_2ISP11_17_StarWKum.Classes.Validation.ValidationFLP(fname);
            //Assert
            Assert.AreEqual(ex, act);
        }
        [TestMethod]
        public void ValidationFLP_IsSpecSymbol_True()
        {
            //Arrange
            string fname = "Dar-ia";
            bool ex = true;

            //Act
            bool act = FitnessAssistant_2ISP11_17_StarWKum.Classes.Validation.ValidationFLP(fname);
            //Assert
            Assert.AreEqual(ex, act);
        }
        [TestMethod]
        public void ValidationFLP_NotSpecSymbol_False()
        {
            //Arrange
            string fname = "Daria";
            bool ex = true;

            //Act
            bool act = FitnessAssistant_2ISP11_17_StarWKum.Classes.Validation.ValidationFLP(fname);
            //Assert
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationFLP_SpecSymbol_False()
        {
            //Arrange
            string fname = "Dar_ia";
            bool ex = true;

            //Act
            bool act = FitnessAssistant_2ISP11_17_StarWKum.Classes.Validation.ValidationFLP(fname);
            //Assert
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationFLP_WhiteSpace_False()
        {
            //Arrange
            string fname = "Dar ia";
            bool ex = true;

            //Act
            bool act = FitnessAssistant_2ISP11_17_StarWKum.Classes.Validation.ValidationFLP(fname);
            //Assert
            Assert.AreEqual(ex, act);
        }

        //-----Height---
        [TestMethod]
        public void ValidationHeightWeight_LenghtMin_False()
        {
            //Arrange
            string height = "-19";
            bool ex = false;

            //Act
            bool act = FitnessAssistant_2ISP11_17_StarWKum.Classes.Validation.ValidationHeightWeight(height);
            //Assert
            Assert.AreEqual(ex, act);
        }
        [TestMethod]
        public void ValidationHeightWeight_LenghtMax_False()
        {
            //Arrange
            string height = "301";
            bool ex = false;

            //Act
            bool act = FitnessAssistant_2ISP11_17_StarWKum.Classes.Validation.ValidationHeightWeight(Convert.ToString(height));
            //Assert
            Assert.AreEqual(ex, act);
        }
        [TestMethod]
        public void ValidationHeightWeight_Letter_False()
        {
            //Arrange
            string height = "3d";
            bool ex = false;

            //Act
            bool act = FitnessAssistant_2ISP11_17_StarWKum.Classes.Validation.ValidationHeightWeight(Convert.ToString(height));
            //Assert
            Assert.AreEqual(ex, act);
        }
        [TestMethod]
        public void ValidationHeightWeight_Null_False()
        {
            //Arrange
            string height = "";
            bool ex = false;

            //Act
            bool act = FitnessAssistant_2ISP11_17_StarWKum.Classes.Validation.ValidationHeightWeight(Convert.ToString(height));
            //Assert
            Assert.AreEqual(ex, act);
        }
        [TestMethod]
        public void ValidationHeightWeight_OnlySpace_False()
        {
            //Arrange
            string height = "4 6";
            bool ex = false;

            //Act
            bool act = FitnessAssistant_2ISP11_17_StarWKum.Classes.Validation.ValidationHeightWeight(Convert.ToString(height));
            //Assert
            Assert.AreEqual(ex, act);
        }
        [TestMethod]
        public void ValidationHeightWeight_SpecSymbol_False()
        {
            //Arrange
            string height = "46@";
            bool ex = false;

            //Act
            bool act = FitnessAssistant_2ISP11_17_StarWKum.Classes.Validation.ValidationHeightWeight(Convert.ToString(height));
            //Assert
            Assert.AreEqual(ex, act);
        }
        [TestMethod]
        public void ValidationHeightWeight_Correct_True()
        {
            //Arrange
            string height = "200";
            bool ex = true;

            //Act
            bool act = FitnessAssistant_2ISP11_17_StarWKum.Classes.Validation.ValidationHeightWeight(Convert.ToString(height));
            //Assert
            Assert.AreEqual(ex, act);
        }
    }
}










