USE [ykt474]
GO

/****** Object:  StoredProcedure [dbo].[EwmCard]    Script Date: 2018-03-26 17:27:14 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [dbo].[EwmCard]
	
AS
BEGIN
	--select (CASE a.sex when '0' then '��' else 'Ů' end) as '�Ա�',a.cust_name as '����',a.cust_nick as '���',a.mobile as '�绰����',b.card_no as '����' from customer a,card_make b where a.cust_no=b.cust_no
	select (CASE a.sex when '0' then '��' else 'Ů' end) as '�Ա�', a.*,b.card_no,b.foregift,b.balance,b.validdt,b.status,b.operator,b.createdt from customer a,card_make b where a.cust_no=b.cust_no
END
GO

--01ͣ�����б���
