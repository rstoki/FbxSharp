using System;
using NUnit.Framework;
using FbxSharp;

namespace FbxSharpTests
{
    [TestFixture]
    public class FbxObjectTest : TestBase
    {
        [Test]
        public void FbxObject_Create_HasZeroProperties()
        {
            // given:
            var obj = new FbxObject("");

            // then:
            Assert.AreEqual(0, CountProperties(obj));
            Assert.AreEqual(0, obj.GetSrcPropertyCount());
            Assert.AreEqual(0, obj.GetDstPropertyCount());
        }

        [Test]
        public void FbxObject_Create_HasRootProperty()
        {
            // given:
            var obj = new FbxObject("");

            // then:
            Assert.NotNull(obj.RootProperty);
            Assert.True((obj.RootProperty).IsValid());
            Assert.AreEqual("", obj.RootProperty.GetName());
        }

        [Test]
        public void FbxObject_Create_HasClassRootProperty()
        {
            // given:
            var obj = new FbxObject("");

            // then:
            Assert.NotNull(obj.GetClassRootProperty());
            Assert.True(obj.GetClassRootProperty().IsValid());
        }
    }
}