using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul4_1302194032
{
    internal class Penjumlahan
    {
        internal class Program
        {
            static void Main(float[] args)
            {
                Penjumlahan<float> nim = new Penjumlahan<float>();
                float x = 1302194032;
                nim.JumlahTigaAngka(x);
                DataGeneric<float> data = new DataGeneric<float>(1302194032);
                data.PrintData();
            }
        }
        public class penjumlahan<T>
        {
            public void JumlahTigaAngka(T x)
            {
                Console.WriteLine("nim: " + x);
            }
        }
        public class DataGeneric<T>
        {
            private T data;
            public DataGeneric(T data)
            {
                this.data = data;
            }
            public void PrintData()
            {
                Console.WriteLine("angka yang keluar: " + this.data);
            }
        }
    }

    internal class Penjumlahan<T>
    {
        public Penjumlahan()
        {
          
        }

        internal void JumlahTigaAngka(float x)
        {
            throw new NotImplementedException();
        }
    }
}
