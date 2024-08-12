﻿using System;

namespace ChuyenSoThanhChu
{
    class Program
{
    static void Main(string[] args)
        {
            int so;

            Console.Write("Nhap vao so nguyen toi da co 3 chu so: ");
            so = int.Parse(Console.ReadLine());

            if (so < 0 || so >= 1000)
            {
                Console.Write("Phai nhap so nguyen toi da co 3 chu so!");
                return;
            }

            int hangDonVi;
            int hangChuc;
            int hangTram;

            hangTram = so / 100;
            hangChuc = (so % 100) / 10;
            hangDonVi = so % 10;

            string[] donvi = ["", "mot", "hai", "ba", "bon", "nam", "sau", "bay", "tam", "chin"];
            string[] hangchuc = ["", "muoi", "hai muoi", "ba muoi", "bon muoi", "nam muoi", "sau muoi", "bay muoi", "tam muoi", "chin muoi"];

            if (so >= 0 && so < 10)
            {
                Console.WriteLine($"So {so} doc la: {donvi[hangDonVi]}");
            }

            if (so == 10)
            {
                Console.WriteLine($"So {so} doc la: {hangchuc[hangChuc]}");

            }
            else if (so > 10 && so < 100)
            {
                Console.WriteLine($"So {so} doc la: {hangchuc[hangChuc]} {donvi[hangDonVi]}");
            }

            if (so == 100)
            {
                Console.WriteLine($"{donvi[hangTram]} tram");
            }
            else if (so > 100 && so < 1000)
            {
                if (hangChuc == 0 && hangDonVi != 0)
                    Console.WriteLine($"So {so} doc la: {donvi[hangTram]} tram {hangchuc[hangChuc]}le {donvi[hangDonVi]}");
                else
                    Console.WriteLine($"So {so} doc la: {donvi[hangTram]} tram {hangchuc[hangChuc]} {donvi[hangDonVi]}");
            }

        }
    }
}