--		操作员			远程开机		远程关机				远程开闸		远程关闸		远程复位				出临时卡				出临免卡	
--11.远程控制记录日报表
create procedure 远程控制记录日报表
@time datetime
as
begin
--declare @time datetime
--set @time=N'2018-03-03 07:36:48.000'
select 
 CONVERT(varchar(100),indt,103) 日期,
 operator 操作员,
 0 远程开机,
 0 远程关机,
 COUNT(operator) 远程开闸,
 0 远程关闸,
 0 远程复位,
 0 出临时卡,
 0 出临免卡
from remote_control 
where DATEPART(YEAR,indt)=DATEPART(YEAR,@time) and DATEPART(MONTH,indt)=DATEPART(MONTH,@time) and DATEPART(DAY,indt)=DATEPART(DAY,@time)
group by operator,CONVERT(varchar(100),indt,103)
end

