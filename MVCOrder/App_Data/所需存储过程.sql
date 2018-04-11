Create PROCEDURE [dbo].[EwmCard]	
AS
BEGIN
	--select (CASE a.sex when '0' then '男' else '女' end) as '性别',a.cust_name as '姓名',a.cust_nick as '编号',a.mobile as '电话号码',b.card_no as '卡号' from customer a,card_make b where a.cust_no=b.cust_no
	select (CASE a.sex when '0' then '男' else '女' end) as '性别', a.*,b.card_no,b.foregift,b.balance,b.validdt,b.status,b.operator,b.createdt from customer a,card_make b where a.cust_no=b.cust_no
END
go
create procedure [dbo].[ParkingCard]
as
begin
select ROW_NUMBER() over(PARTITION  by a.用户名 ORDER BY a.用户名) as 车辆编号,a.*
from (
select a.cust_name as 用户名, c.park_stall as 车位号,
		'' as 层别,
		a.cust_no 用户编号,
		'' as 房间号,
		b.validdt as 有效日期,
		(case when b.status= 0 then '正常' else '失效' end) as 状态,
		c.carno as 车牌,
		d.car_tname as 车型,
		e.color_tname as 颜色,
		f.card_tname as 卡类别,
		b.operator as 操作员,
		b.createdt as 操作时间,
		g.deptName as 部门
from dbo.customer a inner join dbo.card_make b on a.cust_no=b.cust_no
	 inner join dbo.park_card_make c on b.cust_no=c.cust_no 
	 left join dbo.car_type d on d.car_tid=c.car_type
	 left join dbo.color_type e on e.color_tid=c.car_color
	 left join dbo.card_type f on f.card_tid=c.card_type
	 left join dbo.kq_dept g on g.deptNo=a.deptNo
	 
) a  order by a.用户名 desc
end
go
create procedure 停车延期报表
as
begin
 select ROW_NUMBER() over(order by a.车牌 asc) 序号, a.* from (
 select
 a.cust_name 用户姓名,
e.cust_no 用户编号,
'' 房间号,
e.prevdate 原有效日期,
e.currdate 现有效日期,
e.money 付款金额,
e.operator 操作员,
b.deptName 部门,
c.carno 车牌
from card_delay e left join customer a on e.card_no=a.idcard
 left join kq_dept b on a.deptNo=b.deptNo
 left join park_card_make c on c.card_no=e.card_no 
 ) a 
 end
 go
 create procedure 车辆入场记录查询
as
begin
select ROW_NUMBER() over(order by a.in_time desc) 序号, b.card_tname 停车类别,'' 层别,a.carno 车牌号,a.in_time 入场时间,a.in_pic 入场图象,c.Name 入场地址,a.operator 操作员
from in_park a left join card_type b on b.card_tid=a.card_tid left join PA_tboLocal c on c.SeqNO=a.in_from
end
go
create procedure 车辆出场记录查询
as
begin
--select ROW_NUMBER() over(order by )
select e.cust_name 姓名,c.card_tname 停车类别,d.car_tname 车型,a.carno 车牌,a.out_pic 出场图象,a.in_time 入场时间,a.out_time 出场时间,b.Name 地址,a.money2 实收金额,a.operator 操作员
from out_park a left join PA_tboLocal b on b.SeqNO=a.out_from 
left join card_type c on c.card_tid=a.card_tid
left join car_type d on a.car_tid=d.car_tid
left join customer e on a.card_no=e.idcard
end
go
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
end
go
create procedure 停车注销记录报表
as
begin
select ROW_NUMBER() over(order by a.操作时间 asc) 序号, a.* from (
select (case when b.cust_name is not null then b.cust_name else '' end) 用户姓名,
(case when c.carno is not null then c.carno else '' end) 车牌,
a.cust_no 用户编号,
(case when c.park_stall is not null then c.park_stall else '' end) 车位号,
'' 房间号,
e.card_tname 退卡方式,
a.foregift 押金,
a.balance 余额,
a.retmoney 退还金额,
a.operator 操作员,
a.createdt 操作时间,
(case when d.deptName is not null then d.deptName else '' end)  部门
from card_quit a left join customer b on a.card_no=b.idcard
left join kq_dept d on d.deptNo=b.deptNo
left join park_card_make c on a.card_no=c.card_no 
left join card_type e on e.card_tid=a.retmode
) a
end
go
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
go
create procedure 操作员收费日报表
@time datetime
as
begin
--declare @time datetime
--set @time=N'2017-08-30 07:36:48.000'
select 
a.时间 日期,
a.操作员,
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
from(
select * from (
select 
CONVERT(varchar(100),a.out_time,103) 时间,
(case when a.operator is not null then a.operator else '' end) 操作员,
(case when a.money2 is not null then a.money2 else 0 end) 实收金额,
(case when c.card_tname is not null then c.card_tname else '其他' end) 类型
from out_park a left join park_card_make b on a.card_no=b.card_no
left join card_type c on a.card_tid=c.card_tid
where a.payType='现金' and DATEPART(YEAR,a.out_time)=DATEPART(YEAR,@time) and DATEPART(MONTH,a.out_time)=DATEPART(MONTH,@time) and DATEPART(DAY,a.out_time)=DATEPART(DAY,@time)
) a
pivot
(
sum(a.实收金额) for a.类型 in (期卡,授权卡,操作员卡,临时卡,时段卡,免费卡,临免卡,贵宾卡,储值卡,一卡通,其他)
) b
) a
end
go
create procedure 场内停车记录
as
begin
select ROW_NUMBER() over(order by a.入场时间 desc) 序号,a.*
from
(
select 
(case when b.card_tname is not null then b.card_tname  else '' end) 停车类别,
(case when a.carno is not null then a.carno  else '' end) 车牌号,
(case when a.in_time is not null then CONVERT(varchar(100),a.in_time,121)  else '' end) 入场时间,
(case when a.in_pic is not null then a.in_pic  else '' end) 入场图象,
(case when c.stall_name is not null then c.stall_name  else '' end) 占用车位,
(case when a.operator is not null then a.operator  else '' end) 入场操作员

from parking a left join card_type b on a.card_tid=b.card_tid
left join park_stall c on a.stall_no=c.stall_no
) a
end
go
create procedure 车位使用期限查询
as
begin
select ROW_NUMBER() over(order by a.有效期) 序号,a.*
from (
select 
(case when c.validdt is not null and DATEDIFF(day,GETDATE(),c.validdt)>0 then CONVERT(varchar(100),DATEDIFF(day,GETDATE(),c.validdt))+'天'  else '已过期' end) 使用期限,
(case when a.park_stall is not null then a.park_stall  else '' end) 车位号,
'' 房号,
'' 层别,
(case when c.validdt is not null then  CONVERT(varchar(100),c.validdt,121)  else '' end) 有效期,
(case when b.cust_name is not null then b.cust_name  else '' end) 用户姓名,
(case when b.mobile is not null then b.mobile else (CASe when b.phone_no is not null then b.phone_no else '' end ) end) 联系电话
from park_card_make a left join customer b on a.cust_no=b.cust_no
left join card_make c on a.cust_no=c.cust_no 
) a
end
go
create procedure 出场车辆流量日报表
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
 小计  
from
(
select a.* from (
select * from (
select CONVERT(varchar(100),a.out_time,103) 时间,
(case when c.card_tname is not null then c.card_tname else '其他' end) 类型
from out_park a left join park_card_make b on a.card_no=b.card_no
left join card_type c on b.card_type=c.card_tid 
where DATEPART(YEAR,a.out_time)=DATEPART(YEAR,@time) and  DATEPART(MONTH,a.out_time)=DATEPART(MONTH,@time)
) a
pivot
(
count(a.类型) for a.类型 in (期卡,授权卡,操作员卡,临时卡,时段卡,免费卡,临免卡,贵宾卡,储值卡,一卡通,其他)
) b
)a 
) a order by a.时间
end
go
create procedure 入场车流量日报表
@time datetime 
as
begin
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
go
create procedure 私家车位车辆停放统计表
as
begin
select ROW_NUMBER() over(order by a.用户编号) 序号,a.*
from(
select 
(case when a.park_stall is not null then a.park_stall  else '' end) 车位号,
(case when b.cust_name is not null then b.cust_name  else '' end) 用户姓名,
(case when c.card_tname is not null then c.card_tname  else '' end) 停车类别,
(case when b.cust_nick is not null then b.cust_nick  else '' end) 用户编号,
(case when a.card_no is not null then a.carno  else '' end) 车牌号,
(case when d.balance >0 then '已缴费'  else '未缴费' end) 是否缴费,
(case when d.createdt is not null then CONVERT(varchar(100),d.createdt,121)  else '' end) 缴费日期,
(case when d.validdt is not null then CONVERT(varchar(100),d.validdt,121)  else '' end) 停车有效期
from park_card_make a left join customer b on a.cust_no=b.cust_no
left join card_type c on a.card_type=c.card_tid 
left join card_make d on d.cust_no=a.cust_no
) a --where a.停车类别='期卡' --私家车
end
go
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
go
create procedure 用户资料
as
begin
select ROW_NUMBER() over(order by c.有效期 asc) 序号,c.*
from(
select
(case when b.park_stall is not null then b.park_stall else '' end) 车位号,
'' 层别,
(case when d.card_tname is not null then d.card_tname else '' end) 停车类别,
'' 房间号,
(case when a.cust_name is not null then a.cust_name else '' end)  用户姓名, 
(case when a.sex =0 then '男' else '女' end) 性别,
(case when a.cust_nick is not null then a.cust_nick else '' end) 用户编号,
(case when c.validdt is not null then c.validdt else GETDATE() end) 有效期,
(case when b.carno is not null then b.carno else '' end) 车牌号,
(case when a.mobile is not null then a.mobile else (CASe when a.phone_no is not null then a.phone_no else '' end ) end) 联系电话,
'' 身份证号,
(case when a.remark is not null then a.remark else '' end) 备注
from customer a left join park_card_make b on a.cust_no=b.cust_no
left join card_make c on a.cust_no=c.cust_no
left join card_type d on d.card_tid=b.card_type) c

end
go
create procedure 远程控制记录表
as
begin
select 
(case when a.indt is not null then CONVERT(varchar(100),a.indt,121) else '' end) 操作时间,
(case when a.operator is not null then a.operator else '' end) 操作人员,
(case when a.comm_type is not null then a.comm_type else '' end) 命令类型,
(case when b.RecogniseIP is not null then b.RecogniseIP else '' end) 下发地址,
(case when a.flag is not null then (case when a.flag=1 then '成功' else '失败' end) else '未响应' end) 标志,
(case when a.picture is not null then a.picture else '' end) 图象
from remote_control a left join PA_tboLocal b on a.address=b.passBH
end
go
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
go