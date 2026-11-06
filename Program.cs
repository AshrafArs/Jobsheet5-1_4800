int biayaAdministrasi = 2000;
Console.WriteLine("Masukkan Nama Pelanggan");
string namaPelanggan = Console.ReadLine();

Console.WriteLine("Masukkan jumlah halaman yang dicetak");
int jumlahHalaman = int.Parse(Console.ReadLine());

Console.WriteLine("Masukkan Harga cetak per halaman");
int hargaCetak = int.Parse(Console.ReadLine());

int subtotal = jumlahHalaman * hargaCetak;
int totalBiaya = subtotal + biayaAdministrasi;

Console.WriteLine("Nama Pelanggan: " + namaPelanggan);
Console.WriteLine("Jumlah Halaman: " + jumlahHalaman);
Console.WriteLine("Harga Cetak per Halaman: " + hargaCetak);
Console.WriteLine("Biaya Administrasi: " + biayaAdministrasi);
Console.WriteLine("Subtotal: " + subtotal);
Console.WriteLine("Total Biaya Cetak: " + totalBiaya);
