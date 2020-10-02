# BlazorPlatzi
Proyecto en Net Core con Blazor - Curso de Platzi

Blazor Server- client type

en el archivo de _imports.razor se agragan los nameSpaces globales para los archivos .razor. En MVC se rea los imports para las Views.



Migraciones ET -->
desde la consola de Package Manager Console, seleccionar el proyecto donde se va a guardar los acrchivos de migraciones.
1. Instalar el EntityFrameworkCore.Tools
2. Add-Migrations --> comando que crea los archivos de la migración.
3. Update-Datebase --> comando que ejecuta los archivos de la migracion para crear las tablas.
4. Add-Migration AddData --> Comando para crear los scripts de los inserts de la data que se colocaron en la sobreescritura de OnModelCreating.
                             (Si se hace este comando, debemos ejecutar el comando de Update-Database, para ejecurtar los scripts de DML)

