using System.Runtime.InteropServices;

namespace AotDemo
{
    public class Example
    {
        [UnmanagedCallersOnly(EntryPoint = "Add")]
        public static int Add(int a, int b)
        {
            return a + b;
        }
    }
}
