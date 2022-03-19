// See https://aka.ms/new-console-template for more information

// vs de yukarıda Debug yazan kısım kullandığımız mod. Release mod ise son kullanıcının kullanacağı mod.

int x = 10; // <-- Solda koyulan kırmızı nokta breakpoint. Kodu çalıştırdığında buraya kadar çalışıp durur. Bu sayede hata takibi yapmamız kolaylaşır.

// Kodu satır satır çalıştırma F10

x *= 2;

Console.WriteLine(x);

// Adım adım çalıştırırken değişkenin üzerine geldiğinde onu pinleyip değerinin nasıl değiştiğini adım adım görebiliyosun.

// yine f10la adım adım bakarken sağ klik --> quick watchtan belli bişeyi takip edebilirsin. Reevaluate yapıp aşağıdan valuye çift tıklayınca değerini değiştirip devam ettirebilirsin
// pinleme kısmından da değeri değiştirebiliyosun
// quick watchın ordan add watch dersen de aşağıda pencere açar oradan izlersin

