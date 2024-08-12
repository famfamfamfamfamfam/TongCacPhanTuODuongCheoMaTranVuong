using System;

namespace MANGHAICHIEU
{
    class TongCacPhanTuTrenDuongCheoChinh
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap lan luot so hang va cot cua ma tran vuong:");
            int sohang = int.Parse(Console.ReadLine());
            int socot = int.Parse(Console.ReadLine());
            if (sohang!=socot) return;
            double[,] matran = new double[sohang,socot];
            double tong = 0;
            for(int i = 0; i<sohang; i++)
            {
                for(int j = 0; j<socot; j++)
                {
                    Console.WriteLine("Nhap phan tu [{0},{1}]", i, j);
                    matran[i,j] = double.Parse(Console.ReadLine());
                    if(i==j)
                    {
                        tong += matran[i,j];
                    }
                }
            }
            Console.WriteLine("Tong cac phan tu thuoc duong cheo chinh bang "+tong);
        }
    }
}