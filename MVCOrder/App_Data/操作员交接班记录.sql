create procedure ����Ա���Ӱ��¼
as
begin
--declare @��ʼʱ�� datetime
select (case when Operator1 is not null then Operator1  else '' end) ������,
(case when Operator2 is not null then Operator2  else '' end) �Ӱ���,
(case when StartDate is not null then CONVERT(varchar(100),StartDate,121)  else '' end) �ϰ�ʱ��,
(case when EndDate is not null then CONVERT(varchar(100),EndDate,121)  else '' end) �°�ʱ��,
(case when ActualMoney is not null then ActualMoney  else 0 end) ʵ�ս��,
(case when OughttoMoney is not null then OughttoMoney  else 0 end) Ӧ�ս��,
(case when StartParkingNums is not null then StartParkingNums  else 0 end) �Ӱ�ʱ����ͣ��,
(case when EndParkingNums is not null then EndParkingNums  else 0 end) ����ʱ����ͣ��,
(case when StartTempNums is not null then StartTempNums  else 0 end) �Ӱ�ʱ������ʱͣ��,
(case when EndTempNums is not null then EndTempNums  else 0 end) ����ʱ������ʱͣ��,
(case when OutCarNums is not null then OutCarNums  else 0 end) ����������,
(case when InCarNums is not null then InCarNums  else 0 end) �볡������,
(case when HandOutCarNums is not null then HandOutCarNums  else 0 end) �ֹ�����������,
(case when HandInCarNums is not null then HandInCarNums  else 0 end) �ֹ��볡������,
(case when FreeCarNums is not null then FreeCarNums  else 0 end) ��ѳ�������
from handover order by �°�ʱ�� desc
end
--������	�Ӱ���	�ϰ�ʱ��	�°�ʱ��	
--Ӧ�ս��	ʵ�ս��	�Ӱ�ʱ����ͣ��	
--����ʱ����ͣ��	�Ӱ�ʱ������ʱͣ��	
--����ʱ������ʱͣ��	����������	�볡������	
--�ֹ�����������	�ֹ��볡������	��ѳ�������	
--select * from handover
--select * from in_park
--select * from out_park
--select * from parking
