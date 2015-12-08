# Kalapaikat Asp.net harjoitustyö

# 1. Asennus 

- Cloonaa repo githubista / tai lataa zip 
- Kopioi DB/DatabaseKala.txt sisältö. 
- Avaa Visual Studio 
- Open Website (Kalapaikat) kansio
- Avaa SQL Server Object Explorer
- Tee uusi tietokanta Kala
- Tee Kala tietokantaan sql query -> Kopio DatabaseKala.txt sisältö queryyn ja päivitä tietokanta (Huom. Create Table users -> insert user -> create table favourites.) 
- Tarkista että web.config tiedostossa viitataan oikeaan databaseen. Esim. (localdb)\ProjectsV12 (SQL Server Object Explorer polku)


CREATE TABLE [dbo].[Users] (
    [Id]        INT          IDENTITY (1, 1) NOT NULL,
    [name]      VARCHAR (50) NOT NULL,
    [password]  VARCHAR (50) NOT NULL,
    [user_type] VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

Insert Into Kala.dbo.Users Values ('Admin','Admin','Admin')


CREATE TABLE [dbo].[Favourites] (
    [Id]         INT            IDENTITY (1, 1) NOT NULL,
    [name]       NVARCHAR (50)  NULL,
    [comments]   NVARCHAR (255) NULL,
    [spec_regs]  NVARCHAR (255) NULL,
    [county]     NVARCHAR (255) NULL,
    [public_acc] NVARCHAR (255) NULL,
    [access_own] NVARCHAR (255) NULL,
    [site_wl]    NVARCHAR (255) NULL,
    [point_x]    NVARCHAR (255) NULL,
    [point_y]    NVARCHAR (255) NULL,
	[fishspec]    NVARCHAR (255) NULL,
    [UserId]     INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([UserId]) REFERENCES [dbo].[Users] ([Id])
);

# 2. Tietoa ohjelmasta

- New Yorkin osavaltio tarjoaa ilmaista dataa osavaltion kalapaikoista.
- Ohjelma hyödyntää tätä avoita dataa ja käyttää xml kantaa, josta etsitään ja suodatetaan tietoa.
- Näyttää haetun kalapaikan kartalla, tarvittavat kalastusluvat ja tarjoaa esitteen kalapaikasta. 
- Listaa esiintyvät kalalajit kalapaikalla.
- Ohjelmasta voi lisätä kalapaikan omiin suosikkeihin, jolloin ne pysyvät kätevästi tietokannassa.

# 3. Kuvaruutukaappaukset

![MainWindow]
![FishingSpotsSearch]
![Favourites]
![More]
![Database]

[MainWindow]: http://student.labranet.jamk.fi/~G2968/Screenshots/MainWindow.JPG
[Favourites]: http://student.labranet.jamk.fi/~G2968/Screenshots/Favourites.JPG
[FishingSpotsSearch]: http://student.labranet.jamk.fi/~G2968/Screenshots/FishingSpotsSearch.JPG
[More]: http://student.labranet.jamk.fi/~G2968/Screenshots/More.JPG
[Database]: http://student.labranet.jamk.fi/~G2968/Screenshots/Database.JPG


# 4. Ohjelman tarvitsemat / mukana tulevat tiedostot/tietokannat

- xml kansiossa fs.xml
- Images kansion kuvat ( käytetään ohjelmiston taustana yms.)
- Tietokanta tulee luoda Asennusohjeiden mukaisesti DB/DatabaseKala.txt tiedostoa apuna käyttäen. 

# 5. Tiedossa olevat ongelmat bugit sekä jatkokehitysideat

- Käyttäjien hallinnointi järjestelmä jolloin Admin pystyy poistamaan ja lisäämään tai muokkaamaan käyttäjiä.
- Sisällöntuottamisjärjestelmä jolloin Admin pystyy muokkaamaan sivustoa ilman koodaamista, esimerkiksi tuottamaan tekstiä etusivulle muokaamaan otsikoita yms. 
- Omien suosikkien poistaminen tulisi tehdä.

# 6. Mitä opittu, mitkä olivat suurimmat haasteet, mitä kannattaisi tutkia/opiskella lisää jne

- Opin ainakin henkilökohtaisesti käyttämään asp.netin omia ominaisuuksia kuten master pagea webbi sivuilla, olin aikaisemminkin tehnyt suhteellisen paljon web ohjelmointia, jolloin Asp.netin ominaisuudet kiinnostivat.
- XML attributen parsiminen tuotti ongelmia, ehkä olisi ollut helpompikin keino, mutta saimme kuitenkin toimimaan.
- Uusi teknologia web sivujen tuottamiseen tuotti aluksi harmaita hiuksia, koska ajatteli hyvin pitkälle asioita php kokemuksen perusteella.

# 7. Tekijät, vastuiden ja työmäärän jakautuminen sekä tekijöiden perusteltu ehdotus arvosanaksi

### Asmo Korkiatupa

Työmäärä jakautui tasaisesti, olimme Mikon kanssa yhteydessä skypessä jatkuvasti kun työtä tehtiin. Keskityin itse ehkä enemmän ohjelman visuaaliseen puoleen ja toiminnallisuuteen, kuten masterpagen käyttöön, css javascript ja sessioiden hallintaan. Olen itse suhteellisen tyytyväinen projektiin, aikaa meni noin 40 tuntia. Eli kun ottaa huomioon, että työtä tehtiin samanaikaisesti niin koko projektiin meni n. 80 henkilötyötuntia.

Tekniikoiden haastavuuden ja käytetyiden tekniikoiden takia ehdotan arvosanaa 4. Ohjelman olisi voinut viimeistellä paremmin, mutta jälleen kerran aika loppui kesken. Viimeistelyt (suosikkien poistaminen, css, kuvarummun häivytys ominaisuus) tosin eivät olisi vieneet kauheasti aikaa. 
