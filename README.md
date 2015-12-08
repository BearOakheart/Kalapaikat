# Kalapaikat Asp.net harjoitustyö

# 1. Asennus 


- Kopioi DB/DatabaseKala.txt sisältö. 
- Avaa Visual Studio 
- Avaa Object server explorer
- Tee uusi tietokanta Kala
- Tee Kala tietokantaan sql query -> Kopio DatabaseKala.txt sisältö queryyn ja päivitä tietokanta (Huom. Create Table users -> insert user -> create table favourites.) 
- Tarkista että web.config tiedostossa viitataan oikeaan databaseen. (localdb)\ProjectV12 tai Project katso object explorerista mikä on locaalin kannan nimi. (Visual Studio 2013 Projects Visual Studio 2015 ProjectsV12)


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

# 4. Ohjelman tarvitsemat / mukana tulevat tiedostot/tietokannat

- xml kansiossa fs.xml
- Images kansion kuvat ( käytetään ohjelmiston taustana yms.)
- Tietokanta tulee luoda Asennusohjeiden mukaisesti DB/DatabaseKala.txt tiedostoa apuna käyttäen. 

# 5. Tiedossa olevat ongelmat bugit sekä jatkokehitysideat

# 6. Mitä opittu, mitkä olivat suurimmat haasteet, mitä kannattaisi tutkia/opiskella lisää jne

# 7. Tekijät, vastuiden ja työmäärän jakautuminen sekä tekijöiden perusteltu ehdotus arvosanaksi
