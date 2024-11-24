# CivcivKacOyunProjesi
 Civciv engellerden kaciyor
# Civciv-Kac-Oyunu
 Oyunun Yapımcıları:
 Samet Dönmez 21360859008
 Rukiye Boğa 21360859056


 # Proje Oyun Adı: Civciv Kaç
Projenin Amacı: Unity uygulaması kullanarak en az 8 benzersiz aksiyonlu bir oyun
tasarlamak ve programlamak.
Projede Kullanılan Teknolojiler: Unity , Microsoft Visual Studio
![oyun_ici_goruntu](https://github.com/user-attachments/assets/16af2497-c693-4297-9e45-ebda088f959e)

# Oyunun oynanma şekli:
Programlanmış oyun son olarak şu şekilde görünüyor. Sarı civciv bizim ana karakterimizdir. Bu karakteri yer yön tuşları veya A,S,D,W tuşlarıyla yukarı, aşağı, sağa ve sola oynatabiliriz. Oyundaki amaç 3 yandan etrafı sarılı engellerden (kuşlardan ve yeşil zombiden) oluşan civcivin kaçmasını sağlamak. Ve kaçarken et şeklinde yedikçe yenisini çıkan yemeği yemesi ve skor artışı sağlanması. Skor her 10 artışta oyun biraz daha zorlaşıyor ve engellerin hızı artıyor bu şekilde civcivin engellerden kaçması zorlaşıyor. Oyun içinde belirli aralıklarla iksir şişesi çıkıyor civciv bu iksiri içerse birkaç saniyeliğine hızı artıyor. Engellerden çarpması halinde 3 hakkı var. Bu 3 hak ekranın sol üstündeki kalp şekilleriyle belirleniyor. Her engele çarpış durumunda kalplerden biri gidiyor. Tüm kalplerin gitmesi durumda oyun sonlanıyor. Civciv her yemek yediğinde, iksir şişesi içtiğinde ve engele çarptığında anlaşılması için her olaya özgü bir ses çıkartıyor. 

  # 21360859008 Samet Dönmez isimli öğrencinin aksiyonları:
Hareket sınırlandırması
Hız bonusu
Hız bonusu veren iksir ve yem prefabının oluşturulması
Engel objelerin hareketleri
Skoru ekrana yazdırma
Skorun artması ile engellerin hızının artması


  # 21360859056 Rukiye Boğa Numaralı öğrencinin aksiyonları:
Oyuncu hareket ettirme
Oyuncu engele çarptığında canı azalması ve oyunun sonlanması
Oyuncu yemek yediğinde gerçekleşenler
Hız bonusu ile oyuncu çarpıştığında oyuncunun hızlanması ve hız prefabının yok
edilmesi
Can sayısının 3 kalp ile gösterimi

# Oyun içinde kullanılan aksiyonlar:

  # 1- Hareket sınırlandırma aksiyonu:
İlk aksiyon olarak nesnenin pozisyonunu belirli bir alanda sınırlandı. Kodda yer
alan Mathf.Clamp fonksiyonu bir değeri, verilen minimum ve maksimum sınırlar
arasında tutar. Yani nesne belirtilen konumlar arasında hareket eder başka yere
ilerleyemez.
transform.position.x : Nesnenin x eksenindeki alacağı değerlerdir. Bu fonksiyon,
nesnenin X pozisyonunun bu sınırları aşmasını önler.
transform.position.y : Nesnenin y eksenindeki alacağı değerlerdir. Bu fonksiyon,
nesnenin Y pozisyonunun bu sınırları aşmasını önler.
Transform.position= clampedPosition : Nesnenin pozisyonuna atanır.Böylece
nesne, hareket ederken belirlenen sınırlar içinde kalır.
Aksiyon satırları : 52,53,54 ve 56. Satırlar.
Mych.cs dosyasının içinde yer alan hareket sınırlandırma aksiyon kodu; 
![akyison_2_Player_hareketini_sinirlandirma](https://github.com/user-attachments/assets/b1c9c892-c569-4f7c-828d-92c6688a19fe)

  # 2- Hız bonusu aksiyonu :
Bu kodun amacı oyuncunun (civciv) hızını artıran bir özellik. Civciv iksiri
içtiğinde hızlanmasını sağlayan olayın aksiyon kodudur.
Belirli bir süre boyunca hız artışı sağlanır, ardından hız normal seviyeye
geri döner.
StopAllCoroutines() : Daha önce başlatılmış olan tüm coroutines'leri
durdurur. Böylece hız bonusu üst üste yığılmaz ve yalnızca bir hız bonusu
aktif olur.
StartCoroutine(HizBonusuSuresi()) : Hız bonusunun süresini yöneten
coroutine'i başlatır.
speed*= 2 : ile mevcut hız 2 katına çıkar.
yield return new WaitForSeconds(3) : (Bekleme süresi) hız bonusunun 3
saniye boyunca etkili olması sağlanır.
Speed /=2 : hız eski değerine geri döner.
Debug mesajları : Konsola bonusun başlangıç ve bitiş durumlarını bildirir.
Aksiyon satırları : 101 , 102 , 107 , 108 , 109 ,110 ve 111 satırlar.
“Mych_cs.cs “ scriptinin içinde yer alır.
![aksiyon_5_hiz_bonusunun_olusma_Süresinin_coroutine_ile_Ayarlanması](https://github.com/user-attachments/assets/9fc7e947-82f3-4792-8621-d5e7506af235)

  # 3- Hız bonusu veren iksir ve yem prefabının oluşturulması aksiyonu
Bu iki fonksiyon, oyun içinde rastgele pozisyonlarda yeni nesneler (yem ve hız bonusu)
oluşturmak için kullanılır. Yemolustur() yemleri, HizBonusuOlustur() ise hız bonuslarını
sahnede rastgele yerlerde oluşturur.
Yemolustur() fonksiyonu için:
Random.Range(-8.361f,8.3561f): Bu komut, rastgeleSayix için -8.3561 ile 8.3561 arasında bir
değer seçer. Aynı şey rastgeleSayiy için de yapılır. Bu, yemin oyun ekranındaki rastgele bir
noktada oluşturulmasını sağlar.
Vector2 newPosition = new Vector2(rastgeleSayix, rastgeleSayiy);: Yukarıda oluşturduğumuz
rastgele X ve Y koordinatları ile yeni bir 2D vektör (position) oluşturuyoruz. Bu oyun alanındaki
pozisyonu belirleyecek.
Instantiate(yemPrefab, newPosition, Quaternion.identity); : Bu komut, yemPrefab nesnesini
yeni oluşturduğumuz rastgele pozisyonda (newPosition) ve dönüş açısı (Quaternion.identity)
olmadan sahnede yaratır. Instantiate, bir prefab'ı kopyalayarak sahnede yeni bir nesne
oluşturur.
HizBonusuOlustur() Fonksiyonu:
Random.Range(-8.3561f, 8.3561f) ve Random.Range(-4.5f, 4.5f): Aynı şekilde, rastgeleX ve
rastgeleY değerleri için rastgele koordinatlar belirliyoruz.
Vector2 yeniPozisyon = new Vector2(rastgeleX, rastgeleY);: Rastgele X ve Y değerleriyle yeni
bir 2D pozisyon oluşturuyoruz.
if(oyunuDurdur == false): Eğer oyunuDurdur değişkeni false (oyun durdurulmamış) ise,
aşağıdaki kod çalışır. Bu kontrol, hız bonusunun sadece oyun durdurulmadığında
oluşturulmasını sağlar.
Instantiate(hizBonusPrefab, yeniPozisyon, Quaternion.identity);: Eğer oyun
durdurulmamışsa, hizBonusPrefab nesnesi rastgele bir pozisyonda
sahnede yaratılır. Bu da hız bonusu nesnesinin oyun içinde rastgele bir yerde belirli olmasını
sağlar.
Aksiyon satırları : 83,91 ve 92. Satırlar.Yem ve hız bonusu oluşturmak
 “Manager_cs.cs “ scriptinin içinde yer alır. 
![aksiyon_6_hiz_bonusu_iksiri_prefabi_ve_yem_prefabinin_olusturulmasi](https://github.com/user-attachments/assets/ca5f2f27-f06a-4054-9ace-a8b0943dffb2)

 # 4- Engel objelerin hareket aksiyonları :
Her üç kod da engellerin sahnede belirli sınırlar arasında hareket etmesini sağlar.
Scriptler = “Engel1_cs.cs” ,”Engel2_cs.cs” ve “Engel3_cs.cs”
Genel Yapı (Her Üç Kod İçin)
1- Manager Referansı:
 Manager_cs manager;: Oyunun genel durumunu kontrol eden Manager_cs tipindeki bir nesne. Bu
nesne, oyun duraklatıldığında engellerin hareket etmemesini sağlar.
2- Hız (speed):
public float speed = 1.0f;: Engel hareket hızını belirleyen bir değişken.
3- Yön Değişkenleri:
bool goRight;: Engel sağa mı hareket ediyor? Bu değişken sağa hareketi kontrol eder.
bool goUp;: Engel yukarı mı hareket ediyor? Bu değişken yukarı hareketi kontrol eder.
4- Start() Fonksiyonu:
manager = FindObjectOfType<Manager_cs>();: Manager_cs tipinde bir nesne bulunur ve
manager değişkenine atanır.
 Engel nesnesinin başlangıç pozisyonu transform.position ile belirlenir.
# 5- Update() Fonksiyonu:
if(manager.oyunuDurdur == false): Eğer oyun durdurulmamışsa, engellerin hareketine devam
edilir.
transform.Translate() komutu ile engel hareket
ettirilir. 

  Birinci kod( Engel_1_cs):
 Bu kod, bir engelin sadece sağa ve sola hareket
etmesini sağlar.
 Engel x ekseninde hareket eder ve sağa hareket
ederken 7.5'e, sola hareket ederken-7.79'a ulaşınca
yön değiştirir.
Aksiyon kod satırı: 30. ve 34. satırlar. Sola ve sağa hareket.
 İkinci Kod (Engel_2_cs):
Bu kod, bir engelin hem sağa-sola hem de yukarı-aşağı
hareket etmesini sağlar.
X ekseninde: Engel -2.0 ile -5.86 arasındaki sınırlar
arasında sağa ve sola hareket eder.
Y ekseninde: Engel, -4.3 ile -1.0 arasında yukarı ve
aşağı hareket eder
Aksiyon kod satırı: 31, 35 , 49 ve 53. satırlar. Sola ,
sağa , yukarı ve aşağı hareket.
  Üçüncü Kod (Engel_3_cs):
Bu kod da sağa-sola ve yukarı-aşağı hareketi sağlar, ancak hareket sınırları farklıdır.
X ekseninde: Engel 2.0 ile 8.0 arasındaki sınırlar arasında sağa ve sola hareket eder.
Y ekseninde: Engel, -4.0 ile 1.0 arasında yukarı ve aşağı hareket eder.
Aksiyon kod satırı: 31, 35 , 49 ve 53. satırlar. Sola , sağa , yukarı ve aşağı hareket.
![engel_1_objesinin_hareketi](https://github.com/user-attachments/assets/be93a048-70da-4c45-93d5-c0e76f7c2424)
![engel_2_objesinin_hareketi](https://github.com/user-attachments/assets/4c5cb88b-81ea-46d8-90c8-44e539b8c178)
![engel_3_objesinin_hareketi](https://github.com/user-attachments/assets/e9260cda-a13d-4af6-8090-55e221ced5c9)

  # 6- Skoru ekrana yazdırma aksiyonu :
Civciv engellerden kaçıp yemek yedikçe skoru artar. Aşağıdaki kodları bu skorun
artması,güncellenmesi ve ekrana yazdırılmasını sağlar.
Script = “Manager_cs.cs”
Aksiyon satırları= 69 , 70 , 71, 97
public void Score():
score++ ;: Skor değerini 1 artırır.
Debug.Log("Skor: " + score); : Güncel skoru Unity'nin konsol penceresine yazdırır.
SkoruGuncelle(); : Skoru ekranda güncelleyen başka bir metodu çağırır. 
![skor_arttikca_skoruguncelle_fonksiyonunun_cagirilmasi](https://github.com/user-attachments/assets/62f26ec6-abc4-4c0b-a010-a2a2e61c1e06)

Skoru ekranda göstermek için kullanılan TextMeshPro nesnesine bir referanstır. Unity Inspector penceresinde
atanır; 
![skor_yazısı_degiskeni](https://github.com/user-attachments/assets/9a2a29c1-b176-4c9e-aed7-0ffd03246542)

public void SkoruGuncelle():
Skor metnini güncelleyerek ekranda gösterir.
scoreText.text = "Skor: " + score;: Unity'deki bir TextMeshProUGUI bileşenine, güncel skoru yazdırır
![skoruguncelle_fonksiyonu](https://github.com/user-attachments/assets/fbca3d51-2650-46fc-afd0-756e56c997cf)

  # 7- Skorun artması ile engellerin hızının artması aksiyonu :
Skor arttıkça engellerin hızını kademeli olarak artırmak. Skor 10’a ulaşınca hız 2.0f, skor 20’ye ulaşınca hız 3.0f
olur. Böylece oyuncunun karşılaştığı zorluk derecesi artar.
Update metodu, her karede çalıştığı için sürekli olarak skoru kontrol eder ve skor belirli eşik değerlerine
ulaştığında engellerin hızını değiştirir.
 if blokları:
Skor aralıklarını kontrol eder (score >= 10 && score < 20 gibi).
Her aralıkta, engellerin hızlarını artırır.
Hız Değişikliği:
engel_1_Cs.speed, engel_2_Cs.speed, ve engel_3_Cs.speed değerlerini değiştirerek engellerin hızını
artırır.
 Örneğin, skor 10 ile 20 arasında olduğunda hız 2.0f, skor 20 ile 30 arasında olduğunda hız 3.0f olur.
Script = “Manager_cs.cs”
Aksiyon satırları = 37, 38 , 39 , 42 ,43 ,44 ,47 ,48 ,49 ,52 ,53 ,54
![aksiyon_11_skorun_artmasi_ile_engellerin_hizinin_artmasi](https://github.com/user-attachments/assets/fe05d7da-c732-4b2f-aaf3-cb7252a6db3a)

  # 8- Oyuncu hareket ettirme aksiyonu:
Kod, oyuncunun klavye girdilerine (yatay ve dikey eksen) bağlı olarak ekrandaki pozisyonunu değiştirir.
Kullanıcı, ok tuşlarını veya WASD tuşlarını kullanarak nesneyi hareket ettirir.
float horizontal = Input.GetAxis("Horizontal"); :Kullanıcının klavyeden sol/sağ tuşları (örneğin, A/D veya
Sol/Yön Tuşları) ile yaptığı girdiyi alır.
transform.Translate(Vector2.right * horizontal * speed * Time.deltaTime); :Yatay eksende (sağa veya sola)
hareket eder.Hareket hızı, speed ile belirlenir. Time.deltaTime, hareketin kare başına değil zamana göre
yapılmasını sağlar
float vertical = Input.GetAxis("Vertical"); :Kullanıcının klavyeden yukarı/aşağı tuşları (örneğin, W/S veya
Yukarı/Aşağı Yön Tuşları) ile yaptığı girdiyi alır.
transform.Translate(Vector2.up * vertical * speed * Time.deltaTime); :Dikey eksende (yukarı veya aşağı)
hareket eder.
Script =” Mych_cs.cs”
Aksiyon satırları = 47, 50 
![aksiyon_1_Player_hareket_ettirme](https://github.com/user-attachments/assets/907022f8-fb96-408c-878e-f28f5de9fa4b)

  # 9- Oyuncu engele çarptığında canı azalması ve oyunun sonlanması aksiyonu :
Oyuncu bir engele çarptığında 3 canından biri azalır ve tüm canı bittiğinde oyunu sonlanır.
if bloğu, çarpışan nesnenin bir engel olup olmadığını kontrol eder. Eğer öyleyse, oyuncunun canını azaltır
ve can bitince oyunu durdurur.
if (other.CompareTag("Engel")) :Çarpışma olayında, çarpışılan nesnenin etiketi "Engel" mi kontrol
edilir.Eğer "Engel" ise, aşağıdaki işlemler yapılır.
Debug.Log("yandın"); : Konsola "yandın" mesajı yazar.
can--; :Oyuncunun mevcut canını 1 azaltır.
if (can > 0):Eğer oyuncunun hala canı varsa: "Can kaybı sesi çalıyor..." mesajını konsola yazdırır.
audioSource.PlayOneShot(canKaybiSesi); : Can kaybı sesi oynatılır.
else: Eğer oyuncunun canı sıfıra ulaştıysa can kaybı sesini tekrar çalar.
manager.oyunuDurdur = true; : Oyun durdurulmuş olarak işaretlenir.
speed = 0.0f; : Oyuncunun hareket hızı sıfırlanır (durur).
Script=”Mych_cs.cs”
Aksiyon satırları = 66, 70, 75,76
![aksiyon_3_Player_engele_carptiginda_cani_1_azaltmak_can_0_ise_oyunu_durdurmak](https://github.com/user-attachments/assets/121d2106-3c55-41f9-b0de-b1a5ab699e53)

# 10- Oyuncu yemek yediğinde gerçekleşen aksiyonlar:
Bir yem nesnesi yok edildiğinde yenisini oluşturur.
İf (manager != null) : Eğer manager (oyun yöneticisi) referansı doğru atanmışsa aşağıdaki işlemleri yapar.
manager.Yemolustur() : Oyun yöneticisinin Yemolustur() metodunu çağırır. Yeni bit yem nesnesi
oluşturur.
Destroy(this.gameObject); : Yem nesnesini yok eder.
else : Eğer manager referansı atanmadıysa hata mesajı yazdırır.
Script =” Yem_cs.cs”
Aksiyon satırları = 25, 26 
![yediler_beni_fonksiyonu](https://github.com/user-attachments/assets/fb9e14d5-d038-41ec-8c28-a5682c7e1a38)
Oyuncu yem nesnesiyle çarpışınca yemek yeme sesini çalar, skoru artırır ve çarpılan yem nesnesini
yok eder ve yenisini oluşturur.
Else if : Çarpılan nesnenin etiketi “Yem ” ise aşağıdaki işlemleri yapar.
Yem_cs yem_Cs=other.GetCompenent<Yem_cs>(); : Çarpışılan nesneye ait Yem_cs bileşenini alır.
İf (yem_Cs != null ) : Eğer Tem_cs bileşeni varsa,
audioSource.PlayOneShot(yemekYemeSesi); :Yem yeme sesini çalar.
manager.Score(); :Skoru artırır.
yem_Cs.yedilerBeniYem(); :Çarpılan yem nesnesini yok eder ve yenisini oluşturur.
Else : Eğer çarpılan nesnede Yem_cs bileşeni yoksa hata mesajı yazdırır.
Script =”Mych_cs.cs”
Aksiyon satırları =85,86,87 
![aksiyon_4_Player_yeme_değdiğinde_yem_scriptindeki_yedilerbeni_fonksiyonunu_cagirma_ve_manage_scriptindeki_score_fonksiyonunu_Cagirma](https://github.com/user-attachments/assets/24e93642-291e-436b-8aca-19261b8ef07a)

# 11- Hız bonusu ile oyuncu çarpıştığında oyuncunun hızlanması ve hız prefabının yok edilmesi
aksiyonu:
Bu kod, bir güçlendiricinin ("iksir") işlevselliğini ve çarpışma sırasında neler yapılacağını kontrol eder.
OnTriggerEnter2D(Collider2D other) : Bu metod, çarpışma olaylarını algılar.other parametresi,
çarpışan nesneyi temsil eder.
 if(other.tag == "Player") :Çarpışan nesnenin etiketi "Player" (oyuncu) ise, içindeki kodlar çalıştırılır.
Mych_cs mych_Cs = other.transform.GetComponent<Mych_cs>(); :Çarpışan nesnenin (other)
oyuncuya ait bir Mych_cs bileşeni olup olmadığını kontrol eder ve referans alır.
 if(mych_Cs != null) : Eğer oyuncuda Mych_cs bileşeni mevcutsa, aşağıdaki işlemleri gerçekleştirir:
 mych_Cs.IksirIcmeSesiCal(); :İksir içme sesini çalar.
 mych_Cs.HizBonusuAktif(); : Oyuncuya hız bonusu sağlar.
Destroy(this.gameObject); :Çarpışmadan sonra iksir nesnesini sahneden kaldırır (yok eder).
Script = “Hiz_bonus_cs.cs”
Aksiyon satırları = 25, 26 , 32 
![aksiyon_7_hiz_bonusu_ile_Player_çarpıştığında_hizbonusuaktif_fonkdiyonunun_calismasi_ve_hiz_prefabinin_yok_Edilmesi](https://github.com/user-attachments/assets/c5224316-f913-41e0-916c-a638f26efae0)

# 12- Can sayısının 3 kalp ile gösterimi aksiyonu:
Bu üç sınıf (Can1_cs, Can2_cs, ve Can3_cs), oyuncunun can durumuna bağlı olarak belirli
nesneleri sahneden kaldırma veya oyunu durdurma işlevi görüyor. Her biri farklı bir can
seviyesini takip eder ve bu seviyenin altına inildiğinde belirli işlemleri gerçekleştirir.
Can1_cs
Oyuncunun canı 1'den az olduğunda oyunu durdurur ve kendisini sahneden yok eder.
Start(): Oyuncu (Mych_cs) ve oyun yönetici (Manager_cs) nesnelerini bulur ve referans alır.
Update(): Sürekli olarak oyuncunun can durumunu kontrol eder.Eğer can değeri 1'den azsa:
manager.oyunuDurdur = true;: Oyunu durdurur.
Destroy(this.gameObject);: Nesneyi sahneden kaldırır.
Script = “Can1_cs.cs”
Aksiyon satırları = 20,21 
![can_1_objesi](https://github.com/user-attachments/assets/57032a01-a416-461f-95d0-ad4560a129bd)

Can2_cs
Oyuncunun canı 2'den az olduğunda kendisini sahneden yok eder.
Start(): Oyuncu (Mych_cs) nesnesini bulur ve referans alır.
Update(): Sürekli olarak oyuncunun can durumunu kontrol eder.Eğer can değeri 2'den azsa:
Destroy(this.gameObject);: Nesneyi sahneden kaldırır.
Script=”Can2_cs.cs”
Aksiyon satırları = 18 
![can_2_objesi](https://github.com/user-attachments/assets/8d61919c-eb05-4bd6-ba13-39259d939d1a)

Oyuncunun canı 3'ten az olduğunda kendisini sahneden yok eder.
Start(): Oyuncu (Mych_cs) nesnesini bulur ve referans alır.
Update(): Sürekli olarak oyuncunun can durumunu
kontrol eder.Eğer can değeri 3'ten azsa:
Destroy(this.gameObject);: Nesneyi sahneden
kaldırır.
Script =”Can3_cs.cs”
Aksiyon satırları = 18 
![can_3_objesi](https://github.com/user-attachments/assets/402f3c98-4be5-400d-a9f3-9a0374f0e0ab)

# Proje için :
Bu proje kapsamında Unity kullanılarak temel bir 2D oyun geliştirilmiştir. Oyunda engeller,
yemler, hız bonusu ve can sistemi gibi temel oyun mekanikleri uygulanmıştır. 
 Engeller: Belirli alanlar içinde hareket eden engeller, oyuncunun hareket alanını
kısıtlayarak zorluk seviyesini artırmaktadır. Oyuncunun skoru yükseldikçe engellerin
hızları da artmaktadır.
 Yem ve Bonuslar: Yemler oyuncunun skorunu artırırken, hız bonusu geçici bir süre
boyunca oyuncuya hız kazandırmaktadır.
 Can Sistemi: Oyuncunun belirli bir can hakkı bulunmaktadır. Canlar tükendiğinde oyun
sona ermektedir.
 Skor: Oyuncunun ilerlemesi ekrandaki skor sistemi aracılığıyla takip edilmektedir. 

Bu proje, oyun geliştirme alanında Unity ve C# kullanımıyla temel mekaniklerin
uygulanmasını hedeflemiş ve bu konuda faydalı bir çalışma sunmuştur. Proje, temel oyun
yapısı oluşturma konusunda önemli bir deneyim sağlamıştır. 

# Oyunun internet linki : 
https://simmer.io/@sametdonmez/civcivkac

# Oyun Youtube da oynanış videosu :
https://www.youtube.com/watch?v=z6bXkA67oXE


