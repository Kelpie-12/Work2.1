use ComopanyProgect; 
select Client.Id as [№],Client.FirstName as[Имя], Client.LastName as [Фамилия],
Manager.LastName as [Менеджер], Client.TelNumber as [Телефон] 
from Client,Manager 
where Client.Manager=Manager.Id and ( Client.FirstName like 'I'+'%')