create procedure ����������¼��ѯ
as
begin
--select ROW_NUMBER() over(order by )
select e.cust_name ����,c.card_tname ͣ�����,d.car_tname ����,a.carno ����,a.out_pic ����ͼ��,a.in_time �볡ʱ��,a.out_time ����ʱ��,b.Name ��ַ,a.money2 ʵ�ս��,a.operator ����Ա
from out_park a left join PA_tboLocal b on b.SeqNO=a.out_from 
left join card_type c on c.card_tid=a.card_tid
left join car_type d on a.car_tid=d.car_tid
left join customer e on a.card_no=e.idcard
end
go

--select * from out_park
--select * from PA_tboLocal

----04����������¼��ѯ										
----���	����	ͣ����� 	����	����	����ͼ��	�볡ʱ��	����ʱ��	��ַ	ʵ�ս��	����Ա
--select
-- --e.cust_name ����,
-- --c.card_tname ͣ�����,
-- --d.car_tname ����,
-- a.carno ����,
-- a.out_pic ����ͼ��,
-- a.in_time �볡ʱ��,
-- a.out_time ����ʱ��,
-- b.Name ��ַ,
-- a.money2 ʵ�ս��,
-- a.operator ����Ա
--from out_park a left join PA_tboLocal b on a.out_from=b.SeqNO
--inner join card_type c on c.card_tid=a.card_tid
--inner join car_type d on d.car_tid=a.car_tid
--inner join customer e on e.idcard=a.card_no