USE [CodeAuthority]
GO
/****** Object:  StoredProcedure [dbo].[InsertUpdateNewUser]    Script Date: 11/11/2017 11:42:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Detrick DeBurr	
-- Create date: November 11, 2017	
-- Description:	This stored procedure accepts minimal data about a contact. It writes it to the contact table if it doesn't exist (i.e. unique email address)
-- If the email address exists then it updates the users information.

-- =============================================
Create PROCEDURE [dbo].[InsertUpdateNewContact]
@Firstname varchar(40),
@Lastname varchar(40),
@Email varchar(40),
@Telephone varchar(255),
@BestTimeToCall varchar(50)
AS
BEGIN
	SET NOCOUNT ON;
	Declare @iUserId int;
merge	Contacts as contacts
using	(select	@Email as Email,
				@Firstname as Firstname,
				@Lastname as Lastname,
				@Telephone as Telephone,
				@BestTimeToCall as BestTimeToCall
				) as temp
		on	contacts.Email = temp.Email 
		when matched then
		update set 	contacts.Firstname = temp.Firstname,
					contacts.Lastname = temp.Lastname,
					contacts.Email = temp.Email,
					contacts.Telephone = temp.Telephone,
					contacts.BestTimeToCall = temp.BestTimeToCall
		when not matched then
		insert (Firstname,Lastname,Email,Telephone,BestTimeToCall) 
		values(temp.Firstname,temp.Lastname,temp.Email,temp.Telephone,temp.BestTimeToCall);
END

