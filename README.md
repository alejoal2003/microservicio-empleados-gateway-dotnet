# Microservicio Empleados y API Gateway (.NET 10)

Este proyecto implementa una arquitectura de microservicios en .NET 10, compuesta por:

- **ApiGateway**: Encargado de la autenticación JWT y de enrutar todas las peticiones hacia los microservicios.
- **ApiEmpleado**: Microservicio CRUD para la gestión de empleados.

## Estructura

```
TallerMicroservicios/
├── ApiGateway/      # API Gateway con Ocelot y autenticación JWT
├── ApiEmpleado/    # Microservicio CRUD de empleados
└── TallerMicroservicios.sln
```

## Ejecución

1. Abre dos terminales en la carpeta `TallerMicroservicios`.
2. Ejecuta:
   ```sh
   cd ApiEmpleado
   dotnet run
   ```
   y en la otra terminal:
   ```sh
   cd ApiGateway
   dotnet run
   ```

## Pruebas

- **Swagger ApiGateway:** [http://localhost:5080/swagger](http://localhost:5080/swagger)
- **Swagger ApiEmpleado:** [http://localhost:5084/swagger](http://localhost:5084/swagger)

### Flujo de autenticación y consumo
1. Realiza login en `/api/auth/login` (ApiGateway) para obtener un token JWT.
2. Usa el token para consumir los endpoints `/gateway/empleados` (crear, listar, etc.)

## Capturas sugeridas
- Estructura del proyecto en VS Code
- Swagger de ApiGateway y ApiEmpleado
- Login en Postman (token JWT)
- Crear y listar empleados por Gateway
- Acceso denegado sin token

## Autor
- Alejandro Alvarez

---

**Nombre sugerido para el repositorio:** `microservicio-empleados-gateway-dotnet`