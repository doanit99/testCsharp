using System;

namespace TinhThue;

public class PersonalIncomeTaxCalculator
{
    public void Nhap(out double thuNhap, out int soNguoi, out double baoHiem, out double tuThien)
    {
        
            Console.WriteLine("Nhap thu nhap ca nhan cua 1 thang: ");
            thuNhap = Convert.ToDouble(Console.ReadLine());
       

       
            Console.WriteLine("Nhap so nguoi trong gia dinh duoi 18 tuoi (tru ban than): ");
            soNguoi = Convert.ToInt32(Console.ReadLine());
      

      
            Console.WriteLine("Nhap % cac khoan bao hiem phai dong: ");
            baoHiem = Convert.ToDouble(Console.ReadLine());
       

      
            Console.WriteLine("Nhap cac khoan tu thien, quyen gop: ");
            tuThien = Convert.ToDouble(Console.ReadLine());
        
    }

    public double TinhThue(double thuNhap, int soNguoi, double baoHiem, double tuThien)
    {
        double thueGTThuNhapCN = 4000000;
        double thueGTThuNhapGD = 1600000 * soNguoi;
        double thueGTBaoHiem = thuNhap * (baoHiem*0.01);
        
        double thueLuyTienTungPhan = thuNhap - (thueGTThuNhapCN + thueGTThuNhapGD + thueGTBaoHiem + tuThien);

        double thueThuNhapCNPNop = 0;
        double thueThuNhapCN = 0;
        switch (thueLuyTienTungPhan)
        {
            case double n when (n <= 0):
                thueThuNhapCN = 0;
                break;
            case double n when (n <= 5000000):
                thueThuNhapCNPNop = n * 0.05;
                thueThuNhapCN = thueThuNhapCNPNop;
                break;

            case double n when (n <= 10000000):
                thueThuNhapCNPNop = (n - 5000000) * 0.1;
                thueThuNhapCN = 250000 + thueThuNhapCNPNop;
                break;

            case double n when (n <= 18000000):
                thueThuNhapCNPNop = (n - 10000000) * 0.15;
                thueThuNhapCN = 250000 + 500000 + thueThuNhapCNPNop;
                break;

            case double n when (n <= 32000000):
                thueThuNhapCNPNop = (n - 18000000) * 0.2;
                thueThuNhapCN = 250000 + 500000 + 1200000 + thueThuNhapCNPNop;
                break;

            case double n when (n <= 52000000):
                thueThuNhapCNPNop = (n - 32000000) * 0.25;
                thueThuNhapCN = 250000 + 500000 + 1200000 + 2800000 + thueThuNhapCNPNop;
                break;

            case double n when (n <= 80000000):
                thueThuNhapCNPNop = (n - 52000000) * 0.3;
                thueThuNhapCN = 250000 + 500000 + 1200000 + 2800000 + 5000000 + thueThuNhapCNPNop;
                break;

            case double n when (n > 80000000):
                thueThuNhapCNPNop = (thueLuyTienTungPhan - 80000000) * 0.35;
                thueThuNhapCN = 250000 + 500000 + 1200000 + 2800000 + 5000000 + 8400000 + thueThuNhapCNPNop;
                break;
            default:
                return -1;
               
        }
        return thueThuNhapCN;
    }



    static void Main(string[] args)
    {
        PersonalIncomeTaxCalculator program = new PersonalIncomeTaxCalculator();
        double thuNhap;
        int soNguoi;
        double baoHiem;
        double tuThien;

        program.Nhap(out thuNhap, out soNguoi, out baoHiem, out tuThien);
        double thue = program.TinhThue(thuNhap, soNguoi, baoHiem, tuThien);

        Console.WriteLine("Thue can dong la: " + thue);
    }
}