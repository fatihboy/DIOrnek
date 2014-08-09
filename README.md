Dependecy Injection Örneği
=========

Bu solution, blog'umda yer alan [Dependency Injection makalelerinde](http://www.enterprisecoding.com/post/tag/dependency-injection) paylaştığım konuların daha kolay anlaşılması için örnek olması adına paylaşılmaktadır.

Solution 3 ana bileşenden oluşmaktadır;

  - **Ana uygulama** : İçerisinde ana iş mantıklarını barındırmayan, sadece akışın yapıldığı çalıştırılabilir.
  - **Domain** : Yalı haliyle uygulamanın simüle ettiği gerçek hatayın modeli. Sadece tanım ve POCO sınıflarını barındırır.
  - **Implemantasyon** : İçerisinde uygulamanın çalışan iş mantığının bulunduğu bileşendir. iş mantıkları arasında tanımlı sıkı bir akış burada yer almamaktadır.

Proje örnek olması adına iki implemantasyona sahiptir. Bu implamantasyonlardan ilki mocking yolu ile iş mantığının simüle edildiği *Enterprisecoding.DIOrnek.Domain.Moq* projesi, diğeri ise gerçek implemantasyonu barındıran *Enterprisecoding.DIOrnek.Domain.Imp* projesidir. Her iki projede derlendiğinde ana uygulama debug klasörüne kopyalanacak şekilde yapılandırılmıştır.

Bu iki implemantasyondan hangisinin kullanılacağına *Enterprisecoding.DIOrnek*  projesi *Program.cs* dosyasına müdahale ederek karar verebilirsiniz. Varsayılan olan Moq implemantasyonunu kullanacak şekilde yapılandırılmıştır. Bunun değiştirmek için;

```
kernel.Load("DIOrnek.Domain.Moq.dll"); // Domain implemantasyonu için bu satırı commentleyip alttaki coment'i açınız. 
//kernel.Load("DIOrnek.Domain.Imp.dll"); 
```

satırlarını aşağıdaki şekilde değiştirmelisiniz;

```
//kernel.Load("DIOrnek.Domain.Moq.dll"); // Domain implemantasyonu için bu satırı commentleyip alttaki coment'i açınız. 
kernel.Load("DIOrnek.Domain.Imp.dll"); 
```

##Detaylı Bilgi
Solution hakkında detaylı bilgiyi [Enterprisecoding.com](http://enterprisecoding.com) adresindeki kişisel blog'umda yer alan [Profesyonel Projelerimizde Dependency Injection Yaklaşımı](http://www.enterprisecoding.com/post/profesyonel-projelerimizde-dependency-injection-yaklasimi) başlıklı makalemde bulabilirsiniz. 
