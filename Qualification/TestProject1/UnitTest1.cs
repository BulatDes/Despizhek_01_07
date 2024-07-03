using DespizhekPR31.Models;

namespace TestProject1
{
    [TestFixture]
    public class Tests
    {

        [Test]
        public void Test1()
        {
            //���������� ���������� �������� ������
            Cabel cabel = new Cabel("type1", 5, 15);
            //��������� ���������
            double expected = 15 / 5;
            //����������� ���������� ���������� � �������������� �����������
            Assert.AreEqual(expected, cabel.Q(), 0.01);
        }

        [Test]
        public void Test2()
        {
            Cabel cabel = new Cabel("type1", 2, 17.0);
            double expected = 17.0 / 2;
            Assert.AreEqual(expected, cabel.Q(), 0.01);
        }

        [Test]
        public void Test3()
        {
            //���������� ���������� ������ �������
            PresenceOfBraid cabel = new PresenceOfBraid("type1", 5, 15, true);
            double expected = 2.1 * (15 / 5);
            Assert.AreEqual(expected, cabel.Q(),0.01);
        }

        [Test]
        public void Test4()
        {
            PresenceOfBraid cabel = new PresenceOfBraid("type1", 5, 15, false   );
            double expected = 0.7 * (15 / 5);
            Assert.AreEqual(expected, cabel.Q(),0.01);
        }
    }
}