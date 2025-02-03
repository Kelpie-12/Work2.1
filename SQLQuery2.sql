use ComopanyProgect; 
select [Objects].Id as [№],[Objects].Photo as [Фотo], 
Manager.LastName as [Менеджер], [Objects].[Text] as [Описание],
[Objects].AddressCiti as [Город],[Objects].AddressStreet as [Улица],
[Objects].AddressNumberHouse as [Дом],
[Objects].AdressNumberFlat as [Квартира] 
from Manager,[Objects] where Manager.id=[Objects].ManagerId and 
[Objects].AddressCiti like 'Сар' + '%' or [Objects].AddressStreet like'Сар' + '%'-- or [Objects].Id like @Id + '%';