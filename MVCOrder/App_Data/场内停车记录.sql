--序号	停车类别	车牌号	入场时间	入场图象	入场图象	占用车位	入场操作员
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

--select * from PA_tboLocal
--select * from parking
--select * from park_stall