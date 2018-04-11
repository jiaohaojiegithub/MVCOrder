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

--select * from out_park
--select * from PA_tboLocal

----04车辆出场记录查询										
----序号	姓名	停车类别 	车型	车牌	出场图象	入场时间	出场时间	地址	实收金额	操作员
--select
-- --e.cust_name 姓名,
-- --c.card_tname 停车类别,
-- --d.car_tname 车型,
-- a.carno 车牌,
-- a.out_pic 出场图象,
-- a.in_time 入场时间,
-- a.out_time 出场时间,
-- b.Name 地址,
-- a.money2 实收金额,
-- a.operator 操作员
--from out_park a left join PA_tboLocal b on a.out_from=b.SeqNO
--inner join card_type c on c.card_tid=a.card_tid
--inner join car_type d on d.car_tid=a.car_tid
--inner join customer e on e.idcard=a.card_no