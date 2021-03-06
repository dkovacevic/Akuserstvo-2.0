/*
   Saturday, November 03, 20127:19:09 PM
   User: 
   Server: .\sqlexpress
   Database: Parovic
   Application: 
*/

/* To prevent any potential data loss issues, you should review this script in detail before running it outside the context of the database designer.*/
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.Pregled ADD
	Profil71 float(53) NULL,
	Profil61 float(53) NULL,
	Profil51 float(53) NULL,
	Profil41 float(53) NULL,
	Profil31 float(53) NULL,
	Profil21 float(53) NULL,
	Profil11 float(53) NULL,
	Profil01 float(53) NULL,
	Profil72 float(53) NULL,
	Profil62 float(53) NULL,
	Profil52 float(53) NULL,
	Profil42 float(53) NULL,
	Profil32 float(53) NULL,
	Profil22 float(53) NULL,
	Profil12 float(53) NULL,
	Profil02 float(53) NULL
GO
COMMIT
