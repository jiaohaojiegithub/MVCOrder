--03�����볡��¼��ѯ							
--���	ͣ�����	���	���ƺ�	�볡ʱ��	�볡ͼ��	�볡��ַ	����Ա
--��ע:���--��λ���������¥��(B1\B2\B3\B4\B5)					
create procedure �����볡��¼��ѯ
as
begin
select ROW_NUMBER() over(order by a.in_time desc) ���, b.card_tname ͣ�����,'' ���,a.carno ���ƺ�,a.in_time �볡ʱ��,a.in_pic �볡ͼ��,c.Name �볡��ַ,a.operator ����Ա
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