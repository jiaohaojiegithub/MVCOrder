--		����Ա			Զ�̿���		Զ�̹ػ�				Զ�̿�բ		Զ�̹�բ		Զ�̸�λ				����ʱ��				�����⿨	
--11.Զ�̿��Ƽ�¼�ձ���
create procedure Զ�̿��Ƽ�¼�ձ���
@time datetime
as
begin
--declare @time datetime
--set @time=N'2018-03-03 07:36:48.000'
select 
 CONVERT(varchar(100),indt,103) ����,
 operator ����Ա,
 0 Զ�̿���,
 0 Զ�̹ػ�,
 COUNT(operator) Զ�̿�բ,
 0 Զ�̹�բ,
 0 Զ�̸�λ,
 0 ����ʱ��,
 0 �����⿨
from remote_control 
where DATEPART(YEAR,indt)=DATEPART(YEAR,@time) and DATEPART(MONTH,indt)=DATEPART(MONTH,@time) and DATEPART(DAY,indt)=DATEPART(DAY,@time)
group by operator,CONVERT(varchar(100),indt,103)
end

