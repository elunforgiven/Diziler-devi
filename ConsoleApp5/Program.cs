using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Kaç öğrenci kayıt etmek istiyorsunuz?");
                byte mevcut = byte.Parse(Console.ReadLine());
                string[,] ogrenciler = new string[mevcut + 1, 6];
                for (int i = 0; i < ogrenciler.GetLength(0) - 1; i++)
                {
                    for (int j = 0; j < ogrenciler.GetLength(1); j++)
                    {
                        float ort;
                        if (j == 0)
                        {
                            Console.WriteLine("Ad Giriniz");
                            ogrenciler[i, j] = Console.ReadLine();
                        }
                        else if (j == 1)
                        {
                            Console.WriteLine("Soyad Giriniz");
                            ogrenciler[i, j] = Console.ReadLine();
                        }
                        else if (j == 2)
                        {
                            Console.WriteLine("Vize Giriniz");
                            ogrenciler[i, j] = Console.ReadLine();
                        }
                        else if (j == 3)
                        {
                            Console.WriteLine("Final Giriniz");
                            ogrenciler[i, j] = Console.ReadLine();
                        }
                        else if (j == 4)
                        {
                            float vize = Convert.ToSingle(ogrenciler[i, 2].ToString());
                            float final = Convert.ToSingle(ogrenciler[i, 3].ToString());
                            ort = Convert.ToSingle(vize * 0.4 + final * 0.6);
                            ogrenciler[i, j] = ort.ToString();
                        }
                        else
                        {
                            if (Convert.ToSingle(ogrenciler[i, j - 1].ToString()) >= 90)
                            {
                                ogrenciler[i, j] = "Geçti  AA";
                            }

                            else if (Convert.ToSingle(ogrenciler[i, j - 1].ToString()) >= 80)
                            {
                                ogrenciler[i, j] = "Geçti  BA";
                            }
                            else if (Convert.ToSingle(ogrenciler[i, j - 1].ToString()) >= 70)
                            {
                                ogrenciler[i, j] = "Geçti  BB";
                            }
                            else if (Convert.ToSingle(ogrenciler[i, j - 1].ToString()) >= 60)
                            {
                                ogrenciler[i, j] = "Geçti  CB";
                            }
                            else if (Convert.ToSingle(ogrenciler[i, j - 1].ToString()) >= 53)
                            {
                                ogrenciler[i, j] = "Geçti  CC";
                            }
                            else if (Convert.ToSingle(ogrenciler[i, j - 1].ToString()) >= 48)
                            {
                                ogrenciler[i, j] = "Şartlı Başarılı veya Başarısız  DC";
                            }
                            else if (Convert.ToSingle(ogrenciler[i, j - 1].ToString()) >= 40)
                            {
                                ogrenciler[i, j] = "Şartlı Başarılı veya Başarısız DD";
                            }
                            else if (Convert.ToSingle(ogrenciler[i, j - 1].ToString()) >= 30)
                            {
                                ogrenciler[i, j] = "Şartlı Başarılı veya Başarısız  FD";
                            }
                            else
                            {
                                ogrenciler[i, j] = "Kaldı FF";
                            }

                        }
                    }

                }



                for (int i = 0; i < ogrenciler.GetLength(0) - 1; i++)
                {
                    for (int j = 0; j < ogrenciler.GetLength(1); j++)
                    {

                        Console.Write(ogrenciler[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.ReadKey();
            }
        }
    }
    }

