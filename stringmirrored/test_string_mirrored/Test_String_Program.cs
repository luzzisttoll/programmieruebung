using NUnit.Framework;
using StringMirror;

namespace test_string_mirrored
{
    public class StringMirrorTest
    {
        [Test]
        public static void TestMirroredString_IdenticalStrings_ReturnsZero()
        
            string str1 = "bla";
            string str2 = "alb";

            int result = StringMirror.Program.MirroredString(str1, str2);


            Assert.AreEqual(0, result);
        }

        [Test]
        public void TestMirroredString_DifferentStrings_ReturnsPosition()
        {

            string str1 = "blebla";
            string str2 = "albalb";


            int result = StringMirror.Program.MirroredString(str1, str2);

            
            Assert.AreEqual(3, result);
        }

        [Test]
        public void TestMirroredString_UnequalLengthStrings_ReturnsZero()
        {
            
            string str1 = "abc";
            string str2 = "defg";

            
            int result = StringMirror.Program.MirroredString(str1, str2);

            
            Assert.AreEqual(0, result);
        }
    }

}