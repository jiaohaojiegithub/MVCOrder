--03车辆入场记录查询							
--序号	停车类别	层别	车牌号	入场时间	入场图象	入场地址	操作员
--备注:层别--车位所处车库的楼层(B1\B2\B3\B4\B5)					
create procedure 车辆入场记录查询
as
begin
select ROW_NUMBER() over(order by a.in_time desc) 序号, b.card_tname 停车类别,'' 层别,a.carno 车牌号,a.in_time 入场时间,a.in_pic 入场图象,c.Name 入场地址,a.operator 操作员
from in_park a left join card_type b on b.card_tid=a.card_tid left join PA_tboLocal c on c.SeqNO=a.in_from
end
go

--select * from park
--select * from park_stall
--select * from in_park
--select * from PA_tboLocal
--select *
--from in_park a inner join card_type b on b.card_tid=a.card_tid left join PA_tboLocal c on c.SeqNO=a.in_from
--select *
--from out_park a inner join card_type b on b.card_tid=a.card_tid left join PA_tboLocal c on c.SeqNO=a.out_from