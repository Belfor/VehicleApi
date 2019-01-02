# VehicleApi

Ejemplo de Api Rest en ASP.NET 

Este ejemplo proporciona un metodo de validacion del Dao VehicleRequest comprobando la correcta composicion del JSON.
La ruta de este metodo se encuentra en **api/vehicle** usando por defecto los verbo http post, este metodo devuelve VehicleResponse con la 
Id del vehiculo enviada en la request y ResultCode con valor 2 en caso de validacion correcta, en el caso devuelve un VehicleId 
0 y un ResultCode 1 que indica que ha la peticion contiene alguna clase de error.

Para probar el servicio se puede hacer uso del POSTMAN.

Un Ejemplo de peticion correcta:
``` 
{
		"vehicleId" : 4,
		"type" : "type",
		"manufacturerNameShort" : "manufacturerNameShort",
		"price" : 1000000000
}
```
JSON devuelto por el servidor:
```
{
    "vehicleId": 4,
    "returnCode": 2
}
```
