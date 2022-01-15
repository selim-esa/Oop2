﻿// See https://aka.ms/new-console-template for more information
//Bu konu önemli soyutlama yapıyoruz İşe girerken önemli...!!!
//Bu konu önemli soyutlama yapıyoruz İşe girerken önemli...!!!
//Bu konu önemli soyutlama yapıyoruz İşe girerken önemli...!!!

using Oop3;

IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
IKrediManager tasitKrediManager = new TasitKrediManager();
IKrediManager konutKrediManager = new KonutKrediManager();

ILoggerService dataBaseLoggerService = new DataBaseLoggerService();
ILoggerService fileLoggerService = new FileLoggerService();

BasvuruManager basvuruManager = new BasvuruManager();
basvuruManager.BasvuruYap(ihtiyacKrediManager, fileLoggerService);

List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager , tasitKrediManager };
//basvuruManager.KrediOnBilgilendirmesiYap(krediler);


//Bu konu önemli soyutlama yapıyoruz İşe girerken önemli...!!!
//Bu konu önemli soyutlama yapıyoruz İşe girerken önemli...!!!
//Bu konu önemli soyutlama yapıyoruz İşe girerken önemli...!!!

