namespace ConsoleApp1
{
    //Cửa hàng có chương trình đổi 3 vỏ que kem lấy 1 cái kem.
    //An mua 5 cái kem và hiện có 5 vỏ que kem,
    //Viết một chương trình để tính xem An sẽ có bao kem
    public class TinhQueKem
    {
        public static int TinhSoKem(int soKem, int soVoKem)
        {
            if (soVoKem < 3)
            {
                return soKem;
            }
            else
            {
                int soQueKem = soVoKem / 3;
                int soVoKemConLai = soVoKem % 3;
                int tongSoKem = soKem + soQueKem;
                return TinhSoKem(tongSoKem, soQueKem + soVoKemConLai);
            }
        }
    }
}
