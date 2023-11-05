## BlogProject

**.Net Framework'ün 4.7.2 sürümü ile MVC5 kullanılanarak ve DBFirst yaklaşımıyla bir blog projesi geliştirilmiştir.**

## KURULUM
**Bilgisayarınızda istediğiniz herhangi bir editör ve veri tabanı yönetim sisteminin bulunması gerekmektedir. Ben Visual Studio 2022 ve Sql Server 2019'u kullandım.**

## SİTE VE ÖZELLİKLERİ
**Proje temel olarak bir blog sayfasıdır. Çeşitli yazarlar, ilgi alanlarında bloglar yazarak kullanıcılarla paylaşırlar. Kullanıcılar bu blogları okuyabilir, yorumlayabilir ve yazara geri dönüşte bulunabilir. Yazarlar, farklı kategori başlıkları altında blog yazmaktadırlar. Üst yönetici olarak tanımlanan admin, yazarları atamak, düzenlemek ve genel olarak site ile ilgili özelliklerden sorumludur.**
  
---


- **Girişte bizi aşağıdaki sayfa karşılamaktadır. Burada, tüm bloglar vardır. Ayrıca sayfalandırma yapısı kullanılmıştır. En altta ise çeşitli yerlere ulaşılabilen bir footer alanı vardır.**


![Ana Sayfa](https://github.com/BerreYesilyurt/BlogProject/assets/77548130/7f41b6c3-8c66-4dd9-b642-5622b8c5ab61)


![Ana sayfa 2](https://github.com/BerreYesilyurt/BlogProject/assets/77548130/d0a65abf-b249-4c72-9caf-03d2dc9b063b)


![Ana sayfa 3](https://github.com/BerreYesilyurt/BlogProject/assets/77548130/b128eeb4-84e7-4247-8a04-87844c2a1c69)


![Ana sayfa 4](https://github.com/BerreYesilyurt/BlogProject/assets/77548130/7e0a4652-24ea-4829-875e-b9d1b19aedea)


- **En üstte bulunan navbar kısmında, kullanıcının hangi kategori dikkatini çekiyorsa o kategorideki blogları okuması için bir kolaylık yapılması amaçlanmıştır.**

![Seyahat](https://github.com/BerreYesilyurt/BlogProject/assets/77548130/e9120f2a-90d4-4651-81c8-ea8a9532b176)

![Teknoloji](https://github.com/BerreYesilyurt/BlogProject/assets/77548130/dcfd91eb-08da-4ddf-b606-ab1aa34c929b)

![Yazılım](https://github.com/BerreYesilyurt/BlogProject/assets/77548130/77875d55-1fd6-423d-8ca3-6a2636461edd)

- **Eğer bir blogun üstüne tıklarsanız o blog ve detayları gelmektedir. Blog yazısı, blogu hangi yazarın yazdığı, bu blogu yazan yazarın diğer blogları da gözükmektedir. Ayrıca o bloga yapılan yorumlar ve okuyan kişinin de yorum yapabilmesi için bir alan bulunmaktadır.**

![Pardus](https://github.com/BerreYesilyurt/BlogProject/assets/77548130/1dabadce-4699-4c76-9c4f-0563b676765b)

![Pardus 2](https://github.com/BerreYesilyurt/BlogProject/assets/77548130/462bd7b9-d82c-404d-b037-edb90a9baf22)

![Pardus 3](https://github.com/BerreYesilyurt/BlogProject/assets/77548130/6d6cdb5c-c58c-47ed-aea1-20a6e9eb5fde)

![Pardus 4](https://github.com/BerreYesilyurt/BlogProject/assets/77548130/31a45190-ec42-4732-a521-5abec4d5d6c3)



- **"Hakkımızda" kısmında, bu sayfa ve yazarlar hakkında kısaca bilgi edinilmesi amaçlanıyor.**

  
![Hakkımızda](https://github.com/BerreYesilyurt/BlogProject/assets/77548130/18fae530-d5a5-4d79-9049-fea271759cac)

![Hakkımızda 2](https://github.com/BerreYesilyurt/BlogProject/assets/77548130/4f0a89a7-89a1-4491-8d7d-c0801a6361d0)

![Hakkımızda 3](https://github.com/BerreYesilyurt/BlogProject/assets/77548130/cc75313e-800c-4e16-b319-4da8f62d1949)

- **"İletişim" kısmında ise kullanıcı soruları ya da mesajlarının alınması amaçlanmıştır.**

![İletişim](https://github.com/BerreYesilyurt/BlogProject/assets/77548130/503f9845-a532-4d8d-945d-1a174230c3f1)


- **Eğer bir yazarsanız ve sisteme giriş yapmak istiyorsanız, aşağıdaki ekran sizi karşılamaktadır. Ayrıca bu sayfada, altta bulunan bağlantıdan admin girişi de yapılabilmektedir.**

![Yazar Girişi](https://github.com/BerreYesilyurt/BlogProject/assets/77548130/0a06e30d-4aa1-4617-b128-e0b46ad29aba)


- **Yazar doğru mail ve şifre kombinasyonuyla sisteme giriş yaparsa, aşağıdaki ekran onu karşılamaktadır. Burada bloglarını görebilir, düzenleyebilir ya da silebilir. Profil bilgilerini düzenleyebilir.**


![Yazar 1](https://github.com/BerreYesilyurt/BlogProject/assets/77548130/13e0b600-a59e-40cf-8856-926f1223ccc0)

![Yazar 2](https://github.com/BerreYesilyurt/BlogProject/assets/77548130/338a469a-a860-40e8-b3fe-f282ddc814c2)


- **Admin giriş sayfası aşağıdaki gibidir.**

![Admin Giriş](https://github.com/BerreYesilyurt/BlogProject/assets/77548130/6b22efb6-9f4b-4a3f-98a6-9445a5e2e219)

- **Admin şu işlemleri yapabilir:**


1- Blogları görebilir. Bloglara ait olan yorumları ve o blogun detaylarını görebilir. Blogları silip, düzenleyebilir. Yeni bir blog ekleyebilir.
![Admin 1](https://github.com/BerreYesilyurt/BlogProject/assets/77548130/d52c53aa-6b36-4250-8714-db9b938dd5af)

2- Yazarları görüntüleyip hakkındaki bilgilere erişebilir. 
![Admin 2](https://github.com/BerreYesilyurt/BlogProject/assets/77548130/bd280410-39e9-4cf0-9c39-2e343b83ac2c)

3- Yayınlanan ve kaldırılan yorumları görebilir. Eğer admin onaylamazsa o yorum yayınlanamaz. 
![Admin 3](https://github.com/BerreYesilyurt/BlogProject/assets/77548130/118e40cf-9d82-475d-8e3a-81893e69f4f3)

4- Kategorileri düzenleyip o kategorideki tüm bloglara ulaşabilir. 
![Admin 4](https://github.com/BerreYesilyurt/BlogProject/assets/77548130/11f496fd-1884-4bfa-b2bd-0e1b614309f3)

5- "Hakkımızda" bilgilerini düzenleyebilir.
![Admin 5](https://github.com/BerreYesilyurt/BlogProject/assets/77548130/aaadb746-3424-4879-a3b2-517393cafaed)

6- Kendisine gelen mesajları görebilir.
![Admin 6](https://github.com/BerreYesilyurt/BlogProject/assets/77548130/d7c381a1-b704-4835-b581-45313552e55c)

![Admin 7](https://github.com/BerreYesilyurt/BlogProject/assets/77548130/8ae5a692-5f8c-46e8-b2b9-7d6b06709c25)







