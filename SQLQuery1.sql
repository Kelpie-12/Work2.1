use ComopanyProgect; select CommercialRealEstates.IdObjects as [№], 
CommercialRealEstates.Citi as [Город], CommercialRealEstates.Street as [Улица],
CommercialRealEstates.House as [Дом],  TypeObjects.[name] as [Тип недвижимости],
CommercialRealEstates.Area as [Площадь (м)], CommercialRealEstates.Price as [Цена] 
from [Objects],CommercialRealEstates,Manager ,[TypeObjects]  where Manager.LastName='Mordovin'
and [Objects].ManagerId=1 
and CommercialRealEstates.IdObjects=[Objects].Id 
and TypeObjects.id=CommercialRealEstates.ObjectType;