
namespace ElvisTest
{
    public class ElvisTest
    {
        [SetUp]
        public void Setup()
        {
        }


        /// <summary>
        /// ���� ��  �������� ��������� ������  ��������  ��� ����  edds
        /// 
        /// </summary>
        /// <param name="p">������  ������� � ������� ������� ��������  - ��������� ��������� 
        /// ��������� �������� ������������ ���  ������������ ������� ������� � ��������   </param>
        [TestCase(4, 1, 2, 3, 1, 2, 3, 4)]
        [TestCase(1, 1)]
        [TestCase(1, 1, 2, 3)]
        public void GetUnPairSimple(params int[] p)
        {
            var expected = p[0];
            var pairs = new Pair.Pair(p.Skip(1).ToArray());
            Assert.That(pairs.GetUnPairSimple(), Is.EqualTo(expected));
        }
        /// <summary>
        /// ����   ������ ��������� ������  ��������  ��� ����  
        /// </summary>
        /// <param name="p">������  ������� � ������� ������� ��������  - ��������� ��������� 
        /// ��������� �������� ������������ ���  ������������ ������� ������� � ��������   </param>

        [TestCase(4, 1, 2, 3, 1, 2, 3, 4)]
        [TestCase(3, 1, 2, 3, 1, 2, 3, 3)]
        [TestCase(2, 1, 2, 3, 3, 1)]
        [TestCase(1, 1)]
        public void GetUnPairClever(params int[] p)
        {
            var expected = p[0];
            var pairs = new Pair.Pair(p.Skip(1).ToArray());
            Assert.That(pairs.GetUnPairClever(), Is.EqualTo(expected));
        }
    }
}
