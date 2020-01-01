# Containerization

    docker run -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=qwe123**' -e 'MSSQL_PID=Express' -p 1445:1433 --name=catalogdb microsoft/mssql-server-linux:latest

    docker run -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=Qwe123**' -p 1433:1433 --name catalogdb -d mcr.microsoft.com/mssql/server:2017-latest

    MS Sql Server Configuration Managerdan Network settingsden TCP/IP bağlantısını ve Listen All seçeneğini kontrol et. SSMS'de host adına localhost yerine Docker Machine IP'sini ver 
    ex: 192.168.99.100/1433 

    yazdığımız api için bir docker image oluşturmamız gerekiyor. Bu image içerisinde bağlı olduğu sql server çalıştırmak gibi komutlar bulunduruyor port mapping vs var. Bu imagi ile docker kurulu herhangi bir pc'de apiyi ayağa kaldırabiliyoruz. Api projesinde bir dockerfile açıp gerekli komutları yazıyor.

    docker pull microsoft/aspnetcore:2.2.0
    docker pull microsoft/aspnetcore-build:2.2.0

    docker build -t shoes/catalog . apinin pathinde powershell acıp bu komut ile dockerfile'ı build etmiş oluyoruz. Sondaki nokta host makinedeki current directoryde build et anlamına geliyor. -t ile de isim vermiş oluyoruz.

    docker images komutu ile yeni oluşturduğumuz image'ı görebiliriz.

    docker run shoes/catalog diyerek bu image'ı çalıştırabiliriz veya bir docker-compose.yml yapabiliriz.

    docker-compose bi kaç servisi bi araya getiren bi image filedır.

    docker rmi shoes/catalog docker-compose kullanacağımız için bir önceki image'ı bu şekilde silebiliyoruz.

    docker system prune ile kullanılmayan imageları silebiliyoruz.

    docker-compose build eğer docker-compose'da yenilikler varsa build yapmamız gerekir.

    docker-compose up mssqlserver

    docker-compose up catalog

    docker-compose down containerları durdurur.

    192.168.99.100:8080 catalog dockerdan aldığı bu ip'de çalışıyor. localhosttaki port mapping işlemi yapılmalı.
