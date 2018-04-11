create procedure 入场车流量日报表
@time datetime 
as
begin
--declare @time datetime
--set @time=N'2017-08-30 07:36:48.000'
select 
a.时间,
(case when a.期卡 is not null then a.期卡 else 0 end) 私家车,
(case when a.时段卡 is not null then a.时段卡 else 0 end) 月租车,
(case when a.临时卡 is not null then a.临时卡 else 0 end) 时租车,
(case when a.临免卡 is not null then a.临免卡 else 0 end) 特免车,
(case when a.贵宾卡 is not null then a.贵宾卡 else 0 end) 优惠车,
(case when a.免费卡 is not null then a.免费卡 else 0 end) 员工车,
 (case when a.其他 is not null then a.其他 else 0 end) 其他车,
(case when a.免费卡 is not null then a.免费卡 else 0 end)+(case when a.贵宾卡 is not null then a.贵宾卡 else 0 end)+
(case when a.期卡 is not null then a.期卡 else 0 end)+
(case when a.时段卡 is not null then a.时段卡 else 0 end)+
(case when a.临时卡 is not null then a.临时卡 else 0 end)+
(case when a.临免卡 is not null then a.临免卡 else 0 end)+
(case when a.其他 is not null then a.其他 else 0 end)
 小计  
from
(
select a.* from(
select * from
(
select CONVERT(varchar(100),a.in_time,103) 时间,
(case when d.card_tname is not null then d.card_tname else '其他' end) 类型
from in_park a 
left join park_card_make c on a.card_no=c.card_no
left join card_type d on c.card_type=d.card_tid
where DATEPART(YEAR,a.in_time)=DATEPART(YEAR,@time) and  DATEPART(MONTH,a.in_time)=DATEPART(MONTH,@time) --and  DATEPART(DAY,a.in_time)=DATEPART(DAY,@time)
--order by a.in_time
) a
pivot
(
count(a.类型) for a.类型 in (期卡,授权卡,操作员卡,临时卡,时段卡,免费卡,临免卡,贵宾卡,储值卡,一卡通,其他)
) b)a
) a
end


--select DATEDIFF(HOUR,getdate(),'2017-08-30 07:36:48.000')

--时间	私家车	月租车	时租车	特免车（临免车）	优惠车（贵宾车）	员工车	小计	
-- declare @time datetime
--set @time=N'2017-08-30 07:36:48.000'
--select a.* from(
--select * from
--(
--select CONVERT(varchar(100),a.in_time,103) 时间,
--(case when d.card_tname is not null then d.card_tname else '其他' end) 类型
--from in_park a 
--left join park_card_make c on a.card_no=c.card_no
--left join card_type d on c.card_type=d.card_tid
--where DATEPART(YEAR,a.in_time)=DATEPART(YEAR,@time) and  DATEPART(MONTH,a.in_time)=DATEPART(MONTH,@time) --and  DATEPART(DAY,a.in_time)=DATEPART(DAY,@time)
----order by a.in_time
--) a
--pivot
--(
--count(a.类型) for a.类型 in (期卡,授权卡,操作员卡,临时卡,时段卡,免费卡,临免卡,贵宾卡,储值卡,一卡通,其他)
--) b)a
--select CONVERT(varchar(100),a.in_time,103) 时间,
--(case when d.card_tname is not null then d.card_tname else '其他' end) 类型
--from in_park a 
--left join park_card_make c on a.card_no=c.card_no
--left join card_type d on c.card_type=d.card_tid
--where DATEPART(YEAR,a.in_time)=DATEPART(YEAR,@time) and  DATEPART(MONTH,a.in_time)=DATEPART(MONTH,@time) --and  DATEPART(DAY,a.in_time)=DATEPART(DAY,@time)
--order by a.in_time