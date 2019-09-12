using System;

namespace NEW
{
    class bangundatar
    {
        public void luas_persegi(int sisi)
        {
            Console.WriteLine("luas perseegi adalah "+sisi * sisi);
        }
        
        public int luas_segitiga(int alas, int tinggi)
        {
            return alas * tinggi / 2;
        }

        public void luas_lingkaran(int r)
        {
            Console.WriteLine("luas linkaran adalah "+3.14 * r * r);
        }
    }
}