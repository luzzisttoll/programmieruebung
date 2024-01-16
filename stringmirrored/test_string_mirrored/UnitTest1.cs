using NUnit.Framework;
using StringMirror;

namespace test_string_mirrored
{
    public class StringMirrorTest
    {
        [Test]
        public static void TestStringMirrored_IdenticalStrings_ReturnsZero()
        {
            // Arrange
            string str1 = "bla";
            string str2 = "alb";

            // Act
            int result = StringMirror.Program.StringMirrored(str1, str2);

            // Assert
            Assert.AreEqual(0, result);
        }

        [Test]
        public void TestStringMirrored_DifferentStrings_ReturnsPosition()
        {
            // Arrange
            string str1 = "blebla";
            string str2 = "albalb";

            // Act
            int result = StringMirror.Program.StringMirrored(str1, str2);

            // Assert
            Assert.AreEqual(3, result);
        }

        [Test]
        public void TestStringMirrored_UnequalLengthStrings_ReturnsZero()
        {
            // Arrange
            string str1 = "abc";
            string str2 = "defg";

            // Act
            int result = StringMirror.Program.StringMirrored(str1, str2);

            // Assert
            Assert.AreEqual(0, result);
        }
    }

}