--20.远程控制记录表					
--操作时间	操作人员	命令类型	下发地址	标志	图象
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


--select * from PA_tboLocal
--select * from PA_tboDevice
--select * from device
--select * from remote_control