using KutuSorusu;
using Pastel;
using System.Drawing;

Kutu kutu = new Kutu();
KeyValuePair<string, int> sonuc;

int[] birinciSoru = { 3, 2, 4 };
Console.WriteLine($"{"1.".Pastel(Color.Coral)} Sorudaki {string.Join(",", birinciSoru).Pastel(Color.Orange)} boyutları için gerekli alan hesaplanıyor.");
sonuc = await kutu.AlaniniHesapla(birinciSoru);
Console.WriteLine($"{"1.".Pastel(Color.Coral)} Soru İçin En Uygun Kullanilan Alan:{sonuc.Value.ToString().Pastel(Color.FromArgb(255, 0, 0)).PastelBg("#34eb49")} Boyutlar:{sonuc.Key.Pastel(Color.Coral)}\n");


int[] ikinciSoru = { 5, 3, 2, 4 };
Console.WriteLine($"{"2.".Pastel(Color.Aquamarine)} Sorudaki {string.Join(",", ikinciSoru).Pastel(Color.Orange)} boyutları için gerekli alan hesaplanıyor.");
sonuc = await kutu.AlaniniHesapla(ikinciSoru);
Console.WriteLine($"{"2.".Pastel(Color.Aquamarine)} Soru İçin En Uygun Kullanilan Alan:{sonuc.Value.ToString().Pastel(Color.FromArgb(255, 0, 0)).PastelBg("#34eb49")} Boyutlar:{sonuc.Key.Pastel(Color.Aquamarine)}\n");

int[] ucuncuSoru = { 5, 4, 5, 2, 1 };
Console.WriteLine($"{"3.".Pastel(Color.MediumPurple)} Sorudaki {string.Join(",", ucuncuSoru).Pastel(Color.Orange)} boyutları için gerekli alan hesaplanıyor.");
sonuc = await kutu.AlaniniHesapla(ucuncuSoru);
Console.WriteLine($"{"3.".Pastel(Color.MediumPurple)} Soru İçin En Uygun Kullanilan Alan:{sonuc.Value.ToString().Pastel(Color.FromArgb(255, 0, 0)).PastelBg("#34eb49")} Boyutlar:{sonuc.Key.Pastel(Color.MediumPurple)}\n");

int[] dorduncuSoru = { 5, 5, 5, 2, 5, 5, 5 };
Console.WriteLine($"{"4.".Pastel(Color.PeachPuff)} Sorudaki {string.Join(",", dorduncuSoru).Pastel(Color.Orange)} boyutları için gerekli alan hesaplanıyor.");
sonuc = await kutu.AlaniniHesapla(dorduncuSoru);
Console.WriteLine($"{"4.".Pastel(Color.PeachPuff)} Soru İçin En Uygun Kullanilan Alan:{sonuc.Value.ToString().Pastel(Color.FromArgb(255, 0, 0)).PastelBg("#34eb49")} Boyutlar:{sonuc.Key.Pastel(Color.PeachPuff)}\n");

int[] besinciSoru = { 1, 1, 6, 5, 5, 5 };
Console.WriteLine($"{"5.".Pastel(Color.Plum)} Sorudaki {string.Join(",", besinciSoru).Pastel(Color.Orange)} boyutları için gerekli alan hesaplanıyor.");
sonuc = await kutu.AlaniniHesapla(besinciSoru);
Console.WriteLine($"{"5.".Pastel(Color.Plum)} Soru İçin En Uygun Kullanilan Alan:{sonuc.Value.ToString().Pastel(Color.FromArgb(255, 0, 0)).PastelBg("#34eb49")} Boyutlar: {sonuc.Key.Pastel(Color.Plum)} \n");


Console.Write($"Uygulamadan çıkmak için {"<ENTER>".Pastel(Color.FromArgb(165, 229, 250))} tuşuna basın.");
while (Console.ReadKey().Key != ConsoleKey.Enter) { }