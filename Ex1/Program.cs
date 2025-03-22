using System.Runtime.InteropServices;

namespace Ex1
{
	public class Program
	{
		public static void Main()
		{
			unsafe
			{
				int a = 5;
				int *address = &a;
				GCHandle handle = GCHandle.Alloc(a, GCHandleType.Pinned);
    				IntPtr pointer = GCHandle.ToIntPtr(handle);

				System.Console.WriteLine($"{*address}");
				System.Console.WriteLine($"{handle.Target} => {pointer}");

				handle.Free();
			}
			System.Console.WriteLine("Third commit!");
		}
	}
}
