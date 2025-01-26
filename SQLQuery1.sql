use ComopanyProgect;
select [Objects].Id as [№],[Objects].Photo as [Фотo],  Manager.LastName as [Менеджер],
[Objects].[Text] as [Описание], [Objects].AddressCiti as [Город],[Objects].AddressStreet as [Улица],
[Objects].AddressNumberHouse as [Дом],
[Objects].AdressNumberFlat as [Квартира] 
from Manager,[Objects] where [Objects].ManagerId=Manager.Id ;
