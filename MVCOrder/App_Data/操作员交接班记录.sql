create procedure 操作员交接班记录
as
begin
--declare @起始时间 datetime
select (case when Operator1 is not null then Operator1  else '' end) 交班人,
(case when Operator2 is not null then Operator2  else '' end) 接班人,
(case when StartDate is not null then CONVERT(varchar(100),StartDate,121)  else '' end) 上班时间,
(case when EndDate is not null then CONVERT(varchar(100),EndDate,121)  else '' end) 下班时间,
(case when ActualMoney is not null then ActualMoney  else 0 end) 实收金额,
(case when OughttoMoney is not null then OughttoMoney  else 0 end) 应收金额,
(case when StartParkingNums is not null then StartParkingNums  else 0 end) 接班时场内停车,
(case when EndParkingNums is not null then EndParkingNums  else 0 end) 交班时场内停车,
(case when StartTempNums is not null then StartTempNums  else 0 end) 接班时场内临时停车,
(case when EndTempNums is not null then EndTempNums  else 0 end) 交班时场内临时停车,
(case when OutCarNums is not null then OutCarNums  else 0 end) 出场车辆数,
(case when InCarNums is not null then InCarNums  else 0 end) 入场车辆数,
(case when HandOutCarNums is not null then HandOutCarNums  else 0 end) 手工出场车辆数,
(case when HandInCarNums is not null then HandInCarNums  else 0 end) 手工入场车辆数,
(case when FreeCarNums is not null then FreeCarNums  else 0 end) 免费出场车次
from handover order by 下班时间 desc
end
--交班人	接班人	上班时间	下班时间	
--应收金额	实收金额	接班时场内停车	
--交班时场内停车	接班时场内临时停车	
--交班时场内临时停车	出场车辆数	入场车辆数	
--手工出场车辆数	手工入场车辆数	免费出场车次	
--select * from handover
--select * from in_park
--select * from out_park
--select * from parking
