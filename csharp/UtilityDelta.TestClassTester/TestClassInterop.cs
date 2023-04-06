using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace UtilityDelta.TestClassTester
{
    internal class TestClassInterop
    {
        static TestClassInterop()
        {
            var resource = "utilitydelta-interop.dll";
            Assembly curAsm = Assembly.GetExecutingAssembly();
            using (Stream stm = curAsm.GetManifestResourceStream($"{curAsm.GetName().Name}.{resource}"))
            {
                var ba = new byte[(int)stm.Length];
                stm.Read(ba, 0, (int)stm.Length);
                var path = Path.GetTempPath() + resource;
                File.WriteAllBytes(path, ba);
                if (LoadLibrary(path) == IntPtr.Zero)
                {
                    throw new ApplicationException("Cannot load " + path);
                }
            }
        }

        [DllImport("kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
        private static extern IntPtr LoadLibrary(string lpFileName);

        [DllImport("utilitydelta-interop.dll")]
        public static extern int UtilityDeltaTestClassDoThings(
            //grid inputs
            float value,
            out float result);
        
        public static float DoThings(float input)
        {
            float result;
            UtilityDeltaTestClassDoThings(input, out result);
            return result;
        }
    }
}
