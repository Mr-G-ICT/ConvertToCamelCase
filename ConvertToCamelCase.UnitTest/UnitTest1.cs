using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConvertToCamelCase.UnitTest
{
    [TestClass]
    public class ConvertToCamelCaseTests
    {
        [TestMethod]
        public void CanConvertToCamel_IsFirstLetterLower_ReturnsFirstLetterLowerHypens()
        {
            //ARRANGE
            //creating a new instance of the test object so we can access it.
            var Convert = new ConvertToCamelCaase.ConvertToCamel();

            //ACT
            //this could be part of arrange, but as it is used as part of the class I put it in act, 
            //setting up the test. plus this is the variable I will be changing as I change the tests
            string conversionstring = Convert.GetStringToConvert = "the-stealth-warrior";
            //This is calling the function, after I've allocated the variable.
            string result = Convert.ToCamelCase();

            //ASSERT
            //what the outcome should be
            Assert.AreEqual(result, "theStealthWarrior");
        }

        [TestMethod]
        public void CanConvertToCamel_IsFirstLetterUpper_ReturnsFirstLetterUpperHypens()
        {
            //ARRANGE
            var Convert = new ConvertToCamelCaase.ConvertToCamel();

            //ACT
       
            string conversionstring = Convert.GetStringToConvert = "The-Stealth-Warrior";
            string result = Convert.ToCamelCase();

            //ASSERT
            //what the outcome should be
            Assert.AreEqual(result, "TheStealthWarrior");
        }
        [TestMethod]
        public void CanConvertToCamel_IsFirstLetterUpper_ReturnsFirstLetterUpperUnderscores()
        {
            //ARRANGE
            var Convert = new ConvertToCamelCaase.ConvertToCamel();

            //ACT

            string conversionstring = Convert.GetStringToConvert = "The_Stealth_Warrior";
            string result = Convert.ToCamelCase();

            //ASSERT
            //what the outcome should be
            Assert.AreEqual(result, "TheStealthWarrior");
        }
        [TestMethod]
        public void CanConvertToCamel_IsFirstLetterLower_ReturnsFirstLetterLowerUnderscores()
        {
            //ARRANGE
            var Convert = new ConvertToCamelCaase.ConvertToCamel();

            //ACT

            string conversionstring = Convert.GetStringToConvert = "the_Stealth_Warrior";
            string result = Convert.ToCamelCase();

            //ASSERT
            //what the outcome should be
            Assert.AreEqual(result, "theStealthWarrior");
        }
    }
}
