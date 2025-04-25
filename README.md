# Proyecto C# - policyApi

Proyecto de Cristopher Rivera

## Requisitos

- **Base de datos local de SQLEXPRESS** con autenticaci�n de Windows.
  - **Server Name**: `localhost\SQLEXPRESS`
  - **Nombre de la base de datos**: `policyDB`

## Instalaci�n

1. **Clonar el repositorio**:
   - Abre una terminal y ejecuta el siguiente comando:

     ```bash
     git clone https://github.com/cariveracerdas/policyApi.git
     ```

2. **Acceder a la carpeta del proyecto**:
   - Navega hasta la carpeta donde clonaste el repositorio:

     ```bash
     cd policyApi
     ```

3. **Restaurar las dependencias**:
   - Aseg�rate de restaurar las dependencias antes de ejecutar el proyecto:

     ```bash
     dotnet restore
     ```

4. **Ejecutar el proyecto**:
   - Para iniciar la aplicaci�n, ejecuta el siguiente comando:

     ```bash
     dotnet run --launch-profile "https"
     ```

