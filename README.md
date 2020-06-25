# WEb API implementada con :NET CORE para Logyca

Prueba técnica desarrollador .NET
Desarrolle una API REST que permita operar sobre los modelos especificados a continuación. Los
tipos de datos, son tipos en C#, no tipos SQL.
Tabla Campo Tipo de datos Obligatorio
Enterprise Id Int32 Si
Enterprise Name String Si
Enterprise Nit Int64 No
Enterprise Gln Int64 Si
Code Id Int32 Si
Code Owner Enterprise Si
Code Name String Si
Code Description String No
Se deben ofrecer los métodos POST, PATCH, y GET para cada modificar registros específicos (por id)
en cada una de las entidades. El payload de las peticiones debe ser JSON y las relaciones en el mismo
se deben expresar usando los valores de las llaves foreneas (enteros). Además, deben existir
endpoints para:
 Recuperar todos lo códigos pertenecientes a una empresa usando su id.
 Recuperar todas las empresas
 Recuperar una empresa con un nit especifico y sus códigos asociados.
 Recuperar la información de la empresa dueña de un código, usando el id del código.
Las tecnologías/arquitectura usadas deben ser:
 PostgreSQL
 ASP.NET MVC Core
 Entity Framework Code First (con migraciones)
 Arquitectura por capas con: DAL, BLL, Presentación. 


Cuenta con dos controladores uno para Enterprise y otropara Code con los metodos segun lo solicitado
