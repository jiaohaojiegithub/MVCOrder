--05停车场收费日报表
--时间	私家车位 月租停车	时租停车 临免停车 优惠停车（贵宾停车）	员工停车	其他停车	
create procedure 停车场收费日报表
@time datetime
as
begin
--declare @time datetime
--set @time=N'2017-08-30 07:36:48.000'
select 
a.时间 日期,
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
 小计金额  
from
(
select a.* from (
select * from (
select CONVERT(varchar(100),a.out_time,103) 时间,
(case when a.money2 is not null then a.money2 else 0 end) 实收金额,
(case when c.card_tname is not null then c.card_tname else '其他' end) 类型
from out_park a left join park_card_make b on a.card_no=b.card_no
left join card_type c on b.card_type=c.card_tid 
where DATEPART(YEAR,a.out_time)=DATEPART(YEAR,@time) and  DATEPART(MONTH,a.out_time)=DATEPART(MONTH,@time)--月收费
 and DATEPART(DAY,a.out_time)=DATEPART(DAY,@time)--日收费
) a
pivot
(
sum(a.实收金额) for a.类型 in (期卡,授权卡,操作员卡,临时卡,时段卡,免费卡,临免卡,贵宾卡,储值卡,一卡通,其他)
) b
)a 
) a order by a.时间
end

--select * from card_type
--declare @time datetime
--set @time=N'2017-08-21 07:36:48.000'
--select SUM(money2) 金额 from out_park where DATEPART(YEAR,out_time)=DATEPART(YEAR,@time) and DATEPART(MONTH,out_time)=DATEPART(MONTH,@time) and DATEPART(DAY,out_time)=DATEPART(DAY,@time)