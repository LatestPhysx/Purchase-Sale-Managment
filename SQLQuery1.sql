create database gestionAchatVente;
use gestionAchatVente;

CREATE TABLE Produits(
   ProduitID INT,
   Nom VARCHAR(250),
   Description VARCHAR(250),
   Prix float,
   QuantiteStock INT,
   PRIMARY KEY(ProduitID)
);

create table users(
	id int primary key identity(1,1),
	username varchar(250) unique,
	email varchar(250) unique,
	password varchar(250) unique
);

CREATE TABLE Clients(
   ClientID INT,
   Nom VARCHAR(250),
   Adresse VARCHAR(250),
   Telephone VARCHAR(250),
   Email VARCHAR(250),
   PRIMARY KEY(ClientID)
);

CREATE TABLE Commandes(
   CommandeID INT,
   DateCommande DATE,
   Total INT,
   ClientID INT NOT NULL,
   PRIMARY KEY(CommandeID),
   FOREIGN KEY(ClientID) REFERENCES Clients(ClientID)
);

CREATE TABLE LigneCommande(
   LigneID INT,
   Quantite INT,
   PrixUnitaire float,
   CommandeID INT NOT NULL,
   ProduitID INT NOT NULL,
   PRIMARY KEY(LigneID),
   FOREIGN KEY(CommandeID) REFERENCES Commandes(CommandeID),
   FOREIGN KEY(ProduitID) REFERENCES Produits(ProduitID)
);

select * from LigneCommande

CREATE TABLE Fournisseurs(
   FournisseurID INT,
   Nom VARCHAR(250),
   Adresse VARCHAR(250),
   Telephone VARCHAR(250),
   Email VARCHAR(250),
   PRIMARY KEY(FournisseurID)
);

CREATE TABLE Achats(
   AchatID INT,
   Quantite INT,
   PrixAchat float,
   DateAchat DATE,
   FournisseurID INT NOT NULL,
   PRIMARY KEY(AchatID),
   FOREIGN KEY(FournisseurID) REFERENCES Fournisseurs(FournisseurID)
);

CREATE TABLE AchatProduit(
   ProduitID INT,
   AchatID INT,
   PRIMARY KEY(ProduitID, AchatID),
   FOREIGN KEY(ProduitID) REFERENCES Produits(ProduitID),
   FOREIGN KEY(AchatID) REFERENCES Achats(AchatID)
);
