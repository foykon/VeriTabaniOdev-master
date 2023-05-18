SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

SET default_tablespace = '';

CREATE TABLE sema.alici (
    "aliciNo" smallint NOT NULL,
    "aliciAdi" character varying(20) NOT NULL,
    "aliciSoyadi" CHARACTER VARYING(20),
    "adresIl" CHARACTER VARYING(25),
    "kartNo" INTEGER
);
ALTER TABLE sema.alici OWNER TO postgres;

CREATE TABLE sema.satici (
    "saticiNo" smallint NOT NULL,
    "saticiAdi" character varying(20) NOT NULL,
    "saticiSoyadi" character varying(20) NOT NULL,
    "maas" INTEGER,
    "cinsiyet" CHARACTER VARYING(5)
);
ALTER TABLE sema.satici OWNER TO postgres;

CREATE TABLE sema.personel (
    "personelNo" smallint NOT NULL,
    "personelAdi" character varying(20) NOT NULL,
    "personelSoyadi" character varying(20) NOT NULL,
    "tür" character varying(20) NOT NULL,
    "cinsiyet" CHARACTER VARYING(5)
);
ALTER TABLE sema.personel OWNER TO postgres;

CREATE TABLE sema.kitap (
    "kitapNo" smallint NOT NULL,
    "kitapAdi" character varying(30) NOT NULL,
    "tür" character varying(30) NOT NULL,
    "sayfa" INTEGER,
    "yazar" character varying(50)
);
ALTER TABLE sema.kitap OWNER TO postgres;

CREATE TABLE sema.yazar (
    "yazarNo" smallint NOT NULL,
    "yazarAdi" character varying(20) NOT NULL,
    "yazarSoyadi" character varying(20) NOT NULL,
    "tür" character varying(20) ,
    "dogumYili" INTEGER
);
ALTER TABLE sema.yazar OWNER TO postgres;

CREATE TABLE sema.firma (
    "firmaNo" smallint NOT NULL,
    "firmaAdi" character varying(20) NOT NULL,
    "il" character varying(20) NOT NULL,
    "ilce" character varying(20) NOT NULL
);
ALTER TABLE sema.firma OWNER TO postgres;

CREATE TABLE sema.yayinevi (
    "yayineviNo" smallint NOT NULL,
    "yayineviAdi" character varying(30) NOT NULL,
    "il" character varying(25) NOT NULL,
    "ilce" character varying(25) NOT NULL
);
ALTER TABLE sema.yayinevi OWNER TO postgres;

CREATE TABLE sema.nakliyeci (
    "nakliyeciNo" smallint NOT NULL,
    "nakliyeciAdi" character varying(20) NOT NULL
);
ALTER TABLE sema.nakliyeci OWNER TO postgres;

CREATE TABLE sema.il (
    "ilKodu" integer NOT NULL,
    "ilAdi" character varying(20) NOT NULL,
    constraint "uk_ilAdi" unique ("ilAdi")
);
ALTER TABLE sema.il OWNER TO postgres;

CREATE TABLE sema.ilce (
    "ilceKodu" integer NOT NULL,
    "ilceAdi" character varying(30) NOT NULL,
    constraint "uk_ilceAdi" unique ("ilceAdi")
);
ALTER TABLE sema.ilce OWNER TO postgres;

--alıcı girdileri--
INSERT INTO sema.alici VALUES (1, 'Beytullah', 'Fil','Trabzon',25874165);
INSERT INTO sema.alici VALUES (2, 'Hasan', 'Boruzan','Sakarya',44567891);
INSERT INTO sema.alici VALUES (3, 'Fatih', 'Coşkun','Giresun',25844795);
INSERT INTO sema.alici VALUES (4, 'Sena', 'Bal','Bolu',61143453);
INSERT INTO sema.alici VALUES (5, 'Ezgi', 'Morgil','Rize',94562874);
INSERT INTO sema.alici VALUES (6, 'Sümeyye', 'Sağlam','Erzincan',87415965);
INSERT INTO sema.alici VALUES (7, 'Ahmet', 'Yüksek','İstanbul',45467789);
INSERT INTO sema.alici VALUES (8, 'Doğan', 'Katak','Kocaeli',45578912);
INSERT INTO sema.alici VALUES (9, 'Nuri', 'Bilgin','İzmir',15935745);
INSERT INTO sema.alici VALUES (10, 'Muhammet', 'Çilingir','Samsun',48951254);
INSERT INTO sema.alici VALUES (11, 'Fatih', 'Bozdemir','Sivas',96325874);
INSERT INTO sema.alici VALUES (12, 'Tahsin', 'Doğan','Iğdır',25745694);
INSERT INTO sema.alici VALUES (13, 'Mirkan', 'Özdemir','Çankırı',42587463);

--Satıcı girdileri--
INSERT INTO sema.satici VALUES (1, 'Mehmet', 'Kutlu',5500,'Erkek');
INSERT INTO sema.satici VALUES (2, 'Merve', 'Kalkan',6000,'Kadın');
INSERT INTO sema.satici VALUES (3, 'Sinem', 'Göksu',5700,'Kadın' );
INSERT INTO sema.satici VALUES (4, 'Cansu', 'Melek',5700,'Kadın');
INSERT INTO sema.satici VALUES (5, 'Berk', 'Ozden',5650,'Erkek');

--Personel Girdileri--
INSERT INTO sema.personel VALUES (1, 'Ahmet', 'Öztürk','Temizlikçi','Erkek');
INSERT INTO sema.personel VALUES (2, 'Beyza', 'Turan','Bakım','Kadın');
INSERT INTO sema.personel VALUES (3, 'Mahmut', 'Çoban','Düzenleme','Erkek');
INSERT INTO sema.personel VALUES (4, 'Melisa', 'Sayılı','Paketleme','Kadın');
INSERT INTO sema.personel VALUES (5, 'Eren', 'Kılıç','Depocu' ,'Erkek');
INSERT INTO sema.personel VALUES (6, 'Mert', 'Ekin','Depocu' ,'Erkek');

--Yazar Girdileri--
insert into sema.yazar values(1,'Oğuz','Atay','Roman',1934);
insert into sema.yazar values(2,'Orhan','Kemal','Roman',1914);
insert into sema.yazar values(3,'Carlos Maria','Dominguez','Öykü',1955);
insert into sema.yazar values(4,'Franz','Kafka','Öykü',1883);
insert into sema.yazar values(5,'Fyodor','Dostoyevski','Roman',1821);
insert into sema.yazar values(6,'Victor','Hugo','Roman',1802);
insert into sema.yazar values(7,'Falih Rıfkı','Atay','Anı',1894);
insert into sema.yazar values(8,'Yakup Kadri','Karaosmanoğlu','Roman',1889);
insert into sema.yazar values(9,'Sabahattin','Ali','Öykü',1907);
insert into sema.yazar values(10,'Lev','Tolstoy','Roman',1828);
insert into sema.yazar values(11,'Honoré','Balzac','Roman',1799);
insert into sema.yazar values(12,'Jane','Austen','Roman',1775);
insert into sema.yazar values(13,'Dante','Alighieri','Şiir',1265);
insert into sema.yazar values(14,'William','Shakespeare','Tiyatro',1564);
insert into sema.yazar values(15,'Johann Wolfgang Von','Goethe','Mektup',1749);
insert into sema.yazar values(16,'John','Steinbeck','Roman',1902);
insert into sema.yazar values(17,'Ivan','Turgenyev','Roman',1818);
insert into sema.yazar values(18,'Maksim','Gorki','Roman',1868);
insert into sema.yazar values(19,'Charles','Dickens','Roman',1812);
insert into sema.yazar values(20,'Sylvia','Nasar','Biyografi',1947);
insert into sema.yazar values(21,'Ayşe','Kulin','Biyografi',1941);
insert into sema.yazar values(22,'Mustafa Kemal','Atatürk','Söylev',1881);
insert into sema.yazar values(23,'David','Burns','Kişisel Gelişim',1942);
insert into sema.yazar values(24,'Hector','Garcia','Kişisel Gelişim',1981);
insert into sema.yazar values(25,'Halil','Cibran','Şiir',1883);
insert into sema.yazar values(26,'Muallim','Naci','Anı',1849);
insert into sema.yazar values(27,'Ahmet','Rasim','Anı',1864);
insert into sema.yazar values(28,'Aziz','Nesin','Mizah',1915);
insert into sema.yazar values(29,'Virginia','Woolf','Deneme',1882);
insert into sema.yazar values(31,'John','Verdon','Polisiye',1942);
insert into sema.yazar values(32,'Alexandre','Dumas','Roman',1802);
insert into sema.yazar values(33,'Gabriel García','Márquez','Roman',1927);
insert into sema.yazar values(34,'Harper','Lee','Roman',1926);
insert into sema.yazar values(35,'Albert','Camus','Roman',1913);
insert into sema.yazar values(36,'Recep','Bilginer','Tiyatro',1922);
insert into sema.yazar values(37,'Ziya','Paşa','Anı',1825);
insert into sema.yazar values(38,'Aldous','Huxley','Bilim Kurgu',1894);
insert into sema.yazar values(39,'Jules','Verne','Bilim Kurgu',1828);
insert into sema.yazar values(40,'Anthony','Bourdain','Yemek Kitabı',1956);
insert into sema.yazar values(41,'Namık','Kemal','Tiyatro',1840);
insert into sema.yazar values(42,'Tomris','Uyar','Öykü',1941);
insert into sema.yazar values(43,'George','Orwell','Roman',1903);
insert into sema.yazar values(44,'Yuval Noah','Harari','Tarih',1976);

--Kitap Girdileri--

INSERT INTO sema.kitap VALUES (1,'Korkuyu Beklerken', 'Öykü', 202, 'Oğuz Atay');
INSERT INTO sema.kitap VALUES (2, 'Önce Ekmek', 'Öykü', 110, 'Orhan Kemal');
INSERT INTO sema.kitap VALUES (3, 'Kağıt Ev', 'Öykü', 94, 'Carlos Maria Dominguez');
INSERT INTO sema.kitap VALUES (4, 'Dönüşüm', 'Öykü', 80, 'Franz Kafka');
INSERT INTO sema.kitap VALUES (5, 'Suç ve Ceza', 'Roman', 705, 'Fyodor Dostoyevski');
INSERT INTO sema.kitap VALUES (6, 'Sefiller', 'Roman', 1462, 'Victor Hugo');
INSERT INTO sema.kitap VALUES (7, 'Çankaya', 'Anı', 686, 'Falih Rıfkı Atay');
INSERT INTO sema.kitap VALUES (8, 'Ankara', 'Roman', 252, 'Yakup Kadri Karaosmanoğlu');
INSERT INTO sema.kitap VALUES (9, 'Beyaz Diş', 'Roman',175,'Jack London');
INSERT INTO sema.kitap VALUES (10,'Değirmen', 'Öykü', 137, 'Sabahattin Ali');
INSERT INTO sema.kitap VALUES (11,'Korkuyu Beklerken', 'Öykü', 202, 'Oğuz Atay');
INSERT INTO sema.kitap VALUES (12, 'Anna Karenina', 'Roman', 864, 'Lev Tolstoy');
INSERT INTO sema.kitap VALUES (13, 'Vadideki Zambak', 'Roman', 336, 'Honoré de Balzac');
INSERT INTO sema.kitap VALUES (14, 'Notre Dame Kamburu', 'Roman', 408, 'Victor Hugo');
INSERT INTO sema.kitap VALUES (15, 'Aşk ve Gurur', 'Roman', 444, 'Jane Austen');
INSERT INTO sema.kitap VALUES (16, 'İlahi Komedya', 'Şiir', 838, 'Dante Alighieri');
INSERT INTO sema.kitap VALUES (17, 'Romeo ve Juliet', 'Tiyatro', 133, 'William Shakespeare');
INSERT INTO sema.kitap VALUES (18, 'Werther Acıları', 'Mektup', 164, 'Johann Wolfgang Von Goethe');
INSERT INTO sema.kitap VALUES (19, 'Gazap Üzümleri', 'Roman', 464, 'John Steinbeck');
INSERT INTO sema.kitap VALUES (20, 'Babalar ve Oğullar', 'Roman', 264, 'Ivan Turgenyev');
INSERT INTO sema.kitap VALUES (21, 'Ana', 'Roman', 432, 'Maksim Gorki');
INSERT INTO sema.kitap VALUES (22, 'İki Şehrin Hikayesi', 'Roman', 464, 'Charles Dickens');
INSERT INTO sema.kitap VALUES (23, 'Yeraltından Notlar', 'Roman', 160, 'Fyodor Dostoyevski');
INSERT INTO sema.kitap VALUES (24, 'Savaş ve Barış', 'Roman', 1225, 'Lev Tolstoy');
INSERT INTO sema.kitap VALUES (25, 'Akıl Oyunları', 'Biyografi', 460, 'Sylvia Nasar');
INSERT INTO sema.kitap VALUES (26, 'Türkan', 'Biyografi', 344, 'Ayşe Kulin');
INSERT INTO sema.kitap VALUES (27, 'Nutuk', 'Söylev', 544, 'Mustafa Kemal Atatürk');
INSERT INTO sema.kitap VALUES (28, 'İyi Hissetmek', 'Kişisel Gelişim', 632, 'David Burns');
INSERT INTO sema.kitap VALUES (29, 'Ikigai', 'Kişisel Gelişim', 176, 'Hector Garcia');
INSERT INTO sema.kitap VALUES (30, 'Nebi', 'Şiir', 107, 'Halil Cibran');
INSERT INTO sema.kitap VALUES (31, 'Ömerin Çocukluğu', 'Anı', 64, 'Muallim Naci');
INSERT INTO sema.kitap VALUES (32, 'Falaka', 'Anı', 104, 'Ahmet Rasim');
INSERT INTO sema.kitap VALUES (33, 'Zübük', 'Mizah', 280, 'Aziz Nesin');
INSERT INTO sema.kitap VALUES (34, 'Kırk Yıl', 'Anı', 968, 'Halit Ziya Uşaklıgil');
INSERT INTO sema.kitap VALUES (35, 'Aklından Sayı Tut', 'Polisiye', 475, 'John Verdon');
INSERT INTO sema.kitap VALUES (36, 'Üç Silahşörler', 'Roman', 136, 'Alexandre Dumas');
INSERT INTO sema.kitap VALUES (37, 'Yüzyıllık Yalnızlık', 'Roman', 461, 'Gabriel García Márquez');
INSERT INTO sema.kitap VALUES (38, 'Kendine Ait Bir Oda', 'Deneme', 172, 'Virginia Woolf');
INSERT INTO sema.kitap VALUES (39, 'Bülbülü Öldürmek', 'Roman', 281, 'Harper Lee');
INSERT INTO sema.kitap VALUES (40, 'Yabancı', 'Roman', 123, 'Albert Camus');
INSERT INTO sema.kitap VALUES (41, 'Büyük Umutlar', 'Roman', 544, 'Charles Dickens');
INSERT INTO sema.kitap VALUES (45, 'İsyancılar', 'Tiyatro', 170, 'Recep Bilginer' );
INSERT INTO sema.kitap VALUES (46, 'Saray ve Ötesi', 'Anı', 120, 'Halit Ziya Uşaklıgil');
INSERT INTO sema.kitap VALUES (47, 'Defter-i Amâl', 'Anı', 136, 'Ziya Paşa');
INSERT INTO sema.kitap VALUES (48, 'Cesur Yeni Dünya', 'Bilim Kurgu' ,332, 'Aldous Huxley');
INSERT INTO sema.kitap VALUES (49, 'Aya Seyahat', 'Bilim Kurgu', 208, 'Jules Verne');
INSERT INTO sema.kitap VALUES (50, 'Mutfak Sırları', 'Yemek Kitabı', 320, 'Anthony Bourdain');
INSERT INTO sema.kitap VALUES (51, 'Vatan Yahut Silistre', 'Tiyatro', 112, 'Namık Kemal');
INSERT INTO sema.kitap VALUES (52, 'İpek ve Bakır', 'Öykü', 96, 'Tomris Uyar');
INSERT INTO sema.kitap VALUES (53, '1984', 'Roman', 328, 'George Orwell');
INSERT INTO sema.kitap VALUES (54, 'Homo Deus', 'Tarih', 448, 'Yuval Noah Harari');







--İlçe Girdileri--
INSERT INTO sema.ilce VALUES (1104,'Seyhan');
INSERT INTO sema.ilce VALUES (1105,'Adıyaman Merkez');
INSERT INTO sema.ilce VALUES (1108,'Afyon Merkez');
INSERT INTO sema.ilce VALUES (1111,'Ağrı Merkez');
INSERT INTO sema.ilce VALUES (1134,'Amasya Merkez');
INSERT INTO sema.ilce VALUES (1130,'Altındağ');
INSERT INTO sema.ilce VALUES (1512,'Kaş');
INSERT INTO sema.ilce VALUES (1395,'Hopa');
INSERT INTO sema.ilce VALUES (1542,'Nazilli');
INSERT INTO sema.ilce VALUES (1161,'Ayvalık');
INSERT INTO sema.ilce VALUES (1192,'Bilecik Merkez');
INSERT INTO sema.ilce VALUES (1193,'Bingöl Merkez');
INSERT INTO sema.ilce VALUES (1106,'Ahlat');
INSERT INTO sema.ilce VALUES (1364,'Göynük');
INSERT INTO sema.ilce VALUES (1109,'Ağlasun');
INSERT INTO sema.ilce VALUES (1420,'İznik');
INSERT INTO sema.ilce VALUES (1190,'Biga');
INSERT INTO sema.ilce VALUES (1248,'Çerkeş');
INSERT INTO sema.ilce VALUES (2054,'Sancaktepe');
INSERT INTO sema.ilce VALUES (1327,'Fatih');
INSERT INTO sema.ilce VALUES (1203,'Bornova');
INSERT INTO sema.ilce VALUES (1338,'Gebze');
INSERT INTO sema.ilce VALUES (1241,'Çayeli');
INSERT INTO sema.ilce VALUES (1525,'Mesudiye');
INSERT INTO sema.ilce VALUES (2069,'Arifiye');
INSERT INTO sema.ilce VALUES (1676,'Terme');
INSERT INTO sema.ilce VALUES (1407,'İmranlı');
INSERT INTO sema.ilce VALUES (1258,'Çorlu');
INSERT INTO sema.ilce VALUES (1709,'Vakfıkebir');
INSERT INTO sema.ilce VALUES (1313,'Ereğli');
INSERT INTO sema.ilce VALUES (1142,'Aralık');


-- İl Girdileri--
INSERT INTO sema.il VALUES (1,'Adana');
INSERT INTO sema.il VALUES (2,'Adıyaman');
INSERT INTO sema.il VALUES (3,'Afyonkarahisar');
INSERT INTO sema.il VALUES (4,'Ağrı');
INSERT INTO sema.il VALUES (5,'Amasya');
INSERT INTO sema.il VALUES (6,'Ankara');
INSERT INTO sema.il VALUES (7,'Antalya');
INSERT INTO sema.il VALUES (8,'Artvin');
INSERT INTO sema.il VALUES (9,'Aydın');
INSERT INTO sema.il VALUES (10,'Balıkesir');
INSERT INTO sema.il VALUES (11,'Bilecik');
INSERT INTO sema.il VALUES (12,'Bingöl');
INSERT INTO sema.il VALUES (13,'Bitlis');
INSERT INTO sema.il VALUES (14,'Bolu');
INSERT INTO sema.il VALUES (15,'Burdur');
INSERT INTO sema.il VALUES (16,'Bursa');
INSERT INTO sema.il VALUES (17,'Çanakkale');
INSERT INTO sema.il VALUES (18,'Çankırı');
INSERT INTO sema.il VALUES (19,'Çorum');
INSERT INTO sema.il VALUES (20,'Denizli');
INSERT INTO sema.il VALUES (21,'Diyarbakır');
INSERT INTO sema.il VALUES (22,'Edirne');
INSERT INTO sema.il VALUES (23,'Elazığ');
INSERT INTO sema.il VALUES (24,'Erzincan');
INSERT INTO sema.il VALUES (25,'Erzurum');
INSERT INTO sema.il VALUES (26,'Eskişehir');
INSERT INTO sema.il VALUES (27,'Gaziantep');
INSERT INTO sema.il VALUES (28,'Giresun');
INSERT INTO sema.il VALUES (29,'Gümüşhane');
INSERT INTO sema.il VALUES (30,'Hakkari');
INSERT INTO sema.il VALUES (31,'Hatay');
INSERT INTO sema.il VALUES (32,'Isparta');
INSERT INTO sema.il VALUES (33,'Mersin');
INSERT INTO sema.il VALUES (34,'İstanbul');
INSERT INTO sema.il VALUES (35,'İzmir');
INSERT INTO sema.il VALUES (36,'Kars');
INSERT INTO sema.il VALUES (37,'Kastamonu');
INSERT INTO sema.il VALUES (38,'Kayseri');
INSERT INTO sema.il VALUES (39,'Kırklareli');
INSERT INTO sema.il VALUES (40,'Kırşehir');
INSERT INTO sema.il VALUES (41,'Kocaeli');
INSERT INTO sema.il VALUES (42,'Konya');
INSERT INTO sema.il VALUES (43,'Kütahya');
INSERT INTO sema.il VALUES (44,'Malatya');
INSERT INTO sema.il VALUES (45,'Manisa');
INSERT INTO sema.il VALUES (46,'Kahramanmaraş');
INSERT INTO sema.il VALUES (47,'Mardin');
INSERT INTO sema.il VALUES (48,'Muğla');
INSERT INTO sema.il VALUES (49,'Muş');
INSERT INTO sema.il VALUES (50,'Nevşehir');
INSERT INTO sema.il VALUES (51,'Niğde');
INSERT INTO sema.il VALUES (52,'Ordu');
INSERT INTO sema.il VALUES (53,'Rize');
INSERT INTO sema.il VALUES (54,'Sakarya');
INSERT INTO sema.il VALUES (55,'Samsun');
INSERT INTO sema.il VALUES (56,'Siirt');
INSERT INTO sema.il VALUES (57,'Sinop');
INSERT INTO sema.il VALUES (58,'Sivas');
INSERT INTO sema.il VALUES (59,'Tekirdağ');
INSERT INTO sema.il VALUES (60,'Tokat');
INSERT INTO sema.il VALUES (61,'Trabzon');
INSERT INTO sema.il VALUES (62,'Tunceli');
INSERT INTO sema.il VALUES (63,'Şanlıurfa');
INSERT INTO sema.il VALUES (64,'Uşak');
INSERT INTO sema.il VALUES (65,'Van');
INSERT INTO sema.il VALUES (66,'Yozgat');
INSERT INTO sema.il VALUES (67,'Zonguldak');
INSERT INTO sema.il VALUES (68,'Aksaray');
INSERT INTO sema.il VALUES (69,'Bayburt');
INSERT INTO sema.il VALUES (70,'Karaman');
INSERT INTO sema.il VALUES (71,'Kırıkkale');
INSERT INTO sema.il VALUES (72,'Batman');
INSERT INTO sema.il VALUES (73,'Şırnak');
INSERT INTO sema.il VALUES (74,'Bartın');
INSERT INTO sema.il VALUES (75,'Ardahan');
INSERT INTO sema.il VALUES (76,'Iğdır');
INSERT INTO sema.il VALUES (77,'Yalova');
INSERT INTO sema.il VALUES (78,'Karabük');
INSERT INTO sema.il VALUES (79,'Kilis');
INSERT INTO sema.il VALUES (80,'Osmaniye');
INSERT INTO sema.il VALUES (81,'Düzce');


INSERT INTO sema.yayinevi VALUES (1,'Balina Yayınları','İstanbul','Sancaktepe');
INSERT INTO sema.yayinevi VALUES (2,'İş Bankası Yayınları','İstanbul','Fatih');
INSERT INTO sema.yayinevi VALUES (3,'Kırmızı Kedi Yayın','İzmir','Bornova');
INSERT INTO sema.yayinevi VALUES (4,'Pegasus Yayınları','Sakarya','Arifiye');
INSERT INTO sema.yayinevi VALUES (5,'Serüven Kitap','Rize','Çayeli');
INSERT INTO sema.yayinevi VALUES (6,'Ütopya Yayınevi','Kocaeli','Gebze');


INSERT INTO sema.firma VALUES (1,'D&R','Bolu','Göynük');
INSERT INTO sema.firma VALUES (2,'Idefix','Antalya','Kaş');
INSERT INTO sema.firma VALUES (3,'Bkmkitap','İstanbul','Fatih');
INSERT INTO sema.firma VALUES (4,'Kitapyurdu','Trabzon','Vakfıkebir');
INSERT INTO sema.firma VALUES (5,'Pandora','Zonguldak','Ereğli');
INSERT INTO sema.firma VALUES (6,'Punto','Samsun','Terme');
INSERT INTO sema.firma VALUES (7,'KitapSepeti','Adana','Seyhan');


INSERT INTO sema.nakliyeci VALUES (1,'Aras Kargo');
INSERT INTO sema.nakliyeci VALUES (2,'Sürat Kargo');
INSERT INTO sema.nakliyeci VALUES (3,'MNG Kargo');
INSERT INTO sema.nakliyeci VALUES (4,'PTT Kargo');
INSERT INTO sema.nakliyeci VALUES (5,'Yurtiçi Kargo');
INSERT INTO sema.nakliyeci VALUES (6,'UPS Kargo');
INSERT INTO sema.nakliyeci VALUES (7,'İyi Kargo');







ALTER TABLE ONLY sema.alici
    ADD CONSTRAINT pk_alici PRIMARY KEY ("aliciNo");
    
ALTER TABLE ONLY sema.satici
    ADD CONSTRAINT pk_satici PRIMARY KEY ("saticiNo");
    
ALTER TABLE ONLY sema.personel
    ADD CONSTRAINT pk_personel PRIMARY KEY ("personelNo");
    
ALTER TABLE ONLY sema.kitap
    ADD CONSTRAINT pk_kitap PRIMARY KEY ("kitapNo");
    
ALTER TABLE ONLY sema.firma
    ADD CONSTRAINT pk_firma PRIMARY KEY ("firmaNo");
    
ALTER TABLE ONLY sema.yazar
    ADD CONSTRAINT pk_yazar PRIMARY KEY ("yazarNo");
    
ALTER TABLE ONLY sema.yayinevi
    ADD CONSTRAINT pk_yayinevi PRIMARY KEY ("yayineviNo");
    
ALTER TABLE ONLY sema.nakliyeci
    ADD CONSTRAINT pk_nakliyeci PRIMARY KEY ("nakliyeciNo");
    
ALTER TABLE ONLY sema.il
    ADD CONSTRAINT pk_il PRIMARY KEY ("ilKodu");
        
    
ALTER TABLE ONLY sema.ilce
    ADD CONSTRAINT pk_ilce PRIMARY KEY ("ilceKodu","ilceAdi");
    
ALTER TABLE ONLY sema.alici
    ADD CONSTRAINT "fk_kitap" FOREIGN KEY ("aliciNo") REFERENCES sema.kitap("kitapNo") on update cascade;
   
ALTER TABLE ONLY sema.satici
    ADD CONSTRAINT "fk_alici" FOREIGN KEY ("saticiNo") REFERENCES sema.alici("aliciNo") on update cascade;
    
ALTER TABLE ONLY sema.nakliyeci
    ADD CONSTRAINT "fk_firma" FOREIGN KEY ("nakliyeciNo") REFERENCES sema.firma("firmaNo");
    
ALTER TABLE ONLY sema.yayinevi
    ADD CONSTRAINT "fk_nakliyeci" FOREIGN KEY ("yayineviNo") REFERENCES sema.nakliyeci("nakliyeciNo");
    
ALTER TABLE ONLY sema.firma
    ADD CONSTRAINT "fk_il" FOREIGN KEY ("il") REFERENCES sema.il("ilAdi") MATCH FULL;
    
ALTER TABLE ONLY sema.yayinevi
    ADD CONSTRAINT "fk_il2" FOREIGN KEY ("il") REFERENCES sema.il("ilAdi") MATCH FULL;

ALTER TABLE ONLY sema.firma
    ADD CONSTRAINT "fk_ilce" FOREIGN KEY ("ilce") REFERENCES sema.ilce("ilceAdi") MATCH FULL;
    
ALTER TABLE ONLY sema.yayinevi
    ADD CONSTRAINT "fk_ilce2" FOREIGN KEY ("ilce") REFERENCES sema.ilce("ilceAdi") MATCH FULL;


create table sema.yazaryayinevi(
    "yazarNo" integer not null,
    "yayineviNo" integer not null,
    constraint "pk_yazaryayinevi" primary key("yazarNo","yayineviNo"),
    constraint "fk_yazarno" foreign key("yazarNo") references sema.yazar("yazarNo"),
    constraint "fk_yayinevino" foreign key("yayineviNo") references sema.yayinevi("yayineviNo")
    );
alter table sema.yazaryayinevi owner to postgres;

create table sema.kitapyazar(
    "yazarNo" integer not null,
    "kitapNo" integer not null,
    constraint "pk_yazarkitap" primary key("yazarNo","kitapNo"),
    constraint "fk_yazarno" foreign key("yazarNo") references sema.yazar("yazarNo"),
    constraint "fk_kitapno" foreign key("kitapNo") references sema.kitap("kitapNo")
    );
alter table sema.kitapyazar owner to postgres;

create table sema.firmayayinevi(
    "firmaNo" integer not null,
    "yayineviNo" integer not null,
    constraint "pk_firmayayinevi" primary key("firmaNo","yayineviNo"),
    constraint "fk_firmano" foreign key("firmaNo") references sema.firma("firmaNo"),
    constraint "fk_yayinevino" foreign key("yayineviNo") references sema.yayinevi("yayineviNo")
    );
alter table sema.firmayayinevi owner to postgres;

create table sema.nakliyepersonel(
    "nakliyeciNo" integer not null,
    "personelNo" integer not null,
    constraint "pk_nakliyepersonel" primary key("nakliyeciNo","personelNo"),
    constraint "fk_nakliyeno" foreign key("nakliyeciNo") references sema.nakliyeci("nakliyeciNo"),
    constraint "fk_personelno" foreign key("personelNo") references sema.personel("personelNo")
    );
alter table sema.nakliyepersonel owner to postgres;

create table sema.saticifirma(
    "saticiNo" integer not null,
    "firmaNo" integer not null,
    constraint "pk_saticifirma" primary key("saticiNo","firmaNo"),
    constraint "fk_saticino" foreign key("saticiNo") references sema.satici("saticiNo"),
    constraint "fk_firmano" foreign key("firmaNo") references sema.firma("firmaNo")
    );
alter table sema.saticifirma owner to postgres;

create table sema.toplamkitap(
"kitapsayisi" integer
);
insert into sema.toplamkitap (kitapsayisi) values(51)
--select count(*) from sema.kitap
--select * from sema.toplamkitap
create or replace function sema.test()
    returns trigger
    as
    $function$
begin
update sema.toplamkitap set kitapsayisi=kitapsayisi+1;
return new;
end;
$function$
language plpgsql;

create trigger testkitap
after insert
on sema.kitap
for each row
execute procedure sema.test();


create table sema.toplamyazar(
"yazarsayisi" integer
);
insert into sema.toplamyazar (yazarsayisi) values(43)
--select count(*) from sema.yazar
--select * from sema.toplamyazar
create or replace function sema.test1()
    returns trigger
    as
    $function$
begin
update sema.toplamyazar set yazarsayisi=yazarsayisi+1;
return new;
end;
$function$
language plpgsql;

create trigger testyazar
after insert
on sema.yazar
for each row
execute procedure sema.test1();

create table sema.toplamalici(
"alicisayisi" integer
);
insert into sema.toplamalici (alicisayisi) values(13)
--select count(*) from sema.alici
--select * from sema.toplamalici
create or replace function sema.test2()
    returns trigger
    as
    $function$
begin
update sema.toplamalici set alicisayisi=alicisayisi+1;
return new;
end;
$function$
language plpgsql;

create trigger testalici
after insert
on sema.alici
for each row
execute procedure sema.test2();



create table sema.toplamilce(
"ilcesayisi" integer
);
insert into sema.toplamilce (ilcesayisi) values(31)
--select count(*) from sema.ilce
--select * from sema.toplamilce
create or replace function sema.test3()
    returns trigger
    as
    $function$
begin
update sema.toplamilce set ilcesayisi=ilcesayisi+1;
return new;
end;
$function$
language plpgsql;

create trigger testilce
after insert
on sema.ilce
for each row
execute procedure sema.test3();

create function sema.kitapgetir(getir varchar)
    returns table
(
        kitapNosutun SMALLINT,
        kitapAdisutun varchar,
        kitapYazarsutun varchar
)
as
$function$
BEGIN
    return query
    SELECT
    "kitapNo",
    "kitapAdi",
    "yazar"
from sema.kitap
WHERE
    "kitapAdi" like getir;
end;
$function$
language plpgsql;
--select * from sema.kitap
--select * from sema.kitapgetir('%z%')

create function sema.simdikiyas(dogumYili integer)
returns integer
language plpgsql
as
$function$
begin
dogumYili:=2021-dogumYili;
return dogumYili;
end;
$function$;
--select "yazarNo","yazarAdi","dogumYili",sema.simdikiyas("dogumYili") from sema.yazar

create function sema.vergilimaas(maas integer)
returns integer
language plpgsql
as
$function$
begin
maas:=maas*9/10;
return maas;
end;
$function$;
--select "saticiNo","saticiAdi","saticiSoyadi","maas",sema.vergilimaas("maas") from sema.satici


create function sema.alicigetir(getir varchar)
    returns table
(
        aliciNosutun SMALLINT,
        aliciAdisutun varchar,
        aliciSoyadisutun varchar
)
as
$function$
BEGIN
    return query
    SELECT
    "aliciNo",
    "aliciAdi",
    "aliciSoyadi"
from sema.alici
WHERE
    "aliciAdi" like getir;
end;
$function$
language plpgsql;
--select * from sema.alici
--select * from sema.alicigetir('%e%')
