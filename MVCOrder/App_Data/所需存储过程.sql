Create PROCEDURE [dbo].[EwmCard]	
AS
BEGIN
	--select (CASE a.sex when '0' then '��' else 'Ů' end) as '�Ա�',a.cust_name as '����',a.cust_nick as '���',a.mobile as '�绰����',b.card_no as '����' from customer a,card_make b where a.cust_no=b.cust_no
	select (CASE a.sex when '0' then '��' else 'Ů' end) as '�Ա�', a.*,b.card_no,b.foregift,b.balance,b.validdt,b.status,b.operator,b.createdt from customer a,card_make b where a.cust_no=b.cust_no
END
go
create procedure [dbo].[ParkingCard]
as
begin
select ROW_NUMBER() over(PARTITION  by a.�û��� ORDER BY a.�û���) as �������,a.*
from (
select a.cust_name as �û���, c.park_stall as ��λ��,
		'' as ���,
		a.cust_no �û����,
		'' as �����,
		b.validdt as ��Ч����,
		(case when b.status= 0 then '����' else 'ʧЧ' end) as ״̬,
		c.carno as ����,
		d.car_tname as ����,
		e.color_tname as ��ɫ,
		f.card_tname as �����,
		b.operator as ����Ա,
		b.createdt as ����ʱ��,
		g.deptName as ����
from dbo.customer a inner join dbo.card_make b on a.cust_no=b.cust_no
	 inner join dbo.park_card_make c on b.cust_no=c.cust_no 
	 left join dbo.car_type d on d.car_tid=c.car_type
	 left join dbo.color_type e on e.color_tid=c.car_color
	 left join dbo.card_type f on f.card_tid=c.card_type
	 left join dbo.kq_dept g on g.deptNo=a.deptNo
	 
) a  order by a.�û��� desc
end
go
create procedure ͣ�����ڱ���
as
begin
 select ROW_NUMBER() over(order by a.���� asc) ���, a.* from (
 select
 a.cust_name �û�����,
e.cust_no �û����,
'' �����,
e.prevdate ԭ��Ч����,
e.currdate ����Ч����,
e.money ������,
e.operator ����Ա,
b.deptName ����,
c.carno ����
from card_delay e left join customer a on e.card_no=a.idcard
 left join kq_dept b on a.deptNo=b.deptNo
 left join park_card_make c on c.card_no=e.card_no 
 ) a 
 end
 go
 create procedure �����볡��¼��ѯ
as
begin
select ROW_NUMBER() over(order by a.in_time desc) ���, b.card_tname ͣ�����,'' ���,a.carno ���ƺ�,a.in_time �볡ʱ��,a.in_pic �볡ͼ��,c.Name �볡��ַ,a.operator ����Ա
from in_park a left join card_type b on b.card_tid=a.card_tid left join PA_tboLocal c on c.SeqNO=a.in_from
end
go
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
create procedure ��λ���������±���
@���� datetime
as
begin
select 
CONVERT(varchar(50),a.�·�)+'��' �·�,
(case when a.�ڿ� is not null then a.�ڿ� else 0 end) ˽�ҳ�,
(case when a.ʱ�ο� is not null then a.ʱ�ο� else 0 end) ���⳵,
(case when a.���⿨ is not null then a.���⿨ else 0 end) ���⳵,
(case when a.����� is not null then a.����� else 0 end) �Żݳ�,
(case when a.��ѿ� is not null then a.��ѿ� else 0 end) Ա����,
(case when a.��ֵ�� is not null then a.��ֵ�� else 0 end)+(case when a.��ʱ�� is not null then a.��ʱ�� else 0 end)+(case when a.ʱ�ο� is not null then a.ʱ�ο� else 0 end) ������,

(case when a.��ֵ�� is not null then a.��ֵ�� else 0 end)+(case when a.��ʱ�� is not null then a.��ʱ�� else 0 end)+(case when a.���⿨ is not null then a.���⿨ else 0 end)
+ (case when a.����� is not null then a.����� else 0 end)+(case when a.��ѿ� is not null then a.��ѿ� else 0 end)
+(case when a.ʱ�ο� is not null then a.ʱ�ο� else 0 end)+(case when a.�ڿ� is not null then a.�ڿ� else 0 end) С��
 from
(
select * from
(
select DATEPART(MONTH,b.createdt) �·�,c.card_tname ����,COUNT(c.card_tname) ����
--(case when b.createdt is not null then CONVERT(varchar(100),b.createdt,121) else '' end) ����,
from park_card_make a 
left join card_make b on a.cust_no=b.cust_no
left join card_type c on c.card_tid=a.card_type
where DATEPART(YEAR,b.createdt)=DATEPART(YEAR,@����)--����
group by c.card_tname,DATEPART(MONTH,b.createdt)
) a
pivot(
sum(a.����) for a.���� in (�ڿ�,��Ȩ��,����Ա��,��ʱ��,ʱ�ο�,��ѿ�,���⿨,�����,��ֵ��,һ��ͨ)
) b
) a
end
go
create procedure ͣ��ע����¼����
as
begin
select ROW_NUMBER() over(order by a.����ʱ�� asc) ���, a.* from (
select (case when b.cust_name is not null then b.cust_name else '' end) �û�����,
(case when c.carno is not null then c.carno else '' end) ����,
a.cust_no �û����,
(case when c.park_stall is not null then c.park_stall else '' end) ��λ��,
'' �����,
e.card_tname �˿���ʽ,
a.foregift Ѻ��,
a.balance ���,
a.retmoney �˻����,
a.operator ����Ա,
a.createdt ����ʱ��,
(case when d.deptName is not null then d.deptName else '' end)  ����
from card_quit a left join customer b on a.card_no=b.idcard
left join kq_dept d on d.deptNo=b.deptNo
left join park_card_make c on a.card_no=c.card_no 
left join card_type e on e.card_tid=a.retmode
) a
end
go
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
go
create procedure ����Ա�շ��ձ���
@time datetime
as
begin
--declare @time datetime
--set @time=N'2017-08-30 07:36:48.000'
select 
a.ʱ�� ����,
a.����Ա,
(case when a.�ڿ� is not null then a.�ڿ� else 0 end) ˽�ҳ�,
(case when a.ʱ�ο� is not null then a.ʱ�ο� else 0 end) ���⳵,
(case when a.��ʱ�� is not null then a.��ʱ�� else 0 end) ʱ�⳵,
(case when a.���⿨ is not null then a.���⿨ else 0 end) ���⳵,
(case when a.����� is not null then a.����� else 0 end) �Żݳ�,
(case when a.��ѿ� is not null then a.��ѿ� else 0 end) Ա����,
 (case when a.���� is not null then a.���� else 0 end) ������,
(case when a.��ѿ� is not null then a.��ѿ� else 0 end)+(case when a.����� is not null then a.����� else 0 end)+
(case when a.�ڿ� is not null then a.�ڿ� else 0 end)+
(case when a.ʱ�ο� is not null then a.ʱ�ο� else 0 end)+
(case when a.��ʱ�� is not null then a.��ʱ�� else 0 end)+
(case when a.���⿨ is not null then a.���⿨ else 0 end)+
(case when a.���� is not null then a.���� else 0 end)
 С�ƽ��  
from(
select * from (
select 
CONVERT(varchar(100),a.out_time,103) ʱ��,
(case when a.operator is not null then a.operator else '' end) ����Ա,
(case when a.money2 is not null then a.money2 else 0 end) ʵ�ս��,
(case when c.card_tname is not null then c.card_tname else '����' end) ����
from out_park a left join park_card_make b on a.card_no=b.card_no
left join card_type c on a.card_tid=c.card_tid
where a.payType='�ֽ�' and DATEPART(YEAR,a.out_time)=DATEPART(YEAR,@time) and DATEPART(MONTH,a.out_time)=DATEPART(MONTH,@time) and DATEPART(DAY,a.out_time)=DATEPART(DAY,@time)
) a
pivot
(
sum(a.ʵ�ս��) for a.���� in (�ڿ�,��Ȩ��,����Ա��,��ʱ��,ʱ�ο�,��ѿ�,���⿨,�����,��ֵ��,һ��ͨ,����)
) b
) a
end
go
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
go
create procedure ��λʹ�����޲�ѯ
as
begin
select ROW_NUMBER() over(order by a.��Ч��) ���,a.*
from (
select 
(case when c.validdt is not null and DATEDIFF(day,GETDATE(),c.validdt)>0 then CONVERT(varchar(100),DATEDIFF(day,GETDATE(),c.validdt))+'��'  else '�ѹ���' end) ʹ������,
(case when a.park_stall is not null then a.park_stall  else '' end) ��λ��,
'' ����,
'' ���,
(case when c.validdt is not null then  CONVERT(varchar(100),c.validdt,121)  else '' end) ��Ч��,
(case when b.cust_name is not null then b.cust_name  else '' end) �û�����,
(case when b.mobile is not null then b.mobile else (CASe when b.phone_no is not null then b.phone_no else '' end ) end) ��ϵ�绰
from park_card_make a left join customer b on a.cust_no=b.cust_no
left join card_make c on a.cust_no=c.cust_no 
) a
end
go
create procedure �������������ձ���
@time datetime
as
begin
--declare @time datetime
--set @time=N'2017-08-30 07:36:48.000'
select 
a.ʱ�� ����,
(case when a.�ڿ� is not null then a.�ڿ� else 0 end) ˽�ҳ�,
(case when a.ʱ�ο� is not null then a.ʱ�ο� else 0 end) ���⳵,
(case when a.��ʱ�� is not null then a.��ʱ�� else 0 end) ʱ�⳵,
(case when a.���⿨ is not null then a.���⿨ else 0 end) ���⳵,
(case when a.����� is not null then a.����� else 0 end) �Żݳ�,
(case when a.��ѿ� is not null then a.��ѿ� else 0 end) Ա����,
 (case when a.���� is not null then a.���� else 0 end) ������,
(case when a.��ѿ� is not null then a.��ѿ� else 0 end)+(case when a.����� is not null then a.����� else 0 end)+
(case when a.�ڿ� is not null then a.�ڿ� else 0 end)+
(case when a.ʱ�ο� is not null then a.ʱ�ο� else 0 end)+
(case when a.��ʱ�� is not null then a.��ʱ�� else 0 end)+
(case when a.���⿨ is not null then a.���⿨ else 0 end)+
(case when a.���� is not null then a.���� else 0 end)
 С��  
from
(
select a.* from (
select * from (
select CONVERT(varchar(100),a.out_time,103) ʱ��,
(case when c.card_tname is not null then c.card_tname else '����' end) ����
from out_park a left join park_card_make b on a.card_no=b.card_no
left join card_type c on b.card_type=c.card_tid 
where DATEPART(YEAR,a.out_time)=DATEPART(YEAR,@time) and  DATEPART(MONTH,a.out_time)=DATEPART(MONTH,@time)
) a
pivot
(
count(a.����) for a.���� in (�ڿ�,��Ȩ��,����Ա��,��ʱ��,ʱ�ο�,��ѿ�,���⿨,�����,��ֵ��,һ��ͨ,����)
) b
)a 
) a order by a.ʱ��
end
go
create procedure �볡�������ձ���
@time datetime 
as
begin
select 
a.ʱ��,
(case when a.�ڿ� is not null then a.�ڿ� else 0 end) ˽�ҳ�,
(case when a.ʱ�ο� is not null then a.ʱ�ο� else 0 end) ���⳵,
(case when a.��ʱ�� is not null then a.��ʱ�� else 0 end) ʱ�⳵,
(case when a.���⿨ is not null then a.���⿨ else 0 end) ���⳵,
(case when a.����� is not null then a.����� else 0 end) �Żݳ�,
(case when a.��ѿ� is not null then a.��ѿ� else 0 end) Ա����,
 (case when a.���� is not null then a.���� else 0 end) ������,
(case when a.��ѿ� is not null then a.��ѿ� else 0 end)+(case when a.����� is not null then a.����� else 0 end)+
(case when a.�ڿ� is not null then a.�ڿ� else 0 end)+
(case when a.ʱ�ο� is not null then a.ʱ�ο� else 0 end)+
(case when a.��ʱ�� is not null then a.��ʱ�� else 0 end)+
(case when a.���⿨ is not null then a.���⿨ else 0 end)+
(case when a.���� is not null then a.���� else 0 end)
 С��  
from
(
select a.* from(
select * from
(
select CONVERT(varchar(100),a.in_time,103) ʱ��,
(case when d.card_tname is not null then d.card_tname else '����' end) ����
from in_park a 
left join park_card_make c on a.card_no=c.card_no
left join card_type d on c.card_type=d.card_tid
where DATEPART(YEAR,a.in_time)=DATEPART(YEAR,@time) and  DATEPART(MONTH,a.in_time)=DATEPART(MONTH,@time) --and  DATEPART(DAY,a.in_time)=DATEPART(DAY,@time)
--order by a.in_time
) a
pivot
(
count(a.����) for a.���� in (�ڿ�,��Ȩ��,����Ա��,��ʱ��,ʱ�ο�,��ѿ�,���⿨,�����,��ֵ��,һ��ͨ,����)
) b)a
) a
end
go
create procedure ˽�ҳ�λ����ͣ��ͳ�Ʊ�
as
begin
select ROW_NUMBER() over(order by a.�û����) ���,a.*
from(
select 
(case when a.park_stall is not null then a.park_stall  else '' end) ��λ��,
(case when b.cust_name is not null then b.cust_name  else '' end) �û�����,
(case when c.card_tname is not null then c.card_tname  else '' end) ͣ�����,
(case when b.cust_nick is not null then b.cust_nick  else '' end) �û����,
(case when a.card_no is not null then a.carno  else '' end) ���ƺ�,
(case when d.balance >0 then '�ѽɷ�'  else 'δ�ɷ�' end) �Ƿ�ɷ�,
(case when d.createdt is not null then CONVERT(varchar(100),d.createdt,121)  else '' end) �ɷ�����,
(case when d.validdt is not null then CONVERT(varchar(100),d.validdt,121)  else '' end) ͣ����Ч��
from park_card_make a left join customer b on a.cust_no=b.cust_no
left join card_type c on a.card_type=c.card_tid 
left join card_make d on d.cust_no=a.cust_no
) a --where a.ͣ�����='�ڿ�' --˽�ҳ�
end
go
create procedure ͣ�����շ��ձ���
@time datetime
as
begin
--declare @time datetime
--set @time=N'2017-08-30 07:36:48.000'
select 
a.ʱ�� ����,
(case when a.�ڿ� is not null then a.�ڿ� else 0 end) ˽�ҳ�,
(case when a.ʱ�ο� is not null then a.ʱ�ο� else 0 end) ���⳵,
(case when a.��ʱ�� is not null then a.��ʱ�� else 0 end) ʱ�⳵,
(case when a.���⿨ is not null then a.���⿨ else 0 end) ���⳵,
(case when a.����� is not null then a.����� else 0 end) �Żݳ�,
(case when a.��ѿ� is not null then a.��ѿ� else 0 end) Ա����,
 (case when a.���� is not null then a.���� else 0 end) ������,
(case when a.��ѿ� is not null then a.��ѿ� else 0 end)+(case when a.����� is not null then a.����� else 0 end)+
(case when a.�ڿ� is not null then a.�ڿ� else 0 end)+
(case when a.ʱ�ο� is not null then a.ʱ�ο� else 0 end)+
(case when a.��ʱ�� is not null then a.��ʱ�� else 0 end)+
(case when a.���⿨ is not null then a.���⿨ else 0 end)+
(case when a.���� is not null then a.���� else 0 end)
 С�ƽ��  
from
(
select a.* from (
select * from (
select CONVERT(varchar(100),a.out_time,103) ʱ��,
(case when a.money2 is not null then a.money2 else 0 end) ʵ�ս��,
(case when c.card_tname is not null then c.card_tname else '����' end) ����
from out_park a left join park_card_make b on a.card_no=b.card_no
left join card_type c on b.card_type=c.card_tid 
where DATEPART(YEAR,a.out_time)=DATEPART(YEAR,@time) and  DATEPART(MONTH,a.out_time)=DATEPART(MONTH,@time)--���շ�
 and DATEPART(DAY,a.out_time)=DATEPART(DAY,@time)--���շ�
) a
pivot
(
sum(a.ʵ�ս��) for a.���� in (�ڿ�,��Ȩ��,����Ա��,��ʱ��,ʱ�ο�,��ѿ�,���⿨,�����,��ֵ��,һ��ͨ,����)
) b
)a 
) a order by a.ʱ��
end
go
create procedure �û�����
as
begin
select ROW_NUMBER() over(order by c.��Ч�� asc) ���,c.*
from(
select
(case when b.park_stall is not null then b.park_stall else '' end) ��λ��,
'' ���,
(case when d.card_tname is not null then d.card_tname else '' end) ͣ�����,
'' �����,
(case when a.cust_name is not null then a.cust_name else '' end)  �û�����, 
(case when a.sex =0 then '��' else 'Ů' end) �Ա�,
(case when a.cust_nick is not null then a.cust_nick else '' end) �û����,
(case when c.validdt is not null then c.validdt else GETDATE() end) ��Ч��,
(case when b.carno is not null then b.carno else '' end) ���ƺ�,
(case when a.mobile is not null then a.mobile else (CASe when a.phone_no is not null then a.phone_no else '' end ) end) ��ϵ�绰,
'' ���֤��,
(case when a.remark is not null then a.remark else '' end) ��ע
from customer a left join park_card_make b on a.cust_no=b.cust_no
left join card_make c on a.cust_no=c.cust_no
left join card_type d on d.card_tid=b.card_type) c

end
go
create procedure Զ�̿��Ƽ�¼��
as
begin
select 
(case when a.indt is not null then CONVERT(varchar(100),a.indt,121) else '' end) ����ʱ��,
(case when a.operator is not null then a.operator else '' end) ������Ա,
(case when a.comm_type is not null then a.comm_type else '' end) ��������,
(case when b.RecogniseIP is not null then b.RecogniseIP else '' end) �·���ַ,
(case when a.flag is not null then (case when a.flag=1 then '�ɹ�' else 'ʧ��' end) else 'δ��Ӧ' end) ��־,
(case when a.picture is not null then a.picture else '' end) ͼ��
from remote_control a left join PA_tboLocal b on a.address=b.passBH
end
go
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
go