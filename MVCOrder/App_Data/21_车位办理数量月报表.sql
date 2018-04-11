--21.车位办理数量月报表							
							
--日期	私家车	月租车	特免车	优惠车	员工车	其他车	小计
--select 
--CONVERT(varchar(50),a.月份)+'月' 月份,
--(case when a.期卡 is not null then a.期卡 else 0 end) 私家车,
--(case when a.时段卡 is not null then a.时段卡 else 0 end) 月租车,
--(case when a.免费卡 is not null then a.免费卡 else 0 end) 特免车,
--(case when a.贵宾卡 is not null then a.贵宾卡 else 0 end) 优惠车,
--(case when a.授权卡 is not null then a.授权卡 else 0 end) 员工车,
--(case when a.储值卡 is not null then a.储值卡 else 0 end)+(case when a.临时卡 is not null then a.临时卡 else 0 end)+(case when a.临免卡 is not null then a.临免卡 else 0 end) 其他车,
--(case when a.储值卡 is not null then a.储值卡 else 0 end)+(case when a.临时卡 is not null then a.临时卡 else 0 end)+(case when a.临免卡 is not null then a.临免卡 else 0 end)
--+(case when a.授权卡 is not null then a.授权卡 else 0 end)+ (case when a.贵宾卡 is not null then a.贵宾卡 else 0 end)+(case when a.免费卡 is not null then a.免费卡 else 0 end)
--+(case when a.时段卡 is not null then a.时段卡 else 0 end)+(case when a.期卡 is not null then a.期卡 else 0 end) 小计
-- from
--(
--select * from
--(
--select DATEPART(MONTH,b.createdt) 月份,c.card_tname 类型,COUNT(c.card_tname) 数量
----(case when b.createdt is not null then CONVERT(varchar(100),b.createdt,121) else '' end) 日期,
--from park_card_make a 
--left join card_make b on a.cust_no=b.cust_no
--left join card_type c on c.card_tid=a.card_type
----where DATEPART(YEAR,b.createdt)=2017--日期
--group by c.card_tname,DATEPART(MONTH,b.createdt)
--) a
--pivot(
--sum(a.数量) for a.类型 in (期卡,授权卡,操作员卡,临时卡,时段卡,免费卡,临免卡,贵宾卡,储值卡,一卡通)
--) b
--) a
--===================方案一=============================================
create procedure 车位办理数量月报表
@日期 datetime
as
begin
select 
CONVERT(varchar(50),a.月份)+'月' 月份,
(case when a.期卡 is not null then a.期卡 else 0 end) 私家车,
(case when a.时段卡 is not null then a.时段卡 else 0 end) 月租车,
(case when a.临免卡 is not null then a.临免卡 else 0 end) 特免车,
(case when a.贵宾卡 is not null then a.贵宾卡 else 0 end) 优惠车,
(case when a.免费卡 is not null then a.免费卡 else 0 end) 员工车,
(case when a.储值卡 is not null then a.储值卡 else 0 end)+(case when a.临时卡 is not null then a.临时卡 else 0 end)+(case when a.时段卡 is not null then a.时段卡 else 0 end) 其他车,

(case when a.储值卡 is not null then a.储值卡 else 0 end)+(case when a.临时卡 is not null then a.临时卡 else 0 end)+(case when a.临免卡 is not null then a.临免卡 else 0 end)
+ (case when a.贵宾卡 is not null then a.贵宾卡 else 0 end)+(case when a.免费卡 is not null then a.免费卡 else 0 end)
+(case when a.时段卡 is not null then a.时段卡 else 0 end)+(case when a.期卡 is not null then a.期卡 else 0 end) 小计
 from
(
select * from
(
select DATEPART(MONTH,b.createdt) 月份,c.card_tname 类型,COUNT(c.card_tname) 数量
--(case when b.createdt is not null then CONVERT(varchar(100),b.createdt,121) else '' end) 日期,
from park_card_make a 
left join card_make b on a.cust_no=b.cust_no
left join card_type c on c.card_tid=a.card_type
where DATEPART(YEAR,b.createdt)=DATEPART(YEAR,@日期)--日期
group by c.card_tname,DATEPART(MONTH,b.createdt)
) a
pivot(
sum(a.数量) for a.类型 in (期卡,授权卡,操作员卡,临时卡,时段卡,免费卡,临免卡,贵宾卡,储值卡,一卡通)
) b
) a
--=====================方案二====================================================
--select * from
--(
--select CONVERT(varchar(100),DATEPART(MONTH,b.createdt))+'月' 月份,c.card_tname 类型,COUNT(c.card_tname) 数量
----(case when b.createdt is not null then CONVERT(varchar(100),b.createdt,121) else '' end) 日期,
--from park_card_make a 
--left join card_make b on a.cust_no=b.cust_no
--left join card_type c on c.card_tid=a.card_type
----where DATEPART(YEAR,b.createdt)=2017--日期
--group by c.card_tname,DATEPART(MONTH,b.createdt)
--) a
--pivot(
--sum(a.数量) for a.类型 in (期卡,授权卡,操作员卡,临时卡,时段卡,免费卡,临免卡,贵宾卡,储值卡,一卡通)
--) b
--=======================方案三===========================
--
--select CONVERT(varchar(100),DATEPART(MONTH,b.createdt))+'月' 月份,c.card_tname 类型,COUNT(c.card_tname) 数量
----(case when b.createdt is not null then CONVERT(varchar(100),b.createdt,121) else '' end) 日期,
--from park_card_make a 
--left join card_make b on a.cust_no=b.cust_no
--left join card_type c on c.card_tid=a.card_type
----where DATEPART(YEAR,b.createdt)=2017--日期
--group by c.card_tname,DATEPART(MONTH,b.createdt)
end


--select * from card_type

