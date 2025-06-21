
# UAPI

**UsuariosAPI** "UAPI" es una API construida con .NET 7 que permite gestionar usuarios mediante operaciones CRUD (crear, leer, actualizar y eliminar). El proyecto está pensado para ser simple, claro y fácil de probar.

## ¿Qué incluye?

* CRUD completo de usuarios, con todas las operaciones básicas listas para usar.
* Base de datos en memoria, ideal para desarrollo o pruebas rápidas sin necesidad de configurar una base externa.
* AutoMapper, que se encarga de mapear automáticamente las entidades a DTOs y viceversa.
* Documentación integrada con Swagger, para que puedas explorar y probar los endpoints desde el navegador.

## Estructura del proyecto

La organización del código está pensada para mantener todo claro y separado por responsabilidades:

* `Controllers`: Manejan las rutas y peticiones de la API.
* `DTOs`: Objetos usados para enviar y recibir datos, sin exponer directamente el modelo.
* `Models`: Entidades que representan los datos reales.
* `Services`: Contienen la lógica de negocio principal.
* `Data`: Configuración y contexto de la base de datos.
* `Profiles`: Perfiles de mapeo configurados para AutoMapper.

## ¿Cómo ejecutarlo?

Asegurate de tener instalado .NET 7 en tu máquina. Luego, desde la raíz del proyecto, ejecuta el siguiente comando:

```
dotnet run
```

Con eso, la API quedará levantada y lista para usarse en tu entorno local.
