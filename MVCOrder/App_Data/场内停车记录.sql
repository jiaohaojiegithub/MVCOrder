--���	ͣ�����	���ƺ�	�볡ʱ��	�볡ͼ��	�볡ͼ��	ռ�ó�λ	�볡����Ա
create procedure ����ͣ����¼
as
begin
select ROW_NUMBER() over(order by a.�볡ʱ�� desc) ���,a.*
from
(
select 
(case when b.card_tname is not null then b.card_tname  else '' end) ͣ�����,
(case when a.carno is not null then a.carno  else '' end) ���ƺ�,
(case when a.in_time is not null then CONVERT(varchar(100),a.in_time,121)  else '' end) �볡ʱ��,
(case when a.in_pic is not null then a.in_pic  else '' end) �볡ͼ��,
(case when c.stall_name is not null then c.stall_name  else '' end) ռ�ó�λ,
(case when a.operator is not null then a.operator  else '' end) �볡����Ա

from parking a left join card_type b on a.card_tid=b.card_tid
left join park_stall c on a.stall_no=c.stall_no
) a
end

--select * from PA_tboLocal
--select * from parking
--select * from park_stall