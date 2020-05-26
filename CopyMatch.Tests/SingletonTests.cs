using System.Dynamic;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace CopyMatch.Tests
{
    public static class SingletonTests
    {
        [Fact]
        public static void SingletonSingleThreadTest()
        {
            var s1 = Singleton<object>.Instance;
            var s2 = Singleton<object>.Instance;

            Assert.Equal(s1.GetHashCode(), s2.GetHashCode());
        }

        [Fact]
        public static void SingletonMultiThreadedTest()
        {
            object s1 = null; 
            object s2 = null;

            Thread t1 = new Thread(() =>
            {
                s1 = Singleton<object>.Instance;
            });

            Thread t2 = new Thread(() =>
            {
                s2 = Singleton<object>.Instance;
            });

            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();
            Assert.NotNull(s1);
            Assert.NotNull(s2);
            Assert.Equal(s1.GetHashCode(), s2.GetHashCode());
        }
    }
}
