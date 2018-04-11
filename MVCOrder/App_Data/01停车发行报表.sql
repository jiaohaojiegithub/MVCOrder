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
	--select (CASE a.sex when '0' then '男' else '女' end) as '性别',a.cust_name as '姓名',a.cust_nick as '编号',a.mobile as '电话号码',b.card_no as '卡号' from customer a,card_make b where a.cust_no=b.cust_no
	select (CASE a.sex when '0' then '男' else '女' end) as '性别', a.*,b.card_no,b.foregift,b.balance,b.validdt,b.status,b.operator,b.createdt from customer a,card_make b where a.cust_no=b.cust_no
END
GO

--01停车发行报表
