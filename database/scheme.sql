create table Uzytkownicy(
ID_UZYTKOWNIK int constraint PK_UZYTKOWNICY primary key identity(1,1),
U_LOGIN nvarchar(50) not null,
U_HASLO nvarchar(50) not null);

create table Ksiazki(
ID_KSIAZKA int constraint PK_KSIAZKI primary key identity(1,1),
K_TYTUL text not null,
K_OPIS text not null,
K_AUTORZY text not null,
K_WYDAWNICTWO text null,
K_OPRAWA nvarchar(50) null,
K_WYMIARY nvarchar(50) null,
K_ILOSC_STRON int null,
K_ISBN nvarchar(50) null,
K_OKLADKA text null);