using Pastel;
using System.Drawing;

namespace KutuSorusu
{
    public class Kutu
    {
        public async Task<KeyValuePair<string, int>> AlaniniHesapla(int[] kutuBoyutlari)
        {
            //Dizinin her elemanı için yükseklik * taban'ı hesaplarım.
            var keyValue = new List<KeyValuePair<string, int>>();//Her elemanın sonucunu keyValue KeyValuePair'sine yazmak için hazırlık yaptım.
            var terstenKutuBoyutlari = kutuBoyutlari.Reverse().ToArray();
            for (int i = 0; i < kutuBoyutlari.Count(); i++)
            {
                int birinciKutuAlani = 0;
                int ikinciKutuAlani = 0;

                int ilgiliDiziElemani = kutuBoyutlari[i];

                int[] birinciKutuDizisi = new int[i + 1];
                int[] ikinciKutuDizisi = new int[kutuBoyutlari.Count() - (i + 1)];

                for (int j = 0; j < birinciKutuDizisi.Count(); j++)
                {
                    birinciKutuDizisi[j] = kutuBoyutlari[j];
                }
                birinciKutuAlani = await BirinciKutuHesapla(birinciKutuDizisi);

                for (int k = 0; k < ikinciKutuDizisi.Count(); k++)
                {
                    ikinciKutuDizisi[k] = terstenKutuBoyutlari[k];
                }

                ikinciKutuAlani = await IkinciKutuHesapla(ikinciKutuDizisi);
                int alan = birinciKutuAlani + ikinciKutuAlani;
                keyValue.Add(new KeyValuePair<string, int>($" Birinci Kutu:{string.Join(",", birinciKutuDizisi)} İkinci Kutu:{string.Join(",", ikinciKutuDizisi)}" , alan));//Her elemanı KeyValuePair'ye eklerim.
            }
 
            return keyValue.OrderBy(e => e.Value).FirstOrDefault();
        }
        private async Task<int> BirinciKutuHesapla(int[] birinciKutuBoyutlari)
        {
            if (birinciKutuBoyutlari.Count() > 0)
            {
                int yukseklik = birinciKutuBoyutlari.Max();
                int taban = birinciKutuBoyutlari.Count();
                //Console.WriteLine($"Birinci Kutu elemanı: {string.Join(",", birinciKutuBoyutlari).Pastel(Color.Green)} Alanı {(yukseklik * taban).ToString().Pastel(Color.AliceBlue)}");
                return yukseklik * taban;
            }
            else
            {
                return 0;
            }
        }
        private async Task<int> IkinciKutuHesapla(int[] ikinciKutuBoyutlari)
        {
            if (ikinciKutuBoyutlari.Count() > 0)
            {
                //Console.WriteLine($"İkinci Kutu elemanları; {string.Join(",", ikinciKutuBoyutlari).Pastel(Color.DarkGreen)}");
                int yukseklik = ikinciKutuBoyutlari.Max();
                int taban = ikinciKutuBoyutlari.Count();
                //Console.WriteLine($"İkinci Kutu elemanı: {string.Join(",", ikinciKutuBoyutlari).Pastel(Color.Green)} Alanı {(yukseklik * taban).ToString().Pastel(Color.AliceBlue)}");
                return yukseklik * taban;
            }
            else
            {
                return 0;
            }
        }
    }
}
