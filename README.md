# ProductosAPI

API RESTful para gestionar productos (CRUD). Datos en memoria (demo).

## Comenzando 🚀

Requisitos: [.NET SDK](https://dotnet.microsoft.com/download).

Instalación:

1.  Clonar: `Repositorio/ `cd ProductosAPI`
2.  Restaurar dependencias: `dotnet restore`
3.  Ejecutar: `dotnet run` (API en `http://localhost:5125`)

Ejemplo (obtener productos): `curl http://localhost:5125/api/Productos`

## Endpoints ⚙️

* `GET /api/Productos`: Lista todos los productos.
* `GET /api/Productos/{id}`: Detalle de un producto.
* `POST /api/Productos`: Crear producto 
* `PUT /api/Productos/{id}`: Actualizar producto 
* `DELETE /api/Productos/{id}`: Eliminar producto.

## Construido con 🛠️

* [C#](https://learn.microsoft.com/en-us/dotnet/csharp/)
* [.NET SDK](https://dotnet.microsoft.com/download)
* [ASP.NET Core](https://learn.microsoft.com/en-us/aspnet/core/?view=aspnetcore-8.0)

## Autor ✒️

[KENIER] - (https://https://github.com/KenierOS)
