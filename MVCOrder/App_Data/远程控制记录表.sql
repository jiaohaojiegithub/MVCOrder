--20.Զ�̿��Ƽ�¼��					
--����ʱ��	������Ա	��������	�·���ַ	��־	ͼ��
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


--select * from PA_tboLocal
--select * from PA_tboDevice
--select * from device
--select * from remote_control