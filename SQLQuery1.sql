use ComopanyProgect;
select count([Time] ) from Manager,Appointments,Client 
where [Appointments].ManagerId=Manager.Id  and ClientId=Client.Id and '2025-01-26'=[Date]