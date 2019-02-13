# OOP Order Automation
MCBU software engineering is the first project of object-oriented programming.

                                             MANİSA CELAL BAYAR ÜNİVERSİTESİ
	
                      HASAN FERDİ TURGUTLU TEKNOLOJİ FAKÜLTESİ 1.DÖNEM PROJE ÖDEVİ RAPORU 2018-2019



PROJE EKİBİ
1. Bahar YILMAZ-   172802013
2. Berkan ŞAŞMAZ-   182803002
3. Mustafa Taha SOYDAN- 162805003
4. Zişan KARSATAR- 172802058





İÇİNDEKİLER
1. Kapak………………………………………………………….1
2. İçindekiler…………………………………………………2
3. Ödevin Amacı.………………………………………….3
4. Ödevin Kapsamı ………….…………………………3
5. UML Sınıf Diyagramı.…..…….…………………4-5
6. Ekran Görüntüleri………………………………….5-8
7. Önemli Kod Parçaları……………………………9-12
8. Youtube Linki…………………………………………..12
9. Yararlanılan Kaynaklar………………………..12

                                                SİPARİŞ OTOMASYONU
#Ödevin Amacı:
Geliştirdiğimiz otomasyon günümüzde sıklıkla kullanılan internet alışverişinde olduğu gibi ürün alıp, ödeme yapmayı kolaylaştırmak için oluşturulmuştur. Yönetici ekranı sayesinde stoklara ürün ekleme, güncelleme ve çıkartma işlemleri de otomasyonumuzda bulunan özelliklerden. Oluşturduğumuz otomasyona ait detaylı bilgileri aşağıda açıklanmıştır.

#Ödevin Kapsamı:
	1.	Kullanılan platform, dil ve kütüphaneler: Visual Studio2017 Community Common7 IDE, C#, .Net
	2.	Geliştirdiğimiz otomasyon kapsamında ilk olarak müşteri ve yönetici girişi için şifre, kullanıcı adı gibi bilgileri textlerde (CustomerLogin.txt, AdminLogin.txt) tuttuk. Giriş işleminin güvenilir olması için bilgiler doğru girilene kadar ana ekrana erişilemiyor. Doğru giriş yapıldıktan sonra textte tuttuğumuz ürünlerimizi (ItemData.txt) önce diziye aktardık sonra ürün ID numaralarına göre litstte sıralayarak, ilgili sınıflara dağıttık. Listenin her elemanında ürüne ve ait bilgiler (ürün ID, ürün adı, ürün adedi, ürün fiyatı, ürün ağırlığı ve ürün açıklaması) bulunmaktadır. Müşterin sipariş verirken ürün ekranında ve ödeme yapıldıktan sonra yetkili firma formunda bu bilgilere detaylı bir şeklide ulaşabiliriz.








#UML Sınıf Diyagramı:

UML diyagramında kullanılan sınıfların detaylı açıklamaları ve işlevleri şunlardır:
	1.	YetkiliFirma Sınıfı: Bu sınıfta ürün ekleme, çıkartma, ürün stok güncelleme yapmak için metotlar kullanılmıştır. Ve ürünlerimiz ItemData.txt çekilip listeye burada aktarılmıştır.
	2.	Musteri Sınfı: Bu sınıfta MüşteriID, Adres ve AdSoyad değişkenleri tanımlanmıştır. 
	3.	Urun Sınıfı: Bu sınıfta ürünlere ait alınması gereken değişkenler tanımlanmıştır. Ayrıca fiyat ve urun ağırlıkları hesaplamak için kullanılan metotları bu sınıfın içindedir.
	4.	Siparis Sınfı: Bu sınıfta SiparisDetay sınıfı ile aggregation ilişki kurulmuştur. Siparişlerimiz sipariş detay sınıfına burada aktarılmıştır. Toplam ağırlık, vergi tutarı, kargo ücreti ve en sonunda toplam tutar hesaplanması için kullanılan metotlar bu sınıfımızdadır.
	5.	SiparisDetay Sınıfı: Bu sınıfta Vergi ve Tutar değişkenlerimizi tanımlıyoruz. AraToplam metodu ile vergiye KDV eklenmiş halini hesaplıyoruz. CalcWeight metodun da ise ürün ağırlığını alıyoruz.
	6.	Odeme Sınıfı: Abstract class olan bu sınıfımızda OdemeMiktarı değişkenini tanımladık ve UcretOde metodu oluşturduk. 
	7.	CekleOdeme Sınıfı: Bu sınıfımız Odeme sınıfından kalıtım almıştır. Burada Isim ve BankID değişkenlerini tanımladık. Bankadan işlemin yapıldığına dair onay alma metodu oluşturduk ve ödenen miktarla ilgili tutarı gönderen UcretOde fonksiyonumuzu override ederek tutarı gönderdik.
	8.	KrediKartıylaOdeme Sınıfı: Bu sınıf Odeme sınıfından kalıtım almıştır. KartNo, Tip, SonKullanmaTarihi değişkenlerimizi tanımladık. Burada da ödeme işleminin yapıldığına dair onay gönderen metot oluşturuldu ve ödenen miktarla ilgili tutarı gönderen UcretOde fonksiyonumuzu override ederek tutar gönderildi.
	9.	NakitOdeme Sınıfı: Bu sınıfta Odeme sınıfından kalıtım almıştır. Burada da ödeme işleminin yapıldığına dair onay alan metot oluşturuldu ve ödenen miktarla ilgili tutarı gönderen UcretOde fonksiyonumuzu override ederek tutar gönderilirken nakit ödeme yaptığı için otomasyonumuz tarafından tutarın %10 olacak şekilde indirim tutarımıza tanımlanmıştır.

#Ekran Görüntüleri:
1. Giriş Ekranı: Müşteri veya yönetici için gerekli bilgilerin girilmesi halinde ilgili formlar açılacaktır. Burada otomasyona giriş yapıyoruz.


2. ANA EKRAN: Müşteri için giriş yapılması halinde karşımıza çıkan Mdi child olarak şekillendirdiğimiz form.


3. ÜRÜN SEÇME, SİPARİŞ VERME EKRANI: Müşterimizin ürün ve adedini seçmesi için oluşturduğumuz ekran. Burada ürünü en fazla stoklarda bulunan miktar kadar seçebilir.  


4. SEPET EKRANI: Ürün seçimi yapıldıktan sonra sepete ekle butonumuz ile karşımıza açılan formdur. Burada istenirse alışverişe devam edilebilir veya ödeme işlemine geçiş yapılabilir. 


5. ÖDEME EKRANI: Bu ekranda istediğimiz tip ödemeyi seçerek ödeme işlemini tamamlayabiliriz. Ödeme yapmaktan vazgeçen müşterilerimiz için Sipariş iptal butonu ile sipariş iptal edilir.

6. YETKİLİ FİRMA: ÜRÜN EKLEME-ÇIKARTMA-GÜNCELLEME EKRANI: Bu ekranımızda ise yönetici olarak giriş yaptığımızda karşımıza çıkmaktadır. Ürünlerimizin stoktaki son durumları görülmektedir. Yönetici olarak ürün güncelleyip, ekleme ve çıkartma işlemlerini yapabiliyoruz.

7. YETKİLİ FİRMA: VERİLEN SİPARİŞLERİN LİSTESİNİ GÖRÜNTÜLEME EKRANI: Yetkili firmamızın bir diğer ekranında ise müşterilerimizin otomasyonumuz üzerinden aldığı ürünlerin adedini alış tarihini vb. örnekleri görebiliyoruz. 





#Önemli Kod Parçaları
Bu parçada sepetimize ürün ekleme kısmı gerçekleştirilmiştir.


Ödeme için onay alındıktan sonra girilmiş olan verilerimizle sipariş detayı oluşturuluyor ve sepette görüntülenmek üzere sepet listesine aktarılıyor. Daha sonra sipariş listesinden bu verileri çekiyoruz.




ListBox’tan seçilen ürünün stok miktarını ComboBox’lara ekliyoruz.

StreamReader sınıfının nesnesini türettiyoruz. Aynı zamanda çekilen veriyi alfabemize uygun hale getiriyoruz. Dosyanın içinde ki verileri çekip temp değişkenine atıyoruz. Temp içinde ki verileri her bir boşluk gördüğünde components dizisine atıyacak şekilde ayarladık.


Müşteri giriş yaptığında yetkili formu gözükmemesi için geriye boolean değer döndürdük. 

Temp içinde ki verileri her bir boşluk gördüğünde components dizisine atıyacak. Listbox' ta daha sonra yazdırmak için components dizisinin içindeki verilerin bazılarını \t ile ayırarak dataArray değişkenine atıyoruz. Listbox' tan yazdırlan veriyi \t ile ayırmıştık,şimdi ise kullanıcının seçtiği veriyi \t ayırıyoruz.
Temp içinde ki verileri her bir boşluk gördüğünde components dizisine atıyacak şekilde ayarlıyoruz.



#Youtube Linki
https://youtu.be/LxXsTPVMaeM

#Yararlanılan Kaynaklar
	1.	https://www.youtube.com/channel/UCeTERIXq5FWhTkblkVW_0Nw
	2.	C# 7.0 Sefer Algan
	3.	https://stackoverflow.com/	


